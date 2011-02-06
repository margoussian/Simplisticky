using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using Sharpnote;

namespace Simplisticky {
    public partial class StickyNote : Form {

        private ApplicationController app;
        private String key, created, modified;
        private int show, font, color;
        private int newX, newY, newCount = 1;
        
        private const int CS_DROPSHADOW = 0x20000;
        DateTime current;

        #region constructors

        public StickyNote(String _key, String _created, String _modified, String _text,
                          int _show, int _width, int _height, int _font, int _color,
                          Point _p, ApplicationController _app) {
            InitializeComponent();
            this.SetStyle(ControlStyles.ResizeRedraw, true);

            app = _app;
            key = _key;
            this.NoteTextBox.Text = _text;
            created = _created;
            modified = _modified;
            this.Width = _width;
            this.Height = _height;
            this.Location = _p;

//            setFont();
//            setColor();
        }

        public StickyNote(ApplicationController _app) {

            InitializeComponent();
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            app = _app;
        }

        #endregion

        #region ButtonEvents

        private void AddNoteButton_Click(object sender, MouseEventArgs e) {
            StickyNote newNote = new StickyNote(app);
            newX = this.Location.X + this.Width + (newCount * 20);
            newY = this.Location.Y + ((newCount-1) * 20);
            newCount++;
            newNote.Location = new Point(newX, newY);
            app.Notelist.Add(newNote);
            System.Console.WriteLine(app.Notelist.Count);
            newNote.Show();
        }

        #endregion

        

        #region Accessors

        // Accessors

        public String Key {
            get {
                return key;
            }
            set {
                key = value;
            }
        }

        public String Content {
            get {
                return NoteTextBox.Text;
            }
            set {
                NoteTextBox.Text = value;
            }
        }

        public int NoteShow {
            get {
                return show;
            }
            set {
                show = value;
            }
        }

        public String NoteCreated {
            get {
                return created;
            }
            set {
                created = value;
            }
        }

        public String Modified {
            get {
                return modified;
            }
            set {
                modified = value;
            }
        }

        public int NoteFont {
            get {
                return font;
            }
            set {
                font = value;
            }
        }

        public int NoteColor {
            get {
                return color;
            }
            set {
                color = value;
            }
        }

        #endregion

        // Need to clean up everything below this comment line

        Point lastClick;

        private void stickyNote_Load(object sender, EventArgs e) {

        }

        private void closeButton_Click(object sender, EventArgs e) {
            ConfirmDeleteDialog confirmDelete = new ConfirmDeleteDialog(this);
            confirmDelete.Show();
        }

        private void CloseButton_MouseHover(object sender, EventArgs e) {
            CloseButton.ForeColor = Color.Black;
        }

        private void CloseButton_MouseLeave(object sender, EventArgs e) {
            CloseButton.ForeColor = Color.DimGray;
        }

        private void NoteTextBox_TextChanged(object sender, EventArgs e) {
            current = DateTime.Now;
            this.lastUpdatedField.Text = current.ToString();
        }


        private void toolbar_mouseDown(object sender, MouseEventArgs e) {
            frmDrag_MouseDown(sender, e);
        }

        private void toolbar_MouseMove(object sender, MouseEventArgs e) {
            frmDrag_MouseMove(sender, e);
        }

        private void frmDrag_MouseDown(object sender, MouseEventArgs e) {
            lastClick = new Point(e.X, e.Y); //We'll need this for when the Form starts to move
        }



        private void AddNoteButton_MouseLeave(object sender, EventArgs e) {
            AddNoteButton.ForeColor = Color.DimGray;
        }

        private void AddNoteButton_MouseHover(object sender, EventArgs e) {
            AddNoteButton.ForeColor = Color.Black;
        }

        private void frmDrag_MouseMove(object sender, MouseEventArgs e) {
            //Point newLocation = new Point(e.X - lastE.X, e.Y - lastE.Y);
            if (e.Button == MouseButtons.Left) //Only when mouse is clicked
            {
                //Move the Form the same difference the mouse cursor moved;
                this.Left += e.X - lastClick.X;
                this.Top += e.Y - lastClick.Y;
            }
        }

        protected override void WndProc(ref Message m) {
            const int wmNcHitTest = 0x84;
            const int htBottomLeft = 16;
            const int htBottomRight = 17;
            if (m.Msg == wmNcHitTest) {
                int x = (int)(m.LParam.ToInt64() & 0xFFFF);
                int y = (int)((m.LParam.ToInt64() & 0xFFFF0000) >> 16);
                Point pt = PointToClient(new Point(x, y));
                Size clientSize = ClientSize;
                if (pt.X >= clientSize.Width - 16 && pt.Y >= clientSize.Height - 16 && clientSize.Height >= 16) {
                    m.Result = (IntPtr)(IsMirrored ? htBottomLeft : htBottomRight);
                    return;
                }
            }
            base.WndProc(ref m);
        }

        
        protected override CreateParams CreateParams {
            get {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        }

        private void ToolBarPanel_Paint(object sender, PaintEventArgs e) {

        }

        private void lastUpdatedField_Click(object sender, EventArgs e) {

        }

        private void pastToolStripMenuItem_Click(object sender, EventArgs e) {

        }

        private void colorClicked(object sender, EventArgs e) {
            if (sender.Equals(whiteColor)) {
                this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
                this.ToolBarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
                this.NoteTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
                NoteTextBox.Invalidate();
            }

            if (sender.Equals(pinkColor)) {
                this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(175)))), ((int)(((byte)(235)))));
                this.ToolBarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(192)))), ((int)(((byte)(241)))));
                this.NoteTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(175)))), ((int)(((byte)(235)))));
                NoteTextBox.Invalidate();
            }

            if (sender.Equals(greenColor)) {
                this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(233)))), ((int)(((byte)(175)))));
                this.ToolBarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(247)))), ((int)(((byte)(193)))));
                this.NoteTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(254)))), ((int)(((byte)(203)))));
                NoteTextBox.Invalidate();
            }
        }

        private void noTimesNewRomandFaggotToolStripMenuItem_Click(object sender, EventArgs e) {

        }

        private void arialToolStripMenuItem_Click(object sender, EventArgs e) {
            this.NoteTextBox.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        }

        private void calibriToolStripMenuItem_Click(object sender, EventArgs e) {
            this.NoteTextBox.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        }

        private void sergoUIToolStripMenuItem_Click(object sender, EventArgs e) {
            this.NoteTextBox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        }

        private void segioScriptToolStripMenuItem_Click(object sender, EventArgs e) {
            this.NoteTextBox.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        }

    }
}
