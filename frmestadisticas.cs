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
using Microsoft.Reporting.WinForms;
using System.Configuration;
using System.Windows.Forms.DataVisualization.Charting;


namespace SIAP
{
    public partial class frmestadisticas : frmbase
    {
        MySqlConnection cnn = new MySqlConnection();
        MySqlCommand cmd = new MySqlCommand();
        MySqlCommand cmd2 = new MySqlCommand();
        DataSet ds = new DataSet();
        Utilidades cma = new Utilidades();

        public frmestadisticas()
        {
            InitializeComponent();
        }

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


        private void frmestadisticas_Load(object sender, EventArgs e)
        {
            loadchart();           
        }

        public void loadchart()
        {
            try
            {
                conectar();
                string str = "SELECT * from ingreso_xano;";
                MySqlCommand cmd = new MySqlCommand(str, cnn);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                ds = new DataSet();
                da.Fill(ds);
                chingresoxano.DataSource = ds.Tables[0];
                Series serie1 = chingresoxano.Series["Series1"];
                serie1.Name = "Toneladas Entregadas al Ingenio";

                var chart = chingresoxano;

                chart.Series[serie1.Name].XValueMember = "ano";
                chart.Series[serie1.Name].YValueMembers = "toneladas";

                chart.Series[0].IsValueShownAsLabel = true;

                desconectar();

            }
            catch (Exception error)
            {
                MessageBox.Show("Error : " + error.Message);
                throw;
            }
        }
    }
}
