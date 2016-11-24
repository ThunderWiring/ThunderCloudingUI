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
    /// <summary>
    /// Handlig the functionality of the user control of FileViewer
    /// </summary>
    public partial class FileViewer : UserControl
    {
        private int fileCount = 0; /* Number of files been viewed */
        private List<FileListEntry> filesList;
        private List<FileGridView> filesGrid;
        private MenuView menuShape;
        private readonly int gridFiles_Y_spacing;
        private readonly int gridFiles_X_spacing;
        private readonly int x_pivot;
        private Point lastGridFilePosition;

        public enum MenuView { GRID, LIST };
        public FileViewer()
        {
            InitializeComponent();
            filesList = new List<FileListEntry>();
            filesGrid = new List<FileGridView>();
            menuShape = MenuView.LIST;
            lastGridFilePosition = new Point();

            x_pivot = 3;
            gridFiles_X_spacing = 25;
            gridFiles_Y_spacing = 17;
        }

        public void addFile()
        {
            if (menuShape == MenuView.LIST)
            {
                FileListEntry newFile = new FileListEntry("E:/path/to/file" + fileCount.ToString())
                {
                    Dock = DockStyle.Top,
                    Tag = fileCount
                };
                filesList.Add(newFile);
                newFile.AlternateBackColor(fileCount);
                fileHost_panel.Controls.Add(newFile);
            }
            else if (menuShape == MenuView.GRID)
            {
                FileGridView newFile = new FileGridView("E:/path/to/file" + fileCount.ToString()) 
                {
                    Location = getGridFilePosition()
                };
                filesGrid.Add(newFile);
                fileHost_panel.Controls.Add(newFile);
            }            
            fileCount++;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private Point getGridFilePosition()
        {
            FileGridView dummy = new FileGridView();
            int items = filesGrid.Count;
            if (lastGridFilePosition.X < fileHost_panel.Width - 2 * dummy.Width - gridFiles_X_spacing)
            {
                lastGridFilePosition.X += dummy.Width + gridFiles_X_spacing;
            }
            else
            {
                lastGridFilePosition.X = x_pivot;
                lastGridFilePosition.Y += gridFiles_Y_spacing + dummy.Height;
            }
            return lastGridFilePosition;
        }

        /// <summary>
        /// populates the filesGrid List with the current displayed files as a list.
        /// </summary>
        private void switchToGrid()
        {
            menuShape = MenuView.GRID;
            filesGrid.Clear();
            foreach (var file in filesList)
            {
                FileGridView file_grid = new FileGridView(file.GetName);
                filesGrid.Add(file_grid);
            }
            fileHost_panel.Controls.Clear();
            foreach (var file in filesGrid)
            {
                fileHost_panel.Controls.Add(file);
            }

            int curr_x = 3, curr_y = 0;
            fileCount = 0;
            FileGridView dummy = new FileGridView();
            while (fileCount < filesGrid.Count && curr_x < fileHost_panel.Width 
                && curr_y < fileHost_panel.Height)
            {
                while (curr_x < fileHost_panel.Width - dummy.Width && fileCount < filesGrid.Count)
                {
                    lastGridFilePosition = new Point(curr_x, curr_y);
                    filesGrid[fileCount].Location = lastGridFilePosition;
                    fileHost_panel.Controls.Add(filesGrid[fileCount]);
                    fileCount++;
                    curr_x += dummy.Width + gridFiles_X_spacing;
                }
                curr_x = x_pivot;
                curr_y += gridFiles_Y_spacing + dummy.Height;
            }
        }

        private void switchToList()
        {
            menuShape = MenuView.LIST;
            fileHost_panel.Controls.Clear();
            filesList.Clear();
            fileCount = 0;
            foreach (var file in filesGrid)
            {
                FileListEntry newFile = new FileListEntry(file.FileName)
                {
                    Dock =  DockStyle.Top,
                    Tag = fileCount
                };
                filesList.Add(newFile);
                newFile.AlternateBackColor(fileCount);
                fileHost_panel.Controls.Add(newFile);
                fileCount++;
            }
        }

        /***********************************************************************************/
        /*                                Event Handlers                                   */
        /***********************************************************************************/
        private void selectAll_button_Click(object sender, EventArgs e)
        {
            
            if ((menuShape == MenuView.GRID && filesGrid.Count == 0) ||
                (menuShape == MenuView.LIST && filesList.Count == 0))
            {
                return;
            }
            else if (selectAll_button.Text == "Select All")
            {
                selectAll_button.Text = "Undo";
                selectAll_button.BackColor = Color.Gold;

                deleteFile_button.Enabled = true;
                downloadAll_button.Enabled = true;
                foreach (var file in filesList)
                {
                    file.SelectFile(true);
                }
            }
            else
            {
                selectAll_button.Text = "Select All";
                selectAll_button.BackColor = Color.Goldenrod;

                deleteFile_button.Enabled = false;
                downloadAll_button.Enabled = false;
                int index = 0;
                foreach (var file in filesList)
                {
                    file.RemoveSelection(index);
                    index++;
                }
            }

            
        }

        private void upload_button_Click(object sender, EventArgs e)
        {
            addFile();
        }

        /// <summary>
        /// Switch all the entries in the Host panel to grid view rather than list.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gridView_button_Click(object sender, EventArgs e)
        {
            if (menuShape == MenuView.GRID)
                return;
            switchToGrid();
        }

        private void listView_button_Click(object sender, EventArgs e)
        {
            if (menuShape == MenuView.LIST)
                return;
            switchToList();
        }
    }
}
