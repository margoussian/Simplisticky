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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StickyNote));
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
            this.colorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blueColor = new System.Windows.Forms.ToolStripMenuItem();
            this.greenColor = new System.Windows.Forms.ToolStripMenuItem();
            this.pinkColor = new System.Windows.Forms.ToolStripMenuItem();
            this.purpleColor = new System.Windows.Forms.ToolStripMenuItem();
            this.whiteColor = new System.Windows.Forms.ToolStripMenuItem();
            this.yellowColor = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolBarPanel = new System.Windows.Forms.Panel();
            this.settingIcon = new System.Windows.Forms.Label();
            this.DeleteDialog = new System.Windows.Forms.Panel();
            this.slash = new System.Windows.Forms.Label();
            this.confirmDelete = new System.Windows.Forms.LinkLabel();
            this.cancelDelete = new System.Windows.Forms.LinkLabel();
            this.deleteNoteLabel = new System.Windows.Forms.Label();
            this.infoButton = new System.Windows.Forms.Label();
            this.AddNoteButton = new System.Windows.Forms.Label();
            this.CloseButton = new System.Windows.Forms.Label();
            this.NoteTextBox = new System.Windows.Forms.RichTextBox();
            this.infoTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.contextMenuStrip1.SuspendLayout();
            this.ToolBarPanel.SuspendLayout();
            this.DeleteDialog.SuspendLayout();
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
            this.segioScriptToolStripMenuItem});
            this.fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            this.fontToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.fontToolStripMenuItem.Text = "Font";
            // 
            // arialToolStripMenuItem
            // 
            this.arialToolStripMenuItem.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arialToolStripMenuItem.Name = "arialToolStripMenuItem";
            this.arialToolStripMenuItem.Size = new System.Drawing.Size(175, 32);
            this.arialToolStripMenuItem.Text = "Arial";
            this.arialToolStripMenuItem.Click += new System.EventHandler(this.arialToolStripMenuItem_Click);
            // 
            // calibriToolStripMenuItem
            // 
            this.calibriToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calibriToolStripMenuItem.Name = "calibriToolStripMenuItem";
            this.calibriToolStripMenuItem.Size = new System.Drawing.Size(175, 32);
            this.calibriToolStripMenuItem.Text = "Calibri";
            this.calibriToolStripMenuItem.Click += new System.EventHandler(this.calibriToolStripMenuItem_Click);
            // 
            // sergoUIToolStripMenuItem
            // 
            this.sergoUIToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sergoUIToolStripMenuItem.Name = "sergoUIToolStripMenuItem";
            this.sergoUIToolStripMenuItem.Size = new System.Drawing.Size(175, 32);
            this.sergoUIToolStripMenuItem.Text = "Segio UI";
            this.sergoUIToolStripMenuItem.Click += new System.EventHandler(this.sergoUIToolStripMenuItem_Click);
            // 
            // segioScriptToolStripMenuItem
            // 
            this.segioScriptToolStripMenuItem.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.segioScriptToolStripMenuItem.Name = "segioScriptToolStripMenuItem";
            this.segioScriptToolStripMenuItem.Size = new System.Drawing.Size(175, 32);
            this.segioScriptToolStripMenuItem.Text = "Segio Script";
            this.segioScriptToolStripMenuItem.Click += new System.EventHandler(this.segioScriptToolStripMenuItem_Click);
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
            this.blueColor.Image = global::Simplisticky.Properties.Resources.blue_stickynote;
            this.blueColor.Name = "blueColor";
            this.blueColor.Size = new System.Drawing.Size(109, 22);
            this.blueColor.Text = "Blue";
            // 
            // greenColor
            // 
            this.greenColor.Image = global::Simplisticky.Properties.Resources.green_stickynote;
            this.greenColor.Name = "greenColor";
            this.greenColor.Size = new System.Drawing.Size(109, 22);
            this.greenColor.Text = "Green";
            this.greenColor.Click += new System.EventHandler(this.colorClicked);
            // 
            // pinkColor
            // 
            this.pinkColor.Image = ((System.Drawing.Image)(resources.GetObject("pinkColor.Image")));
            this.pinkColor.Name = "pinkColor";
            this.pinkColor.Size = new System.Drawing.Size(109, 22);
            this.pinkColor.Text = "Pink";
            this.pinkColor.Click += new System.EventHandler(this.colorClicked);
            // 
            // purpleColor
            // 
            this.purpleColor.Image = global::Simplisticky.Properties.Resources.purple_stickynote;
            this.purpleColor.Name = "purpleColor";
            this.purpleColor.Size = new System.Drawing.Size(109, 22);
            this.purpleColor.Text = "Purple";
            // 
            // whiteColor
            // 
            this.whiteColor.Image = ((System.Drawing.Image)(resources.GetObject("whiteColor.Image")));
            this.whiteColor.Name = "whiteColor";
            this.whiteColor.Size = new System.Drawing.Size(109, 22);
            this.whiteColor.Text = "White";
            this.whiteColor.Click += new System.EventHandler(this.colorClicked);
            // 
            // yellowColor
            // 
            this.yellowColor.Image = global::Simplisticky.Properties.Resources.yellow_stickynote;
            this.yellowColor.Name = "yellowColor";
            this.yellowColor.Size = new System.Drawing.Size(109, 22);
            this.yellowColor.Text = "Yellow";
            // 
            // ToolBarPanel
            // 
            this.ToolBarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(247)))), ((int)(((byte)(182)))));
            this.ToolBarPanel.Controls.Add(this.settingIcon);
            this.ToolBarPanel.Controls.Add(this.DeleteDialog);
            this.ToolBarPanel.Controls.Add(this.infoButton);
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
            // settingIcon
            // 
            this.settingIcon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingIcon.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingIcon.ForeColor = System.Drawing.Color.DimGray;
            this.settingIcon.Image = global::Simplisticky.Properties.Resources.settings_icon_normal;
            this.settingIcon.Location = new System.Drawing.Point(48, 7);
            this.settingIcon.MaximumSize = new System.Drawing.Size(16, 16);
            this.settingIcon.MinimumSize = new System.Drawing.Size(10, 10);
            this.settingIcon.Name = "settingIcon";
            this.settingIcon.Size = new System.Drawing.Size(16, 16);
            this.settingIcon.TabIndex = 7;
            this.settingIcon.Click += new System.EventHandler(this.settingIcon_Click);
            this.settingIcon.MouseEnter += new System.EventHandler(this.settingIcon_MouseEnter);
            this.settingIcon.MouseLeave += new System.EventHandler(this.settingIcon_MouseLeave);
            // 
            // DeleteDialog
            // 
            this.DeleteDialog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteDialog.BackColor = System.Drawing.Color.Transparent;
            this.DeleteDialog.Controls.Add(this.slash);
            this.DeleteDialog.Controls.Add(this.confirmDelete);
            this.DeleteDialog.Controls.Add(this.cancelDelete);
            this.DeleteDialog.Controls.Add(this.deleteNoteLabel);
            this.DeleteDialog.Location = new System.Drawing.Point(72, 2);
            this.DeleteDialog.Name = "DeleteDialog";
            this.DeleteDialog.Size = new System.Drawing.Size(125, 25);
            this.DeleteDialog.TabIndex = 6;
            this.DeleteDialog.Visible = false;
            this.DeleteDialog.MouseDown += new System.Windows.Forms.MouseEventHandler(this.toolbar_mouseDown);
            this.DeleteDialog.MouseMove += new System.Windows.Forms.MouseEventHandler(this.toolbar_MouseMove);
            // 
            // slash
            // 
            this.slash.AutoSize = true;
            this.slash.BackColor = System.Drawing.Color.Transparent;
            this.slash.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.slash.Location = new System.Drawing.Point(95, 5);
            this.slash.Name = "slash";
            this.slash.Size = new System.Drawing.Size(12, 14);
            this.slash.TabIndex = 3;
            this.slash.Text = "/";
            this.slash.MouseDown += new System.Windows.Forms.MouseEventHandler(this.toolbar_mouseDown);
            this.slash.MouseMove += new System.Windows.Forms.MouseEventHandler(this.toolbar_MouseMove);
            // 
            // confirmDelete
            // 
            this.confirmDelete.ActiveLinkColor = System.Drawing.Color.Black;
            this.confirmDelete.AutoSize = true;
            this.confirmDelete.BackColor = System.Drawing.Color.Transparent;
            this.confirmDelete.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmDelete.ForeColor = System.Drawing.Color.DimGray;
            this.confirmDelete.LinkColor = System.Drawing.Color.DimGray;
            this.confirmDelete.Location = new System.Drawing.Point(75, 5);
            this.confirmDelete.Name = "confirmDelete";
            this.confirmDelete.Size = new System.Drawing.Size(23, 14);
            this.confirmDelete.TabIndex = 1;
            this.confirmDelete.TabStop = true;
            this.confirmDelete.Text = "Yes";
            this.confirmDelete.VisitedLinkColor = System.Drawing.Color.DimGray;
            this.confirmDelete.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.confirmDelete_LinkClicked);
            // 
            // cancelDelete
            // 
            this.cancelDelete.ActiveLinkColor = System.Drawing.Color.Black;
            this.cancelDelete.AutoSize = true;
            this.cancelDelete.BackColor = System.Drawing.Color.Transparent;
            this.cancelDelete.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelDelete.ForeColor = System.Drawing.Color.DimGray;
            this.cancelDelete.LinkColor = System.Drawing.Color.DimGray;
            this.cancelDelete.Location = new System.Drawing.Point(103, 5);
            this.cancelDelete.Name = "cancelDelete";
            this.cancelDelete.Size = new System.Drawing.Size(21, 14);
            this.cancelDelete.TabIndex = 2;
            this.cancelDelete.TabStop = true;
            this.cancelDelete.Text = "No";
            this.cancelDelete.VisitedLinkColor = System.Drawing.Color.DimGray;
            this.cancelDelete.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.cancelDelete_LinkClicked);
            // 
            // deleteNoteLabel
            // 
            this.deleteNoteLabel.AutoSize = true;
            this.deleteNoteLabel.BackColor = System.Drawing.Color.Transparent;
            this.deleteNoteLabel.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteNoteLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.deleteNoteLabel.Location = new System.Drawing.Point(1, 5);
            this.deleteNoteLabel.Name = "deleteNoteLabel";
            this.deleteNoteLabel.Size = new System.Drawing.Size(78, 14);
            this.deleteNoteLabel.TabIndex = 0;
            this.deleteNoteLabel.Text = "Delete note?";
            this.deleteNoteLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.toolbar_mouseDown);
            this.deleteNoteLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.toolbar_MouseMove);
            // 
            // infoButton
            // 
            this.infoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.infoButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoButton.ForeColor = System.Drawing.Color.DimGray;
            this.infoButton.Image = global::Simplisticky.Properties.Resources.info_normal;
            this.infoButton.Location = new System.Drawing.Point(28, 7);
            this.infoButton.MaximumSize = new System.Drawing.Size(16, 16);
            this.infoButton.MinimumSize = new System.Drawing.Size(10, 10);
            this.infoButton.Name = "infoButton";
            this.infoButton.Size = new System.Drawing.Size(16, 16);
            this.infoButton.TabIndex = 5;
            this.infoButton.MouseEnter += new System.EventHandler(this.infoButton_MouseEnter);
            this.infoButton.MouseLeave += new System.EventHandler(this.infoButton_MouseLeave);
            // 
            // AddNoteButton
            // 
            this.AddNoteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddNoteButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddNoteButton.ForeColor = System.Drawing.Color.DimGray;
            this.AddNoteButton.Image = global::Simplisticky.Properties.Resources.stickynote_add_normal;
            this.AddNoteButton.Location = new System.Drawing.Point(7, 7);
            this.AddNoteButton.MaximumSize = new System.Drawing.Size(16, 16);
            this.AddNoteButton.MinimumSize = new System.Drawing.Size(10, 10);
            this.AddNoteButton.Name = "AddNoteButton";
            this.AddNoteButton.Size = new System.Drawing.Size(16, 16);
            this.AddNoteButton.TabIndex = 3;
            this.AddNoteButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.AddNoteButton_Click);
            this.AddNoteButton.MouseEnter += new System.EventHandler(this.AddNoteButton_MouseEnter);
            this.AddNoteButton.MouseLeave += new System.EventHandler(this.AddNoteButton_MouseLeave);
            // 
            // CloseButton
            // 
            this.CloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.ForeColor = System.Drawing.Color.DimGray;
            this.CloseButton.Image = global::Simplisticky.Properties.Resources.deletenote_normal;
            this.CloseButton.Location = new System.Drawing.Point(175, 4);
            this.CloseButton.Margin = new System.Windows.Forms.Padding(0);
            this.CloseButton.MinimumSize = new System.Drawing.Size(15, 15);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(24, 22);
            this.CloseButton.TabIndex = 2;
            this.CloseButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.CloseButton.Click += new System.EventHandler(this.closeButton_Click);
            this.CloseButton.MouseEnter += new System.EventHandler(this.CloseButton_MouseEnter);
            this.CloseButton.MouseLeave += new System.EventHandler(this.CloseButton_MouseLeave);
            // 
            // NoteTextBox
            // 
            this.NoteTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.NoteTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(200)))));
            this.NoteTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NoteTextBox.ContextMenuStrip = this.contextMenuStrip1;
            this.NoteTextBox.ForeColor = System.Drawing.Color.Black;
            this.NoteTextBox.Location = new System.Drawing.Point(5, 34);
            this.NoteTextBox.Name = "NoteTextBox";
            this.NoteTextBox.Size = new System.Drawing.Size(190, 128);
            this.NoteTextBox.TabIndex = 4;
            this.NoteTextBox.Text = "";
            // 
            // StickyNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(200)))));
            this.ClientSize = new System.Drawing.Size(200, 173);
            this.ControlBox = false;
            this.Controls.Add(this.NoteTextBox);
            this.Controls.Add(this.ToolBarPanel);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(200, 65);
            this.Name = "StickyNote";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "SimplySticky";
            this.Activated += new System.EventHandler(this.StickyNote_Activated);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ToolBarPanel.ResumeLayout(false);
            this.DeleteDialog.ResumeLayout(false);
            this.DeleteDialog.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label CloseButton;
        private System.Windows.Forms.Panel ToolBarPanel;
        private System.Windows.Forms.Label AddNoteButton;
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
        private System.Windows.Forms.ToolStripMenuItem segioScriptToolStripMenuItem;
        private System.Windows.Forms.Label infoButton;
        private System.Windows.Forms.RichTextBox NoteTextBox;
        private System.Windows.Forms.Panel DeleteDialog;
        private System.Windows.Forms.Label slash;
        private System.Windows.Forms.LinkLabel confirmDelete;
        private System.Windows.Forms.LinkLabel cancelDelete;
        private System.Windows.Forms.Label deleteNoteLabel;
        private System.Windows.Forms.ToolTip infoTooltip;
        private System.Windows.Forms.Label settingIcon;
        


    }
}
