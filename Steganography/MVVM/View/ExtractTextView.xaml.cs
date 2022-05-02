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
    /// Логика взаимодействия для ExtractTextView.xaml
    /// </summary>
    public partial class ExtractTextView : System.Windows.Controls.UserControl
    {
        double time = 0;
        Stopwatch sw;
        TextExtractor retriever;
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
        public ExtractTextView()
        {
            InitializeComponent();
            retriever = new TextExtractor();
        }

        private void stegabox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void textToEmbed_TextChanged(object sender, TextChangedEventArgs e)
        {

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
        private void timer1_Tick(object sender, EventArgs e)
        {
            time++;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(stegabox.Text))
            {
                if (lsb1.IsChecked == true)
                {
                    decodedText.Text = retriever.Retrieve1lsb(stegabox.Text);
                }
                else if (lsb2.IsChecked == true)
                {
                    decodedText.Text = retriever.Retrieve2lsb(stegabox.Text);
                }
                else if (lsb3.IsChecked == true)
                {
                    decodedText.Text = retriever.Retrieve3lsb(stegabox.Text);
                }
                else if (lsb4.IsChecked == true)
                {
                    decodedText.Text = retriever.Retrieve4lsb(stegabox.Text);
                }

                
            }
            else
            {
                MessageBox.Show("No path specified, please assign a path using the textbox or 'open...' button");
            }
        }
    }
}
