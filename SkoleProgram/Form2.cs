using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace SkoleProgram
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        string path = @"C:\Users\BG\Pictures\Sample Pictures";

        private void Form2_Load(object sender, EventArgs e)
        {

            //var filePaths = Directory.GetFiles(@"C:\Users\BG\Pictures\Sample Pictures", "*.jpg", SearchOption.AllDirectories).Union(Directory.GetFiles(@"C:\Users\BG\Pictures\Sample Pictures", "*.png", SearchOption.AllDirectories));////Union

            //foreach (string files in filePaths)
            //{

            //    listBox1.Items.Add(files);
            //    listBox1.DisplayMember = "ssd";

            //}

            DirectoryInfo directory = new DirectoryInfo(path);

            FileInfo[] fn = directory.GetFiles();

            foreach(FileInfo f in fn)
            {
                listBox1.Items.Add(f.Name);
            }
            
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //string imagepaths = listBox1.SelectedItem.ToString();
            //pictureBox1.Image = Image.FromFile($@"{imagepaths}");

            pictureBox1.ImageLocation = path + "\\" + listBox1.SelectedItem;
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
