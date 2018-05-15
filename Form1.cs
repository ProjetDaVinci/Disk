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

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            panel1.Visible = false;
            
        }

        int cnt = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            string a = Directory.GetCurrentDirectory() + @"\5.jpg";
            MessageBox.Show(a);
        }



        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            cnt = 0;
            panel1.Visible = false;
        }

        private void у2ToolStripMenuItem_Click(object sender, EventArgs e)
        {


        }

        private void у1ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (cnt == 1)
            {
                // System.Diagnostics.Process p = new System.Diagnostics.Process();
                //p.StartInfo.FileName = @"C:\Program Files\Windows Media Player\wmplayer.exe";
                System.Diagnostics.Process.Start(@"C:\Program Files\Windows Media Player\wmplayer.exe", @"C:\1.avi");
            
            }
            if (cnt == 2)
            {
                // System.Diagnostics.Process p = new System.Diagnostics.Process();
                //p.StartInfo.FileName = @"C:\Program Files\Windows Media Player\wmplayer.exe";
                System.Diagnostics.Process.Start(@"C:\Program Files\Windows Media Player\wmplayer.exe", @"C:\1.avi");
            }
            if (cnt == 3)
            {
                // System.Diagnostics.Process p = new System.Diagnostics.Process();
                //p.StartInfo.FileName = @"C:\Program Files\Windows Media Player\wmplayer.exe";
                System.Diagnostics.Process.Start(@"C:\Program Files\Windows Media Player\wmplayer.exe", @"C:\1.avi");
            }
            if (cnt == 4)
            {
                // System.Diagnostics.Process p = new System.Diagnostics.Process();
                //p.StartInfo.FileName = @"C:\Program Files\Windows Media Player\wmplayer.exe";
                System.Diagnostics.Process.Start(@"C:\Program Files\Windows Media Player\wmplayer.exe", @"C:\1.avi");
            }
            if (cnt == 5)
            {
                // System.Diagnostics.Process p = new System.Diagnostics.Process();
                //p.StartInfo.FileName = @"C:\Program Files\Windows Media Player\wmplayer.exe";
                System.Diagnostics.Process.Start(@"C:\Program Files\Windows Media Player\wmplayer.exe", @"C:\1.avi");
            }

            if (cnt == 0)
            {
                cnt = 1;
                panel1.Visible = true;
                panel1.BackgroundImage = Image.FromFile(@"E:\1не трогайте ЭТО моё\Новая папка (4)\фотки для диска\02_3.jpg");

            }
        }

        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            cnt = 0;
            panel1.Visible = false;
        }

        private void у2ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (cnt == 1)
            {
                // System.Diagnostics.Process p = new System.Diagnostics.Process();
                //p.StartInfo.FileName = @"C:\Program Files\Windows Media Player\wmplayer.exe";
                System.Diagnostics.Process.Start(@"C:\Program Files\Windows Media Player\wmplayer.exe", @"C:\1.avi");
            }
            if (cnt == 2)
            {
                // System.Diagnostics.Process p = new System.Diagnostics.Process();
                //p.StartInfo.FileName = @"C:\Program Files\Windows Media Player\wmplayer.exe";
                System.Diagnostics.Process.Start(@"C:\Program Files\Windows Media Player\wmplayer.exe", @"C:\1.avi");
            }
            if (cnt == 3)
            {
                // System.Diagnostics.Process p = new System.Diagnostics.Process();
                //p.StartInfo.FileName = @"C:\Program Files\Windows Media Player\wmplayer.exe";
                System.Diagnostics.Process.Start(@"C:\Program Files\Windows Media Player\wmplayer.exe", @"C:\1.avi");
            }
            if (cnt == 4)
            {
                // System.Diagnostics.Process p = new System.Diagnostics.Process();
                //p.StartInfo.FileName = @"C:\Program Files\Windows Media Player\wmplayer.exe";
                System.Diagnostics.Process.Start(@"C:\Program Files\Windows Media Player\wmplayer.exe", @"C:\1.avi");
            }
            if (cnt == 5)
            {
                // System.Diagnostics.Process p = new System.Diagnostics.Process();
                //p.StartInfo.FileName = @"C:\Program Files\Windows Media Player\wmplayer.exe";
                System.Diagnostics.Process.Start(@"C:\Program Files\Windows Media Player\wmplayer.exe", @"C:\1.avi");
            }
            if (cnt == 0)
            {
                cnt = 2;
                panel1.Visible = true;
                panel1.BackgroundImage = Image.FromFile(@"E:\1не трогайте ЭТО моё\Новая папка (4)\фотки для диска\03_3_3.jpg");

            }
        }

        private void у3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (cnt == 1)
            {
                // System.Diagnostics.Process p = new System.Diagnostics.Process();
                //p.StartInfo.FileName = @"C:\Program Files\Windows Media Player\wmplayer.exe";
                System.Diagnostics.Process.Start(@"C:\Program Files\Windows Media Player\wmplayer.exe", @"C:\1.avi");

            }
            if (cnt == 2)
            {
                // System.Diagnostics.Process p = new System.Diagnostics.Process();
                //p.StartInfo.FileName = @"C:\Program Files\Windows Media Player\wmplayer.exe";
                System.Diagnostics.Process.Start(@"C:\Program Files\Windows Media Player\wmplayer.exe", @"C:\1.avi");
            }
            if (cnt == 3)
            {
                // System.Diagnostics.Process p = new System.Diagnostics.Process();
                //p.StartInfo.FileName = @"C:\Program Files\Windows Media Player\wmplayer.exe";
                System.Diagnostics.Process.Start(@"C:\Program Files\Windows Media Player\wmplayer.exe", @"C:\1.avi");
            }
            if (cnt == 4)
            {
                // System.Diagnostics.Process p = new System.Diagnostics.Process();
                //p.StartInfo.FileName = @"C:\Program Files\Windows Media Player\wmplayer.exe";
                System.Diagnostics.Process.Start(@"C:\Program Files\Windows Media Player\wmplayer.exe", @"C:\1.avi");
            }
            if (cnt == 5)
            {
                // System.Diagnostics.Process p = new System.Diagnostics.Process();
                //p.StartInfo.FileName = @"C:\Program Files\Windows Media Player\wmplayer.exe";
                System.Diagnostics.Process.Start(@"C:\Program Files\Windows Media Player\wmplayer.exe", @"C:\1.avi");
            }

            if (cnt == 0)
            {
                cnt = 3;
                panel1.Visible = true;
                panel1.BackgroundImage = Image.FromFile(@"E:\1не трогайте ЭТО моё\Новая папка (4)\фотки для диска\04_3.jpg");

            }
        }

        private void у4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (cnt == 1)
            {
                // System.Diagnostics.Process p = new System.Diagnostics.Process();
                //p.StartInfo.FileName = @"C:\Program Files\Windows Media Player\wmplayer.exe";
                System.Diagnostics.Process.Start(@"C:\Program Files\Windows Media Player\wmplayer.exe", @"C:\1.avi");

            }
            if (cnt == 2)
            {
                // System.Diagnostics.Process p = new System.Diagnostics.Process();
                //p.StartInfo.FileName = @"C:\Program Files\Windows Media Player\wmplayer.exe";
                System.Diagnostics.Process.Start(@"C:\Program Files\Windows Media Player\wmplayer.exe", @"C:\1.avi");
            }
            if (cnt == 3)
            {
                // System.Diagnostics.Process p = new System.Diagnostics.Process();
                //p.StartInfo.FileName = @"C:\Program Files\Windows Media Player\wmplayer.exe";
                System.Diagnostics.Process.Start(@"C:\Program Files\Windows Media Player\wmplayer.exe", @"C:\1.avi");
            }
            if (cnt == 4)
            {
                // System.Diagnostics.Process p = new System.Diagnostics.Process();
                //p.StartInfo.FileName = @"C:\Program Files\Windows Media Player\wmplayer.exe";
                System.Diagnostics.Process.Start(@"C:\Program Files\Windows Media Player\wmplayer.exe", @"C:\1.avi");
            }
            if (cnt == 5)
            {
                // System.Diagnostics.Process p = new System.Diagnostics.Process();
                //p.StartInfo.FileName = @"C:\Program Files\Windows Media Player\wmplayer.exe";
                System.Diagnostics.Process.Start(@"C:\Program Files\Windows Media Player\wmplayer.exe", @"C:\1.avi");
            }

            if (cnt == 0)
            {
                cnt = 4;
                panel1.Visible = true;
                panel1.BackgroundImage = Image.FromFile(@"E:\1не трогайте ЭТО моё\Новая папка (4)\фотки для диска\05_3.jpg");

            }
        }

        private void у5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (cnt == 1)
            {
                // System.Diagnostics.Process p = new System.Diagnostics.Process();
                //p.StartInfo.FileName = @"C:\Program Files\Windows Media Player\wmplayer.exe";
                System.Diagnostics.Process.Start(@"C:\Program Files\Windows Media Player\wmplayer.exe", @"C:\1.avi");

            }
            if (cnt == 2)
            {
                // System.Diagnostics.Process p = new System.Diagnostics.Process();
                //p.StartInfo.FileName = @"C:\Program Files\Windows Media Player\wmplayer.exe";
                System.Diagnostics.Process.Start(@"C:\Program Files\Windows Media Player\wmplayer.exe", @"C:\1.avi");
            }
            if (cnt == 3)
            {
                // System.Diagnostics.Process p = new System.Diagnostics.Process();
                //p.StartInfo.FileName = @"C:\Program Files\Windows Media Player\wmplayer.exe";
                System.Diagnostics.Process.Start(@"C:\Program Files\Windows Media Player\wmplayer.exe", @"C:\1.avi");
            }
            if (cnt == 4)
            {
                // System.Diagnostics.Process p = new System.Diagnostics.Process();
                //p.StartInfo.FileName = @"C:\Program Files\Windows Media Player\wmplayer.exe";
                System.Diagnostics.Process.Start(@"C:\Program Files\Windows Media Player\wmplayer.exe", @"C:\1.avi");
            }
            if (cnt == 5)
            {
                // System.Diagnostics.Process p = new System.Diagnostics.Process();
                //p.StartInfo.FileName = @"C:\Program Files\Windows Media Player\wmplayer.exe";
                System.Diagnostics.Process.Start(@"C:\Program Files\Windows Media Player\wmplayer.exe", @"C:\1.avi");
            }

            if (cnt == 0)
            {
                cnt = 5;
                panel1.Visible = true;
                panel1.BackgroundImage = Image.FromFile(@"E:\1не трогайте ЭТО моё\Новая папка (4)\фотки для диска\06_3.jpg");

            }
        }

        private void panel1_Layout(object sender, LayoutEventArgs e)
        {

        }
    }

}