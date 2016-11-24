using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThunderClouding.ThunderClouding_Widgets
{
    public partial class TC_CircularProgressBar : UserControl
    {
        private int progress;
        public TC_CircularProgressBar()
        {
            progress = 100;
            InitializeComponent();
            this.BackColor = Color.Transparent;
        }

        public int Progress
        {
            get { return this.progress; }
            set { this.progress = value; }
        }

        private void TC_CircularProgressBar_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.TranslateTransform(this.Width / 2, this.Height / 2);
            e.Graphics.RotateTransform(-90);
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            Pen obj_pen = new Pen(Color.Red);

            Rectangle rect1 = new Rectangle(0 - this.Width / 2 + 25 ,0 - this.Height / 2 + 25, 
                            this.Width - 50, this.Height - 50);
            e.Graphics.DrawPie(obj_pen, rect1, 0, (int)(progress * 3.6)); // 360/100 = 3.6
            e.Graphics.FillPie(new SolidBrush(Color.Red), rect1, 0, (int)(progress * 3.6));

            obj_pen = new Pen(Color.White);
            rect1 = new Rectangle(0 - this.Width / 2 + 30, 0 - this.Height / 2 + 30,
                            this.Width - 60, this.Height - 60);
            e.Graphics.DrawPie(obj_pen, rect1, 0, (int)(progress * 3.6));
            e.Graphics.FillPie(new SolidBrush(Color.White), rect1, 0, (int)(progress * 3.6));

            e.Graphics.RotateTransform(90);
            StringFormat format = new StringFormat();
            format.LineAlignment = StringAlignment.Center;
            format.Alignment = StringAlignment.Center;
            e.Graphics.DrawString("0%", new Font("Arial", 9), new SolidBrush(Color.Red), rect1, format);
        }
        
    }
}
