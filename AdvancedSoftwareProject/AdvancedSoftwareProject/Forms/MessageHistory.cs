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
    public partial class MessageHistory : Form
    {
        public MessageHistory()
        {
            InitializeComponent();
        }

        private void MessageHistory_Load(object sender, EventArgs e)
        {
            messageHistoryTreeView.Nodes.Clear();

            List<Dictionary<string, string>> messageData = DataBaseManager.getMessages();

            

            foreach (var message in messageData)
            {
                TreeNode content = new TreeNode(message["content"]);
                TreeNode subject = new TreeNode(message["subject"]);
                TreeNode[] array = new TreeNode[] { subject, content };

                string messageNodeString = message["date"] + " " + message["time"] + " Class: ";
                Class theClass = DataBaseManager.getClassByID(message["classID"]);
                string className = theClass.getClassName();
                string classSection = theClass.getClassSection();

                messageNodeString += className + "-" + classSection + " ";
                messageNodeString += "Sent to: ";
                
                if (message["facebook"].Equals("1"))
                {
                    messageNodeString += "Facebook ";
                }
                if (message["twitter"].Equals("1"))
                {
                    messageNodeString += "Twitter ";
                }
                if (message["email"].Equals("1"))
                {
                    messageNodeString += "Email ";
                }
                if (message["d2l"].Equals("1"))
                {
                    messageNodeString += "D2l ";
                }

                TreeNode messageNode = new TreeNode(messageNodeString, array);

                messageHistoryTreeView.Nodes.Add(messageNode);
            }
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to clear the message history? This action cannot be undone", "Warning", 
            MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            == DialogResult.Yes)
            {
                DataBaseManager.clearMessages();
                MessageHistory_Load(this, null);
            }

            
        }
    }
}
