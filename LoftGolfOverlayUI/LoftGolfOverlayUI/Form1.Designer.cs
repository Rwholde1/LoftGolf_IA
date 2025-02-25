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
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            UI_Clock = new Label();
            label7 = new Label();
            label3 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            SuspendLayout();
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
            label2.BackColor = SystemColors.ButtonFace;
            label2.Image = (Image)resources.GetObject("label2.Image");
            label2.Location = new Point(163, 108);
            label2.Name = "label2";
            label2.Size = new Size(52, 59);
            label2.TabIndex = 14;
            label2.Click += label2_Click;
            label2.MouseEnter += home_hover;
            label2.MouseLeave += home_leave;
            // 
            // label4
            // 
            label4.BackColor = SystemColors.ButtonFace;
            label4.Image = (Image)resources.GetObject("label4.Image");
            label4.Location = new Point(632, 103);
            label4.Name = "label4";
            label4.Size = new Size(59, 68);
            label4.TabIndex = 9;
            label4.Click += label4_Click;
            label4.MouseEnter += karaoke_hover;
            label4.MouseLeave += karaoke_leave;
            // 
            // label5
            // 
            label5.BackColor = SystemColors.ButtonFace;
            label5.Image = (Image)resources.GetObject("label5.Image");
            label5.Location = new Point(858, 103);
            label5.Name = "label5";
            label5.Size = new Size(71, 68);
            label5.TabIndex = 10;
            label5.Click += label5_Click;
            label5.MouseEnter += movie_hover;
            label5.MouseLeave += movie_leave;
            // 
            // label6
            // 
            label6.BackColor = SystemColors.ButtonFace;
            label6.Image = (Image)resources.GetObject("label6.Image");
            label6.Location = new Point(1108, 103);
            label6.Name = "label6";
            label6.Size = new Size(64, 64);
            label6.TabIndex = 11;
            label6.Click += label6_Click;
            label6.MouseEnter += meeting_hover;
            label6.MouseLeave += meeting_leave;
            // 
            // UI_Clock
            // 
            UI_Clock.AutoSize = true;
            UI_Clock.Font = new Font("Segoe UI", 26F, FontStyle.Regular, GraphicsUnit.Point);
            UI_Clock.Location = new Point(994, 0);
            UI_Clock.Name = "UI_Clock";
            UI_Clock.Size = new Size(224, 70);
            UI_Clock.TabIndex = 12;
            UI_Clock.Text = "Time is...";
            UI_Clock.MouseEnter += Pull_up_UI;
            UI_Clock.MouseLeave += Pull_down_UI;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = SystemColors.ButtonFace;
            label7.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(12, 77);
            label7.Name = "label7";
            label7.Padding = new Padding(15, 35, 110, 35);
            label7.Size = new Size(232, 115);
            label7.TabIndex = 13;
            label7.Text = "Home";
            label7.Click += label7_Click;
            label7.MouseEnter += home_hover;
            label7.MouseLeave += home_leave;
            // 
            // label3
            // 
            label3.BackColor = SystemColors.ButtonFace;
            label3.Image = (Image)resources.GetObject("label3.Image");
            label3.Location = new Point(357, 103);
            label3.Name = "label3";
            label3.Size = new Size(107, 68);
            label3.TabIndex = 8;
            label3.Click += label3_Click;
            label3.MouseEnter += golf_hover;
            label3.MouseLeave += golf_leave;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = SystemColors.ButtonFace;
            label8.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(250, 77);
            label8.Name = "label8";
            label8.Padding = new Padding(15, 35, 138, 35);
            label8.Size = new Size(232, 115);
            label8.TabIndex = 15;
            label8.Text = "Golf";
            label8.Click += label8_Click;
            label8.MouseEnter += golf_hover;
            label8.MouseLeave += golf_leave;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = SystemColors.ButtonFace;
            label9.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(488, 77);
            label9.Name = "label9";
            label9.Padding = new Padding(15, 35, 83, 35);
            label9.Size = new Size(232, 115);
            label9.TabIndex = 16;
            label9.Text = "Karaoke";
            label9.Click += label9_Click;
            label9.MouseEnter += karaoke_hover;
            label9.MouseLeave += karaoke_leave;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = SystemColors.ButtonFace;
            label10.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(726, 77);
            label10.Name = "label10";
            label10.Padding = new Padding(15, 35, 95, 35);
            label10.Size = new Size(232, 115);
            label10.TabIndex = 17;
            label10.Text = "Movies";
            label10.Click += label10_Click;
            label10.MouseEnter += movie_hover;
            label10.MouseLeave += movie_leave;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = SystemColors.ButtonFace;
            label11.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(964, 77);
            label11.Name = "label11";
            label11.Padding = new Padding(15, 35, 78, 35);
            label11.Size = new Size(232, 115);
            label11.TabIndex = 18;
            label11.Text = "Meeting";
            label11.Click += label11_Click;
            label11.MouseEnter += meeting_hover;
            label11.MouseLeave += meeting_leave;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = SystemColors.ButtonFace;
            label12.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(1202, 77);
            label12.Name = "label12";
            label12.Padding = new Padding(15, 35, 15, 35);
            label12.Size = new Size(117, 115);
            label12.TabIndex = 19;
            label12.Text = "Help";
            label12.TextAlign = ContentAlignment.MiddleCenter;
            label12.Click += label12_Click;
            label12.MouseEnter += system_hover;
            label12.MouseLeave += system_leave;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(144F, 144F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = SystemColors.Window;
            ClientSize = new Size(1322, 211);
            ControlBox = false;
            Controls.Add(label12);
            Controls.Add(label2);
            Controls.Add(label7);
            Controls.Add(UI_Clock);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(label10);
            Controls.Add(label11);
            FormBorderStyle = FormBorderStyle.None;
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
        private Label label1;
        private Label label2;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label UI_Clock;
        private Label label7;
        private Label label3;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
    }
}