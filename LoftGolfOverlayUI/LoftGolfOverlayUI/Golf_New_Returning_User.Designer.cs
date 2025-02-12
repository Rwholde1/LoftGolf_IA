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
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaptionText;
            label1.Font = new Font("Segoe UI", 28F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(415, 250);
            label1.Name = "label1";
            label1.Padding = new Padding(250, 0, 250, 0);
            label1.Size = new Size(1430, 74);
            label1.TabIndex = 6;
            label1.Text = "Have you golfed at Loft Golf before?";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.UseWaitCursor = true;
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.Font = new Font("Segoe UI", 72F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(10, 450);
            button1.Name = "button1";
            button1.Size = new Size(1109, 762);
            button1.TabIndex = 7;
            button1.Text = "New User";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.Desktop;
            button2.Font = new Font("Segoe UI", 72F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(1143, 450);
            button2.Name = "button2";
            button2.Size = new Size(1107, 762);
            button2.TabIndex = 8;
            button2.Text = "Returning User";
            button2.UseVisualStyleBackColor = false;
            // 
            // Golf_New_Returning_User
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(2258, 1478);
            ControlBox = false;
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "Golf_New_Returning_User";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
    }
}