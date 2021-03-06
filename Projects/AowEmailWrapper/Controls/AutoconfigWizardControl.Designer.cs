﻿namespace AowEmailWrapper.Controls
{
    partial class AutoconfigWizardControl
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
            this.panelBottom = new System.Windows.Forms.Panel();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.cmdBack = new System.Windows.Forms.Button();
            this.cmdNext = new System.Windows.Forms.Button();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.panelTop = new System.Windows.Forms.Panel();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelMainContent = new System.Windows.Forms.Panel();
            this.contentPage1 = new AowEmailWrapper.Controls.AutoconfigPage1Welcome();
            this.contentPage2 = new AowEmailWrapper.Controls.AutoconfigPage2Search();
            this.contentPage3 = new AowEmailWrapper.Controls.AutoconfigPage3Select();
            this.panelMainHeader = new System.Windows.Forms.Panel();
            this.lblAutoconfigHeaderMessage = new System.Windows.Forms.Label();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.lblThunderbirdTitle = new System.Windows.Forms.Label();
            this.pictureBoxThunderbird = new System.Windows.Forms.PictureBox();
            this.panelBottom.SuspendLayout();
            this.panelButtons.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.panelMainContent.SuspendLayout();
            this.panelMainHeader.SuspendLayout();
            this.panelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxThunderbird)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBottom
            // 
            this.panelBottom.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelBottom.Controls.Add(this.panelButtons);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 338);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(580, 51);
            this.panelBottom.TabIndex = 2;
            // 
            // panelButtons
            // 
            this.panelButtons.Controls.Add(this.cmdBack);
            this.panelButtons.Controls.Add(this.cmdNext);
            this.panelButtons.Controls.Add(this.cmdCancel);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelButtons.Location = new System.Drawing.Point(208, 0);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(368, 47);
            this.panelButtons.TabIndex = 3;
            // 
            // cmdBack
            // 
            this.cmdBack.Location = new System.Drawing.Point(26, 9);
            this.cmdBack.Name = "cmdBack";
            this.cmdBack.Size = new System.Drawing.Size(107, 30);
            this.cmdBack.TabIndex = 0;
            this.cmdBack.Text = "< Back";
            this.cmdBack.UseVisualStyleBackColor = true;
            this.cmdBack.Visible = false;
            // 
            // cmdNext
            // 
            this.cmdNext.Enabled = false;
            this.cmdNext.Location = new System.Drawing.Point(139, 9);
            this.cmdNext.Name = "cmdNext";
            this.cmdNext.Size = new System.Drawing.Size(107, 30);
            this.cmdNext.TabIndex = 1;
            this.cmdNext.Text = "Next >";
            this.cmdNext.UseVisualStyleBackColor = true;
            // 
            // cmdCancel
            // 
            this.cmdCancel.Location = new System.Drawing.Point(252, 9);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(107, 30);
            this.cmdCancel.TabIndex = 2;
            this.cmdCancel.Text = "Cancel";
            this.cmdCancel.UseVisualStyleBackColor = true;
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.White;
            this.panelTop.Controls.Add(this.panelMain);
            this.panelTop.Controls.Add(this.panelLeft);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(580, 338);
            this.panelTop.TabIndex = 3;
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.Transparent;
            this.panelMain.Controls.Add(this.panelMainContent);
            this.panelMain.Controls.Add(this.panelMainHeader);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(160, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(420, 338);
            this.panelMain.TabIndex = 3;
            // 
            // panelMainContent
            // 
            this.panelMainContent.Controls.Add(this.contentPage1);
            this.panelMainContent.Controls.Add(this.contentPage2);
            this.panelMainContent.Controls.Add(this.contentPage3);
            this.panelMainContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMainContent.Location = new System.Drawing.Point(0, 46);
            this.panelMainContent.Name = "panelMainContent";
            this.panelMainContent.Padding = new System.Windows.Forms.Padding(5);
            this.panelMainContent.Size = new System.Drawing.Size(420, 292);
            this.panelMainContent.TabIndex = 1;
            // 
            // contentPage1
            // 
            this.contentPage1.BackColor = System.Drawing.Color.Transparent;
            this.contentPage1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentPage1.Location = new System.Drawing.Point(5, 5);
            this.contentPage1.Name = "contentPage1";
            this.contentPage1.Size = new System.Drawing.Size(410, 282);
            this.contentPage1.TabIndex = 1;
            // 
            // contentPage2
            // 
            this.contentPage2.BackColor = System.Drawing.Color.Transparent;
            this.contentPage2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentPage2.LastRequestType = Mozilla.Autoconfig.RequestType.Standard;
            this.contentPage2.Location = new System.Drawing.Point(5, 5);
            this.contentPage2.Name = "contentPage2";
            this.contentPage2.Size = new System.Drawing.Size(410, 282);
            this.contentPage2.TabIndex = 2;
            this.contentPage2.TabStop = false;
            // 
            // contentPage3
            // 
            this.contentPage3.BackColor = System.Drawing.Color.Transparent;
            this.contentPage3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentPage3.Location = new System.Drawing.Point(5, 5);
            this.contentPage3.Name = "contentPage3";
            this.contentPage3.Size = new System.Drawing.Size(410, 282);
            this.contentPage3.TabIndex = 2;
            this.contentPage3.TabStop = false;
            // 
            // panelMainHeader
            // 
            this.panelMainHeader.BackColor = System.Drawing.Color.Transparent;
            this.panelMainHeader.Controls.Add(this.lblAutoconfigHeaderMessage);
            this.panelMainHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMainHeader.Location = new System.Drawing.Point(0, 0);
            this.panelMainHeader.Name = "panelMainHeader";
            this.panelMainHeader.Size = new System.Drawing.Size(420, 46);
            this.panelMainHeader.TabIndex = 0;
            // 
            // lblAutoconfigHeaderMessage
            // 
            this.lblAutoconfigHeaderMessage.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblAutoconfigHeaderMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAutoconfigHeaderMessage.Location = new System.Drawing.Point(0, 14);
            this.lblAutoconfigHeaderMessage.Name = "lblAutoconfigHeaderMessage";
            this.lblAutoconfigHeaderMessage.Size = new System.Drawing.Size(420, 32);
            this.lblAutoconfigHeaderMessage.TabIndex = 0;
            this.lblAutoconfigHeaderMessage.Text = "Autoconfig Wizard";
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.Transparent;
            this.panelLeft.Controls.Add(this.lblThunderbirdTitle);
            this.panelLeft.Controls.Add(this.pictureBoxThunderbird);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Padding = new System.Windows.Forms.Padding(3, 70, 3, 3);
            this.panelLeft.Size = new System.Drawing.Size(160, 338);
            this.panelLeft.TabIndex = 2;
            // 
            // lblThunderbirdTitle
            // 
            this.lblThunderbirdTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblThunderbirdTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThunderbirdTitle.Location = new System.Drawing.Point(3, 237);
            this.lblThunderbirdTitle.Name = "lblThunderbirdTitle";
            this.lblThunderbirdTitle.Size = new System.Drawing.Size(154, 79);
            this.lblThunderbirdTitle.TabIndex = 1;
            this.lblThunderbirdTitle.Text = "Thunderbird Database";
            this.lblThunderbirdTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBoxThunderbird
            // 
            this.pictureBoxThunderbird.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBoxThunderbird.Image = global::AowEmailWrapper.Properties.Resources.thunderbird;
            this.pictureBoxThunderbird.Location = new System.Drawing.Point(3, 70);
            this.pictureBoxThunderbird.Name = "pictureBoxThunderbird";
            this.pictureBoxThunderbird.Size = new System.Drawing.Size(154, 167);
            this.pictureBoxThunderbird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxThunderbird.TabIndex = 0;
            this.pictureBoxThunderbird.TabStop = false;
            // 
            // AutoconfigWizardControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelBottom);
            this.Name = "AutoconfigWizardControl";
            this.Size = new System.Drawing.Size(580, 389);
            this.panelBottom.ResumeLayout(false);
            this.panelButtons.ResumeLayout(false);
            this.panelTop.ResumeLayout(false);
            this.panelMain.ResumeLayout(false);
            this.panelMainContent.ResumeLayout(false);
            this.panelMainHeader.ResumeLayout(false);
            this.panelLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxThunderbird)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Button cmdNext;
        private System.Windows.Forms.Button cmdCancel;
        private System.Windows.Forms.Button cmdBack;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelMainContent;
        private AutoconfigPage1Welcome contentPage1;
        private AutoconfigPage2Search contentPage2;
        private AutoconfigPage3Select contentPage3;
        private System.Windows.Forms.Panel panelMainHeader;
        private System.Windows.Forms.Label lblAutoconfigHeaderMessage;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Label lblThunderbirdTitle;
        private System.Windows.Forms.PictureBox pictureBoxThunderbird;
    }
}
