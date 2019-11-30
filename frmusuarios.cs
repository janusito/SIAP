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
    public partial class frmusuarios : frmbase
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

        public frmusuarios()
        {
            InitializeComponent();
        }

        public void actualizadg()
        {
            conectar();
            cmd = new MySqlCommand("SELECT usuario, administrador, nombre FROM usuarios;", cnn);
            MySqlDataAdapter con = new MySqlDataAdapter(cmd);
            ds = new DataSet();
            con.Fill(ds);

            dgusuarios.DataSource = ds.Tables[0];
            dgusuarios.Columns[0].HeaderText = "USUARIO";
            dgusuarios.Columns[1].HeaderText = "TIPO";
            dgusuarios.Columns[2].HeaderText = "NOMBRE";

            dgusuarios.Columns[0].Width = 100;
            dgusuarios.Columns[1].Width = 40;
            dgusuarios.Columns[2].Width = 320;

            dgusuarios.AllowUserToAddRows = false;
            dgusuarios.ReadOnly = true;
            desconectar();
        }

        private void frmusuarios_Load(object sender, EventArgs e)
        {
            actualizadg();
        }

        private void dgusuarios_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgusuarios.SelectedRows)
            {
                txtusuario.Text = row.Cells[0].Value.ToString();
                txtnombre.Text = row.Cells[2].Value.ToString();
                if (row.Cells[1].Value.ToString()=="A")
                {
                    rbadmin.Checked = true;
                }
                else
                {
                    rbusuario.Checked = true;
                }
            }
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
            btnagregar.Visible = false;
            btngrabarA.Visible = true;

            btnmodificar.Enabled = false;
            btneliminar.Enabled = false;

            txtusuario.Text = "";
            txtnombre.Text = "";
            txtpasswd1.Text = "";
            txtpasswd2.Text = "";
            rbusuario.Checked = true;
        }

        private void btngrabarA_Click(object sender, EventArgs e)
        {
            if (txtpasswd1.Text.Trim()!=txtpasswd2.Text.Trim())
            {
                MessageBox.Show("No coinciden las contraseñas");
                return;
            }
            if (Utilidades.ValidarFormulario(groupBox1, errorProvider1) == false)
            {
                try
                {
                    conectar();
                    cmd = new MySqlCommand("add_usuario", cnn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    MySqlParameter p_usuario = new MySqlParameter("_usuario", MySqlDbType.VarChar, 30);
                    p_usuario.Value = txtusuario.Text;
                    cmd.Parameters.Add(p_usuario);

                    MySqlParameter p_passstrong = new MySqlParameter("_passstrong", MySqlDbType.VarChar, 10);
                    p_passstrong.Value = txtpasswd1.Text;
                    cmd.Parameters.Add(p_passstrong);

                    MySqlParameter p_llave = new MySqlParameter("_llave", MySqlDbType.VarChar, 50);
                    p_llave.Value = Utilidades.ccx666;
                    cmd.Parameters.Add(p_llave);

                    if (rbadmin.Checked==true)
                    {
                        MySqlParameter p_administrador = new MySqlParameter("_administrador", MySqlDbType.VarChar, 1);
                        p_administrador.Value = "A";
                        cmd.Parameters.Add(p_administrador);
                    }
                    else
                    {
                        MySqlParameter p_administrador = new MySqlParameter("_administrador", MySqlDbType.VarChar, 1);
                        p_administrador.Value = "";
                        cmd.Parameters.Add(p_administrador);
                    }

                    MySqlParameter p_nombre = new MySqlParameter("_nombre", MySqlDbType.VarChar, 50);
                    p_nombre.Value = txtnombre.Text;
                    cmd.Parameters.Add(p_nombre);

                    cmd.ExecuteNonQuery();

                    desconectar();

                    actualizadg();

                    MessageBox.Show("Registro correcto.");

                    groupBox1.Enabled = false;
                    btnagregar.Visible = true;
                    btngrabarA.Visible = false;

                    btnmodificar.Enabled = true;
                    btneliminar.Enabled = true;

                }
                catch (Exception error)
                {
                    MessageBox.Show("Error :" + error.Message);
                    throw;
                }
            }
        }

        private void txtusuario_Validated(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void txtnombre_Validated(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void txtpasswd1_Validated(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void txtpasswd2_Validated(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            DialogResult respuesta=MessageBox.Show("Esta seguro de eliminar a este usuario ?", "Eliminar usuario", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (respuesta==DialogResult.Cancel)
            {
                return;
            }

            if (rbadmin.Checked==true)
            {
                MessageBox.Show("No se puede eliminar a un Administrador.");
                return;
            }

            try
            {
                conectar();
                cmd = new MySqlCommand("del_usuario", cnn);
                cmd.CommandType = CommandType.StoredProcedure;

                MySqlParameter p_usuario = new MySqlParameter("_usuario", MySqlDbType.VarChar, 30);
                p_usuario.Value = txtusuario.Text;
                cmd.Parameters.Add(p_usuario);

                cmd.ExecuteNonQuery();
                desconectar();
                actualizadg();

                MessageBox.Show("Usuario Eliminado");
            }
            catch (Exception error)
            {
                MessageBox.Show("Error : " + error.Message);
            }
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
            btnmodificar.Visible = false;
            btngrabarM.Visible = true;

            btnagregar.Enabled = false;
            btneliminar.Enabled = false;

            txtpasswd1.Validar = false;
            txtpasswd2.Validar = false;

            if (Program.sta_usuario.Trim() == txtusuario.Text.Trim())
            {
                txtpasswd1.Enabled = true;
                txtpasswd2.Enabled = true;
            }
            else
            {
                txtpasswd1.Enabled = false;
                txtpasswd2.Enabled = false;
            }

        }

        private void btngrabarM_Click(object sender, EventArgs e)
        {
            if (txtpasswd1.Text.Trim() != txtpasswd2.Text.Trim())
            {
                MessageBox.Show("No coinciden las contraseñas");
                return;
            }

            if (Utilidades.ValidarFormulario(groupBox1, errorProvider1) == false)
            {
                try
                {
                    conectar();

                    if (Program.sta_usuario == txtusuario.Text)
                    {
                        cmd = new MySqlCommand("upd_usuario", cnn);
                    }
                    else
                    {
                        cmd = new MySqlCommand("upd_usuario2", cnn);
                    }

                    
                    cmd.CommandType = CommandType.StoredProcedure;

                    MySqlParameter p_usuario = new MySqlParameter("_usuario", MySqlDbType.VarChar, 30);
                    p_usuario.Value = txtusuario.Text;
                    cmd.Parameters.Add(p_usuario);

                    if (rbadmin.Checked == true)
                    {
                        MySqlParameter p_administrador = new MySqlParameter("_administrador", MySqlDbType.VarChar, 1);
                        p_administrador.Value = "A";
                        cmd.Parameters.Add(p_administrador);
                    }
                    else
                    {
                        MySqlParameter p_administrador = new MySqlParameter("_administrador", MySqlDbType.VarChar, 1);
                        p_administrador.Value = "";
                        cmd.Parameters.Add(p_administrador);
                    }
                   
                    if (Program.sta_usuario == txtusuario.Text)
                    {
                        //MessageBox.Show(Program.sta_usuario + "    " + txtusuario.Text);

                        MySqlParameter p_llave = new MySqlParameter("_llave", MySqlDbType.VarChar, 50);
                        p_llave.Value = Utilidades.ccx666;
                        cmd.Parameters.Add(p_llave);

                        MySqlParameter p_passstrong = new MySqlParameter("_passstrong", MySqlDbType.VarChar, 10);
                        p_passstrong.Value = txtpasswd1.Text;
                        cmd.Parameters.Add(p_passstrong);
                    }


                    MySqlParameter p_nombre = new MySqlParameter("_nombre", MySqlDbType.VarChar, 50);
                    p_nombre.Value = txtnombre.Text;
                    cmd.Parameters.Add(p_nombre);

                    cmd.ExecuteNonQuery();

                    desconectar();

                    actualizadg();

                    MessageBox.Show("Se modifico correctamente.");

                    groupBox1.Enabled = false;
                    btnmodificar.Visible = true;
                    btngrabarM.Visible = false;

                    btnagregar.Enabled = true;
                    btneliminar.Enabled = true;

                    txtusuario.Text = "";
                    txtnombre.Text = "";

                    txtpasswd1.Enabled = true;
                    txtpasswd2.Enabled = true;

                    txtpasswd1.Validar = true;
                    txtpasswd2.Validar = true;

                }
                catch (Exception error)
                {
                    MessageBox.Show("Error : " + error.Message);
                    throw;
                }
            }

        }
    }
}
