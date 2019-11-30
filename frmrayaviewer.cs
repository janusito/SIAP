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
    public partial class frmrayaviewer : Form
    {
        MySqlConnection cnn = new MySqlConnection();

        public string cm = "'";
        public string _semana;
        public string _tontot;
        public string _rayacos;
        public string _tarcos;
        public string _tartra;
        public string _tarayu;
       
        public frmrayaviewer()
        {
            InitializeComponent();
        }

        private void frmvalesviewer_Load(object sender, EventArgs e)
        {
            string consulta;

            consulta = "";

            consulta = "SELECT * FROM vistaraya WHERE semana="+cm+_semana+cm+";";

            cnn.ConnectionString = ConfigurationManager.ConnectionStrings["default"].ConnectionString;

            MySqlDataAdapter da = new MySqlDataAdapter(consulta, cnn);
            DataSet ds = new DataSet();
            da.Fill(ds);

            ReportDataSource fuente;
            fuente = new ReportDataSource("vistaraya", ds.Tables[0]);
       
            rptraya.LocalReport.DataSources.Clear();
            rptraya.LocalReport.DataSources.Add(fuente);
            rptraya.LocalReport.ReportEmbeddedResource = "SIAP.rptraya.rdlc";

            ReportParameterCollection reportParameters = new ReportParameterCollection();
            reportParameters.Add(new ReportParameter("par_semana", _semana));
            rptraya.LocalReport.SetParameters(reportParameters);

            reportParameters.Add(new ReportParameter("par_tontot", _tontot));
            rptraya.LocalReport.SetParameters(reportParameters);

            reportParameters.Add(new ReportParameter("par_rayacos", _rayacos));
            rptraya.LocalReport.SetParameters(reportParameters);

            reportParameters.Add(new ReportParameter("par_tarcos", _tarcos));
            rptraya.LocalReport.SetParameters(reportParameters);

            reportParameters.Add(new ReportParameter("par_tartra", _tartra));
            rptraya.LocalReport.SetParameters(reportParameters);

            reportParameters.Add(new ReportParameter("par_tarayu", _tarayu));
            rptraya.LocalReport.SetParameters(reportParameters);

            rptraya.LocalReport.Refresh();
            rptraya.Refresh();
            rptraya.RefreshReport();
        }
    }
}
