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
    public partial class Margins : Form
    {
        public Margins()
        {
            InitializeComponent();
        }

        private void Margins_Load(object sender, EventArgs e)
        {
            twitterMarginCB.Checked = AdvancedSoftwareProject.Properties.Settings.Default.TwitterMarginUnifrom;
            FBMarginCB.Checked = AdvancedSoftwareProject.Properties.Settings.Default.FBMarginUniform;
            emailMarginCB.Checked = AdvancedSoftwareProject.Properties.Settings.Default.EmailMarginUniform;

            eTNUM.Value = AdvancedSoftwareProject.Properties.Settings.Default.EmailTopMargin;
            eLNUM.Value = AdvancedSoftwareProject.Properties.Settings.Default.EmailLeftMargin;
            eRNUM.Value = AdvancedSoftwareProject.Properties.Settings.Default.EmailRightMargin;
            eBNUM.Value = AdvancedSoftwareProject.Properties.Settings.Default.EmailBottomMargin;

            fTNUM.Value = AdvancedSoftwareProject.Properties.Settings.Default.FBTopMargin;
            fLNUM.Value = AdvancedSoftwareProject.Properties.Settings.Default.FBLeftMargin;
            fRNUM.Value = AdvancedSoftwareProject.Properties.Settings.Default.FBRightMargin;
            fBNUM.Value = AdvancedSoftwareProject.Properties.Settings.Default.FBBottomMargin;

            tTNUM.Value = AdvancedSoftwareProject.Properties.Settings.Default.TwitterTopMargin;
            tLNUM.Value = AdvancedSoftwareProject.Properties.Settings.Default.TwitterLeftMargin;
            tRNUM.Value = AdvancedSoftwareProject.Properties.Settings.Default.TwitterRightMargin;
            tBNUM.Value = AdvancedSoftwareProject.Properties.Settings.Default.TwitterBottomMargin;
        }

        private void emailMarginSame(int num)
        {
            eLNUM.Value = num;
            eRNUM.Value = num;
            eTNUM.Value = num;
            eBNUM.Value = num;
        }

        private void facebookMarginSame(int num)
        {
            fLNUM.Value = num;
            fRNUM.Value = num;
            fTNUM.Value = num;
            fBNUM.Value = num;
        }

        private void twitterMarginSame(int num)
        {
            tLNUM.Value = num;
            tRNUM.Value = num;
            tTNUM.Value = num;
            tBNUM.Value = num;
        }

        private void eLNUM_ValueChanged(object sender, EventArgs e)
        {
            if (emailMarginCB.Checked)
                emailMarginSame((int)eLNUM.Value);
        }

        private void eRNUM_ValueChanged(object sender, EventArgs e)
        {
            if (emailMarginCB.Checked)
                emailMarginSame((int)eRNUM.Value);
        }

        private void eTNUM_ValueChanged(object sender, EventArgs e)
        {
            if (emailMarginCB.Checked)
                emailMarginSame((int)eTNUM.Value);
        }

        private void eBNUM_ValueChanged(object sender, EventArgs e)
        {
            if (emailMarginCB.Checked)
                emailMarginSame((int)eBNUM.Value);
        }

        private void fLNUM_ValueChanged(object sender, EventArgs e)
        {
            if (FBMarginCB.Checked)
                facebookMarginSame((int)fLNUM.Value);
        }

        private void fRNUM_ValueChanged(object sender, EventArgs e)
        {
            if (FBMarginCB.Checked)
                facebookMarginSame((int)fRNUM.Value);
        }

        private void fTNUM_ValueChanged(object sender, EventArgs e)
        {
            if (FBMarginCB.Checked)
                facebookMarginSame((int)fTNUM.Value);
        }

        private void fBNUM_ValueChanged(object sender, EventArgs e)
        {
            if (FBMarginCB.Checked)
                facebookMarginSame((int)fBNUM.Value);
        }

        private void tLNUM_ValueChanged(object sender, EventArgs e)
        {
            if (twitterMarginCB.Checked)
                twitterMarginSame((int)tLNUM.Value);
        }

        private void tRNUM_ValueChanged(object sender, EventArgs e)
        {
            if (twitterMarginCB.Checked)
                twitterMarginSame((int)tRNUM.Value);
        }

        private void tTNUM_ValueChanged(object sender, EventArgs e)
        {
            if (twitterMarginCB.Checked)
                twitterMarginSame((int)tTNUM.Value);
        }

        private void tBNUM_ValueChanged(object sender, EventArgs e)
        {
            if (twitterMarginCB.Checked)
                twitterMarginSame((int)tBNUM.Value);
        }

        private void emailMarginCB_CheckedChanged(object sender, EventArgs e)
        {
            if (emailMarginCB.Checked)
                emailMarginSame((int)eLNUM.Value);
        }

        private void FBMarginCB_CheckedChanged(object sender, EventArgs e)
        {
            if (FBMarginCB.Checked)
                facebookMarginSame((int)fLNUM.Value);
        }

        private void twitterMarginCB_CheckedChanged(object sender, EventArgs e)
        {
            if (twitterMarginCB.Checked)
                twitterMarginSame((int)tLNUM.Value);
        }

        private void okBTN_Click(object sender, EventArgs e)
        {
            AdvancedSoftwareProject.Properties.Settings.Default.EmailMarginUniform = emailMarginCB.Checked;
            AdvancedSoftwareProject.Properties.Settings.Default.FBMarginUniform = FBMarginCB.Checked;
            AdvancedSoftwareProject.Properties.Settings.Default.TwitterMarginUnifrom = twitterMarginCB.Checked;


            AdvancedSoftwareProject.Properties.Settings.Default.TwitterBottomMargin = (int)tBNUM.Value;
            AdvancedSoftwareProject.Properties.Settings.Default.TwitterLeftMargin = (int)tLNUM.Value;
            AdvancedSoftwareProject.Properties.Settings.Default.TwitterRightMargin = (int)tRNUM.Value;
            AdvancedSoftwareProject.Properties.Settings.Default.TwitterTopMargin = (int)tTNUM.Value;

            AdvancedSoftwareProject.Properties.Settings.Default.FBBottomMargin = (int)fBNUM.Value;
            AdvancedSoftwareProject.Properties.Settings.Default.FBLeftMargin = (int)fLNUM.Value;
            AdvancedSoftwareProject.Properties.Settings.Default.FBRightMargin = (int)fRNUM.Value;
            AdvancedSoftwareProject.Properties.Settings.Default.FBTopMargin = (int)fTNUM.Value;

            AdvancedSoftwareProject.Properties.Settings.Default.EmailBottomMargin = (int)eBNUM.Value;
            AdvancedSoftwareProject.Properties.Settings.Default.EmailLeftMargin = (int)eLNUM.Value;
            AdvancedSoftwareProject.Properties.Settings.Default.EmailRightMargin = (int)eRNUM.Value;
            AdvancedSoftwareProject.Properties.Settings.Default.EmailTopMargin = (int)eTNUM.Value;

            AdvancedSoftwareProject.Properties.Settings.Default.Save();

            this.Close();
        }

        private void saveBTN_Click(object sender, EventArgs e)
        {
            AdvancedSoftwareProject.Properties.Settings.Default.EmailMarginUniform = emailMarginCB.Checked;
            AdvancedSoftwareProject.Properties.Settings.Default.FBMarginUniform = FBMarginCB.Checked;
            AdvancedSoftwareProject.Properties.Settings.Default.TwitterMarginUnifrom = twitterMarginCB.Checked;


            AdvancedSoftwareProject.Properties.Settings.Default.TwitterBottomMargin = (int)tBNUM.Value;
            AdvancedSoftwareProject.Properties.Settings.Default.TwitterLeftMargin = (int)tLNUM.Value;
            AdvancedSoftwareProject.Properties.Settings.Default.TwitterRightMargin = (int)tRNUM.Value;
            AdvancedSoftwareProject.Properties.Settings.Default.TwitterTopMargin = (int)tTNUM.Value;

            AdvancedSoftwareProject.Properties.Settings.Default.FBBottomMargin = (int)fBNUM.Value;
            AdvancedSoftwareProject.Properties.Settings.Default.FBLeftMargin = (int)fLNUM.Value;
            AdvancedSoftwareProject.Properties.Settings.Default.FBRightMargin = (int)fRNUM.Value;
            AdvancedSoftwareProject.Properties.Settings.Default.FBTopMargin = (int)fTNUM.Value;

            AdvancedSoftwareProject.Properties.Settings.Default.EmailBottomMargin = (int)eBNUM.Value;
            AdvancedSoftwareProject.Properties.Settings.Default.EmailLeftMargin = (int)eLNUM.Value;
            AdvancedSoftwareProject.Properties.Settings.Default.EmailRightMargin = (int)eRNUM.Value;
            AdvancedSoftwareProject.Properties.Settings.Default.EmailTopMargin = (int)eTNUM.Value;

            AdvancedSoftwareProject.Properties.Settings.Default.Save();
        }

        private void cancelBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
