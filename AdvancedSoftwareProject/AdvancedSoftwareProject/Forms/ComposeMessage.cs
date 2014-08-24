﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TweetSharp;

using System.Windows.Forms;
using System.Configuration;
using System.Text.RegularExpressions;
using Facebook;
using System.Web;
using System.Net.Mail;
using System.Net;


namespace AdvancedSoftwareProject.Forms
{
    public partial class ComposeMessage : Form
    {

        private const string AppId = "544348638997389";//FB
        private const string ExtendedPermissions = "user_about_me,read_stream,publish_stream,user_groups";//FB
        private string _accessToken;//FB
        string consumerKey = AdvancedSoftwareProject.Properties.Settings.Default.ConsumerKey;//api key
        string consumerSecret = AdvancedSoftwareProject.Properties.Settings.Default.ConsumerSecret;//api secret      
        TwitterClientInfo twitterClientInfo = new TwitterClientInfo();
        TweetSharp.OAuthRequestToken requestToken;
        string pin;
        TweetSharp.OAuthAccessToken oAccessToken;
        List<Class> classList = new List<Class>();
        Class selectedClass;


        // Is this the constructor in C#?
        public ComposeMessage()
        {
            InitializeComponent();
        }
        private void sendButton_Click(object sender, EventArgs e)
        {
            if (twitterCB.Checked || fbCB.Checked || emailCB.Checked)
            {
                if (twitterCB.Checked)
                {
                    TwitterClientInfo twitterClientInfo = new TwitterClientInfo();
                    twitterClientInfo.ConsumerKey = consumerKey; //Read ConsumerKey out of the app.config
                    twitterClientInfo.ConsumerSecret = consumerSecret; //Read the ConsumerSecret out the app.config
                    TwitterService twitterService = new TwitterService(consumerKey, consumerSecret);
                    requestToken = twitterService.GetRequestToken();

                    if (AdvancedSoftwareProject.Properties.Settings.Default.AccessToken != "" && AdvancedSoftwareProject.Properties.Settings.Default.AccessTokenSecret != "")
                    {
                        try
                        {
                            twitterService.AuthenticateWith(AdvancedSoftwareProject.Properties.Settings.Default.AccessToken, AdvancedSoftwareProject.Properties.Settings.Default.AccessTokenSecret);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                            authTwitter(twitterService);
                        }
                    }
                    else
                    {
                        authTwitter(twitterService);
                    }
                    var response = twitterService.SendTweet(new SendTweetOptions() { Status = messageTB.Text });
                }
                //EMAIL
                if (emailCB.Checked)
                {
                    if (subjectTB.Text != "" || fromTB.Text != "" || classDropDown.SelectedItem != null)
                    {
                        try
                        {
                            if (AdvancedSoftwareProject.Properties.Settings.Default.smtpClient.Length > 0 && AdvancedSoftwareProject.Properties.Settings.Default.UserEmail.Length > 0 && AdvancedSoftwareProject.Properties.Settings.Default.UserEmailPW.Length > 0) //checking non-empty
                            {
                                SmtpClient client = new SmtpClient(AdvancedSoftwareProject.Properties.Settings.Default.smtpClient);//"smtp.office365.com"
                                client.Port = Int32.Parse(AdvancedSoftwareProject.Properties.Settings.Default.smtpPort);//587
                                client.EnableSsl = true; //enable secure socket layer
                                client.Timeout = 100000;
                                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                                client.UseDefaultCredentials = false;

                                //ALL NEEDED ARE IN SETTINGS.SETTINGS

                                client.Credentials = new NetworkCredential(AdvancedSoftwareProject.Properties.Settings.Default.UserEmail, AdvancedSoftwareProject.Properties.Settings.Default.UserEmailPW);
                                MailMessage msg = new MailMessage();
                                //To needs to be modified to handle entire class lists
                                List<Dictionary<string, string>> studentData = DataBaseManager.getStudentsByClassID(selectedClass.getClassID());
                                foreach (var dictionary in studentData)
                                {
                                    string email = dictionary["email"];
                                    msg.To.Add(email);
                                }
                                msg.From = new MailAddress(this.fromTB.Text);
                                msg.Subject = this.subjectTB.Text;
                                msg.Body = this.messageTB.Text; ;
                                /*Attachment data = new Attachment(textBox_Attachment.Text);
                                msg.Attachments.Add(data);*/
                                client.Send(msg);
                                MessageBox.Show("Successfully Sent Message.");
                            }
                            else
                            {
                                MessageBox.Show("Your email settings have yet to be set up in this application, please navigate to application settings Edit->Settings and enter the correct information");
                            }

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("An error occured while sending the email, check your email username & password and smtpclient & port \n\n" + ex.Message);
                        }
                    }
                    else
                    {
                        MessageBox.Show("One or more requirements to send an e-mail is missing...\nPlease ensure that the From box, Subject box, and Class box are not empty.", "Can Not Proceed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }


                //FB
                if (fbCB.Checked == true)
                {
                    if (AdvancedSoftwareProject.Properties.Settings.Default.FBAccessToken == "")
                    {
                        var fbLoginDialog = new FBLoginDialog(AppId, ExtendedPermissions);//old
                        fbLoginDialog.ShowDialog();//old


                        DisplayAppropriateMessage(fbLoginDialog.FacebookOAuthResult);//old

                        AdvancedSoftwareProject.Properties.Settings.Default.FBAccessToken = _accessToken;
                        AdvancedSoftwareProject.Properties.Settings.Default.Save();

                        if (AdvancedSoftwareProject.Properties.Settings.Default.FBAccessToken != null)
                        {
                            string FBID = AdvancedSoftwareProject.Properties.Settings.Default.FBGroupID;
                            string enter = "/" + FBID + "/feed";
                            var client = new FacebookClient(AdvancedSoftwareProject.Properties.Settings.Default.FBAccessToken);//old     //Line 105 for error
                            //client.Post("/me/feed", new { message = messageTB.Text });//old
                            client.Post(enter, new { message = messageTB.Text }); //Error?, Errors, i need to login and add group id each time i launch app, figure out why;;; Fixed?
                        }

                    }
                    else
                    {
                        if (AdvancedSoftwareProject.Properties.Settings.Default.FBAccessToken != null)
                        {
                            string FBID = AdvancedSoftwareProject.Properties.Settings.Default.FBGroupID;
                            string enter = "/" + FBID + "/feed";
                            var client = new FacebookClient(AdvancedSoftwareProject.Properties.Settings.Default.FBAccessToken); //Line 114
                            //client.Post("/me/feed", new { message = messageTB.Text });
                            client.Post(enter, new { message = messageTB.Text });
                        }
                    }
                }
                //Pats DB code, commented out because I was getting errors
                //Save the message to the DB
                DataBaseManager.errorInfo eI = new DataBaseManager.errorInfo();
                if (!DataBaseManager.insertMessage(selectedClass.getClassID(), fbCB.Checked, twitterCB.Checked, emailCB.Checked, false, DateTime.Now, DateTime.Now.TimeOfDay, subjectTB.Text, messageTB.Text, out eI))
                {
                    MessageBox.Show(eI.returnedError.Message, eI.returnedError.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

                this.Close();
            }
            else
            {
                MessageBox.Show("Please select a destination.", "Can Not Proceed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        //Get app secret for FB
        public string AppSecret
        {
            get
            {
                return ConfigurationManager.AppSettings["ApplicationSecret"];
            }
        }
        //User Access Token for FB
        public string AccessToken { get; set; }



        private void messageTB_TextChanged(object sender, EventArgs e)
        {
            charsInputtedLabel.Text = messageTB.TextLength.ToString();

            if (messageTB.TextLength > 160)
            {
                if (twitterCB.Checked || twitterCB.Enabled)
                {
                    twitterCB.Checked = false;
                    twitterCB.Enabled = false;
                    twitterUnavailableLabel.Visible = true;
                }
            }
            else if (messageTB.TextLength <= 160)
            {
                if (!twitterCB.Enabled)
                {
                    twitterCB.Enabled = true;
                    twitterUnavailableLabel.Visible = false;
                }
            }
        }
        private void sendEmail()
        {
            //TODO WHY IS THERE TWITTER STUFF HERE??

            //authUrl is just a URL we can open IE and paste it in if we want
            // MessageBox.Show("authUri.ToString()" + authUri.ToString());
           /* if (oAccessToken == null)
            {
                string authUri = twitterService.GetAuthenticationUrl(requestToken).ToString();
                System.Diagnostics.Process.Start(authUri.ToString());

                SettingsManager SM = new SettingsManager();
                SM.ShowDialog();
                pin = SM.twitterPIN;
                oAccessToken = twitterService.GetAccessToken(requestToken, pin);
            }*/
           
       

        }
        //FB
        private void DisplayAppropriateMessage(FacebookOAuthResult facebookOAuthResult)
        {
            if (facebookOAuthResult != null)
            {
                if (facebookOAuthResult.IsSuccess)
                {
                    _accessToken = facebookOAuthResult.AccessToken;
                    var fb = new FacebookClient(facebookOAuthResult.AccessToken);//Access token to log in, can be saved in app

                    dynamic result = fb.Get("/me");
                    var name = result.name;

                    // for .net 3.5
                    //var result = (IDictionary<string, object>)fb.Get("/me");
                    //var name = (string)result["name"];

                    //MessageBox.Show("Hi " + name);
                }
                else
                {
                    MessageBox.Show(facebookOAuthResult.ErrorDescription);
                }
            }
        }



        private void ComposeMessage_Load(object sender, EventArgs e)
        {
            twitterCB.Checked = AdvancedSoftwareProject.Properties.Settings.Default.ToTwitter;
            fbCB.Checked = AdvancedSoftwareProject.Properties.Settings.Default.ToFacebook;
            emailCB.Checked = AdvancedSoftwareProject.Properties.Settings.Default.ToEmail;

            fromTB.Text = AdvancedSoftwareProject.Properties.Settings.Default.UserEmail;

            List<Dictionary<string, string>> classData = DataBaseManager.getClasses();
            foreach (var dictionary in classData)
            {
                string className = dictionary["className"];
                string classSection = dictionary["classSection"];
                string classID = dictionary["classID"];
                string fbGroupID = dictionary["facebookGroupId"];

                Class newClass = new Class(className, classSection, classID, fbGroupID);
                classList.Add(newClass);
                classDropDown.Items.Add(className + "-" + classSection);

            } 
        }
        private void authTwitter(TwitterService twitterService)
        {
            string authUri = twitterService.GetAuthenticationUrl(requestToken).ToString();
            System.Diagnostics.Process.Start(authUri.ToString());
            SettingsManager SM = new SettingsManager();
            SM.ShowDialog();
            pin = SM.twitterPIN;
            oAccessToken = twitterService.GetAccessToken(requestToken, pin);
            AdvancedSoftwareProject.Properties.Settings.Default.AccessToken = oAccessToken.Token;
            AdvancedSoftwareProject.Properties.Settings.Default.AccessTokenSecret = oAccessToken.TokenSecret;
            AdvancedSoftwareProject.Properties.Settings.Default.Save();
            twitterService.AuthenticateWith(AdvancedSoftwareProject.Properties.Settings.Default.AccessToken, AdvancedSoftwareProject.Properties.Settings.Default.AccessTokenSecret);
        }

        private void emailCB_CheckedChanged(object sender, EventArgs e)
        {
            if (AdvancedSoftwareProject.Properties.Settings.Default.Server == "" && emailCB.Checked || AdvancedSoftwareProject.Properties.Settings.Default.Port == "" && emailCB.Checked ||
                AdvancedSoftwareProject.Properties.Settings.Default.Username == "" && emailCB.Checked || AdvancedSoftwareProject.Properties.Settings.Default.Password == "" && emailCB.Checked)
            {
                MessageBox.Show("You don't have an active username/password.", "Unable to Proceed", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                emailCB.Checked = false;
            }
        }

        private void classDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = classDropDown.SelectedIndex;
            selectedClass = classList[index];
       
        }

        private void closeBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            messageTB.Clear();
        }
    }


}
