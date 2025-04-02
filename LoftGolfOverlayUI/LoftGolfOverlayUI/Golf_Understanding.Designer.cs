namespace LoftGolfOverlayUI
{
    partial class Golf_Understanding
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
            golfBtn = new Button();
            videoAgainBtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaptionText;
            label1.Font = new Font("Segoe UI", 28F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(286, 147);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Padding = new Padding(200, 0, 200, 0);
            label1.Size = new Size(727, 62);
            label1.TabIndex = 7;
            label1.Text = "Ready to golf?";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.UseWaitCursor = true;
            // 
            // golfBtn
            // 
            golfBtn.BackColor = Color.Black;
            golfBtn.Font = new Font("Segoe UI", 72F, FontStyle.Regular, GraphicsUnit.Point);
            golfBtn.ForeColor = SystemColors.Control;
            golfBtn.Location = new Point(10, 305);
            golfBtn.Margin = new Padding(2, 2, 2, 2);
            golfBtn.Name = "golfBtn";
            golfBtn.Size = new Size(630, 420);
            golfBtn.TabIndex = 8;
            golfBtn.Text = "Let's Golf!";
            golfBtn.UseVisualStyleBackColor = false;
            golfBtn.Click += golfBtn_Click;
            golfBtn.MouseEnter += golfBtn_MouseEnter;
            golfBtn.MouseLeave += golfBtn_MouseLeave;
            // 
            // videoAgainBtn
            // 
            videoAgainBtn.BackColor = SystemColors.Desktop;
            videoAgainBtn.Font = new Font("Segoe UI", 72F, FontStyle.Regular, GraphicsUnit.Point);
            videoAgainBtn.ForeColor = Color.White;
            videoAgainBtn.Location = new Point(645, 305);
            videoAgainBtn.Margin = new Padding(2, 2, 2, 2);
            videoAgainBtn.Name = "videoAgainBtn";
            videoAgainBtn.Size = new Size(630, 420);
            videoAgainBtn.TabIndex = 9;
            videoAgainBtn.Text = "Watch the video again";
            videoAgainBtn.UseVisualStyleBackColor = false;
            videoAgainBtn.Click += videoAgainBtn_Click;
            videoAgainBtn.MouseEnter += videoAgainBtn_MouseEnter;
            videoAgainBtn.MouseLeave += videoAgainBtn_MouseLeave;
            // 
            // Golf_Understanding
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1280, 800);
            ControlBox = false;
            Controls.Add(videoAgainBtn);
            Controls.Add(golfBtn);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2, 2, 2, 2);
            Name = "Golf_Understanding";
            StartPosition = FormStartPosition.CenterScreen;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button golfBtn;
        private Button videoAgainBtn;
    }
}