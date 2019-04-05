using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MiniTC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            miniTCPanel1.CurrentPath = "C:\\";
            miniTCPanel1.Drives = Directory.GetLogicalDrives();
            miniTCPanel1.SelectedDriveChange += MiniTCPanel1_SelectedDriveChange;
            miniTCPanel1.CurrentPathChange += MiniTCPanel1_CurrentPathChange;




            //string[] getFiles = Directory.GetFiles(CurrentPath);
            //string[] getDirectories = Directory.GetDirectories(CurrentPath);
        }

        private void MiniTCPanel1_SelectedDriveChange()
        {
            miniTCPanel1.CurrentPath = miniTCPanel1.SelectedDrive;
        }

        private void MiniTCPanel1_CurrentPathChange()
        {
            miniTCPanel1.CurrentPath = miniTCPanel1.SelectedFile;
        }
    }
}
