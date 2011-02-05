using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Windows.Forms;

/* This class performs required initilization of note data 
 * on application startup. It also reads and sets proper
 * configuration settings from the application config file.
 * */

namespace Simplisticky {
    class Initialize {

        private int first_run;
        private ApplicationController app;
        private XmlController xml;
        private SecureCredential cred;
        System.Windows.Forms.TabControl MainWindowTabControl;   // Pointer to main window tab controller

        public Initialize(ApplicationController _app) {
            app = _app;
            xml = app.Xml;
        }

        public void begin() {

            if (Properties.Settings.Default.firstrun == true) {
                // If this is the first time ever the application is being launched.
                
                loadLocalContent();
            }
            else {
                // Read locally stored XML file and fill notelist Array
                loadLocalContent();

            }
        }

        private void loadLocalContent() {
            xml.Read(app.Notelist);
        }
/*        public Initialize(TabControl _MainWindowTabControl, TextBox emailField, TextBox passwordField) {
            //first_run = Convert.ToInt32(ConfigurationManager.AppSettings["FirstRun"]);
            MainWindowTabControl = _MainWindowTabControl;
            cred = new SecureCredential();

            // Check config file to see if this is the first time the application is being launched.
            // If so, select Login tab for Simplenote Credentials.

            if (Properties.Settings.Default.firstrun == true) {
                MainWindowTabControl.SelectedTab = MainWindowTabControl.TabPages[2];
            }
            else {
                MainWindowTabControl.SelectedTab = MainWindowTabControl.TabPages[2]; // Change on ship
                emailField.Text = cred.ToInsecureString(cred.DecryptString(Properties.Settings.Default.email));
                passwordField.Text = cred.ToInsecureString(cred.DecryptString(Properties.Settings.Default.password));
                
            } 
        } */

    }
}
