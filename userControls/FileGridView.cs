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
    public partial class FileGridView : UserControl
    {

        private string fileName, size, dateModified, type;
        
        public FileGridView()
        {
            InitializeComponent();
        }
        public FileGridView(string name, 
                        string size, string dateModified, string type)
        {
            InitializeComponent();
            this.fileName = name;
            this.size = size;
            this.dateModified = dateModified;
            this.type = type;
            fileDescription_richTextBox.Text = fileName;
        }

        public FileGridView(string name)
        {
            InitializeComponent();
            this.fileName = name;
            fileDescription_richTextBox.Text = fileName;
        }

        #region Set-Get Properties
        public string FileName
        {
            get { return this.fileName; }
        }

        public string FileSize
        {
            get { return this.size; }
        }

        public string DateModified
        {
            get { return dateModified; }
        }

        public string FileType
        {
            get { return type; }
        }
        #endregion //Set-Get Properties


        /***********************************************************************************/
        /*                                Event Handlers                                   */
        /***********************************************************************************/

    }
}
