namespace SIAP
{
    partial class frmtickets
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
            this.dg1 = new System.Windows.Forms.DataGridView();
            this.btnnuevo = new System.Windows.Forms.Button();
            this.btnedit = new System.Windows.Forms.Button();
            this.gbdatosticket = new System.Windows.Forms.GroupBox();
            this.cb1 = new System.Windows.Forms.CheckBox();
            this.txtfolio = new MiLibreria.ErrorTxtBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txttoneladas = new MiLibreria.ErrorTxtBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtsemana = new MiLibreria.ErrorTxtBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dpentrega = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.combo_vehiculo = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg1)).BeginInit();
            this.gbdatosticket.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(600, 76);
            this.button5.Size = new System.Drawing.Size(119, 27);
            this.button5.TabIndex = 8;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(600, 172);
            this.button4.Size = new System.Drawing.Size(119, 27);
            this.button4.TabIndex = 10;
            this.button4.Text = "Grabar";
            this.button4.Visible = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(600, 124);
            this.button3.Size = new System.Drawing.Size(119, 27);
            this.button3.TabIndex = 9;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(600, 29);
            this.button2.Size = new System.Drawing.Size(119, 27);
            this.button2.TabIndex = 5;
            this.button2.Text = "Guardar";
            this.button2.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(600, 220);
            this.button1.Size = new System.Drawing.Size(119, 27);
            this.button1.TabIndex = 12;
            this.button1.Visible = false;
            // 
            // btnsalir
            // 
            this.btnsalir.Location = new System.Drawing.Point(600, 220);
            this.btnsalir.Size = new System.Drawing.Size(119, 27);
            this.btnsalir.TabIndex = 11;
            // 
            // dg1
            // 
            this.dg1.AllowUserToAddRows = false;
            this.dg1.AllowUserToDeleteRows = false;
            this.dg1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg1.Location = new System.Drawing.Point(22, 285);
            this.dg1.Name = "dg1";
            this.dg1.ReadOnly = true;
            this.dg1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg1.Size = new System.Drawing.Size(697, 258);
            this.dg1.TabIndex = 99;
            this.dg1.SelectionChanged += new System.EventHandler(this.Dg1_SelectionChanged);
            // 
            // btnnuevo
            // 
            this.btnnuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnuevo.Location = new System.Drawing.Point(600, 29);
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.Size = new System.Drawing.Size(119, 27);
            this.btnnuevo.TabIndex = 15;
            this.btnnuevo.Text = "Nuevo";
            this.btnnuevo.UseVisualStyleBackColor = true;
            this.btnnuevo.Click += new System.EventHandler(this.Btnnuevo_Click);
            // 
            // btnedit
            // 
            this.btnedit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnedit.Location = new System.Drawing.Point(600, 172);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(119, 27);
            this.btnedit.TabIndex = 16;
            this.btnedit.Text = "Modificar";
            this.btnedit.UseVisualStyleBackColor = true;
            this.btnedit.Click += new System.EventHandler(this.Btnedit_Click);
            // 
            // gbdatosticket
            // 
            this.gbdatosticket.Controls.Add(this.cb1);
            this.gbdatosticket.Controls.Add(this.txtfolio);
            this.gbdatosticket.Controls.Add(this.label1);
            this.gbdatosticket.Controls.Add(this.txttoneladas);
            this.gbdatosticket.Controls.Add(this.label9);
            this.gbdatosticket.Controls.Add(this.txtsemana);
            this.gbdatosticket.Controls.Add(this.label8);
            this.gbdatosticket.Controls.Add(this.dpentrega);
            this.gbdatosticket.Controls.Add(this.label4);
            this.gbdatosticket.Controls.Add(this.label5);
            this.gbdatosticket.Controls.Add(this.combo_vehiculo);
            this.gbdatosticket.Enabled = false;
            this.gbdatosticket.Location = new System.Drawing.Point(22, 76);
            this.gbdatosticket.Name = "gbdatosticket";
            this.gbdatosticket.Size = new System.Drawing.Size(561, 195);
            this.gbdatosticket.TabIndex = 73;
            this.gbdatosticket.TabStop = false;
            this.gbdatosticket.Text = "Datos del Ticket";
            // 
            // cb1
            // 
            this.cb1.AutoSize = true;
            this.cb1.Enabled = false;
            this.cb1.Location = new System.Drawing.Point(414, 85);
            this.cb1.Name = "cb1";
            this.cb1.Size = new System.Drawing.Size(109, 17);
            this.cb1.TabIndex = 84;
            this.cb1.Text = "Ticket ya pagado";
            this.cb1.UseVisualStyleBackColor = true;
            this.cb1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // txtfolio
            // 
            this.txtfolio.Location = new System.Drawing.Point(148, 69);
            this.txtfolio.Name = "txtfolio";
            this.txtfolio.Size = new System.Drawing.Size(140, 20);
            this.txtfolio.TabIndex = 2;
            this.txtfolio.Validar = true;
            this.txtfolio.TextChanged += new System.EventHandler(this.txtfolio_TextChanged);
            this.txtfolio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtfolio_KeyPress_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 16);
            this.label1.TabIndex = 83;
            this.label1.Text = "Folio Ticket :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txttoneladas
            // 
            this.txttoneladas.Location = new System.Drawing.Point(148, 110);
            this.txttoneladas.Name = "txttoneladas";
            this.txttoneladas.Size = new System.Drawing.Size(140, 20);
            this.txttoneladas.TabIndex = 3;
            this.txttoneladas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txttoneladas.Validar = true;
            this.txttoneladas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txttoneladas_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(25, 111);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 16);
            this.label9.TabIndex = 79;
            this.label9.Text = "Toneladas :";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // txtsemana
            // 
            this.txtsemana.Location = new System.Drawing.Point(404, 25);
            this.txtsemana.Name = "txtsemana";
            this.txtsemana.Size = new System.Drawing.Size(119, 20);
            this.txtsemana.TabIndex = 1;
            this.txtsemana.Validar = true;
            this.txtsemana.TextChanged += new System.EventHandler(this.txtsemana_TextChanged);
            this.txtsemana.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtsemana_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(325, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 16);
            this.label8.TabIndex = 77;
            this.label8.Text = "Semana :";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // dpentrega
            // 
            this.dpentrega.CustomFormat = "dd/MM/yyyy";
            this.dpentrega.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpentrega.Location = new System.Drawing.Point(148, 25);
            this.dpentrega.Name = "dpentrega";
            this.dpentrega.Size = new System.Drawing.Size(140, 20);
            this.dpentrega.TabIndex = 0;
            this.dpentrega.ValueChanged += new System.EventHandler(this.dpentrega_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 16);
            this.label4.TabIndex = 75;
            this.label4.Text = "Fecha Entrega :";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(25, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 16);
            this.label5.TabIndex = 74;
            this.label5.Text = "Vehiculo :";
            // 
            // combo_vehiculo
            // 
            this.combo_vehiculo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_vehiculo.FormattingEnabled = true;
            this.combo_vehiculo.Location = new System.Drawing.Point(148, 157);
            this.combo_vehiculo.Name = "combo_vehiculo";
            this.combo_vehiculo.Size = new System.Drawing.Size(375, 21);
            this.combo_vehiculo.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SIAP.Properties.Resources.zucarmex;
            this.pictureBox1.Location = new System.Drawing.Point(204, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(301, 58);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 81;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // frmtickets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 555);
            this.Controls.Add(this.gbdatosticket);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnedit);
            this.Controls.Add(this.btnnuevo);
            this.Controls.Add(this.dg1);
            this.Name = "frmtickets";
            this.Text = "Entrega de caña";
            this.Load += new System.EventHandler(this.Frmvehiculo_Load);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.button4, 0);
            this.Controls.SetChildIndex(this.button2, 0);
            this.Controls.SetChildIndex(this.dg1, 0);
            this.Controls.SetChildIndex(this.btnnuevo, 0);
            this.Controls.SetChildIndex(this.btnedit, 0);
            this.Controls.SetChildIndex(this.button5, 0);
            this.Controls.SetChildIndex(this.btnsalir, 0);
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            this.Controls.SetChildIndex(this.button3, 0);
            this.Controls.SetChildIndex(this.gbdatosticket, 0);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg1)).EndInit();
            this.gbdatosticket.ResumeLayout(false);
            this.gbdatosticket.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dg1;
        private System.Windows.Forms.Button btnnuevo;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.GroupBox gbdatosticket;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MiLibreria.ErrorTxtBox txttoneladas;
        private System.Windows.Forms.Label label9;
        private MiLibreria.ErrorTxtBox txtsemana;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox combo_vehiculo;
        public System.Windows.Forms.DateTimePicker dpentrega;
        private MiLibreria.ErrorTxtBox txtfolio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cb1;
    }
}