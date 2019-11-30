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
    public partial class frmchofer : frmmantenimiento
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
            string str = "SELECT id_chofer from chofer order by id_chofer";
            MySqlCommand cmd = new MySqlCommand(str, cnn);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                txtidchof.Text  = dr["id_chofer"].ToString();
            }
            int i = int.Parse(txtidchof.Text);
            i = i + 1;
            txtidchof.Text = i.ToString();
            desconectar();
            dr.Close();
        }

        public override void limpiar()
        {
            actualizadg();
            des_cam();
            txtidchof.ReadOnly = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
        }

        public void actualizadg()
        {
            conectar();
            cmd = new MySqlCommand("SELECT * FROM chofer;", cnn);
            MySqlDataAdapter con = new MySqlDataAdapter(cmd);
            ds = new DataSet();
            con.Fill(ds);

            dg1.DataSource = ds.Tables[0];
            dg1.Columns[0].HeaderText = "ID";
            dg1.Columns[1].HeaderText = "NOMBRE";
            dg1.Columns[2].HeaderText = "APELLIDO PATERNO";
            dg1.Columns[3].HeaderText = "APELLIDO MATERNO";



            dg1.Columns[0].Width = 100;
            dg1.Columns[1].Width = 200;
            dg1.Columns[2].Width = 200;
            dg1.Columns[3].Width = 200;


            dg1.AllowUserToAddRows = false;
            dg1.ReadOnly = true;
            desconectar();
        }

        public frmchofer()
        {
            InitializeComponent();
        }

        private void Frmchofer_Load(object sender, EventArgs e)
        {
            conteoid();
            actualizadg();
            des_cam();
            txtidchof.ReadOnly = false;
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
                    cmd = new MySqlCommand("add_chofer", cnn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    MySqlParameter p_id_chofer = new MySqlParameter("_id_chofer", MySqlDbType.Int32);
                    p_id_chofer.Value = txtidchof.Text;
                    cmd.Parameters.Add(p_id_chofer);

                    MySqlParameter p_nom_chofer = new MySqlParameter("_nom_chofer", MySqlDbType.VarChar, 40);
                    p_nom_chofer.Value = txtnomchof.Text;
                    cmd.Parameters.Add(p_nom_chofer);

                    MySqlParameter p_app_chofer = new MySqlParameter("_app_chofer", MySqlDbType.VarChar, 40);
                    p_app_chofer.Value = txtpaterno.Text;
                    cmd.Parameters.Add(p_app_chofer);

                    MySqlParameter p_apm_chofer = new MySqlParameter("_apm_chofer", MySqlDbType.VarChar, 40);
                    p_apm_chofer.Value = txtmaterno.Text;
                    cmd.Parameters.Add(p_apm_chofer);

                    cmd.ExecuteNonQuery();

                    desconectar();

                    actualizadg();

                    MessageBox.Show("Registro correcto.");


                    des_cam();
                    btnedit.Enabled = true;
                    txtidchof.ReadOnly = false;
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
                cmd = new MySqlCommand("qry_chofer", cnn);
                cmd.CommandType = CommandType.StoredProcedure;

                MySqlParameter p_id_chofer = new MySqlParameter("_id_chofer", MySqlDbType.Int32);
                p_id_chofer.Value = txtidchof.Text;
                cmd.Parameters.Add(p_id_chofer);

                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    txtnomchof.Text = dr["nom_chofer"].ToString();
                    txtpaterno.Text = dr["app_chofer"].ToString();
                    txtmaterno.Text = dr["apm_chofer"].ToString();

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
                cmd = new MySqlCommand("qry_chofer", cnn);
                cmd.CommandType = CommandType.StoredProcedure;

                MySqlParameter p_id_chofer = new MySqlParameter("_id_chofer", MySqlDbType.Int32);
                p_id_chofer.Value = txtidchof.Text;
                cmd.Parameters.Add(p_id_chofer);


                dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    desconectar();
                    conectar();
                    cmd = new MySqlCommand("del_chofer", cnn);
                    cmd.CommandType = CommandType.StoredProcedure;


                    p_id_chofer.Value = txtidchof.Text;
                    cmd.Parameters.Add(p_id_chofer);
                    cmd.ExecuteNonQuery();
                    desconectar();
                    actualizadg();
                    MessageBox.Show("Registro ELIMINADO con Exito!!");
                    des_cam();
                    txtidchof.ReadOnly = false;
                    button3.Enabled = true;
                    button4.Enabled = true;
                    button5.Enabled = true;
                }
                else
                {
                    MessageBox.Show("No existe el registro que desea eliminar");
                    des_cam();
                    txtidchof.ReadOnly = false;
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
            cmd2 = new MySqlCommand("qry_chofer", cnn);
            cmd2.CommandType = CommandType.StoredProcedure;

            MySqlParameter pp_id_chofer = new MySqlParameter("_id_chofer", MySqlDbType.Int32);
            pp_id_chofer.Value = txtidchof.Text;
            cmd2.Parameters.Add(pp_id_chofer);


            dr = cmd2.ExecuteReader();



            if (dr.Read())
            {
                if (Utilidades.ValidarFormulario(this, errorProvider1) == false)
                {
                    conectar();
                    //inicia rutina de modificar
                    cmd = new MySqlCommand("upd_chofer", cnn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    MySqlParameter p_id_chofer = new MySqlParameter("_id_chofer", MySqlDbType.Int32);
                    p_id_chofer.Value = txtidchof.Text;
                    cmd.Parameters.Add(p_id_chofer);

                    MySqlParameter p_nom_chofer = new MySqlParameter("_nom_chofer", MySqlDbType.VarChar, 40);
                    p_nom_chofer.Value = txtnomchof.Text;
                    cmd.Parameters.Add(p_nom_chofer);

                    MySqlParameter p_app_chofer = new MySqlParameter("_app_chofer", MySqlDbType.VarChar, 40);
                    p_app_chofer.Value = txtpaterno.Text;
                    cmd.Parameters.Add(p_app_chofer);

                    MySqlParameter p_apm_chofer = new MySqlParameter("_apm_chofer", MySqlDbType.VarChar, 40);
                    p_apm_chofer.Value = txtmaterno.Text;
                    cmd.Parameters.Add(p_apm_chofer);

                    try
                    {
                        cmd.ExecuteNonQuery();
                        desconectar();
                        actualizadg();

                        MessageBox.Show("Registro MODIFICADO con Exito!!");

                        des_cam();

                        txtidchof.ReadOnly = false;
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
                txtidchof.Text = row.Cells[0].Value.ToString();
                txtnomchof.Text = row.Cells[1].Value.ToString();
                txtpaterno.Text = row.Cells[2].Value.ToString();
                txtmaterno.Text = row.Cells[3].Value.ToString();
            }
        }

        private void Btnnuevo_Click(object sender, EventArgs e)
        {
            act_cam();
            conteoid();
            btnedit.Enabled = false;
            button1.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            txtnomchof.Text = "";
            txtpaterno.Text = "";
            txtmaterno.Text = "";
            txtnomchof.Focus();

        }

        public void des_cam()
        {
            txtidchof.ReadOnly = true;
            txtnomchof.ReadOnly = true;
            txtpaterno.ReadOnly = true;
            txtmaterno.ReadOnly = true;

            btnnuevo.Visible = true;
            button2.Visible = false;

            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
        }
        public void act_cam()
        {
            txtidchof.ReadOnly = false;
            txtnomchof.ReadOnly = false;
            txtpaterno.ReadOnly = false;
            txtmaterno.ReadOnly = false;


            btnnuevo.Visible = false;
            button2.Visible = true;
            button1.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
        }

        public void busca_dg()
        {
            string searchValue = txtidchof.Text;
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
            txtnomchof.Focus();
        }


        private void Txtdescripv_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void Txtplaca_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
