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
    public partial class frmFiltroVal : frmbase
    {
        Utilidades cma = new Utilidades();

        public frmFiltroVal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            frmvalesviewer fv = new frmvalesviewer();
            fv.MdiParent = ParentForm;

            // ========= Pasando variables ======
            if (radioButton1.Checked==true){
                fv.alcance = "T";
            }

            if (radioButton2.Checked == true)
            {
                fv.alcance = "D";
            }

            if (radioButton3.Checked == true)
            {
                fv.alcance = "E";
            }

            if (cbfechas.Checked == true)
            {
                fv.cb1 = true;
            }
            else
            {
                fv.cb1 = false;

            }
            if (cbfolios.Checked == true)
            {
                fv.cb2 = true;
            }
            else
            {
                fv.cb2 = false;
            }

            if (cbvehiculo.Checked == true)
            {
                fv.cb3 = true;
            }
            else
            {
                fv.cb3 = false;
            }
            

                
            fv.veh= combo_vehiculo.SelectedValue.ToString();
            fv.vehtxt = combo_vehiculo.Text.ToString();

            fv.fecdesde = dateTimePicker1.Value.Date.ToString("yyyy/MM/dd");
            fv.fechasta = dateTimePicker2.Value.Date.ToString("yyyy/MM/dd");

            fv.foldesde = errorTxtBox1.Text;
            fv.folhasta = errorTxtBox2.Text;

            //====================================

            fv.Show();

        }

        private void frmFiltroVal_Load(object sender, EventArgs e)
        {
            cma.llenarcombo(combo_vehiculo, "list_vehiculo", "id_vehiculo", "aliasveh");
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
        }

        private void errorTxtBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utilidades.SoloNumeros(e);
        }

        private void errorTxtBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utilidades.SoloNumeros(e);
        }

        private void cbfechas_CheckedChanged(object sender, EventArgs e)
        {
            if (cbfechas.Checked == true && radioButton1.Checked != true)
            {
                dateTimePicker1.Enabled = true;
                dateTimePicker2.Enabled = true;
                
            }
            else
            {
                dateTimePicker1.Enabled = false;
                dateTimePicker2.Enabled = false;
            }
        }

        private void cbfolios_CheckedChanged(object sender, EventArgs e)
        {
            if (cbfolios.Checked == true)
            {
                errorTxtBox1.Enabled = true;
                errorTxtBox2.Enabled = true;
            }
            else
            {
                errorTxtBox1.Enabled = false;
                errorTxtBox2.Enabled = false;
            }

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            cbfechas.Enabled = true;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            cbfechas.Enabled = true;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            cbfechas.Enabled = false;
        }

        private void dateTimePicker1_Validating(object sender, CancelEventArgs e)
        {
            if(dateTimePicker1.Value > dateTimePicker2.Value)
            {
                errorProvider1.SetError(dateTimePicker1, "Fecha inicio debe ser menor a la de fin");
                e.Cancel = true;
            }
        }

        private void dateTimePicker2_Validating(object sender, CancelEventArgs e)
        {
            if (dateTimePicker1.Value > dateTimePicker2.Value)
            {
                errorProvider1.SetError(dateTimePicker1, "Fecha inicio debe ser menor a la de fin");
                e.Cancel = true;   
            }

        }

        private void dateTimePicker1_Validated(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void dateTimePicker2_Validated(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void cbvehiculo_CheckedChanged(object sender, EventArgs e)
        {
            if (cbvehiculo.Checked == true)
            {
                combo_vehiculo.Enabled = true;
            }
            else
            {
                combo_vehiculo.Enabled = false;
            }

        }
    }
}
