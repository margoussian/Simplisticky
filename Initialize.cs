﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Windows.Forms;
using System.Drawing;

/* This class performs required initilization of note data 
 * on application startup. It also reads and sets proper
 * configuration settings from the application config file.
 * */

namespace Simplisticky {
    class Initialize {

        private ApplicationController app;
        private XmlController xml;

        public Initialize(ApplicationController _app) {
            app = _app;
            xml = app.Xml;
        }

        public void begin() {

            if (Properties.Settings.Default.firstrun == true) {
                // If this is the first time ever the application is being launched.
                Properties.Settings.Default.firstrun = false;
                Properties.Settings.Default.Save();
                app.Main = new MainWindow(2,true,app);

                if (app.Notelist.Count == 0) {  // Nothing stored in XML File
                    StickyNote note = new StickyNote(app, null);
                    app.Notelist.Add(note);
                    app.Xml.addRecord(note);
                    note.Location = new Point(50, 50);
                    note.Show();
                }
            }
            else {
                // Read locally stored XML file and fill notelist Array
                app.Main = new MainWindow(0, Properties.Settings.Default.showmain, app);
                loadLocalContent();
                if (app.Notelist.Count == 0) {  // Nothing stored in XML File
                    StickyNote note = new StickyNote(app, null);
                    app.Notelist.Add(note);
                    app.Xml.addRecord(note);
                    note.Location = new Point(190, 210);
                    note.Show();
                }

            }
        }

        private void loadLocalContent() {
            xml.Read(app.Notelist);
        }

    }
}
