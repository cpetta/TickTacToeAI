namespace ticTacToe
{
    partial class mainForm
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
            this.firstLeftButton = new System.Windows.Forms.Button();
            this.firstMiddleButton = new System.Windows.Forms.Button();
            this.firstRightButton = new System.Windows.Forms.Button();
            this.secondLeftButton = new System.Windows.Forms.Button();
            this.secondMiddleButton = new System.Windows.Forms.Button();
            this.secondRightButton = new System.Windows.Forms.Button();
            this.thirdLeftButton = new System.Windows.Forms.Button();
            this.thirdMiddleButton = new System.Windows.Forms.Button();
            this.thirdRightButton = new System.Windows.Forms.Button();
            this.aiButton = new System.Windows.Forms.Button();
            this.WinnerLabel = new System.Windows.Forms.Label();
            this.reset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // firstLeftButton
            // 
            this.firstLeftButton.Location = new System.Drawing.Point(29, 46);
            this.firstLeftButton.Name = "firstLeftButton";
            this.firstLeftButton.Size = new System.Drawing.Size(71, 78);
            this.firstLeftButton.TabIndex = 0;
            this.firstLeftButton.Text = "firstLeft";
            this.firstLeftButton.UseVisualStyleBackColor = true;
            this.firstLeftButton.Click += new System.EventHandler(this.button_Click);
            // 
            // firstMiddleButton
            // 
            this.firstMiddleButton.Location = new System.Drawing.Point(121, 46);
            this.firstMiddleButton.Name = "firstMiddleButton";
            this.firstMiddleButton.Size = new System.Drawing.Size(71, 78);
            this.firstMiddleButton.TabIndex = 1;
            this.firstMiddleButton.Text = "firstMiddle";
            this.firstMiddleButton.UseVisualStyleBackColor = true;
            this.firstMiddleButton.Click += new System.EventHandler(this.button_Click);
            // 
            // firstRightButton
            // 
            this.firstRightButton.Location = new System.Drawing.Point(211, 46);
            this.firstRightButton.Name = "firstRightButton";
            this.firstRightButton.Size = new System.Drawing.Size(71, 78);
            this.firstRightButton.TabIndex = 2;
            this.firstRightButton.Text = "firstRight";
            this.firstRightButton.UseVisualStyleBackColor = true;
            this.firstRightButton.Click += new System.EventHandler(this.button_Click);
            // 
            // secondLeftButton
            // 
            this.secondLeftButton.Location = new System.Drawing.Point(29, 144);
            this.secondLeftButton.Name = "secondLeftButton";
            this.secondLeftButton.Size = new System.Drawing.Size(71, 78);
            this.secondLeftButton.TabIndex = 3;
            this.secondLeftButton.Text = "secondLeft";
            this.secondLeftButton.UseVisualStyleBackColor = true;
            this.secondLeftButton.Click += new System.EventHandler(this.button_Click);
            // 
            // secondMiddleButton
            // 
            this.secondMiddleButton.Location = new System.Drawing.Point(121, 144);
            this.secondMiddleButton.Name = "secondMiddleButton";
            this.secondMiddleButton.Size = new System.Drawing.Size(71, 78);
            this.secondMiddleButton.TabIndex = 4;
            this.secondMiddleButton.Text = "secondMiddle";
            this.secondMiddleButton.UseVisualStyleBackColor = true;
            this.secondMiddleButton.Click += new System.EventHandler(this.button_Click);
            // 
            // secondRightButton
            // 
            this.secondRightButton.Location = new System.Drawing.Point(211, 144);
            this.secondRightButton.Name = "secondRightButton";
            this.secondRightButton.Size = new System.Drawing.Size(71, 78);
            this.secondRightButton.TabIndex = 5;
            this.secondRightButton.Text = "secondRight";
            this.secondRightButton.UseVisualStyleBackColor = true;
            this.secondRightButton.Click += new System.EventHandler(this.button_Click);
            // 
            // thirdLeftButton
            // 
            this.thirdLeftButton.Location = new System.Drawing.Point(29, 246);
            this.thirdLeftButton.Name = "thirdLeftButton";
            this.thirdLeftButton.Size = new System.Drawing.Size(71, 78);
            this.thirdLeftButton.TabIndex = 6;
            this.thirdLeftButton.Text = "thirdLeft";
            this.thirdLeftButton.UseVisualStyleBackColor = true;
            this.thirdLeftButton.Click += new System.EventHandler(this.button_Click);
            // 
            // thirdMiddleButton
            // 
            this.thirdMiddleButton.Location = new System.Drawing.Point(121, 246);
            this.thirdMiddleButton.Name = "thirdMiddleButton";
            this.thirdMiddleButton.Size = new System.Drawing.Size(71, 78);
            this.thirdMiddleButton.TabIndex = 7;
            this.thirdMiddleButton.Text = "thirdMiddle";
            this.thirdMiddleButton.UseVisualStyleBackColor = true;
            this.thirdMiddleButton.Click += new System.EventHandler(this.button_Click);
            // 
            // thirdRightButton
            // 
            this.thirdRightButton.Location = new System.Drawing.Point(211, 246);
            this.thirdRightButton.Name = "thirdRightButton";
            this.thirdRightButton.Size = new System.Drawing.Size(71, 78);
            this.thirdRightButton.TabIndex = 8;
            this.thirdRightButton.Text = "thirdRight";
            this.thirdRightButton.UseVisualStyleBackColor = true;
            this.thirdRightButton.Click += new System.EventHandler(this.button_Click);
            // 
            // aiButton
            // 
            this.aiButton.Location = new System.Drawing.Point(29, 363);
            this.aiButton.Name = "aiButton";
            this.aiButton.Size = new System.Drawing.Size(253, 23);
            this.aiButton.TabIndex = 9;
            this.aiButton.Text = "AI Take Turn";
            this.aiButton.UseVisualStyleBackColor = true;
            this.aiButton.Click += new System.EventHandler(this.aiButton_Click);
            // 
            // WinnerLabel
            // 
            this.WinnerLabel.AutoSize = true;
            this.WinnerLabel.Location = new System.Drawing.Point(10, 11);
            this.WinnerLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.WinnerLabel.Name = "WinnerLabel";
            this.WinnerLabel.Size = new System.Drawing.Size(82, 13);
            this.WinnerLabel.TabIndex = 10;
            this.WinnerLabel.Text = "No Winners Yet";
            // 
            // reset
            // 
            this.reset.Location = new System.Drawing.Point(254, 13);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(75, 23);
            this.reset.TabIndex = 11;
            this.reset.Text = "Reset";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 422);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.WinnerLabel);
            this.Controls.Add(this.aiButton);
            this.Controls.Add(this.thirdRightButton);
            this.Controls.Add(this.thirdMiddleButton);
            this.Controls.Add(this.thirdLeftButton);
            this.Controls.Add(this.secondRightButton);
            this.Controls.Add(this.secondMiddleButton);
            this.Controls.Add(this.secondLeftButton);
            this.Controls.Add(this.firstRightButton);
            this.Controls.Add(this.firstMiddleButton);
            this.Controls.Add(this.firstLeftButton);
            this.Name = "mainForm";
            this.Text = "Tic Tac Toe AI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button firstLeftButton;
        private System.Windows.Forms.Button firstMiddleButton;
        private System.Windows.Forms.Button firstRightButton;
        private System.Windows.Forms.Button secondLeftButton;
        private System.Windows.Forms.Button secondMiddleButton;
        private System.Windows.Forms.Button secondRightButton;
        private System.Windows.Forms.Button thirdLeftButton;
        private System.Windows.Forms.Button thirdMiddleButton;
        private System.Windows.Forms.Button thirdRightButton;
        private System.Windows.Forms.Button aiButton;
        private System.Windows.Forms.Label WinnerLabel;
        private System.Windows.Forms.Button reset;
    }
}

