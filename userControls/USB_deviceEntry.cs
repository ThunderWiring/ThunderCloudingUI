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
    public partial class USB_deviceEntry : UserControl
    {
        private string _name; //name of the usb device.
        private readonly Color selectColor;

        public event EventHandler DeviceSelected;

        public USB_deviceEntry()
        {
            InitializeComponent();
            selectColor = Color.FromArgb(229, 236, 49);
        }

        public USB_deviceEntry(string name)
        {
            InitializeComponent();
            this._name = name;
            deviceName_label.Text = _name;
            selectColor = Color.FromArgb(229, 236, 49);
        }

        private void USB_deviceEntry_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(163, 163, 163);
        }

        private void USB_deviceEntry_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(58, 58, 58);
        }

        private void USB_deviceEntry_MouseClick(object sender, MouseEventArgs e)
        {
            BackColor = selectColor;
        }

        /// <summary>
        /// Should trigger an event to creat a fileView data and change the current userControl
        /// from homePage to fileView.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void USB_deviceEntry_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (DeviceSelected != null)
            {
                DeviceSelected(sender, e);
            }
        }
    }
}
