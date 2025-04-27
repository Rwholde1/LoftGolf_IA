namespace LoftGolfOverlayUI
{
    partial class Troubleshoot
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
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            questionLabel = new Label();
            yesButton = new Button();
            noButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 32F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(354, 19);
            label1.Name = "label1";
            label1.Size = new Size(217, 59);
            label1.TabIndex = 0;
            label1.Text = "Help Page";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(223, 78);
            label2.Name = "label2";
            label2.Size = new Size(491, 181);
            label2.TabIndex = 1;
            label2.Text = "Hello there! This is the golf troubleshooting page. Please answer the questions below, and we will try our best to fix your issue!\r\n";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(796, 535);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(110, 57);
            button1.TabIndex = 2;
            button1.Text = "Return";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // questionLabel
            // 
            questionLabel.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            questionLabel.ForeColor = Color.White;
            questionLabel.Location = new Point(211, 259);
            questionLabel.Name = "questionLabel";
            questionLabel.Size = new Size(518, 171);
            questionLabel.TabIndex = 3;
            questionLabel.Text = "Is the light on in the hitting area?";
            questionLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // yesButton
            // 
            yesButton.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            yesButton.Location = new Point(286, 505);
            yesButton.Margin = new Padding(3, 2, 3, 2);
            yesButton.Name = "yesButton";
            yesButton.Size = new Size(133, 61);
            yesButton.TabIndex = 4;
            yesButton.Text = "Yes";
            yesButton.UseVisualStyleBackColor = true;
            yesButton.Click += button2_Click;
            // 
            // noButton
            // 
            noButton.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            noButton.Location = new Point(526, 505);
            noButton.Margin = new Padding(3, 2, 3, 2);
            noButton.Name = "noButton";
            noButton.Size = new Size(133, 61);
            noButton.TabIndex = 5;
            noButton.Text = "No";
            noButton.UseVisualStyleBackColor = true;
            noButton.Click += button3_Click;
            // 
            // Troubleshoot
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(918, 603);
            ControlBox = false;
            Controls.Add(noButton);
            Controls.Add(yesButton);
            Controls.Add(questionLabel);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Troubleshoot";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Load += Form6_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button button1;
        private Label questionLabel;
        private Button yesButton;
        private Button noButton;
    }
}