using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Steganography.Core
{
    internal class TextExtractor
    {
        Operations ops = new Operations();
        

        

        public string Retrieve1lsb(string inRoute_)
        {
            Point pixelIndex = new Point(1, 0);
            Bitmap bmp = new Bitmap(inRoute_);

            //Получение длины финального пикселя
            Color lastPixel = bmp.GetPixel(bmp.Width - 1, bmp.Height - 1);
            string first = ops.convNumberToBits(lastPixel.R);
            string second = ops.convNumberToBits(lastPixel.G);
            string third = ops.convNumberToBits(lastPixel.B);
            string concat = first + second + third;
            long finalLength = Convert.ToInt64(concat);

            //Длина в десятичных
            long msgLength = ops.binaryToDecimalLong(finalLength);

            //Декодирование 
            string message = "";
            int counter = 0;

            while (counter < msgLength * 8)
            {

                Color pixelCol = bmp.GetPixel(pixelIndex.X, pixelIndex.Y);
                for (int rgb = 0; rgb < 3; rgb++)
                {
                    if (counter < msgLength * 8)
                    {
                        switch (rgb)
                        {
                            //R
                            case 0:
                                {
                                    string rBitString = ops.convNumberToBits(pixelCol.R);
                                    string rLastFour = rBitString.Substring(7, 1);

                                    message += rLastFour;
                                    counter++;
                                    break;
                                }
                            //G
                            case 1:
                                {
                                    string gBitString = ops.convNumberToBits(pixelCol.G);
                                    string gLastFour = gBitString.Substring(7, 1);
                                    message += gLastFour;
                                    counter++;
                                    break;
                                }
                            //B
                            case 2:
                                {
                                    string bBitString = ops.convNumberToBits(pixelCol.B);
                                    string bLastFour = bBitString.Substring(7, 1);
                                    message += bLastFour;
                                    counter++;
                                    break;
                                }

                        }
                    }

                }
                pixelIndex.X++;
                if (pixelIndex.X >= bmp.Width)
                {
                    pixelIndex.X = 1;
                    pixelIndex.Y++;
                }
            }

            return ops.BinaryToString(message);

        }

  

        public string Retrieve2lsb(string inRoute_)
        {
            Point pixelIndex = new Point(1, 0);
            Bitmap bmp = new Bitmap(inRoute_);

            Color lastPixel = bmp.GetPixel(bmp.Width - 1, bmp.Height - 1);
            string first = ops.convNumberToBits(lastPixel.R);
            string second = ops.convNumberToBits(lastPixel.G);
            string third = ops.convNumberToBits(lastPixel.B);
            string concat = first + second + third;
            long finalLength = Convert.ToInt64(concat);

            long msgLength = ops.binaryToDecimalLong(finalLength) / 2;

            //Декодирование
            string currentLetter = "";
            string message = "";
            int counter = 0;
            while (counter < msgLength * 8)
            {

                Color pixelCol = bmp.GetPixel(pixelIndex.X, pixelIndex.Y);
                for (int rgb = 0; rgb < 3; rgb++)
                {
                    if (counter < msgLength * 8)
                    {
                        switch (rgb)
                        {
                            //R
                            case 0:
                                {
                                    string rBitString = ops.convNumberToBits(pixelCol.R);
                                    string rLastFour = rBitString.Substring(6, 2);

                                    message += rLastFour;
                                    counter++;
                                    break;
                                }
                            //G
                            case 1:
                                {
                                    string gBitString = ops.convNumberToBits(pixelCol.G);
                                    string gLastFour = gBitString.Substring(6, 2);
                                    message += gLastFour;
                                    counter++;
                                    break;
                                }
                            //B
                            case 2:
                                {
                                    string bBitString = ops.convNumberToBits(pixelCol.B);
                                    string bLastFour = bBitString.Substring(6, 2);
                                    message += bLastFour;
                                    counter++;
                                    break;
                                }

                        }
                    }

                }
                pixelIndex.X++;
                if (pixelIndex.X >= bmp.Width)
                {
                    pixelIndex.X = 1;
                    pixelIndex.Y++;
                }
            }

            return ops.BinaryToString(message);
        }
        public string Retrieve3lsb(string inRoute_)
        {
            Point pixelIndex = new Point(1, 0);
            Bitmap bmp = new Bitmap(inRoute_);

            Color lastPixel = bmp.GetPixel(bmp.Width - 1, bmp.Height - 1);
            string first = ops.convNumberToBits(lastPixel.R);
            string second = ops.convNumberToBits(lastPixel.G);
            string third = ops.convNumberToBits(lastPixel.B);
            string concat = first + second + third;
            long finalLength = Convert.ToInt64(concat);

            long msgLength = ops.binaryToDecimalLong(finalLength) / 3;

            //Декодирование
            string message = "";
            int counter = 0;
            while (counter < msgLength * 8)
            {

                Color pixelCol = bmp.GetPixel(pixelIndex.X, pixelIndex.Y);
                for (int rgb = 0; rgb < 3; rgb++)
                {
                    if (counter < msgLength * 8)
                    {
                        switch (rgb)
                        {
                            //R
                            case 0:
                                {
                                    string rBitString = ops.convNumberToBits(pixelCol.R);
                                    string rLastFour = rBitString.Substring(5, 3);

                                    message += rLastFour;
                                    counter++;
                                    break;
                                }
                            //G
                            case 1:
                                {
                                    string gBitString = ops.convNumberToBits(pixelCol.G);
                                    string gLastFour = gBitString.Substring(5, 3);
                                    message += gLastFour;
                                    counter++;
                                    break;
                                }
                            //B
                            case 2:
                                {
                                    string bBitString = ops.convNumberToBits(pixelCol.B);
                                    string bLastFour = bBitString.Substring(5, 3);
                                    message += bLastFour;
                                    counter++;
                                    break;
                                }

                        }
                    }

                }

                pixelIndex.X++;
                if (pixelIndex.X >= bmp.Width - 1)
                {
                    pixelIndex.X = 1;
                    pixelIndex.Y++;
                }


            }
            return ops.BinaryToString(message);
        }
        public string Retrieve4lsb(string inRoute_)
        {
            Point pixelIndex = new Point(1, 0);
            Bitmap bmp = new Bitmap(inRoute_);

            Color lastPixel = bmp.GetPixel(bmp.Width - 1, bmp.Height - 1);
            string first = ops.convNumberToBits(lastPixel.R);
            string second = ops.convNumberToBits(lastPixel.G);
            string third = ops.convNumberToBits(lastPixel.B);
            string concat = first + second + third;
            long finalLength = Convert.ToInt64(concat);

            long msgLength = ops.binaryToDecimalLong(finalLength);

            //Декодирование
            string currentLetter = "";
            string message = "";
            for (int i = 0; i < msgLength; i++)
            {

                Color pixelCol = bmp.GetPixel(pixelIndex.X, pixelIndex.Y);
                for (int rgb = 0; rgb < 2; rgb++)
                {
                    switch (rgb)
                    {
                        //R
                        case 0:
                            {
                                string rBitString = ops.convNumberToBits(pixelCol.R);
                                string rLastFour = ops.removeFromStart(rBitString, 4);

                                currentLetter = rLastFour;
                                message += rLastFour;
                                break;
                            }
                        //G
                        case 1:
                            {
                                string gBitString = ops.convNumberToBits(pixelCol.G);
                                string gLastFour = ops.removeFromStart(gBitString, 4);
                                currentLetter += gLastFour;
                                message += gLastFour;
                                break;
                            }

                    }
                }
                pixelIndex.X++;
                if (pixelIndex.X >= bmp.Width)
                {
                    pixelIndex.X = 0;
                    pixelIndex.Y++;
                }

            }
            return ops.BinaryToString(message);
        }

    }
}
