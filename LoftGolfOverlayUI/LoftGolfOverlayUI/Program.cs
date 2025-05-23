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
        private static string automationFilesCSVPath = @"C:\LOFT\LoftGolf_UIAutomation.csv"; //Change this if the CSV's file path changes
        public static Dictionary<string, string> scriptFileDict = new Dictionary<string, string>();
        private static string ahkexe; //This path is whereever the file used to run AHK scripts is
        private static Process? ahkProcess;

        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            // Form2.activity currActivity = Form2.activity.golf;
            DictInit();
            currentForm = new HomeScreen();
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

                ahkexe = scriptFileDict["AHK EXE"];
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