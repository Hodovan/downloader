using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Diagnostics;


namespace Downloader
{
    public partial class Main : Form
    {


        WebClient client = new WebClient();
        public Main()
        {
            InitializeComponent();
        }

        private void btnDownloadSync_Click(object sender, EventArgs e)
        {
            // DOWNLOAD HAS THE EFFECT OF FREEZING THE INTERFACE WHILE DOWNLOAD OCCURS
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                client.DownloadFile("https://github.com/git-for-windows/git/releases/download/v2.26.2.windows.1/Git-2.26.2-64-bit.exe", saveFileDialog.FileName);
            }
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe","/select," + saveFileDialog.FileName);
        }

        private void btnDownloadAsync_Click(object sender, EventArgs e)
        {
            // THE INTERFACE DOES NOT FREEZE DURING THE DOWNLOAD
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                client.DownloadFileAsync(new Uri("https://github.com/git-for-windows/git/releases/download/v2.26.2.windows.1/Git-2.26.2-64-bit.exe"), saveFileDialog.FileName);
            }
        }
    }
}
