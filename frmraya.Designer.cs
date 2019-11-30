namespace SIAP
{
    partial class frmraya
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
            this.dgresumen = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtimp_co = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mtxte3 = new System.Windows.Forms.MaskedTextBox();
            this.mtxte2 = new System.Windows.Forms.MaskedTextBox();
            this.mtxte1 = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtimp_ay = new System.Windows.Forms.MaskedTextBox();
            this.txtimp_op = new System.Windows.Forms.MaskedTextBox();
            this.txttons_op = new System.Windows.Forms.MaskedTextBox();
            this.txtequipo = new MiLibreria.ErrorTxtBox();
            this.txtsemana = new MiLibreria.ErrorTxtBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtoperador = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.txttontot = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnprintraya = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgresumen)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnsalir
            // 
            this.btnsalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsalir.Location = new System.Drawing.Point(744, 441);
            this.btnsalir.Size = new System.Drawing.Size(97, 21);
            // 
            // dgresumen
            // 
            this.dgresumen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgresumen.Location = new System.Drawing.Point(12, 236);
            this.dgresumen.Name = "dgresumen";
            this.dgresumen.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgresumen.Size = new System.Drawing.Size(829, 158);
            this.dgresumen.TabIndex = 26;
            this.dgresumen.SelectionChanged += new System.EventHandler(this.dgresumen_SelectionChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtimp_co);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.txtimp_ay);
            this.groupBox2.Controls.Add(this.txtimp_op);
            this.groupBox2.Controls.Add(this.txttons_op);
            this.groupBox2.Controls.Add(this.txtequipo);
            this.groupBox2.Controls.Add(this.txtsemana);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txtoperador);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(829, 218);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos de Raya";
            // 
            // txtimp_co
            // 
            this.txtimp_co.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtimp_co.Location = new System.Drawing.Point(682, 58);
            this.txtimp_co.Name = "txtimp_co";
            this.txtimp_co.ReadOnly = true;
            this.txtimp_co.Size = new System.Drawing.Size(119, 20);
            this.txtimp_co.TabIndex = 53;
            this.txtimp_co.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtimp_co.ValidatingType = typeof(int);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(531, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 13);
            this.label2.TabIndex = 52;
            this.label2.Text = "RAYA COSECHADORA :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(557, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 13);
            this.label5.TabIndex = 51;
            this.label5.Text = "RAYA AYUDANTE :";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(222, 23);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(110, 23);
            this.button4.TabIndex = 1;
            this.button4.Text = "Consultar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mtxte3);
            this.groupBox1.Controls.Add(this.mtxte2);
            this.groupBox1.Controls.Add(this.mtxte1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Location = new System.Drawing.Point(259, 106);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 99);
            this.groupBox1.TabIndex = 50;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tarifas";
            // 
            // mtxte3
            // 
            this.mtxte3.Location = new System.Drawing.Point(90, 68);
            this.mtxte3.Mask = "99999";
            this.mtxte3.Name = "mtxte3";
            this.mtxte3.ReadOnly = true;
            this.mtxte3.Size = new System.Drawing.Size(100, 20);
            this.mtxte3.TabIndex = 28;
            this.mtxte3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.mtxte3.ValidatingType = typeof(int);
            // 
            // mtxte2
            // 
            this.mtxte2.Location = new System.Drawing.Point(90, 42);
            this.mtxte2.Mask = "99999";
            this.mtxte2.Name = "mtxte2";
            this.mtxte2.ReadOnly = true;
            this.mtxte2.Size = new System.Drawing.Size(100, 20);
            this.mtxte2.TabIndex = 27;
            this.mtxte2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.mtxte2.ValidatingType = typeof(int);
            // 
            // mtxte1
            // 
            this.mtxte1.Location = new System.Drawing.Point(90, 16);
            this.mtxte1.Mask = "99999";
            this.mtxte1.Name = "mtxte1";
            this.mtxte1.ReadOnly = true;
            this.mtxte1.Size = new System.Drawing.Size(100, 20);
            this.mtxte1.TabIndex = 26;
            this.mtxte1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.mtxte1.ValidatingType = typeof(int);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Ayudante :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Tractorista :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Cosechadora :";
            // 
            // txtimp_ay
            // 
            this.txtimp_ay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtimp_ay.Location = new System.Drawing.Point(682, 132);
            this.txtimp_ay.Name = "txtimp_ay";
            this.txtimp_ay.ReadOnly = true;
            this.txtimp_ay.Size = new System.Drawing.Size(119, 20);
            this.txtimp_ay.TabIndex = 49;
            this.txtimp_ay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtimp_op
            // 
            this.txtimp_op.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtimp_op.Location = new System.Drawing.Point(682, 99);
            this.txtimp_op.Name = "txtimp_op";
            this.txtimp_op.ReadOnly = true;
            this.txtimp_op.Size = new System.Drawing.Size(119, 20);
            this.txtimp_op.TabIndex = 46;
            this.txtimp_op.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtimp_op.ValidatingType = typeof(int);
            // 
            // txttons_op
            // 
            this.txttons_op.Location = new System.Drawing.Point(132, 103);
            this.txttons_op.Name = "txttons_op";
            this.txttons_op.ReadOnly = true;
            this.txttons_op.Size = new System.Drawing.Size(86, 20);
            this.txttons_op.TabIndex = 44;
            this.txttons_op.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtequipo
            // 
            this.txtequipo.Location = new System.Drawing.Point(132, 51);
            this.txtequipo.Name = "txtequipo";
            this.txtequipo.ReadOnly = true;
            this.txtequipo.Size = new System.Drawing.Size(327, 20);
            this.txtequipo.TabIndex = 43;
            this.txtequipo.Validar = false;
            // 
            // txtsemana
            // 
            this.txtsemana.Location = new System.Drawing.Point(132, 25);
            this.txtsemana.Name = "txtsemana";
            this.txtsemana.Size = new System.Drawing.Size(68, 20);
            this.txtsemana.TabIndex = 0;
            this.txtsemana.Validar = true;
            this.txtsemana.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtsemana_KeyPress);
            this.txtsemana.Validated += new System.EventHandler(this.txtsemana_Validated);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 106);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(119, 13);
            this.label10.TabIndex = 40;
            this.label10.Text = "Toneladas entregadas :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(69, 80);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 13);
            this.label11.TabIndex = 39;
            this.label11.Text = "Operador :";
            // 
            // txtoperador
            // 
            this.txtoperador.Location = new System.Drawing.Point(132, 77);
            this.txtoperador.Name = "txtoperador";
            this.txtoperador.ReadOnly = true;
            this.txtoperador.Size = new System.Drawing.Size(327, 20);
            this.txtoperador.TabIndex = 36;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(555, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 13);
            this.label4.TabIndex = 34;
            this.label4.Text = "RAYA OPERADOR :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 13);
            this.label3.TabIndex = 33;
            this.label3.Text = "Equipo de Acarreo :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Numero de Semana :";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // txttontot
            // 
            this.txttontot.Location = new System.Drawing.Point(572, 402);
            this.txttontot.Name = "txttontot";
            this.txttontot.ReadOnly = true;
            this.txttontot.Size = new System.Drawing.Size(86, 20);
            this.txttontot.TabIndex = 46;
            this.txttontot.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(465, 405);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 13);
            this.label9.TabIndex = 45;
            this.label9.Text = "Toneladas Totales :";
            // 
            // btnprintraya
            // 
            this.btnprintraya.Location = new System.Drawing.Point(664, 400);
            this.btnprintraya.Name = "btnprintraya";
            this.btnprintraya.Size = new System.Drawing.Size(75, 23);
            this.btnprintraya.TabIndex = 47;
            this.btnprintraya.Text = "Imprimir";
            this.btnprintraya.UseVisualStyleBackColor = true;
            this.btnprintraya.Click += new System.EventHandler(this.btnprintraya_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SIAP.Properties.Resources.IMG_20191118_230627;
            this.pictureBox1.Location = new System.Drawing.Point(10, 132);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(242, 73);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 51;
            this.pictureBox1.TabStop = false;
            // 
            // frmraya
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 474);
            this.Controls.Add(this.btnprintraya);
            this.Controls.Add(this.txttontot);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgresumen);
            this.Name = "frmraya";
            this.Text = "Calculo de raya por acarreo";
            this.Load += new System.EventHandler(this.frmraya_Load);
            this.Controls.SetChildIndex(this.btnsalir, 0);
            this.Controls.SetChildIndex(this.dgresumen, 0);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.Controls.SetChildIndex(this.label9, 0);
            this.Controls.SetChildIndex(this.txttontot, 0);
            this.Controls.SetChildIndex(this.btnprintraya, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgresumen)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgresumen;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtoperador;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox mtxte3;
        private System.Windows.Forms.MaskedTextBox mtxte2;
        private System.Windows.Forms.MaskedTextBox mtxte1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox txtimp_ay;
        private System.Windows.Forms.MaskedTextBox txtimp_op;
        private System.Windows.Forms.MaskedTextBox txttons_op;
        private MiLibreria.ErrorTxtBox txtequipo;
        private MiLibreria.ErrorTxtBox txtsemana;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox txtimp_co;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox txttontot;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnprintraya;
    }
}