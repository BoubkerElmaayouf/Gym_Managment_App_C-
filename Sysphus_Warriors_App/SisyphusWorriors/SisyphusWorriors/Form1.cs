using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using Tulpep.NotificationWindow;
using System.Data.SqlClient;
using System.Threading;
using System.Globalization;
using System.Configuration;
namespace SisyphusWorriors
{
    public partial class Form1 : MaterialForm
    {
        public SqlConnection cnx = new SqlConnection("Data Source=DESKTOP-TNU9JD7;Initial Catalog=SisyphusWarriors;Integrated Security=True");

        // Pour la calcule BMI :
        double T;
        double P;
        double R;

        // la class Ado :
        Ado d = new Ado();

        public Form1()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Red700, Primary.Red700, Primary.Red700, Accent.Red700, TextShade.WHITE);
        }

        // Remplissage de Dgv Member :      
        public void RemplirDGV()
        {
            d.Connecter();
            if (d.dt.Rows != null)
            {
                d.dt.Clear();
            }
            d.cmd.CommandText = "Select * from Member";
            d.cmd.Connection = d.cnx;
            d.dr = d.cmd.ExecuteReader();
            d.dt.Load(d.dr);
            dataGridView.DataSource = d.dt;
            d.dr.Close();
            d.Deconnecter();
        }

        // Remplissage de combobox : 
        public void RempCombobox()
        {
            d.Connecter();
            d.cmd.Connection = d.cnx;
            d.cmd.CommandText = "select CIN from Member";
            d.dr = d.cmd.ExecuteReader();

            while (d.dr.Read())
            {
                //comboCinPay.Items.Add(d.dr[0]);
                CombNomRech.Items.Add(d.dr[0]);
            }
            d.dr.Close();
            d.Deconnecter();
        }
        //Payment Tab :  Remplissage de dgvPayment : 
        public SqlCommand cmd = new SqlCommand();
        public SqlDataReader dr;
        public DataTable dt = new DataTable();
        // Remplissage de dgvPayment :
        public void RemplirDGVDePayment()
        {
            cnx.Open();
            d.Connecter();
            if (dt.Rows != null)
            {
                dt.Clear();
            }
            cmd.CommandText = "Select * from Payment";
            cmd.Connection = cnx;
            dr = cmd.ExecuteReader();
            dt.Load(dr);
            DGVpayment.DataSource = dt;
            dr.Close();
            cnx.Close();
        }

        // Rempplissage de Dgv Produit :
        public SqlCommand cmd2 = new SqlCommand();
        public SqlDataReader dr2;
        public DataTable dt2 = new DataTable();
        public void RemplirDGVDeProd()
        {
            cnx.Open();
            d.Connecter();
            if (dt2.Rows != null)
            {
                dt2.Clear();
            }
            cmd2.CommandText = "Select * from Produit";
            cmd2.Connection = cnx;
            dr2 = cmd2.ExecuteReader();
            dt2.Load(dr2);
            DgvProd.DataSource = dt2;
            dr2.Close();
            cnx.Close();
            d.Deconnecter();
        }

        // Rempplissage de Dgv MATERIAL :
        public SqlCommand cmd3 = new SqlCommand();
        public SqlDataReader dr3;
        public DataTable dt3 = new DataTable();
        public void RemplirDGVDeMat()
        {
            cnx.Open();
            d.Connecter();
            if (dt3.Rows != null)
            {
                dt3.Clear();
            }
            cmd3.CommandText = "Select * from Material";
            cmd3.Connection = cnx;
            dr3 = cmd3.ExecuteReader();
            dt3.Load(dr3);
            DGVEquipement.DataSource = dt3;
            dr3.Close();
            cnx.Close();
            d.Deconnecter();
        }

        // Rempplissage de Dgv Competition :
        public SqlCommand cmd4 = new SqlCommand();
        public SqlDataReader dr4;
        public DataTable dt4 = new DataTable();
        public void RemplirDGVDeComp()
        {
            cnx.Open();
            d.Connecter();
            if (dt4.Rows != null)
            {
                dt4.Clear();
            }
            cmd4.CommandText = "Select * from Competitions";
            cmd4.Connection = cnx;
            dr4 = cmd4.ExecuteReader();
            dt4.Load(dr4);
            DGVComp.DataSource = dt4;
            dr4.Close();
            cnx.Close();
            d.Deconnecter();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RempCombobox();
            RemplirDGV();
            RemplirDGVDePayment();
            RemplirDGVDeProd();
            RemplirDGVDeMat();
            RemplirDGVDeComp();
            lblTotalMember.Text = $"Totale des Member :  {(dataGridView.RowCount) - 1}";
            lblTotalMembers.Text = $" {(dataGridView.RowCount) - 1}";
            lblTotalPay.Text = $" {(DGVpayment.RowCount) - 1}";
            lblTotalProd.Text = $"{(DgvProd.RowCount) - 1}";
            lblTotalEquipe.Text = $" {DGVEquipement.RowCount  - 1} ";
            lblTotalComp.Text = $" {DGVComp.RowCount - 1 } ";

            timer1.Start();
        }
        private void TabPage6_Click(object sender, EventArgs e)
        {
        }
        private void MaterialTextBox6_TextChanged(object sender, EventArgs e)
        {
        }

        //Themes : DARK . LIGHT . ORANGE . BLUE . GEREN . PURPPLE : 
        MaterialSkinManager ThemeManager = MaterialSkinManager.Instance;
        private void MaterialSwitch1_CheckedChanged(object sender, EventArgs e)
        {
            if (switchTheme.Checked)
            {
                ThemeManager.Theme = MaterialSkinManager.Themes.DARK;
                dataGridView.DefaultCellStyle.BackColor = Color.Gray;
                DGVRechercher.DefaultCellStyle.BackColor = Color.Gray;
                DgvProd.DefaultCellStyle.BackColor = Color.Gray;
                DGVpayment.DefaultCellStyle.BackColor = Color.Gray;
                DGVEquipement.DefaultCellStyle.BackColor = Color.Gray;
                PaymentMounth.BaseColor = Color.Gray;
                InscriptiondatePicker.BaseColor = Color.Gray;
                DGVComp.DefaultCellStyle.BackColor = Color.Gray;
                txtDateComp.BaseColor = Color.Gray;               
            }
            else if (switchTheme.Checked == false)
            {
                ThemeManager.Theme = MaterialSkinManager.Themes.LIGHT;
                dataGridView.DefaultCellStyle.BackColor = Color.White;
                DGVRechercher.DefaultCellStyle.BackColor = Color.White;
                DgvProd.DefaultCellStyle.BackColor = Color.White;
                DGVpayment.DefaultCellStyle.BackColor = Color.White;
                DGVEquipement.DefaultCellStyle.BackColor = Color.White;
                PaymentMounth.BaseColor = Color.White;
                InscriptiondatePicker.BaseColor = Color.White;
                DGVComp.DefaultCellStyle.BackColor = Color.White;
                txtDateComp.BaseColor = Color.White;

            }
        }


        //**************Themes************  :
        private void RadioOrange_CheckedChanged(object sender, EventArgs e)
        {
            ThemeManager.ColorScheme = new ColorScheme(Primary.DeepOrange600, Primary.DeepOrange600, Primary.DeepOrange600, Accent.DeepOrange400, TextShade.WHITE);
        }

        private void RadioGreen_CheckedChanged(object sender, EventArgs e)
        {
            ThemeManager.ColorScheme = new ColorScheme(Primary.Green800, Primary.Green800, Primary.Green800, Accent.Green400, TextShade.WHITE);

        }

        private void RadioBlue_CheckedChanged(object sender, EventArgs e)
        {
            ThemeManager.ColorScheme = new ColorScheme(Primary.Blue600, Primary.Blue600, Primary.Blue600, Accent.Blue400, TextShade.WHITE);
        }

        private void RadioPurpple_CheckedChanged(object sender, EventArgs e)
        {
            ThemeManager.ColorScheme = new ColorScheme(Primary.Purple300, Primary.Purple300, Primary.Purple300, Accent.Purple100, TextShade.WHITE);
        }

        private void RadioDefault_CheckedChanged(object sender, EventArgs e)
        {
            ThemeManager.ColorScheme = new ColorScheme(Primary.Red700, Primary.Red700, Primary.Red700, Accent.Red700, TextShade.WHITE);

        }
        //Boutton Vider de calculatrice :
        private void BtnVider_Click(object sender, EventArgs e)
        {
            txtTaille.Text = "";
            txtPoids.Text = "";
            LblBmi.Text = "Resultat de BMI";
            LblBmi.BackColor = Color.Transparent;
            txtBmiResult.BackColor = Color.Transparent;
        }
        // BMI calculator :
        private void BtnCalculer_Click(object sender, EventArgs e)
        {
            try
            {
                T = double.Parse(txtTaille.Text);
                P = double.Parse(txtPoids.Text);
                R = P / (T * T);
                LblBmi.Text = string.Format("{0:f}", R);

                if (R <= 18.5)
                {
                    txtBmiResult.BackColor = Color.DeepSkyBlue;
                    txtBmiResult.Visible = true;
                }
                else if (R >= 18.5 && R <= 24.9)
                {
                    txtBmiResult.BackColor = Color.LawnGreen;
                    txtBmiResult.Visible = true;
                }
                else if (R >= 25 && R <= 30)
                {
                    txtBmiResult.BackColor = Color.OrangeRed;
                    txtBmiResult.Visible = true;
                }
                else if (R > 30)
                {
                    txtBmiResult.BackColor = Color.IndianRed;
                    txtBmiResult.Visible = true;
                }
            }
            catch
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
                popup.ContentText = "Vous avez eu des mauvaise informations,Veulliez réessayer";
                popup.ContentColor = Color.White;
                popup.Popup();
            }
        }

        private void TabPage9_Click(object sender, EventArgs e)
        {

        }

        private void LblBmi_Click(object sender, EventArgs e)
        {
        }

        // Methode Count To add (ADD tab):
        public int CountToAdd()
        {
            int cpt;
            d.cmd.CommandText = "select count(CIN) from Member where CIN ='" + txtCin.Text + "'";
            d.cmd.Connection = d.cnx;
            cpt = (int)d.cmd.ExecuteScalar();
            return cpt;
        }

        //Methode Ajouter() Member : 
        public bool Ajoutter()
        {
            if (CountToAdd() == 0)
            {
                d.cmd.CommandText = "insert into Member values('" + txtCin.Text + " ','" + txtNom.Text + " ','" + txtTele.Text + "','" + txtAge.Text + "','" + comboSexe.SelectedItem + "','" + InscriptiondatePicker.Value.Date + "','" + ComboParti.SelectedItem + "')";
                d.cmd.ExecuteNonQuery();
                return true;
            }
            return false;
        }
        private void BtnAjouter_Click(object sender, EventArgs e)
        {
            try
            {
                d.Connecter();
                if (txtCin.Text == "" || txtNom.Text == "" || txtTele.Text == "" || txtAge.Text == "" || InscriptiondatePicker.Text == "" || comboSexe.Text == "" || ComboParti.Text == "")
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
                    popup.ContentText = "Vous avez eu des mauvaise informations,Veulliez réessayer";
                    popup.ContentColor = Color.White;
                    popup.Popup();
                    return;
                }
                if (Ajoutter() == true)
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
                    popup.ContentText = "Ajoute Avec succes!!";
                    popup.ContentColor = Color.White;
                    popup.Popup();
                    lblTotalMember.Text = $"Totale des Member :  {(dataGridView.RowCount + 1) - 1 } ";
                    d.Deconnecter();
                    RemplirDGV();
                    RempCombobox();
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
                    popup.ContentText = "cette member deja exist!!";
                    popup.ContentColor = Color.White;
                    popup.Popup();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            d.Deconnecter();
        }
        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("voulez vous vider les champs ?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                txtCin.Text = "";
                txtAge.Text = "";
                txtNom.Text = "";
                txtTele.Text = "";
                ComboParti.SelectedIndex = -1;
                comboSexe.SelectedIndex = -1;
                InscriptiondatePicker.Value = DateTime.Now;
            }
        }

        private void TabPage1_Click(object sender, EventArgs e)
        {
        }
        // Methode Supprimer  // Member //:
        public bool Supprimer()
        {
            if (CountToAdd() != 0)
            {
                d.cmd.CommandText = "Delete Member where CIN = '" + txtCin.Text + "'";
                d.cmd.ExecuteNonQuery();
                dataGridView.Refresh();
                return true;
            }
            return false;
        }
        private void BtnSupprimer_Click(object sender, EventArgs e)
        {
            d.Connecter();
            if (MessageBox.Show("voullez vous vider les donner de cette Member ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (txtCin.Text == "")
                {
                    MessageBox.Show("les champ de recherche est vide!!");
                    return;
                }
                else if (Supprimer() == true)
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
                    popup.ContentText = "Supprission avec succes!!";
                    popup.ContentColor = Color.White;
                    popup.Popup();
                    RemplirDGV();
                    RempCombobox();
                    lblTotalMember.Text = $"Totale des Member :  {dataGridView.RowCount - 1}";
                    d.Deconnecter();
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
                    popup.ContentText = "Member n'est pas exist!!";
                    popup.ContentColor = Color.White;
                    popup.Popup();
                }
                d.Deconnecter();
            }
        }
        private void BtnQuitter_Click(object sender, EventArgs e)
        {
        }

        //Boutton   Modifier()  // Members // : 
        public bool Modifier()
        {
            if (CountToAdd() != 0)
            {
                d.cmd.CommandText = "Update Member set Nom = '" + txtNom.Text + "' , Telephone = '" + txtTele.Text + "', Age = '" + txtAge.Text + "', Sexe = '" + comboSexe.SelectedItem + "' ,  Date_inscription = '" + InscriptiondatePicker.Value + "', Participation_Comp = '" + ComboParti.SelectedItem + "' where CIN =  '" + txtCin.Text + "'";
                d.cmd.ExecuteNonQuery();
                return true;
            }
            return false;
        }
        private void BtnViderAdd_Click(object sender, EventArgs e)
        {
            try
            {
                d.Connecter();

                if (txtCin.Text == "" || txtNom.Text == "" || txtNom.Text == "" || txtTele.Text == "" || txtAge.Text == "" || InscriptiondatePicker.Text == "" || comboSexe.Text == "" || ComboParti.Text == "")
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
                    popup.ContentText = "Vous avez eu des mauvaise informations,Veulliez réessayer";
                    popup.ContentColor = Color.White;
                    popup.Popup();
                    return;
                }
                if (Modifier() == true)
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
                    popup.ContentText = "Modification Avec succes!!";
                    popup.ContentColor = Color.White;
                    popup.Popup();
                    RemplirDGV();
                    RempCombobox();
                    d.Deconnecter();
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
                    popup.ContentText = "cette member deja exist!!";
                    popup.ContentColor = Color.White;
                    popup.Popup();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }


        private void GunaComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void GunaButton1_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void GunaButton2_Click(object sender, EventArgs e)
        {
            //Home Tab :
            HomeTab.Text = "Home";
            //tab of Add : *********
            txtCin.Hint = "ID";
            AddTap.Text = "Add Member";
            txtAge.Hint = "Age";
            btnSupprimer.Text = "Delete";
            btnAjouter.Text = "Add";
            btnModifierMember.Text = "Modify";
            txtNom.Hint = "Name";
            txtTele.Hint = "Phone Number";
            ComboParti.Hint = "competition participation";
            comboSexe.Hint = "Gender";
            lbldateinscript.Text = "registration date :";
            btnEmpty.Text = "Empty";
            lblTotalMember.Text = "Total Member :";
            // Rechercher Tab : **************
            lblCinRech.Text = "ID :";
            RechTap.Text = "Searsh";
            CombNomRech.Hint = "Search by Name";
            lblNameRech.Text = "Name : ";
            lblPhoneNumRech.Text = "Phone Number : ";
            lblSexeRech.Text = "Gender :";
            lbldatedinscripRech.Text = "Registration date :";
            lblPartComRech.Text = "Participation in competitions :";
            btnEmptyRech.Text = "Empty";
            btnRechercher.Text = "Search";
            lblMEMBERtOTAL.Text = "Total Members : ";
            lblTitle.Text = "Member Information : ";
            // Payment Tab : *****************       
            PaymentTap.Text = "Payment";
            btnPay.Text = "Pay";
            combAbonment.Hint = "Subscription";
            txtNomPay.Hint = "Search by Name";
            btnRechPaiment.Text = "Search";
            comboCin.Hint = "Name";
            txtAmountPay.Hint = "Amount";
            lbldatePayment.Text = "Payment month :";
            btnEmptyPay.Text = "Empty";

            // Product Tab : ******************
            txtNomRech.Hint = "Type ID";
            ProductTap.Text = "Product";
            txtProductNom.Text =  "Product Name";
            txtProductCateory.Hint = "Product Category";
            txtrductPrice.Hint = "Price";
            txtProductQte.Hint = "Quantity";
            btnViderProd.Text = "Empty";
            btnProductModifie.Text = "Update";
            btnProductAdd.Text = "Add";
            btnProductDelete.Text = "Delete";


            //  Material Tab : *****************
            EquipmentTab.Text = "Equipment";
            txtEquipNom.Hint = "Material Name";
            combCategoryEquip.Hint = "Category";
            combStateEquip.Hint = "State";
            combMuslsUseEquip.Hint = "Target Muscules";
            btnAjouteEquip.Text = "Add";
            btnModifieEquip.Text = "Empty";
            btnModifieEquip.Text = "modify";
            btnSupprimerEquip.Text = "Delete";
            btnRechercherEquip.Text = "Search";
            lblNumEquip.Text = "Total material :";
            // Bmi calculator Tab: 
            calcTab.Text = "BMI Calculator";
            txtTaille.Hint = "Taille";
            lblHeaderTitle.Text = "BMI Calculator :";
            txtTaille.Hint = "Height";
            txtPoids.Hint = "Weight";
            lblResultatBmi.Text = "BMI Result :";
            btnCalculer.Text = "calculate";
            btnVider.Text = "Empty";
            lblRange.Text = "BMI Range :";

            //Settings Tab :
            SettingsTab.Text = "Settings";
            lblTitleTheme.Text = "Select Theme :";
            RadioGreen.Text = "Green";
            RadioBlue.Text = "Blue";
            RadioPurpple.Text = "Purplle";
            RadioDefault.Text = "Default";
            lblLanguage.Text = "Langauge :";
            switchTheme.Text = "Dark and light mode";
            //Competition  Tap : 
            txtCinComp.Text = "ID";
            txtNomCopm.Hint = "Name";
            txtLieuComp.Hint = "Localisation";
            txtTypeComp.Hint = "Competition Type";
            lblDateComp.Text = "Competition Date :";
            btnAjouterComp.Text = "Add";
            btnSupprimerComp.Text = "Delete";
            btnModifierComp.Text = "Update";
            btnViderComp.Text = "Empty";
            lblTotalCompetition.Text = "Competition Total :";
        }

        private void GunaButton3_Click(object sender, EventArgs e)
        {
            //Home Tab :
            HomeTab.Text = "Hogar";
            //tab of Add : *********
            txtCin.Hint = "DNI";
            AddTap.Text = "Agregar Miembro";
            txtAge.Hint = "Edad";
            btnSupprimer.Text = "Borar";
            btnAjouter.Text = "Agregar";
            btnModifierMember.Text = "Modificar";
            txtNom.Hint = "Nombre";
            txtTele.Hint = "Nùmero telefonico";
            ComboParti.Hint = "Participacion de la Competencia";
            comboSexe.Hint = "Género";
            lbldateinscript.Text = "Fecha de registro :";
            btnEmpty.Text = "Vacio";
            lblTotalMember.Text = "Miembro total :";
            // Rechercher Tab : **************
            lblCinRech.Text = "DNI";
            RechTap.Text = "Bùsqueda";
            CombNomRech.Hint = "Bùsqueda Por Nombre";
            lblNameRech.Text = "Nombre : ";
            lblPhoneNumRech.Text = "Nùmero telefonico : ";
            lblSexeRech.Text = "Género :";
            lbldatedinscripRech.Text = "Fecha de registro :";
            lblPartComRech.Text = "Participacion de la Competencia :";
            btnEmptyRech.Text = "Vacio";
            btnRechercher.Text = "Bùsqueda";
            lblMEMBERtOTAL.Text = "Miembro total : ";
            lblTitle.Text = " Informacion de miembro : ";
            // Payment Tab : *****************       
            PaymentTap.Text = "Pago";
            btnPay.Text = "Pagar";
            combAbonment.Hint = "Suscripcion";
            txtNomPay.Hint = "Bùsqueda Por Nombre";
            btnRechPaiment.Text = "Bùsqueda";
            comboCin.Hint = "Nombre";
            txtAmountPay.Hint = "Monto";
            lbldatePayment.Text = "Mes de Pago :";
            btnEmptyPay.Text = "Vacio";

            // Product Tab : ******************

            ProductTap.Text = "Producto";
            txtProductNom.Hint = "nombre del producto";
            txtProductCateory.Hint = "categoria de producto";
            txtrductPrice.Hint = "Precio";
            txtProductQte.Hint = "Cantidad";
            btnViderProd.Text = "Vacío";
            btnProductModifie.Text = "Actualizar";
            btnProductAdd.Text = "Agregar";
            btnProductDelete.Text = "Borrar";

            //  Material Tab : *****************
            EquipmentTab.Text = "Equipo";
            txtEquipNom.Hint = "Nombre de Material";
            combCategoryEquip.Hint = "Categorià";
            combStateEquip.Hint = "Estado";
            combMuslsUseEquip.Hint = "Mùscuulos dirigidos";
            btnAjouteEquip.Text = "Edad";
            btnModifieEquip.Text = "Vacio";
            btnModifieEquip.Text = "Modificar";
            btnSupprimerEquip.Text = "Borar";
            btnRechercherEquip.Text = "Bùsqueda";
            lblNumEquip.Text = "Materiales Total :";
            //Competition  Tap : 
            CompetiTab.Text = "Competencia";
            txtCinComp.Text = "ID";
            txtNomCopm.Hint = "Nombre de la Competencia";
            txtLieuComp.Hint = "Localizacion";
            txtTypeComp.Hint = "Competition Tipo";
            lblDateComp.Text = "Competition Fesha:";
            btnAjouterComp.Text = "Agregar";
            btnSupprimerComp.Text = "Borrar";
            btnModifierComp.Text = "Editar";
            btnViderComp.Text = "Vacio";
            lblTotalCompetition.Text = "Competencia Total :";
            // Bmi calculator Tab: 
            calcTab.Text = "Calculadora de IMC";
            txtTaille.Hint = "Taille";
            lblHeaderTitle.Text = "Calculatora BMI :";
            txtTaille.Hint = "Alturra";
            txtPoids.Hint = "Peso";
            lblResultatBmi.Text = "BMI Resultado :";
            btnCalculer.Text = "Calcular";
            btnVider.Text = "Vacio";
            lblRange.Text = "BMI Distancia :";
            //Settings Tab :
            SettingsTab.Text = "Ajuste";
            lblTitleTheme.Text = "Seleccione Tema :";
            RadioGreen.Text = "Verde";
            RadioBlue.Text = "Azul";
            RadioPurpple.Text = "Pùrpura";
            RadioDefault.Text = "Default";
            lblLanguage.Text = "Idioma :";
            switchTheme.Text = "Estado de ànimo Oscuro y Ligero";
        }

        private void TabPage2_Click(object sender, EventArgs e)
        {
        }

        private void MaterialButton5_Click(object sender, EventArgs e)
        {

        }
        // la selection  dans la dataGridViewv  ADDtab :
        private void DataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dataGridView.CurrentRow.Selected = true;
                    txtCin.Text = dataGridView.Rows[e.RowIndex].Cells["CIN"].Value.ToString();
                    txtNom.Text = dataGridView.Rows[e.RowIndex].Cells["Nom"].Value.ToString();
                    txtTele.Text = dataGridView.Rows[e.RowIndex].Cells["Telephone"].Value.ToString();
                    txtAge.Text = dataGridView.Rows[e.RowIndex].Cells["Age"].Value.ToString();
                    comboSexe.SelectedItem = dataGridView.Rows[e.RowIndex].Cells["Sexe"].Value.ToString();
                    ComboParti.SelectedItem = dataGridView.Rows[e.RowIndex].Cells["Participation_Comp"].Value.ToString();
                    InscriptiondatePicker.Text = dataGridView.Rows[e.RowIndex].Cells[6].Value.ToString();
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
                    popup.ContentText = "Selectionnez uniquement les cellules qui contiennrnt des informations. Veuillez essayer à nouveau !!";
                    popup.ContentColor = Color.White;
                    popup.Popup();
                }
            }
            catch (Exception ex)
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
                popup.ContentText = $"{ex.Message}";
                popup.ContentColor = Color.White;
                popup.Popup();
            }
        }
        private void BtnSupp_Click(object sender, EventArgs e)
        {
        }
        // tabRechercher :
        private void BtnRechercher_Click(object sender, EventArgs e)
        {
            try
            {
                if (CombNomRech.SelectedItem != null || txtNomRech.Text != null)
                {
                    DGVRechercher.Rows.Clear();
                    cnx.Open();
                    SqlCommand cmd = new SqlCommand("select * from Member where CIN ='" + CombNomRech.Text + "' OR  CIN ='" + txtNomRech.Text + "' ", cnx);
                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        DGVRechercher.Rows.Add(dr[0], dr[1], dr[2], dr[3], dr[4], dr[5], dr[6]);
                        lblRechCin.Text = dr[0].ToString();
                        lblName.Text = dr[1].ToString();
                        lblTeleRech.Text = dr[2].ToString();
                        lblAge.Text = dr[3].ToString();
                        lblGender.Text = dr[4].ToString();
                        lblDateinscriptRech.Text = dr[5].ToString();
                        lblParticipationComp.Text = dr[6].ToString();
                        txtNomRech.Text = "";
                        CombNomRech.SelectedIndex = -1;
                        if (lblGender.Text == "")
                        {
                            GifAvatarGender.Show();
                            picGirlsAvatar.Hide();
                            picBoysAvatar.Hide();
                        }
                        if (lblGender.Text == "Homme")
                        {
                            GifAvatarGender.Hide();
                            picGirlsAvatar.Hide();
                            picBoysAvatar.Show();
                        }
                        else if (lblGender.Text == "Femme")
                        {
                            GifAvatarGender.Hide();
                            picBoysAvatar.Hide();
                            picGirlsAvatar.Show();
                        }
                    }
                    dr.Close();
                    cnx.Close();
                }
                else if (CombNomRech.SelectedItem == null || txtNomRech.Text != null)
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

        private void MaterialButton4_Click(object sender, EventArgs e)
        {

        }

        private void MaterlialCard6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MaterialCard8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void RechTap_Click(object sender, EventArgs e)
        {

        }


        // Recherche Tab boutton Empty in search Tab :
        private void BtnEmptyRech_Click(object sender, EventArgs e)
        {
            lblRechCin.Text = "";
            txtNomRech.Text = "";
            CombNomRech.SelectedIndex = -1;
            GifAvatarGender.Show();
            picBoysAvatar.Hide();
            picGirlsAvatar.Hide();
            DGVRechercher.Rows.Clear();
            lblName.Text = "";
            lblTeleRech.Text = "";
            lblAge.Text = "";
            lblGender.Text = "";
            CombNomRech.Text = "";
            lblParticipationComp.Text = "";
            lblDateinscriptRech.Text = "";
        }
        private void TabPage8_Click(object sender, EventArgs e)
        {
        }

        private void BtnRechercherEquip_Click(object sender, EventArgs e)
        {

        }

        private void MaterialCard12_Paint(object sender, PaintEventArgs e)
        {

        }
        private void LblResultatBmi_Click(object sender, EventArgs e)
        {

        }
        private void LblTotalEquip_Click(object sender, EventArgs e)
        {
        }
        private void BtnImprimer_Click(object sender, EventArgs e)
        {
            //imprimer Im = new imprimer();
            //Im.ShowDialog();
        }

        private void BtnExite_Click(object sender, EventArgs e)
        {

        }



        //Payment Tab :  count add
        public int CountToPay()
        {
            int cpt;
            d.cmd.CommandText = "select count(CIN) from Payment where CIN ='" + comboCin.Text + "' Or Nom ='" + txtNomPay.Text + "' ";
            d.cmd.Connection = d.cnx;
            cpt = (int)d.cmd.ExecuteScalar();
            return cpt;
        }
        // Methode Payer   Payment Section  :
        public bool Payer()
        {
            if (CountToPay() == 0)
            {
                d.cmd.CommandText = "insert into Payment values('" + comboCin.Text + " ','" + txtNomPay.Text + " ','" + combAbonment.Text + "','" + txtAmountPay.Text + "','" + PaymentMounth.Value.Date + "')";
                d.cmd.ExecuteNonQuery();
                return true;
            }
            return false;
        }
        private void BtnPay_Click(object sender, EventArgs e)
        {
            try
            {
                d.Connecter();
                if (txtNomPay.Text == "" || comboCin.Text == "" || combAbonment.Text == "" || txtAmountPay.Text == "" || PaymentMounth.Text == "")
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
                    popup.ContentText = "Vous avez eu des mauvaise informations,Veulliez réessayer";
                    popup.ContentColor = Color.White;
                    popup.Popup();
                    return;
                }
                if (Payer() == true)
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
                    popup.ContentText = "Paiemnet Avec succes!!";
                    popup.ContentColor = Color.White;
                    popup.Popup();
                    lblTotalPay.Text = $" {(DGVpayment.RowCount + 1) - 1}";
                    RemplirDGVDePayment();
                    d.Deconnecter();
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
                    popup.ContentText = "cette Paiment a était deja exist!!";
                    popup.ContentColor = Color.White;
                    popup.Popup();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            d.Deconnecter();
        }

        // button vider Payment :
        private void BtnEmptyPay_Click(object sender, EventArgs e)
        {
            comboCin.Text = "";
            combAbonment.SelectedIndex = -1;
            txtNomPay.Text = "";
            txtAmountPay.Text = "";
            PaymentMounth.Text = "";
        }

        //Methode Modifier of Payment Section :
        public bool ModifierPay()
        {
            if (CountToPay() != 0)
            {
                d.cmd.CommandText = "Update Payment set CIN = '" + comboCin.Text + "' , Nom = '" + txtNomPay.Text + "', Abonmement = '" + combAbonment.SelectedItem + "', Mantant = '" + txtAmountPay.Text + "' ,  Mois_paiement = '" + PaymentMounth.Value + "' where CIN =  '" + comboCin.Text + "'";
                d.cmd.ExecuteNonQuery();
                return true;
            }
            return false;
        }
        private void BtnModifierPay_Click(object sender, EventArgs e)
        {
            try
            {
                d.Connecter();

                if (comboCin.Text == "" || txtNomPay.Text == "" || combAbonment.Text == "" || txtAmountPay.Text == "" || PaymentMounth.Text == "")
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
                    popup.ContentText = "Vous avez eu des mauvaise informations,Veulliez réessayer";
                    popup.ContentColor = Color.White;
                    popup.Popup();
                    return;
                }
                if (ModifierPay() == true)
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
                    popup.ContentText = "Modification Avec succes!!";
                    popup.ContentColor = Color.White;
                    popup.Popup();
                    RemplirDGVDePayment();
                    d.Deconnecter();
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
                    popup.ContentText = "cette member deja exist!!";
                    popup.ContentColor = Color.White;
                    popup.Popup();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }


        //Payment Supprition Methode  :
        public bool SupprimerPay()
        {
            if (CountToPay() != 0)
            {
                d.cmd.CommandText = "Delete Payment where CIN = '" + comboCin.Text + "'";
                d.cmd.ExecuteNonQuery();
                //dataGridView.Refresh();
                return true;
            }
            return false;
        }
        private void BtnSuppPay_Click(object sender, EventArgs e)
        {
            d.Connecter();
            if (MessageBox.Show("voullez vous vider les donner de cette Member ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (comboCin.Text == "")
                {
                    MessageBox.Show("les champ de recherche est vide!!");
                    return;
                }
                if (SupprimerPay() == true)
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
                    popup.ContentText = "Supprission avec succes!!";
                    popup.ContentColor = Color.White;
                    popup.Popup();
                    lblTotalPay.Text = $" {DGVpayment.RowCount - 1}";
                    RemplirDGVDePayment();
                    d.Deconnecter();
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
                    popup.ContentText = "Member n'est pas exist!!";
                    popup.ContentColor = Color.White;
                    popup.Popup();
                }
                d.Deconnecter();
            }
        }

        private void DataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DGVpayment_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DGVpayment_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        //btn Rechecrher des Paiments 
        private void BtnRechPaiment_Click(object sender, EventArgs e)
        {
            RechercherDesPayment R = new RechercherDesPayment();
            R.ShowDialog();
        }




        // The Home Timer :
        private void Timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("HH:mm");
            lblSeconds.Text = DateTime.Now.ToString("ss");
            lbldated.Text = DateTime.Now.ToString("dd MMM yyyy");
            lblDays.Text = DateTime.Now.ToString("dddd");
            //lblSeconds.Location = new Point(lblTime.Location.X + lblTime.Width, lblSeconds.Location.Y);
        }

        private void MaterialCard13_Paint(object sender, PaintEventArgs e)
        {

        }

        // Cell Click of the Payment Section :
        private void DGVpayment_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (DGVpayment.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    DGVpayment.CurrentRow.Selected = true;
                    comboCin.Text = DGVpayment.Rows[e.RowIndex].Cells[1].Value.ToString();
                    txtNomPay.Text = DGVpayment.Rows[e.RowIndex].Cells[2].Value.ToString();
                    combAbonment.SelectedItem = DGVpayment.Rows[e.RowIndex].Cells[3].Value.ToString();
                    txtAmountPay.Text = DGVpayment.Rows[e.RowIndex].Cells[4].Value.ToString();
                    PaymentMounth.Text = DGVpayment.Rows[e.RowIndex].Cells[5].Value.ToString();
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
                    popup.ContentText = "Selectionnez uniquement les cellules qui contiennrnt des informations. Veuillez essayer à nouveau !!";
                    popup.ContentColor = Color.White;
                    popup.Popup();
                }
            }
            catch (Exception ex)
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
                popup.ContentText = $"{ex.Message}";
                popup.ContentColor = Color.White;
                popup.Popup();
            }
        }

        private void BtnExporter_Click(object sender, EventArgs e)
        {
            ExporterLesPaiments E = new ExporterLesPaiments();
            E.ShowDialog();
        }

        private void BtnExporter_Click_1(object sender, EventArgs e)
        {

        }

        private void TxtProductCateory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //********** Produit ********* :
        //Ajouter : 
        // Methode Count To add (Produit):
        public int CountToProd()
        {
            int cpt;
            d.cmd.CommandText = "select count(NomProduit) from Produit where NomProduit ='" + txtProductNom.Text + "'";
            d.cmd.Connection = d.cnx;
            cpt = (int)d.cmd.ExecuteScalar();
            return cpt;
        }

        //Methode Ajouter() Produit : 
        public bool AjoutterProd()
        {
            if (CountToProd() == 0)
            {
                d.cmd.CommandText = "insert into Produit values('" + txtProductNom.Text + " ','" + txtProductCateory.SelectedItem + " ','" + txtrductPrice.Text + "','" + txtProductQte.Text + "')";
                d.cmd.ExecuteNonQuery();
                return true;
            }
            return false;
        }
        private void BtnProductAdd_Click(object sender, EventArgs e)
        {
            try
            {
                d.Connecter();
                if (txtProductNom.Text == "" || txtProductCateory.Text == "" || txtrductPrice.Text == "" || txtrductPrice.Text == "" || txtProductQte.Text == "")
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
                    popup.ContentText = "Vous avez eu des mauvaise informations,Veulliez réessayer";
                    popup.ContentColor = Color.White;
                    popup.Popup();
                    return;
                }
                if (AjoutterProd() == true)
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
                    popup.ContentText = "Ajoute Avec succes!!";
                    popup.ContentColor = Color.White;
                    popup.Popup();
                    lblTotalProd.Text = $"{(DgvProd.RowCount + 1) - 1}";

                    RemplirDGVDeProd();
                    d.Deconnecter();
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
                    popup.ContentText = "cette Produit a était deja exist!!";
                    popup.ContentColor = Color.White;
                    popup.Popup();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            d.Deconnecter();
        }

        // Supprission  Produit :
        public bool SupprimerProd()
        {
            if (CountToProd() != 0)
            {
                d.cmd.CommandText = "Delete Produit where NomProduit = '" + txtProductNom.Text + "'";
                d.cmd.ExecuteNonQuery();
                dataGridView.Refresh();
                return true;
            }
            return false;
        }

        private void BtnProductDelete_Click(object sender, EventArgs e)
        {
            d.Connecter();
            if (MessageBox.Show("voullez vous vider les donner de cette Produit ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {   
                if (txtProductNom.Text == "")
                {
                    MessageBox.Show("les champ de recherche est vide!!");
                    return;
                }
                else if (SupprimerProd() == true)
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
                    popup.ContentText = "Supprission avec succes!!";
                    popup.ContentColor = Color.White;
                    popup.Popup();
                    lblTotalProd.Text = $"{DgvProd.RowCount - 1}";
                    RemplirDGVDeProd();
                    d.Deconnecter();
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
                    popup.ContentText = "Member n'est pas exist!!";
                    popup.ContentColor = Color.White;
                    popup.Popup();
                }
                d.Deconnecter();
            }
        }

        // Btn Modifier : 
        public bool ModifierProd()
        {
            if (CountToProd() != 0)
            {
                d.cmd.CommandText = "Update Produit set NomProduit = '" + txtProductNom.Text + "' , CatégorieProd = '" + txtProductCateory.Text + "', Prix = '" + txtrductPrice.Text + "', quantité_Stock = '" + txtProductQte.Text + "'  where NomProduit =  '" + txtProductNom.Text + "'";
                d.cmd.ExecuteNonQuery();
                return true;
            }
            return false;
        }
        private void BtnProductModifie_Click(object sender, EventArgs e)
        {
            try
            {
                d.Connecter();

                if (txtProductNom.Text == "" || txtProductCateory.Text == "" || txtrductPrice.Text == "" || txtProductQte.Text == "")
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
                    popup.ContentText = "Vous avez eu des mauvaise informations,Veulliez réessayer";
                    popup.ContentColor = Color.White;
                    popup.Popup();
                    return;
                }
                if (ModifierProd() == true)
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
                    popup.ContentText = "Modification Avec succes!!";
                    popup.ContentColor = Color.White;
                    popup.Popup();
                    RemplirDGVDeProd();
                    d.Deconnecter();
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
                    popup.ContentText = "cette Produit deja exist!!";
                    popup.ContentColor = Color.White;
                    popup.Popup();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void BtnViderProd_Click(object sender, EventArgs e)
        {
            txtProductQte.Text = "";
            txtProductNom.Text = "";
            txtrductPrice.Text = "";
            txtProductCateory.SelectedIndex = -1;
        }

        private void DgvProd_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (DgvProd.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    DgvProd.CurrentRow.Selected = true;
                    txtProductNom.Text = DgvProd.Rows[e.RowIndex].Cells[1].Value.ToString();
                    txtProductCateory.SelectedItem = DgvProd.Rows[e.RowIndex].Cells[2].Value.ToString();
                    txtrductPrice.Text = DgvProd.Rows[e.RowIndex].Cells[3].Value.ToString();
                    txtProductQte.Text = DgvProd.Rows[e.RowIndex].Cells[4].Value.ToString();
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
                    popup.ContentText = "Selectionnez uniquement les cellules qui contiennrnt des informations. Veuillez essayer à nouveau !!";
                    popup.ContentColor = Color.White;
                    popup.Popup();
                }
            }
            catch (Exception ex)
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
                popup.ContentText = $"{ex.Message}";
                popup.ContentColor = Color.White;
                popup.Popup();
            }
        }



        // ************ Matairial Tap *************** :
        // Methode Count To add (Material Tab):
        public int CountToAddMat()
        {
            int cpt;
            d.cmd.CommandText = "select count(Nom_Matériau) from Material where Nom_Matériau ='" + txtEquipNom.Text + "'";
            d.cmd.Connection = d.cnx;
            cpt = (int)d.cmd.ExecuteScalar();
            return cpt;
        }

        //Methode Ajouter()  Equipment: 
        public bool AjoutterMat()
        {
            if (CountToAddMat() == 0)
            {
                d.cmd.CommandText = "insert into Material values('" + txtEquipNom.Text + "','" + combCategoryEquip.SelectedItem + "','" + combMuslsUseEquip.SelectedItem + "','" + combStateEquip.SelectedItem + "' ,'" + richtxtDescription.Text + "')";
                d.cmd.ExecuteNonQuery();
                return true;
            }
            return false;
        }
        private void BtnAjouteEquip_Click(object sender, EventArgs e)
        {
            try
            {
                d.Connecter();
                if (txtEquipNom.Text == "" || combCategoryEquip.Text == "" || combMuslsUseEquip.Text == "" || combStateEquip.Text == "" || richtxtDescription.Text == "")
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
                    popup.ContentText = "Vous avez eu des mauvaise informations,Veulliez réessayer";
                    popup.ContentColor = Color.White;
                    popup.Popup();
                    return;
                }
                if (AjoutterMat() == true)
                {
                    RemplirDGVDeMat();
                    lblTotalEquipe.Text = $" {(DGVEquipement.RowCount + 1) - 1} ";
                    PopupNotifier popup = new PopupNotifier();
                    popup.Image = Properties.Resources.notifcations;
                    popup.HeaderHeight = 20;
                    popup.ContentFont = new System.Drawing.Font("Tahoma", 8F);
                    popup.BodyColor = Color.FromArgb(32, 32, 32);
                    popup.HeaderColor = Color.OrangeRed;
                    popup.Size = new Size(400, 180);
                    popup.AnimationDuration = 1000;
                    popup.TitleText = "Sysphus is Warrning you!!";
                    popup.ContentText = "Ajoute Avec succes!!";
                    popup.ContentColor = Color.White;
                    popup.Popup();
                    d.Deconnecter();
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
                    popup.ContentText = "cette member deja exist!!";
                    popup.ContentColor = Color.White;
                    popup.Popup();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            d.Deconnecter();
        }

        private void BtnRechercherEquip_Click_1(object sender, EventArgs e)
        {
            RechercherDesMaterial RM = new RechercherDesMaterial();
            RM.ShowDialog();
        }


        // Methode Supprimer  // Member //:
        public bool SupprimerMat()
        {
            if (CountToAddMat() != 0)
            {
                d.cmd.CommandText = "Delete Material where Nom_Matériau = '" + txtEquipNom.Text + "'";
                d.cmd.ExecuteNonQuery();
                dataGridView.Refresh();
                return true;
            }
            return false;
        }
        private void BtnSupprimerEquip_Click(object sender, EventArgs e)
        {
            d.Connecter();
            if (MessageBox.Show("voullez vous vider les donner de cette Material ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (txtEquipNom.Text == "")
                {
                    MessageBox.Show("le champ de recherche est vide!!");
                    return;
                }
                else if (SupprimerMat() == true)
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
                    popup.ContentText = "Supprission avec succes!!";
                    popup.ContentColor = Color.White;
                    popup.Popup();
                    RemplirDGVDeMat();
                    lblTotalEquipe.Text = $" {DGVEquipement.RowCount - 1}";
                    d.Deconnecter();
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
                    popup.ContentText = "Material n'est pas exist!!";
                    popup.ContentColor = Color.White;
                    popup.Popup();
                }
                d.Deconnecter();
            }
        }
        // Btn Modifier Mat : 
        public bool ModifierMat()
        {
            if (CountToAddMat() != 0)
            {
                d.cmd.CommandText = "Update Material set [Nom_Matériau] = '" + txtEquipNom.Text + "' , Categorie = '" + combCategoryEquip.Text + "', Muscles_ciblés = '" + combMuslsUseEquip.Text + "', [État] = '" + combStateEquip.Text + "' ,[Description] = '" + richtxtDescription.Text + "' where [Nom_Matériau] =  '" + txtEquipNom.Text + "'";
                d.cmd.ExecuteNonQuery();
                return true;
            }
            return false;
        }
        private void BtnModifieEquip_Click(object sender, EventArgs e)
        {
            try
            {
            d.Connecter(); 
            if (txtEquipNom.Text == "" || combCategoryEquip.Text == "" || combMuslsUseEquip.Text == "" || combStateEquip.Text == "" || richtxtDescription.Text == "")
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
                popup.ContentText = "Vous avez eu des mauvaise informations,Veulliez réessayer";
                popup.ContentColor = Color.White;
                popup.Popup();
                return;
            }
            if (ModifierMat() == true)
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
                popup.ContentText = "Modification Avec succes!!";
                popup.ContentColor = Color.White;
                popup.Popup();
                RemplirDGVDeMat();
                d.Deconnecter();
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
                popup.ContentText = "cette member était déja deja exist!!";
                popup.ContentColor = Color.White;
                popup.Popup();
            }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
         }


        // Competition Tab :

        // Methode Count To add (Copitition Tab):
        public int CountToAddComp()
        {
            int cpt;
            d.cmd.CommandText = "select count([CIN_Member]) from Competitions where [CIN_Member] ='" + txtCinComp.Text + "'";
            d.cmd.Connection = d.cnx;
            cpt = (int)d.cmd.ExecuteScalar();
            return cpt;
        }

        //Methode Ajouter()  Copitition: 
        public bool AjoutterComp()
        {
            if (CountToAddComp() == 0)
            {
                d.cmd.CommandText = "insert into Competitions values('" + txtCinComp.Text + "','" + txtNomCopm.Text + "','" + txtLieuComp.Text + "','" + txtTypeComp.SelectedItem + "' ,'" + txtDateComp.Value.Date + "')";
                d.cmd.ExecuteNonQuery();
                return true;
            }
            return false;
        }
        private void BtnAjouterComp_Click(object sender, EventArgs e)
        {
            try
            {
                d.Connecter();
                if (txtCinComp.Text == "" || txtNomCopm.Text == "" || txtLieuComp.Text == "" || txtDateComp.Text == "" || txtTypeComp.Text == "")
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
                    popup.ContentText = "Vous avez eu des mauvaise informations,Veulliez réessayer";
                    popup.ContentColor = Color.White;
                    popup.Popup();
                    return;
                }
                if (AjoutterComp() == true)
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
                    popup.ContentText = "Ajoute Avec succes!!";
                    popup.ContentColor = Color.White;
                    popup.Popup();
                    lblTotalComp.Text = $" {(DGVComp.RowCount + 1) - 1 } ";
                    d.Deconnecter();
                    RemplirDGVDeComp();
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
                    popup.ContentText = "cette Competition était déja deja exist!!";
                    popup.ContentColor = Color.White;
                    popup.Popup();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            d.Deconnecter();
        }

        private void BtnViderComp_Click(object sender, EventArgs e)
        {
            txtNomCopm.Text = "";
            txtCinComp.Text = "";
            txtLieuComp.Text = "";
            txtTypeComp.SelectedIndex = -1;
            txtDateComp.Text = "";
        }
        // Methode Supprimer  // Member //:
        public bool SupprimerComp()
        {
            if (CountToAddComp() != 0)
            {
                d.cmd.CommandText = "Delete Competitions where [CIN_Member] = '" + txtCinComp.Text + "'";
                d.cmd.ExecuteNonQuery();
                dataGridView.Refresh();
                return true;
            }
            return false;
        }
        private void BtnSupprimerComp_Click(object sender, EventArgs e)
        {
            d.Connecter();
            if (MessageBox.Show("voullez vous vider les donner de cette Competition ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (txtCinComp.Text == "")
                {
                    MessageBox.Show("le champ de recherche est vide!!");
                    return;
                }
                else if (SupprimerComp() == true)
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
                    popup.ContentText = "Supprission avec succes!!";
                    popup.ContentColor = Color.White;
                    popup.Popup();
                    RemplirDGVDeComp();
                    lblTotalComp.Text = $" {DGVComp.RowCount - 1}";
                    d.Deconnecter();       
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
                    popup.ContentText = "Material n'est pas exist!!";
                    popup.ContentColor = Color.White;
                    popup.Popup();
                }
                d.Deconnecter();
            }
        }

        //Modifier Les Competition :
        public bool ModifierComp()
        {
            if (CountToAddComp() != 0)
            {
                d.cmd.CommandText = "Update Competitions set [CIN_Member] = '" + txtCinComp.Text + "' , [Nom_Competition] = '" + txtNomCopm.Text + "', [Lieu_Compitition] = '" + txtLieuComp.Text + "', [Type_Comp] = '" + txtTypeComp.Text + "' ,[date_comp] = '" + txtDateComp.Value + "' where [CIN_Member] =  '" + txtCinComp.Text + "'";
                d.cmd.ExecuteNonQuery();
                return true;
            }
            return false;
        }

        private void BtnModifierComp_Click(object sender, EventArgs e)
        {
            try
            {
                d.Connecter();
                if (txtCinComp.Text == "" || txtNomCopm.Text == "" || txtTypeComp.Text == "" || txtDateComp.Text == "" )
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
                    popup.ContentText = "Vous avez eu des mauvaise informations,Veulliez réessayer";
                    popup.ContentColor = Color.White;
                    popup.Popup();
                    return;
                }
                if (ModifierComp() == true)
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
                    popup.ContentText = "Modification Avec succes!!";
                    popup.ContentColor = Color.White;
                    popup.Popup();
                    RemplirDGVDeComp();
                    d.Deconnecter();
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
                    popup.ContentText = "cette Competition a était deja exist!!";
                    popup.ContentColor = Color.White;
                    popup.Popup();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void BtnViderMat_Click(object sender, EventArgs e)
        {
            txtEquipNom.Text = "";
            combCategoryEquip.SelectedIndex = -1;
            combMuslsUseEquip.SelectedIndex = -1;
            combStateEquip.SelectedIndex = -1;
            richtxtDescription.Text = "";
        }

        private void MaterialLabel1_Click(object sender, EventArgs e)
        {

        }

        private void MaterialCard20_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DGVEquipement_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (DGVEquipement.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    DGVEquipement.CurrentRow.Selected = true;
                    txtEquipNom.Text = DGVEquipement.Rows[e.RowIndex].Cells[1].Value.ToString();
                    combCategoryEquip.SelectedItem = DGVEquipement.Rows[e.RowIndex].Cells[2].Value.ToString();
                    combMuslsUseEquip.SelectedItem = DGVEquipement.Rows[e.RowIndex].Cells[3].Value.ToString();
                    combStateEquip.SelectedItem = DGVEquipement.Rows[e.RowIndex].Cells[4].Value.ToString();
                    richtxtDescription.Text = DGVEquipement.Rows[e.RowIndex].Cells[5].Value.ToString();
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
                    popup.ContentText = "Selectionnez uniquement les cellules qui contiennrnt des informations. Veuillez essayer à nouveau !!";
                    popup.ContentColor = Color.White;
                    popup.Popup();
                }
            }
            catch (Exception ex)
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
                popup.ContentText = $"{ex.Message}";
                popup.ContentColor = Color.White;
                popup.Popup();
            }
        }

        private void DGVComp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (DGVComp.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    DGVComp.CurrentRow.Selected = true;
                    txtCinComp.Text = DGVComp.Rows[e.RowIndex].Cells[1].Value.ToString();
                    txtNomCopm.Text = DGVComp.Rows[e.RowIndex].Cells[2].Value.ToString();
                    txtLieuComp.Text = DGVComp.Rows[e.RowIndex].Cells[3].Value.ToString();
                    txtTypeComp.SelectedItem = DGVComp.Rows[e.RowIndex].Cells[4].Value.ToString();
                    txtDateComp.Text = DGVComp.Rows[e.RowIndex].Cells[5].Value.ToString();
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
                    popup.ContentText = "Selectionnez uniquement les cellules qui contiennrnt des informations. Veuillez essayer à nouveau !!";
                    popup.ContentColor = Color.White;
                    popup.Popup();
                }
            }
            catch (Exception ex)
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
                popup.ContentText = $"{ex.Message}";
                popup.ContentColor = Color.White;
                popup.Popup();
            }
        }

    }
}


    

