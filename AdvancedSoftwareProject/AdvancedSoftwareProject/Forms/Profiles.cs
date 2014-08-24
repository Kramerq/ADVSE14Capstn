using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdvancedSoftwareProject.Forms
{
    public partial class Profiles : Form
    {
        public Profiles()
        {
            InitializeComponent();
        }

        private void cancelBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void selectBTN_Click(object sender, EventArgs e)
        {
            if(profilesLB.SelectedItem != null)
            {
                MessageBox.Show(profilesLB.SelectedItem.ToString());
                AdvancedSoftwareProject.Properties.Settings.Default.ActiveProfile = profilesLB.SelectedItem.ToString();
                AdvancedSoftwareProject.Properties.Settings.Default.Save();

                this.Close();
            }
            else
            {
                MessageBox.Show("You must choose a profile to continue.", "Can Not Proceed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
