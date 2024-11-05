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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            UI_Clock = new Label();
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
            button1.MouseEnter += Pull_up_UI;
            button1.MouseLeave += Pull_down_UI;
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
            button2.MouseEnter += Pull_up_UI;
            button2.MouseLeave += Pull_down_UI;
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
            button3.MouseEnter += Pull_up_UI;
            button3.MouseLeave += Pull_down_UI;
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
            button4.MouseEnter += Pull_up_UI;
            button4.MouseLeave += Pull_down_UI;
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
            button5.MouseEnter += Pull_up_UI;
            button5.MouseLeave += Pull_down_UI;
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
            button6.MouseEnter += Pull_up_UI;
            button6.MouseLeave += Pull_down_UI;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Image = (Image)resources.GetObject("label1.Image");
            label1.Location = new Point(304, 4);
            label1.Name = "label1";
            label1.Size = new Size(701, 65);
            label1.TabIndex = 6;
            label1.MouseEnter += Pull_up_UI;
            label1.MouseLeave += Pull_down_UI;
            // 
            // label2
            // 
            label2.BackColor = Color.Transparent;
            label2.Image = (Image)resources.GetObject("label2.Image");
            label2.Location = new Point(161, 108);
            label2.Name = "label2";
            label2.Size = new Size(52, 59);
            label2.TabIndex = 7;
            label2.MouseEnter += Pull_up_UI;
            label2.MouseLeave += Pull_down_UI;
            // 
            // label3
            // 
            label3.BackColor = Color.Transparent;
            label3.Image = (Image)resources.GetObject("label3.Image");
            label3.Location = new Point(370, 99);
            label3.Name = "label3";
            label3.Size = new Size(107, 68);
            label3.TabIndex = 8;
            label3.MouseEnter += Pull_up_UI;
            label3.MouseLeave += Pull_down_UI;
            // 
            // label4
            // 
            label4.BackColor = Color.Transparent;
            label4.Image = (Image)resources.GetObject("label4.Image");
            label4.Location = new Point(639, 99);
            label4.Name = "label4";
            label4.Size = new Size(88, 68);
            label4.TabIndex = 9;
            label4.MouseEnter += Pull_up_UI;
            label4.MouseLeave += Pull_down_UI;
            // 
            // label5
            // 
            label5.BackColor = Color.Transparent;
            label5.Image = (Image)resources.GetObject("label5.Image");
            label5.Location = new Point(871, 99);
            label5.Name = "label5";
            label5.Size = new Size(100, 68);
            label5.TabIndex = 10;
            label5.MouseEnter += Pull_up_UI;
            label5.MouseLeave += Pull_down_UI;
            // 
            // label6
            // 
            label6.Image = (Image)resources.GetObject("label6.Image");
            label6.Location = new Point(1125, 103);
            label6.Name = "label6";
            label6.Size = new Size(88, 64);
            label6.TabIndex = 11;
            label6.MouseEnter += Pull_up_UI;
            label6.MouseLeave += Pull_down_UI;
            // 
            // UI_Clock
            // 
            UI_Clock.AutoSize = true;
            UI_Clock.Font = new Font("Segoe UI", 26F, FontStyle.Regular, GraphicsUnit.Point);
            UI_Clock.Location = new Point(994, 0);
            UI_Clock.Name = "UI_Clock";
            UI_Clock.Size = new Size(278, 70);
            UI_Clock.TabIndex = 12;
            UI_Clock.Text = "TIME HERE";
            UI_Clock.MouseEnter += Pull_up_UI;
            UI_Clock.MouseLeave += Pull_down_UI;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(144F, 144F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(1322, 211);
            ControlBox = false;
            Controls.Add(UI_Clock);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Opacity = 0.8D;
            ShowIcon = false;
            StartPosition = FormStartPosition.Manual;
            TopMost = true;
            MouseEnter += Pull_up_UI;
            MouseLeave += Pull_down_UI;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label UI_Clock;
    }
}