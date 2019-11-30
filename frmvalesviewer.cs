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
    public partial class frmvalesviewer : Form
    {
        MySqlConnection cnn = new MySqlConnection();

        public string alcance;
        public string fecdesde;
        public string fechasta;
        public string foldesde;
        public string folhasta;
        public string ambito;
        public string veh;
        public string vehtxt;
        public bool cb1;
        public bool cb2;
        public bool cb3;



        public frmvalesviewer()
        {
            InitializeComponent();
        }

        private void frmvalesviewer_Load(object sender, EventArgs e)
        {
            string cadena1;
            string cadena2;
            string cadena3;
            string cadena4;
            string consulta;
            string yy;
            string pc;
            string cm;

            cadena1 = "";
            cadena2 = "";
            cadena3 = "";
            cadena4 = "";
            consulta = "";
            yy = " AND ";
            pc = ";";
            cm = "'";



            if (alcance == "T")
            {
                //Cadena 1 para Todos
                if (cb2 == true && (foldesde.Trim() != "" && folhasta.Trim() != ""))
                {
                    cadena1 = "SELECT * FROM vistavale WHERE (sta_val='' || sta_val='X')";
                    consulta = cadena1 + yy;
                }
                else
                {
                    cadena1 = "SELECT * FROM vistavale WHERE (sta_val='' || sta_val='X')";
                    consulta = cadena1;
                }

                //Cadena 3 para Todos
                if ((cb2 == true) && (foldesde.Trim() != "" && folhasta.Trim() != ""))
                {
                    cadena3 = "(folio_vale>=" + foldesde + " AND folio_vale<=" + folhasta + ")";
                    consulta = consulta + cadena3;
                }
                else
                {
                    cadena3 = "";
                    consulta = consulta + cadena3;
                }
                //Cadena 4 para todos
                if (cb3 == true)
                {
                    cadena4 = "(fk_id_vehiculo=" + veh + ")";
                    consulta = consulta + yy+ cadena4;
                }
                else
                {
                    cadena4 = "";
                    consulta = consulta + cadena4;
                }

                consulta = consulta + pc;

                //MessageBox.Show("Consulta  : " + consulta);

            }
            // ====================================================================

            if (alcance == "D")
            {
                //Cadena 1 para Disponibles
                if ((cb1 == true) || cb2 == true && (foldesde.Trim() != "" && folhasta.Trim() != ""))
                {
                    cadena1 = "SELECT * FROM vistavale WHERE (sta_val='')";
                    consulta = cadena1 + yy;
                }
                else
                {
                    cadena1 = "SELECT * FROM vistavale WHERE (sta_val='')";
                    consulta = cadena1;
                }


                //Cadena 2 para Disponibles
                if (cb1 == true && (cb2 == true && (foldesde.Trim() != "" && folhasta.Trim() != "")))
                {
                    cadena2 = "(fec_ingreso>=" + cm + fecdesde + cm + " and fec_ingreso<=" + cm + fechasta + cm + ")";
                    consulta = consulta + cadena2 + yy;
                }

                if (cb1 == true && cb2 == false)
                {
                    cadena2 = "(fec_ingreso>=" + cm + fecdesde + cm + " and fec_ingreso<=" + cm + fechasta + cm + ")";
                    consulta = consulta + cadena2;
                }
                if ((cb1 == false) && cb2 == true && (foldesde.Trim() != "" && folhasta.Trim() != ""))
                {
                    cadena2 = "";
                    consulta = consulta + cadena2;
                }


                //Cadena 3 para Disponibles
                if ((cb2 == true) && (foldesde.Trim() != "" && folhasta.Trim() != ""))
                {
                    cadena3 = "(folio_vale >= " + foldesde + " AND folio_vale <= " + folhasta + ")";
                    consulta = consulta + cadena3;
                }
                else
                {
                    cadena3 = "";
                    consulta = consulta + cadena3;
                }

                //Cadena 4 para todos
                if (cb3 == true)
                {
                    cadena4 = "(fk_id_vehiculo=" + veh + ")";
                    consulta = consulta + yy + cadena4;
                }
                else
                {
                    cadena4 = "";
                    consulta = consulta + cadena4;
                }

                consulta = consulta + pc;

                //MessageBox.Show("Consulta  : " + consulta);

            }
            // ====================================================================

            if (alcance == "E")
            {
                //Cadena 1 para Disponibles
                if ((cb1 == true) || cb2 == true && (foldesde.Trim() != "" && folhasta.Trim() != ""))
                {
                    cadena1 = "SELECT * FROM vistavale WHERE (sta_val='X')";
                    consulta = cadena1 + yy;
                }
                else
                {
                    cadena1 = "SELECT * FROM vistavale WHERE (sta_val='X')";
                    consulta = cadena1;
                }


                //Cadena 2 para Disponibles
                if (cb1 == true && (cb2 == true && (foldesde.Trim() != "" && folhasta.Trim() != "")))
                {
                    cadena2 = "(fec_entrega>=" + cm + fecdesde + cm + " and fec_entrega<=" + cm + fechasta + cm + ")";
                    consulta = consulta + cadena2 + yy;
                }

                if (cb1 == true && cb2 == false)
                {
                    cadena2 = "(fec_entrega>=" + cm + fecdesde + cm + " and fec_entrega<=" + cm + fechasta + cm + ")";
                    consulta = consulta + cadena2;
                }
                if ((cb1 == false) && cb2 == true && (foldesde.Trim() != "" && folhasta.Trim() != ""))
                {
                    cadena2 = "";
                    consulta = consulta + cadena2;
                }


                //Cadena 3 para Disponibles
                if ((cb2 == true) && (foldesde.Trim() != "" && folhasta.Trim() != ""))
                {
                    cadena3 = "(folio_vale >= " + foldesde + " AND folio_vale <= " + folhasta + ")";
                    consulta = consulta + cadena3;
                }
                else
                {
                    cadena3 = "";
                    consulta = consulta + cadena3;
                }

                //Cadena 4 para todos
                if (cb3 == true)
                {
                    cadena4 = "(fk_id_vehiculo=" + veh + ")";
                    consulta = consulta + yy + cadena4;
                }
                else
                {
                    cadena4 = "";
                    consulta = consulta + cadena4;
                }

                consulta = consulta + pc;

                //MessageBox.Show("Consulta  : " + consulta);
            }
            // ====================================================================

            cnn.ConnectionString = ConfigurationManager.ConnectionStrings["default"].ConnectionString;

            MySqlDataAdapter da = new MySqlDataAdapter(consulta, cnn);
            DataSet ds = new DataSet();
            da.Fill(ds);

            ReportDataSource fuente;
            fuente = new ReportDataSource("vistavale", ds.Tables[0]);


            rptvale.LocalReport.DataSources.Clear();
            rptvale.LocalReport.DataSources.Add(fuente);
            rptvale.LocalReport.ReportEmbeddedResource = "SIAP.rptvale.rdlc";

            // Pasando parametros de reporte
            ambito = "";
            if (alcance == "T")
            {
                ambito = "TODOS LOS VALES";
                fecdesde = null;
                fechasta = null;
            }
            if (alcance == "D")
            {
                ambito = "VALES DISPONIBLES";
                if (cb1 == false)
                {
                    fecdesde = null;
                    fechasta = null;
                }
            }
            
            if (alcance == "E")
            {
                ambito = "VALES ENTREGADOS";
                if (cb1 == false)
                {
                    fecdesde = null;
                    fechasta = null;
                }
            }
            if (cb3 == false)
            {
                veh = "";
                vehtxt = "";
            }
           

            ReportParameterCollection reportParameters = new ReportParameterCollection();
            reportParameters.Add(new ReportParameter("par_alcance", ambito));
            reportParameters.Add(new ReportParameter("par_desde", fecdesde));
            reportParameters.Add(new ReportParameter("par_hasta", fechasta));
            reportParameters.Add(new ReportParameter("par_foldesde", foldesde));
            reportParameters.Add(new ReportParameter("par_folhasta", folhasta));
            reportParameters.Add(new ReportParameter("par_vehiculo", vehtxt));
            //==============================
            rptvale.LocalReport.SetParameters(reportParameters);



            rptvale.LocalReport.Refresh();
            rptvale.Refresh();
            rptvale.RefreshReport();
        }
    }
}
