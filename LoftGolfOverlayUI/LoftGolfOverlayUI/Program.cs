using Microsoft.VisualBasic.ApplicationServices;
using CsvHelper;
using System.Globalization;
using System.Diagnostics;

namespace LoftGolfOverlayUI
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        /// 
        private static Form currentForm;
        private static string automationFilesCSVPath = @"C:\Users\Rowan\Documents\Unity\LoftGolf_IA\Admin Tools\LoftGolf_AdminTools\LoftGolf_AdminTools\LoftGolf_UIAutomation.csv"; //Change this if the CSV's file path changes
        public static Dictionary<string, string> scriptFileDict = new Dictionary<string, string>();
        public static string automationScriptsFilePath = @"C:\Users\Rowan\Documents\Unity\LoftGolf_IA\LoftGolfOverlayUI\LoftGolfOverlayUI\"; //This path should be set at the folder containing all automation scripts and videos
        private static string ahkexe = @"C:\Program Files\AutoHotkey\v2\AutoHotkey64_UIA.exe"; //This path is whereever the file used to run AHK script is
        private static Process? ahkProcess;

        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            // Form2.activity currActivity = Form2.activity.golf;
            currentForm = new Form2();
            DictInit();
            ahkProcess = null;
            Application.Run(currentForm);
            /* 
             * TO DO:
             *     O -ADD AN ARROW TO THE TOP PORTION OF OVERLAY TO INDICATE THE MENU CAN SLIDE UP
             *          -- ADD ICONS FOR ALL BUTTONS AS WELL
             *          --- DONE !!!
             *     O - ON STARTUP SET POSITION OF OVERLAY
             *          -- CHANGE TRANSFORM OF THE FORM TO SIT IN THE MIDDLE BOTTOM OF THE SCREEN
             *          --- DONE !!! *see form1.cs form1 constructor
             *     O -OnMouseEnter() INTO OVERLAY
             *          -- INCREASE FORM OPACITY TO 100%
             *          -- CHANGE TRANSFORM OF THE FORM TO SLIDE UP
             *     O -OnMouseExit() FROM OVERLAY
             *          -- DECREASE FORM OPACITY TO 80%
             *          -- CHANGE TRANSFORM OF THE FORM TO SLIDE DOWN
             *     O -KEEP FORM ON SCREEN ABOVE EVERYTHING
             *     X -PROGRAM BUTTONS
             */
        }

        public static void changeForm(Form form)
        {
            if(currentForm != null)
            {
                currentForm.Hide();
            }
            
            currentForm = form;
            currentForm.Show();
        }

        public static Dictionary<string, string> retrieveDict()
        {
            return scriptFileDict; 
        }

        public static string retrieveScriptsFilePath()
        { 
            return automationScriptsFilePath;
        }

        private class DictEntry
        {
            public string Script { get; set; }
            public string FilePath { get; set; }
        }

        public static void DictInit()
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
            }
            catch
            {
                MessageBox.Show("Failed to fetch CSV.");
            }
        }

        public static void runAHKScript(string scriptPath)
        {
            //stopAHKScript(); //In initial implementation

            ProcessStartInfo psi = new ProcessStartInfo
            {
                FileName = ahkexe,
                Arguments = $"\"{scriptPath}\"",
                UseShellExecute = true
            };

            try
            {
                ahkProcess = Process.Start(psi);
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Error launching AHK script: " + ex.Message);
            }
        }
    }
}