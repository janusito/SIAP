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
using MySql.Data.Types;
using MiLibreria;
using System.Configuration;


namespace SIAP
{
    public partial class frmtarifas : frmbase
    {
        MySqlConnection cnn = new MySqlConnection();
        MySqlCommand cmd = new MySqlCommand();
        DataSet ds = new DataSet();

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

        public frmtarifas()
        {
            InitializeComponent();
        }

        private void frmtarifas_Load(object sender, EventArgs e)
        {
            act_tarifa();
        }

        public void act_tarifa()
        {
            conectar();
            cmd = new MySqlCommand("SELECT * FROM tarifas;", cnn);
            MySqlDataAdapter con = new MySqlDataAdapter(cmd);
            ds = new DataSet();
            con.Fill(ds);

            txttar1.Text= ds.Tables[0].Rows[0]["tar_cos"].ToString();
            txttar2.Text = ds.Tables[0].Rows[0]["tar_tra"].ToString();
            txttar3.Text = ds.Tables[0].Rows[0]["tar_ayu"].ToString();
            
            desconectar();
        }

        private void txttar1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utilidades.SoloNumeros(e);
        }

        private void txttar2_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utilidades.SoloNumeros(e);
        }

        private void txttar3_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utilidades.SoloNumeros(e);
        }

        private void txttar1_Validated(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void txttar2_Validated(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void txttar3_Validated(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Utilidades.ValidarFormulario(this, errorProvider1) == false)
            {
                conectar();
                //inicia rutina de modificar
                cmd = new MySqlCommand("upd_tarifa", cnn);
                cmd.CommandType = CommandType.StoredProcedure;

                MySqlParameter p_id_tarifa = new MySqlParameter("_id_tarifa", MySqlDbType.Int32);
                p_id_tarifa.Value = int.Parse("1");
                cmd.Parameters.Add(p_id_tarifa);

                MySqlParameter p_tar_cos = new MySqlParameter("_tar_cos", MySqlDbType.Decimal);
                p_tar_cos.Value = decimal.Parse(txttar1.Text);
                cmd.Parameters.Add(p_tar_cos);

                MySqlParameter p_tar_tra = new MySqlParameter("_tar_tra", MySqlDbType.Decimal);
                p_tar_tra.Value = decimal.Parse(txttar2.Text);
                cmd.Parameters.Add(p_tar_tra);

                MySqlParameter p_tar_ayu = new MySqlParameter("_tar_ayu", MySqlDbType.Decimal);
                p_tar_ayu.Value = decimal.Parse(txttar3.Text);
                cmd.Parameters.Add(p_tar_ayu);

                try
                {
                    cmd.ExecuteNonQuery();
                    desconectar();
                    act_tarifa();
                    MessageBox.Show("Tarifas Actualizadas.");
                }
                catch (Exception error)
                {
                    MessageBox.Show("Ha ocurrido un error. " + error.Message);
                }
            }
        }
    }
}
