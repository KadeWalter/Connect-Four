namespace Connect_Four
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.MainMenu_Label = new System.Windows.Forms.Label();
            this.playGame = new System.Windows.Forms.Button();
            this.Exit_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MainMenu_Label
            // 
            this.MainMenu_Label.AutoSize = true;
            this.MainMenu_Label.Font = new System.Drawing.Font("Tempus Sans ITC", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenu_Label.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.MainMenu_Label.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.MainMenu_Label.Location = new System.Drawing.Point(68, 64);
            this.MainMenu_Label.Name = "MainMenu_Label";
            this.MainMenu_Label.Size = new System.Drawing.Size(355, 84);
            this.MainMenu_Label.TabIndex = 0;
            this.MainMenu_Label.Text = "Main Menu";
            this.MainMenu_Label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // playGame
            // 
            this.playGame.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playGame.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.playGame.Location = new System.Drawing.Point(124, 226);
            this.playGame.Name = "playGame";
            this.playGame.Size = new System.Drawing.Size(209, 47);
            this.playGame.TabIndex = 2;
            this.playGame.Text = "Play Game";
            this.playGame.UseVisualStyleBackColor = true;
            this.playGame.Click += new System.EventHandler(this.playGame_click);
            // 
            // Exit_button
            // 
            this.Exit_button.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit_button.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Exit_button.Location = new System.Drawing.Point(124, 321);
            this.Exit_button.Name = "Exit_button";
            this.Exit_button.Size = new System.Drawing.Size(209, 47);
            this.Exit_button.TabIndex = 3;
            this.Exit_button.Text = "Exit Game";
            this.Exit_button.UseVisualStyleBackColor = true;
            this.Exit_button.Click += new System.EventHandler(this.Exit_click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(478, 478);
            this.Controls.Add(this.Exit_button);
            this.Controls.Add(this.playGame);
            this.Controls.Add(this.MainMenu_Label);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Connect Four";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainMenu_FormClosing);
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MainMenu_Label;
        private System.Windows.Forms.Button playGame;
        private System.Windows.Forms.Button Exit_button;
    }
}

