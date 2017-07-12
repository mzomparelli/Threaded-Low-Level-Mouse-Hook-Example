using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MouseHookSample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStartMouseHook_Click(object sender, EventArgs e)
        {
            Program.StartMouseHook();
            MessageBox.Show(
                "The mouse hook has been started on a separate thread. Now when you right-click you will see a messagebox showing that the hook captured it. When you close the form the Hook will be unloaded so don't worry about pressing StopMouseHook.");
        }

        private void btnStopMouseHook_Click(object sender, EventArgs e)
        {
            Program.StopMouseHook();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.StopMouseHook();
        }

        private void btnGUIProcess_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= 9; i++)
            {
                System.Threading.Thread.Sleep(1000);
            }
        }
    }
}
