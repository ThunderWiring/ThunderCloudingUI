using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThunderClouding
{
    public partial class MainFormClass : Form
    {
        private Stack<Control> controlHistory;
        public MainFormClass()
        {
            InitializeComponent();
            controlHistory = new Stack<Control>();
            controlHistory.Push(homePage);
            this.homePage.InitFileViewInForm += new EventHandler(StartFileView_Event);            
        }



        private void label_X_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void fileViewer_Load(object sender, EventArgs e)
        {

        }


        protected void device_chosen_formHandling(object sender, EventArgs e)
        {
            fileViewer.BringToFront();
            controlHistory.Push(fileViewer);
        }

        private void listView_button_Click(object sender, EventArgs e)
        {
            if (controlHistory.Count <= 1)
            {
                return;
            }
            Control curr_ctrl = controlHistory.Pop();
            curr_ctrl.BringToFront();
        }

        private void homePage_button_Click(object sender, EventArgs e)
        {
            if (controlHistory.Peek() != homePage)
            {
                controlHistory.Push(homePage);
            }
            homePage.BringToFront();
        }

        protected void StartFileView_Event(object sender, EventArgs e)
        {
            this.fileViewer.BringToFront();
        }
    }
}
