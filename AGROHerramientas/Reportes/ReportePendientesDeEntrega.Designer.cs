namespace AGROHerramientas.Reportes
{
    partial class ReportePendientesDeEntrega
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportePendientesDeEntrega));
            this.pnlBotones = new System.Windows.Forms.Panel();
            this.btnExcel = new System.Windows.Forms.Button();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.cfgDetalle = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.cmbEstatus = new System.Windows.Forms.ComboBox();
            this.lblEstatus = new System.Windows.Forms.Label();
            this.lblAlmacen = new System.Windows.Forms.Label();
            this.cmbAlmacen = new System.Windows.Forms.ComboBox();
            this.lblGrupo = new System.Windows.Forms.Label();
            this.cmbGrupo = new System.Windows.Forms.ComboBox();
            this.dtpFechaD = new System.Windows.Forms.DateTimePicker();
            this.lblFechaD = new System.Windows.Forms.Label();
            this.lblFechaH = new System.Windows.Forms.Label();
            this.dtpFechaH = new System.Windows.Forms.DateTimePicker();
            this.chkRango = new System.Windows.Forms.CheckBox();
            this.pnlBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cfgDetalle)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBotones
            // 
            this.pnlBotones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBotones.Controls.Add(this.btnExcel);
            this.pnlBotones.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBotones.Location = new System.Drawing.Point(0, 0);
            this.pnlBotones.Name = "pnlBotones";
            this.pnlBotones.Size = new System.Drawing.Size(1069, 26);
            this.pnlBotones.TabIndex = 4;
            // 
            // btnExcel
            // 
            this.btnExcel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExcel.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnExcel.FlatAppearance.BorderSize = 0;
            this.btnExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcel.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcel.ImageIndex = 5;
            this.btnExcel.ImageList = this.imageList;
            this.btnExcel.Location = new System.Drawing.Point(0, 0);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.btnExcel.Size = new System.Drawing.Size(82, 24);
            this.btnExcel.TabIndex = 3;
            this.btnExcel.Text = "Excel";
            this.btnExcel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "Nuevo.png");
            this.imageList.Images.SetKeyName(1, "1452043662_save.png");
            this.imageList.Images.SetKeyName(2, "1487204409_add_list.png");
            this.imageList.Images.SetKeyName(3, "1486257561_print.png");
            this.imageList.Images.SetKeyName(4, "Buscar.png");
            this.imageList.Images.SetKeyName(5, "md_5b33460f04516.png");
            // 
            // cfgDetalle
            // 
            this.cfgDetalle.AllowEditing = false;
            this.cfgDetalle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cfgDetalle.AutoClipboard = true;
            this.cfgDetalle.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
            this.cfgDetalle.ColumnInfo = resources.GetString("cfgDetalle.ColumnInfo");
            this.cfgDetalle.ExtendLastCol = true;
            this.cfgDetalle.KeyActionTab = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross;
            this.cfgDetalle.Location = new System.Drawing.Point(12, 125);
            this.cfgDetalle.Name = "cfgDetalle";
            this.cfgDetalle.Rows.Count = 1;
            this.cfgDetalle.Rows.DefaultSize = 20;
            this.cfgDetalle.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;
            this.cfgDetalle.Size = new System.Drawing.Size(1045, 489);
            this.cfgDetalle.StyleInfo = resources.GetString("cfgDetalle.StyleInfo");
            this.cfgDetalle.TabIndex = 5;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(71, 31);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(187, 23);
            this.txtBuscar.TabIndex = 6;
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Location = new System.Drawing.Point(12, 34);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(53, 17);
            this.lblBuscar.TabIndex = 7;
            this.lblBuscar.Text = "Buscar:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.ImageIndex = 4;
            this.btnBuscar.ImageList = this.imageList;
            this.btnBuscar.Location = new System.Drawing.Point(264, 30);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(29, 24);
            this.btnBuscar.TabIndex = 9;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // cmbEstatus
            // 
            this.cmbEstatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstatus.FormattingEnabled = true;
            this.cmbEstatus.Items.AddRange(new object[] {
            "(TODOS)",
            "CONCLUIDO",
            "PENDIENTE",
            "CANCELADO"});
            this.cmbEstatus.Location = new System.Drawing.Point(375, 31);
            this.cmbEstatus.Name = "cmbEstatus";
            this.cmbEstatus.Size = new System.Drawing.Size(121, 25);
            this.cmbEstatus.TabIndex = 10;
            // 
            // lblEstatus
            // 
            this.lblEstatus.AutoSize = true;
            this.lblEstatus.Location = new System.Drawing.Point(299, 34);
            this.lblEstatus.Name = "lblEstatus";
            this.lblEstatus.Size = new System.Drawing.Size(56, 17);
            this.lblEstatus.TabIndex = 11;
            this.lblEstatus.Text = "Estatus:";
            // 
            // lblAlmacen
            // 
            this.lblAlmacen.AutoSize = true;
            this.lblAlmacen.Location = new System.Drawing.Point(299, 65);
            this.lblAlmacen.Name = "lblAlmacen";
            this.lblAlmacen.Size = new System.Drawing.Size(70, 17);
            this.lblAlmacen.TabIndex = 13;
            this.lblAlmacen.Text = "Almacen:";
            // 
            // cmbAlmacen
            // 
            this.cmbAlmacen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAlmacen.FormattingEnabled = true;
            this.cmbAlmacen.Items.AddRange(new object[] {
            "(TODOS)",
            "CONCLUIDO",
            "PENDIENTE",
            "CANCELADO"});
            this.cmbAlmacen.Location = new System.Drawing.Point(375, 62);
            this.cmbAlmacen.Name = "cmbAlmacen";
            this.cmbAlmacen.Size = new System.Drawing.Size(121, 25);
            this.cmbAlmacen.TabIndex = 12;
            // 
            // lblGrupo
            // 
            this.lblGrupo.AutoSize = true;
            this.lblGrupo.Location = new System.Drawing.Point(299, 97);
            this.lblGrupo.Name = "lblGrupo";
            this.lblGrupo.Size = new System.Drawing.Size(53, 17);
            this.lblGrupo.TabIndex = 15;
            this.lblGrupo.Text = "Grupo:";
            // 
            // cmbGrupo
            // 
            this.cmbGrupo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGrupo.FormattingEnabled = true;
            this.cmbGrupo.Items.AddRange(new object[] {
            "(TODOS)",
            "ALMACEN",
            "MOSTRADOR"});
            this.cmbGrupo.Location = new System.Drawing.Point(375, 94);
            this.cmbGrupo.Name = "cmbGrupo";
            this.cmbGrupo.Size = new System.Drawing.Size(121, 25);
            this.cmbGrupo.TabIndex = 14;
            // 
            // dtpFechaD
            // 
            this.dtpFechaD.Enabled = false;
            this.dtpFechaD.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaD.Location = new System.Drawing.Point(557, 33);
            this.dtpFechaD.Name = "dtpFechaD";
            this.dtpFechaD.Size = new System.Drawing.Size(107, 23);
            this.dtpFechaD.TabIndex = 16;
            // 
            // lblFechaD
            // 
            this.lblFechaD.AutoSize = true;
            this.lblFechaD.Location = new System.Drawing.Point(502, 34);
            this.lblFechaD.Name = "lblFechaD";
            this.lblFechaD.Size = new System.Drawing.Size(30, 17);
            this.lblFechaD.TabIndex = 17;
            this.lblFechaD.Text = "De:";
            // 
            // lblFechaH
            // 
            this.lblFechaH.AutoSize = true;
            this.lblFechaH.Location = new System.Drawing.Point(502, 65);
            this.lblFechaH.Name = "lblFechaH";
            this.lblFechaH.Size = new System.Drawing.Size(49, 17);
            this.lblFechaH.TabIndex = 19;
            this.lblFechaH.Text = "Hasta:";
            // 
            // dtpFechaH
            // 
            this.dtpFechaH.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaH.Location = new System.Drawing.Point(557, 64);
            this.dtpFechaH.Name = "dtpFechaH";
            this.dtpFechaH.Size = new System.Drawing.Size(107, 23);
            this.dtpFechaH.TabIndex = 18;
            // 
            // chkRango
            // 
            this.chkRango.AutoSize = true;
            this.chkRango.Location = new System.Drawing.Point(594, 96);
            this.chkRango.Name = "chkRango";
            this.chkRango.Size = new System.Drawing.Size(70, 21);
            this.chkRango.TabIndex = 20;
            this.chkRango.Text = "Rango";
            this.chkRango.UseVisualStyleBackColor = true;
            this.chkRango.CheckedChanged += new System.EventHandler(this.chkRango_CheckedChanged);
            // 
            // ReportePendientesDeEntrega
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(203)))), ((int)(((byte)(186)))));
            this.ClientSize = new System.Drawing.Size(1069, 626);
            this.Controls.Add(this.chkRango);
            this.Controls.Add(this.lblFechaH);
            this.Controls.Add(this.dtpFechaH);
            this.Controls.Add(this.lblFechaD);
            this.Controls.Add(this.dtpFechaD);
            this.Controls.Add(this.lblGrupo);
            this.Controls.Add(this.cmbGrupo);
            this.Controls.Add(this.lblAlmacen);
            this.Controls.Add(this.cmbAlmacen);
            this.Controls.Add(this.lblEstatus);
            this.Controls.Add(this.cmbEstatus);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lblBuscar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.cfgDetalle);
            this.Controls.Add(this.pnlBotones);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "ReportePendientesDeEntrega";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReportePendientesDeEntrega";
            this.Load += new System.EventHandler(this.ReportePendientesDeEntrega_Load);
            this.pnlBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cfgDetalle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlBotones;
        private System.Windows.Forms.Button btnExcel;
        private C1.Win.C1FlexGrid.C1FlexGrid cfgDetalle;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.ComboBox cmbEstatus;
        private System.Windows.Forms.Label lblEstatus;
        private System.Windows.Forms.Label lblAlmacen;
        private System.Windows.Forms.ComboBox cmbAlmacen;
        private System.Windows.Forms.Label lblGrupo;
        private System.Windows.Forms.ComboBox cmbGrupo;
        private System.Windows.Forms.DateTimePicker dtpFechaD;
        private System.Windows.Forms.Label lblFechaD;
        private System.Windows.Forms.Label lblFechaH;
        private System.Windows.Forms.DateTimePicker dtpFechaH;
        private System.Windows.Forms.CheckBox chkRango;
    }
}