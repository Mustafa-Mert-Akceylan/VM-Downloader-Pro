using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;
using VideoLibrary;
using MediaToolkit;
using System.Net;


namespace VM_Downloader_Pro
{
    public partial class Form1 : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
        (
              int nLeftRect,
              int nTopRect,
              int nRightRect,
              int nBottomRect,
              int nWidthEllipse,
              int nHeightEllipse

        );
        public Form1()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            panel1.Height = mainbutton.Height;
            panel1.Top = mainbutton.Top;
            panel1.Left = mainbutton.Left;

            title.Text = "Main Menu";
            MainMenu frmDashboard_vrb = new MainMenu() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmDashboard_vrb.FormBorderStyle = FormBorderStyle.None;
            this.mainpanel.Controls.Add(frmDashboard_vrb);
            frmDashboard_vrb.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void mainbutton_Click(object sender, EventArgs e)
        {
            panel1.Height = mainbutton.Height;
            panel1.Top = mainbutton.Top;
            panel1.Left = mainbutton.Left;
            title.Text = "Main Menu";
            this.mainpanel.Controls.Clear();
            MainMenu mainMenu_vrb = new MainMenu() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            mainMenu_vrb.FormBorderStyle = FormBorderStyle.None;
            this.mainpanel.Controls.Add(mainMenu_vrb);
            mainMenu_vrb.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void mp3button_Click(object sender, EventArgs e)
        {
            panel1.Height = mp3button.Height;
            panel1.Top = mp3button.Top;
            panel1.Left = mp3button.Left;
            title.Text = "MP3 Downloader";
            this.mainpanel.Controls.Clear();
            MP3 MP3_vrb = new MP3() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            MP3_vrb.FormBorderStyle = FormBorderStyle.None;
            this.mainpanel.Controls.Add(MP3_vrb);
            MP3_vrb.Show();
        }

        private void mp4button_Click(object sender, EventArgs e)
        {
            panel1.Height = mp4button.Height;
            panel1.Top = mp4button.Top;
            panel1.Left = mp4button.Left;
            title.Text = "MP4 Downloader";
            this.mainpanel.Controls.Clear();
            MP4 MP4_vrb = new MP4() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            MP4_vrb.FormBorderStyle = FormBorderStyle.None;
            this.mainpanel.Controls.Add(MP4_vrb);
            MP4_vrb.Show();
        }

        private void filebutton_Click(object sender, EventArgs e)
        {
            panel1.Height = filebutton.Height;
            panel1.Top = filebutton.Top;
            panel1.Left = filebutton.Left;
            title.Text = "File Downloader";
            this.mainpanel.Controls.Clear();
            Filed Filed_vrb = new Filed() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            Filed_vrb.FormBorderStyle = FormBorderStyle.None;
            this.mainpanel.Controls.Add(Filed_vrb);
            Filed_vrb.Show();
        }
    }
}
