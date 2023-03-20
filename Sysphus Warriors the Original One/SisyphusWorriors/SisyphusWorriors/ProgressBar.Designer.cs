namespace SisyphusWorriors
{
    partial class ProgressBar
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
            this.components = new System.ComponentModel.Container();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.ProgressBarPanel = new System.Windows.Forms.Panel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.MessageLable = new Guna.UI.WinForms.GunaLabel();
            this.ProgressBarTimer = new System.Windows.Forms.Timer(this.components);
            this.btnDemarerApp = new Guna.UI.WinForms.GunaButton();
            this.TopPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TopPanel
            // 
            this.TopPanel.Controls.Add(this.ProgressBarPanel);
            this.TopPanel.Location = new System.Drawing.Point(42, 78);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(515, 21);
            this.TopPanel.TabIndex = 0;
            this.TopPanel.UseWaitCursor = true;
            this.TopPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.TopPanel_Paint);
            // 
            // ProgressBarPanel
            // 
            this.ProgressBarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ProgressBarPanel.Location = new System.Drawing.Point(0, 0);
            this.ProgressBarPanel.Name = "ProgressBarPanel";
            this.ProgressBarPanel.Size = new System.Drawing.Size(11, 21);
            this.ProgressBarPanel.TabIndex = 0;
            this.ProgressBarPanel.UseWaitCursor = true;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.Red;
            this.gunaLabel1.Location = new System.Drawing.Point(187, 19);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(252, 30);
            this.gunaLabel1.TabIndex = 19;
            this.gunaLabel1.Text = "Sisyphus Gym Application";
            this.gunaLabel1.UseWaitCursor = true;
            // 
            // MessageLable
            // 
            this.MessageLable.AutoSize = true;
            this.MessageLable.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MessageLable.ForeColor = System.Drawing.Color.Red;
            this.MessageLable.Location = new System.Drawing.Point(229, 116);
            this.MessageLable.Name = "MessageLable";
            this.MessageLable.Size = new System.Drawing.Size(141, 17);
            this.MessageLable.TabIndex = 20;
            this.MessageLable.Text = "Le progrès est terminé";
            this.MessageLable.UseWaitCursor = true;
            this.MessageLable.Visible = false;
            this.MessageLable.Click += new System.EventHandler(this.MessageLable_Click);
            // 
            // ProgressBarTimer
            // 
            this.ProgressBarTimer.Interval = 1;
            this.ProgressBarTimer.Tick += new System.EventHandler(this.ProgressBarTimer_Tick);
            // 
            // btnDemarerApp
            // 
            this.btnDemarerApp.AnimationHoverSpeed = 0.07F;
            this.btnDemarerApp.AnimationSpeed = 0.03F;
            this.btnDemarerApp.BackColor = System.Drawing.Color.Transparent;
            this.btnDemarerApp.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btnDemarerApp.BorderColor = System.Drawing.Color.Black;
            this.btnDemarerApp.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnDemarerApp.FocusedColor = System.Drawing.Color.Empty;
            this.btnDemarerApp.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDemarerApp.ForeColor = System.Drawing.Color.White;
            this.btnDemarerApp.Image = null;
            this.btnDemarerApp.ImageSize = new System.Drawing.Size(20, 20);
            this.btnDemarerApp.Location = new System.Drawing.Point(192, 145);
            this.btnDemarerApp.Name = "btnDemarerApp";
            this.btnDemarerApp.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btnDemarerApp.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnDemarerApp.OnHoverForeColor = System.Drawing.Color.White;
            this.btnDemarerApp.OnHoverImage = null;
            this.btnDemarerApp.OnPressedColor = System.Drawing.Color.Black;
            this.btnDemarerApp.Radius = 10;
            this.btnDemarerApp.Size = new System.Drawing.Size(223, 30);
            this.btnDemarerApp.TabIndex = 21;
            this.btnDemarerApp.Text = "Démarer l\'application";
            this.btnDemarerApp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnDemarerApp.UseTransfarantBackground = true;
            this.btnDemarerApp.UseWaitCursor = true;
            this.btnDemarerApp.Visible = false;
            this.btnDemarerApp.Click += new System.EventHandler(this.BtnDemarerApp_Click);
            // 
            // ProgressBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(603, 198);
            this.Controls.Add(this.btnDemarerApp);
            this.Controls.Add(this.MessageLable);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.TopPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProgressBar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProccesBar";
            this.UseWaitCursor = true;
            this.Load += new System.EventHandler(this.ProccesBar_Load);
            this.TopPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Panel ProgressBarPanel;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLabel MessageLable;
        private System.Windows.Forms.Timer ProgressBarTimer;
        private Guna.UI.WinForms.GunaButton btnDemarerApp;
    }
}