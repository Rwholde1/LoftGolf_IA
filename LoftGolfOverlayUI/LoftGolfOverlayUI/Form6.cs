using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoftGolfOverlayUI
{
    public partial class Form6 : Form
    {
        // use UIA + .ahk script method instead of direct exe method
        private const string ahkexe = @"C:\Program Files\AutoHotkey\v2\AutoHotkey64_UIA.exe";
        private const string exampleScript = @"C:\Users\heidk\OneDrive\Documents\AutoHotkey\exampleScript.ahk";
        private const string exampleExe = @"C:\Users\heidk\OneDrive\Documents\AutoHotkey\exampleScript.exe";
        private const string runGSPROReconnect = @"C:\LOFT\AutoHotkey\ResetGSProConnect.ahk";
        private const string fullSimRestart = @"C:\LOFT\LoftUI\Loft_Full_Reset_Sim.exe"; // exe or ahk?
        private const string fullSystemReboot = @"C:\LOFT\AutoHotkey\LoftFullRestart.ahk";
        private static Process ahkProcess;

        private Form2.activity currActivity;
        private int yesCount;
        private int noCount;
        private string stage;
        private bool special;
        private ProcessStartInfo psi;
        public Form6(Form2.activity newActivity)
        {
            InitializeComponent();
            currActivity = newActivity;
            yesCount = 0;
            noCount = 0;
            stage = "";
            special = false;
            ahkProcess = null;
            this.TopMost = true;
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1(currActivity);
            form1.Show();
            this.Hide();
        }

        private void endHelp()
        {
            questionLabel.Text = "We are glad that we were able to help you out! Please select Return to go back to your activity.";
            yesButton.Visible = false;
            noButton.Visible = false;
        }

        private void rebootSystem()
        {
            questionLabel.Text = "We will fully reboot the system. If the issue is not resolved after this, please contact Loft Golf Studios via phone/email during business hours so we can make it up to you.";
            yesButton.Visible = false;
            noButton.Visible = false;
            runAHKScript(fullSystemReboot);
        }

        private void stopAHKScript()
        {
            if (ahkProcess != null && !ahkProcess.HasExited)
            {
                ahkProcess.Kill();
                ahkProcess.Dispose();
                ahkProcess = null;
            }
        }

        private void runAHKScript(string scriptPath)
        {
            stopAHKScript();

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

        private void runAHKExe(string exePath)
        {
            stopAHKScript();

            try
            {
                Process.Start(exePath);
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Error launching exe script: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e) // yes button
        {
            // this represents the previous string of answers
            // (ex: YN means from the start of troubleshooting, user answered yes, and then no to the next question)
            switch (stage)
            {
                case "":
                    questionLabel.Text = "Is there more than 1 ball in or near the hitting area?";
                    break;
                case "Y":
                    questionLabel.Text = "Remove all but one golf ball from hitting area. Is the issue resolved?";
                    break;
                case "YY":
                    endHelp();
                    break;
                case "N":
                    questionLabel.Text = "Please book additional time at least 20 minutes prior to the end of the scheduled session.";
                    yesButton.Visible = false;
                    noButton.Visible = false;
                    break;
                case "NN":
                    endHelp();
                    break;
                case "NNN":
                    endHelp();
                    break;
                case "YN":
                    questionLabel.Text = "Running automation to reconnect GSPro. Wait until the line turns green in the bottom right corner of the window. DO NOT CLOSE: the \"Uneekor Connect\" window or GSPro will not work. After this has finished, is the issue resolved?";
                    runAHKScript(runGSPROReconnect);
                    break;
                case "YNY":
                    endHelp();
                    break;
                case "YNN":
                    questionLabel.Text = "Is there an active session in view?";
                    break;
                case "YNNY":
                    questionLabel.Text = "Refreshing in Uneekor Launcher. After this is accomplished, is the issue resolved?";
                    special = true;
                    stage = "NN";
                    break;
                case "YNNN":
                    endHelp();
                    break;
                case "YNYN":
                    endHelp();
                    break;
                case "YNNYY":
                    endHelp();
                    break;
                case "YNNYN":
                    endHelp();
                    break;
            }

            // if a special case where we want to set the specific stage for simplicity, otherwise add the option the user chose to our stage
            if (!special)
            {
                stage += "Y";
            }
            else
            {
                special = false;
            }

        }

        private void button3_Click(object sender, EventArgs e) // no button
        {
            // this represents the previous string of answers
            // (ex: YN means from the start of troubleshooting, user answered yes, and then no to the next question)
            switch (stage)
            {
                case "":
                    questionLabel.Text = "Has your scheduled time expired?";
                    break;
                case "N":
                    questionLabel.Text = "Check the switch on the wall and turn on.\nAfter you have done this and Uneekor Launcher has refreshed, is the issue resolved?";
                    break;
                case "NN":
                    questionLabel.Text = "We will perform a full sim restart. After this is performed, is the issue resolved?";
                    break;
                case "NNN":
                    rebootSystem();
                    break;
                case "Y":
                    questionLabel.Text = "Is the shot detected in VIEW? This can be checked on the side monitor.";
                    break;
                case "YN":
                    questionLabel.Text = "Is the system logged into the VIEW session?";
                    break;
                case "YY":
                    questionLabel.Text = "Is the shot detected in VIEW? This can be checked on the side monitor.";
                    stage = "YN";
                    special = true;
                    break;
                case "YNN":
                    questionLabel.Text = "We are logging into the view session. After this is accomplished, is the issue resolved?";
                    break;
                case "YNY":
                    questionLabel.Text = "We will perform a full sim restart. After this is performed, is the issue resolved?";
                    break;
                case "YNYN":
                    rebootSystem();
                    break;
                case "YNNN":
                    questionLabel.Text = "Refreshing in Uneekor Launcher. After this is accomplished, is the issue resolved?";
                    special = true;
                    stage = "NN";
                    break;
                case "YNNY":
                    questionLabel.Text = "Adding session in View. After this is accomplished, is the issue resolved?";
                    break;
                case "YNNNN":
                    questionLabel.Text = "We will perform a full sim restart. After this is performed, is the issue resolved?";
                    break;
                case "YNNYN":
                    questionLabel.Text = "Refreshing in Uneekor Launcher. After this is accomplished, is the issue resolved?";
                    special = true;
                    stage = "NN";
                    break;
                case "YNNNNN":
                    rebootSystem();
                    break;
                case "YNNYNN":
                    questionLabel.Text = "We will perform a full sim restart. After this is performed, is the issue resolved?";
                    break;
                case "YNNYNNN":
                    rebootSystem();
                    break;
            }

            if (!special)
            {
                stage += "N";
            }
            else
            {
                special = false;
            }
        }
    }
}
