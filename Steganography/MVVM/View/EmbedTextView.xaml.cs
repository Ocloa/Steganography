using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using System.Windows.Forms;
using Steganography.Core;
using System.Diagnostics;
using SaveFileDialog = System.Windows.Forms.SaveFileDialog;
using MessageBox = System.Windows.MessageBox;
using System.Drawing;
using System.IO;

namespace Steganography.MVVM.View
{
    /// <summary>
    /// Логика взаимодействия для EmbedTextView.xaml
    /// </summary>
    public partial class EmbedTextView : System.Windows.Controls.UserControl
    {
        TextEmbedder embedder;
        int maxInputLength;
        double time = 0;
        Stopwatch sw;
        BitmapImage BitmapToImageSource(Bitmap bitmap)
        {
            using (MemoryStream memory = new MemoryStream())
            {
                bitmap.Save(memory, System.Drawing.Imaging.ImageFormat.Bmp);
                memory.Position = 0;
                BitmapImage bitmapimage = new BitmapImage();
                bitmapimage.BeginInit();
                bitmapimage.StreamSource = memory;
                bitmapimage.CacheOption = BitmapCacheOption.OnLoad;
                bitmapimage.EndInit();

                return bitmapimage;
            }
        }
        public EmbedTextView()
        {
            InitializeComponent();
            embedder = new TextEmbedder(pBar1);
        }
        private void updateLength(BitmapImage bmp_)
        {
            if (lsb1.IsChecked==true)
            {
                textToEmbed.MaxLength = (int)(((bmp_.Width * bmp_.Height) * 3) / 8);
                maxInputLength = textToEmbed.MaxLength;
            }
            else if (lsb2.IsChecked == true)
            {
                textToEmbed.MaxLength = (int)(((bmp_.Width * bmp_.Height) * 3) / 4);
                maxInputLength = textToEmbed.MaxLength;
            }
            else if (lsb3.IsChecked == true)
            {
                textToEmbed.MaxLength = (int)(((bmp_.Width * bmp_.Height) * 3) / 3);
                maxInputLength = textToEmbed.MaxLength;
            }
            else if (lsb4.IsChecked == true)
            {
                textToEmbed.MaxLength = (int)(((bmp_.Width * bmp_.Height) * 2) / 2);
                maxInputLength = textToEmbed.MaxLength;
            }
        }

        private void @true(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }
        private void embedButton_Click(object sender, RoutedEventArgs e)
        {
            sw = Stopwatch.StartNew();
            //Error handling
            if (routeBox.Text == "")
            {
                MessageBox.Show("ERROR: no input image selected, see 'Image route' section.");
            }
            else if (textToEmbed.Text == "")
            {
                MessageBox.Show("ERROR: no input text available, see 'Text to embed' box.");
            }
            else if (lsb1.IsChecked == false && lsb2.IsChecked == false && lsb3.IsChecked == false && lsb4.IsChecked == false)
            {
                MessageBox.Show("ERROR: no byte-density selected, please select one of the available options (i.e: '1LSB').");
            }

            //sw and different LSBs.
            else if (lsb1.IsChecked==true)
            {
                pictureBoxStega.Source = BitmapToImageSource(embedder.Embed1lsb(routeBox.Text, textToEmbed.Text));
            }
            else if (lsb2.IsChecked == true)
            {
                pictureBoxStega.Source = BitmapToImageSource(embedder.Embed2lsb(routeBox.Text, textToEmbed.Text));
            }
            else if (lsb3.IsChecked == true)
            {
                pictureBoxStega.Source = BitmapToImageSource(embedder.Embed3lsb(routeBox.Text, textToEmbed.Text));
            }
            else if (lsb4.IsChecked == true)
            {
                pictureBoxStega.Source = BitmapToImageSource(embedder.Embed4lsb(routeBox.Text, textToEmbed.Text));
            }
            long timed = sw.ElapsedMilliseconds;
            MessageBox.Show("Elapsed time in milliseconds: " + timed);
            this.sw.Stop();
            saveStegaButton.IsEnabled = true;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                OpenFileDialog open = new OpenFileDialog();
                open.Filter = "Image Files(*.jpg; *.png; *.jpeg; *.gif; *.bmp)|*.jpg; *.png; *.jpeg; *.gif; *.bmp";
                open.InitialDirectory = @"C:\Users\User\Desktop\";
                if (open.ShowDialog() == DialogResult.OK)
                {
                    routeBox.Text = open.FileName.ToString();
                    Uri fileUri = new Uri(open.FileName);
                    pictureBoxInput.Source = new BitmapImage(fileUri);
                    BitmapImage bmp = new BitmapImage();
                    bmp.BeginInit();
                    bmp.UriSource = new Uri(routeBox.Text);
                    bmp.EndInit();
                    int length = (bmp.PixelWidth * bmp.PixelHeight);//-1 for the final pixel which stores the length.
                    textToEmbed.MaxLength = length;
                }
                
            }

            catch (Exception)
            {
                throw new ApplicationException("Failed loading image");
            }
            //get max potential length
           
        }
        private void updateLength(Bitmap bmp_)
        {
            if (lsb1.IsChecked==true)
            {
                textToEmbed.MaxLength = ((bmp_.Width * bmp_.Height) * 3) / 8;
                maxInputLength = textToEmbed.MaxLength;
            }
            else if (lsb2.IsChecked == true)
            {
                textToEmbed.MaxLength = ((bmp_.Width * bmp_.Height) * 3) / 4;
                maxInputLength = textToEmbed.MaxLength;
            }
            else if (lsb3.IsChecked == true)
            {
                textToEmbed.MaxLength = ((bmp_.Width * bmp_.Height) * 3) / 3;
                maxInputLength = textToEmbed.MaxLength;
            }
            else if (lsb4.IsChecked == true)
            {
                textToEmbed.MaxLength = ((bmp_.Width * bmp_.Height) * 2) / 2;
                maxInputLength = textToEmbed.MaxLength;
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            time++;
        }

        private void saveStegaButton_Click(object sender, RoutedEventArgs e)
        {
            BitmapImage bmp = new BitmapImage();
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                bmp.BeginInit();
                bmp.UriSource = new Uri(stegabox.Text);
                stegabox.Text = saveFile.FileName.ToString();
                pictureBoxStega.Source = bmp;
                

            }
        }

        private void routeBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void OpenStegaButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                System.Windows.Forms.OpenFileDialog open = new System.Windows.Forms.OpenFileDialog();
                open.Filter = "Image Files(*.jpg; *.png; *.jpeg; *.gif; *.bmp)|*.jpg; *.png; *.jpeg; *.gif; *.bmp";
                open.InitialDirectory = @"C:\Users\User\Desktop\UNI\1920\productionProject\outputFiles";
                if (open.ShowDialog() == DialogResult.OK)

                {
                    stegabox.Text = open.FileName.ToString();
                    Uri fileUri = new Uri(open.FileName);
                    pictureBoxStega.Source = new BitmapImage(fileUri);
                }
            }

            catch (Exception)
            {
                throw new ApplicationException("Failed loading image");
            }
        }

        private void textToEmbed_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
