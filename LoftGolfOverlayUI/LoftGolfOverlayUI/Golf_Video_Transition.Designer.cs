namespace LoftGolfOverlayUI
{
    partial class Golf_Video_Transition : Form
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
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaptionText;
            label1.Font = new Font("Segoe UI", 28F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(245, 90);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Padding = new Padding(175, 0, 175, 0);
            label1.Size = new Size(350, 51);
            label1.TabIndex = 7;
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.UseWaitCursor = true;
            // 
            // Golf_Video_Transition
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1280, 800);
            ControlBox = false;
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "Golf_Video_Transition";
            StartPosition = FormStartPosition.CenterScreen;
            Shown += Golf_Video_Transition_Shown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private Label label1;
    }
}