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

namespace SIAP
{
    public partial class frmraya : frmbase
    {
        MySqlConnection cnn = new MySqlConnection();
        MySqlCommand cmd = new MySqlCommand();
        MySqlCommand cmd2 = new MySqlCommand();
        DataSet ds = new DataSet();
        Utilidades cma = new Utilidades();

        public string sem = "";
        public double sum = 0;
        public string cm = "'";


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


        public frmraya()
        {
            InitializeComponent();
        }

        private void frmraya_Load(object sender, EventArgs e)
        {
            rectarifa();
        }

        public Boolean rectarifa()
        {
            try
            {
                conectar();
                cmd = new MySqlCommand("SELECT * FROM tarifas;", cnn);
                MySqlDataAdapter con = new MySqlDataAdapter(cmd);
                ds = new DataSet();
                con.Fill(ds);

                mtxte1.Text = ds.Tables[0].Rows[0]["tar_cos"].ToString();
                mtxte2.Text = ds.Tables[0].Rows[0]["tar_tra"].ToString();
                mtxte3.Text = ds.Tables[0].Rows[0]["tar_ayu"].ToString();

                return true;
            }
            catch (Exception error)
            {
                MessageBox.Show("Error :" + error.Message);
                return false;
            }
        }

        public void actualizadg1()
        {
            conectar();
            cmd = new MySqlCommand("SELECT concat(t2.des_veh, ' / ', t2.pla_veh) as nomveh, concat(t3.nom_chofer,' ',t3.app_chofer,' ',t3.apm_chofer) as nomchofer, t1.semana, count(folio_ticket) AS cant_tickets, sum(toneladas) AS toneladas, ((sum(toneladas))/1000)*" + mtxte2.Text.Trim() + " AS importe_trac, ((sum(toneladas))/1000)*" + mtxte3.Text.Trim() + " AS importe_ayud from ticket t1 INNER JOIN vehiculo t2 ON t1.fk_id_vehiculo = t2.id_vehiculo INNER JOIN chofer t3 ON t3.id_chofer=t2.fk_id_chofer WHERE semana=" + cm+sem + cm+" GROUP BY fk_id_vehiculo;", cnn);
            MySqlDataAdapter con = new MySqlDataAdapter(cmd);
            ds = new DataSet();
            con.Fill(ds);

            dgresumen.DataSource = ds.Tables[0];
            dgresumen.Columns[0].HeaderText = "EQUIPO";
            dgresumen.Columns[1].HeaderText = "OPERADOR";
            dgresumen.Columns[2].HeaderText = "SEM";
            dgresumen.Columns[3].HeaderText = "TICK";
            dgresumen.Columns[4].HeaderText = "TONS. ENTREG.";
            dgresumen.Columns[5].HeaderText = "IMPORTE TRACTORISTA";
            dgresumen.Columns[6].HeaderText = "IMPORTE AYUDANTE";

            dgresumen.Columns[0].Width = 220;
            dgresumen.Columns[1].Width = 220;
            dgresumen.Columns[2].Width = 40;
            dgresumen.Columns[3].Width = 40;
            dgresumen.Columns[4].Width = 80;
            dgresumen.Columns[5].Width = 90;
            dgresumen.Columns[6].Width = 90;

            dgresumen.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgresumen.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgresumen.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgresumen.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgresumen.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dgresumen.Columns[4].DefaultCellStyle.Format = "###,###";
            dgresumen.Columns[5].DefaultCellStyle.Format = "#.##";
            dgresumen.Columns[6].DefaultCellStyle.Format = "##0.00";

            dgresumen.AllowUserToAddRows = false;
            dgresumen.ReadOnly = true;
            desconectar();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            sem = txtsemana.Text;


            if (Utilidades.ValidarFormulario(groupBox2, errorProvider1) == false)
            {

                sem = txtsemana.Text;
                actualizadg1();

                conectar();
                cmd = new MySqlCommand("SELECT t1.semana, count(folio_ticket) AS cant_tickets, sum(toneladas) AS toneladas, ((sum(toneladas)) / 1000) * " + mtxte1.Text.Trim() + " AS importe_tot from ticket t1 INNER JOIN vehiculo t2 ON t1.fk_id_vehiculo = t2.id_vehiculo INNER JOIN chofer t3 ON t3.id_chofer = t2.fk_id_chofer WHERE semana = "+cm+sem+cm+";", cnn);

                MySqlDataAdapter con = new MySqlDataAdapter(cmd);
                ds = new DataSet();
                con.Fill(ds);
                txttontot.Text = ds.Tables[0].Rows[0]["toneladas"].ToString();

                if (txttontot.Text=="")
                {
                    txttontot.Text = "0";
                    txtimp_op.Text = "0";
                    txtimp_ay.Text = "0";
                    txtequipo.Text = "";
                    txtoperador.Text = "";
                    txttons_op.Text = "";
                }

                float var1 = 0;
                float var2 = 0;
                float var3 = 0;

                var1 = float.Parse(txttontot.Text);
                var2 = float.Parse(mtxte1.Text);
                var3 = (var1/1000) * var2;

                txtimp_co.Text = var3.ToString();
                desconectar();

            }
        }

        private void txtsemana_Validated(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void txtsemana_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void dgresumen_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgresumen.SelectedRows)
            {
                txtequipo.Text = row.Cells[0].Value.ToString();
                txtoperador.Text = row.Cells[1].Value.ToString();
                txttons_op.Text = row.Cells[4].Value.ToString();
                txtimp_op.Text = row.Cells[5].Value.ToString();
                txtimp_ay.Text = row.Cells[6].Value.ToString();
            }
        }

        private void btnprintraya_Click(object sender, EventArgs e)
        {
            frmrayaviewer fv = new frmrayaviewer();
            fv.MdiParent = ParentForm;

            fv._semana = txtsemana.Text;
            fv._tontot = txttontot.Text;
            fv._rayacos = txtimp_co.Text;
            fv._tarcos = mtxte1.Text;
            fv._tartra = mtxte2.Text;
            fv._tarayu = mtxte3.Text;

            fv.Show();
        }
    }
}
