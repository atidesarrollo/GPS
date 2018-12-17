using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace GPS
{
    public class clsRutas
    {
        public int idRuta { get; set; }
        public string Ruta { get; set; }
        public string Color { get; set; }

        public static List<clsRutas> ObtenerRutas()
        {
            List<clsRutas> ListRuta = new List<clsRutas>();
            clsRutas R = new clsRutas();
            R.idRuta = 0;
            R.Ruta = "Todas";
            ListRuta.Add(R);

            R = new clsRutas();
            R.idRuta = 1;
            R.Ruta = "CHS";
            ListRuta.Add(R);

            R = new clsRutas();
            R.idRuta = 2;
            R.Ruta = "COL";
            ListRuta.Add(R);
            return ListRuta;
        }        
    }

    public class clsPuntosRutas : clsRutas
    {
        public double Latitud { get; set; }
        public double Longitud { get; set; }
        public DateTime Fecha { get; set; }

        public static List<clsPuntosRutas> ObtenerPuntos(int Ruta, DateTime Inicio, DateTime Fin)
        {
            List<clsPuntosRutas> PuntosCoordenadas = new List<clsPuntosRutas>();
            clsPuntosRutas PuntosRuta = new clsPuntosRutas();
            PuntosRuta.idRuta = 1;
            PuntosRuta.Ruta = "CHS";
            PuntosRuta.Color = "Black";
            PuntosRuta.Latitud = 16.75726823;
            PuntosRuta.Longitud = -93.16458862;
            PuntosRuta.Fecha = Convert.ToDateTime("2018-07-12 13:14:59");
            PuntosCoordenadas.Add(PuntosRuta);

            PuntosRuta = new clsPuntosRutas();
            PuntosRuta.idRuta = 1;
            PuntosRuta.Ruta = "CHS";
            PuntosRuta.Color = "Black";
            PuntosRuta.Latitud = 16.75531760;
            PuntosRuta.Longitud = -93.14977169;
            PuntosRuta.Fecha = Convert.ToDateTime("2018-07-12 13:17:01");
            PuntosCoordenadas.Add(PuntosRuta);

            PuntosRuta = new clsPuntosRutas();
            PuntosRuta.idRuta = 2;
            PuntosRuta.Ruta = "COL";
            PuntosRuta.Color = "Purple";
            PuntosRuta.Latitud = 19.385206519858617;
            PuntosRuta.Longitud = -104.06430555087915;
            PuntosRuta.Fecha = Convert.ToDateTime("2018-10-12 18:24:15");
            PuntosCoordenadas.Add(PuntosRuta);

            PuntosRuta = new clsPuntosRutas();
            PuntosRuta.idRuta = 2;
            PuntosRuta.Ruta = "COL";
            PuntosRuta.Color = "Purple";
            PuntosRuta.Latitud = 19.412368969164046;
            PuntosRuta.Longitud = -104.0372893972707;
            PuntosRuta.Fecha = Convert.ToDateTime("2018-10-12 18:32:10");
            PuntosCoordenadas.Add(PuntosRuta);

            return PuntosCoordenadas;
        }
    }
}
