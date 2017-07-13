using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;

namespace MouseHookSample
{
    internal static class HookHandlers
    {
        private static int iKeypress;
        public static void HookManagerOnMouseClickExt(object sender, MouseEventExtArgs mouseEventExtArgs)
        {
            
            //The right mouse button was pressed
            if (mouseEventExtArgs.Button == MouseButtons.Right)
            {
                //This will fire twice, once for the mouse down and once for the mouse up. Let's only perform the action once.
                if (iKeypress == 1)
                {
                    //Perform the action, in this case, display a messagebox.
                    //always call the action on a new thread so it does not block the hook. 
                    //A messagebox will block so it must be displayed from a different thread
                    new Thread(() => { ExecuteAction(); }).Start();

                    //Setting this variable to true tells the hook not to pass this mouse input to the next hook.
                    mouseEventExtArgs.Handled = true;
                    iKeypress = 0;
                    return;
                }
                else
                {
                    iKeypress = 1;
                    mouseEventExtArgs.Handled = true;
                    return;
                }
            }

        }

        private static void ExecuteAction()
        {
            MouseInputAction.DisplayMessage("You right-clicked the mouse");
        }


    }
}