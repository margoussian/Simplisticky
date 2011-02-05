using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Security;
using System.Configuration;
using Sharpnote;

namespace Simplisticky {
    public partial class MainWindow : Form {
        
        private Initialize init;
        private SecureCredential cred;
        private SecureString secureEmail, securePassword;
        private String encryptedEmail, encryptedPassword;

        public MainWindow(int tab, bool show) {
            InitializeComponent();
            if (!show)
                this.Hide();
            else {
                this.MainWindowTabControl.SelectedTab = this.MainWindowTabControl.TabPages[tab];
                this.Show();
            }
/*            init = new Initialize(this.MainWindowTabControl, this.emailField, this.passwordField);
            cred = new SecureCredential(); */
        }

        private void syncButton_Click(object sender, EventArgs e) {
            if (emailField.Text == "" || passwordField.Text == "") {
                syncStatusMessage.ForeColor = Color.Red;
                syncStatusMessage.Text = "Invalid email or password";
                syncStatusMessage.Show();
            }
            else {
                try {
                    Sharpnote.Sharpnote.Instance.Login(emailField.Text, passwordField.Text);
                    var notes = Sharpnote.Sharpnote.Instance.SearchNotes<Note>();
                    //XML_store storedNotes = new XML_store();

                    syncStatusMessage.ForeColor = Color.LimeGreen;
                    syncStatusMessage.Text = "Sync Successful";
                    syncStatusMessage.Show();

                    secureEmail = cred.ToSecureString(emailField.Text);
                    securePassword = cred.ToSecureString(passwordField.Text);
                    encryptedEmail = cred.EncryptString(secureEmail);
                    encryptedPassword = cred.EncryptString(securePassword);

                    Properties.Settings.Default.email = encryptedEmail;
                    Properties.Settings.Default.password = encryptedPassword;
                    Properties.Settings.Default.firstrun = false;
                    Properties.Settings.Default.Save();

                    List<Note> notelist = notes.Item1.ToList();
                    
                    listBox1.DataSource = notelist;
                    listBox1.DisplayMember = "Content";
                    Hashtable myHT = new Hashtable();
                    
                    foreach (Note n in notelist) {
                        myHT.Add(n.Key, n);
           //              StickyNote sticky = new StickyNote();
           //             storedNotes.xmlWrite(n, sticky);
           //             sticky.Content = n.Content;
           //             sticky.Show();
                    }
             //       storedNotes.xmlRead();
                } catch (Exception error) {
                    System.Console.WriteLine(error.Message);
                    // Find a more elegant solution to check for error type
                    if (error.Message == "The remote server returned an error: (400) Bad Request.") {
                        syncStatusMessage.ForeColor = Color.Red;
                        syncStatusMessage.Text = "Invalid email or password";
                    }
                    if (error.Message == "Unable to connect to the remote server" || error.Message == "The remote name could not be resolved: 'simple-note.appspot.com'") {
                        syncStatusMessage.ForeColor = Color.Red;
                        syncStatusMessage.Text = "Unable to connect.\nCheck your internet connection";
                    }
                    syncStatusMessage.Show();
                }

            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e) {

        }

        private void quitButton_Click(object sender, EventArgs e) {
            // Modify
            Application.Exit();
        }

        private void closeToTaskbar_Click(object sender, EventArgs e) {
            Properties.Settings.Default.showmain = false;
            Properties.Settings.Default.Save();
            this.Hide();
        }

        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e) {
            this.Show();
            Properties.Settings.Default.showmain = true;
            Properties.Settings.Default.Save();
        }

        private void sysTrayQuit_Click(object sender, EventArgs e) {
            // Modify
            Application.Exit();
        }

        private void sysTrayShowNotelist_Click(object sender, EventArgs e) {
            
            System.Console.WriteLine("notelist clicked");
            this.MainWindowTabControl.SelectedTab = this.MainWindowTabControl.TabPages[0];
            this.Show();
            Properties.Settings.Default.showmain = true;
            Properties.Settings.Default.Save();
            
        }

        protected override void OnFormClosing(FormClosingEventArgs e) {
            FormClosing(this,e);
        }

        private void FormClosing(object sender,FormClosingEventArgs e) {

            if (e.CloseReason == CloseReason.UserClosing && ((!sender.Equals(sysTrayQuit) && !sender.Equals(quitButton)) || sender.Equals(this))) {
                e.Cancel = true;
                this.Hide();
            }
            else
                Application.Exit();
        }

    }
}
