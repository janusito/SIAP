namespace SIAP
{
    partial class frmtarifas
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
            this.label3 = new System.Windows.Forms.Label();
            this.txttar1 = new MiLibreria.ErrorTxtBox();
            this.txttar2 = new MiLibreria.ErrorTxtBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txttar3 = new MiLibreria.ErrorTxtBox();
            this.label5 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnsalir
            // 
            this.btnsalir.Location = new System.Drawing.Point(207, 161);
            this.btnsalir.Size = new System.Drawing.Size(142, 31);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tarifa Operador de Cosechadora :";
            // 
            // txttar1
            // 
            this.txttar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttar1.Location = new System.Drawing.Point(201, 35);
            this.txttar1.Name = "txttar1";
            this.txttar1.Size = new System.Drawing.Size(119, 22);
            this.txttar1.TabIndex = 8;
            this.txttar1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txttar1.Validar = true;
            this.txttar1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txttar1_KeyPress);
            this.txttar1.Validated += new System.EventHandler(this.txttar1_Validated);
            // 
            // txttar2
            // 
            this.txttar2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttar2.Location = new System.Drawing.Point(201, 70);
            this.txttar2.Name = "txttar2";
            this.txttar2.Size = new System.Drawing.Size(119, 22);
            this.txttar2.TabIndex = 10;
            this.txttar2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txttar2.Validar = true;
            this.txttar2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txttar2_KeyPress);
            this.txttar2.Validated += new System.EventHandler(this.txttar2_Validated);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Tarifa Operador de Tractor :";
            // 
            // txttar3
            // 
            this.txttar3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttar3.Location = new System.Drawing.Point(201, 105);
            this.txttar3.Name = "txttar3";
            this.txttar3.Size = new System.Drawing.Size(119, 22);
            this.txttar3.TabIndex = 12;
            this.txttar3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txttar3.Validar = true;
            this.txttar3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txttar3_KeyPress);
            this.txttar3.Validated += new System.EventHandler(this.txttar3_Validated);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Tarifa Ayudante de Tractorista :";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 161);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 31);
            this.button1.TabIndex = 13;
            this.button1.Text = "Grabar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmtarifas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 209);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txttar3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txttar2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txttar1);
            this.Controls.Add(this.label3);
            this.Name = "frmtarifas";
            this.Text = "Tarifas por Acarreo";
            this.Load += new System.EventHandler(this.frmtarifas_Load);
            this.Controls.SetChildIndex(this.btnsalir, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.txttar1, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.txttar2, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.txttar3, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private MiLibreria.ErrorTxtBox txttar1;
        private MiLibreria.ErrorTxtBox txttar2;
        private System.Windows.Forms.Label label4;
        private MiLibreria.ErrorTxtBox txttar3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button button1;
    }
}