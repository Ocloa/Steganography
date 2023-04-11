using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Steganography.Core
{
    internal class TextEmbedder
    {
        Operations ops = new Operations();
        Bitmap bmp;
        private ProgressBar pBar1;
        public TextEmbedder(ProgressBar pBar1)
        {
            this.pBar1 = pBar1;
            pBar1.Visibility = System.Windows.Visibility.Hidden;
        }

        public Bitmap Embed1lsb(string inRoute_, string inText_)
        {
            bmp = new Bitmap(inRoute_);
            string bitString = "";
            Point pixelIndex = new Point(1, 0);
            SetLength(inText_.Length);

            //Внедрение символов
            inText_.Insert(0, "0");

            //Для каждого символа в тексте
            for (int i = 0; i < inText_.Length; i++)
            {
                //Получение бинарного значения текущего символа в тексте
                string newBit = ops.convLetterToBits(inText_.Substring(i, 1));
                bitString = bitString + newBit;
            }

            //Вычисление необходимого количества пикселей для текста данной длины
            int noOfPixels = (inText_.Length * 8) / 3;

            pBarSetup(noOfPixels);

            //Для каждого пикселя в изображении
            for (int i = 0; i < noOfPixels; i++)
            {

                pBar1.Value++;
                //Получение пикселя по индексу
                Color pixelCol = bmp.GetPixel(pixelIndex.X, pixelIndex.Y);

                int finalR = 0, finalG = 0, finalB = 0;
                //Цикл через R/G/B пикселя
                for (int rgb = 0; rgb < 3; rgb++)
                {
                    if (!String.IsNullOrEmpty(bitString))
                    {
                        switch (rgb)
                        {
                            //R
                            case 0:
                                {
                                    //Бинарные значения R
                                    string rBitString = ops.convNumberToBits(pixelCol.R);
                                    //Первые 7 цифр R
                                    string rFirstFour = rBitString.Substring(0, 7);
                                    string lFirstFour = bitString.Substring(0, 1);
                                    bitString = bitString.Substring(1, bitString.Length - 1);
                                    int newR = Convert.ToInt32(rFirstFour + lFirstFour);

                                    finalR = ops.binaryToDecimal(newR);
                                    break;
                                }
                            //G
                            case 1:
                                {
                                    string gBitString = ops.convNumberToBits(pixelCol.G);
                                    string gFirstFour = gBitString.Substring(0, 7);
                                    string lLastFour = bitString.Substring(0, 1);
                                    bitString = bitString.Substring(1, bitString.Length - 1);
                                    int newG = Convert.ToInt32(gFirstFour + lLastFour);

                                    finalG = ops.binaryToDecimal(newG);
                                    break;
                                }
                            //B
                            case 2:
                                {
                                    string bBitString = ops.convNumberToBits(pixelCol.B);
                                    string bFirstFour = bBitString.Substring(0, 7);
                                    string lLastFour = bitString.Substring(0, 1);
                                    bitString = bitString.Substring(1, bitString.Length - 1);
                                    int newB = Convert.ToInt32(bFirstFour + lLastFour);

                                    finalB = ops.binaryToDecimal(newB);
                                    break;
                                }
                        }
                    }
                }
                bmp.SetPixel(pixelIndex.X, pixelIndex.Y, Color.FromArgb(finalR, finalG, finalB));

                pixelIndex.X++;
                if (pixelIndex.X >= bmp.Width)
                {
                    pixelIndex.X = 1;
                    pixelIndex.Y++;
                }


            }
            pBar1.Visibility = System.Windows.Visibility.Hidden;
            return bmp;
        }

        public Bitmap Embed2lsb(string inRoute_, string inText_)
        {
            bmp = new Bitmap(inRoute_);
            string bitString = "";
            Point pixelIndex = new Point(1, 0);
            SetLength(inText_.Length);

            //EMBED LETTER 
            inText_.Insert(0, "0");

            //for each letter in the message.
            for (int i = 0; i < inText_.Length; i++)
            {
                //get the binary value of current letter in message
                string newBit = ops.convLetterToBits(inText_.Substring(i, 1));
                //append bitstream with new byte
                bitString = bitString + newBit;
            }

            //calculate how many pixels are needed for length of message
            int noOfPixels = ((inText_.Length * 8) / 3) / 2;

            pBarSetup(noOfPixels);

            //for each pixel in image.
            for (int i = 0; i < noOfPixels; i++)
            {
                pBar1.Value++;
                //retrieve pixel at index
                Color pixelCol = bmp.GetPixel(pixelIndex.X, pixelIndex.Y);

                int finalR = 0, finalG = 0, finalB = 0;
                //loop through R/G/B of pixel
                for (int rgb = 0; rgb < 3; rgb++)
                {
                    if (!String.IsNullOrEmpty(bitString))
                    {
                        switch (rgb)
                        {
                            //R
                            case 0:
                                {
                                    //get the binary values of R 
                                    string rBitString = ops.convNumberToBits(pixelCol.R);
                                    //get first 7 digit of R
                                    string rFirstFour = rBitString.Substring(0, 6);
                                    //get first digit from bitStream
                                    string lFirstFour = bitString.Substring(0, 2);
                                    //remove first digit bitstring
                                    bitString = bitString.Substring(2, bitString.Length - 2);
                                    //merge and convert to back to int
                                    int newR = Convert.ToInt32(rFirstFour + lFirstFour);

                                    finalR = ops.binaryToDecimal(newR);
                                    break;
                                }
                            //G
                            case 1:
                                {
                                    //get the binary values of G
                                    string gBitString = ops.convNumberToBits(pixelCol.G);
                                    //get first 7 digit of G
                                    string gFirstFour = gBitString.Substring(0, 6);
                                    //get first digit from bitStream
                                    string lLastFour = bitString.Substring(0, 2);
                                    //remove first digit bitstring
                                    bitString = bitString.Substring(2, bitString.Length - 2);
                                    //merge 
                                    int newG = Convert.ToInt32(gFirstFour + lLastFour);

                                    finalG = ops.binaryToDecimal(newG);
                                    break;
                                }
                            //B
                            case 2:
                                {
                                    //get the binary values of B
                                    string bBitString = ops.convNumberToBits(pixelCol.B);
                                    //get first 7 digit of B
                                    string bFirstFour = bBitString.Substring(0, 6);
                                    //get first digit from bitStream
                                    string lLastFour = bitString.Substring(0, 2);
                                    //remove first digit bitstring
                                    bitString = bitString.Substring(2, bitString.Length - 2);
                                    //merge 
                                    int newB = Convert.ToInt32(bFirstFour + lLastFour);

                                    finalB = ops.binaryToDecimal(newB);
                                    break;
                                }
                        }
                    }
                }
                bmp.SetPixel(pixelIndex.X, pixelIndex.Y, Color.FromArgb(finalR, finalG, finalB));

                pixelIndex.X++;
                if (pixelIndex.X >= bmp.Width)
                {
                    pixelIndex.X = 1;
                    pixelIndex.Y++;
                }


            }
            pBar1.Visibility = 0;
            return bmp;
        }

        public Bitmap Embed3lsb(string inRoute_, string inText_)
        {
            bmp = new Bitmap(inRoute_);
            string bitString = "";
            Point pixelIndex = new Point(1, 0);
            SetLength(inText_.Length);


            for (int i = 0; i < inText_.Length; i++)
            {
                string newBit = ops.convLetterToBits(inText_.Substring(i, 1));
                bitString = bitString + newBit;
            }

            int noOfPixels = ((inText_.Length * 8) / 3) / 3;

            pBarSetup(noOfPixels);
            for (int i = 0; i < noOfPixels; i++)
            {
                pBar1.Value++;
                if (i < noOfPixels)
                {
                    Color pixelCol = bmp.GetPixel(pixelIndex.X, pixelIndex.Y);

                    int finalR = 0, finalG = 0, finalB = 0;
                    for (int rgb = 0; rgb < 3; rgb++)
                    {
                        if (bitString.Length >= 3)
                        {
                            switch (rgb)
                            {
                                //R
                                case 0:
                                    {
                                        string rBitString = ops.convNumberToBits(pixelCol.R);
                                        string rFirstFour = rBitString.Substring(0, 5);
                                        string lFirstFour = bitString.Substring(0, 3);
                                        bitString = bitString.Substring(3, bitString.Length - 3);
                                        int newR = Convert.ToInt32(rFirstFour + lFirstFour);

                                        finalR = ops.binaryToDecimal(newR);
                                        break;
                                    }
                                //G
                                case 1:
                                    {
                                        string gBitString = ops.convNumberToBits(pixelCol.G);
                                        string gFirstFour = gBitString.Substring(0, 5);
                                        string lLastFour = bitString.Substring(0, 3);
                                        bitString = bitString.Substring(3, bitString.Length - 3);
                                        int newG = Convert.ToInt32(gFirstFour + lLastFour);

                                        finalG = ops.binaryToDecimal(newG);
                                        break;
                                    }
                                //B
                                case 2:
                                    {
                                        string bBitString = ops.convNumberToBits(pixelCol.B);
                                        string bFirstFour = bBitString.Substring(0, 5);
                                        string lLastFour = bitString.Substring(0, 3);
                                        bitString = bitString.Substring(3, bitString.Length - 3);
                                        int newB = Convert.ToInt32(bFirstFour + lLastFour);

                                        finalB = ops.binaryToDecimal(newB);
                                        break;
                                    }
                            }
                        }
                    }
                    if (bitString.Length >= 3)
                    {
                        bmp.SetPixel(pixelIndex.X, pixelIndex.Y, Color.FromArgb(finalR, finalG, finalB));
                    }
                    pixelIndex.X++;
                    if (pixelIndex.X >= bmp.Width - 1)
                    {
                        pixelIndex.X = 1;
                        pixelIndex.Y++;
                    }

                }
            }
            pBar1.Visibility = 0;
            return bmp;
        }


        public Bitmap Embed4lsb(string inRoute_, string inText_)
        {
            bmp = new Bitmap(inRoute_);
            Point pixelIndex = new Point(1, 0);

            SetLength(inText_.Length);

            int counter = 0;
            inText_.Insert(0, "0");

            pBarSetup(inText_.Length);
            for (int i = 0; i < inText_.Length; i++)
            {
                if (counter < inText_.Length)
                {
                    Color pixelCol = bmp.GetPixel(pixelIndex.X, pixelIndex.Y);

                    string bitString = ops.convLetterToBits(inText_.Substring(counter, 1));
                    int finalR = 0, finalG = 0;
                    for (int rgb = 0; rgb < 2; rgb++)
                    {
                        switch (rgb)
                        {
                            //R
                            case 0:
                                {
                                    string rBitString = ops.convNumberToBits(pixelCol.R);
                                    string rFirstFour = ops.getFromStart(rBitString, 4);
                                    string lFirstFour = ops.getFromStart(bitString, 4);
                                    int newR = Convert.ToInt32(rFirstFour + lFirstFour);

                                    finalR = ops.binaryToDecimal(newR);
                                    break;
                                }
                            //G
                            case 1:
                                {
                                    string gBitString = ops.convNumberToBits(pixelCol.G);
                                    string gFirstFour = ops.getFromStart(gBitString, 4);
                                    string lLastFour = ops.removeFromStart(bitString, 4);
                                    int newG = Convert.ToInt32(gFirstFour + lLastFour);

                                    finalG = ops.binaryToDecimal(newG);
                                    break;
                                }
                        }
                    }
                    bmp.SetPixel(pixelIndex.X, pixelIndex.Y, Color.FromArgb(finalR, finalG, pixelCol.B));

                    counter++;
                    pixelIndex.X++;
                    if (pixelIndex.X >= bmp.Width)
                    {
                        pixelIndex.X = 1;
                        pixelIndex.Y++;
                    }
                }
            }
            pBar1.Visibility = System.Windows.Visibility.Hidden;
            return bmp;
        }
        private void SetLength(int inLength_)
        {
            string lengthBitString = ops.convNumberToBits(inLength_);
            int loopCount = 0;

            Color lengthPixelCol = bmp.GetPixel(bmp.Width - 1, bmp.Height - 1);

            while (lengthBitString.Length < 24)
            {
                lengthBitString = lengthBitString.Insert(0, "0");
            }
            string[] splitInto8s = ops.splitLengthInParts(lengthBitString).Split(' ');


            int lengthR = 0, lengthG = 0, lengthB = 0;

            for (int rgb = 0; rgb < 3; rgb++)
            {
                switch (rgb)
                {
                    //R
                    case 0:
                        {
                            lengthR = ops.binaryToDecimal(Int32.Parse(splitInto8s[1]));
                            break;
                        }
                    //G
                    case 1:
                        {
                            lengthG = ops.binaryToDecimal(Int32.Parse(splitInto8s[2]));
                            break;
                        }
                    //B
                    case 2:
                        {
                            lengthB = ops.binaryToDecimal(Int32.Parse(splitInto8s[3]));
                            break;
                        }
                }
            }
            bmp.SetPixel(bmp.Width - 1, bmp.Height - 1, Color.FromArgb(lengthR, lengthG, lengthB));

        }

        private void pBarSetup(int max_)
        {
            pBar1.Visibility = System.Windows.Visibility.Visible;
            pBar1.Minimum = 1;
            pBar1.Maximum = max_ / 8;
            pBar1.Value = 1;
        }


    }
}
