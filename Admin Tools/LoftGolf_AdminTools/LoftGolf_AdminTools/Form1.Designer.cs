using System.ComponentModel;
using System.Runtime.InteropServices;

namespace LoftGolf_AdminTools
{
    public class SyncListBoxes

    {



        private ListBox _LB1 = null;

        private ListBox _LB2 = null;



        private ListBoxScroll _ListBoxScroll1 = null;

        private ListBoxScroll _ListBoxScroll2 = null;



        public SyncListBoxes(ListBox LB1, ListBox LB2)

        {

            if (LB1 != null && LB1.IsHandleCreated && LB2 != null && LB2.IsHandleCreated &&

                LB1.Items.Count == LB2.Items.Count && LB1.Height == LB2.Height)

            {

                this._LB1 = LB1;

                this._ListBoxScroll1 = new ListBoxScroll(LB1);

                this._ListBoxScroll1.Scroll += _ListBoxScroll1_VerticalScroll;



                this._LB2 = LB2;

                this._ListBoxScroll2 = new ListBoxScroll(LB2);

                this._ListBoxScroll2.Scroll += _ListBoxScroll2_VerticalScroll;



                this._LB1.SelectedIndexChanged += _LB1_SelectedIndexChanged;

                this._LB2.SelectedIndexChanged += _LB2_SelectedIndexChanged;

            }

        }



        private void _LB1_SelectedIndexChanged(object sender, EventArgs e)

        {

            if (this._LB2.TopIndex != this._LB1.TopIndex)

            {

                this._LB2.TopIndex = this._LB1.TopIndex;

            }

            if (this._LB2.SelectedIndex != this._LB1.SelectedIndex)

            {

                this._LB2.SelectedIndex = this._LB1.SelectedIndex;

            }

        }



        private void _LB2_SelectedIndexChanged(object sender, EventArgs e)

        {

            if (this._LB1.TopIndex != this._LB2.TopIndex)

            {

                this._LB1.TopIndex = this._LB2.TopIndex;

            }

            if (this._LB1.SelectedIndex != this._LB2.SelectedIndex)

            {

                this._LB1.SelectedIndex = this._LB2.SelectedIndex;

            }

        }



        private void _ListBoxScroll1_VerticalScroll(ListBox LB)

        {

            if (this._LB2.TopIndex != this._LB1.TopIndex)

            {

                this._LB2.TopIndex = this._LB1.TopIndex;

            }

        }



        private void _ListBoxScroll2_VerticalScroll(ListBox LB)

        {

            if (this._LB1.TopIndex != this._LB2.TopIndex)

            {

                this._LB1.TopIndex = this._LB2.TopIndex;

            }

        }



        private class ListBoxScroll : NativeWindow

        {



            private ListBox _LB = null;

            private const int WM_VSCROLL = 0x115;

            private const int WM_MOUSEWHEEL = 0x20a;



            public event dlgListBoxScroll Scroll;

            public delegate void dlgListBoxScroll(ListBox LB);



            public ListBoxScroll(ListBox LB)

            {

                this._LB = LB;

                this.AssignHandle(LB.Handle);

            }



            protected override void WndProc(ref Message m)

            {

                base.WndProc(ref m);

                switch (m.Msg)

                {

                    case WM_VSCROLL:

                    case WM_MOUSEWHEEL:

                        if (this.Scroll != null)

                        {

                            this.Scroll(_LB);

                        }

                        break;

                }

            }



        }



    }

    partial class Form1
    {
        private SyncListBoxes pairedListBoxes;

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
            FilePathStubSaveBtn = new Button();
            FilePathStubTextBox = new TextBox();
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
            label5.Location = new Point(76, 90);
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
            label6.Location = new Point(637, 90);
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
            ScriptNameListBox.Location = new Point(40, 156);
            ScriptNameListBox.Margin = new Padding(2);
            ScriptNameListBox.Name = "ScriptNameListBox";
            ScriptNameListBox.Size = new Size(240, 235);
            ScriptNameListBox.TabIndex = 15;
            //ScriptNameListBox.OnVerticalScroll += ScriptNameListBox_OnVerticalScroll;

            ScriptNameListBox.SelectedIndexChanged += loadScriptInfo;
            // 
            // FilePathListBox
            // 
            FilePathListBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FilePathListBox.FormattingEnabled = true;
            FilePathListBox.ItemHeight = 21;
            FilePathListBox.Location = new Point(302, 156);
            FilePathListBox.Margin = new Padding(2);
            FilePathListBox.Name = "FilePathListBox";
            FilePathListBox.SelectionMode = SelectionMode.None;
            FilePathListBox.Size = new Size(741, 235);
            FilePathListBox.TabIndex = 16;
            //FilePathListBox.Scroll += FilePathListBox_OnVerticalScroll;
            // 
            // SelectedScriptNameTextBox
            // 
            SelectedScriptNameTextBox.Enabled = false;
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
            DeleteSelectedScriptBtn.Location = new Point(1066, 243);
            DeleteSelectedScriptBtn.Margin = new Padding(2);
            DeleteSelectedScriptBtn.Name = "DeleteSelectedScriptBtn";
            DeleteSelectedScriptBtn.Size = new Size(190, 50);
            DeleteSelectedScriptBtn.TabIndex = 28;
            DeleteSelectedScriptBtn.Text = "Delete Selected Script";
            DeleteSelectedScriptBtn.UseVisualStyleBackColor = true;
            DeleteSelectedScriptBtn.Click += DeleteSelectedScriptBtn_Click;
            // 
            // ResetChangesBtn
            // 
            ResetChangesBtn.Font = new Font("Segoe UI", 12F);
            ResetChangesBtn.Location = new Point(1066, 313);
            ResetChangesBtn.Margin = new Padding(2);
            ResetChangesBtn.Name = "ResetChangesBtn";
            ResetChangesBtn.Size = new Size(190, 50);
            ResetChangesBtn.TabIndex = 29;
            ResetChangesBtn.Text = "Reset to Current CSV";
            ResetChangesBtn.UseVisualStyleBackColor = true;
            ResetChangesBtn.Click += ResetChangesBtn_Click;
            // 
            // FilePathStubSaveBtn
            // 
            FilePathStubSaveBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FilePathStubSaveBtn.Location = new Point(976, 411);
            FilePathStubSaveBtn.Margin = new Padding(2);
            FilePathStubSaveBtn.Name = "FilePathStubSaveBtn";
            FilePathStubSaveBtn.Size = new Size(280, 50);
            FilePathStubSaveBtn.TabIndex = 31;
            FilePathStubSaveBtn.Text = "Save File Path Stub";
            FilePathStubSaveBtn.UseVisualStyleBackColor = true;
            FilePathStubSaveBtn.Click += FilePathStubSaveBtn_Click;
            // 
            // FilePathStubTextBox
            // 
            FilePathStubTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FilePathStubTextBox.Location = new Point(35, 423);
            FilePathStubTextBox.Margin = new Padding(2);
            FilePathStubTextBox.Name = "FilePathStubTextBox";
            FilePathStubTextBox.PlaceholderText = "Current File Path Stub";
            FilePathStubTextBox.Size = new Size(914, 29);
            FilePathStubTextBox.TabIndex = 32;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1280, 800);
            Controls.Add(FilePathStubTextBox);
            Controls.Add(FilePathStubSaveBtn);
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
            FormBorderStyle = FormBorderStyle.FixedSingle;
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
        private Button FilePathStubSaveBtn;
        private TextBox FilePathStubTextBox;
    }
}
