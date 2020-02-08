namespace AGROHerramientas.Tableros
{
    partial class Tareas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tareas));
            this.cfgTareas = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.cfgAsignacion = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.btnUDN = new System.Windows.Forms.Button();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.btnGuardar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.cfgTareas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cfgAsignacion)).BeginInit();
            this.SuspendLayout();
            // 
            // cfgTareas
            // 
            this.cfgTareas.AutoClipboard = true;
            this.cfgTareas.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
            this.cfgTareas.ColumnInfo = "0,0,0,0,0,100,Columns:";
            this.cfgTareas.ExtendLastCol = true;
            this.cfgTareas.Location = new System.Drawing.Point(12, 39);
            this.cfgTareas.Name = "cfgTareas";
            this.cfgTareas.Rows.DefaultSize = 20;
            this.cfgTareas.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row;
            this.cfgTareas.Size = new System.Drawing.Size(348, 575);
            this.cfgTareas.StyleInfo = resources.GetString("cfgTareas.StyleInfo");
            this.cfgTareas.TabIndex = 12;
            this.cfgTareas.AfterEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.cfgTareas_AfterEdit);
            this.cfgTareas.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cfgTareas_KeyDown);
            // 
            // cfgAsignacion
            // 
            this.cfgAsignacion.AutoClipboard = true;
            this.cfgAsignacion.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
            this.cfgAsignacion.ColumnInfo = "0,0,0,0,0,100,Columns:";
            this.cfgAsignacion.ExtendLastCol = true;
            this.cfgAsignacion.Location = new System.Drawing.Point(366, 39);
            this.cfgAsignacion.Name = "cfgAsignacion";
            this.cfgAsignacion.Rows.Count = 13;
            this.cfgAsignacion.Rows.DefaultSize = 20;
            this.cfgAsignacion.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row;
            this.cfgAsignacion.Size = new System.Drawing.Size(691, 575);
            this.cfgAsignacion.StyleInfo = resources.GetString("cfgAsignacion.StyleInfo");
            this.cfgAsignacion.TabIndex = 13;
            this.cfgAsignacion.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cfgAsignacion_KeyDown);
            // 
            // btnUDN
            // 
            this.btnUDN.FlatAppearance.BorderSize = 0;
            this.btnUDN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUDN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUDN.ImageIndex = 0;
            this.btnUDN.ImageList = this.imageList;
            this.btnUDN.Location = new System.Drawing.Point(887, 10);
            this.btnUDN.Name = "btnUDN";
            this.btnUDN.Size = new System.Drawing.Size(170, 23);
            this.btnUDN.TabIndex = 14;
            this.btnUDN.Text = "Unidades Negocio";
            this.btnUDN.UseVisualStyleBackColor = true;
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "iconfinder_organization_82846.png");
            this.imageList.Images.SetKeyName(1, "1452043662_save.png");
            // 
            // btnGuardar
            // 
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.ImageIndex = 1;
            this.btnGuardar.ImageList = this.imageList;
            this.btnGuardar.Location = new System.Drawing.Point(366, 10);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(129, 23);
            this.btnGuardar.TabIndex = 15;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // Tareas
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(203)))), ((int)(((byte)(186)))));
            this.ClientSize = new System.Drawing.Size(1069, 626);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnUDN);
            this.Controls.Add(this.cfgAsignacion);
            this.Controls.Add(this.cfgTareas);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Tareas";
            this.Text = "Tareas";
            this.Load += new System.EventHandler(this.Tareas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cfgTareas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cfgAsignacion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private C1.Win.C1FlexGrid.C1FlexGrid cfgTareas;
        private C1.Win.C1FlexGrid.C1FlexGrid cfgAsignacion;
        private System.Windows.Forms.Button btnUDN;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.Button btnGuardar;
    }
}