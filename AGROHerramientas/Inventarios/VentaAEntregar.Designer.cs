namespace AGROHerramientas.Inventarios
{
    partial class VentaAEntregar
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
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.panelDegradado = new MisControles.PanelDegradado();
            this.lblDetalle = new System.Windows.Forms.Label();
            this.lblTiempo = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblAgente = new System.Windows.Forms.Label();
            this.lblMovID = new System.Windows.Forms.Label();
            this.contenedorCurvo1 = new MisControles.ContenedorCurvo();
            this.timerEstatus = new System.Windows.Forms.Timer(this.components);
            this.panelDegradado.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // panelDegradado
            // 
            this.panelDegradado.AnguloDegradado = 90F;
            this.panelDegradado.ColorAbajo = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.panelDegradado.ColorArriba = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.panelDegradado.Controls.Add(this.lblDetalle);
            this.panelDegradado.Controls.Add(this.lblTiempo);
            this.panelDegradado.Controls.Add(this.lblCliente);
            this.panelDegradado.Controls.Add(this.lblAgente);
            this.panelDegradado.Controls.Add(this.lblMovID);
            this.panelDegradado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDegradado.Location = new System.Drawing.Point(0, 0);
            this.panelDegradado.Name = "panelDegradado";
            this.panelDegradado.Size = new System.Drawing.Size(356, 339);
            this.panelDegradado.TabIndex = 0;
            this.panelDegradado.Click += new System.EventHandler(this.panelDegradado_Click);
            // 
            // lblDetalle
            // 
            this.lblDetalle.BackColor = System.Drawing.Color.Transparent;
            this.lblDetalle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDetalle.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetalle.Location = new System.Drawing.Point(0, 69);
            this.lblDetalle.Name = "lblDetalle";
            this.lblDetalle.Size = new System.Drawing.Size(356, 247);
            this.lblDetalle.TabIndex = 6;
            this.lblDetalle.Text = "Detalle";
            this.lblDetalle.Click += new System.EventHandler(this.lblDetalle_Click);
            // 
            // lblTiempo
            // 
            this.lblTiempo.BackColor = System.Drawing.Color.Transparent;
            this.lblTiempo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblTiempo.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTiempo.Location = new System.Drawing.Point(0, 316);
            this.lblTiempo.Name = "lblTiempo";
            this.lblTiempo.Size = new System.Drawing.Size(356, 23);
            this.lblTiempo.TabIndex = 5;
            this.lblTiempo.Text = "Tiempo";
            this.lblTiempo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTiempo.Click += new System.EventHandler(this.lblDetalle_Click);
            // 
            // lblCliente
            // 
            this.lblCliente.BackColor = System.Drawing.Color.Transparent;
            this.lblCliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCliente.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.Location = new System.Drawing.Point(0, 46);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(356, 23);
            this.lblCliente.TabIndex = 3;
            this.lblCliente.Text = "Cliente";
            this.lblCliente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCliente.Click += new System.EventHandler(this.lblDetalle_Click);
            // 
            // lblAgente
            // 
            this.lblAgente.BackColor = System.Drawing.Color.Transparent;
            this.lblAgente.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblAgente.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgente.Location = new System.Drawing.Point(0, 23);
            this.lblAgente.Name = "lblAgente";
            this.lblAgente.Size = new System.Drawing.Size(356, 23);
            this.lblAgente.TabIndex = 1;
            this.lblAgente.Text = "Agente";
            this.lblAgente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAgente.Click += new System.EventHandler(this.lblDetalle_Click);
            // 
            // lblMovID
            // 
            this.lblMovID.BackColor = System.Drawing.Color.Transparent;
            this.lblMovID.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblMovID.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovID.Location = new System.Drawing.Point(0, 0);
            this.lblMovID.Name = "lblMovID";
            this.lblMovID.Size = new System.Drawing.Size(356, 23);
            this.lblMovID.TabIndex = 0;
            this.lblMovID.Text = "MovID";
            this.lblMovID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMovID.Click += new System.EventHandler(this.lblDetalle_Click);
            // 
            // contenedorCurvo1
            // 
            this.contenedorCurvo1.CornerRaiuds = 20;
            this.contenedorCurvo1.TargetControl = this;
            // 
            // timerEstatus
            // 
            this.timerEstatus.Interval = 60000;
            this.timerEstatus.Tick += new System.EventHandler(this.timerEstatus_Tick);
            // 
            // VentaAEntregar
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(356, 339);
            this.Controls.Add(this.panelDegradado);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VentaAEntregar";
            this.Text = "VentaAEntregar";
            this.Load += new System.EventHandler(this.VentaAEntregar_Load);
            this.panelDegradado.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MisControles.PanelDegradado panelDegradado;
        private MisControles.ContenedorCurvo contenedorCurvo1;
        private System.Windows.Forms.Label lblAgente;
        private System.Windows.Forms.Label lblMovID;
        private System.Windows.Forms.Label lblDetalle;
        private System.Windows.Forms.Label lblTiempo;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Timer timerEstatus;
    }
}