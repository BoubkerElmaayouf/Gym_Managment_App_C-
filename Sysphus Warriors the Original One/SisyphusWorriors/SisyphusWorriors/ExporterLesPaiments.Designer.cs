namespace SisyphusWorriors
{
    partial class ExporterLesPaiments
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExporterLesPaiments));
            this.DgvExport = new System.Windows.Forms.DataGridView();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnExport = new Guna.UI.WinForms.GunaAdvenceButton();
            this.lblTotalPay = new MaterialSkin.Controls.MaterialLabel();
            this.lblMEMBERtOTAL = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.DgvExport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvExport
            // 
            this.DgvExport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvExport.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(236)))), ((int)(((byte)(194)))));
            this.DgvExport.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvExport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvExport.Location = new System.Drawing.Point(25, 142);
            this.DgvExport.Name = "DgvExport";
            this.DgvExport.Size = new System.Drawing.Size(755, 350);
            this.DgvExport.TabIndex = 66;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.BackColor = System.Drawing.Color.White;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(212)))), ((int)(((byte)(118)))));
            this.gunaLabel2.Location = new System.Drawing.Point(195, 62);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(530, 21);
            this.gunaLabel2.TabIndex = 68;
            this.gunaLabel2.Text = "Exporter tous les Paiments  dans l\'Excel  par Clicker sur la Button \'Exporter\' :";
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::SisyphusWorriors.Properties.Resources.close_icone_sghira;
            this.button1.Location = new System.Drawing.Point(769, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(38, 31);
            this.button1.TabIndex = 81;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SisyphusWorriors.Properties.Resources.Mesa_de_trabajo_1;
            this.pictureBox1.Location = new System.Drawing.Point(34, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(136, 124);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 67;
            this.pictureBox1.TabStop = false;
            // 
            // btnExport
            // 
            this.btnExport.AnimationHoverSpeed = 0.07F;
            this.btnExport.AnimationSpeed = 0.03F;
            this.btnExport.BackColor = System.Drawing.Color.Transparent;
            this.btnExport.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(212)))), ((int)(((byte)(118)))));
            this.btnExport.BorderColor = System.Drawing.Color.Black;
            this.btnExport.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnExport.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnExport.CheckedForeColor = System.Drawing.Color.White;
            this.btnExport.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnExport.CheckedImage")));
            this.btnExport.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnExport.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnExport.FocusedColor = System.Drawing.Color.Empty;
            this.btnExport.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.ForeColor = System.Drawing.Color.White;
            this.btnExport.Image = null;
            this.btnExport.ImageSize = new System.Drawing.Size(20, 20);
            this.btnExport.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(229)))), ((int)(((byte)(128)))));
            this.btnExport.Location = new System.Drawing.Point(290, 507);
            this.btnExport.Name = "btnExport";
            this.btnExport.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(219)))), ((int)(((byte)(74)))));
            this.btnExport.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnExport.OnHoverForeColor = System.Drawing.Color.White;
            this.btnExport.OnHoverImage = null;
            this.btnExport.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnExport.OnPressedColor = System.Drawing.Color.Black;
            this.btnExport.Radius = 15;
            this.btnExport.Size = new System.Drawing.Size(200, 43);
            this.btnExport.TabIndex = 65;
            this.btnExport.Text = "Exporter";
            this.btnExport.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnExport.Click += new System.EventHandler(this.BtnExport_Click);
            // 
            // lblTotalPay
            // 
            this.lblTotalPay.AutoSize = true;
            this.lblTotalPay.Depth = 0;
            this.lblTotalPay.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblTotalPay.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblTotalPay.Location = new System.Drawing.Point(669, 522);
            this.lblTotalPay.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTotalPay.Name = "lblTotalPay";
            this.lblTotalPay.Size = new System.Drawing.Size(13, 19);
            this.lblTotalPay.TabIndex = 83;
            this.lblTotalPay.Text = "...";
            // 
            // lblMEMBERtOTAL
            // 
            this.lblMEMBERtOTAL.AutoSize = true;
            this.lblMEMBERtOTAL.Depth = 0;
            this.lblMEMBERtOTAL.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblMEMBERtOTAL.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblMEMBERtOTAL.Location = new System.Drawing.Point(542, 522);
            this.lblMEMBERtOTAL.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblMEMBERtOTAL.Name = "lblMEMBERtOTAL";
            this.lblMEMBERtOTAL.Size = new System.Drawing.Size(109, 19);
            this.lblMEMBERtOTAL.TabIndex = 82;
            this.lblMEMBERtOTAL.Text = "Total Paiment :";
            // 
            // ExporterLesPaiments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(807, 571);
            this.Controls.Add(this.lblTotalPay);
            this.Controls.Add(this.lblMEMBERtOTAL);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.DgvExport);
            this.Controls.Add(this.btnExport);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ExporterLesPaiments";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ExporterLesPaiments";
            this.Load += new System.EventHandler(this.ExporterLesPaiments_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvExport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView DgvExport;
        private Guna.UI.WinForms.GunaAdvenceButton btnExport;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private System.Windows.Forms.Button button1;
        private MaterialSkin.Controls.MaterialLabel lblTotalPay;
        private MaterialSkin.Controls.MaterialLabel lblMEMBERtOTAL;
    }
}