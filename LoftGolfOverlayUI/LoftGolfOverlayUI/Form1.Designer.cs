namespace LoftGolfOverlayUI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ImageAlign = ContentAlignment.MiddleRight;
            button1.Location = new Point(12, 72);
            button1.Name = "button1";
            button1.Size = new Size(238, 127);
            button1.TabIndex = 0;
            button1.Text = "Home";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ImageAlign = ContentAlignment.MiddleRight;
            button2.Location = new Point(256, 72);
            button2.Name = "button2";
            button2.Size = new Size(238, 127);
            button2.TabIndex = 1;
            button2.Text = "Golf";
            button2.TextAlign = ContentAlignment.MiddleLeft;
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ImageAlign = ContentAlignment.MiddleRight;
            button3.Location = new Point(500, 72);
            button3.Name = "button3";
            button3.Size = new Size(238, 127);
            button3.TabIndex = 2;
            button3.Text = "Karaoke";
            button3.TextAlign = ContentAlignment.MiddleLeft;
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            button4.ImageAlign = ContentAlignment.MiddleRight;
            button4.Location = new Point(744, 72);
            button4.Name = "button4";
            button4.Size = new Size(238, 127);
            button4.TabIndex = 3;
            button4.Text = "Movie";
            button4.TextAlign = ContentAlignment.MiddleLeft;
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            button5.ImageAlign = ContentAlignment.MiddleRight;
            button5.Location = new Point(988, 72);
            button5.Name = "button5";
            button5.Size = new Size(238, 127);
            button5.TabIndex = 4;
            button5.Text = "Meeting";
            button5.TextAlign = ContentAlignment.MiddleLeft;
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            button6.ImageAlign = ContentAlignment.MiddleRight;
            button6.Location = new Point(1232, 72);
            button6.Name = "button6";
            button6.Size = new Size(78, 127);
            button6.TabIndex = 5;
            button6.Text = "?";
            button6.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(144F, 144F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(1322, 211);
            ControlBox = false;
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Opacity = 0.8D;
            ShowIcon = false;
            TopMost = true;
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
    }
}