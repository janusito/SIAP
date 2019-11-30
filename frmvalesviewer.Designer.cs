namespace SIAP
{
    partial class frmvalesviewer
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
            this.DS_vales = new SIAP.DS_vales();
            this.vistavaleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rptvale = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.DS_vales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistavaleBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // DS_vales
            // 
            this.DS_vales.DataSetName = "DS_vales";
            this.DS_vales.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vistavaleBindingSource
            // 
            this.vistavaleBindingSource.DataMember = "vistavale";
            this.vistavaleBindingSource.DataSource = this.DS_vales;
            // 
            // rptvale
            // 
            this.rptvale.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rptvale.Location = new System.Drawing.Point(0, 0);
            this.rptvale.Name = "rptvale";
            this.rptvale.ServerReport.BearerToken = null;
            this.rptvale.Size = new System.Drawing.Size(798, 523);
            this.rptvale.TabIndex = 0;
            // 
            // frmvalesviewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 523);
            this.Controls.Add(this.rptvale);
            this.MinimizeBox = false;
            this.Name = "frmvalesviewer";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte de vales de combustible";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmvalesviewer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DS_vales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistavaleBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource vistavaleBindingSource;
        private DS_vales DS_vales;
        private Microsoft.Reporting.WinForms.ReportViewer rptvale;
    }
}