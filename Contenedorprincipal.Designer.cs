namespace SIAP
{
    partial class Contenedorprincipal
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Contenedorprincipal));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administracionDeUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.salirDelSistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.controlDeValesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vehiculosYMaquinariaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.operadoresDeMaquinariaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.controlDeValesDeCombustibleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entregaDeCañaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroDeTicketsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculoDeRayaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tarifasPcalculoRayaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.estadisticasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.helpToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.lblstrip_usuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblcntusr = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblnombre = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblcntnombre = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblcnttipo = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.controlDeValesToolStripMenuItem,
            this.entregaDeCañaToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(834, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.administracionDeUsuariosToolStripMenuItem,
            this.toolStripSeparator2,
            this.salirDelSistemaToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // administracionDeUsuariosToolStripMenuItem
            // 
            this.administracionDeUsuariosToolStripMenuItem.Image = global::SIAP.Properties.Resources.usuario_registrados;
            this.administracionDeUsuariosToolStripMenuItem.Name = "administracionDeUsuariosToolStripMenuItem";
            this.administracionDeUsuariosToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.administracionDeUsuariosToolStripMenuItem.Text = "Administracion de Usuarios";
            this.administracionDeUsuariosToolStripMenuItem.Click += new System.EventHandler(this.administracionDeUsuariosToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(216, 6);
            // 
            // salirDelSistemaToolStripMenuItem
            // 
            this.salirDelSistemaToolStripMenuItem.Image = global::SIAP.Properties.Resources.salir;
            this.salirDelSistemaToolStripMenuItem.Name = "salirDelSistemaToolStripMenuItem";
            this.salirDelSistemaToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.salirDelSistemaToolStripMenuItem.Text = "Salir del Sistema";
            this.salirDelSistemaToolStripMenuItem.Click += new System.EventHandler(this.salirDelSistemaToolStripMenuItem_Click);
            // 
            // controlDeValesToolStripMenuItem
            // 
            this.controlDeValesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vehiculosYMaquinariaToolStripMenuItem,
            this.operadoresDeMaquinariaToolStripMenuItem,
            this.controlDeValesDeCombustibleToolStripMenuItem,
            this.reportesToolStripMenuItem});
            this.controlDeValesToolStripMenuItem.Name = "controlDeValesToolStripMenuItem";
            this.controlDeValesToolStripMenuItem.Size = new System.Drawing.Size(105, 20);
            this.controlDeValesToolStripMenuItem.Text = "Control de Vales";
            // 
            // vehiculosYMaquinariaToolStripMenuItem
            // 
            this.vehiculosYMaquinariaToolStripMenuItem.Image = global::SIAP.Properties.Resources._614tractor_100372;
            this.vehiculosYMaquinariaToolStripMenuItem.Name = "vehiculosYMaquinariaToolStripMenuItem";
            this.vehiculosYMaquinariaToolStripMenuItem.Size = new System.Drawing.Size(272, 22);
            this.vehiculosYMaquinariaToolStripMenuItem.Text = "Vehiculos y Maquinaria";
            this.vehiculosYMaquinariaToolStripMenuItem.Click += new System.EventHandler(this.VehiculosYMaquinariaToolStripMenuItem_Click);
            // 
            // operadoresDeMaquinariaToolStripMenuItem
            // 
            this.operadoresDeMaquinariaToolStripMenuItem.Image = global::SIAP.Properties.Resources._2125_cab_driver_102435;
            this.operadoresDeMaquinariaToolStripMenuItem.Name = "operadoresDeMaquinariaToolStripMenuItem";
            this.operadoresDeMaquinariaToolStripMenuItem.Size = new System.Drawing.Size(272, 22);
            this.operadoresDeMaquinariaToolStripMenuItem.Text = "Operadores de Maquinaria / Choferes";
            this.operadoresDeMaquinariaToolStripMenuItem.Click += new System.EventHandler(this.OperadoresDeMaquinariaToolStripMenuItem_Click);
            // 
            // controlDeValesDeCombustibleToolStripMenuItem
            // 
            this.controlDeValesDeCombustibleToolStripMenuItem.Image = global::SIAP.Properties.Resources.vale;
            this.controlDeValesDeCombustibleToolStripMenuItem.Name = "controlDeValesDeCombustibleToolStripMenuItem";
            this.controlDeValesDeCombustibleToolStripMenuItem.Size = new System.Drawing.Size(272, 22);
            this.controlDeValesDeCombustibleToolStripMenuItem.Text = "Control de Vales de Combustible";
            this.controlDeValesDeCombustibleToolStripMenuItem.Click += new System.EventHandler(this.ControlDeValesDeCombustibleToolStripMenuItem_Click);
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.Image = global::SIAP.Properties.Resources.images;
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(272, 22);
            this.reportesToolStripMenuItem.Text = "Reportes de Vales de Combustible";
            this.reportesToolStripMenuItem.Click += new System.EventHandler(this.ReportesToolStripMenuItem_Click);
            // 
            // entregaDeCañaToolStripMenuItem
            // 
            this.entregaDeCañaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registroDeTicketsToolStripMenuItem,
            this.calculoDeRayaToolStripMenuItem,
            this.toolStripSeparator1,
            this.tarifasPcalculoRayaToolStripMenuItem,
            this.toolStripSeparator3,
            this.estadisticasToolStripMenuItem});
            this.entregaDeCañaToolStripMenuItem.Name = "entregaDeCañaToolStripMenuItem";
            this.entregaDeCañaToolStripMenuItem.Size = new System.Drawing.Size(105, 20);
            this.entregaDeCañaToolStripMenuItem.Text = "Entrega de Caña";
            // 
            // registroDeTicketsToolStripMenuItem
            // 
            this.registroDeTicketsToolStripMenuItem.Name = "registroDeTicketsToolStripMenuItem";
            this.registroDeTicketsToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.registroDeTicketsToolStripMenuItem.Text = "Ingreso de caña al Ingenio";
            this.registroDeTicketsToolStripMenuItem.Click += new System.EventHandler(this.RegistroDeTicketsToolStripMenuItem_Click);
            // 
            // calculoDeRayaToolStripMenuItem
            // 
            this.calculoDeRayaToolStripMenuItem.Name = "calculoDeRayaToolStripMenuItem";
            this.calculoDeRayaToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.calculoDeRayaToolStripMenuItem.Text = "Calculo de Raya";
            this.calculoDeRayaToolStripMenuItem.Click += new System.EventHandler(this.calculoDeRayaToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(209, 6);
            // 
            // tarifasPcalculoRayaToolStripMenuItem
            // 
            this.tarifasPcalculoRayaToolStripMenuItem.Name = "tarifasPcalculoRayaToolStripMenuItem";
            this.tarifasPcalculoRayaToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.tarifasPcalculoRayaToolStripMenuItem.Text = "Tarifas p/calculo raya";
            this.tarifasPcalculoRayaToolStripMenuItem.Click += new System.EventHandler(this.tarifasPcalculoRayaToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(209, 6);
            // 
            // estadisticasToolStripMenuItem
            // 
            this.estadisticasToolStripMenuItem.Name = "estadisticasToolStripMenuItem";
            this.estadisticasToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.estadisticasToolStripMenuItem.Text = "Estadisticas";
            this.estadisticasToolStripMenuItem.Click += new System.EventHandler(this.estadisticasToolStripMenuItem_Click);
            // 
            // toolStrip
            // 
            this.toolStrip.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripButton,
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripLabel1});
            this.toolStrip.Location = new System.Drawing.Point(0, 24);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(834, 39);
            this.toolStrip.TabIndex = 1;
            this.toolStrip.Text = "ToolStrip";
            // 
            // helpToolStripButton
            // 
            this.helpToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.helpToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("helpToolStripButton.Image")));
            this.helpToolStripButton.ImageTransparentColor = System.Drawing.Color.Black;
            this.helpToolStripButton.Name = "helpToolStripButton";
            this.helpToolStripButton.Size = new System.Drawing.Size(36, 36);
            this.helpToolStripButton.Text = "Ayuda";
            this.helpToolStripButton.ToolTipText = "Catalogo de vehiculos";
            this.helpToolStripButton.Click += new System.EventHandler(this.HelpToolStripButton_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(36, 36);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.ToolTipText = "Catalogo de Operadores";
            this.toolStripButton1.Click += new System.EventHandler(this.ToolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(36, 36);
            this.toolStripButton2.Text = "toolStripButton2";
            this.toolStripButton2.ToolTipText = "Control de Vales";
            this.toolStripButton2.Click += new System.EventHandler(this.ToolStripButton2_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = global::SIAP.Properties.Resources.images;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(36, 36);
            this.toolStripButton3.Text = "Reportes de Vales";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(581, 36);
            this.toolStripLabel1.Text = "SISTEMA INTEGRAL ADMINISTRATIVO DE PRODUCCION RURAL";
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblstrip_usuario,
            this.lblcntusr,
            this.lblnombre,
            this.lblcntnombre,
            this.toolStripStatusLabel1,
            this.lblcnttipo});
            this.statusStrip.Location = new System.Drawing.Point(0, 423);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(834, 24);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // lblstrip_usuario
            // 
            this.lblstrip_usuario.Name = "lblstrip_usuario";
            this.lblstrip_usuario.Size = new System.Drawing.Size(62, 19);
            this.lblstrip_usuario.Text = "USUARIO :";
            // 
            // lblcntusr
            // 
            this.lblcntusr.BackColor = System.Drawing.Color.PaleGreen;
            this.lblcntusr.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.lblcntusr.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.lblcntusr.Name = "lblcntusr";
            this.lblcntusr.Size = new System.Drawing.Size(62, 19);
            this.lblcntusr.Text = "                 ";
            // 
            // lblnombre
            // 
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(62, 19);
            this.lblnombre.Text = "NOMBRE :";
            // 
            // lblcntnombre
            // 
            this.lblcntnombre.BackColor = System.Drawing.Color.PaleGreen;
            this.lblcntnombre.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.lblcntnombre.Name = "lblcntnombre";
            this.lblcntnombre.Size = new System.Drawing.Size(59, 19);
            this.lblcntnombre.Text = "                ";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(108, 19);
            this.toolStripStatusLabel1.Text = "TIPO DE USUARIO :";
            // 
            // lblcnttipo
            // 
            this.lblcnttipo.BackColor = System.Drawing.Color.PaleGreen;
            this.lblcnttipo.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.lblcnttipo.Name = "lblcnttipo";
            this.lblcnttipo.Size = new System.Drawing.Size(80, 19);
            this.lblcnttipo.Text = "                       ";
            // 
            // Contenedorprincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::SIAP.Properties.Resources.LOGOBACK;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(834, 447);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Contenedorprincipal";
            this.Text = "SIAP";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Contenedorprincipal_FormClosing);
            this.Load += new System.EventHandler(this.Contenedorprincipal_Load);
            this.Leave += new System.EventHandler(this.Contenedorprincipal_Leave);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripButton helpToolStripButton;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripMenuItem controlDeValesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vehiculosYMaquinariaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem operadoresDeMaquinariaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem controlDeValesDeCombustibleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirDelSistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem entregaDeCañaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroDeTicketsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculoDeRayaToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel lblstrip_usuario;
        private System.Windows.Forms.ToolStripStatusLabel lblcntusr;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripMenuItem tarifasPcalculoRayaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem administracionDeUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel lblnombre;
        private System.Windows.Forms.ToolStripStatusLabel lblcntnombre;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel lblcnttipo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem estadisticasToolStripMenuItem;
    }
}



