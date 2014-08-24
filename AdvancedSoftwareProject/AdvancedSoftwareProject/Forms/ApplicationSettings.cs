using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TweetSharp;

namespace AdvancedSoftwareProject.Forms
{
    public partial class ApplicationSettings : Form
    {
        public ApplicationSettings()
        {
            InitializeComponent();
        }

        private void cancelBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void okBTN_Click(object sender, EventArgs e)
        {
            saveBTN_Click(sender, e);

            this.Close();
        }

        private void ApplicationSettings_Load(object sender, EventArgs e)
        {
            if (AdvancedSoftwareProject.Properties.Settings.Default.AccessToken == "" || AdvancedSoftwareProject.Properties.Settings.Default.AccessTokenSecret == "")
            {
                twitterAuthoLabel.Text = "Not Authorized";
                twitterAuthoLabel.ForeColor = Color.Red;
                twitterAuthBTN.Text = "Authorize";
            }
            else
            {
                twitterAuthoLabel.Text = "Authorized";
                twitterAuthoLabel.ForeColor = Color.Green;
                twitterAuthBTN.Text = "Deauthorize";
            }

            if (AdvancedSoftwareProject.Properties.Settings.Default.FBAccessToken == "")
            {
                FBStatusLBL.Text = "Not Authorized";
                FBStatusLBL.ForeColor = Color.Red;
                FBAuthBTN.Text = "Authorize";
            }
            else
            {
                FBStatusLBL.Text = "Authorized";
                FBStatusLBL.ForeColor = Color.Green;
                FBAuthBTN.Text = "Deauthorize";
            }


            twitterCB.Checked = AdvancedSoftwareProject.Properties.Settings.Default.ToTwitter;
            fbCB.Checked = AdvancedSoftwareProject.Properties.Settings.Default.ToFacebook;
            emailCB.Checked = AdvancedSoftwareProject.Properties.Settings.Default.ToEmail;

            serverTB.Text = AdvancedSoftwareProject.Properties.Settings.Default.smtpClient;
            portTB.Text = AdvancedSoftwareProject.Properties.Settings.Default.smtpPort;
            userTB.Text = AdvancedSoftwareProject.Properties.Settings.Default.UserEmail;
            passTB.Text = AdvancedSoftwareProject.Properties.Settings.Default.UserEmailPW;

            profileLBL.Text = AdvancedSoftwareProject.Properties.Settings.Default.ActiveProfile;

            if (AdvancedSoftwareProject.Properties.Settings.Default.ActiveEmail == "Office 365")
                officeRB.Checked = true;
            else if (AdvancedSoftwareProject.Properties.Settings.Default.ActiveEmail == "Gmail")
                gmailRB.Checked = true;
            else
                yahooRB.Checked = true;
        }

        private void twitterAuthBTN_Click(object sender, EventArgs e)
        {
            if(twitterAuthBTN.Text == "Authorize")
            {
                //Authorize Twitter
            }
            else
            {
                AdvancedSoftwareProject.Properties.Settings.Default.AccessToken = "";
                AdvancedSoftwareProject.Properties.Settings.Default.AccessTokenSecret = "";
                AdvancedSoftwareProject.Properties.Settings.Default.Save();

                twitterAuthoLabel.Text = "Not Authorized";
                twitterAuthoLabel.ForeColor = Color.Red;
                twitterAuthBTN.Text = "Authorize";

            }
        }

        private void FBAuthBTN_Click(object sender, EventArgs e)
        {
            if(FBAuthBTN.Text == "Authorize")
            {
                //Authorize Facebook
            }
            else
            {
                AdvancedSoftwareProject.Properties.Settings.Default.FBAccessToken = "";
                AdvancedSoftwareProject.Properties.Settings.Default.Save();

                FBAuthBTN.Text = "Authorize";
                FBStatusLBL.Text = "Not Authorized";
                FBStatusLBL.ForeColor = Color.Red;
            }
        }

        private void groupIDReset_Click(object sender, EventArgs e)
        {
            AdvancedSoftwareProject.Properties.Settings.Default.FBGroupID = "";
            AdvancedSoftwareProject.Properties.Settings.Default.Save();
        }

        private void saveBTN_Click(object sender, EventArgs e)
        {
            AdvancedSoftwareProject.Properties.Settings.Default.ToTwitter = twitterCB.Checked;
            AdvancedSoftwareProject.Properties.Settings.Default.ToFacebook = fbCB.Checked;
            AdvancedSoftwareProject.Properties.Settings.Default.ToEmail = emailCB.Checked;

            AdvancedSoftwareProject.Properties.Settings.Default.smtpClient = serverTB.Text;
            AdvancedSoftwareProject.Properties.Settings.Default.smtpPort = portTB.Text;
            AdvancedSoftwareProject.Properties.Settings.Default.UserEmail = userTB.Text;
            AdvancedSoftwareProject.Properties.Settings.Default.UserEmailPW = passTB.Text;
            AdvancedSoftwareProject.Properties.Settings.Default.FBGroupID = FBgroupID.Text;

            AdvancedSoftwareProject.Properties.Settings.Default.ActiveTwitterCode = wCodeTB.Text;

            if (officeRB.Checked)
                AdvancedSoftwareProject.Properties.Settings.Default.ActiveEmail = "Office 365";
            else if (gmailRB.Checked)
                AdvancedSoftwareProject.Properties.Settings.Default.ActiveEmail = "Gmail";
            else
                AdvancedSoftwareProject.Properties.Settings.Default.ActiveEmail = "Yahoo";


            AdvancedSoftwareProject.Properties.Settings.Default.Save();
        }

        private void changeBTN_Click(object sender, EventArgs e)
        {
            Profiles P = new Profiles();
            P.ShowDialog();

            profileLBL.Text = AdvancedSoftwareProject.Properties.Settings.Default.ActiveProfile;
        }
    }
}
