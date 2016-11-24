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
    public partial class MenuGridList : UserControl 

    {
        /// <summary>
        /// Define the organization of the items in the menu; either as List or Grid
        /// </summary>
        private enum MenuShape {Grid, List};
        private int itemsCount;
        private int numberOfColumns;

        public MenuGridList(int col_num = 1)
        {
            InitializeComponent();
            itemsCount = 0;
            numberOfColumns = col_num;
        }

        #region Properties
        public int Count 
        {
            get { return this.itemsCount; }
        }
        #endregion //Properties
        
        public void AddRow()
        { 
            
        }

        public void RemoveRow()
        { 
        
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
