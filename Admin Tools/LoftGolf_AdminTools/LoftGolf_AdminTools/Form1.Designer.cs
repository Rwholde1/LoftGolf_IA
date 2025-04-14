namespace LoftGolf_AdminTools
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
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            ScriptNameListBox = new ListBox();
            FilePathListBox = new ListBox();
            SelectedScriptNameTextBox = new TextBox();
            SelectedFilePathTextBox = new TextBox();
            SaveEditsBtn = new Button();
            AddNewScriptBtn = new Button();
            NewFilePathTextBox = new TextBox();
            NewScriptNameTextBox = new TextBox();
            FileSaveBtn = new Button();
            ExitAdminToolsBtn = new Button();
            ErrorTextLabel = new Label();
            DeleteSelectedScriptBtn = new Button();
            ResetChangesBtn = new Button();
            SuspendLayout();
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(0, 10);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(1280, 65);
            label4.TabIndex = 6;
            label4.Text = "Loft Golf UI Automation Admin Tools";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(355, 134);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(165, 37);
            label5.TabIndex = 7;
            label5.Text = "Script/Video";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(801, 134);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(58, 37);
            label6.TabIndex = 8;
            label6.Text = "File";
            // 
            // ScriptNameListBox
            // 
            ScriptNameListBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ScriptNameListBox.FormattingEnabled = true;
            ScriptNameListBox.ItemHeight = 21;
            ScriptNameListBox.Location = new Point(300, 200);
            ScriptNameListBox.Margin = new Padding(2);
            ScriptNameListBox.Name = "ScriptNameListBox";
            ScriptNameListBox.Size = new Size(300, 235);
            ScriptNameListBox.TabIndex = 15;
            ScriptNameListBox.SelectedIndexChanged += loadScriptInfo;
            // 
            // FilePathListBox
            // 
            FilePathListBox.Enabled = false;
            FilePathListBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FilePathListBox.FormattingEnabled = true;
            FilePathListBox.ItemHeight = 21;
            FilePathListBox.Location = new Point(680, 200);
            FilePathListBox.Margin = new Padding(2);
            FilePathListBox.Name = "FilePathListBox";
            FilePathListBox.Size = new Size(300, 235);
            FilePathListBox.TabIndex = 16;
            // 
            // SelectedScriptNameTextBox
            // 
            SelectedScriptNameTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SelectedScriptNameTextBox.Location = new Point(35, 492);
            SelectedScriptNameTextBox.Margin = new Padding(2);
            SelectedScriptNameTextBox.Name = "SelectedScriptNameTextBox";
            SelectedScriptNameTextBox.PlaceholderText = "Selected Script/Video Name";
            SelectedScriptNameTextBox.ReadOnly = true;
            SelectedScriptNameTextBox.Size = new Size(481, 29);
            SelectedScriptNameTextBox.TabIndex = 19;
            // 
            // SelectedFilePathTextBox
            // 
            SelectedFilePathTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SelectedFilePathTextBox.Location = new Point(562, 492);
            SelectedFilePathTextBox.Margin = new Padding(2);
            SelectedFilePathTextBox.Name = "SelectedFilePathTextBox";
            SelectedFilePathTextBox.PlaceholderText = "Selected File's Name";
            SelectedFilePathTextBox.Size = new Size(481, 29);
            SelectedFilePathTextBox.TabIndex = 20;
            // 
            // SaveEditsBtn
            // 
            SaveEditsBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SaveEditsBtn.Location = new Point(1066, 482);
            SaveEditsBtn.Margin = new Padding(2);
            SaveEditsBtn.Name = "SaveEditsBtn";
            SaveEditsBtn.Size = new Size(190, 50);
            SaveEditsBtn.TabIndex = 21;
            SaveEditsBtn.Text = "Save File Path Edits";
            SaveEditsBtn.UseVisualStyleBackColor = true;
            SaveEditsBtn.Click += SaveEditsBtn_Click;
            // 
            // AddNewScriptBtn
            // 
            AddNewScriptBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AddNewScriptBtn.Location = new Point(1066, 551);
            AddNewScriptBtn.Margin = new Padding(2);
            AddNewScriptBtn.Name = "AddNewScriptBtn";
            AddNewScriptBtn.Size = new Size(190, 50);
            AddNewScriptBtn.TabIndex = 22;
            AddNewScriptBtn.Text = "Add New File Path";
            AddNewScriptBtn.UseVisualStyleBackColor = true;
            AddNewScriptBtn.Click += AddNewScriptBtn_Click;
            // 
            // NewFilePathTextBox
            // 
            NewFilePathTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NewFilePathTextBox.Location = new Point(562, 561);
            NewFilePathTextBox.Margin = new Padding(2);
            NewFilePathTextBox.Name = "NewFilePathTextBox";
            NewFilePathTextBox.PlaceholderText = "New File's Name";
            NewFilePathTextBox.Size = new Size(481, 29);
            NewFilePathTextBox.TabIndex = 23;
            // 
            // NewScriptNameTextBox
            // 
            NewScriptNameTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NewScriptNameTextBox.Location = new Point(35, 561);
            NewScriptNameTextBox.Margin = new Padding(2);
            NewScriptNameTextBox.Name = "NewScriptNameTextBox";
            NewScriptNameTextBox.PlaceholderText = "New Script/Video Name";
            NewScriptNameTextBox.Size = new Size(481, 29);
            NewScriptNameTextBox.TabIndex = 24;
            // 
            // FileSaveBtn
            // 
            FileSaveBtn.Font = new Font("Segoe UI", 21.75F);
            FileSaveBtn.Location = new Point(200, 680);
            FileSaveBtn.Margin = new Padding(2);
            FileSaveBtn.Name = "FileSaveBtn";
            FileSaveBtn.Size = new Size(360, 80);
            FileSaveBtn.TabIndex = 25;
            FileSaveBtn.Text = "Save to File";
            FileSaveBtn.UseVisualStyleBackColor = true;
            FileSaveBtn.Click += FileSaveBtn_Click;
            // 
            // ExitAdminToolsBtn
            // 
            ExitAdminToolsBtn.Font = new Font("Segoe UI", 21.75F);
            ExitAdminToolsBtn.Location = new Point(720, 680);
            ExitAdminToolsBtn.Margin = new Padding(2);
            ExitAdminToolsBtn.Name = "ExitAdminToolsBtn";
            ExitAdminToolsBtn.Size = new Size(360, 80);
            ExitAdminToolsBtn.TabIndex = 26;
            ExitAdminToolsBtn.Text = "Exit Admin Tools";
            ExitAdminToolsBtn.UseVisualStyleBackColor = true;
            ExitAdminToolsBtn.Click += ExitAdminToolsBtn_Click;
            // 
            // ErrorTextLabel
            // 
            ErrorTextLabel.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ErrorTextLabel.ForeColor = Color.White;
            ErrorTextLabel.Location = new Point(0, 615);
            ErrorTextLabel.Margin = new Padding(2, 0, 2, 0);
            ErrorTextLabel.Name = "ErrorTextLabel";
            ErrorTextLabel.Size = new Size(1280, 45);
            ErrorTextLabel.TabIndex = 27;
            ErrorTextLabel.Text = "Error Message Text";
            ErrorTextLabel.TextAlign = ContentAlignment.MiddleCenter;
            ErrorTextLabel.Visible = false;
            // 
            // DeleteSelectedScriptBtn
            // 
            DeleteSelectedScriptBtn.Font = new Font("Segoe UI", 12F);
            DeleteSelectedScriptBtn.Location = new Point(1036, 287);
            DeleteSelectedScriptBtn.Margin = new Padding(2);
            DeleteSelectedScriptBtn.Name = "DeleteSelectedScriptBtn";
            DeleteSelectedScriptBtn.Size = new Size(220, 50);
            DeleteSelectedScriptBtn.TabIndex = 28;
            DeleteSelectedScriptBtn.Text = "Delete Selected Script";
            DeleteSelectedScriptBtn.UseVisualStyleBackColor = true;
            DeleteSelectedScriptBtn.Click += DeleteSelectedScriptBtn_Click;
            // 
            // ResetChangesBtn
            // 
            ResetChangesBtn.Font = new Font("Segoe UI", 12F);
            ResetChangesBtn.Location = new Point(1036, 357);
            ResetChangesBtn.Margin = new Padding(2);
            ResetChangesBtn.Name = "ResetChangesBtn";
            ResetChangesBtn.Size = new Size(220, 50);
            ResetChangesBtn.TabIndex = 29;
            ResetChangesBtn.Text = "Reset to Current CSV";
            ResetChangesBtn.UseVisualStyleBackColor = true;
            ResetChangesBtn.Click += ResetChangesBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1280, 800);
            Controls.Add(ResetChangesBtn);
            Controls.Add(DeleteSelectedScriptBtn);
            Controls.Add(ErrorTextLabel);
            Controls.Add(ExitAdminToolsBtn);
            Controls.Add(FileSaveBtn);
            Controls.Add(NewScriptNameTextBox);
            Controls.Add(NewFilePathTextBox);
            Controls.Add(AddNewScriptBtn);
            Controls.Add(SaveEditsBtn);
            Controls.Add(SelectedFilePathTextBox);
            Controls.Add(SelectedScriptNameTextBox);
            Controls.Add(FilePathListBox);
            Controls.Add(ScriptNameListBox);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label4;
        private Label label5;
        private Label label6;
        private ListBox ScriptNameListBox;
        private ListBox FilePathListBox;
        private TextBox SelectedScriptNameTextBox;
        private TextBox SelectedFilePathTextBox;
        private Button SaveEditsBtn;
        private Button AddNewScriptBtn;
        private TextBox NewFilePathTextBox;
        private TextBox NewScriptNameTextBox;
        private Button FileSaveBtn;
        private Button ExitAdminToolsBtn;
        private Label ErrorTextLabel;
        private Button DeleteSelectedScriptBtn;
        private Button ResetChangesBtn;
    }
}
