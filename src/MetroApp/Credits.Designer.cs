namespace Metro_App
{
    partial class Credits
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.titleLabel = new System.Windows.Forms.Label();
            this.subtitleLabel = new System.Windows.Forms.Label();
            this.cardPanel = new System.Windows.Forms.Panel();
            this.devNameLabel = new System.Windows.Forms.Label();
            this.roleLabel = new System.Windows.Forms.Label();
            this.emailTagLabel = new System.Windows.Forms.Label();
            this.emailLinkLabel = new System.Windows.Forms.LinkLabel();
            this.githubTagLabel = new System.Windows.Forms.Label();
            this.githubLinkLabel = new System.Windows.Forms.LinkLabel();
            this.versionLabel = new System.Windows.Forms.Label();
            this.contributorTagLabel = new System.Windows.Forms.Label();
            this.contributorLinkLabel = new System.Windows.Forms.LinkLabel();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.cardPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.BackColor = System.Drawing.Color.Transparent;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(130, 45);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(506, 54);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Metro Navigation System";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // subtitleLabel
            // 
            this.subtitleLabel.AutoSize = true;
            this.subtitleLabel.BackColor = System.Drawing.Color.Transparent;
            this.subtitleLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtitleLabel.ForeColor = System.Drawing.Color.LightGray;
            this.subtitleLabel.Location = new System.Drawing.Point(240, 105);
            this.subtitleLabel.Name = "subtitleLabel";
            this.subtitleLabel.Size = new System.Drawing.Size(288, 28);
            this.subtitleLabel.TabIndex = 1;
            this.subtitleLabel.Text = "Developer Credits & Information";
            this.subtitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cardPanel
            // 
            this.cardPanel.BackColor = System.Drawing.Color.FromArgb(15, 25, 45);
            this.cardPanel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cardPanel.Controls.Add(this.devNameLabel);
            this.cardPanel.Controls.Add(this.roleLabel);
            this.cardPanel.Controls.Add(this.emailTagLabel);
            this.cardPanel.Controls.Add(this.emailLinkLabel);
            this.cardPanel.Controls.Add(this.githubTagLabel);
            this.cardPanel.Controls.Add(this.githubLinkLabel);
            this.cardPanel.Controls.Add(this.versionLabel);
            this.cardPanel.Location = new System.Drawing.Point(139, 160);
            this.cardPanel.Name = "cardPanel";
            this.cardPanel.Size = new System.Drawing.Size(500, 240);
            this.cardPanel.TabIndex = 2;
            // 
            // devNameLabel
            // 
            this.devNameLabel.AutoSize = true;
            this.devNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.devNameLabel.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.devNameLabel.ForeColor = System.Drawing.Color.White;
            this.devNameLabel.Location = new System.Drawing.Point(25, 20);
            this.devNameLabel.Name = "devNameLabel";
            this.devNameLabel.Size = new System.Drawing.Size(229, 38);
            this.devNameLabel.TabIndex = 0;
            this.devNameLabel.Text = "Mohammad Sufiyan Aasim";
            // 
            // roleLabel
            // 
            this.roleLabel.AutoSize = true;
            this.roleLabel.BackColor = System.Drawing.Color.Transparent;
            this.roleLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(200)))));
            this.roleLabel.Location = new System.Drawing.Point(26, 60);
            this.roleLabel.Name = "roleLabel";
            this.roleLabel.Size = new System.Drawing.Size(262, 23);
            this.roleLabel.TabIndex = 1;
            this.roleLabel.Text = "Software Engineer, UI Designer & System Architect";
            this.roleLabel.UseMnemonic = false;
            // 
            // emailTagLabel
            // 
            this.emailTagLabel.AutoSize = true;
            this.emailTagLabel.BackColor = System.Drawing.Color.Transparent;
            this.emailTagLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTagLabel.ForeColor = System.Drawing.Color.LightGray;
            this.emailTagLabel.Location = new System.Drawing.Point(25, 105);
            this.emailTagLabel.Name = "emailTagLabel";
            this.emailTagLabel.Size = new System.Drawing.Size(64, 25);
            this.emailTagLabel.TabIndex = 2;
            this.emailTagLabel.Text = "Email:";
            // 
            // emailLinkLabel
            // 
            this.emailLinkLabel.AutoSize = true;
            this.emailLinkLabel.BackColor = System.Drawing.Color.Transparent;
            this.emailLinkLabel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLinkLabel.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(255)))));
            this.emailLinkLabel.Location = new System.Drawing.Point(115, 105);
            this.emailLinkLabel.Name = "emailLinkLabel";
            this.emailLinkLabel.Size = new System.Drawing.Size(232, 25);
            this.emailLinkLabel.TabIndex = 3;
            this.emailLinkLabel.TabStop = true;
            this.emailLinkLabel.Text = "sufiyanaasim@outlook.com";
            this.emailLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkEmail_LinkClicked);
            // 
            // githubTagLabel
            // 
            this.githubTagLabel.AutoSize = true;
            this.githubTagLabel.BackColor = System.Drawing.Color.Transparent;
            this.githubTagLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.githubTagLabel.ForeColor = System.Drawing.Color.LightGray;
            this.githubTagLabel.Location = new System.Drawing.Point(25, 145);
            this.githubTagLabel.Name = "githubTagLabel";
            this.githubTagLabel.Size = new System.Drawing.Size(78, 25);
            this.githubTagLabel.TabIndex = 4;
            this.githubTagLabel.Text = "GitHub:";
            // 
            // githubLinkLabel
            // 
            this.githubLinkLabel.AutoSize = true;
            this.githubLinkLabel.BackColor = System.Drawing.Color.Transparent;
            this.githubLinkLabel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.githubLinkLabel.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(255)))));
            this.githubLinkLabel.Location = new System.Drawing.Point(115, 145);
            this.githubLinkLabel.Name = "githubLinkLabel";
            this.githubLinkLabel.Size = new System.Drawing.Size(117, 25);
            this.githubLinkLabel.TabIndex = 5;
            this.githubLinkLabel.TabStop = true;
            this.githubLinkLabel.Text = "SufiyanAasim";
            this.githubLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkGithub_LinkClicked);
            // 
            // versionLabel
            // 
            this.versionLabel.AutoSize = true;
            this.versionLabel.BackColor = System.Drawing.Color.Transparent;
            this.versionLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.versionLabel.ForeColor = System.Drawing.Color.Gray;
            this.versionLabel.Location = new System.Drawing.Point(26, 195);
            this.versionLabel.Name = "versionLabel";
            this.versionLabel.Size = new System.Drawing.Size(127, 20);
            this.versionLabel.TabIndex = 6;
            this.versionLabel.Text = "App Version: 2.0.0";
            //
            // contributorTagLabel
            //
            this.contributorTagLabel.AutoSize = true;
            this.contributorTagLabel.BackColor = System.Drawing.Color.Transparent;
            this.contributorTagLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contributorTagLabel.ForeColor = System.Drawing.Color.LightGray;
            this.contributorTagLabel.Location = new System.Drawing.Point(139, 412);
            this.contributorTagLabel.Name = "contributorTagLabel";
            this.contributorTagLabel.Size = new System.Drawing.Size(160, 21);
            this.contributorTagLabel.TabIndex = 5;
            this.contributorTagLabel.Text = "Front-end Development:";
            //
            // contributorLinkLabel
            //
            this.contributorLinkLabel.AutoSize = true;
            this.contributorLinkLabel.BackColor = System.Drawing.Color.Transparent;
            this.contributorLinkLabel.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contributorLinkLabel.ForeColor = System.Drawing.Color.White;
            this.contributorLinkLabel.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(255)))));
            this.contributorLinkLabel.Location = new System.Drawing.Point(139, 434);
            this.contributorLinkLabel.Name = "contributorLinkLabel";
            this.contributorLinkLabel.Size = new System.Drawing.Size(260, 21);
            this.contributorLinkLabel.TabIndex = 6;
            this.contributorLinkLabel.TabStop = true;
            this.contributorLinkLabel.Text = "Fahad Bin Nasir (fahadabbasi17025@gmail.com)";
            this.contributorLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkContributorEmail_LinkClicked);
            //
            // buttonBack
            // 
            this.buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBack.BackColor = System.Drawing.Color.Transparent;
            this.buttonBack.FlatAppearance.BorderSize = 0;
            this.buttonBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonBack.BackgroundImage = global::Metro_App.Properties.Resources.btn_back;
            this.buttonBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBack.Location = new System.Drawing.Point(60, 500);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(120, 40);
            this.buttonBack.TabIndex = 3;
            this.buttonBack.Text = "";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNext.BackColor = System.Drawing.Color.Transparent;
            this.buttonNext.FlatAppearance.BorderSize = 0;
            this.buttonNext.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonNext.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonNext.BackgroundImage = global::Metro_App.Properties.Resources.btn_next;
            this.buttonNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonNext.Location = new System.Drawing.Point(500, 500);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(120, 40);
            this.buttonNext.TabIndex = 4;
            this.buttonNext.Text = "";
            this.buttonNext.UseVisualStyleBackColor = false;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // Credits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Metro_App.Properties.Resources.developer_credits_bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(778, 549);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.contributorLinkLabel);
            this.Controls.Add(this.contributorTagLabel);
            this.Controls.Add(this.cardPanel);
            this.Controls.Add(this.subtitleLabel);
            this.Controls.Add(this.titleLabel);
            this.Name = "Credits";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Developer Credits";
            this.Load += new System.EventHandler(this.Credits_Load);
            this.cardPanel.ResumeLayout(false);
            this.cardPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label subtitleLabel;
        private System.Windows.Forms.Panel cardPanel;
        private System.Windows.Forms.Label devNameLabel;
        private System.Windows.Forms.Label roleLabel;
        private System.Windows.Forms.Label emailTagLabel;
        private System.Windows.Forms.LinkLabel emailLinkLabel;
        private System.Windows.Forms.Label githubTagLabel;
        private System.Windows.Forms.LinkLabel githubLinkLabel;
        private System.Windows.Forms.Label versionLabel;
        private System.Windows.Forms.Label contributorTagLabel;
        private System.Windows.Forms.LinkLabel contributorLinkLabel;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonNext;
    }
}
