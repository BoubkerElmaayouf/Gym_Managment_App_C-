namespace SisyphusWorriors
{
    partial class RechercherDesMaterial
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RechercherDesMaterial));
            this.btnVider = new Guna.UI.WinForms.GunaAdvenceButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtRechNomEquip = new MaterialSkin.Controls.MaterialTextBox();
            this.btnRechercherPay = new Guna.UI.WinForms.GunaAdvenceButton();
            this.DgvRech = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CIN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Abonmement = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mantant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mois_paiement = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblb7777 = new MaterialSkin.Controls.MaterialLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.materialCard6 = new MaterialSkin.Controls.MaterialCard();
            this.lblMat = new MaterialSkin.Controls.MaterialLabel();
            this.lblblblb = new MaterialSkin.Controls.MaterialLabel();
            this.lblNomMat = new MaterialSkin.Controls.MaterialLabel();
            this.lblCat = new MaterialSkin.Controls.MaterialLabel();
            this.lblPhoneNumRech = new MaterialSkin.Controls.MaterialLabel();
            this.Etat = new MaterialSkin.Controls.MaterialLabel();
            this.lblMusUse = new MaterialSkin.Controls.MaterialLabel();
            this.lblAgeRech = new MaterialSkin.Controls.MaterialLabel();
            this.lbldatedinscripRech = new MaterialSkin.Controls.MaterialLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.lblDescription = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvRech)).BeginInit();
            this.materialCard6.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnVider
            // 
            this.btnVider.AnimationHoverSpeed = 0.07F;
            this.btnVider.AnimationSpeed = 0.03F;
            this.btnVider.BackColor = System.Drawing.Color.Transparent;
            this.btnVider.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.btnVider.BorderColor = System.Drawing.Color.Black;
            this.btnVider.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnVider.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnVider.CheckedForeColor = System.Drawing.Color.White;
            this.btnVider.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnVider.CheckedImage")));
            this.btnVider.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnVider.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnVider.FocusedColor = System.Drawing.Color.Empty;
            this.btnVider.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVider.ForeColor = System.Drawing.Color.White;
            this.btnVider.Image = null;
            this.btnVider.ImageSize = new System.Drawing.Size(20, 20);
            this.btnVider.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(229)))), ((int)(((byte)(128)))));
            this.btnVider.Location = new System.Drawing.Point(600, 57);
            this.btnVider.Name = "btnVider";
            this.btnVider.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btnVider.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnVider.OnHoverForeColor = System.Drawing.Color.White;
            this.btnVider.OnHoverImage = null;
            this.btnVider.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btnVider.OnPressedColor = System.Drawing.Color.Black;
            this.btnVider.Radius = 5;
            this.btnVider.Size = new System.Drawing.Size(100, 50);
            this.btnVider.TabIndex = 95;
            this.btnVider.Text = "Vider";
            this.btnVider.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnVider.Click += new System.EventHandler(this.BtnVider_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SisyphusWorriors.Properties.Resources.Artboard_12;
            this.pictureBox1.Location = new System.Drawing.Point(517, 203);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(197, 173);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 94;
            this.pictureBox1.TabStop = false;
            // 
            // txtRechNomEquip
            // 
            this.txtRechNomEquip.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRechNomEquip.Depth = 0;
            this.txtRechNomEquip.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtRechNomEquip.Hint = "Taper le Nom du matériau";
            this.txtRechNomEquip.Location = new System.Drawing.Point(169, 57);
            this.txtRechNomEquip.MaxLength = 50;
            this.txtRechNomEquip.MouseState = MaterialSkin.MouseState.OUT;
            this.txtRechNomEquip.Multiline = false;
            this.txtRechNomEquip.Name = "txtRechNomEquip";
            this.txtRechNomEquip.Size = new System.Drawing.Size(228, 50);
            this.txtRechNomEquip.TabIndex = 89;
            this.txtRechNomEquip.Text = "";
            // 
            // btnRechercherPay
            // 
            this.btnRechercherPay.AnimationHoverSpeed = 0.07F;
            this.btnRechercherPay.AnimationSpeed = 0.03F;
            this.btnRechercherPay.BackColor = System.Drawing.Color.Transparent;
            this.btnRechercherPay.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.btnRechercherPay.BorderColor = System.Drawing.Color.Black;
            this.btnRechercherPay.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnRechercherPay.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnRechercherPay.CheckedForeColor = System.Drawing.Color.White;
            this.btnRechercherPay.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnRechercherPay.CheckedImage")));
            this.btnRechercherPay.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnRechercherPay.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnRechercherPay.FocusedColor = System.Drawing.Color.Empty;
            this.btnRechercherPay.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRechercherPay.ForeColor = System.Drawing.Color.White;
            this.btnRechercherPay.Image = null;
            this.btnRechercherPay.ImageSize = new System.Drawing.Size(20, 20);
            this.btnRechercherPay.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(229)))), ((int)(((byte)(128)))));
            this.btnRechercherPay.Location = new System.Drawing.Point(432, 57);
            this.btnRechercherPay.Name = "btnRechercherPay";
            this.btnRechercherPay.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btnRechercherPay.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnRechercherPay.OnHoverForeColor = System.Drawing.Color.White;
            this.btnRechercherPay.OnHoverImage = null;
            this.btnRechercherPay.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btnRechercherPay.OnPressedColor = System.Drawing.Color.Black;
            this.btnRechercherPay.Radius = 5;
            this.btnRechercherPay.Size = new System.Drawing.Size(137, 50);
            this.btnRechercherPay.TabIndex = 93;
            this.btnRechercherPay.Text = "Rechercher";
            this.btnRechercherPay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnRechercherPay.Click += new System.EventHandler(this.BtnRechercherPay_Click);
            // 
            // DgvRech
            // 
            this.DgvRech.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvRech.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(85)))), ((int)(((byte)(74)))));
            this.DgvRech.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvRech.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvRech.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.CIN,
            this.NOM,
            this.Abonmement,
            this.Mantant,
            this.Mois_paiement});
            this.DgvRech.Location = new System.Drawing.Point(12, 132);
            this.DgvRech.Name = "DgvRech";
            this.DgvRech.Size = new System.Drawing.Size(783, 61);
            this.DgvRech.TabIndex = 91;
            // 
            // id
            // 
            this.id.HeaderText = "Matricule";
            this.id.Name = "id";
            // 
            // CIN
            // 
            this.CIN.HeaderText = "Nom du matériau";
            this.CIN.Name = "CIN";
            // 
            // NOM
            // 
            this.NOM.HeaderText = "Catégorie";
            this.NOM.Name = "NOM";
            // 
            // Abonmement
            // 
            this.Abonmement.HeaderText = "Muscles Ciblés";
            this.Abonmement.Name = "Abonmement";
            // 
            // Mantant
            // 
            this.Mantant.HeaderText = "Etat";
            this.Mantant.Name = "Mantant";
            // 
            // Mois_paiement
            // 
            this.Mois_paiement.HeaderText = "Description";
            this.Mois_paiement.Name = "Mois_paiement";
            // 
            // lblb7777
            // 
            this.lblb7777.AutoSize = true;
            this.lblb7777.Depth = 0;
            this.lblb7777.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblb7777.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblb7777.Location = new System.Drawing.Point(36, 87);
            this.lblb7777.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblb7777.Name = "lblb7777";
            this.lblb7777.Size = new System.Drawing.Size(132, 19);
            this.lblb7777.TabIndex = 62;
            this.lblb7777.Text = "Nom du matériau :";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.BackColor = System.Drawing.Color.White;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.gunaLabel2.Location = new System.Drawing.Point(8, 9);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(277, 21);
            this.gunaLabel2.TabIndex = 96;
            this.gunaLabel2.Text = "Rechercher avec le Nom du  matériau :";
            // 
            // materialCard6
            // 
            this.materialCard6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard6.Controls.Add(this.lblMat);
            this.materialCard6.Controls.Add(this.lblblblb);
            this.materialCard6.Controls.Add(this.lblNomMat);
            this.materialCard6.Controls.Add(this.lblCat);
            this.materialCard6.Controls.Add(this.lblPhoneNumRech);
            this.materialCard6.Controls.Add(this.lblb7777);
            this.materialCard6.Controls.Add(this.Etat);
            this.materialCard6.Controls.Add(this.lblMusUse);
            this.materialCard6.Controls.Add(this.lblAgeRech);
            this.materialCard6.Controls.Add(this.lbldatedinscripRech);
            this.materialCard6.Depth = 0;
            this.materialCard6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard6.Location = new System.Drawing.Point(23, 230);
            this.materialCard6.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard6.Name = "materialCard6";
            this.materialCard6.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard6.Size = new System.Drawing.Size(388, 308);
            this.materialCard6.TabIndex = 92;
            // 
            // lblMat
            // 
            this.lblMat.AutoSize = true;
            this.lblMat.BackColor = System.Drawing.Color.White;
            this.lblMat.Depth = 0;
            this.lblMat.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblMat.ForeColor = System.Drawing.Color.Black;
            this.lblMat.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblMat.Location = new System.Drawing.Point(183, 35);
            this.lblMat.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblMat.Name = "lblMat";
            this.lblMat.Size = new System.Drawing.Size(13, 19);
            this.lblMat.TabIndex = 67;
            this.lblMat.Text = "...";
            // 
            // lblblblb
            // 
            this.lblblblb.AutoSize = true;
            this.lblblblb.Depth = 0;
            this.lblblblb.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblblblb.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblblblb.Location = new System.Drawing.Point(36, 35);
            this.lblblblb.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblblblb.Name = "lblblblb";
            this.lblblblb.Size = new System.Drawing.Size(75, 19);
            this.lblblblb.TabIndex = 66;
            this.lblblblb.Text = "Matricule :";
            // 
            // lblNomMat
            // 
            this.lblNomMat.AutoSize = true;
            this.lblNomMat.BackColor = System.Drawing.Color.White;
            this.lblNomMat.Depth = 0;
            this.lblNomMat.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblNomMat.ForeColor = System.Drawing.Color.Black;
            this.lblNomMat.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblNomMat.Location = new System.Drawing.Point(183, 87);
            this.lblNomMat.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblNomMat.Name = "lblNomMat";
            this.lblNomMat.Size = new System.Drawing.Size(13, 19);
            this.lblNomMat.TabIndex = 65;
            this.lblNomMat.Text = "...";
            // 
            // lblCat
            // 
            this.lblCat.AutoSize = true;
            this.lblCat.Depth = 0;
            this.lblCat.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblCat.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblCat.Location = new System.Drawing.Point(183, 137);
            this.lblCat.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCat.Name = "lblCat";
            this.lblCat.Size = new System.Drawing.Size(13, 19);
            this.lblCat.TabIndex = 64;
            this.lblCat.Text = "...";
            // 
            // lblPhoneNumRech
            // 
            this.lblPhoneNumRech.AutoSize = true;
            this.lblPhoneNumRech.Depth = 0;
            this.lblPhoneNumRech.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblPhoneNumRech.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblPhoneNumRech.Location = new System.Drawing.Point(36, 137);
            this.lblPhoneNumRech.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblPhoneNumRech.Name = "lblPhoneNumRech";
            this.lblPhoneNumRech.Size = new System.Drawing.Size(84, 19);
            this.lblPhoneNumRech.TabIndex = 63;
            this.lblPhoneNumRech.Text = "Catégorie  : ";
            // 
            // Etat
            // 
            this.Etat.AutoSize = true;
            this.Etat.Depth = 0;
            this.Etat.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Etat.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Etat.Location = new System.Drawing.Point(183, 234);
            this.Etat.MouseState = MaterialSkin.MouseState.HOVER;
            this.Etat.Name = "Etat";
            this.Etat.Size = new System.Drawing.Size(13, 19);
            this.Etat.TabIndex = 50;
            this.Etat.Text = "...";
            // 
            // lblMusUse
            // 
            this.lblMusUse.AutoSize = true;
            this.lblMusUse.Depth = 0;
            this.lblMusUse.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblMusUse.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblMusUse.Location = new System.Drawing.Point(183, 185);
            this.lblMusUse.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblMusUse.Name = "lblMusUse";
            this.lblMusUse.Size = new System.Drawing.Size(13, 19);
            this.lblMusUse.TabIndex = 47;
            this.lblMusUse.Text = "...";
            // 
            // lblAgeRech
            // 
            this.lblAgeRech.AutoSize = true;
            this.lblAgeRech.Depth = 0;
            this.lblAgeRech.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblAgeRech.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblAgeRech.Location = new System.Drawing.Point(36, 234);
            this.lblAgeRech.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblAgeRech.Name = "lblAgeRech";
            this.lblAgeRech.Size = new System.Drawing.Size(37, 19);
            this.lblAgeRech.TabIndex = 44;
            this.lblAgeRech.Text = "État :";
            // 
            // lbldatedinscripRech
            // 
            this.lbldatedinscripRech.AutoSize = true;
            this.lbldatedinscripRech.Depth = 0;
            this.lbldatedinscripRech.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbldatedinscripRech.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbldatedinscripRech.Location = new System.Drawing.Point(36, 185);
            this.lbldatedinscripRech.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbldatedinscripRech.Name = "lbldatedinscripRech";
            this.lbldatedinscripRech.Size = new System.Drawing.Size(117, 19);
            this.lbldatedinscripRech.TabIndex = 40;
            this.lbldatedinscripRech.Text = " Muscles ciblés :";
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::SisyphusWorriors.Properties.Resources.close_icone_sghira;
            this.button1.Location = new System.Drawing.Point(769, -1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(38, 31);
            this.button1.TabIndex = 90;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.materialLabel2.Location = new System.Drawing.Point(428, 382);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(93, 19);
            this.materialLabel2.TabIndex = 49;
            this.materialLabel2.Text = "Description  :";
            // 
            // lblDescription
            // 
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(421, 404);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(374, 134);
            this.lblDescription.TabIndex = 97;
            this.lblDescription.Text = "";
            // 
            // RechercherDesMaterial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(807, 571);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.btnVider);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtRechNomEquip);
            this.Controls.Add(this.btnRechercherPay);
            this.Controls.Add(this.DgvRech);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.materialCard6);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RechercherDesMaterial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RechercherDesMaterial";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvRech)).EndInit();
            this.materialCard6.ResumeLayout(false);
            this.materialCard6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaAdvenceButton btnVider;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialTextBox txtRechNomEquip;
        private Guna.UI.WinForms.GunaAdvenceButton btnRechercherPay;
        private System.Windows.Forms.DataGridView DgvRech;
        private MaterialSkin.Controls.MaterialLabel lblb7777;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private MaterialSkin.Controls.MaterialCard materialCard6;
        private MaterialSkin.Controls.MaterialLabel lblMat;
        private MaterialSkin.Controls.MaterialLabel lblblblb;
        private MaterialSkin.Controls.MaterialLabel lblNomMat;
        private MaterialSkin.Controls.MaterialLabel lblCat;
        private MaterialSkin.Controls.MaterialLabel lblPhoneNumRech;
        private MaterialSkin.Controls.MaterialLabel Etat;
        private MaterialSkin.Controls.MaterialLabel lblMusUse;
        private MaterialSkin.Controls.MaterialLabel lblAgeRech;
        private MaterialSkin.Controls.MaterialLabel lbldatedinscripRech;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn CIN;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOM;
        private System.Windows.Forms.DataGridViewTextBoxColumn Abonmement;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mantant;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mois_paiement;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.RichTextBox lblDescription;
    }
}