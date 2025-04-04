using Microsoft.VisualBasic.ApplicationServices;

namespace LoftGolfOverlayUI
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        /// 
        private static Form currentForm;

        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            // Form2.activity currActivity = Form2.activity.golf;
            currentForm = new Form2();
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

        
    }
}