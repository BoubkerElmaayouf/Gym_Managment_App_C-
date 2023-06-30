using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SisyphusWorriors
{
    public partial class ProgressBar : Form
    {
        public ProgressBar()
        {
            InitializeComponent();
        }

        private void ProgressBarTimer_Tick(object sender, EventArgs e)
        {
            if(ProgressBarPanel.Width != TopPanel.Width)
            {
                ProgressBarPanel.Width = ProgressBarPanel.Width + 4;
            }
            else
            {
                MessageLable.Visible = true;
                btnDemarerApp.Visible = true;
                UseWaitCursor = false;
            }
        }

        private void ProccesBar_Load(object sender, EventArgs e)
        {
            ProgressBarTimer.Start();
        }

        private void MessageLable_Click(object sender, EventArgs e)
        {

        }

        private void BtnDemarerApp_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login l = new Login();   
            l.ShowDialog();
            this.Close();
        }

        private void TopPanel_Paint(object sender, PaintEventArgs e)
        {

        }
        
    }
}
