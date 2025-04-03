namespace LoftGolfOverlayUI
{
    partial class Form6
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
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(283, 23);
            label1.Name = "label1";
            label1.Size = new Size(138, 37);
            label1.TabIndex = 0;
            label1.Text = "Help Page";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.ForeColor = Color.White;
            label2.Location = new Point(185, 72);
            label2.Name = "label2";
            label2.Size = new Size(337, 60);
            label2.TabIndex = 1;
            label2.Text = "Hello there! If you are accessing the help page, we assume you are running into trouble with your shot being detected. Please answer the questions below, and we will try our best to fix your issue!\r\n";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.Location = new Point(606, 289);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(69, 29);
            button1.TabIndex = 2;
            button1.Text = "Return";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // questionLabel
            // 
            questionLabel.ForeColor = Color.White;
            questionLabel.Location = new Point(210, 148);
            questionLabel.Name = "questionLabel";
            questionLabel.Size = new Size(284, 99);
            questionLabel.TabIndex = 3;
            questionLabel.Text = "Is the light on in the hitting area?";
            questionLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // yesButton
            // 
            yesButton.Location = new Point(276, 249);
            yesButton.Margin = new Padding(3, 2, 3, 2);
            yesButton.Name = "yesButton";
            yesButton.Size = new Size(48, 23);
            yesButton.TabIndex = 4;
            yesButton.Text = "Yes";
            yesButton.UseVisualStyleBackColor = true;
            yesButton.Click += button2_Click;
            // 
            // noButton
            // 
            noButton.Location = new Point(379, 249);
            noButton.Margin = new Padding(3, 2, 3, 2);
            noButton.Name = "noButton";
            noButton.Size = new Size(48, 23);
            noButton.TabIndex = 5;
            noButton.Text = "No";
            noButton.UseVisualStyleBackColor = true;
            noButton.Click += button3_Click;
            // 
            // Form6
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(704, 338);
            ControlBox = false;
            Controls.Add(noButton);
            Controls.Add(yesButton);
            Controls.Add(questionLabel);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form6";
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