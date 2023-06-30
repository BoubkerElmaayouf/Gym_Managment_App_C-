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
    public partial class RechercherDesMaterial : Form
    {
        public RechercherDesMaterial()
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
                if (txtRechNomEquip.Text != null)
                {
                    DgvRech.Rows.Clear();
                    cnx.Open();
                    SqlCommand cmd = new SqlCommand("select * from Material where Nom_Matériau ='" + txtRechNomEquip.Text + "'", cnx);
                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        DgvRech.Rows.Add(dr[0], dr[1], dr[2], dr[3], dr[4], dr[5]);
                        lblMat.Text = dr[0].ToString();
                        lblNomMat.Text = dr[1].ToString();
                        lblCat.Text = dr[2].ToString();
                        lblMusUse.Text = dr[3].ToString();
                        Etat.Text = dr[4].ToString();
                        lblDescription.Text = dr[5].ToString();
                        txtRechNomEquip.Text = "";
                    }
                    dr.Close();
                    cnx.Close();
                }
                else if (txtRechNomEquip.Text == null)
                {
                    MessageBox.Show("Entrer le Nom de Material !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                d.Deconnecter();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnVider_Click(object sender, EventArgs e)
        {
            txtRechNomEquip.Text = "";
            lblMat.Text = "";
            lblNomMat.Text = "";
            lblCat.Text = "";
            lblMusUse.Text = "";
            Etat.Text = "";
            lblDescription.Text = "";
            DgvRech.Rows.Clear();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
