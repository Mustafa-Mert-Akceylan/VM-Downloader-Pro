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
using VideoLibrary;
using MediaToolkit;
using System.Net;

namespace VM_Downloader_Pro
{
    public partial class MP4 : Form
    {
        public MP4()
        {
            InitializeComponent();
        }
        bool FormatDurum = false;
        private void MP4_Load(object sender, EventArgs e)
        {

        }

        private async void indir2_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fdb = new FolderBrowserDialog() { Description = "Please Select The Folder You Want To Save" })
            {

                if (fdb.ShowDialog() == DialogResult.OK)
                {

                    GetTitle();
                    labelDurum2.Text = "Downloading... Please Wait";
                    labelDurum2.ForeColor = Color.Red;

                    var youtube = YouTube.Default;
                    var video = await youtube.GetVideoAsync(textBox2.Text);
                    File.WriteAllBytes(fdb.SelectedPath + @"\" + video.FullName, await video.GetBytesAsync());


                    var inputFile = new MediaToolkit.Model.MediaFile { Filename = fdb.SelectedPath + @"\" + video.FullName };
                    var outputFile = new MediaToolkit.Model.MediaFile { Filename = $"{fdb.SelectedPath + @"\" + video.FullName}.mp3" };

                    using (var enging = new Engine())
                    {
                        enging.GetMetadata(inputFile);
                        enging.Convert(inputFile, outputFile);
                    }

                    if (FormatDurum == true)
                    {
                        File.Delete(fdb.SelectedPath + @"\" + video.FullName);
                    }
                    else
                    {
                        File.Delete($"{fdb.SelectedPath + @"\" + video.FullName}.mp3");
                    }

                    labelDurum2.Text = "Succesfully Downloaded!";
                    labelDurum2.ForeColor = Color.Green;

                }
                else
                {
                    MessageBox.Show("Please Select File Path", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
        void GetTitle()
        {
            WebRequest istek = HttpWebRequest.Create(textBox2.Text);
            WebResponse yanıt;
            yanıt = istek.GetResponse();
            StreamReader bilgiler = new StreamReader(yanıt.GetResponseStream());
            string gelen = bilgiler.ReadToEnd();
            int baslangic = gelen.IndexOf("<title>") + 7;
            int bitis = gelen.Substring(baslangic).IndexOf("</title>");
            string gelenbilgiler = gelen.Substring(baslangic, bitis);
            labelTitle2.Text = (gelenbilgiler);
        }
    }
    }

