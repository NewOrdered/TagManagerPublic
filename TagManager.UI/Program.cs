using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using TagManager.Core.Models;

namespace TagManager.UI
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.ThreadException += new System.Threading.ThreadExceptionEventHandler(Application_ThreadException);

            //ILogger logger = new ConsoleLogger();
            ILogger logger = new TxtFileLogger();
            AccessNameManager accessNameManager = new AccessNameManager();
            AlarmGroupManager alarmGroupManager = new AlarmGroupManager();
            TagImporter tagImporter = new TagImporter(logger);
            TagExporter tagExporter = new TagExporter();
            TagStorage tagStorage = new TagStorage(tagImporter, tagExporter, alarmGroupManager, accessNameManager);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmMain(tagStorage));
        }

        static void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
        {// All exceptions thrown by the main thread are handled over this method

            ShowExceptionDetails(e.Exception);
        }
        static void ShowExceptionDetails(Exception Ex)
        {

            var innerExcpeption = Ex.InnerException;
            string lowestInnerExceptionMessage = "";
            while (innerExcpeption != null)
            {
                lowestInnerExceptionMessage = innerExcpeption.Message;
                innerExcpeption = innerExcpeption.InnerException;
            }

            // Do logging of exception details
            MessageBox.Show(Ex.Message + "\n" + lowestInnerExceptionMessage, Ex.TargetSite.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
