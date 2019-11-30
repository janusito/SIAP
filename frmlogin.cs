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
using MiLibreria;
using System.Configuration;


namespace SIAP
{
    public partial class frmlogin : frmbase
    {
        MySqlConnection cnn = new MySqlConnection();
        MySqlCommand cmd = new MySqlCommand();
        MySqlCommand cmd2 = new MySqlCommand();
        DataSet ds = new DataSet();
        Utilidades cma = new Utilidades();

        public void conectar()
        {
            cnn.Close();
            cnn.ConnectionString = ConfigurationManager.ConnectionStrings["default"].ConnectionString;
            cnn.Open();
        }
        public void desconectar()
        {
            cnn.Close();
        }

        public frmlogin()
        {
            InitializeComponent();
        }

        private void btningresar_Click(object sender, EventArgs e)
        {
            conectar();
            string str = "SELECT * FROM usuarios WHERE (AES_DECRYPT(passstrong,'"+ Utilidades.ccx666 + "'))='" + txtpassword.Text + "' and usuario='"+ txtusuario.Text + "' ";

            MySqlCommand cmd = new MySqlCommand(str, cnn);
            MySqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                Program.sta_administrador = dr["administrador"].ToString();
                Program.sta_nombre = dr["nombre"].ToString();
                Program.sta_usuario = dr["usuario"].ToString();

                Contenedorprincipal principal = new Contenedorprincipal();
                desconectar();
                principal.Show();
                this.Hide();
            }else
            {
                MessageBox.Show("Usuario o Contraseña incorrectos, verifique.");
            }
            desconectar();

        }

        private void frmlogin_Load(object sender, EventArgs e)
        {
            txtusuario.Focus();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {

        }
    }
}