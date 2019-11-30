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
    public partial class frmtickets : frmmantenimiento
    {
        MySqlConnection cnn = new MySqlConnection();
        MySqlCommand cmd = new MySqlCommand();
        MySqlCommand cmd2 = new MySqlCommand();
        DataSet ds = new DataSet();
        MySqlDataReader dr;
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

        public void des_cam()
        {
            gbdatosticket.Enabled = false;

            btnnuevo.Visible = true;
            button2.Visible = false;

            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
        }

        public void act_cam()
        {
            gbdatosticket.Enabled = true;
            btnnuevo.Visible = false;
            button2.Visible = true;
            button1.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
        }
        public override void limpiar()
        {
            actualizadg();
            des_cam();
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            txtfolio.Text = "";
            txtfolio.Focus();
        }
        public void actualizadg()
        {
            conectar();
            cmd = new MySqlCommand("SELECT t1.folio_ticket, t1.fecha_entrega, t1.semana, t1.toneladas, concat(t2.des_veh,' / ',t2.pla_veh) AS nomveh, t2.tip_veh, t1.fk_id_vehiculo, t1.statust FROM ticket t1 LEFT JOIN vehiculo t2 ON t1.fk_id_vehiculo = t2.id_vehiculo;", cnn);

            MySqlDataAdapter con = new MySqlDataAdapter(cmd);
            ds = new DataSet();
            con.Fill(ds);

            dg1.DataSource = ds.Tables[0];
            dg1.Columns[0].HeaderText = "FOLIO";
            dg1.Columns[1].HeaderText = "ENTREGA";
            dg1.Columns[2].HeaderText = "SEMANA";
            dg1.Columns[3].HeaderText = "TONELADAS";
            dg1.Columns[4].HeaderText = "VEHICULO";
            dg1.Columns[5].HeaderText = "TIPO";
            dg1.Columns[6].HeaderText = "PAG";


            dg1.Columns[0].Width = 80;
            dg1.Columns[1].Width = 70;
            dg1.Columns[2].Width = 55;
            dg1.Columns[3].Width = 80;
            dg1.Columns[4].Width = 370;
            dg1.Columns[5].Width = 20;
            dg1.Columns[6].Width = 10;

            dg1.Columns[5].Visible = false;
            dg1.Columns[6].Visible = false;
            dg1.Columns[7].Visible = false;


            dg1.AllowUserToAddRows = false;
            dg1.ReadOnly = true;
            desconectar();
        }
        private void Dg1_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dg1.SelectedRows)
            {
                txtfolio.Text = row.Cells[0].Value.ToString();
                dpentrega.Value = Convert.ToDateTime(row.Cells[1].Value);
                txtsemana.Text = row.Cells[2].Value.ToString();
                txttoneladas.Text = row.Cells[3].Value.ToString();
                combo_vehiculo.SelectedValue = row.Cells[6].Value;
                if (row.Cells[7].Value.ToString() == "X")
                {
                    cb1.Checked = true;
                }
                else
                {
                    cb1.Checked = false;
                }
            }
        }

        public frmtickets()
        {
            InitializeComponent();
        }
        private void Frmvehiculo_Load(object sender, EventArgs e)
        {
            actualizadg();
            cma.llenarcombo(combo_vehiculo, "list_tractor", "id_vehiculo", "aliasveh");
            des_cam();
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            txtfolio.Focus();
        }
        public override Boolean agregar()
        {   
            if (Utilidades.ValidarFormulario(gbdatosticket, errorProvider1)==false)
            {
                try
                {
                    // ======= Buscando Folio ========
                    desconectar();
                    conectar();
                    cmd = new MySqlCommand("qry_ticket", cnn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    MySqlParameter p_folio_ticket = new MySqlParameter("_folio_ticket", MySqlDbType.Int32);
                    p_folio_ticket.Value = txtfolio.Text;
                    cmd.Parameters.Add(p_folio_ticket);


                    dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        MessageBox.Show("Folio Duplicado");
                        return false;
                    }
                    desconectar();

                    conectar();
                    cmd = new MySqlCommand("add_ticket", cnn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    //MySqlParameter p_folio_ticket = new MySqlParameter("_folio_ticket", MySqlDbType.Int32);
                    p_folio_ticket.Value = txtfolio.Text;
                    cmd.Parameters.Add(p_folio_ticket);

                    MySqlParameter p_fecha_entrega = new MySqlParameter("_fecha_entrega", MySqlDbType.DateTime);
                    p_fecha_entrega.Value = dpentrega.Value.Date;
                    cmd.Parameters.Add(p_fecha_entrega);

                    MySqlParameter p_semana = new MySqlParameter("_semana", MySqlDbType.String);
                    p_semana.Value = txtsemana.Text;
                    cmd.Parameters.Add(p_semana);

                    MySqlParameter p_toneladas = new MySqlParameter("_toneladas", MySqlDbType.Double);
                    p_toneladas.Value = txttoneladas.Text;
                    cmd.Parameters.Add(p_toneladas);

                    MySqlParameter p_fk_id_vehiculo = new MySqlParameter("_fk_id_vehiculo", MySqlDbType.Int32);
                    p_fk_id_vehiculo.Value = combo_vehiculo.SelectedValue;
                    cmd.Parameters.Add(p_fk_id_vehiculo);

                    MySqlParameter p_statust = new MySqlParameter("_statust", MySqlDbType.String);
                    p_statust.Value = "";
                    cmd.Parameters.Add(p_statust);


                    cmd.ExecuteNonQuery();
                    desconectar();
                    actualizadg();
                    MessageBox.Show("Registro correcto.");

                    des_cam();
                    dg1.Enabled = true;
                    button3.Enabled = true;
                    button4.Enabled = true;
                    button5.Enabled = true;
                    txtfolio.Text = "";
                    txttoneladas.Text = "";

                    return true;
                }
                catch (Exception error)
                {
                    MessageBox.Show("Ha ocurrido un error. " + error);
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public override Boolean buscar()
        {
            try
            {
                conectar();
                cmd = new MySqlCommand("qry_ticket", cnn);
                cmd.CommandType = CommandType.StoredProcedure;

                MySqlParameter p_folio_ticket = new MySqlParameter("_folio_ticket", MySqlDbType.Int32);
                p_folio_ticket.Value = txtfolio.Text;
                cmd.Parameters.Add(p_folio_ticket);

                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    busca_dg();

                    return true;
                }
                else
                {
                    MessageBox.Show("Registro no encontrado");
                    limpiar();
                    return false;
                }

               
            }
            catch(Exception error)
            {
                MessageBox.Show("Ha ocurrido un error. " + error.ToString());
                return false;
            }
            finally
            {
                desconectar();
            }
        }


        public override void eliminar()
        {
            try
            {
                desconectar();
                conectar();
                cmd = new MySqlCommand("qry_ticket", cnn);
                cmd.CommandType = CommandType.StoredProcedure;

                MySqlParameter p_folio_ticket = new MySqlParameter("_folio_ticket", MySqlDbType.Int32);
                p_folio_ticket.Value = txtfolio.Text;
                cmd.Parameters.Add(p_folio_ticket);


                dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    desconectar();
                    conectar();
                    cmd = new MySqlCommand("del_ticket", cnn);
                    cmd.CommandType = CommandType.StoredProcedure;


                    p_folio_ticket.Value = txtfolio.Text;
                    cmd.Parameters.Add(p_folio_ticket);
                    cmd.ExecuteNonQuery();
                    desconectar();
                    actualizadg();
                    MessageBox.Show("Registro ELIMINADO con Exito!!");
                    des_cam();
                    button3.Enabled = true;
                    button4.Enabled = true;
                    button5.Enabled = true;
                }
                else
                {
                    MessageBox.Show("No existe el registro que desea eliminar");
                    des_cam();
                    button3.Enabled = true;
                    button4.Enabled = true;
                    button5.Enabled = true;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error : " + ex.ToString());
            }
            finally
            {
                desconectar();
            }
        }

        public override void modificar()
        {
            //Inicia rutina para localizar primero el registro antes de pasar a rutina de modificacion
            desconectar();
            conectar();
            cmd2 = new MySqlCommand("qry_ticket", cnn);
            cmd2.CommandType = CommandType.StoredProcedure;

            MySqlParameter pp_folio_ticket = new MySqlParameter("_folio_ticket", MySqlDbType.Int32);
            pp_folio_ticket.Value = txtfolio.Text;
            cmd2.Parameters.Add(pp_folio_ticket);


            dr = cmd2.ExecuteReader();



            if (dr.Read())
            {
                if (Utilidades.ValidarFormulario(this, errorProvider1) == false)
                {
                    conectar();
                    //inicia rutina de modificar
                    cmd = new MySqlCommand("upd_ticket", cnn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    MySqlParameter p_folio_ticket = new MySqlParameter("_folio_ticket", MySqlDbType.Int32);
                    p_folio_ticket.Value = txtfolio.Text;
                    cmd.Parameters.Add(p_folio_ticket);

                    MySqlParameter p_fecha_entrega = new MySqlParameter("_fecha_entrega", MySqlDbType.DateTime);
                    p_fecha_entrega.Value = dpentrega.Value.Date;
                    cmd.Parameters.Add(p_fecha_entrega);

                    MySqlParameter p_semana = new MySqlParameter("_semana", MySqlDbType.String);
                    p_semana.Value = txtsemana.Text;
                    cmd.Parameters.Add(p_semana);

                    MySqlParameter p_toneladas = new MySqlParameter("_toneladas", MySqlDbType.Double);
                    p_toneladas.Value = txttoneladas.Text;
                    cmd.Parameters.Add(p_toneladas);

                    MySqlParameter p_fk_id_vehiculo = new MySqlParameter("_fk_id_vehiculo", MySqlDbType.Int32);
                    p_fk_id_vehiculo.Value = combo_vehiculo.SelectedValue;
                    cmd.Parameters.Add(p_fk_id_vehiculo);

                    MySqlParameter p_statust = new MySqlParameter("_statust", MySqlDbType.String);
                    p_statust.Value = "";
                    cmd.Parameters.Add(p_statust);


                    try
                    {
                        cmd.ExecuteNonQuery();
                        desconectar();
                        actualizadg();

                        MessageBox.Show("Registro MODIFICADO con Exito!!");

                        des_cam();

                        button3.Enabled = true;
                        button4.Enabled = true;
                        button4.Visible = false;
                        button5.Enabled = true;
                        btnedit.Visible = true;
                        button2.Visible = false;
                        btnnuevo.Visible = true;
                        btnnuevo.Enabled = true;
                        button1.Enabled = true;
                        //termina rutina de modificar
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString());
                    }
                }              
            }
        }


        private void Btnnuevo_Click(object sender, EventArgs e)
        {
            act_cam();
            dg1.Enabled = false;
            button1.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            txtfolio.Text = "";
            //txtsemana.Text = "";
            txttoneladas.Text = "";
            dpentrega.Focus();
        }


        public void busca_dg()
        {
            string searchValue = txtfolio.Text;
            dg1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            
            foreach (DataGridViewRow row in dg1.Rows)
            {
                if (row.Cells[0].Value.ToString().Equals(searchValue))
                {
                    dg1.ClearSelection();
                    row.Selected = true;

                    dg1.Refresh();

                    dg1.Focus();    
                    break;
                }
            }
            
        }

        private void Btnedit_Click(object sender, EventArgs e)
        {
            act_cam();
            button1.Enabled = false;
            button3.Enabled = false;
            button5.Enabled = false;

            button2.Visible = false;
            btnnuevo.Visible = true;
            btnnuevo.Enabled = false;

            button4.Enabled = true;
            button4.Visible = true;
            btnedit.Visible = false;
            dpentrega.Focus();
        }


        private void Txtdescripv_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void Txtplaca_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void txtfolio_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utilidades.SoloNumeros(e);
        }

        private void txtsemana_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void txttoneladas_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utilidades.SoloNumeros(e);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dpentrega_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void txtsemana_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtfolio_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtfolio_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            Utilidades.SoloNumeros(e);
        }
    }
}
