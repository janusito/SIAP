using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Configuration;

namespace MiLibreria
{

    public class Utilidades
    {
        static string cadena = ConfigurationManager.ConnectionStrings["default"].ConnectionString;
        public static string ccx666 = "troy";

        

        public static DataSet Ejecutar(string cmd)
        {
            MySqlConnection con = new MySqlConnection(cadena);
            con.Open();

            DataSet DS = new DataSet();
            MySqlDataAdapter DP = new MySqlDataAdapter(cmd,con);

            DP.Fill(DS);

            con.Close();

            return DS;
        }


        // Ejemplo de uso del metodo Ejecutar
        //public static ejemplo()
        //{
        //    try
        //    {
        //        string CMD = string.Format("SELECT * FROM tabla WHERE campo1='{0}' AND campo2='{1}'", txtbox1.Text.Trim(), txtbox2.Text.Trim());

        //        DataSet ds = Utilidades.Ejecutar(CMD);

        //        string variable1 = ds.Tables[0].Rows[0]["campo1"].ToString().Trim();
        //        string variable2 = ds.Tables[0].Rows[0]["campo2"].ToString().Trim();

        //        if(campo1 == txtbox1.Text.Trim() && campo2 == txtbox2.Text.Trim())
        //        {
        //            MessageBox.Show("Se ha iniciado sesion");
        //        }

        //    }
        //    catch (Exception error)
        //    {
        //        MessageBox.Show(error.Message);
        //    }
        //}




        public void llenarcombo(ComboBox combo1, string proc, string vm, string dm)
        {
            MySqlConnection con = new MySqlConnection(cadena);
            MySqlCommand cm = new MySqlCommand(proc, con);
            cm.CommandType = System.Data.CommandType.StoredProcedure;
            MySqlDataAdapter da = new MySqlDataAdapter(cm);
            DataTable dt = new DataTable();
            da.Fill(dt);
            combo1.ValueMember = vm;
            combo1.DisplayMember = dm;
            combo1.DataSource = dt;
        }

   
        public static void SoloLetras(KeyPressEventArgs v)
        {
            if (Char.IsLetter(v.KeyChar))
            {
                v.Handled = false;
            }
            else if (Char.IsSeparator(v.KeyChar))
            {
                v.Handled = false;
            }
            else if (Char.IsControl(v.KeyChar))
            {
                v.Handled = false;
            }
            else
            {
                v.Handled = true;
                MessageBox.Show("Solo Letras");
            }
        }

        public static void SoloNumeros(KeyPressEventArgs v)
        {
            if (Char.IsDigit(v.KeyChar))
            {
                v.Handled = false;
            }
            else if (Char.IsSeparator(v.KeyChar))
            {
                v.Handled = false;
            }
            else if (Char.IsControl(v.KeyChar))
            {
                v.Handled = false;
            }
            else
            {
                v.Handled = true;
                MessageBox.Show("Solo Numeros");
            }
        }

        public static void NumerosDecimales(KeyPressEventArgs v)
        {
            if (Char.IsDigit(v.KeyChar))
            {
                v.Handled = false;
            }
            else if (Char.IsSeparator(v.KeyChar))
            {
                v.Handled = false;
            }
            else if (Char.IsControl(v.KeyChar))
            {
                v.Handled = false;
            }
            else if (v.KeyChar.ToString().Equals("."))
            {
                v.Handled = false;
            }
            else
            {
                v.Handled = true;
                MessageBox.Show("Solo numeros o numeros con punto decimal");
            }
        }

        public static Boolean ValidarFormulario(Control Objeto, ErrorProvider ErrorProvider )
        {
            Boolean HayErrores = false;

            foreach (Control Item in Objeto.Controls)
            {
                if (Item is ErrorTxtBox)
                {
                    ErrorTxtBox Obj = (ErrorTxtBox)Item;

                    if (Obj.Validar == true)
                    {
                        if (string.IsNullOrEmpty(Obj.Text.Trim()))
                        {
                            ErrorProvider.SetError(Obj, "No puede estar vacio.");
                            HayErrores = true;
                        }
                    }
                    else
                    {
                        ErrorProvider.SetError(Obj, "");
                    }
                }
            }
            return HayErrores;
        }

    }
}
