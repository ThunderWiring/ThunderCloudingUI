using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThunderClouding
{
    public partial class homePage : UserControl
    {

        public event EventHandler InitFileViewInForm;

        public homePage()
        {
            InitializeComponent();
            storageDevicesControl.BringToFront();
            this.storageDevicesControl.TriggerFileView += new EventHandler(initFileView);
            profileInfo.NameUpdate += new EventHandler(updateUserNameLable_Event);
        }

        /// <summary>
        /// Adjusts the length of the panel underline according to the 
        /// currently pressed button's length.
        /// </summary>
        /// <param name="newLocation"></param>
        /// <param name="newSize"></param>
        private void resizeUnderLinePanel(Point newLocation, Size newSize)
        {
            underLine_panel.Location = newLocation;
            underLine_panel.Size = newSize;
            underLine_panel.BringToFront();
        }

        private void updateUserNameLable_Event(object sender, EventArgs e)
        {
            username_label.Text = profileInfo.UserName;
        }

        private void usbDevices_button_Click(object sender, EventArgs e)
        {
            storageDevicesControl.BringToFront();
            resizeUnderLinePanel(new Point(usbDevices_button.Location.X, underLine_panel.Location.Y),
                new Size(usbDevices_button.Width, underLine_panel.Size.Height));
        }

        private void myProfile_button_Click(object sender, EventArgs e)
        {
            profileInfo.BringToFront();

            resizeUnderLinePanel(new Point(myProfile_button.Location.X, underLine_panel.Location.Y),
                            new Size(myProfile_button.Width, underLine_panel.Size.Height));
        }

        protected void initFileView(object sender, EventArgs e)
        {
            if (InitFileViewInForm != null)
            {
                InitFileViewInForm(sender, e);
            }
        }

    }
}
