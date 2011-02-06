namespace Simplisticky {
    partial class StickyNote {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textboxRightClickMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.seperatorToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.fontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calibriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sergoUIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.segioScriptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noTimesNewRomandFaggotToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blueColor = new System.Windows.Forms.ToolStripMenuItem();
            this.greenColor = new System.Windows.Forms.ToolStripMenuItem();
            this.pinkColor = new System.Windows.Forms.ToolStripMenuItem();
            this.purpleColor = new System.Windows.Forms.ToolStripMenuItem();
            this.whiteColor = new System.Windows.Forms.ToolStripMenuItem();
            this.yellowColor = new System.Windows.Forms.ToolStripMenuItem();
            this.CloseButton = new System.Windows.Forms.Label();
            this.ToolBarPanel = new System.Windows.Forms.Panel();
            this.lastUpdatedField = new System.Windows.Forms.Label();
            this.AddNoteButton = new System.Windows.Forms.Label();
            this.dragIconLabel = new System.Windows.Forms.Label();
            this.NoteTextBox = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1.SuspendLayout();
            this.ToolBarPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.textboxRightClickMenu,
            this.seperatorToolStripMenuItem,
            this.fontToolStripMenuItem,
            this.colorToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(104, 120);
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.cutToolStripMenuItem.Text = "Cut";
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            // 
            // textboxRightClickMenu
            // 
            this.textboxRightClickMenu.Name = "textboxRightClickMenu";
            this.textboxRightClickMenu.Size = new System.Drawing.Size(103, 22);
            this.textboxRightClickMenu.Text = "Paste";
            this.textboxRightClickMenu.Click += new System.EventHandler(this.pastToolStripMenuItem_Click);
            // 
            // seperatorToolStripMenuItem
            // 
            this.seperatorToolStripMenuItem.Name = "seperatorToolStripMenuItem";
            this.seperatorToolStripMenuItem.Size = new System.Drawing.Size(100, 6);
            // 
            // fontToolStripMenuItem
            // 
            this.fontToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arialToolStripMenuItem,
            this.calibriToolStripMenuItem,
            this.sergoUIToolStripMenuItem,
            this.segioScriptToolStripMenuItem,
            this.noTimesNewRomandFaggotToolStripMenuItem});
            this.fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            this.fontToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.fontToolStripMenuItem.Text = "Font";
            // 
            // arialToolStripMenuItem
            // 
            this.arialToolStripMenuItem.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arialToolStripMenuItem.Name = "arialToolStripMenuItem";
            this.arialToolStripMenuItem.Size = new System.Drawing.Size(236, 32);
            this.arialToolStripMenuItem.Text = "Arial";
            this.arialToolStripMenuItem.Click += new System.EventHandler(this.arialToolStripMenuItem_Click);
            // 
            // calibriToolStripMenuItem
            // 
            this.calibriToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calibriToolStripMenuItem.Name = "calibriToolStripMenuItem";
            this.calibriToolStripMenuItem.Size = new System.Drawing.Size(236, 32);
            this.calibriToolStripMenuItem.Text = "Calibri";
            this.calibriToolStripMenuItem.Click += new System.EventHandler(this.calibriToolStripMenuItem_Click);
            // 
            // sergoUIToolStripMenuItem
            // 
            this.sergoUIToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sergoUIToolStripMenuItem.Name = "sergoUIToolStripMenuItem";
            this.sergoUIToolStripMenuItem.Size = new System.Drawing.Size(236, 32);
            this.sergoUIToolStripMenuItem.Text = "Segio UI";
            this.sergoUIToolStripMenuItem.Click += new System.EventHandler(this.sergoUIToolStripMenuItem_Click);
            // 
            // segioScriptToolStripMenuItem
            // 
            this.segioScriptToolStripMenuItem.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.segioScriptToolStripMenuItem.Name = "segioScriptToolStripMenuItem";
            this.segioScriptToolStripMenuItem.Size = new System.Drawing.Size(236, 32);
            this.segioScriptToolStripMenuItem.Text = "Segio Script";
            this.segioScriptToolStripMenuItem.Click += new System.EventHandler(this.segioScriptToolStripMenuItem_Click);
            // 
            // noTimesNewRomandFaggotToolStripMenuItem
            // 
            this.noTimesNewRomandFaggotToolStripMenuItem.Name = "noTimesNewRomandFaggotToolStripMenuItem";
            this.noTimesNewRomandFaggotToolStripMenuItem.Size = new System.Drawing.Size(236, 32);
            this.noTimesNewRomandFaggotToolStripMenuItem.Text = "No Times New Roman, Faggot";
            this.noTimesNewRomandFaggotToolStripMenuItem.Click += new System.EventHandler(this.noTimesNewRomandFaggotToolStripMenuItem_Click);
            // 
            // colorToolStripMenuItem
            // 
            this.colorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.blueColor,
            this.greenColor,
            this.pinkColor,
            this.purpleColor,
            this.whiteColor,
            this.yellowColor});
            this.colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            this.colorToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.colorToolStripMenuItem.Text = "Color";
            // 
            // blueColor
            // 
            this.blueColor.Name = "blueColor";
            this.blueColor.Size = new System.Drawing.Size(109, 22);
            this.blueColor.Text = "Blue";
            // 
            // greenColor
            // 
            this.greenColor.Name = "greenColor";
            this.greenColor.Size = new System.Drawing.Size(109, 22);
            this.greenColor.Text = "Green";
            this.greenColor.Click += new System.EventHandler(this.colorClicked);
            // 
            // pinkColor
            // 
            this.pinkColor.Image = global::Simplisticky.Properties.Resources.pink;
            this.pinkColor.Name = "pinkColor";
            this.pinkColor.Size = new System.Drawing.Size(109, 22);
            this.pinkColor.Text = "Pink";
            this.pinkColor.Click += new System.EventHandler(this.colorClicked);
            // 
            // purpleColor
            // 
            this.purpleColor.Name = "purpleColor";
            this.purpleColor.Size = new System.Drawing.Size(109, 22);
            this.purpleColor.Text = "Purple";
            // 
            // whiteColor
            // 
            this.whiteColor.Name = "whiteColor";
            this.whiteColor.Size = new System.Drawing.Size(109, 22);
            this.whiteColor.Text = "White";
            this.whiteColor.Click += new System.EventHandler(this.colorClicked);
            // 
            // yellowColor
            // 
            this.yellowColor.Name = "yellowColor";
            this.yellowColor.Size = new System.Drawing.Size(109, 22);
            this.yellowColor.Text = "Yellow";
            // 
            // CloseButton
            // 
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Font = new System.Drawing.Font("Wingdings 2", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.CloseButton.ForeColor = System.Drawing.Color.DimGray;
            this.CloseButton.Location = new System.Drawing.Point(27, 5);
            this.CloseButton.Margin = new System.Windows.Forms.Padding(0);
            this.CloseButton.MaximumSize = new System.Drawing.Size(20, 20);
            this.CloseButton.MinimumSize = new System.Drawing.Size(20, 20);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(20, 20);
            this.CloseButton.TabIndex = 2;
            this.CloseButton.Text = "O";
            this.CloseButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.CloseButton.Click += new System.EventHandler(this.closeButton_Click);
            this.CloseButton.MouseLeave += new System.EventHandler(this.CloseButton_MouseLeave);
            this.CloseButton.MouseHover += new System.EventHandler(this.CloseButton_MouseHover);
            // 
            // ToolBarPanel
            // 
            this.ToolBarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(247)))), ((int)(((byte)(182)))));
            this.ToolBarPanel.Controls.Add(this.lastUpdatedField);
            this.ToolBarPanel.Controls.Add(this.AddNoteButton);
            this.ToolBarPanel.Controls.Add(this.CloseButton);
            this.ToolBarPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ToolBarPanel.Location = new System.Drawing.Point(0, 0);
            this.ToolBarPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ToolBarPanel.Name = "ToolBarPanel";
            this.ToolBarPanel.Size = new System.Drawing.Size(200, 30);
            this.ToolBarPanel.TabIndex = 3;
            this.ToolBarPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.ToolBarPanel_Paint);
            this.ToolBarPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.toolbar_mouseDown);
            this.ToolBarPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.toolbar_MouseMove);
            // 
            // lastUpdatedField
            // 
            this.lastUpdatedField.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lastUpdatedField.AutoSize = true;
            this.lastUpdatedField.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastUpdatedField.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lastUpdatedField.Location = new System.Drawing.Point(74, 7);
            this.lastUpdatedField.MaximumSize = new System.Drawing.Size(120, 16);
            this.lastUpdatedField.MinimumSize = new System.Drawing.Size(120, 16);
            this.lastUpdatedField.Name = "lastUpdatedField";
            this.lastUpdatedField.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lastUpdatedField.Size = new System.Drawing.Size(120, 16);
            this.lastUpdatedField.TabIndex = 4;
            this.lastUpdatedField.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lastUpdatedField.Click += new System.EventHandler(this.lastUpdatedField_Click);
            this.lastUpdatedField.MouseDown += new System.Windows.Forms.MouseEventHandler(this.toolbar_mouseDown);
            this.lastUpdatedField.MouseMove += new System.Windows.Forms.MouseEventHandler(this.toolbar_MouseMove);
            // 
            // AddNoteButton
            // 
            this.AddNoteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddNoteButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddNoteButton.ForeColor = System.Drawing.Color.DimGray;
            this.AddNoteButton.Location = new System.Drawing.Point(6, 6);
            this.AddNoteButton.MaximumSize = new System.Drawing.Size(20, 20);
            this.AddNoteButton.MinimumSize = new System.Drawing.Size(20, 20);
            this.AddNoteButton.Name = "AddNoteButton";
            this.AddNoteButton.Size = new System.Drawing.Size(20, 20);
            this.AddNoteButton.TabIndex = 3;
            this.AddNoteButton.Text = "+";
            this.AddNoteButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.AddNoteButton_Click);
            this.AddNoteButton.MouseLeave += new System.EventHandler(this.AddNoteButton_MouseLeave);
            this.AddNoteButton.MouseHover += new System.EventHandler(this.AddNoteButton_MouseHover);
            // 
            // dragIconLabel
            // 
            this.dragIconLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dragIconLabel.AutoSize = true;
            this.dragIconLabel.Cursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.dragIconLabel.Image = global::Simplisticky.Properties.Resources.drag;
            this.dragIconLabel.Location = new System.Drawing.Point(188, 162);
            this.dragIconLabel.MaximumSize = new System.Drawing.Size(8, 8);
            this.dragIconLabel.MinimumSize = new System.Drawing.Size(8, 8);
            this.dragIconLabel.Name = "dragIconLabel";
            this.dragIconLabel.Size = new System.Drawing.Size(8, 8);
            this.dragIconLabel.TabIndex = 4;
            // 
            // NoteTextBox
            // 
            this.NoteTextBox.AcceptsReturn = true;
            this.NoteTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.NoteTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(225)))));
            this.NoteTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NoteTextBox.ContextMenuStrip = this.contextMenuStrip1;
            this.NoteTextBox.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NoteTextBox.Location = new System.Drawing.Point(13, 40);
            this.NoteTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NoteTextBox.Multiline = true;
            this.NoteTextBox.Name = "NoteTextBox";
            this.NoteTextBox.Size = new System.Drawing.Size(174, 119);
            this.NoteTextBox.TabIndex = 0;
            this.NoteTextBox.TextChanged += new System.EventHandler(this.NoteTextBox_TextChanged);
            // 
            // StickyNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(200, 173);
            this.ControlBox = false;
            this.Controls.Add(this.ToolBarPanel);
            this.Controls.Add(this.dragIconLabel);
            this.Controls.Add(this.NoteTextBox);
            this.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(180, 100);
            this.Name = "StickyNote";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "SimpleStickyNote";
            this.Load += new System.EventHandler(this.stickyNote_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ToolBarPanel.ResumeLayout(false);
            this.ToolBarPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NoteTextBox;
        private System.Windows.Forms.Label CloseButton;
        private System.Windows.Forms.Panel ToolBarPanel;
        private System.Windows.Forms.Label AddNoteButton;
        private System.Windows.Forms.Label dragIconLabel;
        private System.Windows.Forms.Label lastUpdatedField;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem textboxRightClickMenu;
        private System.Windows.Forms.ToolStripSeparator seperatorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fontToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calibriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sergoUIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blueColor;
        private System.Windows.Forms.ToolStripMenuItem greenColor;
        private System.Windows.Forms.ToolStripMenuItem pinkColor;
        private System.Windows.Forms.ToolStripMenuItem purpleColor;
        private System.Windows.Forms.ToolStripMenuItem whiteColor;
        private System.Windows.Forms.ToolStripMenuItem yellowColor;
        private System.Windows.Forms.ToolStripMenuItem noTimesNewRomandFaggotToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem segioScriptToolStripMenuItem;
    }
}

