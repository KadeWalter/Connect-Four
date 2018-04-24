namespace Connect_Four
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.settingsTitle = new System.Windows.Forms.Label();
            this.sizeLabel = new System.Windows.Forms.Label();
            this.sizeDropDown = new System.Windows.Forms.ComboBox();
            this.timeLabel = new System.Windows.Forms.Label();
            this.timeDropDown = new System.Windows.Forms.ComboBox();
            this.SettingSubBtn = new System.Windows.Forms.Button();
            this.p1_label = new System.Windows.Forms.Label();
            this.p1Comp = new System.Windows.Forms.Button();
            this.p1Human = new System.Windows.Forms.Button();
            this.ai_one_name = new System.Windows.Forms.Label();
            this.p2_label = new System.Windows.Forms.Label();
            this.p2Human = new System.Windows.Forms.Button();
            this.p2Comp = new System.Windows.Forms.Button();
            this.ai_two_name = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // settingsTitle
            // 
            this.settingsTitle.AutoSize = true;
            this.settingsTitle.Font = new System.Drawing.Font("Tempus Sans ITC", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingsTitle.ForeColor = System.Drawing.SystemColors.Highlight;
            this.settingsTitle.Location = new System.Drawing.Point(86, 48);
            this.settingsTitle.Name = "settingsTitle";
            this.settingsTitle.Size = new System.Drawing.Size(142, 46);
            this.settingsTitle.TabIndex = 0;
            this.settingsTitle.Text = "Settings";
            // 
            // sizeLabel
            // 
            this.sizeLabel.AutoSize = true;
            this.sizeLabel.Font = new System.Drawing.Font("Tempus Sans ITC", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sizeLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.sizeLabel.Location = new System.Drawing.Point(22, 349);
            this.sizeLabel.Name = "sizeLabel";
            this.sizeLabel.Size = new System.Drawing.Size(117, 27);
            this.sizeLabel.TabIndex = 1;
            this.sizeLabel.Text = "Game Size:";
            // 
            // sizeDropDown
            // 
            this.sizeDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sizeDropDown.FormattingEnabled = true;
            this.sizeDropDown.Items.AddRange(new object[] {
            "Small",
            "Standard",
            "Large"});
            this.sizeDropDown.Location = new System.Drawing.Point(145, 355);
            this.sizeDropDown.Name = "sizeDropDown";
            this.sizeDropDown.Size = new System.Drawing.Size(133, 21);
            this.sizeDropDown.TabIndex = 2;
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Font = new System.Drawing.Font("Tempus Sans ITC", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.timeLabel.Location = new System.Drawing.Point(17, 392);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(122, 27);
            this.timeLabel.TabIndex = 3;
            this.timeLabel.Text = "Time Limit:";
            // 
            // timeDropDown
            // 
            this.timeDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.timeDropDown.FormattingEnabled = true;
            this.timeDropDown.Items.AddRange(new object[] {
            "No Limit",
            "5 Sec.",
            "10 Sec.",
            "15 Sec.",
            "20 Sec.",
            "25 Sec.",
            "30 Sec."});
            this.timeDropDown.Location = new System.Drawing.Point(145, 398);
            this.timeDropDown.Name = "timeDropDown";
            this.timeDropDown.Size = new System.Drawing.Size(133, 21);
            this.timeDropDown.TabIndex = 4;
            // 
            // SettingSubBtn
            // 
            this.SettingSubBtn.Location = new System.Drawing.Point(145, 460);
            this.SettingSubBtn.Name = "SettingSubBtn";
            this.SettingSubBtn.Size = new System.Drawing.Size(75, 23);
            this.SettingSubBtn.TabIndex = 5;
            this.SettingSubBtn.Text = "Submit";
            this.SettingSubBtn.UseVisualStyleBackColor = true;
            this.SettingSubBtn.Click += new System.EventHandler(this.SettingSubBtn_Click);
            // 
            // p1_label
            // 
            this.p1_label.AutoSize = true;
            this.p1_label.Font = new System.Drawing.Font("Tempus Sans ITC", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p1_label.ForeColor = System.Drawing.SystemColors.Highlight;
            this.p1_label.Location = new System.Drawing.Point(17, 143);
            this.p1_label.Name = "p1_label";
            this.p1_label.Size = new System.Drawing.Size(93, 27);
            this.p1_label.TabIndex = 6;
            this.p1_label.Text = "Player 1:";
            // 
            // p1Comp
            // 
            this.p1Comp.Location = new System.Drawing.Point(245, 147);
            this.p1Comp.Name = "p1Comp";
            this.p1Comp.Size = new System.Drawing.Size(75, 23);
            this.p1Comp.TabIndex = 7;
            this.p1Comp.Text = "Computer";
            this.p1Comp.UseVisualStyleBackColor = true;
            this.p1Comp.Click += new System.EventHandler(this.p1Comp_Click);
            // 
            // p1Human
            // 
            this.p1Human.Location = new System.Drawing.Point(143, 147);
            this.p1Human.Name = "p1Human";
            this.p1Human.Size = new System.Drawing.Size(75, 23);
            this.p1Human.TabIndex = 8;
            this.p1Human.Text = "Human";
            this.p1Human.UseVisualStyleBackColor = true;
            this.p1Human.Click += new System.EventHandler(this.p1Human_Click);
            // 
            // ai_one_name
            // 
            this.ai_one_name.AutoSize = true;
            this.ai_one_name.Location = new System.Drawing.Point(140, 189);
            this.ai_one_name.Name = "ai_one_name";
            this.ai_one_name.Size = new System.Drawing.Size(0, 13);
            this.ai_one_name.TabIndex = 9;
            // 
            // p2_label
            // 
            this.p2_label.AutoSize = true;
            this.p2_label.Font = new System.Drawing.Font("Tempus Sans ITC", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p2_label.ForeColor = System.Drawing.SystemColors.Highlight;
            this.p2_label.Location = new System.Drawing.Point(17, 231);
            this.p2_label.Name = "p2_label";
            this.p2_label.Size = new System.Drawing.Size(97, 27);
            this.p2_label.TabIndex = 10;
            this.p2_label.Text = "Player 2:";
            // 
            // p2Human
            // 
            this.p2Human.Location = new System.Drawing.Point(143, 235);
            this.p2Human.Name = "p2Human";
            this.p2Human.Size = new System.Drawing.Size(75, 23);
            this.p2Human.TabIndex = 11;
            this.p2Human.Text = "Human";
            this.p2Human.UseVisualStyleBackColor = true;
            this.p2Human.Click += new System.EventHandler(this.p2Human_Click);
            // 
            // p2Comp
            // 
            this.p2Comp.Location = new System.Drawing.Point(245, 235);
            this.p2Comp.Name = "p2Comp";
            this.p2Comp.Size = new System.Drawing.Size(75, 23);
            this.p2Comp.TabIndex = 12;
            this.p2Comp.Text = "Computer";
            this.p2Comp.UseVisualStyleBackColor = true;
            this.p2Comp.Click += new System.EventHandler(this.p2Comp_Click);
            // 
            // ai_two_name
            // 
            this.ai_two_name.AutoSize = true;
            this.ai_two_name.Location = new System.Drawing.Point(142, 275);
            this.ai_two_name.Name = "ai_two_name";
            this.ai_two_name.Size = new System.Drawing.Size(0, 13);
            this.ai_two_name.TabIndex = 13;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(361, 516);
            this.Controls.Add(this.ai_two_name);
            this.Controls.Add(this.p2Comp);
            this.Controls.Add(this.p2Human);
            this.Controls.Add(this.p2_label);
            this.Controls.Add(this.ai_one_name);
            this.Controls.Add(this.p1Human);
            this.Controls.Add(this.p1Comp);
            this.Controls.Add(this.p1_label);
            this.Controls.Add(this.SettingSubBtn);
            this.Controls.Add(this.timeDropDown);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.sizeDropDown);
            this.Controls.Add(this.sizeLabel);
            this.Controls.Add(this.settingsTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Connect Four";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label settingsTitle;
        private System.Windows.Forms.Label sizeLabel;
        private System.Windows.Forms.ComboBox sizeDropDown;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.ComboBox timeDropDown;
        private System.Windows.Forms.Button SettingSubBtn;
        private System.Windows.Forms.Label p1_label;
        private System.Windows.Forms.Button p1Comp;
        private System.Windows.Forms.Button p1Human;
        private System.Windows.Forms.Label ai_one_name;
        private System.Windows.Forms.Label p2_label;
        private System.Windows.Forms.Button p2Human;
        private System.Windows.Forms.Button p2Comp;
        private System.Windows.Forms.Label ai_two_name;
    }
}