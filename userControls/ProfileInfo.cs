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
    public partial class ProfileInfo : UserControl
    {
        public event EventHandler NameUpdate;

        public ProfileInfo()
        {
            InitializeComponent();
        }

        public string UserName
        {
            get { return username_textBox.Text; }
        }

        private void highlightControlBorder_Event(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Pen pen = new Pen(Color.BlueViolet, 5);
            Rectangle rect = new Rectangle(((TextBox)(sender)).Location, ((TextBox)(sender)).Size);
            g.DrawRectangle(pen, rect);
        }

        private void removeHighlightFromBoarder_Event(object sender, EventArgs e)
        {
            this.Invalidate();
        }

        private void deleteFile_button_Click(object sender, EventArgs e)
        {
            username_textBox.ReadOnly = false;
            username_textBox.Cursor = Cursors.IBeam;
        }

        private void ok_profileInfo_button_Click(object sender, EventArgs e)
        {            
            if (NameUpdate != null)
            {
                NameUpdate(sender, e);
            }
        }

        private void cancel_profileInfo_button_Click(object sender, EventArgs e)
        {
            this.SendToBack();
        }
    }
}
