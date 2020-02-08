namespace AGROHerramientas.Inventarios
{
    partial class EntregaDeMercancia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EntregaDeMercancia));
            this.pnlBarra = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblCerrar = new System.Windows.Forms.Label();
            this.pnlBotones = new System.Windows.Forms.Panel();
            this.btnEntregarTodo = new System.Windows.Forms.Button();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.btnGuardar = new System.Windows.Forms.Button();
            this.pnlEncabezado = new System.Windows.Forms.Panel();
            this.lblMovID = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.txtCodigoDeBarras = new System.Windows.Forms.TextBox();
            this.txtSituacion = new System.Windows.Forms.TextBox();
            this.pblGeneral = new System.Windows.Forms.Panel();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.pnlOriginal = new System.Windows.Forms.Panel();
            this.cfgOriginal = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.lblOriginal = new System.Windows.Forms.Label();
            this.pnlCorrectosFisicamente = new System.Windows.Forms.Panel();
            this.cfgCorrectos = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.lblCorrectos = new System.Windows.Forms.Label();
            this.pnlBot = new System.Windows.Forms.Panel();
            this.pnlIncorrectosCntidades = new System.Windows.Forms.Panel();
            this.cfgIncorrectosCantidad = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.lblIncorrectosCantidad = new System.Windows.Forms.Label();
            this.pnlIncorrectos = new System.Windows.Forms.Panel();
            this.cfgIncorrectos = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.lblIncorrectos = new System.Windows.Forms.Label();
            this.lblEscaneado = new System.Windows.Forms.Label();
            this.pnlBarra.SuspendLayout();
            this.pnlBotones.SuspendLayout();
            this.pnlEncabezado.SuspendLayout();
            this.pblGeneral.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.pnlOriginal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cfgOriginal)).BeginInit();
            this.pnlCorrectosFisicamente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cfgCorrectos)).BeginInit();
            this.pnlBot.SuspendLayout();
            this.pnlIncorrectosCntidades.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cfgIncorrectosCantidad)).BeginInit();
            this.pnlIncorrectos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cfgIncorrectos)).BeginInit();
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
            this.pnlBarra.Size = new System.Drawing.Size(870, 24);
            this.pnlBarra.TabIndex = 1;
            this.pnlBarra.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlBarra_Paint);
            this.pnlBarra.DoubleClick += new System.EventHandler(this.pnlBarra_DoubleClick);
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
            this.lblTitulo.Text = "ENTREGA DE MERCANCIA";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCerrar
            // 
            this.lblCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCerrar.AutoSize = true;
            this.lblCerrar.ForeColor = System.Drawing.Color.White;
            this.lblCerrar.Location = new System.Drawing.Point(848, 0);
            this.lblCerrar.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblCerrar.Name = "lblCerrar";
            this.lblCerrar.Size = new System.Drawing.Size(22, 22);
            this.lblCerrar.TabIndex = 0;
            this.lblCerrar.Text = "X";
            this.lblCerrar.Click += new System.EventHandler(this.lblCerrar_Click);
            // 
            // pnlBotones
            // 
            this.pnlBotones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBotones.Controls.Add(this.btnEntregarTodo);
            this.pnlBotones.Controls.Add(this.btnGuardar);
            this.pnlBotones.Controls.Add(this.txtSituacion);
            this.pnlBotones.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBotones.Location = new System.Drawing.Point(0, 24);
            this.pnlBotones.Name = "pnlBotones";
            this.pnlBotones.Size = new System.Drawing.Size(870, 26);
            this.pnlBotones.TabIndex = 2;
            // 
            // btnEntregarTodo
            // 
            this.btnEntregarTodo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEntregarTodo.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnEntregarTodo.FlatAppearance.BorderSize = 0;
            this.btnEntregarTodo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntregarTodo.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntregarTodo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEntregarTodo.ImageIndex = 2;
            this.btnEntregarTodo.ImageList = this.imageList;
            this.btnEntregarTodo.Location = new System.Drawing.Point(85, 0);
            this.btnEntregarTodo.Name = "btnEntregarTodo";
            this.btnEntregarTodo.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.btnEntregarTodo.Size = new System.Drawing.Size(112, 24);
            this.btnEntregarTodo.TabIndex = 2;
            this.btnEntregarTodo.Text = "Entregar Todo";
            this.btnEntregarTodo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEntregarTodo.UseVisualStyleBackColor = true;
            this.btnEntregarTodo.Click += new System.EventHandler(this.btnEntregarTodo_Click);
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "Nuevo.png");
            this.imageList.Images.SetKeyName(1, "1452043662_save.png");
            this.imageList.Images.SetKeyName(2, "1487204409_add_list.png");
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnGuardar.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.ImageIndex = 1;
            this.btnGuardar.ImageList = this.imageList;
            this.btnGuardar.Location = new System.Drawing.Point(0, 0);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.btnGuardar.Size = new System.Drawing.Size(85, 24);
            this.btnGuardar.TabIndex = 1;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // pnlEncabezado
            // 
            this.pnlEncabezado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlEncabezado.Controls.Add(this.lblEscaneado);
            this.pnlEncabezado.Controls.Add(this.lblMovID);
            this.pnlEncabezado.Controls.Add(this.lblID);
            this.pnlEncabezado.Controls.Add(this.txtCodigoDeBarras);
            this.pnlEncabezado.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlEncabezado.Location = new System.Drawing.Point(0, 50);
            this.pnlEncabezado.Name = "pnlEncabezado";
            this.pnlEncabezado.Size = new System.Drawing.Size(870, 46);
            this.pnlEncabezado.TabIndex = 3;
            // 
            // lblMovID
            // 
            this.lblMovID.AutoSize = true;
            this.lblMovID.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovID.Location = new System.Drawing.Point(280, 11);
            this.lblMovID.Name = "lblMovID";
            this.lblMovID.Size = new System.Drawing.Size(141, 19);
            this.lblMovID.TabIndex = 3;
            this.lblMovID.Text = "Factura CA42780";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.ForeColor = System.Drawing.Color.Navy;
            this.lblID.Location = new System.Drawing.Point(-1, 13);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(66, 19);
            this.lblID.TabIndex = 2;
            this.lblID.Text = "V553499";
            // 
            // txtCodigoDeBarras
            // 
            this.txtCodigoDeBarras.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoDeBarras.Location = new System.Drawing.Point(71, 10);
            this.txtCodigoDeBarras.Name = "txtCodigoDeBarras";
            this.txtCodigoDeBarras.Size = new System.Drawing.Size(203, 24);
            this.txtCodigoDeBarras.TabIndex = 1;
            this.txtCodigoDeBarras.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCodigoDeBarras_KeyDown);
            // 
            // txtSituacion
            // 
            this.txtSituacion.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSituacion.Location = new System.Drawing.Point(540, 1);
            this.txtSituacion.Name = "txtSituacion";
            this.txtSituacion.ReadOnly = true;
            this.txtSituacion.Size = new System.Drawing.Size(296, 21);
            this.txtSituacion.TabIndex = 0;
            // 
            // pblGeneral
            // 
            this.pblGeneral.Controls.Add(this.pnlBot);
            this.pblGeneral.Controls.Add(this.pnlTop);
            this.pblGeneral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pblGeneral.Location = new System.Drawing.Point(0, 96);
            this.pblGeneral.Name = "pblGeneral";
            this.pblGeneral.Size = new System.Drawing.Size(870, 440);
            this.pblGeneral.TabIndex = 4;
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.pnlCorrectosFisicamente);
            this.pnlTop.Controls.Add(this.pnlOriginal);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(870, 212);
            this.pnlTop.TabIndex = 4;
            // 
            // pnlOriginal
            // 
            this.pnlOriginal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlOriginal.Controls.Add(this.cfgOriginal);
            this.pnlOriginal.Controls.Add(this.lblOriginal);
            this.pnlOriginal.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlOriginal.Location = new System.Drawing.Point(0, 0);
            this.pnlOriginal.Name = "pnlOriginal";
            this.pnlOriginal.Size = new System.Drawing.Size(431, 212);
            this.pnlOriginal.TabIndex = 4;
            // 
            // cfgOriginal
            // 
            this.cfgOriginal.AllowEditing = false;
            this.cfgOriginal.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
            this.cfgOriginal.ColumnInfo = resources.GetString("cfgOriginal.ColumnInfo");
            this.cfgOriginal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cfgOriginal.ExtendLastCol = true;
            this.cfgOriginal.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cfgOriginal.Location = new System.Drawing.Point(0, 15);
            this.cfgOriginal.Name = "cfgOriginal";
            this.cfgOriginal.Rows.Count = 1;
            this.cfgOriginal.Rows.DefaultSize = 18;
            this.cfgOriginal.Size = new System.Drawing.Size(429, 195);
            this.cfgOriginal.StyleInfo = resources.GetString("cfgOriginal.StyleInfo");
            this.cfgOriginal.TabIndex = 1;
            // 
            // lblOriginal
            // 
            this.lblOriginal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(203)))), ((int)(((byte)(186)))));
            this.lblOriginal.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblOriginal.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOriginal.Location = new System.Drawing.Point(0, 0);
            this.lblOriginal.Name = "lblOriginal";
            this.lblOriginal.Size = new System.Drawing.Size(429, 15);
            this.lblOriginal.TabIndex = 0;
            this.lblOriginal.Text = "ARTICULOS DEL MOVIMIENTO";
            // 
            // pnlCorrectosFisicamente
            // 
            this.pnlCorrectosFisicamente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCorrectosFisicamente.Controls.Add(this.cfgCorrectos);
            this.pnlCorrectosFisicamente.Controls.Add(this.lblCorrectos);
            this.pnlCorrectosFisicamente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCorrectosFisicamente.Location = new System.Drawing.Point(431, 0);
            this.pnlCorrectosFisicamente.Name = "pnlCorrectosFisicamente";
            this.pnlCorrectosFisicamente.Size = new System.Drawing.Size(439, 212);
            this.pnlCorrectosFisicamente.TabIndex = 5;
            // 
            // cfgCorrectos
            // 
            this.cfgCorrectos.AllowEditing = false;
            this.cfgCorrectos.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
            this.cfgCorrectos.ColumnInfo = resources.GetString("cfgCorrectos.ColumnInfo");
            this.cfgCorrectos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cfgCorrectos.ExtendLastCol = true;
            this.cfgCorrectos.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cfgCorrectos.Location = new System.Drawing.Point(0, 15);
            this.cfgCorrectos.Name = "cfgCorrectos";
            this.cfgCorrectos.Rows.Count = 1;
            this.cfgCorrectos.Rows.DefaultSize = 18;
            this.cfgCorrectos.Size = new System.Drawing.Size(437, 195);
            this.cfgCorrectos.StyleInfo = resources.GetString("cfgCorrectos.StyleInfo");
            this.cfgCorrectos.TabIndex = 2;
            // 
            // lblCorrectos
            // 
            this.lblCorrectos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(203)))), ((int)(((byte)(186)))));
            this.lblCorrectos.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCorrectos.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorrectos.Location = new System.Drawing.Point(0, 0);
            this.lblCorrectos.Name = "lblCorrectos";
            this.lblCorrectos.Size = new System.Drawing.Size(437, 15);
            this.lblCorrectos.TabIndex = 1;
            this.lblCorrectos.Text = "ARTICULOS FISICAMENTE CORRECTOS";
            // 
            // pnlBot
            // 
            this.pnlBot.Controls.Add(this.pnlIncorrectos);
            this.pnlBot.Controls.Add(this.pnlIncorrectosCntidades);
            this.pnlBot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBot.Location = new System.Drawing.Point(0, 212);
            this.pnlBot.Name = "pnlBot";
            this.pnlBot.Size = new System.Drawing.Size(870, 228);
            this.pnlBot.TabIndex = 5;
            // 
            // pnlIncorrectosCntidades
            // 
            this.pnlIncorrectosCntidades.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlIncorrectosCntidades.Controls.Add(this.cfgIncorrectosCantidad);
            this.pnlIncorrectosCntidades.Controls.Add(this.lblIncorrectosCantidad);
            this.pnlIncorrectosCntidades.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlIncorrectosCntidades.Location = new System.Drawing.Point(0, 0);
            this.pnlIncorrectosCntidades.Name = "pnlIncorrectosCntidades";
            this.pnlIncorrectosCntidades.Size = new System.Drawing.Size(435, 228);
            this.pnlIncorrectosCntidades.TabIndex = 3;
            // 
            // cfgIncorrectosCantidad
            // 
            this.cfgIncorrectosCantidad.AllowEditing = false;
            this.cfgIncorrectosCantidad.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
            this.cfgIncorrectosCantidad.ColumnInfo = resources.GetString("cfgIncorrectosCantidad.ColumnInfo");
            this.cfgIncorrectosCantidad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cfgIncorrectosCantidad.ExtendLastCol = true;
            this.cfgIncorrectosCantidad.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cfgIncorrectosCantidad.Location = new System.Drawing.Point(0, 15);
            this.cfgIncorrectosCantidad.Name = "cfgIncorrectosCantidad";
            this.cfgIncorrectosCantidad.Rows.Count = 1;
            this.cfgIncorrectosCantidad.Rows.DefaultSize = 18;
            this.cfgIncorrectosCantidad.Size = new System.Drawing.Size(433, 211);
            this.cfgIncorrectosCantidad.StyleInfo = resources.GetString("cfgIncorrectosCantidad.StyleInfo");
            this.cfgIncorrectosCantidad.TabIndex = 3;
            // 
            // lblIncorrectosCantidad
            // 
            this.lblIncorrectosCantidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(203)))), ((int)(((byte)(186)))));
            this.lblIncorrectosCantidad.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblIncorrectosCantidad.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIncorrectosCantidad.Location = new System.Drawing.Point(0, 0);
            this.lblIncorrectosCantidad.Name = "lblIncorrectosCantidad";
            this.lblIncorrectosCantidad.Size = new System.Drawing.Size(433, 15);
            this.lblIncorrectosCantidad.TabIndex = 1;
            this.lblIncorrectosCantidad.Text = "ARTICULOS INCORRECTOS (CANTIDAD Y/O LOTE)";
            // 
            // pnlIncorrectos
            // 
            this.pnlIncorrectos.AutoSize = true;
            this.pnlIncorrectos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlIncorrectos.Controls.Add(this.cfgIncorrectos);
            this.pnlIncorrectos.Controls.Add(this.lblIncorrectos);
            this.pnlIncorrectos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlIncorrectos.Location = new System.Drawing.Point(435, 0);
            this.pnlIncorrectos.Name = "pnlIncorrectos";
            this.pnlIncorrectos.Size = new System.Drawing.Size(435, 228);
            this.pnlIncorrectos.TabIndex = 4;
            // 
            // cfgIncorrectos
            // 
            this.cfgIncorrectos.AllowEditing = false;
            this.cfgIncorrectos.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
            this.cfgIncorrectos.ColumnInfo = resources.GetString("cfgIncorrectos.ColumnInfo");
            this.cfgIncorrectos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cfgIncorrectos.ExtendLastCol = true;
            this.cfgIncorrectos.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cfgIncorrectos.Location = new System.Drawing.Point(0, 15);
            this.cfgIncorrectos.Name = "cfgIncorrectos";
            this.cfgIncorrectos.Rows.Count = 1;
            this.cfgIncorrectos.Rows.DefaultSize = 18;
            this.cfgIncorrectos.Size = new System.Drawing.Size(433, 211);
            this.cfgIncorrectos.StyleInfo = resources.GetString("cfgIncorrectos.StyleInfo");
            this.cfgIncorrectos.TabIndex = 3;
            // 
            // lblIncorrectos
            // 
            this.lblIncorrectos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(203)))), ((int)(((byte)(186)))));
            this.lblIncorrectos.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblIncorrectos.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIncorrectos.Location = new System.Drawing.Point(0, 0);
            this.lblIncorrectos.Name = "lblIncorrectos";
            this.lblIncorrectos.Size = new System.Drawing.Size(433, 15);
            this.lblIncorrectos.TabIndex = 2;
            this.lblIncorrectos.Text = "ARTICULOS INCORRECTOS";
            // 
            // lblEscaneado
            // 
            this.lblEscaneado.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEscaneado.Location = new System.Drawing.Point(430, 10);
            this.lblEscaneado.Name = "lblEscaneado";
            this.lblEscaneado.Size = new System.Drawing.Size(435, 24);
            this.lblEscaneado.TabIndex = 4;
            this.lblEscaneado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // EntregaDeMercancia
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(870, 536);
            this.Controls.Add(this.pblGeneral);
            this.Controls.Add(this.pnlEncabezado);
            this.Controls.Add(this.pnlBotones);
            this.Controls.Add(this.pnlBarra);
            this.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EntregaDeMercancia";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Entrega De Mercancia";
            this.Load += new System.EventHandler(this.EntregaDeMercancia_Load);
            this.pnlBarra.ResumeLayout(false);
            this.pnlBarra.PerformLayout();
            this.pnlBotones.ResumeLayout(false);
            this.pnlBotones.PerformLayout();
            this.pnlEncabezado.ResumeLayout(false);
            this.pnlEncabezado.PerformLayout();
            this.pblGeneral.ResumeLayout(false);
            this.pnlTop.ResumeLayout(false);
            this.pnlOriginal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cfgOriginal)).EndInit();
            this.pnlCorrectosFisicamente.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cfgCorrectos)).EndInit();
            this.pnlBot.ResumeLayout(false);
            this.pnlBot.PerformLayout();
            this.pnlIncorrectosCntidades.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cfgIncorrectosCantidad)).EndInit();
            this.pnlIncorrectos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cfgIncorrectos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBarra;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblCerrar;
        private System.Windows.Forms.Panel pnlBotones;
        private System.Windows.Forms.Button btnEntregarTodo;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Panel pnlEncabezado;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtCodigoDeBarras;
        private System.Windows.Forms.TextBox txtSituacion;
        private System.Windows.Forms.Label lblMovID;
        private System.Windows.Forms.Panel pblGeneral;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Panel pnlCorrectosFisicamente;
        private C1.Win.C1FlexGrid.C1FlexGrid cfgCorrectos;
        private System.Windows.Forms.Label lblCorrectos;
        private System.Windows.Forms.Panel pnlOriginal;
        private C1.Win.C1FlexGrid.C1FlexGrid cfgOriginal;
        private System.Windows.Forms.Label lblOriginal;
        private System.Windows.Forms.Panel pnlBot;
        private System.Windows.Forms.Panel pnlIncorrectos;
        private C1.Win.C1FlexGrid.C1FlexGrid cfgIncorrectos;
        private System.Windows.Forms.Label lblIncorrectos;
        private System.Windows.Forms.Panel pnlIncorrectosCntidades;
        private C1.Win.C1FlexGrid.C1FlexGrid cfgIncorrectosCantidad;
        private System.Windows.Forms.Label lblIncorrectosCantidad;
        private System.Windows.Forms.Label lblEscaneado;
    }
}