namespace SIAP
{
    partial class frmvehiculo
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
            this.txtidveh = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dg1 = new System.Windows.Forms.DataGridView();
            this.rb1 = new System.Windows.Forms.RadioButton();
            this.rb2 = new System.Windows.Forms.RadioButton();
            this.combo_chofer = new System.Windows.Forms.ComboBox();
            this.btnnuevo = new System.Windows.Forms.Button();
            this.btnedit = new System.Windows.Forms.Button();
            this.txtdescripv = new MiLibreria.ErrorTxtBox();
            this.txtplaca = new MiLibreria.ErrorTxtBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg1)).BeginInit();
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
            this.button2.TabIndex = 7;
            this.button2.Text = "Guardar";
            this.button2.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(310, 32);
            this.button1.Size = new System.Drawing.Size(119, 27);
            this.button1.TabIndex = 12;
            // 
            // btnsalir
            // 
            this.btnsalir.Location = new System.Drawing.Point(600, 220);
            this.btnsalir.Size = new System.Drawing.Size(119, 27);
            this.btnsalir.TabIndex = 11;
            // 
            // txtidveh
            // 
            this.txtidveh.BackColor = System.Drawing.SystemColors.Info;
            this.txtidveh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtidveh.Location = new System.Drawing.Point(206, 39);
            this.txtidveh.Name = "txtidveh";
            this.txtidveh.Size = new System.Drawing.Size(89, 20);
            this.txtidveh.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(62, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Id. Vehiculo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(62, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Descripción";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(62, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Placa / No. Serie";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(62, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Tipo de Vehiculo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(65, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "Chofer Asignado";
            // 
            // dg1
            // 
            this.dg1.AllowUserToAddRows = false;
            this.dg1.AllowUserToDeleteRows = false;
            this.dg1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg1.Location = new System.Drawing.Point(65, 265);
            this.dg1.Name = "dg1";
            this.dg1.ReadOnly = true;
            this.dg1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg1.Size = new System.Drawing.Size(654, 186);
            this.dg1.TabIndex = 0;
            this.dg1.SelectionChanged += new System.EventHandler(this.Dg1_SelectionChanged);
            // 
            // rb1
            // 
            this.rb1.AutoSize = true;
            this.rb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb1.Location = new System.Drawing.Point(206, 157);
            this.rb1.Name = "rb1";
            this.rb1.Size = new System.Drawing.Size(71, 20);
            this.rb1.TabIndex = 4;
            this.rb1.Text = "Urbano";
            this.rb1.UseVisualStyleBackColor = true;
            // 
            // rb2
            // 
            this.rb2.AutoSize = true;
            this.rb2.Checked = true;
            this.rb2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb2.Location = new System.Drawing.Point(322, 156);
            this.rb2.Name = "rb2";
            this.rb2.Size = new System.Drawing.Size(76, 20);
            this.rb2.TabIndex = 5;
            this.rb2.TabStop = true;
            this.rb2.Text = "Agricola";
            this.rb2.UseVisualStyleBackColor = true;
            // 
            // combo_chofer
            // 
            this.combo_chofer.FormattingEnabled = true;
            this.combo_chofer.Location = new System.Drawing.Point(206, 198);
            this.combo_chofer.Name = "combo_chofer";
            this.combo_chofer.Size = new System.Drawing.Size(359, 21);
            this.combo_chofer.TabIndex = 6;
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
            // txtdescripv
            // 
            this.txtdescripv.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtdescripv.Location = new System.Drawing.Point(206, 81);
            this.txtdescripv.MaxLength = 40;
            this.txtdescripv.Name = "txtdescripv";
            this.txtdescripv.Size = new System.Drawing.Size(359, 20);
            this.txtdescripv.TabIndex = 17;
            this.txtdescripv.Validar = true;
            this.txtdescripv.TextChanged += new System.EventHandler(this.Txtdescripv_TextChanged);
            // 
            // txtplaca
            // 
            this.txtplaca.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtplaca.Location = new System.Drawing.Point(206, 115);
            this.txtplaca.MaxLength = 10;
            this.txtplaca.Name = "txtplaca";
            this.txtplaca.Size = new System.Drawing.Size(153, 20);
            this.txtplaca.TabIndex = 18;
            this.txtplaca.Validar = true;
            this.txtplaca.TextChanged += new System.EventHandler(this.Txtplaca_TextChanged);
            // 
            // frmvehiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 478);
            this.Controls.Add(this.txtplaca);
            this.Controls.Add(this.txtdescripv);
            this.Controls.Add(this.btnedit);
            this.Controls.Add(this.btnnuevo);
            this.Controls.Add(this.combo_chofer);
            this.Controls.Add(this.rb2);
            this.Controls.Add(this.rb1);
            this.Controls.Add(this.dg1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtidveh);
            this.Name = "frmvehiculo";
            this.Text = "Vehiculos y Maquinaria";
            this.Load += new System.EventHandler(this.Frmvehiculo_Load);
            this.Controls.SetChildIndex(this.txtidveh, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.dg1, 0);
            this.Controls.SetChildIndex(this.rb1, 0);
            this.Controls.SetChildIndex(this.rb2, 0);
            this.Controls.SetChildIndex(this.combo_chofer, 0);
            this.Controls.SetChildIndex(this.btnnuevo, 0);
            this.Controls.SetChildIndex(this.btnedit, 0);
            this.Controls.SetChildIndex(this.txtdescripv, 0);
            this.Controls.SetChildIndex(this.button5, 0);
            this.Controls.SetChildIndex(this.btnsalir, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.button3, 0);
            this.Controls.SetChildIndex(this.button4, 0);
            this.Controls.SetChildIndex(this.button2, 0);
            this.Controls.SetChildIndex(this.txtplaca, 0);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtidveh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dg1;
        private System.Windows.Forms.RadioButton rb1;
        private System.Windows.Forms.RadioButton rb2;
        private System.Windows.Forms.ComboBox combo_chofer;
        private System.Windows.Forms.Button btnnuevo;
        private System.Windows.Forms.Button btnedit;
        private MiLibreria.ErrorTxtBox txtdescripv;
        private MiLibreria.ErrorTxtBox txtplaca;
    }
}