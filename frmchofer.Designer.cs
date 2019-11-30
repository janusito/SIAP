namespace SIAP
{
    partial class frmchofer
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
            this.txtidchof = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dg1 = new System.Windows.Forms.DataGridView();
            this.btnnuevo = new System.Windows.Forms.Button();
            this.btnedit = new System.Windows.Forms.Button();
            this.txtnomchof = new MiLibreria.ErrorTxtBox();
            this.txtpaterno = new MiLibreria.ErrorTxtBox();
            this.txtmaterno = new MiLibreria.ErrorTxtBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg1)).BeginInit();
            this.SuspendLayout();
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(600, 76);
            this.button5.Size = new System.Drawing.Size(119, 27);
            this.button5.TabIndex = 6;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(600, 172);
            this.button4.Size = new System.Drawing.Size(119, 27);
            this.button4.TabIndex = 10;
            this.button4.Text = "Grabar";
            this.button4.Visible = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(600, 124);
            this.button3.Size = new System.Drawing.Size(119, 27);
            this.button3.TabIndex = 7;
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
            this.button1.Location = new System.Drawing.Point(343, 59);
            this.button1.Size = new System.Drawing.Size(119, 27);
            // 
            // btnsalir
            // 
            this.btnsalir.Location = new System.Drawing.Point(600, 220);
            this.btnsalir.Size = new System.Drawing.Size(119, 27);
            this.btnsalir.TabIndex = 9;
            // 
            // txtidchof
            // 
            this.txtidchof.BackColor = System.Drawing.SystemColors.Info;
            this.txtidchof.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtidchof.Location = new System.Drawing.Point(229, 63);
            this.txtidchof.Name = "txtidchof";
            this.txtidchof.Size = new System.Drawing.Size(89, 20);
            this.txtidchof.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(62, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Id. Operador / Chofer :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(62, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(62, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Apellido Paterno";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(62, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Apellido Materno";
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
            // btnnuevo
            // 
            this.btnnuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnuevo.Location = new System.Drawing.Point(600, 29);
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.Size = new System.Drawing.Size(119, 27);
            this.btnnuevo.TabIndex = 5;
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
            this.btnedit.TabIndex = 8;
            this.btnedit.Text = "Modificar";
            this.btnedit.UseVisualStyleBackColor = true;
            this.btnedit.Click += new System.EventHandler(this.Btnedit_Click);
            // 
            // txtnomchof
            // 
            this.txtnomchof.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtnomchof.Location = new System.Drawing.Point(221, 107);
            this.txtnomchof.MaxLength = 40;
            this.txtnomchof.Name = "txtnomchof";
            this.txtnomchof.Size = new System.Drawing.Size(339, 20);
            this.txtnomchof.TabIndex = 2;
            this.txtnomchof.Validar = true;
            this.txtnomchof.TextChanged += new System.EventHandler(this.Txtdescripv_TextChanged);
            // 
            // txtpaterno
            // 
            this.txtpaterno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtpaterno.Location = new System.Drawing.Point(221, 151);
            this.txtpaterno.MaxLength = 40;
            this.txtpaterno.Name = "txtpaterno";
            this.txtpaterno.Size = new System.Drawing.Size(339, 20);
            this.txtpaterno.TabIndex = 3;
            this.txtpaterno.Validar = true;
            this.txtpaterno.TextChanged += new System.EventHandler(this.Txtplaca_TextChanged);
            // 
            // txtmaterno
            // 
            this.txtmaterno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtmaterno.Location = new System.Drawing.Point(221, 195);
            this.txtmaterno.MaxLength = 40;
            this.txtmaterno.Name = "txtmaterno";
            this.txtmaterno.Size = new System.Drawing.Size(339, 20);
            this.txtmaterno.TabIndex = 4;
            this.txtmaterno.Validar = true;
            // 
            // frmchofer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 478);
            this.Controls.Add(this.txtmaterno);
            this.Controls.Add(this.txtpaterno);
            this.Controls.Add(this.txtnomchof);
            this.Controls.Add(this.btnedit);
            this.Controls.Add(this.btnnuevo);
            this.Controls.Add(this.dg1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtidchof);
            this.Name = "frmchofer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation;
            this.Text = "Operadores / Choferes";
            this.Load += new System.EventHandler(this.Frmchofer_Load);
            this.Controls.SetChildIndex(this.button4, 0);
            this.Controls.SetChildIndex(this.button2, 0);
            this.Controls.SetChildIndex(this.txtidchof, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.dg1, 0);
            this.Controls.SetChildIndex(this.btnnuevo, 0);
            this.Controls.SetChildIndex(this.btnedit, 0);
            this.Controls.SetChildIndex(this.txtnomchof, 0);
            this.Controls.SetChildIndex(this.button5, 0);
            this.Controls.SetChildIndex(this.btnsalir, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.button3, 0);
            this.Controls.SetChildIndex(this.txtpaterno, 0);
            this.Controls.SetChildIndex(this.txtmaterno, 0);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtidchof;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dg1;
        private System.Windows.Forms.Button btnnuevo;
        private System.Windows.Forms.Button btnedit;
        private MiLibreria.ErrorTxtBox txtnomchof;
        private MiLibreria.ErrorTxtBox txtpaterno;
        private MiLibreria.ErrorTxtBox txtmaterno;
    }
}