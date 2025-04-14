using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Windows.Forms;
using CsvHelper;

namespace LoftGolf_AdminTools
{
    public partial class Form1 : Form
    {
        string automationFilesCSVPath = @"C:\Users\Rowan\Documents\Unity\LoftGolf_IA\Admin Tools\LoftGolf_AdminTools\LoftGolf_AdminTools\LoftGolf_UIAutomation.csv";
        public Dictionary<string, string> scriptFileDict = new Dictionary<string, string>();
        public Form1()
        {
            InitializeComponent();
            this.Load += DictInit;
        }

        private class DictEntry
        {
            public required string Script { get; set; }
            public required string FilePath { get; set; }
        }

        private void DictInit(object sender, EventArgs e)
        {

            try
            {
                using var reader = new StreamReader(automationFilesCSVPath);
                using var automationCSV = new CsvReader(reader, CultureInfo.InvariantCulture);

                var records = automationCSV.GetRecords<DictEntry>();

                foreach (var record in records)
                {
                    scriptFileDict.Add(record.Script, record.FilePath);
                }

                ErrorTextLabel.Visible = false;
            }
            catch
            {
                ErrorTextLabel.Text = "Failed to fetch CSV.";
                ErrorTextLabel.Visible = true;
            }

            if (ScriptNameListBox.Items.Count > 0)
            {
                ScriptNameListBox.Items.Clear();
                FilePathListBox.Items.Clear();
            }

            if (scriptFileDict.Count != 0)
            {
                foreach (var entry in scriptFileDict)
                {
                    ScriptNameListBox.Items.Add(entry.Key);
                    FilePathListBox.Items.Add(entry.Value);
                }
            }
        }

        private void loadScriptInfo(object sender, EventArgs e)
        {
            if (ScriptNameListBox.SelectedIndex != -1)
            {
                string selectedScript = ScriptNameListBox.SelectedItem.ToString();
                int currentIndex = ScriptNameListBox.SelectedIndex;
                string selectedFilePath = FilePathListBox.Items[currentIndex].ToString();

                SelectedScriptNameTextBox.Text = selectedScript;
                SelectedFilePathTextBox.Text = selectedFilePath;
                ErrorTextLabel.Visible = false;
            }
            else
            {
                ErrorTextLabel.Text = "Please select a valid entry to edit.";
                ErrorTextLabel.Visible = true;
            }

        }

        private void SaveEditsBtn_Click(object sender, EventArgs e)
        {
            if ((ScriptNameListBox.SelectedIndex != -1) && (SelectedFilePathTextBox.Text != ""))
            {
                int currentIndex = ScriptNameListBox.SelectedIndex;
                string selectedScript = ScriptNameListBox.SelectedItem.ToString();
                string newFilePath = SelectedFilePathTextBox.Text;
                FilePathListBox.Items[currentIndex] = newFilePath;
                scriptFileDict[selectedScript] = newFilePath;

                ScriptNameListBox.SelectedIndex = -1;
                SelectedScriptNameTextBox.Text = "";
                SelectedFilePathTextBox.Text = "";
                ErrorTextLabel.Visible = false;
            }
            else if((ScriptNameListBox.SelectedIndex == -1))
            {
                ErrorTextLabel.Text = "Please select a valid entry to edit.";
                ErrorTextLabel.Visible = true;
            }
            else
            {
                ErrorTextLabel.Text = "New file path cannot be blank.";
                ErrorTextLabel.Visible = true;
            }

        }

        private void AddNewScriptBtn_Click(object sender, EventArgs e)
        {
            if ((NewScriptNameTextBox.Text != "") && (NewFilePathTextBox.Text != ""))
            {
                string newScript = NewScriptNameTextBox.Text;
                string newFilePath = NewFilePathTextBox.Text;

                ScriptNameListBox.Items.Add(newScript);
                FilePathListBox.Items.Add(newFilePath);

                NewScriptNameTextBox.Text = "";
                NewFilePathTextBox.Text = "";
                scriptFileDict.Add(newScript, newFilePath);
                ErrorTextLabel.Visible = false;
            }
            else if((NewScriptNameTextBox.Text == ""))
            {
                ErrorTextLabel.Text = "New script name cannot be blank.";
                ErrorTextLabel.Visible = true;
            }
            else
            {
                ErrorTextLabel.Text = "New file path cannot be blank.";
                ErrorTextLabel.Visible = true;
            }
        }

        private void DeleteSelectedScriptBtn_Click(object sender, EventArgs e)
        {
            if (ScriptNameListBox.SelectedIndex != -1)
            {
                int currentIndex = ScriptNameListBox.SelectedIndex;
                string selectedScript = ScriptNameListBox.SelectedItem.ToString();
                ScriptNameListBox.SelectedIndex = -1;

                ScriptNameListBox.Items.RemoveAt(currentIndex);
                FilePathListBox.Items.RemoveAt(currentIndex);
                scriptFileDict.Remove(selectedScript);

                SelectedScriptNameTextBox.Text = "";
                SelectedFilePathTextBox.Text = "";
                NewScriptNameTextBox.Text = "";
                NewFilePathTextBox.Text = "";
                ErrorTextLabel.Visible = false;
            }
            else
            {
                ErrorTextLabel.Text = "Please select a valid entry to delete.";
                ErrorTextLabel.Visible = true;
            }
        }

        private void ResetChangesBtn_Click(object sender, EventArgs e)
        {
            scriptFileDict.Clear();
            DictInit(sender, e);
        }

        private void ExitAdminToolsBtn_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void FileSaveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                using var writer = new StreamWriter(automationFilesCSVPath);
                using var oldCSV = new CsvHelper.CsvWriter(writer, CultureInfo.InvariantCulture);

                oldCSV.WriteField("Script");
                oldCSV.WriteField("FilePath");
                oldCSV.NextRecord();

                foreach(var entry in scriptFileDict)
                {
                    oldCSV.WriteField(entry.Key);
                    oldCSV.WriteField(entry.Value);
                    oldCSV.NextRecord();
                }
                ErrorTextLabel.Visible = false;
            } catch
            {
                ErrorTextLabel.Text = "Failed to overwrite CSV.";
                ErrorTextLabel.Visible = true;
            }
        }
    }
}
