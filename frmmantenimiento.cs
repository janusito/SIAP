using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIAP
{
    public partial class frmmantenimiento : frmbase
    {
        public frmmantenimiento()
        {
            InitializeComponent();
        }

        private void Frmmantenimiento_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            buscar();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            agregar();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            eliminar();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            modificar();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            limpiar();
        }
    }
}
