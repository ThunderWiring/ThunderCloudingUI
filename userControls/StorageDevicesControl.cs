using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThunderClouding.userControls
{
    public partial class StorageDevicesControl : UserControl
    {
        private int devicesCount;
        private List<USB_deviceEntry> devices;

        public event EventHandler TriggerFileView;

        public StorageDevicesControl()
        {
            InitializeComponent();
            devicesCount = 0;
            devices = new List<USB_deviceEntry>();
        }

        private void refreshDevices_button_Click(object sender, EventArgs e)
        {
            // adds a new disscovered USB device entry.
            devicesCount++;
            
            USB_deviceEntry newDevice = new USB_deviceEntry("D"+devicesCount.ToString());

            Point newLocation = new Point(devicesCtrl_panel.Location.X,
                devicesCtrl_panel.Location.Y + devicesCount * newDevice.Height + 1);
            newDevice.Location = newLocation;
            newDevice.Dock = DockStyle.Top;
            newDevice.DeviceSelected += new EventHandler(USB_entry_Clicked);
            devices.Add(newDevice);
            devices_panel.Controls.Add(newDevice);
        }

        protected void USB_entry_Clicked(object sender, EventArgs e)
        {
            if (TriggerFileView != null)
            {
                TriggerFileView(sender, e);
            }
        }
    }
}
