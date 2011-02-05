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

        public ConfirmDeleteDialog(StickyNote _note) {
            InitializeComponent();
            note = _note;
        }

        private void ConfirmDeleteDialog_Load(object sender, EventArgs e) {

        }

        private void label2_Click(object sender, EventArgs e) {

        }

        private void cancelDeleteButton_Click(object sender, EventArgs e) {
            this.Hide();
        }

        private void ConfirmDeleteButton_Click(object sender, EventArgs e) {
            Application.Exit();
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
