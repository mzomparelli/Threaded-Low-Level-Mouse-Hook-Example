using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MouseHookSample
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
            Application.Run(new Form1());
        }



        public static Thread MouseHook = null;
        private static bool blnStopMouseHook = false;
        public static void StartMouseHook()
        {
            if (MouseHook == null)
            {
                blnStopMouseHook = false;
                MouseHook = new Thread(new ThreadStart(() => { MouseHookThread(); }));
                MouseHook.SetApartmentState(ApartmentState.STA);
                MouseHook.Start();
            }
        }

        public static void StopMouseHook()
        {
            if (MouseHook != null)
            {
                blnStopMouseHook = true;
                MouseHook.Join();
                MouseHook = null;
            }
        }

        private static void MouseHookThread()
        {
            HookManager.MouseClickExt += HookHandlers.HookManagerOnMouseClickExt;
            do
            {
                System.Threading.Thread.Sleep(1);
                Application.DoEvents();
            } while (blnStopMouseHook == false);

            HookManager.MouseClickExt -= HookHandlers.HookManagerOnMouseClickExt;

        }
    }
}
