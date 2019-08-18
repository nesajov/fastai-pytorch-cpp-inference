using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


namespace TestApp
{
    using DogOrCat;
    public partial class TestForm : Form
    {
        private DogOrCat _dogOrCat = null;
        private Bitmap _image = null;

        // save your current directory  
        string currentDirectory = "../images";

        public TestForm()
        {
            InitializeComponent();

            textBoxlabel.Text = "";
            textBoxProbability.Text = "";

            _dogOrCat = new DogOrCat();

            openFileDialog.InitialDirectory = @"D:\";

        }


        private void buttonProcess_Click(object sender, EventArgs e)
        {
            textBoxlabel.Text = "";
            textBoxProbability.Text = "";
            if ((_dogOrCat != null) && (_image != null))
            {
                _dogOrCat.Process((Bitmap)_image.Clone());


                textBoxlabel.Text = _dogOrCat.Label;

                double p = _dogOrCat.Probability * 100.0;
                textBoxProbability.Text = p.ToString("F1");
            }
        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "JPEG files (jpg, jpeg, jpe)|*.jpg;*.jpeg;*jpe|" +
                                     "Windows Bitmaps (bmp, dib)|*.bmp;*.dib;|" +
                                     "Portable Network Graphics (png)|*.png;|" +
                                     "Portable image format (pbm, pgm, ppm)|*.pbm;*.pgm;*.ppm|" +
                                     "Sun raster (sr, ras)|*.sr;*.ras|" +
                                     "All Files (*.*)|*.jpg;*.jpeg;*jpe;*.bmp;*.dib;*.png;*.pbm;*.pgm;*.ppm;*.sr;*.ras";
            openFileDialog.FilterIndex = 6;
            openFileDialog.RestoreDirectory = false;
            openFileDialog.InitialDirectory = currentDirectory;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    _image = new Bitmap(openFileDialog.FileName);
                    pictureBox.Image = (Bitmap)_image.Clone();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}