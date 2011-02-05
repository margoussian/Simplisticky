namespace Simplisticky {
    partial class MainWindow {
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
            this.MainWindowTabControl = new System.Windows.Forms.TabControl();
            this.NoteListTab = new System.Windows.Forms.TabPage();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.noteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.NotesTabDescLabel = new System.Windows.Forms.Label();
            this.SettingsTab = new System.Windows.Forms.TabPage();
            this.LoginCredentialsTab = new System.Windows.Forms.TabPage();
            this.syncStatusMessage = new System.Windows.Forms.Label();
            this.syncButton = new System.Windows.Forms.Button();
            this.CredentialsBox = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.emailField = new System.Windows.Forms.TextBox();
            this.passwordField = new System.Windows.Forms.TextBox();
            this.MainWindowTabControl.SuspendLayout();
            this.NoteListTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.noteBindingSource)).BeginInit();
            this.LoginCredentialsTab.SuspendLayout();
            this.CredentialsBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainWindowTabControl
            // 
            this.MainWindowTabControl.Controls.Add(this.NoteListTab);
            this.MainWindowTabControl.Controls.Add(this.SettingsTab);
            this.MainWindowTabControl.Controls.Add(this.LoginCredentialsTab);
            this.MainWindowTabControl.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainWindowTabControl.Location = new System.Drawing.Point(12, 12);
            this.MainWindowTabControl.Name = "MainWindowTabControl";
            this.MainWindowTabControl.SelectedIndex = 0;
            this.MainWindowTabControl.Size = new System.Drawing.Size(294, 412);
            this.MainWindowTabControl.TabIndex = 0;
            // 
            // NoteListTab
            // 
            this.NoteListTab.BackColor = System.Drawing.Color.WhiteSmoke;
            this.NoteListTab.Controls.Add(this.listBox1);
            this.NoteListTab.Controls.Add(this.NotesTabDescLabel);
            this.NoteListTab.Location = new System.Drawing.Point(4, 24);
            this.NoteListTab.Name = "NoteListTab";
            this.NoteListTab.Padding = new System.Windows.Forms.Padding(3);
            this.NoteListTab.Size = new System.Drawing.Size(286, 384);
            this.NoteListTab.TabIndex = 0;
            this.NoteListTab.Text = "Notes";
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(3, 62);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(280, 319);
            this.listBox1.TabIndex = 2;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // noteBindingSource
            // 
            this.noteBindingSource.DataSource = typeof(Sharpnote.Note);
            // 
            // NotesTabDescLabel
            // 
            this.NotesTabDescLabel.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NotesTabDescLabel.Location = new System.Drawing.Point(6, 4);
            this.NotesTabDescLabel.Name = "NotesTabDescLabel";
            this.NotesTabDescLabel.Size = new System.Drawing.Size(247, 54);
            this.NotesTabDescLabel.TabIndex = 1;
            this.NotesTabDescLabel.Text = "This list contains the notes stored on your Simplenote account. Select the ones y" +
                "ou\'d like to see as sticky notes on your desktop.";
            this.NotesTabDescLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SettingsTab
            // 
            this.SettingsTab.BackColor = System.Drawing.Color.WhiteSmoke;
            this.SettingsTab.Location = new System.Drawing.Point(4, 24);
            this.SettingsTab.Name = "SettingsTab";
            this.SettingsTab.Padding = new System.Windows.Forms.Padding(3);
            this.SettingsTab.Size = new System.Drawing.Size(286, 384);
            this.SettingsTab.TabIndex = 1;
            this.SettingsTab.Text = "Settings";
            // 
            // LoginCredentialsTab
            // 
            this.LoginCredentialsTab.BackColor = System.Drawing.Color.WhiteSmoke;
            this.LoginCredentialsTab.Controls.Add(this.syncStatusMessage);
            this.LoginCredentialsTab.Controls.Add(this.syncButton);
            this.LoginCredentialsTab.Controls.Add(this.CredentialsBox);
            this.LoginCredentialsTab.Location = new System.Drawing.Point(4, 24);
            this.LoginCredentialsTab.Name = "LoginCredentialsTab";
            this.LoginCredentialsTab.Size = new System.Drawing.Size(286, 384);
            this.LoginCredentialsTab.TabIndex = 2;
            this.LoginCredentialsTab.Text = "Simplenote";
            // 
            // syncStatusMessage
            // 
            this.syncStatusMessage.AutoSize = true;
            this.syncStatusMessage.BackColor = System.Drawing.Color.Transparent;
            this.syncStatusMessage.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.syncStatusMessage.ForeColor = System.Drawing.Color.LimeGreen;
            this.syncStatusMessage.Location = new System.Drawing.Point(10, 132);
            this.syncStatusMessage.Name = "syncStatusMessage";
            this.syncStatusMessage.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.syncStatusMessage.Size = new System.Drawing.Size(88, 15);
            this.syncStatusMessage.TabIndex = 4;
            this.syncStatusMessage.Text = "Sync Successful";
            this.syncStatusMessage.Visible = false;
            // 
            // syncButton
            // 
            this.syncButton.Location = new System.Drawing.Point(201, 128);
            this.syncButton.Name = "syncButton";
            this.syncButton.Size = new System.Drawing.Size(75, 23);
            this.syncButton.TabIndex = 3;
            this.syncButton.Text = "Sync Now";
            this.syncButton.UseVisualStyleBackColor = true;
            this.syncButton.Click += new System.EventHandler(this.syncButton_Click);
            // 
            // CredentialsBox
            // 
            this.CredentialsBox.Controls.Add(this.label2);
            this.CredentialsBox.Controls.Add(this.label1);
            this.CredentialsBox.Controls.Add(this.emailField);
            this.CredentialsBox.Controls.Add(this.passwordField);
            this.CredentialsBox.Location = new System.Drawing.Point(10, 31);
            this.CredentialsBox.Name = "CredentialsBox";
            this.CredentialsBox.Size = new System.Drawing.Size(266, 91);
            this.CredentialsBox.TabIndex = 2;
            this.CredentialsBox.TabStop = false;
            this.CredentialsBox.Text = "Simplenote Account";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Email:";
            // 
            // emailField
            // 
            this.emailField.Location = new System.Drawing.Point(79, 23);
            this.emailField.Name = "emailField";
            this.emailField.Size = new System.Drawing.Size(174, 23);
            this.emailField.TabIndex = 0;
            // 
            // passwordField
            // 
            this.passwordField.Location = new System.Drawing.Point(79, 53);
            this.passwordField.Name = "passwordField";
            this.passwordField.Size = new System.Drawing.Size(173, 23);
            this.passwordField.TabIndex = 1;
            this.passwordField.UseSystemPasswordChar = true;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 436);
            this.Controls.Add(this.MainWindowTabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(324, 464);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(324, 464);
            this.Name = "MainWindow";
            this.Text = "SimpleStickyNotes";
            this.MainWindowTabControl.ResumeLayout(false);
            this.NoteListTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.noteBindingSource)).EndInit();
            this.LoginCredentialsTab.ResumeLayout(false);
            this.LoginCredentialsTab.PerformLayout();
            this.CredentialsBox.ResumeLayout(false);
            this.CredentialsBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl MainWindowTabControl;
        private System.Windows.Forms.TabPage NoteListTab;
        private System.Windows.Forms.TabPage SettingsTab;
        private System.Windows.Forms.TabPage LoginCredentialsTab;
        private System.Windows.Forms.Label NotesTabDescLabel;
        private System.Windows.Forms.GroupBox CredentialsBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox emailField;
        private System.Windows.Forms.TextBox passwordField;
        private System.Windows.Forms.Label syncStatusMessage;
        private System.Windows.Forms.Button syncButton;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.BindingSource noteBindingSource;
    }
}