namespace AGROHerramientas.Inventarios
{
    partial class BuscarPendienteEntregaVentas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuscarPendienteEntregaVentas));
            this.pnlBarra = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblCerrar = new System.Windows.Forms.Label();
            this.pnlPrincipal = new System.Windows.Forms.Panel();
            this.chkRango = new System.Windows.Forms.CheckBox();
            this.lblFechaH = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.dtpFechaH = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaD = new System.Windows.Forms.DateTimePicker();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.cfgVentas = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.lblBuscar = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.pnlBarra.SuspendLayout();
            this.pnlPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cfgVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBarra
            // 
            this.pnlBarra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.pnlBarra.Controls.Add(this.lblTitulo);
            this.pnlBarra.Controls.Add(this.lblCerrar);
            this.pnlBarra.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBarra.Location = new System.Drawing.Point(0, 0);
            this.pnlBarra.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.pnlBarra.Name = "pnlBarra";
            this.pnlBarra.Size = new System.Drawing.Size(743, 24);
            this.pnlBarra.TabIndex = 2;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTitulo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(0, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(231, 24);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Buscar Venta";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCerrar
            // 
            this.lblCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCerrar.AutoSize = true;
            this.lblCerrar.ForeColor = System.Drawing.Color.White;
            this.lblCerrar.Location = new System.Drawing.Point(721, 4);
            this.lblCerrar.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblCerrar.Name = "lblCerrar";
            this.lblCerrar.Size = new System.Drawing.Size(16, 17);
            this.lblCerrar.TabIndex = 0;
            this.lblCerrar.Text = "X";
            this.lblCerrar.Click += new System.EventHandler(this.lblCerrar_Click);
            // 
            // pnlPrincipal
            // 
            this.pnlPrincipal.Controls.Add(this.chkRango);
            this.pnlPrincipal.Controls.Add(this.lblFechaH);
            this.pnlPrincipal.Controls.Add(this.lblFecha);
            this.pnlPrincipal.Controls.Add(this.dtpFechaH);
            this.pnlPrincipal.Controls.Add(this.dtpFechaD);
            this.pnlPrincipal.Controls.Add(this.btnAceptar);
            this.pnlPrincipal.Controls.Add(this.cfgVentas);
            this.pnlPrincipal.Controls.Add(this.btnBuscar);
            this.pnlPrincipal.Controls.Add(this.lblBuscar);
            this.pnlPrincipal.Controls.Add(this.txtBuscar);
            this.pnlPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPrincipal.Location = new System.Drawing.Point(0, 24);
            this.pnlPrincipal.Name = "pnlPrincipal";
            this.pnlPrincipal.Size = new System.Drawing.Size(743, 428);
            this.pnlPrincipal.TabIndex = 3;
            // 
            // chkRango
            // 
            this.chkRango.AutoSize = true;
            this.chkRango.Location = new System.Drawing.Point(656, 10);
            this.chkRango.Name = "chkRango";
            this.chkRango.Size = new System.Drawing.Size(70, 21);
            this.chkRango.TabIndex = 16;
            this.chkRango.Text = "Rango";
            this.chkRango.UseVisualStyleBackColor = true;
            this.chkRango.CheckedChanged += new System.EventHandler(this.chkRango_CheckedChanged);
            // 
            // lblFechaH
            // 
            this.lblFechaH.AutoSize = true;
            this.lblFechaH.Location = new System.Drawing.Point(483, 11);
            this.lblFechaH.Name = "lblFechaH";
            this.lblFechaH.Size = new System.Drawing.Size(49, 17);
            this.lblFechaH.TabIndex = 15;
            this.lblFechaH.Text = "Hasta:";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(315, 11);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(51, 17);
            this.lblFecha.TabIndex = 14;
            this.lblFecha.Text = "Fecha:";
            // 
            // dtpFechaH
            // 
            this.dtpFechaH.Enabled = false;
            this.dtpFechaH.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaH.Location = new System.Drawing.Point(538, 8);
            this.dtpFechaH.Name = "dtpFechaH";
            this.dtpFechaH.Size = new System.Drawing.Size(105, 23);
            this.dtpFechaH.TabIndex = 13;
            // 
            // dtpFechaD
            // 
            this.dtpFechaD.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaD.Location = new System.Drawing.Point(372, 8);
            this.dtpFechaD.Name = "dtpFechaD";
            this.dtpFechaD.Size = new System.Drawing.Size(105, 23);
            this.dtpFechaD.TabIndex = 12;
            // 
            // btnAceptar
            // 
            this.btnAceptar.FlatAppearance.BorderSize = 0;
            this.btnAceptar.Location = new System.Drawing.Point(651, 385);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 35);
            this.btnAceptar.TabIndex = 11;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // cfgVentas
            // 
            this.cfgVentas.AutoClipboard = true;
            this.cfgVentas.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
            this.cfgVentas.ColumnInfo = resources.GetString("cfgVentas.ColumnInfo");
            this.cfgVentas.Location = new System.Drawing.Point(15, 37);
            this.cfgVentas.Name = "cfgVentas";
            this.cfgVentas.Rows.Count = 1;
            this.cfgVentas.Rows.DefaultSize = 20;
            this.cfgVentas.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row;
            this.cfgVentas.Size = new System.Drawing.Size(711, 342);
            this.cfgVentas.StyleInfo = resources.GetString("cfgVentas.StyleInfo");
            this.cfgVentas.TabIndex = 10;
            this.cfgVentas.DoubleClick += new System.EventHandler(this.cfgVentas_DoubleClick);
            // 
            // btnBuscar
            // 
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.ImageIndex = 0;
            this.btnBuscar.ImageList = this.imageList;
            this.btnBuscar.Location = new System.Drawing.Point(280, 8);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(29, 23);
            this.btnBuscar.TabIndex = 9;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "Buscar.png");
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Location = new System.Drawing.Point(12, 11);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(53, 17);
            this.lblBuscar.TabIndex = 1;
            this.lblBuscar.Text = "Buscar:";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(71, 8);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(203, 23);
            this.txtBuscar.TabIndex = 0;
            this.txtBuscar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBuscar_KeyDown);
            // 
            // BuscarPendienteEntregaVentas
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(743, 452);
            this.Controls.Add(this.pnlPrincipal);
            this.Controls.Add(this.pnlBarra);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "BuscarPendienteEntregaVentas";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BuscarPendienteEntregaVentas";
            this.pnlBarra.ResumeLayout(false);
            this.pnlBarra.PerformLayout();
            this.pnlPrincipal.ResumeLayout(false);
            this.pnlPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cfgVentas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBarra;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblCerrar;
        private System.Windows.Forms.Panel pnlPrincipal;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.Button btnAceptar;
        private C1.Win.C1FlexGrid.C1FlexGrid cfgVentas;
        private System.Windows.Forms.CheckBox chkRango;
        private System.Windows.Forms.Label lblFechaH;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.DateTimePicker dtpFechaH;
        private System.Windows.Forms.DateTimePicker dtpFechaD;
    }
}