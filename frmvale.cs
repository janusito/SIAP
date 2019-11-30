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
    public partial class frmvale : frmmantenimiento
    {
        //Definicion de variables.

        MySqlConnection cnn = new MySqlConnection();
        MySqlCommand cmd = new MySqlCommand();
        MySqlCommand cmd2 = new MySqlCommand();
        DataSet ds = new DataSet();
        MySqlDataReader dr;
        Utilidades cma = new Utilidades();

        int fol_ini = 0;
        int fol_fin = 0;
        int tot_fol = 0;

        string busqueda;

        // ==========================================================================================

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

        public void totaliza()
        {
            conectar();
            cmd = new MySqlCommand("SELECT SUM(den_val) from vistavale WHERE sta_val = '';", cnn);
            DataSet ds = new DataSet();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(ds,"den_val");
            txttotal.Text = Convert.ToString(cmd.ExecuteScalar());
        }

        public void actualizadg(string cadena)
        {
            conectar();
            cmd = new MySqlCommand(cadena, cnn);
            MySqlDataAdapter con = new MySqlDataAdapter(cmd);
            ds = new DataSet();
            con.Fill(ds);

            dg1.DataSource = ds.Tables[0];
            dg1.Columns[0].HeaderText = "FOLIO";
            dg1.Columns[1].HeaderText = "DENOMINACION";
            dg1.Columns[2].HeaderText = "STATUS";
            dg1.Columns[3].HeaderText = "FECHA ENTREGA";
            dg1.Columns[4].HeaderText = "VEHICULO";


            dg1.Columns[0].Width = 80;
            dg1.Columns[1].Width = 100;
            dg1.Columns[2].Width = 50;
            dg1.Columns[3].Width = 100;
            dg1.Columns[4].Width = 450;


            dg1.AllowUserToAddRows = false;
            dg1.ReadOnly = true;
            desconectar();
            totaliza();
        }

        public frmvale()
        {
            InitializeComponent();
        }

        private void Frmvehiculo_Load(object sender, EventArgs e)
        {
            actualizadg("SELECT t1.folio_vale, t1.den_val, t1.sta_val, t1.fec_entrega, concat(t2.des_veh,' / ',t2.pla_veh) AS nomveh FROM vale t1 LEFT JOIN vehiculo t2 ON t1.fk_id_vehiculo = t2.id_vehiculo;");
            cma.llenarcombo(combo_vehiculo, "list_vehiculo", "id_vehiculo", "aliasveh");
            totaliza();
        }

        // ============================ CODIGO PARA AGREGAR =================================
        public override Boolean agregar()
        {

            if (Utilidades.ValidarFormulario(gb1, errorProvider1)==false)
            {
                fol_ini = int.Parse(errorTxtBox1.Text);
                fol_fin = int.Parse(errorTxtBox2.Text);
                tot_fol = (fol_fin - fol_ini) + 1;


                if (fol_fin < fol_ini)
                {
                    MessageBox.Show("Rango Invalido");
                    return false;
                }

                // Inicia busqueda de folios del lote en la BD
                int i = 0;
                conectar();
                cmd = new MySqlCommand("qry_vale", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                MySqlParameter p_folio_vale = new MySqlParameter("_folio_vale", MySqlDbType.Int32);

                pb1.Maximum = tot_fol;
                pb1.Minimum = 1;
                pb1.Step = 1;
                for (i = fol_ini; i <= fol_fin; i++)
                {
                    try
                    {
                        conectar();

                        p_folio_vale.Value = i.ToString();
                        cmd.Parameters.Add(p_folio_vale);
                        dr = cmd.ExecuteReader();

                        if (dr.Read())
                        {
                            desconectar();
                            MessageBox.Show("Existe en la BD un folio del lote repetido, verifique.");
                            return false;
                            //break;
                        }

                        cmd.Parameters.Clear();
                        desconectar();
                    }
                    catch (Exception error)
                    {
                        MessageBox.Show("Ha ocurrido un error. " + error.Message);
                        return false;
                    }
                    pb1.PerformStep();
                }
                //===================================================================================
                // Iniciar rutina de almacenamiento
                pb1.Value = 1;

                conectar();
                cmd = new MySqlCommand("add_vale", cnn);
                cmd.CommandType = CommandType.StoredProcedure;

                MySqlParameter p_fac_ingreso = new MySqlParameter("_fac_ingreso", MySqlDbType.Int32);
                MySqlParameter p_fec_ingreso = new MySqlParameter("_fec_ingreso", MySqlDbType.Date);
                MySqlParameter p_fec_entrega = new MySqlParameter("_fec_entrega", MySqlDbType.Date);
                MySqlParameter p_den_vale = new MySqlParameter("_den_vale", MySqlDbType.Int32);
                MySqlParameter p_sta_val = new MySqlParameter("_sta_val", MySqlDbType.VarChar,1);
                MySqlParameter p_fk_id_vehiculo = new MySqlParameter("_fk_id_vehiculo", MySqlDbType.Int32);

                for (i = fol_ini; i <= fol_fin; i++)
                {
                    try
                    {
                        conectar();

                        p_folio_vale.Value = i.ToString();
                        cmd.Parameters.Add(p_folio_vale);

                        p_fac_ingreso.Value = errorTxtBox3.Text;
                        cmd.Parameters.Add(p_fac_ingreso);

                        p_fec_ingreso.Value = dtpicker.Value.Date;
                        cmd.Parameters.Add(p_fec_ingreso);

                        p_fec_entrega.Value = null;
                        cmd.Parameters.Add(p_fec_entrega);

                        p_den_vale.Value = errorTxtBox5.Text;
                        cmd.Parameters.Add(p_den_vale);

                        p_sta_val.Value = "";
                        cmd.Parameters.Add(p_sta_val);

                        p_fk_id_vehiculo.Value = null;
                        cmd.Parameters.Add(p_fk_id_vehiculo);

                        cmd.ExecuteNonQuery();
                        cmd.Parameters.Clear();
                        desconectar();

                    }
                    catch (Exception error)
                    {
                        MessageBox.Show("Ha ocurrido un error. " + error);
                        return false;
                    }
                    pb1.PerformStep();
                }
                // Restaura Botones despues de agregar.
                gb1.Enabled = false;
                btnnuevo.Visible = true;
                button4.Enabled = true;
                button1.Enabled = true;

                button8.Enabled = true;
                button5.Enabled = true;
                button3.Enabled = true;
                gb2.Enabled = true;

                actualizadg("SELECT t1.folio_vale, t1.den_val, t1.sta_val, t1.fec_entrega, concat(t2.des_veh,' / ',t2.pla_veh) AS nomveh FROM vale t1 LEFT JOIN vehiculo t2 ON t1.fk_id_vehiculo = t2.id_vehiculo;");

                MessageBox.Show("Se registro correctamente el lote de vales.");
                pb1.Value = 1;
                return true;
            }
            else
            {
                return true;
            }
        }
        // ====================================================================================================

        public override Boolean buscar()
        {
            busqueda = errorTxtBox6.Text;
            actualizadg("SELECT t1.folio_vale, t1.den_val, t1.sta_val, t1.fec_entrega, concat(t2.des_veh,' / ',t2.pla_veh) AS nomveh FROM vale t1 LEFT JOIN vehiculo t2 ON t1.fk_id_vehiculo = t2.id_vehiculo WHERE t1.folio_vale="+busqueda+";");
            return true;
        }

        // ====================================================================================================
        // Entregar Vale
        public override void limpiar()
        {
            conectar();
            cmd = new MySqlCommand("upd_vale", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            MySqlParameter p_folio_vale = new MySqlParameter("_folio_vale", MySqlDbType.Int32);
            MySqlParameter p_sta_val = new MySqlParameter("_sta_val", MySqlDbType.VarChar, 1);
            MySqlParameter p_fec_entrega = new MySqlParameter("_fec_entrega", MySqlDbType.Date);
            MySqlParameter p_fk_id_vehiculo = new MySqlParameter("_fk_id_vehiculo", MySqlDbType.Int32);

            foreach (DataGridViewRow row in dg1.SelectedRows)
            {
                p_folio_vale.Value = row.Cells[0].Value.ToString();
            }

            p_sta_val.Value = "X";
            p_fec_entrega.Value = dp2.Value.Date;
            p_fk_id_vehiculo.Value = combo_vehiculo.SelectedValue;

            cmd.Parameters.Add(p_folio_vale);
            cmd.Parameters.Add(p_sta_val);
            cmd.Parameters.Add(p_fec_entrega);
            cmd.Parameters.Add(p_fk_id_vehiculo);

            cmd.ExecuteNonQuery();

            actualizadg("SELECT t1.folio_vale, t1.den_val, t1.sta_val, t1.fec_entrega, concat(t2.des_veh,' / ',t2.pla_veh) AS nomveh FROM vale t1 LEFT JOIN vehiculo t2 ON t1.fk_id_vehiculo = t2.id_vehiculo;");

            desconectar();

            MessageBox.Show("El vale ha sido Entregado exitosamente!!");
        }
        // ====================================================================================================
        // Restaurar Vale
        public override void eliminar()
        {
            conectar();
            cmd = new MySqlCommand("upd_vale", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            MySqlParameter p_folio_vale = new MySqlParameter("_folio_vale", MySqlDbType.Int32);
            MySqlParameter p_sta_val = new MySqlParameter("_sta_val", MySqlDbType.VarChar, 1);
            MySqlParameter p_fec_entrega = new MySqlParameter("_fec_entrega", MySqlDbType.Date);
            MySqlParameter p_fk_id_vehiculo = new MySqlParameter("_fk_id_vehiculo", MySqlDbType.Int32);

            foreach (DataGridViewRow row in dg1.SelectedRows)
            {
                p_folio_vale.Value = row.Cells[0].Value.ToString();
            }

            p_sta_val.Value = null;
            p_fec_entrega.Value = null;
            p_fk_id_vehiculo.Value = null;

            cmd.Parameters.Add(p_folio_vale);
            cmd.Parameters.Add(p_sta_val);
            cmd.Parameters.Add(p_fec_entrega);
            cmd.Parameters.Add(p_fk_id_vehiculo);

            cmd.ExecuteNonQuery();

            actualizadg("SELECT t1.folio_vale, t1.den_val, t1.sta_val, t1.fec_entrega, concat(t2.des_veh,' / ',t2.pla_veh) AS nomveh FROM vale t1 LEFT JOIN vehiculo t2 ON t1.fk_id_vehiculo = t2.id_vehiculo;");

            desconectar();

            MessageBox.Show("El vale ha sido Restaurado exitosamente!!");
        }
        // ====================================================================================================
        public override void modificar()
        {
            actualizadg("SELECT t1.folio_vale, t1.den_val, t1.sta_val, t1.fec_entrega, concat(t2.des_veh,' / ',t2.pla_veh) AS nomveh FROM vale t1 LEFT JOIN vehiculo t2 ON t1.fk_id_vehiculo = t2.id_vehiculo WHERE t1.sta_val<>'X';");
        }
        // ====================================================================================================

        private void Btnnuevo_Click(object sender, EventArgs e)
        {
            gb1.Enabled = true;
            btnnuevo.Visible = false;
            button4.Enabled = false;
            button1.Enabled = false;
            
            button8.Enabled = false;
            button5.Enabled = false;
            button3.Enabled = false;
            gb2.Enabled = false;

            errorTxtBox1.Focus();
        }

        private void ErrorTxtBox1_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void ErrorTxtBox2_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void ErrorTxtBox3_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void ErrorTxtBox2_Validated(object sender, EventArgs e)
        {
            fol_ini = int.Parse(errorTxtBox1.Text);
            fol_fin = int.Parse(errorTxtBox2.Text);

            tot_fol = (fol_fin - fol_ini) + 1;
            errorTxtBox4.Text = tot_fol.ToString();
            if (fol_fin < fol_ini)
            {
                MessageBox.Show("Rango Invalido");
            }
        }

        private void ErrorTxtBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utilidades.SoloNumeros(e);
        }

        private void ErrorTxtBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utilidades.SoloNumeros(e);
        }

        private void ErrorTxtBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utilidades.SoloNumeros(e);
        }

        private void ErrorTxtBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utilidades.SoloNumeros(e);

        }

        private void ErrorTxtBox5_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            actualizadg("SELECT t1.folio_vale, t1.den_val, t1.sta_val, t1.fec_entrega, concat(t2.des_veh,' / ',t2.pla_veh) AS nomveh FROM vale t1 LEFT JOIN vehiculo t2 ON t1.fk_id_vehiculo = t2.id_vehiculo;");
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
