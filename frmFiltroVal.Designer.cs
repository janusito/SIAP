namespace SIAP
{
    partial class frmFiltroVal
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
            this.button1 = new System.Windows.Forms.Button();
            this.tp1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbvehiculo = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.combo_vehiculo = new System.Windows.Forms.ComboBox();
            this.cbfolios = new System.Windows.Forms.CheckBox();
            this.cbfechas = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.errorTxtBox2 = new MiLibreria.ErrorTxtBox();
            this.errorTxtBox1 = new MiLibreria.ErrorTxtBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tp1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnsalir
            // 
            this.btnsalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsalir.Location = new System.Drawing.Point(333, 255);
            this.btnsalir.Text = "Cancelar";
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(180, 255);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 32);
            this.button1.TabIndex = 2;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tp1
            // 
            this.tp1.Controls.Add(this.groupBox1);
            this.tp1.Location = new System.Drawing.Point(4, 22);
            this.tp1.Name = "tp1";
            this.tp1.Padding = new System.Windows.Forms.Padding(3);
            this.tp1.Size = new System.Drawing.Size(432, 211);
            this.tp1.TabIndex = 1;
            this.tp1.Text = "Filtro General";
            this.tp1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbvehiculo);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.combo_vehiculo);
            this.groupBox1.Controls.Add(this.cbfolios);
            this.groupBox1.Controls.Add(this.cbfechas);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.errorTxtBox2);
            this.groupBox1.Controls.Add(this.errorTxtBox1);
            this.groupBox1.Controls.Add(this.dateTimePicker2);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(8, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(399, 179);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vales";
            // 
            // cbvehiculo
            // 
            this.cbvehiculo.AutoSize = true;
            this.cbvehiculo.Location = new System.Drawing.Point(18, 140);
            this.cbvehiculo.Name = "cbvehiculo";
            this.cbvehiculo.Size = new System.Drawing.Size(15, 14);
            this.cbvehiculo.TabIndex = 58;
            this.cbvehiculo.UseVisualStyleBackColor = true;
            this.cbvehiculo.CheckedChanged += new System.EventHandler(this.cbvehiculo_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 57;
            this.label5.Text = "Vehiculo :";
            // 
            // combo_vehiculo
            // 
            this.combo_vehiculo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_vehiculo.Enabled = false;
            this.combo_vehiculo.FormattingEnabled = true;
            this.combo_vehiculo.Location = new System.Drawing.Point(94, 137);
            this.combo_vehiculo.Name = "combo_vehiculo";
            this.combo_vehiculo.Size = new System.Drawing.Size(282, 21);
            this.combo_vehiculo.TabIndex = 56;
            // 
            // cbfolios
            // 
            this.cbfolios.AutoSize = true;
            this.cbfolios.Location = new System.Drawing.Point(18, 107);
            this.cbfolios.Name = "cbfolios";
            this.cbfolios.Size = new System.Drawing.Size(15, 14);
            this.cbfolios.TabIndex = 12;
            this.cbfolios.UseVisualStyleBackColor = true;
            this.cbfolios.CheckedChanged += new System.EventHandler(this.cbfolios_CheckedChanged);
            // 
            // cbfechas
            // 
            this.cbfechas.AutoSize = true;
            this.cbfechas.Enabled = false;
            this.cbfechas.Location = new System.Drawing.Point(18, 68);
            this.cbfechas.Name = "cbfechas";
            this.cbfechas.Size = new System.Drawing.Size(15, 14);
            this.cbfechas.TabIndex = 11;
            this.cbfechas.UseVisualStyleBackColor = true;
            this.cbfechas.CheckedChanged += new System.EventHandler(this.cbfechas_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(214, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Hasta :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Desde :";
            // 
            // errorTxtBox2
            // 
            this.errorTxtBox2.Enabled = false;
            this.errorTxtBox2.Location = new System.Drawing.Point(274, 101);
            this.errorTxtBox2.Name = "errorTxtBox2";
            this.errorTxtBox2.Size = new System.Drawing.Size(102, 20);
            this.errorTxtBox2.TabIndex = 8;
            this.errorTxtBox2.Validar = false;
            this.errorTxtBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.errorTxtBox2_KeyPress);
            // 
            // errorTxtBox1
            // 
            this.errorTxtBox1.Enabled = false;
            this.errorTxtBox1.Location = new System.Drawing.Point(94, 101);
            this.errorTxtBox1.Name = "errorTxtBox1";
            this.errorTxtBox1.Size = new System.Drawing.Size(102, 20);
            this.errorTxtBox1.TabIndex = 7;
            this.errorTxtBox1.Validar = false;
            this.errorTxtBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.errorTxtBox1_KeyPress);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker2.Enabled = false;
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(274, 63);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(102, 20);
            this.dateTimePicker2.TabIndex = 6;
            this.dateTimePicker2.Value = new System.DateTime(2019, 11, 12, 20, 0, 54, 0);
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            this.dateTimePicker2.Validating += new System.ComponentModel.CancelEventHandler(this.dateTimePicker2_Validating);
            this.dateTimePicker2.Validated += new System.EventHandler(this.dateTimePicker2_Validated);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(94, 63);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(102, 20);
            this.dateTimePicker1.TabIndex = 5;
            this.dateTimePicker1.Value = new System.DateTime(2019, 11, 12, 20, 0, 43, 0);
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            this.dateTimePicker1.Validating += new System.ComponentModel.CancelEventHandler(this.dateTimePicker1_Validating);
            this.dateTimePicker1.Validated += new System.EventHandler(this.dateTimePicker1_Validated);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(214, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Hasta :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Desde :";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(286, 26);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(79, 17);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.Text = "Entregados";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(145, 26);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(79, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.Text = "Disponibles";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(28, 26);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(55, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Todos";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tp1);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(440, 237);
            this.tabControl1.TabIndex = 1;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmFiltroVal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 298);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmFiltroVal";
            this.Text = "Reporte de Vales de Combustible";
            this.Load += new System.EventHandler(this.frmFiltroVal_Load);
            this.Controls.SetChildIndex(this.tabControl1, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.btnsalir, 0);
            this.tp1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage tp1;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.CheckBox cbfolios;
        public System.Windows.Forms.CheckBox cbfechas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private MiLibreria.ErrorTxtBox errorTxtBox2;
        private MiLibreria.ErrorTxtBox errorTxtBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        public System.Windows.Forms.CheckBox cbvehiculo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox combo_vehiculo;
    }
}