using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Office.Interop;
using Microsoft.Office.Core;

namespace SisyphusWorriors
{
    public partial class ExporterLesPaiments : Form
    {
        public ExporterLesPaiments()
        {
            InitializeComponent();
        }

        public SqlConnection cnx = new SqlConnection("Data Source=DESKTOP-TNU9JD7;Initial Catalog=SisyphusWarriors;Integrated Security=True");
        public SqlCommand cmd = new SqlCommand();
        public SqlDataReader dr;
        public DataTable dt = new DataTable();

        //Remplissage de dgvPayment
        public void RemplirDGVDePayment()
        {
            cnx.Open();
            if (dt.Rows != null)
            {
                dt.Clear();
            }
            cmd.CommandText = "Select * from Payment";
            cmd.Connection = cnx;
            dr = cmd.ExecuteReader();
            dt.Load(dr);
            DgvExport.DataSource = dt;
            dr.Close();
            cnx.Close();
        }

        private void BtnExport_Click(object sender, EventArgs e)
        {
            try
            {
                DgvExport.SelectAll();
                DataObject copydata = DgvExport.GetClipboardContent();
                if (copydata != null) Clipboard.SetDataObject(copydata);
                Microsoft.Office.Interop.Excel.Application xlapp = new Microsoft.Office.Interop.Excel.Application();
                xlapp.Visible = true;
                Microsoft.Office.Interop.Excel.Workbook xlWbook;
                Microsoft.Office.Interop.Excel.Worksheet xlsheet;
                object miseddata = System.Reflection.Missing.Value;
                xlWbook = xlapp.Workbooks.Add(miseddata);

                xlsheet = (Microsoft.Office.Interop.Excel.Worksheet)xlWbook.Worksheets.get_Item(1);
                Microsoft.Office.Interop.Excel.Range xlr = (Microsoft.Office.Interop.Excel.Range)xlsheet.Cells[1, 1];
                xlr.Select();

                xlsheet.PasteSpecial(xlr, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ExporterLesPaiments_Load(object sender, EventArgs e)
        {
            RemplirDGVDePayment();
            lblTotalPay.Text = $"{(DgvExport.RowCount) - 1 }";
        }
    }
}
