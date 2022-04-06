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

namespace MyApp1
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Image image = Image.FromFile("C:/Users/nusra/CompARe/Screenshots/CB.jpg");

            var ms = new MemoryStream();
            image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            //to get the bytes
            var bytes = ms.ToArray();
            var imageMemoryStream = new MemoryStream(bytes);
            Image imgFromStream = Image.FromStream(imageMemoryStream);
            ImageShow.Image = imgFromStream;
        }
    }
}
