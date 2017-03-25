using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace luval_dragdrop_sink
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void listFiles_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
        }

        private void listFiles_DragDrop(object sender, DragEventArgs e)
        {
            var files = (string[])e.Data.GetData(DataFormats.FileDrop);
            foreach (string file in files)
                listFiles.Items.Add(new ListViewItem(file)
                {
                    
                });
        }

        private void listFiles_Resize(object sender, EventArgs e)
        {
            SetColumnSize();
        }

        private void SetColumnSize()
        {
            listHeader.Width = (int)(listFiles.Width * 0.95);

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            SetColumnSize();
        }
    }
}
