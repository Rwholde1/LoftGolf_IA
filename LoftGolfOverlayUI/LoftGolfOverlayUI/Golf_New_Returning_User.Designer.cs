namespace LoftGolfOverlayUI
{
    partial class Golf_New_Returning_User
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
            newUserBtn = new Button();
            returningUserBtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaptionText;
            label1.Font = new Font("Segoe UI", 28F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(95, 147);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Padding = new Padding(175, 0, 175, 0);
            label1.Size = new Size(1090, 51);
            label1.TabIndex = 6;
            label1.Text = "Have you been to Loft Golf Studios before?";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.UseWaitCursor = true;
            // 
            // newUserBtn
            // 
            newUserBtn.BackColor = Color.Black;
            newUserBtn.Font = new Font("Segoe UI", 72F, FontStyle.Regular, GraphicsUnit.Point);
            newUserBtn.ForeColor = SystemColors.Control;
            newUserBtn.Location = new Point(86, 283);
            newUserBtn.Margin = new Padding(2, 2, 2, 2);
            newUserBtn.Name = "newUserBtn";
            newUserBtn.Size = new Size(551, 315);
            newUserBtn.TabIndex = 7;
            newUserBtn.Text = "New User";
            newUserBtn.UseVisualStyleBackColor = false;
            newUserBtn.Click += button1_Click;
            newUserBtn.MouseEnter += newUserBtn_MouseEnter;
            newUserBtn.MouseLeave += newUserBtn_MouseLeave;
            // 
            // returningUserBtn
            // 
            returningUserBtn.BackColor = Color.Black;
            returningUserBtn.Font = new Font("Segoe UI", 72F, FontStyle.Regular, GraphicsUnit.Point);
            returningUserBtn.ForeColor = Color.White;
            returningUserBtn.Location = new Point(641, 283);
            returningUserBtn.Margin = new Padding(2, 2, 2, 2);
            returningUserBtn.Name = "returningUserBtn";
            returningUserBtn.Size = new Size(551, 315);
            returningUserBtn.TabIndex = 8;
            returningUserBtn.Text = "Returning User";
            returningUserBtn.UseVisualStyleBackColor = false;
            returningUserBtn.Click += returningUserBtn_Click;
            returningUserBtn.MouseEnter += returningUserBtn_MouseEnter;
            returningUserBtn.MouseLeave += returningUserBtn_MouseLeave;
            // 
            // Golf_New_Returning_User
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1280, 800);
            ControlBox = false;
            Controls.Add(returningUserBtn);
            Controls.Add(newUserBtn);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2, 2, 2, 2);
            Name = "Golf_New_Returning_User";
            StartPosition = FormStartPosition.Manual;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button newUserBtn;
        private Button returningUserBtn;
    }
}