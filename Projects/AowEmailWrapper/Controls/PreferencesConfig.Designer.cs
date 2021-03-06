﻿namespace AowEmailWrapper.Controls
{
    partial class PreferencesConfig
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxPreferences = new System.Windows.Forms.GroupBox();
            this.groupBoxEmailSelection = new System.Windows.Forms.GroupBox();
            this.panelMessage = new System.Windows.Forms.Panel();
            this.labelMessage = new System.Windows.Forms.Label();
            this.fbSaveFolder = new AowEmailWrapper.Controls.FormBlockCombo();
            this.fbGameWrapperDataPort = new AowEmailWrapper.Controls.FormBlockText();
            this.fbCopyToEmailOut = new AowEmailWrapper.Controls.FormBlockCheckBox();
            this.fbAutostart = new AowEmailWrapper.Controls.FormBlockCheckBox();
            this.fbSentSound = new AowEmailWrapper.Controls.FormBlockCheckBox();
            this.fbEmailSound = new AowEmailWrapper.Controls.FormBlockCheckBox();
            this.fbLocalization = new AowEmailWrapper.Controls.FormBlockCombo();
            this.groupBoxPreferences.SuspendLayout();
            this.groupBoxEmailSelection.SuspendLayout();
            this.panelMessage.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxPreferences
            // 
            this.groupBoxPreferences.AutoSize = true;
            this.groupBoxPreferences.Controls.Add(this.fbGameWrapperDataPort);
            this.groupBoxPreferences.Controls.Add(this.fbCopyToEmailOut);
            this.groupBoxPreferences.Controls.Add(this.fbAutostart);
            this.groupBoxPreferences.Controls.Add(this.fbSentSound);
            this.groupBoxPreferences.Controls.Add(this.fbEmailSound);
            this.groupBoxPreferences.Controls.Add(this.fbLocalization);
            this.groupBoxPreferences.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxPreferences.Location = new System.Drawing.Point(0, 0);
            this.groupBoxPreferences.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxPreferences.Name = "groupBoxPreferences";
            this.groupBoxPreferences.Padding = new System.Windows.Forms.Padding(2, 2, 2, 5);
            this.groupBoxPreferences.Size = new System.Drawing.Size(423, 164);
            this.groupBoxPreferences.TabIndex = 0;
            this.groupBoxPreferences.TabStop = false;
            this.groupBoxPreferences.Text = "Preferences";
            // 
            // groupBoxEmailSelection
            // 
            this.groupBoxEmailSelection.AutoSize = true;
            this.groupBoxEmailSelection.Controls.Add(this.panelMessage);
            this.groupBoxEmailSelection.Controls.Add(this.fbSaveFolder);
            this.groupBoxEmailSelection.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxEmailSelection.Location = new System.Drawing.Point(0, 164);
            this.groupBoxEmailSelection.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxEmailSelection.Name = "groupBoxEmailSelection";
            this.groupBoxEmailSelection.Padding = new System.Windows.Forms.Padding(2, 2, 2, 5);
            this.groupBoxEmailSelection.Size = new System.Drawing.Size(423, 65);
            this.groupBoxEmailSelection.TabIndex = 14;
            this.groupBoxEmailSelection.TabStop = false;
            this.groupBoxEmailSelection.Text = "Email Attachment Downloading";
            // 
            // panelMessage
            // 
            this.panelMessage.BackColor = System.Drawing.SystemColors.Info;
            this.panelMessage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMessage.Controls.Add(this.labelMessage);
            this.panelMessage.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMessage.Location = new System.Drawing.Point(2, 39);
            this.panelMessage.Name = "panelMessage";
            this.panelMessage.Size = new System.Drawing.Size(419, 21);
            this.panelMessage.TabIndex = 19;
            // 
            // labelMessage
            // 
            this.labelMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelMessage.Location = new System.Drawing.Point(0, 0);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(417, 19);
            this.labelMessage.TabIndex = 0;
            this.labelMessage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // fbSaveFolder
            // 
            this.fbSaveFolder.Dock = System.Windows.Forms.DockStyle.Top;
            this.fbSaveFolder.LabelName = "Download Folder:";
            this.fbSaveFolder.Location = new System.Drawing.Point(2, 15);
            this.fbSaveFolder.Margin = new System.Windows.Forms.Padding(2);
            this.fbSaveFolder.MinimumSize = new System.Drawing.Size(0, 24);
            this.fbSaveFolder.Name = "fbSaveFolder";
            this.fbSaveFolder.SelectedIndex = -1;
            this.fbSaveFolder.SelectedValue = "";
            this.fbSaveFolder.Size = new System.Drawing.Size(419, 24);
            this.fbSaveFolder.TabIndex = 18;
            this.fbSaveFolder.Tag = "";
            // 
            // fbGameWrapperDataPort
            // 
            this.fbGameWrapperDataPort.Dock = System.Windows.Forms.DockStyle.Top;
            this.fbGameWrapperDataPort.IsPassword = false;
            this.fbGameWrapperDataPort.LabelName = "Game to Wrapper data port:";
            this.fbGameWrapperDataPort.Location = new System.Drawing.Point(2, 135);
            this.fbGameWrapperDataPort.Margin = new System.Windows.Forms.Padding(2);
            this.fbGameWrapperDataPort.MinimumSize = new System.Drawing.Size(0, 24);
            this.fbGameWrapperDataPort.Name = "fbGameWrapperDataPort";
            this.fbGameWrapperDataPort.Size = new System.Drawing.Size(419, 24);
            this.fbGameWrapperDataPort.TabIndex = 36;
            this.fbGameWrapperDataPort.TextValue = "";
            this.fbGameWrapperDataPort.ValidationRegEx = "^(0|[1-9][0-9]*)$";
            // 
            // fbCopyToEmailOut
            // 
            this.fbCopyToEmailOut.Checked = false;
            this.fbCopyToEmailOut.Dock = System.Windows.Forms.DockStyle.Top;
            this.fbCopyToEmailOut.LabelName = "Copy to EmailOut on send:";
            this.fbCopyToEmailOut.Location = new System.Drawing.Point(2, 111);
            this.fbCopyToEmailOut.MinimumSize = new System.Drawing.Size(0, 24);
            this.fbCopyToEmailOut.Name = "fbCopyToEmailOut";
            this.fbCopyToEmailOut.Size = new System.Drawing.Size(419, 24);
            this.fbCopyToEmailOut.TabIndex = 35;
            // 
            // fbAutostart
            // 
            this.fbAutostart.Checked = false;
            this.fbAutostart.Dock = System.Windows.Forms.DockStyle.Top;
            this.fbAutostart.LabelName = "Autostart with Windows:";
            this.fbAutostart.Location = new System.Drawing.Point(2, 87);
            this.fbAutostart.MinimumSize = new System.Drawing.Size(0, 24);
            this.fbAutostart.Name = "fbAutostart";
            this.fbAutostart.Size = new System.Drawing.Size(419, 24);
            this.fbAutostart.TabIndex = 34;
            // 
            // fbSentSound
            // 
            this.fbSentSound.Checked = false;
            this.fbSentSound.Dock = System.Windows.Forms.DockStyle.Top;
            this.fbSentSound.LabelName = "Email Sent sound:";
            this.fbSentSound.Location = new System.Drawing.Point(2, 63);
            this.fbSentSound.MinimumSize = new System.Drawing.Size(0, 24);
            this.fbSentSound.Name = "fbSentSound";
            this.fbSentSound.Size = new System.Drawing.Size(419, 24);
            this.fbSentSound.TabIndex = 33;
            // 
            // fbEmailSound
            // 
            this.fbEmailSound.Checked = false;
            this.fbEmailSound.Dock = System.Windows.Forms.DockStyle.Top;
            this.fbEmailSound.LabelName = "Email Downloaded sound:";
            this.fbEmailSound.Location = new System.Drawing.Point(2, 39);
            this.fbEmailSound.MinimumSize = new System.Drawing.Size(0, 24);
            this.fbEmailSound.Name = "fbEmailSound";
            this.fbEmailSound.Size = new System.Drawing.Size(419, 24);
            this.fbEmailSound.TabIndex = 32;
            // 
            // fbLocalization
            // 
            this.fbLocalization.Dock = System.Windows.Forms.DockStyle.Top;
            this.fbLocalization.LabelName = "Language:";
            this.fbLocalization.Location = new System.Drawing.Point(2, 15);
            this.fbLocalization.Margin = new System.Windows.Forms.Padding(2);
            this.fbLocalization.MinimumSize = new System.Drawing.Size(0, 24);
            this.fbLocalization.Name = "fbLocalization";
            this.fbLocalization.SelectedIndex = -1;
            this.fbLocalization.SelectedValue = "";
            this.fbLocalization.Size = new System.Drawing.Size(419, 24);
            this.fbLocalization.TabIndex = 19;
            this.fbLocalization.Tag = "";
            // 
            // PreferencesConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBoxEmailSelection);
            this.Controls.Add(this.groupBoxPreferences);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "PreferencesConfig";
            this.Size = new System.Drawing.Size(423, 272);
            this.groupBoxPreferences.ResumeLayout(false);
            this.groupBoxEmailSelection.ResumeLayout(false);
            this.panelMessage.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxPreferences;
        private System.Windows.Forms.GroupBox groupBoxEmailSelection;
        private System.Windows.Forms.Panel panelMessage;
        private System.Windows.Forms.Label labelMessage;
        private FormBlockCombo fbSaveFolder;
        private FormBlockCombo fbLocalization;
        private FormBlockCheckBox fbAutostart;
        private FormBlockCheckBox fbSentSound;
        private FormBlockCheckBox fbEmailSound;
        private FormBlockCheckBox fbCopyToEmailOut;
        private FormBlockText fbGameWrapperDataPort;
    }
}
