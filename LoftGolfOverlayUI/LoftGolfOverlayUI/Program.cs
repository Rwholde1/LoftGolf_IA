namespace LoftGolfOverlayUI
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
            /* 
             * TO DO:
             *      -ADD AN ARROW TO THE TOP PORTION OF OVERLAY TO INDICATE THE MENU CAN SLIDE UP
             *      -OnMouseEnter() INTO OVERLAY
             *          -- INCREASE FORM OPACITY TO 100%
             *          -- CHANGE TRANSFORM OF THE FORM TO SLIDE UP
             *      -OnMouseExit() FROM OVERLAY
             *          -- DECREASE FORM OPACITY TO 80%
             *          -- CHANGE TRANSFORM OF THE FORM TO SLIDE DOWN
             *      -KEEP FORM ON SCREEN ABOVE EVERYTHING
             *      -PROGRAM BUTTONS
             */
        }
    }
}