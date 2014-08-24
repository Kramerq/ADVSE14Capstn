using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdvancedSoftwareProject.Forms;
using Facebook;
using TweetSharp;
using AdvancedSoftwareProject.Classes;
using System.Web;
using System.Net.Mail;
using System.Net;
using OpenPop.Pop3;


namespace AdvancedSoftwareProject
{
    public partial class mainForm : Form
    {

        private const string AppId = "544348638997389";
        private const string ExtendedPermissions = "user_about_me,read_stream,publish_actions";
        private string _accessToken;
        string consumerKey = AdvancedSoftwareProject.Properties.Settings.Default.ConsumerKey;//api key
        string consumerSecret = AdvancedSoftwareProject.Properties.Settings.Default.ConsumerSecret;//api secret         
        TweetSharp.OAuthRequestToken requestToken;
        string pin;
        TweetSharp.OAuthAccessToken oAccessToken;


        public mainForm()
        {
            InitializeComponent();
        }

        private void aboutUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox AB = new AboutBox();
            AB.ShowDialog();
        }

        private void classToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ClassManager CM = new ClassManager();
            CM.ShowDialog();
        }

        private void studentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentManager SM = new StudentManager();
            SM.ShowDialog();
        }

        private void DisplayAppropriateMessage(FacebookOAuthResult facebookOAuthResult)
        {
            if (facebookOAuthResult != null)
            {
                if (facebookOAuthResult.IsSuccess)
                {
                    _accessToken = facebookOAuthResult.AccessToken;
                    var fb = new FacebookClient(facebookOAuthResult.AccessToken);

                    dynamic result = fb.Get("/me");
                    var name = result.name;

                    // for .net 3.5
                    //var result = (IDictionary<string, object>)fb.Get("/me");
                    //var name = (string)result["name"];

                    MessageBox.Show("Hi " + name);
                }
                else
                {
                    MessageBox.Show(facebookOAuthResult.ErrorDescription);
                }
                if (facebookOAuthResult == null)
                {
                    MessageBox.Show("Null");
                }
            }
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var fbLoginDialog = new FBLoginDialog(AppId, ExtendedPermissions);
            fbLoginDialog.ShowDialog();

            DisplayAppropriateMessage(fbLoginDialog.FacebookOAuthResult);
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var webBrowser = new WebBrowser();
            var fb = new FacebookClient();
            var logouUrl = fb.GetLogoutUrl(new { access_token = _accessToken, next = "https://www.facebook.com/connect/login_success.html" });
            webBrowser.Navigate(logouUrl);
        }

        private void twitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SettingsManager SM = new SettingsManager();
            SM.ShowDialog();
        }

        private void settingsToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ApplicationSettings AS = new ApplicationSettings();
            AS.ShowDialog();


            formSplitter.Panel1.Padding = new Padding(AdvancedSoftwareProject.Properties.Settings.Default.EmailLeftMargin, AdvancedSoftwareProject.Properties.Settings.Default.EmailTopMargin, AdvancedSoftwareProject.Properties.Settings.Default.EmailRightMargin, AdvancedSoftwareProject.Properties.Settings.Default.EmailBottomMargin);
            FB_Twitter_Splitter.Panel1.Padding = new Padding(AdvancedSoftwareProject.Properties.Settings.Default.FBLeftMargin, AdvancedSoftwareProject.Properties.Settings.Default.FBTopMargin, AdvancedSoftwareProject.Properties.Settings.Default.FBRightMargin, AdvancedSoftwareProject.Properties.Settings.Default.FBBottomMargin);
            FB_Twitter_Splitter.Panel2.Padding = new Padding(AdvancedSoftwareProject.Properties.Settings.Default.TwitterLeftMargin, AdvancedSoftwareProject.Properties.Settings.Default.TwitterTopMargin, AdvancedSoftwareProject.Properties.Settings.Default.TwitterRightMargin, AdvancedSoftwareProject.Properties.Settings.Default.TwitterBottomMargin);
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            formSplitter.Panel1.Padding = new Padding(AdvancedSoftwareProject.Properties.Settings.Default.EmailLeftMargin, AdvancedSoftwareProject.Properties.Settings.Default.EmailTopMargin, AdvancedSoftwareProject.Properties.Settings.Default.EmailRightMargin, AdvancedSoftwareProject.Properties.Settings.Default.EmailBottomMargin);
            FB_Twitter_Splitter.Panel1.Padding = new Padding(AdvancedSoftwareProject.Properties.Settings.Default.FBLeftMargin, AdvancedSoftwareProject.Properties.Settings.Default.FBTopMargin, AdvancedSoftwareProject.Properties.Settings.Default.FBRightMargin, AdvancedSoftwareProject.Properties.Settings.Default.FBBottomMargin);
            FB_Twitter_Splitter.Panel2.Padding = new Padding(AdvancedSoftwareProject.Properties.Settings.Default.TwitterLeftMargin, AdvancedSoftwareProject.Properties.Settings.Default.TwitterTopMargin, AdvancedSoftwareProject.Properties.Settings.Default.TwitterRightMargin, AdvancedSoftwareProject.Properties.Settings.Default.TwitterBottomMargin);

            profileLBL.Text = AdvancedSoftwareProject.Properties.Settings.Default.ActiveProfile;
        }

        private void twitterToolStripMenuItem_Click_1(object sender, EventArgs e)
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
            var options = new ListTweetsOnHomeTimelineOptions();
            var currentTweets = twitterService.ListTweetsOnHomeTimeline(options);
            List<TwitterStatus> tweets = currentTweets.ToList();
            //tweets[i].User.ScreenName
            
            //See https://github.com/danielcrenna/tweetsharp for more info on how to use tweets etc
          

            twitterFeed.DocumentText = "";
            string twitterHTML = "<div style = \"color:0099FF\">";

            for (int i = 0; i < tweets.Count; i++)
            {
                if (i != tweets.Count - 1)
                {
                    twitterHTML = twitterHTML + tweets[i].TextAsHtml + "<br><br>";
                }
                else
                {
                    twitterHTML = twitterHTML + tweets[i].TextAsHtml + "</div>";
                }
            }

            twitterFeed.DocumentText = twitterHTML;
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

        private void composeBTN_Click(object sender, EventArgs e)
        {
            ComposeMessage CM = new ComposeMessage();
            CM.ShowDialog();
        }

        private void twitterToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if(twitterToolStripMenuItem1.Checked)
                FB_Twitter_Splitter.Panel2Collapsed = false;
            else
                FB_Twitter_Splitter.Panel2Collapsed = true;
        }

        private void facebookToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (facebookToolStripMenuItem1.Checked)
                FB_Twitter_Splitter.Panel1Collapsed = false;
            else
                FB_Twitter_Splitter.Panel1Collapsed = true;
        }

        private void facebookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string FBID = AdvancedSoftwareProject.Properties.Settings.Default.FBGroupID;
            if (FBID != "")
            {
                string enter = "/" + FBID + "/feed";
                var fb = new FacebookClient(AdvancedSoftwareProject.Properties.Settings.Default.FBAccessToken);
                dynamic result = fb.Get(enter); //Error? Add code to check if the FBID is empty
                string fbHTML = "";

                foreach (dynamic post in result.data)
                {
                    var fromMessage = post.message;
                    var fromName = post.from.name;
                    var fromTime = post.created_time;
                    //Console.WriteLine(fromName);
                    fbHTML = fbHTML + "<br><br>" + fromName + "@" + fromTime + ": " + fromMessage;
                }
                FBFeed.DocumentText = fbHTML;
            }
            if (FBID == "")
            {
                MessageBox.Show("Enter a FB group ID in the settings");//Add code to reset FB group ID
            }
            //FBFeed.Navigate(new Uri("http://www.facebook.com/plugins/likebox.php?href=https%3A%2F%2Fwww.facebook.com%2FFacebookDevelopers&width&height=720&colorscheme=light&show_faces=false&header=true&stream=true&show_border=true&appId=544348638997389"));
        }

        private void refreshAllToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
         private void messageHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageHistory MH = new MessageHistory();
            MH.ShowDialog();
        }

        private void emailToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (emailToolStripMenuItem1.Checked)
            {
                emailBrowser.Visible = false;
                emailToolStripMenuItem1.Checked = false;
            }
            else
            {
                emailBrowser.Visible = true;
                emailToolStripMenuItem1.Checked = true;
            }
        }

        private void facebookToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            fbColorDialog.ShowDialog();
            AdvancedSoftwareProject.Properties.Settings.Default.FBFeedColor = fbColorDialog.Color;

            AdvancedSoftwareProject.Properties.Settings.Default.Save();
        }

        private void profileToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Profiles P = new Profiles();
            P.ShowDialog();

            profileLBL.Text = AdvancedSoftwareProject.Properties.Settings.Default.ActiveProfile;
        }

        private void marginsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Margins M = new Margins();
            M.ShowDialog();
        }

        private void settingsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ApplicationSettings AS = new ApplicationSettings();
            AS.ShowDialog();


            formSplitter.Panel1.Padding = new Padding(AdvancedSoftwareProject.Properties.Settings.Default.EmailLeftMargin, AdvancedSoftwareProject.Properties.Settings.Default.EmailTopMargin, AdvancedSoftwareProject.Properties.Settings.Default.EmailRightMargin, AdvancedSoftwareProject.Properties.Settings.Default.EmailBottomMargin);
            FB_Twitter_Splitter.Panel1.Padding = new Padding(AdvancedSoftwareProject.Properties.Settings.Default.FBLeftMargin, AdvancedSoftwareProject.Properties.Settings.Default.FBTopMargin, AdvancedSoftwareProject.Properties.Settings.Default.FBRightMargin, AdvancedSoftwareProject.Properties.Settings.Default.FBBottomMargin);
            FB_Twitter_Splitter.Panel2.Padding = new Padding(AdvancedSoftwareProject.Properties.Settings.Default.TwitterLeftMargin, AdvancedSoftwareProject.Properties.Settings.Default.TwitterTopMargin, AdvancedSoftwareProject.Properties.Settings.Default.TwitterRightMargin, AdvancedSoftwareProject.Properties.Settings.Default.TwitterBottomMargin);
        }
    }
}
