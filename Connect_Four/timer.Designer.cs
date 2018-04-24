namespace Connect_Four
{
    partial class timer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(timer));
            this.label1 = new System.Windows.Forms.Label();
            this.timeDropDown = new System.Windows.Forms.ComboBox();
            this.timerSub_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tempus Sans ITC", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(24, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select a time limit";
            // 
            // timeDropDown
            // 
            this.timeDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.timeDropDown.FormattingEnabled = true;
            this.timeDropDown.Items.AddRange(new object[] {
            "No Limit",
            "5 sec",
            "10 sec",
            "15 sec",
            "20 sec",
            "25 sec",
            "30 sec"});
            this.timeDropDown.Location = new System.Drawing.Point(82, 102);
            this.timeDropDown.Name = "timeDropDown";
            this.timeDropDown.Size = new System.Drawing.Size(132, 21);
            this.timeDropDown.TabIndex = 2;
            // 
            // timerSub_button
            // 
            this.timerSub_button.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timerSub_button.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.timerSub_button.Location = new System.Drawing.Point(82, 155);
            this.timerSub_button.Name = "timerSub_button";
            this.timerSub_button.Size = new System.Drawing.Size(132, 33);
            this.timerSub_button.TabIndex = 3;
            this.timerSub_button.Text = "Submit";
            this.timerSub_button.UseVisualStyleBackColor = true;
            this.timerSub_button.Click += new System.EventHandler(this.timerSub_button_Click);
            // 
            // timer
            // 
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.timerSub_button);
            this.Controls.Add(this.timeDropDown);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "timer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Connect Four";
            this.Load += new System.EventHandler(this.size_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label size_label;
        private System.Windows.Forms.Button smallSize_button;
        private System.Windows.Forms.Button standardSize_button;
        private System.Windows.Forms.Button largeSize_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox timeDropDown;
        private System.Windows.Forms.Button timerSub_button;
    }
}