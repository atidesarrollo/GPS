using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Net;
using System.Windows.Forms;

namespace GPS
{
    public partial class frmPrincipal : Form
    {
        int TotalRutas = 0, dias;
        string Titulo;
        double Latitud, Longitud;

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            gmaps.Overlays.Clear();
            ConfigurarMaps();
            UbicarDefault();
            CargarInformacion();
        }

        private bool ValidarConexion()
        {
            Uri Url = new Uri("http://www.google.com/");
            WebRequest Request = WebRequest.Create(Url);
            WebResponse Response;
            try
            {
                Response = Request.GetResponse();
                Response.Close();
                return true;
            }
            catch { return false; }
        }

        private void ConfigurarMaps()
        {
            if (ValidarConexion())
            {
                GMaps.Instance.Mode = AccessMode.ServerOnly;
                GMapProvider.Language = LanguageType.Spanish;
                gmaps.MapProvider = GMapProviders.GoogleMap;
                gmaps.Dock = DockStyle.Fill;
                gmaps.ShowCenter = false;
            }
            else
                MessageBox.Show("No se ha podido establecer conexión a Internet.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void UbicarDefault()
        {
            Titulo = "Actual";
            Latitud = 16.757311;
            Longitud = -93.164511;
            gmaps.Position = new PointLatLng(Latitud, Longitud);

            Cursor.Current = Cursors.WaitCursor;
            GMapOverlay overlay = new GMapOverlay("Marcadores");
            PointLatLng PositionCurrent = new PointLatLng(gmaps.Position.Lat, gmaps.Position.Lng);
            GMarkerGoogle PointMarker = new GMarkerGoogle(PositionCurrent, GMarkerGoogleType.red);

            PointMarker.ToolTipText = Titulo;
            PointMarker.ToolTipMode = MarkerTooltipMode.Always;
            PointMarker.ToolTip.Foreground = Brushes.Black;
            PointMarker.ToolTip.Stroke = Pens.Black;
            PointMarker.ToolTip.TextPadding = new Size(10, 10);

            overlay.Markers.Add(PointMarker);
            gmaps.Overlays.Add(overlay);
            gmaps.DragButton = MouseButtons.Left;
            Cursor.Current = Cursors.Hand;

            txtLatitud.Text = Latitud.ToString();
            txtLongitud.Text = Longitud.ToString();
        }

        private void CargarInformacion()
        {
            List<clsRutas> Rutas = clsRutas.ObtenerRutas();
            TotalRutas = Rutas.Count;
            foreach (clsRutas aux in Rutas)
            {
                cbxRutas.Items.Add(aux.Ruta);
            }
            cbxRutas.SelectedIndex = -1;
        }

        private void gmaps_OnMarkerClick(GMapMarker item, MouseEventArgs e)
        {
            item.ToolTipText = "Coordenadas (" + gmaps.Position.Lat + ", " + gmaps.Position.Lng + ")";
            item.ToolTipMode = MarkerTooltipMode.Always;
            item.ToolTip.Foreground = Brushes.Black;
            item.ToolTip.Stroke = Pens.Black;
            item.ToolTip.TextPadding = new Size(10, 10);
        }

        private void gmaps_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Cursor.Current = Cursors.WaitCursor;

                GMapOverlay overlay = new GMapOverlay("MarcadorActual");
                PointLatLng LatLong = gmaps.FromLocalToLatLng(e.X, e.Y);
                GMarkerGoogle Marcar = new GMarkerGoogle(LatLong, GMarkerGoogleType.red_pushpin);

                Marcar.ToolTipText = "Punto Nuevo";
                Marcar.ToolTipMode = MarkerTooltipMode.Always;
                Marcar.ToolTip.Foreground = Brushes.Black;
                Marcar.ToolTip.Stroke = Pens.Black;
                Marcar.ToolTip.TextPadding = new Size(10, 10);

                gmaps.MarkersEnabled = false;
                overlay.Markers.Clear();
                gmaps.Overlays.Clear();
                overlay.Markers.Add(Marcar);
                gmaps.Overlays.Add(overlay);
                gmaps.DragButton = MouseButtons.Left;
                gmaps.MarkersEnabled = true;
                Cursor.Current = Cursors.Hand;

                txtLatitud.Text = LatLong.Lat.ToString();
                txtLongitud.Text = LatLong.Lng.ToString();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (cbxRutas.SelectedIndex >= 0)
            {
                int Ruta = cbxRutas.SelectedIndex;
                DateTime Inicio = dtFechaInicio.Value;
                DateTime Fin = dtFechaFin.Value;
                Fin = Fin.AddDays(1);

                List<clsPuntosRutas> Puntos = clsPuntosRutas.ObtenerPuntos(Ruta, Inicio, Fin);
                GenerarRuta(Puntos);
            }
            else MessageBox.Show("Seleccione una ruta...", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void GenerarRuta(List<clsPuntosRutas> Puntos)
        {
            GMapOverlay Rutas = new GMapOverlay("Rutas");
            List<PointLatLng> PointsRouts = new List<PointLatLng>();

            int PuntoInicial = 0;
            string RutaAnterior = "", ColorRuta = "";
            gmaps.Overlays.Clear();
            for (int i = 1; i <= Puntos.Count; i++)
            {
                if (PuntoInicial == 0)
                {
                    PuntoInicial = Puntos[i - 1].idRuta;
                    RutaAnterior = Puntos[i - 1].Ruta;
                    ColorRuta = Puntos[i - 1].Color;
                }

                if (PuntoInicial == Puntos[i - 1].idRuta)
                {
                    PointsRouts.Add(new PointLatLng(Puntos[i - 1].Latitud, Puntos[i - 1].Longitud));
                    PointLatLng PositionCurrent = new PointLatLng(Puntos[i - 1].Latitud, Puntos[i - 1].Longitud);
                    GMarkerGoogle PointMarker = new GMarkerGoogle(PositionCurrent, GMarkerGoogleType.red);

                    PointMarker.ToolTipText = "Punto " + i;
                    PointMarker.ToolTipMode = MarkerTooltipMode.Always;
                    PointMarker.ToolTip.Foreground = Brushes.Black;
                    PointMarker.ToolTip.Stroke = Pens.Black;
                    PointMarker.ToolTip.TextPadding = new Size(10, 10);
                    Rutas.Markers.Add(PointMarker);
                }
                else
                {
                    GMapRoute Ruta = new GMapRoute(PointsRouts, "Venta en Ruta de " + RutaAnterior);

                    Ruta.Stroke = new Pen(Color.FromName(ColorRuta), 3);
                    Rutas.Routes.Add(Ruta);

                    PointsRouts.Clear();
                    RutaAnterior = Puntos[i - 1].Ruta;
                    PuntoInicial = Puntos[i - 1].idRuta;
                    ColorRuta = Puntos[i - 1].Color;
                    PointsRouts.Add(new PointLatLng(Puntos[i - 1].Latitud, Puntos[i - 1].Longitud));
                    PointLatLng PositionCurrent = new PointLatLng(Puntos[i - 1].Latitud, Puntos[i - 1].Longitud);
                    GMarkerGoogle PointMarker = new GMarkerGoogle(PositionCurrent, GMarkerGoogleType.red);

                    PointMarker.ToolTipText = "Punto " + i;
                    PointMarker.ToolTipMode = MarkerTooltipMode.Always;
                    PointMarker.ToolTip.Foreground = Brushes.Black;
                    PointMarker.ToolTip.Stroke = Pens.Black;
                    PointMarker.ToolTip.TextPadding = new Size(10, 10);
                    Rutas.Markers.Add(PointMarker);
                }

                if (i == Puntos.Count)
                {
                    GMapRoute Ruta = new GMapRoute(PointsRouts, "Venta en Ruta de " + RutaAnterior);

                    Ruta.Stroke = new Pen(Color.FromName(ColorRuta), 3);
                    Rutas.Routes.Add(Ruta);
                }
            }
            gmaps.Overlays.Add(Rutas);
        }
    }
}
