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
    public partial class frmvehiculo : frmmantenimiento
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

        public void conteoid()
        {
            conectar();
            string str = "SELECT id_vehiculo from vehiculo order by id_vehiculo";
            MySqlCommand cmd = new MySqlCommand(str, cnn);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                txtidveh.Text  = dr["id_vehiculo"].ToString();
            }
            int i = int.Parse(txtidveh.Text);
            i = i + 1;
            txtidveh.Text = i.ToString();
            desconectar();
            dr.Close();
        }

        public override void limpiar()
        {
            actualizadg();
            des_cam();
            txtidveh.ReadOnly = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
        }

        public void actualizadg()
        {
            conectar();
            cmd = new MySqlCommand("SELECT * FROM vehiculo;", cnn);
            MySqlDataAdapter con = new MySqlDataAdapter(cmd);
            ds = new DataSet();
            con.Fill(ds);

            dg1.DataSource = ds.Tables[0];
            dg1.Columns[0].HeaderText = "ID";
            dg1.Columns[1].HeaderText = "DESCRIPCION";
            dg1.Columns[2].HeaderText = "PLACAS / SERIE";
            dg1.Columns[3].HeaderText = "TIPO VEHICULO";
            dg1.Columns[4].HeaderText = "ID CHOFER";



            dg1.Columns[0].Width = 30;
            dg1.Columns[1].Width = 400;
            dg1.Columns[2].Width = 100;
            dg1.Columns[3].Width = 50;
            dg1.Columns[4].Width =  50;


            dg1.AllowUserToAddRows = false;
            dg1.ReadOnly = true;
            desconectar();
        }

        public frmvehiculo()
        {
            InitializeComponent();
        }

        private void Frmvehiculo_Load(object sender, EventArgs e)
        {
            conteoid();
            actualizadg();
            cma.llenarcombo(combo_chofer, "list_chofer", "id_chofer", "nombre");
            des_cam();
            txtidveh.ReadOnly = false;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
        }

        public override Boolean agregar()
        {   
            if (Utilidades.ValidarFormulario(this, errorProvider1)==false)
            {
                try
                {
                    conectar();
                    cmd = new MySqlCommand("add_vehiculo", cnn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    MySqlParameter p_id_vehiculo = new MySqlParameter("_id_vehiculo", MySqlDbType.Int32);
                    p_id_vehiculo.Value = txtidveh.Text;
                    cmd.Parameters.Add(p_id_vehiculo);

                    MySqlParameter p_des_veh = new MySqlParameter("_des_veh", MySqlDbType.VarChar, 40);
                    p_des_veh.Value = txtdescripv.Text;
                    cmd.Parameters.Add(p_des_veh);

                    MySqlParameter p_pla_veh = new MySqlParameter("_pla_veh", MySqlDbType.VarChar, 10);
                    p_pla_veh.Value = txtplaca.Text;
                    cmd.Parameters.Add(p_pla_veh);

                    MySqlParameter p_tip_veh = new MySqlParameter("_tip_veh", MySqlDbType.VarChar, 1);
                    if (rb1.Checked == true)
                    {
                        p_tip_veh.Value = "U";
                        cmd.Parameters.Add(p_tip_veh);
                    }
                    else
                    {
                        p_tip_veh.Value = "A";
                        cmd.Parameters.Add(p_tip_veh);
                    }

                    MySqlParameter p_fk_id_chofer = new MySqlParameter("_fk_id_chofer", MySqlDbType.Int32);
                    p_fk_id_chofer.Value = combo_chofer.SelectedValue;
                    cmd.Parameters.Add(p_fk_id_chofer);

                    cmd.ExecuteNonQuery();

                    desconectar();

                    actualizadg();

                    MessageBox.Show("Registro correcto.");


                    des_cam();
                    txtidveh.ReadOnly = false;
                    button3.Enabled = true;
                    button4.Enabled = true;
                    button5.Enabled = true;

                    return true;
                }
                catch (Exception error)
                {
                    MessageBox.Show("Ha ocurrido un error. " + error.Message);
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
                cmd = new MySqlCommand("qry_vehiculo", cnn);
                cmd.CommandType = CommandType.StoredProcedure;

                MySqlParameter p_id_vehiculo = new MySqlParameter("_id_vehiculo", MySqlDbType.Int32);
                p_id_vehiculo.Value = txtidveh.Text;
                cmd.Parameters.Add(p_id_vehiculo);

                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    txtdescripv.Text = dr["des_veh"].ToString();
                    txtplaca.Text = dr["pla_veh"].ToString();
                    if ((dr["tip_veh"].ToString()) == "U")
                    {
                        rb1.Checked = true;
                    }
                    else
                    {
                        rb2.Checked = true;
                    }

                    combo_chofer.SelectedValue= dr["fk_id_chofer"].ToString();

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
                MessageBox.Show("Ha ocurrido un error. " + error.Message);
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
                cmd = new MySqlCommand("qry_vehiculo", cnn);
                cmd.CommandType = CommandType.StoredProcedure;

                MySqlParameter p_id_vehiculo = new MySqlParameter("_id_vehiculo", MySqlDbType.Int32);
                p_id_vehiculo.Value = txtidveh.Text;
                cmd.Parameters.Add(p_id_vehiculo);


                dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    desconectar();
                    conectar();
                    cmd = new MySqlCommand("del_vehiculo", cnn);
                    cmd.CommandType = CommandType.StoredProcedure;


                    p_id_vehiculo.Value = txtidveh.Text;
                    cmd.Parameters.Add(p_id_vehiculo);
                    cmd.ExecuteNonQuery();
                    desconectar();
                    actualizadg();
                    MessageBox.Show("Registro ELIMINADO con Exito!!");
                    des_cam();
                    txtidveh.ReadOnly = false;
                    button3.Enabled = true;
                    button4.Enabled = true;
                    button5.Enabled = true;
                }
                else
                {
                    MessageBox.Show("No existe el registro que desea eliminar");
                    des_cam();
                    txtidveh.ReadOnly = false;
                    button3.Enabled = true;
                    button4.Enabled = true;
                    button5.Enabled = true;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("No tienes permisos de Eliminar, contacte con el Administrador de la BD." + ex.Message);
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
            cmd2 = new MySqlCommand("qry_vehiculo", cnn);
            cmd2.CommandType = CommandType.StoredProcedure;

            MySqlParameter pp_id_vehiculo = new MySqlParameter("_id_vehiculo", MySqlDbType.Int32);
            pp_id_vehiculo.Value = txtidveh.Text;
            cmd2.Parameters.Add(pp_id_vehiculo);


            dr = cmd2.ExecuteReader();



            if (dr.Read())
            {
                if (Utilidades.ValidarFormulario(this, errorProvider1) == false)
                {
                    conectar();
                    //inicia rutina de modificar
                    cmd = new MySqlCommand("upd_vehiculo", cnn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    MySqlParameter p_id_vehiculo = new MySqlParameter("_id_vehiculo", MySqlDbType.Int32);
                    p_id_vehiculo.Value = txtidveh.Text;
                    cmd.Parameters.Add(p_id_vehiculo);

                    MySqlParameter p_des_veh = new MySqlParameter("_des_veh", MySqlDbType.VarChar, 40);
                    p_des_veh.Value = txtdescripv.Text;
                    cmd.Parameters.Add(p_des_veh);

                    MySqlParameter p_pla_veh = new MySqlParameter("_pla_veh", MySqlDbType.VarChar, 10);
                    p_pla_veh.Value = txtplaca.Text;
                    cmd.Parameters.Add(p_pla_veh);

                    MySqlParameter p_tip_veh = new MySqlParameter("_tip_veh", MySqlDbType.VarChar, 1);
                    if (rb1.Checked == true)
                    {
                        p_tip_veh.Value = "U";
                    }
                    else
                    {
                        p_tip_veh.Value = "A";
                    }

                    cmd.Parameters.Add(p_tip_veh);

                    MySqlParameter p_fk_id_chofer = new MySqlParameter("_fk_id_chofer", MySqlDbType.Int32);
                    p_fk_id_chofer.Value = combo_chofer.SelectedValue;
                    cmd.Parameters.Add(p_fk_id_chofer);

                    try
                    {
                        cmd.ExecuteNonQuery();
                        desconectar();
                        actualizadg();

                        MessageBox.Show("Registro MODIFICADO con Exito!!");

                        des_cam();

                        txtidveh.ReadOnly = false;
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
                        MessageBox.Show(ex.Message);
                    }
                }
                
                
            }
            
        }

        private void Dg1_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dg1.SelectedRows)
            {
                txtidveh.Text = row.Cells[0].Value.ToString();
                txtdescripv.Text = row.Cells[1].Value.ToString();
                txtplaca.Text = row.Cells[2].Value.ToString();
                

                if ((row.Cells[3].Value.ToString()) == "U")
                {
                    rb1.Checked = true;
                }
                else
                {
                    rb2.Checked = true;
                }

                combo_chofer.SelectedValue = row.Cells[4].Value.ToString();
            }
        }

        private void Btnnuevo_Click(object sender, EventArgs e)
        {
            act_cam();
            conteoid();
            button1.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            txtdescripv.Text = "";
            txtplaca.Text = "";
            txtdescripv.Focus();

        }

        public void des_cam()
        {
            txtidveh.ReadOnly = true;
            txtdescripv.ReadOnly = true;
            txtplaca.ReadOnly = true;
            rb1.Enabled = false;
            rb2.Enabled = false;
            combo_chofer.Enabled = false;

            btnnuevo.Visible = true;
            button2.Visible = false;

            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
        }
        public void act_cam()
        {
            txtidveh.ReadOnly = false;
            txtdescripv.ReadOnly = false;
            txtplaca.ReadOnly = false;
            rb1.Enabled = true;
            rb2.Enabled = true;
            combo_chofer.Enabled = true;

            btnnuevo.Visible = false;
            button2.Visible = true;
            button1.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
        }

        public void busca_dg()
        {
            string searchValue = txtidveh.Text;
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
            txtdescripv.Focus();
        }


        private void Txtdescripv_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void Txtplaca_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }
    }
}
