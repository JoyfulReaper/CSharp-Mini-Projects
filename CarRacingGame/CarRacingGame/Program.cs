// <div>Icons made by <a href="https://www.flaticon.com/authors/freepik" title="Freepik">Freepik</a> from <a href="https://www.flaticon.com/" title="Flaticon">www.flaticon.com</a></div>
// https://www.youtube.com/watch?v=xyggRDkoOwU
// Not perfect but my take on car racing game from YouTube. Will try to improve later

using System;
using System.Windows.Forms;

namespace CarRacingGame
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new CarRacingForm());
        }
    }
}
