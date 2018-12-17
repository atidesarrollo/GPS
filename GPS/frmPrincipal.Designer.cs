namespace GPS
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbxBusqueda = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.cbxRutas = new System.Windows.Forms.ComboBox();
            this.lblRutas = new System.Windows.Forms.Label();
            this.gbxFechas = new System.Windows.Forms.GroupBox();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.dtFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.dtFechaFin = new System.Windows.Forms.DateTimePicker();
            this.txtLongitud = new System.Windows.Forms.TextBox();
            this.lblLongitud = new System.Windows.Forms.Label();
            this.txtLatitud = new System.Windows.Forms.TextBox();
            this.lblLatitud = new System.Windows.Forms.Label();
            this.gbxMapa = new System.Windows.Forms.GroupBox();
            this.gmaps = new GMap.NET.WindowsForms.GMapControl();
            this.gbxBusqueda.SuspendLayout();
            this.gbxFechas.SuspendLayout();
            this.gbxMapa.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxBusqueda
            // 
            this.gbxBusqueda.Controls.Add(this.btnBuscar);
            this.gbxBusqueda.Controls.Add(this.cbxRutas);
            this.gbxBusqueda.Controls.Add(this.lblRutas);
            this.gbxBusqueda.Controls.Add(this.gbxFechas);
            this.gbxBusqueda.Controls.Add(this.txtLongitud);
            this.gbxBusqueda.Controls.Add(this.lblLongitud);
            this.gbxBusqueda.Controls.Add(this.txtLatitud);
            this.gbxBusqueda.Controls.Add(this.lblLatitud);
            this.gbxBusqueda.Location = new System.Drawing.Point(2, 12);
            this.gbxBusqueda.Name = "gbxBusqueda";
            this.gbxBusqueda.Size = new System.Drawing.Size(999, 68);
            this.gbxBusqueda.TabIndex = 1;
            this.gbxBusqueda.TabStop = false;
            this.gbxBusqueda.Text = "Búsqueda";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(677, 32);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 12;
            this.btnBuscar.Text = "&Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // cbxRutas
            // 
            this.cbxRutas.BackColor = System.Drawing.SystemColors.Control;
            this.cbxRutas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxRutas.FormattingEnabled = true;
            this.cbxRutas.Location = new System.Drawing.Point(55, 16);
            this.cbxRutas.Name = "cbxRutas";
            this.cbxRutas.Size = new System.Drawing.Size(135, 21);
            this.cbxRutas.TabIndex = 11;
            // 
            // lblRutas
            // 
            this.lblRutas.AutoSize = true;
            this.lblRutas.Location = new System.Drawing.Point(16, 20);
            this.lblRutas.Name = "lblRutas";
            this.lblRutas.Size = new System.Drawing.Size(33, 13);
            this.lblRutas.TabIndex = 10;
            this.lblRutas.Text = "Ruta:";
            // 
            // gbxFechas
            // 
            this.gbxFechas.Controls.Add(this.lbl2);
            this.gbxFechas.Controls.Add(this.lbl1);
            this.gbxFechas.Controls.Add(this.dtFechaInicio);
            this.gbxFechas.Controls.Add(this.dtFechaFin);
            this.gbxFechas.Location = new System.Drawing.Point(398, 16);
            this.gbxFechas.Name = "gbxFechas";
            this.gbxFechas.Size = new System.Drawing.Size(258, 46);
            this.gbxFechas.TabIndex = 9;
            this.gbxFechas.TabStop = false;
            this.gbxFechas.Text = "Rango de Fechas";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(132, 22);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(18, 13);
            this.lbl2.TabIndex = 10;
            this.lbl2.Text = "al:";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(6, 22);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(26, 13);
            this.lbl1.TabIndex = 9;
            this.lbl1.Text = "Del:";
            // 
            // dtFechaInicio
            // 
            this.dtFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaInicio.Location = new System.Drawing.Point(32, 19);
            this.dtFechaInicio.Name = "dtFechaInicio";
            this.dtFechaInicio.Size = new System.Drawing.Size(98, 20);
            this.dtFechaInicio.TabIndex = 7;
            // 
            // dtFechaFin
            // 
            this.dtFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaFin.Location = new System.Drawing.Point(150, 19);
            this.dtFechaFin.Name = "dtFechaFin";
            this.dtFechaFin.Size = new System.Drawing.Size(98, 20);
            this.dtFechaFin.TabIndex = 8;
            // 
            // txtLongitud
            // 
            this.txtLongitud.BackColor = System.Drawing.SystemColors.Control;
            this.txtLongitud.Location = new System.Drawing.Point(258, 42);
            this.txtLongitud.Name = "txtLongitud";
            this.txtLongitud.Size = new System.Drawing.Size(125, 20);
            this.txtLongitud.TabIndex = 5;
            // 
            // lblLongitud
            // 
            this.lblLongitud.AutoSize = true;
            this.lblLongitud.Location = new System.Drawing.Point(205, 45);
            this.lblLongitud.Name = "lblLongitud";
            this.lblLongitud.Size = new System.Drawing.Size(51, 13);
            this.lblLongitud.TabIndex = 4;
            this.lblLongitud.Text = "Longitud:";
            // 
            // txtLatitud
            // 
            this.txtLatitud.BackColor = System.Drawing.SystemColors.Control;
            this.txtLatitud.Location = new System.Drawing.Point(258, 16);
            this.txtLatitud.Name = "txtLatitud";
            this.txtLatitud.Size = new System.Drawing.Size(125, 20);
            this.txtLatitud.TabIndex = 3;
            // 
            // lblLatitud
            // 
            this.lblLatitud.AutoSize = true;
            this.lblLatitud.Location = new System.Drawing.Point(213, 19);
            this.lblLatitud.Name = "lblLatitud";
            this.lblLatitud.Size = new System.Drawing.Size(42, 13);
            this.lblLatitud.TabIndex = 2;
            this.lblLatitud.Text = "Latitud:";
            // 
            // gbxMapa
            // 
            this.gbxMapa.Controls.Add(this.gmaps);
            this.gbxMapa.Location = new System.Drawing.Point(2, 82);
            this.gbxMapa.Name = "gbxMapa";
            this.gbxMapa.Size = new System.Drawing.Size(999, 466);
            this.gbxMapa.TabIndex = 4;
            this.gbxMapa.TabStop = false;
            this.gbxMapa.Text = "Mapa";
            // 
            // gmaps
            // 
            this.gmaps.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gmaps.Bearing = 0F;
            this.gmaps.CanDragMap = true;
            this.gmaps.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gmaps.EmptyTileColor = System.Drawing.Color.Navy;
            this.gmaps.GrayScaleMode = false;
            this.gmaps.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gmaps.LevelsKeepInMemmory = 5;
            this.gmaps.Location = new System.Drawing.Point(6, 19);
            this.gmaps.MarkersEnabled = true;
            this.gmaps.MaxZoom = 18;
            this.gmaps.MinZoom = 2;
            this.gmaps.MouseWheelZoomEnabled = true;
            this.gmaps.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gmaps.Name = "gmaps";
            this.gmaps.NegativeMode = false;
            this.gmaps.PolygonsEnabled = true;
            this.gmaps.RetryLoadTile = 0;
            this.gmaps.RoutesEnabled = true;
            this.gmaps.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gmaps.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gmaps.ShowTileGridLines = false;
            this.gmaps.Size = new System.Drawing.Size(993, 499);
            this.gmaps.TabIndex = 2;
            this.gmaps.Zoom = 15D;
            this.gmaps.OnMarkerClick += new GMap.NET.WindowsForms.MarkerClick(this.gmaps_OnMarkerClick);
            this.gmaps.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.gmaps_MouseDoubleClick);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 612);
            this.Controls.Add(this.gbxMapa);
            this.Controls.Add(this.gbxBusqueda);
            this.Name = "frmPrincipal";
            this.Text = "GPS";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.gbxBusqueda.ResumeLayout(false);
            this.gbxBusqueda.PerformLayout();
            this.gbxFechas.ResumeLayout(false);
            this.gbxFechas.PerformLayout();
            this.gbxMapa.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxBusqueda;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.ComboBox cbxRutas;
        private System.Windows.Forms.Label lblRutas;
        private System.Windows.Forms.GroupBox gbxFechas;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.DateTimePicker dtFechaInicio;
        private System.Windows.Forms.DateTimePicker dtFechaFin;
        private System.Windows.Forms.TextBox txtLongitud;
        private System.Windows.Forms.Label lblLongitud;
        private System.Windows.Forms.TextBox txtLatitud;
        private System.Windows.Forms.Label lblLatitud;
        private System.Windows.Forms.GroupBox gbxMapa;
        private GMap.NET.WindowsForms.GMapControl gmaps;
    }
}

