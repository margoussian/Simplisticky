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
using System.Threading;
using Sharpnote;

namespace Simplisticky {
    public partial class MainWindow : Form {

        private ApplicationController app;
        private SecureCredential cred;
        private SecureString secureEmail, securePassword;
        private String encryptedEmail, encryptedPassword;
        private Thread syncThread;
        delegate void SetTextCallback(bool result, Exception error);

        public MainWindow(int tab, bool show, ApplicationController _app) {
            InitializeComponent();
            app = _app;
            this.Location = Properties.Settings.Default.mainLocation;

            if (!show)
                this.Hide();
            else {
                this.MainWindowTabControl.SelectedTab = this.MainWindowTabControl.TabPages[tab];
                this.Show();
            }         
            cred = new SecureCredential();
        }

        #region buttonClickEvents

        private void syncButton_Click(object sender, EventArgs e) {
            if (emailField.Text == "" || passwordField.Text == "") {
                syncStatusMessage.ForeColor = Color.Red;
                syncStatusMessage.Text = "Invalid email or password";
                syncStatusMessage.Show();
            }
            else {
                syncThread = new Thread(new ThreadStart(this.ThreadProcSafe));
                syncThread.Name = "MainWindow Sync Thread";
                syncThread.Start();
            }
        }

        private void closeToTaskbar_Click(object sender, EventArgs e) {
            Properties.Settings.Default.showmain = false;
            Properties.Settings.Default.Save();
            this.Hide();
        }

        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e) {
            this.Show();
            this.Activate();
            foreach (StickyNote n in app.Notelist) {
                n.Activate();
            }
            Properties.Settings.Default.showmain = true;
            Properties.Settings.Default.Save();
        }

        private void sysTrayQuit_Click(object sender, EventArgs e) {
            app.Xml.Write(app.Notelist);
            notifyIcon.Visible = false;
            Application.Exit();
        }

        private void quitButton_Click(object sender, EventArgs e) {
            app.Xml.Write(app.Notelist);
            notifyIcon.Visible = false;
            Application.Exit();
        }

        #endregion

        // Simplenote API Call Methods

        private void ThreadProcSafe() {
            try {
                Sharpnote.Sharpnote.Instance.Login(emailField.Text, passwordField.Text);
                var simplenotes = Sharpnote.Sharpnote.Instance.SearchNotes<Note>();

                this.processLoginResults(true, null);
            }
            catch (Exception error) {
                this.processLoginResults(false, error);
            }
        }

        // This delegate processes the results from the sync thread on the main thread

        private void processLoginResults(bool result, Exception error) {
            if (this.syncStatusMessage.InvokeRequired) {
                SetTextCallback d = new SetTextCallback(processLoginResults);
                this.Invoke(d, new object[] { result,error });
            }
            else {
                if (result) {
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
                }
                else {
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


        // Clean up everything below this line



        private void sysTrayShowNotelist_Click(object sender, EventArgs e) {
            this.MainWindowTabControl.SelectedTab = this.MainWindowTabControl.TabPages[0];
            this.Show();
            Properties.Settings.Default.showmain = true;
            Properties.Settings.Default.Save();
        }

        private void MainWindowMoved(object sender, EventArgs e) {
            Properties.Settings.Default.mainLocation = this.Location;
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
            else {
                app.Xml.Write(app.Notelist);
                Application.Exit();
            }
        }

        private void newNoteButton_Click_1(object sender, EventArgs e) {
            StickyNote newNote;
            try {
                if (app.Notelist.Count > 0) {
                    newNote = app.Notelist[app.Notelist.Count - 1];
                    if (newNote != null) {
                        newNote.spawnNewNote();
                    }
                }
                else {
                    newNote = new StickyNote(app, null);
                    app.Notelist.Add(newNote);
                    newNote.Location = new Point(190, 210);
                    newNote.Show();
                }
            }
            catch (Exception errorCreatingNewNote) {
                System.Console.WriteLine(errorCreatingNewNote.Message);
            }

        }

    }
}
