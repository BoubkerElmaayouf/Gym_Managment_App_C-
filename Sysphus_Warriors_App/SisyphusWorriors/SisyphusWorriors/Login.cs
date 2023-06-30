using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MaterialSkin;
using MaterialSkin.Controls;
using System.Windows.Forms;
using System.Data.SqlClient;
using Tulpep.NotificationWindow;
namespace SisyphusWorriors
{
    public partial class Login : Form
    {
        Ado d = new Ado();
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
        private void GunaLabel1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            d.Connecter();

            d.cmd.Connection = d.cnx;
            d.cmd.CommandText = "Select * from Loginn where Nom_Utilisateur = '" + txtUtilisateur.Text + "' and Mode_Passe = '" + txtPassword.Text + "'";
            d.dr = d.cmd.ExecuteReader();
            if (txtUtilisateur.Text == "" || txtPassword.Text == "")
            {
                PopupNotifier popup = new PopupNotifier();
                popup.Image = Properties.Resources.notifcations;
                popup.HeaderHeight = 20;
                popup.ContentFont = new System.Drawing.Font("Tahoma", 8F);
                popup.BodyColor = Color.FromArgb(32, 32, 32);
                popup.HeaderColor = Color.OrangeRed;
                popup.Size = new Size(400, 180);
                popup.AnimationDuration = 1000;
                popup.TitleText = "Erreur !!";
                popup.ContentText = " remplir les champs  !!";
                popup.ContentColor = Color.White;
                popup.Popup();
            }
            if (d.dr.Read() == true)
            {
                PopupNotifier popup = new PopupNotifier();
                popup.Image = Properties.Resources.notifcations;
                popup.HeaderHeight = 20;
                popup.ContentFont = new System.Drawing.Font("Tahoma", 8F);
                popup.BodyColor = Color.FromArgb(32, 32, 32);
                popup.HeaderColor = Color.OrangeRed;
                popup.Size = new Size(400, 180);
                popup.AnimationDuration = 1000;
                popup.TitleText = "Sysphus is Warrning you !!";
                popup.ContentText = "Connexion Avec succes !!";
                popup.ContentColor = Color.White;
                popup.Popup();
                this.Hide();
                Form1 l = new Form1();
                l.ShowDialog();
                this.Close();
            }
            else
            {
                PopupNotifier popup = new PopupNotifier();
                popup.Image = Properties.Resources.notifcations;
                popup.HeaderHeight = 20;
                popup.ContentFont = new System.Drawing.Font("Tahoma", 8F);
                popup.BodyColor = Color.FromArgb(32, 32, 32);
                popup.HeaderColor = Color.OrangeRed;
                popup.Size = new Size(400, 180);
                popup.AnimationDuration = 1000;
                popup.TitleText = "Sysphus is Warrning you!!";
                popup.ContentText = "Le Nom de Utilisateur n'exist pas ou le mode passe est incorect !!";
                popup.ContentColor = Color.White;
                popup.Popup();
            }
            d.Deconnecter();           
        }

        private void GunaLinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit();
        }
    }
}
