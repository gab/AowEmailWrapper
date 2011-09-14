﻿namespace AowEmailWrapper
{
    partial class Main
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            AowEmailWrapper.ConfigFramework.PreferencesConfigValues preferencesConfigValues1 = new AowEmailWrapper.ConfigFramework.PreferencesConfigValues();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.imageListIcons = new System.Windows.Forms.ImageList(this.components);
            this.panelBottom = new System.Windows.Forms.Panel();
            this.cmdSave = new System.Windows.Forms.Button();
            this.panelLocalMessageStore = new System.Windows.Forms.Panel();
            this.cmdMessageStore = new System.Windows.Forms.Button();
            this.panelMain = new System.Windows.Forms.Panel();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabAccounts = new System.Windows.Forms.TabPage();
            this.accountsConfig = new AowEmailWrapper.Controls.AccountsConfig();
            this.tabActivity = new System.Windows.Forms.TabPage();
            this.activityListView = new AowEmailWrapper.Controls.ActivityListView();
            this.tabPreferences = new System.Windows.Forms.TabPage();
            this.preferencesConfig = new AowEmailWrapper.Controls.PreferencesConfig();
            this.tabAbout = new System.Windows.Forms.TabPage();
            this.panelAbout = new System.Windows.Forms.Panel();
            this.groupBetaTesters = new System.Windows.Forms.GroupBox();
            this.panelBetaTestersGroupBox = new System.Windows.Forms.Panel();
            this.lblTester10 = new System.Windows.Forms.Label();
            this.lblTester9 = new System.Windows.Forms.Label();
            this.lblTester8 = new System.Windows.Forms.Label();
            this.lblTester7 = new System.Windows.Forms.Label();
            this.lblTester6 = new System.Windows.Forms.Label();
            this.lblTester5 = new System.Windows.Forms.Label();
            this.lblTester4 = new System.Windows.Forms.Label();
            this.lblTester3 = new System.Windows.Forms.Label();
            this.lblTester2 = new System.Windows.Forms.Label();
            this.lblTester1 = new System.Windows.Forms.Label();
            this.groupAuthors = new System.Windows.Forms.GroupBox();
            this.lblAuthor2 = new System.Windows.Forms.Label();
            this.lblAuthor1 = new System.Windows.Forms.Label();
            this.lblNotice = new System.Windows.Forms.Label();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.lblVersion = new System.Windows.Forms.Label();
            this.fbLink = new AowEmailWrapper.Controls.LinkButton();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panelBottom.SuspendLayout();
            this.panelLocalMessageStore.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.tabControlMain.SuspendLayout();
            this.tabAccounts.SuspendLayout();
            this.tabActivity.SuspendLayout();
            this.tabPreferences.SuspendLayout();
            this.tabAbout.SuspendLayout();
            this.panelAbout.SuspendLayout();
            this.groupBetaTesters.SuspendLayout();
            this.panelBetaTestersGroupBox.SuspendLayout();
            this.groupAuthors.SuspendLayout();
            this.panelTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon
            // 
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Visible = true;
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
            // 
            // imageListIcons
            // 
            this.imageListIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListIcons.ImageStream")));
            this.imageListIcons.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListIcons.Images.SetKeyName(0, "EmailWaiting");
            this.imageListIcons.Images.SetKeyName(1, "Sending");
            this.imageListIcons.Images.SetKeyName(2, "Checking");
            this.imageListIcons.Images.SetKeyName(3, "AoW1");
            this.imageListIcons.Images.SetKeyName(4, "AoW2");
            this.imageListIcons.Images.SetKeyName(5, "AoWSM");
            this.imageListIcons.Images.SetKeyName(6, "CheckEmail");
            // 
            // panelBottom
            // 
            this.panelBottom.Controls.Add(this.cmdSave);
            this.panelBottom.Controls.Add(this.panelLocalMessageStore);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 485);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Padding = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.panelBottom.Size = new System.Drawing.Size(522, 44);
            this.panelBottom.TabIndex = 2;
            // 
            // cmdSave
            // 
            this.cmdSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmdSave.Location = new System.Drawing.Point(184, 5);
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(336, 34);
            this.cmdSave.TabIndex = 2;
            this.cmdSave.Text = "Save Settings";
            this.cmdSave.UseVisualStyleBackColor = true;
            this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click);
            // 
            // panelLocalMessageStore
            // 
            this.panelLocalMessageStore.Controls.Add(this.cmdMessageStore);
            this.panelLocalMessageStore.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLocalMessageStore.Location = new System.Drawing.Point(2, 5);
            this.panelLocalMessageStore.Name = "panelLocalMessageStore";
            this.panelLocalMessageStore.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.panelLocalMessageStore.Size = new System.Drawing.Size(182, 34);
            this.panelLocalMessageStore.TabIndex = 1;
            this.panelLocalMessageStore.Visible = false;
            // 
            // cmdMessageStore
            // 
            this.cmdMessageStore.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmdMessageStore.Location = new System.Drawing.Point(0, 0);
            this.cmdMessageStore.Name = "cmdMessageStore";
            this.cmdMessageStore.Size = new System.Drawing.Size(177, 34);
            this.cmdMessageStore.TabIndex = 3;
            this.cmdMessageStore.Text = "Show POP3 Emails";
            this.cmdMessageStore.UseVisualStyleBackColor = true;
            this.cmdMessageStore.Click += new System.EventHandler(this.cmdMessageStore_Click);
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.tabControlMain);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.panelMain.Size = new System.Drawing.Size(522, 485);
            this.panelMain.TabIndex = 3;
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabAccounts);
            this.tabControlMain.Controls.Add(this.tabActivity);
            this.tabControlMain.Controls.Add(this.tabPreferences);
            this.tabControlMain.Controls.Add(this.tabAbout);
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMain.Location = new System.Drawing.Point(0, 5);
            this.tabControlMain.Margin = new System.Windows.Forms.Padding(2);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(522, 480);
            this.tabControlMain.TabIndex = 2;
            // 
            // tabAccounts
            // 
            this.tabAccounts.Controls.Add(this.accountsConfig);
            this.tabAccounts.Location = new System.Drawing.Point(4, 22);
            this.tabAccounts.Name = "tabAccounts";
            this.tabAccounts.Padding = new System.Windows.Forms.Padding(5);
            this.tabAccounts.Size = new System.Drawing.Size(514, 454);
            this.tabAccounts.TabIndex = 6;
            this.tabAccounts.Text = "Accounts";
            this.tabAccounts.UseVisualStyleBackColor = true;
            // 
            // accountsConfig
            // 
            this.accountsConfig.AccountsTemplates = null;
            this.accountsConfig.Config = null;
            this.accountsConfig.Dock = System.Windows.Forms.DockStyle.Fill;
            this.accountsConfig.Location = new System.Drawing.Point(5, 5);
            this.accountsConfig.Name = "accountsConfig";
            this.accountsConfig.Size = new System.Drawing.Size(504, 444);
            this.accountsConfig.TabIndex = 0;
            // 
            // tabActivity
            // 
            this.tabActivity.Controls.Add(this.activityListView);
            this.tabActivity.Location = new System.Drawing.Point(4, 22);
            this.tabActivity.Name = "tabActivity";
            this.tabActivity.Size = new System.Drawing.Size(514, 433);
            this.tabActivity.TabIndex = 7;
            this.tabActivity.Text = "Activity Log";
            this.tabActivity.UseVisualStyleBackColor = true;
            // 
            // activityListView
            // 
            this.activityListView.ActivityLog = null;
            this.activityListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.activityListView.Location = new System.Drawing.Point(0, 0);
            this.activityListView.Name = "activityListView";
            this.activityListView.Padding = new System.Windows.Forms.Padding(5);
            this.activityListView.Size = new System.Drawing.Size(514, 433);
            this.activityListView.SmallImageList = null;
            this.activityListView.TabIndex = 0;
            // 
            // tabPreferences
            // 
            this.tabPreferences.Controls.Add(this.preferencesConfig);
            this.tabPreferences.Location = new System.Drawing.Point(4, 22);
            this.tabPreferences.Margin = new System.Windows.Forms.Padding(2);
            this.tabPreferences.Name = "tabPreferences";
            this.tabPreferences.Size = new System.Drawing.Size(514, 433);
            this.tabPreferences.TabIndex = 3;
            this.tabPreferences.Text = "Preferences";
            this.tabPreferences.UseVisualStyleBackColor = true;
            // 
            // preferencesConfig
            // 
            preferencesConfigValues1.Autostart = false;
            preferencesConfigValues1.CopyToEmailOut = false;
            preferencesConfigValues1.GameWrapperDataPort = 49252;
            preferencesConfigValues1.LanguageCode = null;
            preferencesConfigValues1.PlaySoundOnEmail = false;
            preferencesConfigValues1.PlaySoundOnSend = false;
            preferencesConfigValues1.SaveFolder = AowEmailWrapper.ConfigFramework.EmailSaveFolder.EmailIn;
            this.preferencesConfig.Config = preferencesConfigValues1;
            this.preferencesConfig.Dock = System.Windows.Forms.DockStyle.Top;
            this.preferencesConfig.Location = new System.Drawing.Point(0, 0);
            this.preferencesConfig.Margin = new System.Windows.Forms.Padding(2);
            this.preferencesConfig.Name = "preferencesConfig";
            this.preferencesConfig.Padding = new System.Windows.Forms.Padding(5);
            this.preferencesConfig.Size = new System.Drawing.Size(514, 313);
            this.preferencesConfig.TabIndex = 0;
            // 
            // tabAbout
            // 
            this.tabAbout.Controls.Add(this.panelAbout);
            this.tabAbout.Location = new System.Drawing.Point(4, 22);
            this.tabAbout.Name = "tabAbout";
            this.tabAbout.Size = new System.Drawing.Size(514, 433);
            this.tabAbout.TabIndex = 5;
            this.tabAbout.Text = "About";
            this.tabAbout.UseVisualStyleBackColor = true;
            // 
            // panelAbout
            // 
            this.panelAbout.Controls.Add(this.groupBetaTesters);
            this.panelAbout.Controls.Add(this.groupAuthors);
            this.panelAbout.Controls.Add(this.lblNotice);
            this.panelAbout.Controls.Add(this.panelTitle);
            this.panelAbout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAbout.Location = new System.Drawing.Point(0, 0);
            this.panelAbout.Name = "panelAbout";
            this.panelAbout.Padding = new System.Windows.Forms.Padding(5);
            this.panelAbout.Size = new System.Drawing.Size(514, 433);
            this.panelAbout.TabIndex = 0;
            // 
            // groupBetaTesters
            // 
            this.groupBetaTesters.Controls.Add(this.panelBetaTestersGroupBox);
            this.groupBetaTesters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBetaTesters.Location = new System.Drawing.Point(5, 219);
            this.groupBetaTesters.Name = "groupBetaTesters";
            this.groupBetaTesters.Size = new System.Drawing.Size(504, 209);
            this.groupBetaTesters.TabIndex = 12;
            this.groupBetaTesters.TabStop = false;
            this.groupBetaTesters.Text = "Beta Testers";
            // 
            // panelBetaTestersGroupBox
            // 
            this.panelBetaTestersGroupBox.AutoScroll = true;
            this.panelBetaTestersGroupBox.Controls.Add(this.lblTester10);
            this.panelBetaTestersGroupBox.Controls.Add(this.lblTester9);
            this.panelBetaTestersGroupBox.Controls.Add(this.lblTester8);
            this.panelBetaTestersGroupBox.Controls.Add(this.lblTester7);
            this.panelBetaTestersGroupBox.Controls.Add(this.lblTester6);
            this.panelBetaTestersGroupBox.Controls.Add(this.lblTester5);
            this.panelBetaTestersGroupBox.Controls.Add(this.lblTester4);
            this.panelBetaTestersGroupBox.Controls.Add(this.lblTester3);
            this.panelBetaTestersGroupBox.Controls.Add(this.lblTester2);
            this.panelBetaTestersGroupBox.Controls.Add(this.lblTester1);
            this.panelBetaTestersGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBetaTestersGroupBox.Location = new System.Drawing.Point(3, 16);
            this.panelBetaTestersGroupBox.Name = "panelBetaTestersGroupBox";
            this.panelBetaTestersGroupBox.Size = new System.Drawing.Size(498, 190);
            this.panelBetaTestersGroupBox.TabIndex = 0;
            // 
            // lblTester10
            // 
            this.lblTester10.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTester10.Location = new System.Drawing.Point(0, 350);
            this.lblTester10.Name = "lblTester10";
            this.lblTester10.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.lblTester10.Size = new System.Drawing.Size(482, 40);
            this.lblTester10.TabIndex = 17;
            this.lblTester10.Text = "David Honess, United Kingdom: A big thank you to everyone who has contributed to " +
                "this program!";
            // 
            // lblTester9
            // 
            this.lblTester9.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTester9.Location = new System.Drawing.Point(0, 320);
            this.lblTester9.Name = "lblTester9";
            this.lblTester9.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.lblTester9.Size = new System.Drawing.Size(482, 30);
            this.lblTester9.TabIndex = 16;
            this.lblTester9.Text = "Bryan Carter, United Kingdom: If it ain\'t broke, you haven\'t tested it long enoug" +
                "h!";
            // 
            // lblTester8
            // 
            this.lblTester8.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTester8.Location = new System.Drawing.Point(0, 250);
            this.lblTester8.Name = "lblTester8";
            this.lblTester8.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.lblTester8.Size = new System.Drawing.Size(482, 70);
            this.lblTester8.TabIndex = 15;
            this.lblTester8.Text = resources.GetString("lblTester8.Text");
            // 
            // lblTester7
            // 
            this.lblTester7.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTester7.Location = new System.Drawing.Point(0, 220);
            this.lblTester7.Name = "lblTester7";
            this.lblTester7.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.lblTester7.Size = new System.Drawing.Size(482, 30);
            this.lblTester7.TabIndex = 14;
            this.lblTester7.Text = "Kyle Welykholowa, Canada: Power to the peoples of the Age of Wonders!";
            // 
            // lblTester6
            // 
            this.lblTester6.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTester6.Location = new System.Drawing.Point(0, 180);
            this.lblTester6.Name = "lblTester6";
            this.lblTester6.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.lblTester6.Size = new System.Drawing.Size(482, 40);
            this.lblTester6.TabIndex = 13;
            this.lblTester6.Text = "Jaime González Peña, Mexico: Thank you very much for the wrapper, it works wondro" +
                "usly.";
            // 
            // lblTester5
            // 
            this.lblTester5.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTester5.Location = new System.Drawing.Point(0, 150);
            this.lblTester5.Name = "lblTester5";
            this.lblTester5.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.lblTester5.Size = new System.Drawing.Size(482, 30);
            this.lblTester5.TabIndex = 12;
            this.lblTester5.Text = "Frida Rodelo, Mexico: ¡A jugar!";
            // 
            // lblTester4
            // 
            this.lblTester4.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTester4.Location = new System.Drawing.Point(0, 110);
            this.lblTester4.Name = "lblTester4";
            this.lblTester4.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.lblTester4.Size = new System.Drawing.Size(482, 40);
            this.lblTester4.TabIndex = 11;
            this.lblTester4.Text = "Kasper Bergh, Denmark: You live and learn. At any rate, you live. Unless of cours" +
                "e you\'re the Undead!";
            // 
            // lblTester3
            // 
            this.lblTester3.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTester3.Location = new System.Drawing.Point(0, 70);
            this.lblTester3.Name = "lblTester3";
            this.lblTester3.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.lblTester3.Size = new System.Drawing.Size(482, 40);
            this.lblTester3.TabIndex = 10;
            this.lblTester3.Text = "Aggelon, Nancy, France: Thanks Dave: this soft is a dream for PBEM players ! Enjo" +
                "y it !";
            // 
            // lblTester2
            // 
            this.lblTester2.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTester2.Location = new System.Drawing.Point(0, 30);
            this.lblTester2.Name = "lblTester2";
            this.lblTester2.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.lblTester2.Size = new System.Drawing.Size(482, 40);
            this.lblTester2.TabIndex = 9;
            this.lblTester2.Text = "Nguyen Huy Hai, Vietnam: I hope you enjoy playing game with the Wrapper as much a" +
                "s I do.";
            // 
            // lblTester1
            // 
            this.lblTester1.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTester1.Location = new System.Drawing.Point(0, 0);
            this.lblTester1.Name = "lblTester1";
            this.lblTester1.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.lblTester1.Size = new System.Drawing.Size(482, 30);
            this.lblTester1.TabIndex = 8;
            this.lblTester1.Text = "Travis, United States: I implore you to reconsider!!";
            // 
            // groupAuthors
            // 
            this.groupAuthors.Controls.Add(this.lblAuthor2);
            this.groupAuthors.Controls.Add(this.lblAuthor1);
            this.groupAuthors.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupAuthors.Location = new System.Drawing.Point(5, 128);
            this.groupAuthors.Name = "groupAuthors";
            this.groupAuthors.Size = new System.Drawing.Size(504, 91);
            this.groupAuthors.TabIndex = 11;
            this.groupAuthors.TabStop = false;
            this.groupAuthors.Text = "Authors";
            // 
            // lblAuthor2
            // 
            this.lblAuthor2.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblAuthor2.Location = new System.Drawing.Point(3, 49);
            this.lblAuthor2.Name = "lblAuthor2";
            this.lblAuthor2.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.lblAuthor2.Size = new System.Drawing.Size(498, 33);
            this.lblAuthor2.TabIndex = 7;
            this.lblAuthor2.Text = "David N.T. Honess: Development, Programming";
            // 
            // lblAuthor1
            // 
            this.lblAuthor1.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblAuthor1.Location = new System.Drawing.Point(3, 16);
            this.lblAuthor1.Name = "lblAuthor1";
            this.lblAuthor1.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.lblAuthor1.Size = new System.Drawing.Size(498, 33);
            this.lblAuthor1.TabIndex = 6;
            this.lblAuthor1.Text = "Bryan S. Carter: Original concept, QA Testing";
            // 
            // lblNotice
            // 
            this.lblNotice.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblNotice.Location = new System.Drawing.Point(5, 45);
            this.lblNotice.Name = "lblNotice";
            this.lblNotice.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.lblNotice.Size = new System.Drawing.Size(504, 83);
            this.lblNotice.TabIndex = 10;
            this.lblNotice.Text = resources.GetString("lblNotice.Text");
            // 
            // panelTitle
            // 
            this.panelTitle.Controls.Add(this.lblVersion);
            this.panelTitle.Controls.Add(this.fbLink);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(5, 5);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(504, 40);
            this.panelTitle.TabIndex = 13;
            // 
            // lblVersion
            // 
            this.lblVersion.BackColor = System.Drawing.SystemColors.Highlight;
            this.lblVersion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVersion.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblVersion.Location = new System.Drawing.Point(0, 0);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.lblVersion.Size = new System.Drawing.Size(464, 40);
            this.lblVersion.TabIndex = 10;
            this.lblVersion.Text = "Age of Wonders Email Wrapper [{0}]";
            // 
            // fbLink
            // 
            this.fbLink.BackColor = System.Drawing.SystemColors.Window;
            this.fbLink.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.fbLink.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fbLink.Dock = System.Windows.Forms.DockStyle.Right;
            this.fbLink.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.fbLink.FlatAppearance.BorderSize = 5;
            this.fbLink.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fbLink.Image = ((System.Drawing.Image)(resources.GetObject("fbLink.Image")));
            this.fbLink.Location = new System.Drawing.Point(464, 0);
            this.fbLink.Name = "fbLink";
            this.fbLink.Size = new System.Drawing.Size(40, 40);
            this.fbLink.TabIndex = 11;
            this.fbLink.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.fbLink.Url = "http://www.facebook.com/pages/173302036046975";
            this.fbLink.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(5, 45);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.label1.Size = new System.Drawing.Size(414, 83);
            this.label1.TabIndex = 10;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Location = new System.Drawing.Point(3, 16);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.label4.Size = new System.Drawing.Size(408, 33);
            this.label4.TabIndex = 6;
            this.label4.Text = "Bryan S. Carter: Original concept, QA Testing";
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Location = new System.Drawing.Point(3, 49);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.label5.Size = new System.Drawing.Size(408, 33);
            this.label5.TabIndex = 7;
            this.label5.Text = "David N.T. Honess: Development, Programming";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 529);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelBottom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "Age of Wonders Email Wrapper";
            this.panelBottom.ResumeLayout(false);
            this.panelLocalMessageStore.ResumeLayout(false);
            this.panelMain.ResumeLayout(false);
            this.tabControlMain.ResumeLayout(false);
            this.tabAccounts.ResumeLayout(false);
            this.tabActivity.ResumeLayout(false);
            this.tabPreferences.ResumeLayout(false);
            this.tabAbout.ResumeLayout(false);
            this.panelAbout.ResumeLayout(false);
            this.groupBetaTesters.ResumeLayout(false);
            this.panelBetaTestersGroupBox.ResumeLayout(false);
            this.groupAuthors.ResumeLayout(false);
            this.panelTitle.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ImageList imageListIcons;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPreferences;
        private AowEmailWrapper.Controls.PreferencesConfig preferencesConfig;
        private System.Windows.Forms.TabPage tabAbout;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage tabAccounts;
        private AowEmailWrapper.Controls.AccountsConfig accountsConfig;
        private System.Windows.Forms.TabPage tabActivity;
        private AowEmailWrapper.Controls.ActivityListView activityListView;
        private System.Windows.Forms.Panel panelAbout;
        private System.Windows.Forms.GroupBox groupBetaTesters;
        private System.Windows.Forms.GroupBox groupAuthors;
        private System.Windows.Forms.Label lblAuthor2;
        private System.Windows.Forms.Label lblAuthor1;
        private System.Windows.Forms.Label lblNotice;
        private System.Windows.Forms.Panel panelBetaTestersGroupBox;
        private System.Windows.Forms.Label lblTester1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTester2;
        private System.Windows.Forms.Label lblTester6;
        private System.Windows.Forms.Label lblTester5;
        private System.Windows.Forms.Label lblTester4;
        private System.Windows.Forms.Label lblTester3;
        private System.Windows.Forms.Label lblTester10;
        private System.Windows.Forms.Label lblTester9;
        private System.Windows.Forms.Label lblTester8;
        private System.Windows.Forms.Label lblTester7;
        private System.Windows.Forms.Panel panelLocalMessageStore;
        private System.Windows.Forms.Button cmdSave;
        private System.Windows.Forms.Button cmdMessageStore;
        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Label lblVersion;
        private AowEmailWrapper.Controls.LinkButton fbLink;
    }
}

