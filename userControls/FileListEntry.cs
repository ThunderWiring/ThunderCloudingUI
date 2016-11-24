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
    public partial class FileListEntry : UserControl
    {
        private readonly Color initialBackColor;
        private readonly Color selectColor;
        private Color currentBackColor;

        public FileListEntry()
        {
            InitializeComponent();
            initialBackColor = Color.FromArgb(236,236,236);
            selectColor = Color.FromArgb(229, 236, 49);
            currentBackColor = Color.Empty;
        }
        public FileListEntry(string fileName)
        {
            InitializeComponent();
            fileName_label.Text = fileName;
            initialBackColor = Color.FromArgb(236, 236, 236);
            selectColor = Color.FromArgb(229, 236, 49);
        }

        #region Set-Get Properties
        public Color GetInitialBackColor
        {
            get { return this.initialBackColor; }
        }

        public Color GetSelectionBackColor
        {
            get { return this.selectColor; }
        }


        public Color GetBackColor
        {
            get { return tableLayoutPanel.BackColor; }
        }

        public Color SetBackColor
        {
            set { tableLayoutPanel.BackColor = value; }
        }

        public string GetName
        {
            get { return this.fileName_label.Text; }
        }
        

        #endregion //Set-Get Properties

        /// <summary>
        /// change the back color to selection color.
        /// If the value of 'selector' true, then the entry gets selected and collor changed regardless of 
        /// its previous state.
        /// </summary>
        public void SelectFile(bool selector)
        {
            if (selector == true)
            {
                tableLayoutPanel.BackColor = selectColor;
                return;
            }

            if (tableLayoutPanel.BackColor != selectColor)
            {
                tableLayoutPanel.BackColor = selectColor;
            }
            else
            {
                if (currentBackColor != Color.Empty)
                    tableLayoutPanel.BackColor = currentBackColor;
                else
                    tableLayoutPanel.BackColor = initialBackColor;
            }
        }

        public void RemoveSelection(int index)
        {
            tableLayoutPanel.BackColor = initialBackColor;
            AlternateBackColor(index);            
        }
        public void AlternateBackColor(int count)
        {
            if (0 != count % 2)
            {
                tableLayoutPanel.BackColor = Color.FromArgb(224,224,224);
                currentBackColor = Color.FromArgb(224, 224, 224);
            }
        }

        private void fileName_label_MouseClick(object sender, MouseEventArgs e)
        {
            SelectFile(false);
        }


    }
}
