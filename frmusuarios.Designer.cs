namespace SIAP
{
    partial class frmusuarios
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
            this.dgusuarios = new System.Windows.Forms.DataGridView();
            this.btnagregar = new System.Windows.Forms.Button();
            this.btngrabarA = new System.Windows.Forms.Button();
            this.btnmodificar = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btngrabarM = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.rbusuario = new System.Windows.Forms.RadioButton();
            this.rbadmin = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.txtpasswd2 = new MiLibreria.ErrorTxtBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtpasswd1 = new MiLibreria.ErrorTxtBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtnombre = new MiLibreria.ErrorTxtBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtusuario = new MiLibreria.ErrorTxtBox();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgusuarios)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnsalir
            // 
            this.btnsalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsalir.Location = new System.Drawing.Point(438, 324);
            this.btnsalir.Size = new System.Drawing.Size(98, 23);
            // 
            // dgusuarios
            // 
            this.dgusuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgusuarios.Location = new System.Drawing.Point(12, 12);
            this.dgusuarios.Name = "dgusuarios";
            this.dgusuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgusuarios.Size = new System.Drawing.Size(526, 138);
            this.dgusuarios.TabIndex = 1;
            this.dgusuarios.SelectionChanged += new System.EventHandler(this.dgusuarios_SelectionChanged);
            // 
            // btnagregar
            // 
            this.btnagregar.Location = new System.Drawing.Point(12, 324);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(98, 23);
            this.btnagregar.TabIndex = 10;
            this.btnagregar.Text = "Agregar usuario";
            this.btnagregar.UseVisualStyleBackColor = true;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // btngrabarA
            // 
            this.btngrabarA.Location = new System.Drawing.Point(12, 324);
            this.btngrabarA.Name = "btngrabarA";
            this.btngrabarA.Size = new System.Drawing.Size(98, 23);
            this.btngrabarA.TabIndex = 11;
            this.btngrabarA.Text = "Grabar";
            this.btngrabarA.UseVisualStyleBackColor = true;
            this.btngrabarA.Visible = false;
            this.btngrabarA.Click += new System.EventHandler(this.btngrabarA_Click);
            // 
            // btnmodificar
            // 
            this.btnmodificar.Location = new System.Drawing.Point(160, 324);
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.Size = new System.Drawing.Size(98, 23);
            this.btnmodificar.TabIndex = 12;
            this.btnmodificar.Text = "Modificar";
            this.btnmodificar.UseVisualStyleBackColor = true;
            this.btnmodificar.Click += new System.EventHandler(this.btnmodificar_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.Location = new System.Drawing.Point(296, 324);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(98, 23);
            this.btneliminar.TabIndex = 13;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // btngrabarM
            // 
            this.btngrabarM.Location = new System.Drawing.Point(160, 324);
            this.btngrabarM.Name = "btngrabarM";
            this.btngrabarM.Size = new System.Drawing.Size(98, 23);
            this.btngrabarM.TabIndex = 14;
            this.btngrabarM.Text = "Grabar";
            this.btngrabarM.UseVisualStyleBackColor = true;
            this.btngrabarM.Visible = false;
            this.btngrabarM.Click += new System.EventHandler(this.btngrabarM_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.rbusuario);
            this.groupBox1.Controls.Add(this.rbadmin);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtpasswd2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtpasswd1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtnombre);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtusuario);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(12, 156);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(526, 143);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SIAP.Properties.Resources.usuario_registrados;
            this.pictureBox1.Location = new System.Drawing.Point(21, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(118, 118);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // rbusuario
            // 
            this.rbusuario.AutoSize = true;
            this.rbusuario.Checked = true;
            this.rbusuario.Location = new System.Drawing.Point(427, 115);
            this.rbusuario.Name = "rbusuario";
            this.rbusuario.Size = new System.Drawing.Size(61, 17);
            this.rbusuario.TabIndex = 28;
            this.rbusuario.TabStop = true;
            this.rbusuario.Text = "Usuario";
            this.rbusuario.UseVisualStyleBackColor = true;
            // 
            // rbadmin
            // 
            this.rbadmin.AutoSize = true;
            this.rbadmin.Location = new System.Drawing.Point(427, 82);
            this.rbadmin.Name = "rbadmin";
            this.rbadmin.Size = new System.Drawing.Size(88, 17);
            this.rbadmin.TabIndex = 27;
            this.rbadmin.Text = "Administrador";
            this.rbadmin.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(333, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Tipo de Usuario :";
            // 
            // txtpasswd2
            // 
            this.txtpasswd2.Location = new System.Drawing.Point(218, 112);
            this.txtpasswd2.Name = "txtpasswd2";
            this.txtpasswd2.PasswordChar = '*';
            this.txtpasswd2.Size = new System.Drawing.Size(100, 20);
            this.txtpasswd2.TabIndex = 25;
            this.txtpasswd2.Validar = true;
            this.txtpasswd2.Validated += new System.EventHandler(this.txtpasswd2_Validated);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(155, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Confirmar :";
            // 
            // txtpasswd1
            // 
            this.txtpasswd1.Location = new System.Drawing.Point(218, 81);
            this.txtpasswd1.Name = "txtpasswd1";
            this.txtpasswd1.PasswordChar = '*';
            this.txtpasswd1.Size = new System.Drawing.Size(100, 20);
            this.txtpasswd1.TabIndex = 23;
            this.txtpasswd1.Validar = true;
            this.txtpasswd1.Validated += new System.EventHandler(this.txtpasswd1_Validated);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(145, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Contraseña :";
            // 
            // txtnombre
            // 
            this.txtnombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtnombre.Location = new System.Drawing.Point(218, 50);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(291, 20);
            this.txtnombre.TabIndex = 21;
            this.txtnombre.Validar = true;
            this.txtnombre.Validated += new System.EventHandler(this.txtnombre_Validated);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(162, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Nombre :";
            // 
            // txtusuario
            // 
            this.txtusuario.Location = new System.Drawing.Point(218, 19);
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.Size = new System.Drawing.Size(89, 20);
            this.txtusuario.TabIndex = 19;
            this.txtusuario.Validar = true;
            this.txtusuario.Validated += new System.EventHandler(this.txtusuario_Validated);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(163, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Usuario :";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmusuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 371);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btnmodificar);
            this.Controls.Add(this.btnagregar);
            this.Controls.Add(this.dgusuarios);
            this.Controls.Add(this.btngrabarA);
            this.Controls.Add(this.btngrabarM);
            this.Name = "frmusuarios";
            this.Text = "Usuarios";
            this.Load += new System.EventHandler(this.frmusuarios_Load);
            this.Controls.SetChildIndex(this.btngrabarM, 0);
            this.Controls.SetChildIndex(this.btngrabarA, 0);
            this.Controls.SetChildIndex(this.btnsalir, 0);
            this.Controls.SetChildIndex(this.dgusuarios, 0);
            this.Controls.SetChildIndex(this.btnagregar, 0);
            this.Controls.SetChildIndex(this.btnmodificar, 0);
            this.Controls.SetChildIndex(this.btneliminar, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgusuarios)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgusuarios;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.Button btngrabarA;
        private System.Windows.Forms.Button btnmodificar;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btngrabarM;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbusuario;
        private System.Windows.Forms.RadioButton rbadmin;
        private System.Windows.Forms.Label label5;
        private MiLibreria.ErrorTxtBox txtpasswd2;
        private System.Windows.Forms.Label label4;
        private MiLibreria.ErrorTxtBox txtpasswd1;
        private System.Windows.Forms.Label label3;
        private MiLibreria.ErrorTxtBox txtnombre;
        private System.Windows.Forms.Label label2;
        private MiLibreria.ErrorTxtBox txtusuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}