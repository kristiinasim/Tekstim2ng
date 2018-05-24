using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            PictureBox pb1 = new PictureBox();
            pb1.ImageLocation = @"../../9.jpg";
            pb1.SizeMode = PictureBoxSizeMode.AutoSize;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        

    

        private void button1_Click(object sender, EventArgs e)
        {

            Process p = new Process();
            Process.Start(@"D:\#Games and Apps\GITHUB\Tekstim2ng\m2ng.exe");
            this.Close();

        }
    }
}

