using AltoHttp;
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
using System.Net;


namespace VM_Downloader_Pro
{
    public partial class Filed : Form
    {
        public Filed()
        {
            InitializeComponent();
        }
        private HttpDownloader httpDownloader = null;


        private void btnStart_Click(object sender, EventArgs e)
        {
            httpDownloader = new HttpDownloader(txtUrl.Text, $"{Application.StartupPath}\\{Path.GetFileName(txtUrl.Text)}");
            httpDownloader.DownloadCompleted += HttpDownloader_DownloadCompleted;
            httpDownloader.ProgressChanged += HttpDownloader_ProgressChanged;
            httpDownloader.Start();
        }

        private void HttpDownloader_DownloadCompleted(object sender, EventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                lblstatus.Text = "Finish";
                lblpercent.Text = "100%";
            }

                );
        }
        

        

        private void HttpDownloader_ProgressChanged(object sender, AltoHttp.ProgressChangedEventArgs e)
        {
            progressBar1.Value = (int)e.Progress;
            lblpercent.Text = $"{e.Progress.ToString("0.00")} % ";
            lblspeed.Text = string.Format("{0} MB/s", (e.SpeedInBytes / 1024d / 1024d).ToString("0.00"));
            lblsize.Text = string.Format("{0} MB", (httpDownloader.TotalBytesReceived / 1024d / 1024d).ToString("0.00"));
            lblstatus.Text = "Downloading...";
        }
        private void btnPause_Click(object sender, EventArgs e)
        {
            httpDownloader.Pause();
        }

        private void btnResume_Click(object sender, EventArgs e)
        {
            httpDownloader.Resume();
        }

        private void Filed_Load(object sender, EventArgs e)
        {

        }
    }
}
