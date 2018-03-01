
    partial class MainForm
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
            this.WelcomeLabel = new System.Windows.Forms.Label();
            this.InfoLabel = new System.Windows.Forms.Label();
            this.DiscordLabel = new System.Windows.Forms.Label();
            this.DiscordLinkLabel = new System.Windows.Forms.LinkLabel();
            this.DeathsCheckbox = new System.Windows.Forms.CheckBox();
            this.NotifyIfLabel = new System.Windows.Forms.Label();
            this.DeathsNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.FreeBagSlotsNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.FreeBagSlotsCheckbox = new System.Windows.Forms.CheckBox();
            this.LatencyNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.LatencyCheckbox = new System.Windows.Forms.CheckBox();
            this.StuckNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.StuckCheckbox = new System.Windows.Forms.CheckBox();
            this.LogoutButton = new System.Windows.Forms.Button();
            this.HealthPercentCheckbox = new System.Windows.Forms.CheckBox();
            this.HealthPercentTrackBar = new System.Windows.Forms.TrackBar();
            this.DiedCheckbox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.DeathsNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FreeBagSlotsNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LatencyNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StuckNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HealthPercentTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // WelcomeLabel
            // 
            this.WelcomeLabel.AutoSize = true;
            this.WelcomeLabel.Location = new System.Drawing.Point(163, 18);
            this.WelcomeLabel.Name = "WelcomeLabel";
            this.WelcomeLabel.Size = new System.Drawing.Size(143, 13);
            this.WelcomeLabel.TabIndex = 0;
            this.WelcomeLabel.Text = "Welcome to Remote Control!";
            // 
            // InfoLabel
            // 
            this.InfoLabel.AutoSize = true;
            this.InfoLabel.Location = new System.Drawing.Point(12, 45);
            this.InfoLabel.Name = "InfoLabel";
            this.InfoLabel.Size = new System.Drawing.Size(466, 13);
            this.InfoLabel.TabIndex = 1;
            this.InfoLabel.Text = "Sliders below are used to set up push notifications to mobile device associated w" +
    "ith your account.";
            // 
            // DiscordLabel
            // 
            this.DiscordLabel.AutoSize = true;
            this.DiscordLabel.Location = new System.Drawing.Point(12, 282);
            this.DiscordLabel.Name = "DiscordLabel";
            this.DiscordLabel.Size = new System.Drawing.Size(46, 13);
            this.DiscordLabel.TabIndex = 2;
            this.DiscordLabel.Text = "Discord:";
            // 
            // DiscordLinkLabel
            // 
            this.DiscordLinkLabel.AutoSize = true;
            this.DiscordLinkLabel.Location = new System.Drawing.Point(56, 282);
            this.DiscordLinkLabel.Name = "DiscordLinkLabel";
            this.DiscordLinkLabel.Size = new System.Drawing.Size(134, 13);
            this.DiscordLinkLabel.TabIndex = 3;
            this.DiscordLinkLabel.TabStop = true;
            this.DiscordLinkLabel.Text = "https://discord.gg/z852r2x";
            // 
            // DeathsCheckbox
            // 
            this.DeathsCheckbox.AutoSize = true;
            this.DeathsCheckbox.Location = new System.Drawing.Point(125, 125);
            this.DeathsCheckbox.Name = "DeathsCheckbox";
            this.DeathsCheckbox.Size = new System.Drawing.Size(162, 17);
            this.DeathsCheckbox.TabIndex = 4;
            this.DeathsCheckbox.Text = "Death amount is higher than:";
            this.DeathsCheckbox.UseVisualStyleBackColor = true;
            this.DeathsCheckbox.CheckedChanged += new System.EventHandler(this.DeathsCheckbox_CheckedChanged);
            // 
            // NotifyIfLabel
            // 
            this.NotifyIfLabel.AutoSize = true;
            this.NotifyIfLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NotifyIfLabel.Location = new System.Drawing.Point(213, 77);
            this.NotifyIfLabel.Name = "NotifyIfLabel";
            this.NotifyIfLabel.Size = new System.Drawing.Size(45, 13);
            this.NotifyIfLabel.TabIndex = 5;
            this.NotifyIfLabel.Text = "Notify if:";
            // 
            // DeathsNumericUpDown
            // 
            this.DeathsNumericUpDown.Location = new System.Drawing.Point(285, 124);
            this.DeathsNumericUpDown.Name = "DeathsNumericUpDown";
            this.DeathsNumericUpDown.Size = new System.Drawing.Size(43, 20);
            this.DeathsNumericUpDown.TabIndex = 6;
            this.DeathsNumericUpDown.ValueChanged += new System.EventHandler(this.DeathsNumericUpDown_ValueChanged);
            // 
            // FreeBagSlotsNumericUpDown
            // 
            this.FreeBagSlotsNumericUpDown.Location = new System.Drawing.Point(317, 150);
            this.FreeBagSlotsNumericUpDown.Name = "FreeBagSlotsNumericUpDown";
            this.FreeBagSlotsNumericUpDown.Size = new System.Drawing.Size(43, 20);
            this.FreeBagSlotsNumericUpDown.TabIndex = 8;
            this.FreeBagSlotsNumericUpDown.ValueChanged += new System.EventHandler(this.FreeBagSlotsNumericUpDown_ValueChanged);
            // 
            // FreeBagSlotsCheckbox
            // 
            this.FreeBagSlotsCheckbox.AutoSize = true;
            this.FreeBagSlotsCheckbox.Location = new System.Drawing.Point(125, 151);
            this.FreeBagSlotsCheckbox.Name = "FreeBagSlotsCheckbox";
            this.FreeBagSlotsCheckbox.Size = new System.Drawing.Size(195, 17);
            this.FreeBagSlotsCheckbox.TabIndex = 7;
            this.FreeBagSlotsCheckbox.Text = "Free bag slots amount is lower than:";
            this.FreeBagSlotsCheckbox.UseVisualStyleBackColor = true;
            this.FreeBagSlotsCheckbox.CheckedChanged += new System.EventHandler(this.FreeBagSlotsCheckbox_CheckedChanged);
            // 
            // LatencyNumericUpDown
            // 
            this.LatencyNumericUpDown.Location = new System.Drawing.Point(255, 174);
            this.LatencyNumericUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.LatencyNumericUpDown.Name = "LatencyNumericUpDown";
            this.LatencyNumericUpDown.Size = new System.Drawing.Size(43, 20);
            this.LatencyNumericUpDown.TabIndex = 10;
            this.LatencyNumericUpDown.ValueChanged += new System.EventHandler(this.LatencyNumericUpDown_ValueChanged);
            // 
            // LatencyCheckbox
            // 
            this.LatencyCheckbox.AutoSize = true;
            this.LatencyCheckbox.Location = new System.Drawing.Point(125, 175);
            this.LatencyCheckbox.Name = "LatencyCheckbox";
            this.LatencyCheckbox.Size = new System.Drawing.Size(133, 17);
            this.LatencyCheckbox.TabIndex = 9;
            this.LatencyCheckbox.Text = "Latency is higher than:";
            this.LatencyCheckbox.UseVisualStyleBackColor = true;
            this.LatencyCheckbox.CheckedChanged += new System.EventHandler(this.LatencyCheckbox_CheckedChanged);
            // 
            // StuckNumericUpDown
            // 
            this.StuckNumericUpDown.Location = new System.Drawing.Point(283, 199);
            this.StuckNumericUpDown.Name = "StuckNumericUpDown";
            this.StuckNumericUpDown.Size = new System.Drawing.Size(43, 20);
            this.StuckNumericUpDown.TabIndex = 12;
            this.StuckNumericUpDown.ValueChanged += new System.EventHandler(this.StuckNumericUpDown_ValueChanged);
            // 
            // StuckCheckbox
            // 
            this.StuckCheckbox.AutoSize = true;
            this.StuckCheckbox.Location = new System.Drawing.Point(125, 200);
            this.StuckCheckbox.Name = "StuckCheckbox";
            this.StuckCheckbox.Size = new System.Drawing.Size(161, 17);
            this.StuckCheckbox.TabIndex = 11;
            this.StuckCheckbox.Text = "Stuck amount is higher than:";
            this.StuckCheckbox.UseVisualStyleBackColor = true;
            this.StuckCheckbox.CheckedChanged += new System.EventHandler(this.StuckCheckbox_CheckedChanged);
            // 
            // LogoutButton
            // 
            this.LogoutButton.Location = new System.Drawing.Point(403, 269);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(75, 23);
            this.LogoutButton.TabIndex = 13;
            this.LogoutButton.Text = "Logout";
            this.LogoutButton.UseVisualStyleBackColor = true;
            this.LogoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // HealthPercentCheckbox
            // 
            this.HealthPercentCheckbox.AutoSize = true;
            this.HealthPercentCheckbox.Location = new System.Drawing.Point(125, 226);
            this.HealthPercentCheckbox.Name = "HealthPercentCheckbox";
            this.HealthPercentCheckbox.Size = new System.Drawing.Size(145, 17);
            this.HealthPercentCheckbox.TabIndex = 14;
            this.HealthPercentCheckbox.Text = "HP percent is lower than:";
            this.HealthPercentCheckbox.UseVisualStyleBackColor = true;
            this.HealthPercentCheckbox.CheckedChanged += new System.EventHandler(this.HealthPercentCheckbox_CheckedChanged);
            // 
            // HealthPercentTrackBar
            // 
            this.HealthPercentTrackBar.LargeChange = 10;
            this.HealthPercentTrackBar.Location = new System.Drawing.Point(265, 226);
            this.HealthPercentTrackBar.Maximum = 100;
            this.HealthPercentTrackBar.Name = "HealthPercentTrackBar";
            this.HealthPercentTrackBar.Size = new System.Drawing.Size(115, 45);
            this.HealthPercentTrackBar.SmallChange = 5;
            this.HealthPercentTrackBar.TabIndex = 15;
            this.HealthPercentTrackBar.TickFrequency = 5;
            this.HealthPercentTrackBar.Scroll += new System.EventHandler(this.HealthPercentTrackBar_Scroll);
            // 
            // DiedCheckbox
            // 
            this.DiedCheckbox.AutoSize = true;
            this.DiedCheckbox.Location = new System.Drawing.Point(210, 100);
            this.DiedCheckbox.Name = "DiedCheckbox";
            this.DiedCheckbox.Size = new System.Drawing.Size(48, 17);
            this.DiedCheckbox.TabIndex = 16;
            this.DiedCheckbox.Text = "Died";
            this.DiedCheckbox.UseVisualStyleBackColor = true;
            this.DiedCheckbox.CheckedChanged += new System.EventHandler(this.DiedCheckbox_CheckedChanged);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 304);
            this.Controls.Add(this.DiedCheckbox);
            this.Controls.Add(this.HealthPercentTrackBar);
            this.Controls.Add(this.HealthPercentCheckbox);
            this.Controls.Add(this.LogoutButton);
            this.Controls.Add(this.StuckNumericUpDown);
            this.Controls.Add(this.StuckCheckbox);
            this.Controls.Add(this.LatencyNumericUpDown);
            this.Controls.Add(this.LatencyCheckbox);
            this.Controls.Add(this.FreeBagSlotsNumericUpDown);
            this.Controls.Add(this.FreeBagSlotsCheckbox);
            this.Controls.Add(this.DeathsNumericUpDown);
            this.Controls.Add(this.NotifyIfLabel);
            this.Controls.Add(this.DeathsCheckbox);
            this.Controls.Add(this.DiscordLinkLabel);
            this.Controls.Add(this.DiscordLabel);
            this.Controls.Add(this.InfoLabel);
            this.Controls.Add(this.WelcomeLabel);
            this.Name = "Main";
            this.Text = "Remote Control";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DeathsNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FreeBagSlotsNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LatencyNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StuckNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HealthPercentTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label WelcomeLabel;
        private System.Windows.Forms.Label InfoLabel;
        private System.Windows.Forms.Label DiscordLabel;
        private System.Windows.Forms.LinkLabel DiscordLinkLabel;
        private System.Windows.Forms.CheckBox DeathsCheckbox;
        private System.Windows.Forms.Label NotifyIfLabel;
        private System.Windows.Forms.NumericUpDown DeathsNumericUpDown;
        private System.Windows.Forms.NumericUpDown FreeBagSlotsNumericUpDown;
        private System.Windows.Forms.CheckBox FreeBagSlotsCheckbox;
        private System.Windows.Forms.NumericUpDown LatencyNumericUpDown;
        private System.Windows.Forms.CheckBox LatencyCheckbox;
        private System.Windows.Forms.NumericUpDown StuckNumericUpDown;
        private System.Windows.Forms.CheckBox StuckCheckbox;
        private System.Windows.Forms.Button LogoutButton;
        private System.Windows.Forms.CheckBox HealthPercentCheckbox;
        private System.Windows.Forms.TrackBar HealthPercentTrackBar;
        private System.Windows.Forms.CheckBox DiedCheckbox;
    }
