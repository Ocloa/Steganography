using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using Microsoft.Win32;
using System.Windows.Forms;

namespace Steganography.MVVM.View
{
    /// <summary>
    /// Логика взаимодействия для EmbedTextView.xaml
    /// </summary>
    public partial class EmbedTextView : System.Windows.Controls.UserControl
    {
        public EmbedTextView()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Microsoft.Win32.OpenFileDialog open = new Microsoft.Win32.OpenFileDialog();
                open.Filter = "Image Files(*.jpg; *.png; *.jpeg; *.gif; *.bmp)|*.jpg; *.png; *.jpeg; *.gif; *.bmp";
                open.InitialDirectory = @"C:\Users\User\Desktop\UNI\1920\productionProject\outputFiles";
                if (open.ShowDialog() == true)

                {
                    routeBox.Text = open.FileName.ToString();
                    Uri fileUri = new Uri(open.FileName);
                    pictureBoxInput.Source = new BitmapImage(fileUri);
                    //get max potential length
                    
                }
            }

            catch (Exception)
            {
                throw new ApplicationException("Failed loading image");
            }
        }

        private void saveStegaButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void routeBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
