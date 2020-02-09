using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Images
{
    public partial class Form1 : Form
    {
        //g>2*r or g>2*b
        //get image
        //convert to bitmap
        //check pixel by pixel
        //return 0 255 0 if green else white
        //time of conversion in textbox

        Bitmap img;
        Bitmap extracted;
        public Form1()
        {
            InitializeComponent();
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                //Get the path of specified file
                filePath = openFileDialog.FileName;

                //Read the contents of the file into a stream
                var fileStream = openFileDialog.OpenFile();

                using (StreamReader reader = new StreamReader(fileStream))
                {
                    fileContent = reader.ReadToEnd();
                }
            }
            textBox1.Text = filePath;
            var bmp = (Bitmap)Image.FromFile(filePath);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Image = (Image)bmp;
            img = bmp;
        }

        private void extractButton_Click(object sender, EventArgs e)
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            extracted = img;
            for (int i = 0; i < img.Width; i++)
            {
                for (int j = 0; j < img.Height; j++)
                {
                    Color pixel = img.GetPixel(i, j);

                    if (pixel.G > (pixel.R * 2) || pixel.G > (pixel.B * 2))
                    {
                        extracted.SetPixel(i, j, Color.Green);
                    }
                    else
                        extracted.SetPixel(i, j, Color.White);
                }
            }
            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;
            textBox2.Text = (elapsedMs).ToString() + "ms";
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.Image = (Image)extracted;
        }
    }
}
