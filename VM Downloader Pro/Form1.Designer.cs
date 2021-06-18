
namespace VM_Downloader_Pro
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.filebutton = new System.Windows.Forms.Button();
            this.mp4button = new System.Windows.Forms.Button();
            this.mp3button = new System.Windows.Forms.Button();
            this.mainbutton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.Label();
            this.mainpanel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.filebutton);
            this.panel1.Controls.Add(this.mp4button);
            this.panel1.Controls.Add(this.mp3button);
            this.panel1.Controls.Add(this.mainbutton);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(186, 520);
            this.panel1.TabIndex = 0;
            // 
            // filebutton
            // 
            this.filebutton.Dock = System.Windows.Forms.DockStyle.Top;
            this.filebutton.FlatAppearance.BorderSize = 0;
            this.filebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.filebutton.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.filebutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.filebutton.Location = new System.Drawing.Point(0, 256);
            this.filebutton.Name = "filebutton";
            this.filebutton.Size = new System.Drawing.Size(186, 42);
            this.filebutton.TabIndex = 4;
            this.filebutton.Text = "File";
            this.filebutton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.filebutton.UseVisualStyleBackColor = true;
            this.filebutton.Click += new System.EventHandler(this.filebutton_Click);
            // 
            // mp4button
            // 
            this.mp4button.Dock = System.Windows.Forms.DockStyle.Top;
            this.mp4button.FlatAppearance.BorderSize = 0;
            this.mp4button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mp4button.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mp4button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.mp4button.Location = new System.Drawing.Point(0, 214);
            this.mp4button.Name = "mp4button";
            this.mp4button.Size = new System.Drawing.Size(186, 42);
            this.mp4button.TabIndex = 3;
            this.mp4button.Text = "MP4";
            this.mp4button.UseVisualStyleBackColor = true;
            this.mp4button.Click += new System.EventHandler(this.mp4button_Click);
            // 
            // mp3button
            // 
            this.mp3button.Dock = System.Windows.Forms.DockStyle.Top;
            this.mp3button.FlatAppearance.BorderSize = 0;
            this.mp3button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mp3button.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mp3button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.mp3button.Location = new System.Drawing.Point(0, 172);
            this.mp3button.Name = "mp3button";
            this.mp3button.Size = new System.Drawing.Size(186, 42);
            this.mp3button.TabIndex = 2;
            this.mp3button.Text = "MP3";
            this.mp3button.UseVisualStyleBackColor = true;
            this.mp3button.Click += new System.EventHandler(this.mp3button_Click);
            // 
            // mainbutton
            // 
            this.mainbutton.Dock = System.Windows.Forms.DockStyle.Top;
            this.mainbutton.FlatAppearance.BorderSize = 0;
            this.mainbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mainbutton.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mainbutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.mainbutton.Location = new System.Drawing.Point(0, 130);
            this.mainbutton.Name = "mainbutton";
            this.mainbutton.Size = new System.Drawing.Size(186, 42);
            this.mainbutton.TabIndex = 1;
            this.mainbutton.Text = "Main Menu";
            this.mainbutton.UseVisualStyleBackColor = true;
            this.mainbutton.Click += new System.EventHandler(this.mainbutton_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(186, 130);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label1.Location = new System.Drawing.Point(12, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "VM Downloader Pro";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::VM_Downloader_Pro.Properties.Resources._72;
            this.pictureBox1.Location = new System.Drawing.Point(55, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(72, 72);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(537, 310);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(8, 8);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(795, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 2;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.title.Location = new System.Drawing.Point(192, 9);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(138, 35);
            this.title.TabIndex = 3;
            this.title.Text = "Main Menu";
            // 
            // mainpanel
            // 
            this.mainpanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.mainpanel.Location = new System.Drawing.Point(186, 96);
            this.mainpanel.Name = "mainpanel";
            this.mainpanel.Size = new System.Drawing.Size(764, 424);
            this.mainpanel.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.button1.Location = new System.Drawing.Point(875, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 42);
            this.button1.TabIndex = 5;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(950, 520);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.mainpanel);
            this.Controls.Add(this.title);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VM Downloader Pro";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button filebutton;
        private System.Windows.Forms.Button mp4button;
        private System.Windows.Forms.Button mp3button;
        private System.Windows.Forms.Button mainbutton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Panel mainpanel;
        private System.Windows.Forms.Button button1;
    }
}

