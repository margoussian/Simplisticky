using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Simplisticky {
    public partial class ConfirmDeleteDialog : Form {
        StickyNote note;
        ApplicationController app;

        public ConfirmDeleteDialog(StickyNote _note, ApplicationController _app) {
            InitializeComponent();
            note = _note;
            app = _app;
        }

        private void ConfirmDeleteDialog_Load(object sender, EventArgs e) {

        }

        private void label2_Click(object sender, EventArgs e) {

        }

        private void cancelDeleteButton_Click(object sender, EventArgs e) {
            this.Hide();
        }

        private void ConfirmDeleteButton_Click(object sender, EventArgs e) {
            // simplenote api call to delete remote copy

            app.Notelist.Remove(note);
            if (note.Creator != null) {
                note.Creator.NewCount--;
            }
            note.Hide();
            this.Hide();

            /*note.noteCollection.Remove(note);
            if (note.noteCollection.Count == 0) {
                Application.Exit();
            }
            else {
                
                note.Hide();
            }
            this.Hide(); */
        }

        
    }
}
