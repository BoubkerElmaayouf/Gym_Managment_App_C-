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

namespace SisyphusWorriors
{
    public partial class RechercherDesPayment : Form
    {
        public RechercherDesPayment()
        {
            InitializeComponent();
        }
        Ado d = new Ado();
        public SqlConnection cnx = new SqlConnection("Data Source=DESKTOP-TNU9JD7;Initial Catalog=SisyphusWarriors;Integrated Security=True");
        public SqlCommand cmd = new SqlCommand();
        public SqlDataReader dr;
        public DataTable dt = new DataTable();
        private void BtnRechercherPay_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCinPayRech.Text != null)
                {
                    DgvRech.Rows.Clear();
                    cnx.Open();
                    SqlCommand cmd = new SqlCommand("select * from Payment where CIN ='" + txtCinPayRech.Text + "'", cnx);
                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        DgvRech.Rows.Add(dr[0], dr[1], dr[2], dr[3], dr[4], dr[5]);
                        lblid.Text = dr[0].ToString();
                        lblCin.Text = dr[1].ToString();
                        lblNom.Text = dr[2].ToString();
                        lblAbonment.Text = dr[3].ToString();
                        lblmantant.Text = dr[4].ToString();
                        lbldatepay.Text = dr[5].ToString();
                        txtCinPayRech.Text = "";                     
                    }
                    dr.Close();
                    cnx.Close();
                }
                else if (txtCinPayRech.Text == null )
                {
                    MessageBox.Show("Entrer le Nom de Member !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                d.Deconnecter();
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

        private void BtnVider_Click(object sender, EventArgs e)
        {
            lblid.Text = "...";
            lblCin.Text = "...";
            lblNom.Text = "...";
            lblmantant.Text = "...";
            lbldatepay.Text = "...";
            lblAbonment.Text = "...";
            DgvRech.Rows.Clear();
        }
    }
}
