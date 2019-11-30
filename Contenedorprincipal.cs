using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace SIAP
{
    public partial class Contenedorprincipal : Form
    {
        private int childFormNumber = 0;

        public Contenedorprincipal()
        {
            InitializeComponent();
            lblcntusr.Text = ConfigurationManager.ConnectionStrings["default"].ConnectionString;
            if (Program.sta_administrador=="A")
            {
                administracionDeUsuariosToolStripMenuItem.Visible = true;
            }
            else
            {
                administracionDeUsuariosToolStripMenuItem.Visible = false;
            }
            lblcntusr.Text = Program.sta_usuario;
            lblcntnombre.Text = Program.sta_nombre;
            if (Program.sta_administrador=="A")
            {
                lblcnttipo.Text = "ADMINISTRADOR";
            }
            else
            {
                lblcnttipo.Text = "USUARIO ESTANDAR";
            }
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Ventana " + childFormNumber++;
            childForm.Show();
        }
        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }


        private void VehiculosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmvehiculo fvehi = new frmvehiculo();
            fvehi.MdiParent = this;
            fvehi.Show();
        }

        private void HelpToolStripButton_Click(object sender, EventArgs e)
        {
            frmvehiculo fvehi = new frmvehiculo();
            fvehi.MdiParent = this;
            fvehi.Show();
        }

        private void ConductoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmchofer fchof = new frmchofer();
            fchof.MdiParent = this;
            fchof.Show();
        }

        private void ToolStripButton1_Click(object sender, EventArgs e)
        {
            frmchofer fchof = new frmchofer();
            fchof.MdiParent = this;
            fchof.Show();
        }

        private void ToolStripButton2_Click(object sender, EventArgs e)
        {
            frmvale fval = new frmvale();
            fval.MdiParent = this;
            fval.Show();
        }

        private void despachoDeValesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmvale fval = new frmvale();
            fval.MdiParent = this;
            fval.Show();
        }

        private void stockDeValesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFiltroVal fval = new frmFiltroVal();
            fval.MdiParent = this;
            fval.Show();

        }

        private void VehiculosYMaquinariaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmvehiculo fvehi = new frmvehiculo();
            fvehi.MdiParent = this;
            fvehi.Show();
        }

        private void OperadoresDeMaquinariaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmchofer fchof = new frmchofer();
            fchof.MdiParent = this;
            fchof.Show();
        }

        private void ControlDeValesDeCombustibleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmvale fval = new frmvale();
            fval.MdiParent = this;
            fval.Show();
        }

        private void ReportesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFiltroVal fval = new frmFiltroVal();
            fval.MdiParent = this;
            fval.Show();
        }

        private void RegistroDeTicketsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmtickets fticket = new frmtickets();
            fticket.MdiParent = this;
            fticket.Show();
        }

        private void Contenedorprincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Desea Salir del Sistema ?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                System.Environment.Exit(0);
            }
            else
            {
                e.Cancel = true;
            }

        }

        private void reportesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
        }

        private void salirDelSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea Salir del Sistema ?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                System.Environment.Exit(0);
            }

        }

        private void Contenedorprincipal_Leave(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            frmFiltroVal fval = new frmFiltroVal();
            fval.MdiParent = this;
            fval.Show();
        }

        private void tarifasPcalculoRayaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmtarifas ftar = new frmtarifas();
            ftar.MdiParent = this;
            ftar.Show();
        }

        private void calculoDeRayaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmraya fraya = new frmraya();
            fraya.MdiParent = this;
            fraya.Show();
        }

        private void administracionDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmusuarios fusu = new frmusuarios();
            fusu.MdiParent = this;
            fusu.Show();
        }

        private void Contenedorprincipal_Load(object sender, EventArgs e)
        {

        }

        private void estadisticasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmestadisticas festa = new frmestadisticas();
            festa.MdiParent = this;
            festa.Show();
        }

    }
}
