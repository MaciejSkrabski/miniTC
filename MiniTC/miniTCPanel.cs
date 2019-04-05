using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MiniTC
{
    

    public partial class miniTCPanel : UserControl
    {

        #region Properties

        public string CurrentPath
        {
            get
            {
                return path.Text;
            }
            set
            {
                path.Text = value;
            }
        }

        public string[] Drives
        {
            set
            {
                drives.Items.AddRange(value);
            }
        }

        public string SelectedDrive
        {
            get
            {
                return drives.SelectedItem.ToString();
            }
        }

        public string SelectedFile
        {
            get
            {
                return files.SelectedItem.ToString();
            }
        }


        #endregion

        #region events

        public event Action SelectedDriveChange;
        public event Action CurrentPathChange;
        #endregion


        public miniTCPanel()
        {
            InitializeComponent();
        }

        private void drives_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (drives.SelectedIndex > -1)
                if (SelectedDriveChange != null)
                    SelectedDriveChange();
        }

        private void files_SelectedIndexChanged(object sender, EventArgs e)
        {
            CurrentPathChange();
        }

        private void path_TextChanged(object sender, EventArgs e)
        {
            files.Items.Clear();

            try
            {
                string[] Files = Directory.GetFiles(CurrentPath);
                string[] Directories = Directory.GetDirectories(CurrentPath);
                foreach (string i in Files)
                    files.Items.Add(i);
                foreach (string i in Directories)
                    files.Items.Add(i);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }

    
}
