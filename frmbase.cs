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
    public partial class frmbase : Form
    {
        public frmbase()
        {
            InitializeComponent();
        }

        private void Frmbase_Load(object sender, EventArgs e)
        {

        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Desea salir ?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        public virtual void eliminar()
        {

        }

        public virtual void modificar()
        {

        }

        public virtual Boolean buscar()
        {
            return false;
        }

        public virtual Boolean agregar()
        {
            return false;
        }

        public virtual void limpiar()
        {

        }
    }
}
