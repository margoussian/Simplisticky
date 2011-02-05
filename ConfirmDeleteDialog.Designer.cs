namespace Simplisticky {
    partial class ConfirmDeleteDialog {
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.CancelDeleteButton = new System.Windows.Forms.Button();
            this.ConfirmDeleteButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Menu;
            this.panel1.Controls.Add(this.CancelDeleteButton);
            this.panel1.Controls.Add(this.ConfirmDeleteButton);
            this.panel1.Location = new System.Drawing.Point(-1, 81);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(454, 42);
            this.panel1.TabIndex = 0;
            // 
            // CancelDeleteButton
            // 
            this.CancelDeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.CancelDeleteButton.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelDeleteButton.Location = new System.Drawing.Point(321, 8);
            this.CancelDeleteButton.Name = "CancelDeleteButton";
            this.CancelDeleteButton.Size = new System.Drawing.Size(75, 23);
            this.CancelDeleteButton.TabIndex = 1;
            this.CancelDeleteButton.Text = "No";
            this.CancelDeleteButton.UseVisualStyleBackColor = true;
            this.CancelDeleteButton.Click += new System.EventHandler(this.cancelDeleteButton_Click);
            // 
            // ConfirmDeleteButton
            // 
            this.ConfirmDeleteButton.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmDeleteButton.Location = new System.Drawing.Point(240, 8);
            this.ConfirmDeleteButton.Name = "ConfirmDeleteButton";
            this.ConfirmDeleteButton.Size = new System.Drawing.Size(75, 23);
            this.ConfirmDeleteButton.TabIndex = 0;
            this.ConfirmDeleteButton.Text = "Yes";
            this.ConfirmDeleteButton.UseVisualStyleBackColor = true;
            this.ConfirmDeleteButton.Click += new System.EventHandler(this.ConfirmDeleteButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Delete Note";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(283, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Are you sure you want to delete this note?";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // ConfirmDeleteDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(407, 119);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConfirmDeleteDialog";
            this.Text = "SimpleStickyNotes";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.ConfirmDeleteDialog_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button CancelDeleteButton;
        private System.Windows.Forms.Button ConfirmDeleteButton;
    }
}