using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LiamOS_Update_Calculator
{
    public partial class StartScreen : Form
    {
        public StartScreen()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ContinueBTN.Enabled = false;
        }

        private void ExitBTN_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
        private void Controlbuttons()
        {
            if (VersionName.Text.Trim() != string.Empty && VersionName.Text.All(Char.IsLetter))
            {
                ContinueBTN.Enabled = true;
                errorProvider1.SetError(VersionName, "");
            }
            else
            {
                if (!(VersionName.Text.All(Char.IsLetter)))
                {
                    errorProvider1.SetError(VersionName, "The Version Only Contains Letters.");
                }
                else
                {
                    errorProvider1.SetError(VersionName, "Put Any Version Name Example: LiamOS , LiamOSsHell");
                }
                ContinueBTN.Enabled = false;
                VersionName.Focus();
            }
        }
        private void VersionName_TextChanged(object sender, EventArgs e)
        {
            Controlbuttons();
        }
    }
}
