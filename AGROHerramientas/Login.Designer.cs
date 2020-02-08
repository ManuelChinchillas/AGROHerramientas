namespace AGROHerramientas
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.panelDer = new System.Windows.Forms.Panel();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.pbAlmacen = new System.Windows.Forms.PictureBox();
            this.cmbAlmacen = new System.Windows.Forms.ComboBox();
            this.lblAlmacen = new System.Windows.Forms.Label();
            this.pbContraseña = new System.Windows.Forms.PictureBox();
            this.txtContraseña = new MisControles.MiTextBox();
            this.pbUsuario = new System.Windows.Forms.PictureBox();
            this.txtUsuario = new MisControles.MiTextBox();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblCerrar = new System.Windows.Forms.Label();
            this.panelDegradado = new MisControles.PanelDegradado();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.panelDer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlmacen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbContraseña)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUsuario)).BeginInit();
            this.panelDegradado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelDer
            // 
            this.panelDer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(235)))), ((int)(((byte)(210)))));
            this.panelDer.Controls.Add(this.btnIniciar);
            this.panelDer.Controls.Add(this.pbAlmacen);
            this.panelDer.Controls.Add(this.cmbAlmacen);
            this.panelDer.Controls.Add(this.lblAlmacen);
            this.panelDer.Controls.Add(this.pbContraseña);
            this.panelDer.Controls.Add(this.txtContraseña);
            this.panelDer.Controls.Add(this.pbUsuario);
            this.panelDer.Controls.Add(this.txtUsuario);
            this.panelDer.Controls.Add(this.lblContraseña);
            this.panelDer.Controls.Add(this.lblUsuario);
            this.panelDer.Controls.Add(this.lblLogin);
            this.panelDer.Controls.Add(this.lblCerrar);
            this.panelDer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDer.Location = new System.Drawing.Point(247, 0);
            this.panelDer.Name = "panelDer";
            this.panelDer.Size = new System.Drawing.Size(322, 504);
            this.panelDer.TabIndex = 3;
            // 
            // btnIniciar
            // 
            this.btnIniciar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.btnIniciar.FlatAppearance.BorderSize = 0;
            this.btnIniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIniciar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciar.ForeColor = System.Drawing.Color.White;
            this.btnIniciar.Location = new System.Drawing.Point(165, 446);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(149, 52);
            this.btnIniciar.TabIndex = 14;
            this.btnIniciar.Text = "INICIAR";
            this.btnIniciar.UseVisualStyleBackColor = false;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // pbAlmacen
            // 
            this.pbAlmacen.Image = ((System.Drawing.Image)(resources.GetObject("pbAlmacen.Image")));
            this.pbAlmacen.Location = new System.Drawing.Point(10, 201);
            this.pbAlmacen.Name = "pbAlmacen";
            this.pbAlmacen.Size = new System.Drawing.Size(22, 22);
            this.pbAlmacen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAlmacen.TabIndex = 13;
            this.pbAlmacen.TabStop = false;
            // 
            // cmbAlmacen
            // 
            this.cmbAlmacen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAlmacen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbAlmacen.FormattingEnabled = true;
            this.cmbAlmacen.Location = new System.Drawing.Point(38, 201);
            this.cmbAlmacen.Name = "cmbAlmacen";
            this.cmbAlmacen.Size = new System.Drawing.Size(276, 24);
            this.cmbAlmacen.TabIndex = 12;
            // 
            // lblAlmacen
            // 
            this.lblAlmacen.AutoSize = true;
            this.lblAlmacen.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlmacen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.lblAlmacen.Location = new System.Drawing.Point(34, 179);
            this.lblAlmacen.Name = "lblAlmacen";
            this.lblAlmacen.Size = new System.Drawing.Size(86, 19);
            this.lblAlmacen.TabIndex = 11;
            this.lblAlmacen.Text = "Almacen:";
            // 
            // pbContraseña
            // 
            this.pbContraseña.Image = global::AGROHerramientas.Properties.Resources.iconfinder_invisible_82734;
            this.pbContraseña.Location = new System.Drawing.Point(10, 154);
            this.pbContraseña.Name = "pbContraseña";
            this.pbContraseña.Size = new System.Drawing.Size(22, 22);
            this.pbContraseña.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbContraseña.TabIndex = 10;
            this.pbContraseña.TabStop = false;
            this.pbContraseña.Click += new System.EventHandler(this.pbContraseña_Click);
            this.pbContraseña.MouseEnter += new System.EventHandler(this.pbContraseña_MouseEnter);
            this.pbContraseña.MouseLeave += new System.EventHandler(this.pbContraseña_MouseLeave);
            this.pbContraseña.MouseHover += new System.EventHandler(this.pbContraseña_MouseHover);
            // 
            // txtContraseña
            // 
            this.txtContraseña.BordeAncho = 2;
            this.txtContraseña.BordeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.txtContraseña.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtContraseña.Location = new System.Drawing.Point(38, 154);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(276, 22);
            this.txtContraseña.TabIndex = 9;
            this.txtContraseña.UseSystemPasswordChar = true;
            this.txtContraseña.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtContraseña_KeyDown);
            // 
            // pbUsuario
            // 
            this.pbUsuario.Image = ((System.Drawing.Image)(resources.GetObject("pbUsuario.Image")));
            this.pbUsuario.Location = new System.Drawing.Point(10, 107);
            this.pbUsuario.Name = "pbUsuario";
            this.pbUsuario.Size = new System.Drawing.Size(22, 22);
            this.pbUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbUsuario.TabIndex = 8;
            this.pbUsuario.TabStop = false;
            // 
            // txtUsuario
            // 
            this.txtUsuario.BordeAncho = 2;
            this.txtUsuario.BordeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtUsuario.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(38, 107);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(276, 22);
            this.txtUsuario.TabIndex = 7;
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContraseña.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.lblContraseña.Location = new System.Drawing.Point(34, 132);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(102, 19);
            this.lblContraseña.TabIndex = 6;
            this.lblContraseña.Text = "Contraseña:";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.lblUsuario.Location = new System.Drawing.Point(34, 87);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(69, 19);
            this.lblUsuario.TabIndex = 3;
            this.lblUsuario.Text = "Usuario:";
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.lblLogin.Location = new System.Drawing.Point(58, 43);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(214, 28);
            this.lblLogin.TabIndex = 2;
            this.lblLogin.Text = "INICIO DE SESION";
            // 
            // lblCerrar
            // 
            this.lblCerrar.AutoSize = true;
            this.lblCerrar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCerrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.lblCerrar.Location = new System.Drawing.Point(300, 0);
            this.lblCerrar.Name = "lblCerrar";
            this.lblCerrar.Size = new System.Drawing.Size(23, 23);
            this.lblCerrar.TabIndex = 1;
            this.lblCerrar.Text = "X";
            this.lblCerrar.Click += new System.EventHandler(this.lblCerrar_Click);
            // 
            // panelDegradado
            // 
            this.panelDegradado.AnguloDegradado = 90F;
            this.panelDegradado.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panelDegradado.ColorAbajo = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.panelDegradado.ColorArriba = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.panelDegradado.Controls.Add(this.lblTitulo);
            this.panelDegradado.Controls.Add(this.pbLogo);
            this.panelDegradado.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelDegradado.Location = new System.Drawing.Point(0, 0);
            this.panelDegradado.Name = "panelDegradado";
            this.panelDegradado.Size = new System.Drawing.Size(247, 504);
            this.panelDegradado.TabIndex = 2;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(10, 166);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(226, 32);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "HERRAMIENTAS ADMINISTRATIVAS\r\nY DE OPERACION";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTitulo.Click += new System.EventHandler(this.lblTitulo_Click);
            // 
            // pbLogo
            // 
            this.pbLogo.BackColor = System.Drawing.Color.Transparent;
            this.pbLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbLogo.Image")));
            this.pbLogo.Location = new System.Drawing.Point(37, 12);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(172, 129);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 1;
            this.pbLogo.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(569, 504);
            this.Controls.Add(this.panelDer);
            this.Controls.Add(this.panelDegradado);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Login";
            this.Opacity = 0.98D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LogIn";
            this.Load += new System.EventHandler(this.Login_Load);
            this.panelDer.ResumeLayout(false);
            this.panelDer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlmacen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbContraseña)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUsuario)).EndInit();
            this.panelDegradado.ResumeLayout(false);
            this.panelDegradado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MisControles.PanelDegradado panelDegradado;
        private System.Windows.Forms.Panel panelDer;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.PictureBox pbAlmacen;
        private System.Windows.Forms.ComboBox cmbAlmacen;
        private System.Windows.Forms.Label lblAlmacen;
        private System.Windows.Forms.PictureBox pbContraseña;
        private MisControles.MiTextBox txtContraseña;
        private System.Windows.Forms.PictureBox pbUsuario;
        private MisControles.MiTextBox txtUsuario;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblCerrar;
    }
}

