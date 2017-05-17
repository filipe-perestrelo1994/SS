using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using Emgu.CV.Structure;
using Emgu.CV;

namespace SS_OpenCV
{
    class ImageClass
    {

        /// <summary>
        /// Image Negative using EmguCV library
        /// Slower method
        /// </summary>
        /// <param name="img">Image</param>
        public struct colors
        {
            public int red;
            public int green;
            public int blue;
        }

        public static void Negative(Image<Bgr, byte> img)
        {
            /*Bgr aux;
            int x;
            int y;
            int width = img.Width;
            int height = img.Height;
            for (y = 0; y < height; y++)
            {
                for (x = 0; x < width; x++)
                {
                    // emguCV access: slower
                    aux = img[y, x];
                    img[y, x] = new Bgr(255 - aux.Blue, 255 - aux.Green, 255 - aux.Red);
                }
            }*/
            unsafe
            {
                // direct access to the image memory(sequencial)
                // direcion top left -> bottom right

                MIplImage m = img.MIplImage;
                byte* dataPtr = (byte*)m.imageData.ToPointer(); // Pointer to the image
                byte blue, green, red;

                int width = img.Width;
                int height = img.Height;
                int nChan = m.nChannels; // number of channels - 3
                int padding = m.widthStep - m.nChannels * m.width; // alinhament bytes (padding)
                int x, y;

                if (nChan == 3) // image in RGB
                {
                    for (y = 0; y < height; y++)
                    {
                        for (x = 0; x < width; x++)
                        {
                            //obtém as 3 componentes
                            blue = dataPtr[0];
                            green = dataPtr[1];
                            red = dataPtr[2];

                            // store in the image
                            dataPtr[0] = (byte)((int)255 - blue);
                            dataPtr[1] = (byte)((int)255 - green);
                            dataPtr[2] = (byte)((int)255 - red);

                            // advance the pointer to the next pixel
                            dataPtr += nChan; //nChan: numero de canais
                        }

                        //at the end of the line advance the pointer by the aligment bytes (padding)
                        dataPtr += padding;
                    }
                }
            }
        }
     

        /// <summary>
        /// Convert to gray
        /// Direct access to memory
        /// </summary>
        /// <param name="img">image</param>
        public static void ConvertToGray(Image<Bgr, byte> img)
        {
            unsafe
            {
                // direct access to the image memory(sequencial)
                // direcion top left -> bottom right

                MIplImage m = img.MIplImage;
                byte* dataPtr = (byte*)m.imageData.ToPointer(); // Pointer to the image
                byte blue, green, red, gray;

                int width = img.Width;
                int height = img.Height;
                int nChan = m.nChannels; // number of channels - 3
                int padding = m.widthStep - m.nChannels * m.width; // alinhament bytes (padding)
                int x, y;
                        
                if (nChan == 3) // image in RGB
                {
                    for (y = 0; y < height; y++)
                    {
                        for (x = 0; x < width; x++)
                        {
                            //obtém as 3 componentes
                            blue = dataPtr[0];
                            green = dataPtr[1];
                            red = dataPtr[2];

                            // convert to gray
                            gray = (byte)(((int)blue + green + red) / 3);

                            // store in the image
                            dataPtr[0] = gray;
                            dataPtr[1] = gray;
                            dataPtr[2] = gray;

                            // advance the pointer to the next pixel
                            dataPtr += nChan; //nChan: numero de canais
                        }

                        //at the end of the line advance the pointer by the aligment bytes (padding)
                        dataPtr += padding;
                    }
                }
            }
        }

        public static void OnlyGray(Image<Bgr, byte> img, int color_index)
        {
            unsafe
            {
                // direct access to the image memory(sequencial)
                // direcion top left -> bottom right

                MIplImage m = img.MIplImage;
                byte* dataPtr = (byte*)m.imageData.ToPointer(); // Pointer to the image
                byte color;

                int width = img.Width;
                int height = img.Height;
                int nChan = m.nChannels; // number of channels - 3
                int padding = m.widthStep - m.nChannels * m.width; // alinhament bytes (padding)
                int x, y;

                if (nChan == 3) // image in RGB
                {
                    for (y = 0; y < height; y++)
                    {
                        for (x = 0; x < width; x++)
                        {
                            //obtém as 3 componentes
                            color = dataPtr[color_index];

                            // convert to gray
                            //gray = (byte)(((int)blue + green + red) / 3);

                            // store in the image
                            dataPtr[0] = color;
                            dataPtr[1] = color;
                            dataPtr[2] = color;

                            // advance the pointer to the next pixel
                            dataPtr += nChan; //nChan: numero de canais
                        }

                        //at the end of the line advance the pointer by the aligment bytes (padding)
                        dataPtr += padding;
                    }
                }
            }
        }

        public static void brightAndcont(Image<Bgr, byte> img, int brilho, int contraste)
        {
            unsafe
            {
                // direct access to the image memory(sequencial)
                // direcion top left -> bottom right
                MIplImage m = img.MIplImage;
                byte* dataPtr = (byte*)m.imageData.ToPointer(); // Pointer to the image
                float Red, Green, Blue;
                float iRed, iGreen, iBlue;
                int iR, iG, iB;

                int width = img.Width;
                int height = img.Height;
                int nChan = m.nChannels; // number of channels - 3
                int padding = m.widthStep - m.nChannels * m.width; // alinhament bytes (padding)
                int x, y;

                if (nChan == 3) // image in RGB
                {
                    for (y = 0; y < height; y++)
                    {
                        for (x = 0; x < width; x++)
                        {
                            Red = dataPtr[2] * (1.0f / 255.0f);
                            Green = dataPtr[1] * (1.0f/ 255.0f);
                            Blue = dataPtr[0] * (1.0f / 255.0f);
                            iRed = (((Red - 0.5f) * contraste) + 0.5f) * 255.0f;
                            iGreen = (((Green - 0.5f) * contraste) + 0.5f) * 255.0f;
                            iBlue = (((Blue - 0.5f) * contraste) + 0.5f) * 255.0f;
                            iRed += brilho;
                            iGreen += brilho;
                            iBlue += brilho;
                            

                            iR = (int)iRed;
                            iR = iR > 255 ? 255 : iR;
                            iR = iR < 0 ? 0 : iR;
                            iG = (int)iGreen;
                            iG = iG > 255 ? 255 : iG;
                            iG = iG < 0 ? 0 : iG;
                            iB = (int)iBlue;
                            iB = iB > 255 ? 255 : iB;
                            iB = iB < 0 ? 0 : iB;

                            // store in the image
                            dataPtr[0] = (byte)iB;
                            dataPtr[1] = (byte)iG;
                            dataPtr[2] = (byte)iR;

                            // advance the pointer to the next pixel
                            dataPtr += nChan; //nChan: numero de canais
                        }

                        //at the end of the line advance the pointer by the aligment bytes (padding)
                        dataPtr += padding;
                    }
                }
            }
        }

        public static void moveImage(Image<Bgr, byte> img, Image<Bgr, byte> imgUndo ,int dX, int dY)
        {
            unsafe
            {
                // direct access to the image memory(sequencial)
                // direcion top left -> bottom right
                MIplImage m = img.MIplImage;
                MIplImage mUndo = imgUndo.MIplImage;
                byte* dataPtrOrigem = (byte*)mUndo.imageData.ToPointer(); // Pointer to the image
                byte* dataPtrDestino = (byte*)m.imageData.ToPointer();
                float Red, Green, Blue;

                int width = img.Width;
                int dataPtrOrig_aux = 0;
                int height = img.Height;
                int nChan = m.nChannels; // number of channels - 3
                int padding = m.widthStep - m.nChannels * m.width; // alinhament bytes (padding)
                int x, y;

                if (nChan == 3) // image in RGB
                {
                    for (y = 0; y < height; y++)
                    {
                        for (x = 0; x < width; x++)
                        {
                            if (x - dX < 0 || x - dX > width || y - dY < 0 || y - dY > height)
                            {
                                dataPtrDestino[0] = (byte)0;
                                dataPtrDestino[1] = (byte)0;
                                dataPtrDestino[2] = (byte)0;
                            }
                            else
                            {
                                dataPtrOrig_aux = (y-dY) * m.widthStep + (x-dX) * nChan;
                                Red = (byte)(dataPtrOrigem + dataPtrOrig_aux)[2];
                                Green = (byte)(dataPtrOrigem + dataPtrOrig_aux)[1];
                                Blue = (byte)(dataPtrOrigem + dataPtrOrig_aux)[0];
                                
                                // store in the image
                                dataPtrDestino[0] = (byte)Blue; 
                                dataPtrDestino[1] = (byte)Green;
                                dataPtrDestino[2] = (byte)Red;
                            }
                            // advance the pointer to the next pixel
                            dataPtrDestino += nChan; //nChan: numero de canais
                        }
                        //at the end of the line advance the pointer by the aligment bytes (padding)
                        dataPtrDestino += padding;
                    }
                }
            }
        }

        public static void rotateImage(Image<Bgr, byte> img, Image<Bgr, byte> imgUndo, double angle)
        {
            unsafe
            {
                // direct access to the image memory(sequencial)
                // direcion top left -> bottom right
                MIplImage m = img.MIplImage;
                MIplImage mUndo = imgUndo.MIplImage;
                byte* dataPtrOrigem = (byte*)mUndo.imageData.ToPointer(); // Pointer to the image
                byte* dataPtrDestino = (byte*)m.imageData.ToPointer();
                float Red, Green, Blue;

                int width = img.Width;
                int height = img.Height;
                int dataPtrOrig_aux = 0;
                int nChan = m.nChannels; // number of channels - 3
                int padding = m.widthStep - m.nChannels * m.width; // alinhament bytes (padding)
                int x, y;
                int x_org, y_org;

                double val_x = (width / 2) - ((height / 2) * Math.Sin(angle)) - ((width / 2) * Math.Cos(angle));
                double val_y = (height / 2) - ((height / 2) * Math.Cos(angle)) + ((width / 2) * Math.Sin(angle));

                if (nChan == 3) // image in RGB
                {
                    for (y = 0; y < height; y++)
                    {
                        for (x = 0; x < width; x++)
                        {
                            x_org = (int)((x * Math.Cos(angle)) + (y * Math.Sin(angle)) + val_x);
                            y_org = (int)((y * Math.Cos(angle)) - (x * Math.Sin(angle)) + val_y);
                            if (x_org < 0 || x_org > width || y_org < 0 || y_org > height)
                            {
                                dataPtrDestino[0] = (byte)0;
                                dataPtrDestino[1] = (byte)0;
                                dataPtrDestino[2] = (byte)0;
                            }
                            else
                            {
                                dataPtrOrig_aux = y_org * m.widthStep + x_org * nChan;
                                Red = (byte)(dataPtrOrigem + dataPtrOrig_aux)[2];
                                Green = (byte)(dataPtrOrigem + dataPtrOrig_aux)[1];
                                Blue = (byte)(dataPtrOrigem + dataPtrOrig_aux)[0];

                                // store in the image
                                dataPtrDestino[0] = (byte)Blue;
                                dataPtrDestino[1] = (byte)Green;
                                dataPtrDestino[2] = (byte)Red;
                            }
                            // advance the pointer to the next pixel
                            dataPtrDestino += nChan; //nChan: numero de canais
                        }
                        //at the end of the line advance the pointer by the aligment bytes (padding)
                        dataPtrDestino += padding;
                    }
                }
            }
        }

        public static void zoomImage(Image<Bgr, byte> img, Image<Bgr, byte> imgUndo, float zoom, int x_zoom, int y_zoom)
        {
            unsafe
            {
                // direct access to the image memory(sequencial)
                // direcion top left -> bottom right
                MIplImage m = img.MIplImage;
                MIplImage mUndo = imgUndo.MIplImage;
                byte* dataPtrOrigem = (byte*)mUndo.imageData.ToPointer(); // Pointer to the image
                byte* dataPtrDestino = (byte*)m.imageData.ToPointer();
                float Red, Green, Blue;

                int width = img.Width;
                int height = img.Height;
                int dataPtrOrig_aux = 0;
                int nChan = m.nChannels; // number of channels - 3
                int padding = m.widthStep - m.nChannels * m.width; // alinhament bytes (padding)
                int x, y;
                int x_org, y_org;
                if (nChan == 3) // image in RGB
                {
                    for (y = 0; y < height; y++)
                    {
                        for (x = 0; x < width; x++)
                        {     
                            x_org = (int)((x - x_zoom) / zoom) + x_zoom;
                            y_org = (int)((y - y_zoom) / zoom) + y_zoom;                           

                            if (x_org < 0 || x_org > width || y_org < 0 || y_org > height)
                            {
                                dataPtrDestino[0] = (byte)0;
                                dataPtrDestino[1] = (byte)0;
                                dataPtrDestino[2] = (byte)0;
                            }
                            else
                            {
                                dataPtrOrig_aux = y_org * m.widthStep + x_org * nChan;
                                Red = (byte)(dataPtrOrigem + dataPtrOrig_aux)[2];
                                Green = (byte)(dataPtrOrigem + dataPtrOrig_aux)[1];
                                Blue = (byte)(dataPtrOrigem + dataPtrOrig_aux)[0];

                                // store in the image
                                dataPtrDestino[0] = (byte)Blue;
                                dataPtrDestino[1] = (byte)Green;
                                dataPtrDestino[2] = (byte)Red;
                            }
                            // advance the pointer to the next pixel
                            dataPtrDestino += nChan; //nChan: numero de canais
                        }
                        //at the end of the line advance the pointer by the aligment bytes (padding)
                        dataPtrDestino += padding;
                    }
                }
            }
        }

        public static void averageFilter(Image<Bgr, byte> img, Image<Bgr, byte> imgUndo, int dim)
        {
            unsafe
            {
                // direct access to the image memory(sequencial)
                // direcion top left -> bottom right

                MIplImage m = img.MIplImage;
                MIplImage mUndo = imgUndo.MIplImage;
                byte* dataPtr = (byte*)m.imageData.ToPointer(); // Pointer to the image
                byte* dataPtrAux = (byte*)mUndo.imageData.ToPointer();
                int blue_avrg = 0, green_avrg = 0, red_avrg = 0;

                int width = img.Width;
                int widthStep = m.widthStep;
                int height = img.Height;
                int nChan = m.nChannels; // number of channels - 3
                int padding = m.widthStep - m.nChannels * m.width; // alinhament bytes (padding)
                int x, y;
                int i, j;
                int half_dim = (int)(dim / 2); //Metade da divisão inteira da dimensão
                
                int x_dif = 0, y_dif = 0; // Estas variáveis indicam se a área do filtro supera as dimensões da imagem. Se tiverem valores positivos, 
                                          // quer dizer que são superiores à altura (Y) ou ao comprimento (X), se tiverem valores negativos, 
                                          // significa que o filtro supera a menor dimensão de x ou y;
                               
                byte* dataAux = dataPtrAux; // Variável auxiliar que serve para repor o valor de dataPtrAux sempre que necessário.
                byte* dataAux2 = dataPtrAux;

                if (nChan == 3) // image in RGB
                {
                    //dataPtr += widthStep + nChan;
                    for (y = 0; y < height; y++)
                    {
                        for (x = 0; x < width; x++)
                        {
                            blue_avrg = 0;
                            green_avrg = 0;
                            red_avrg = 0;
                            if ((x - half_dim) < 0 || (y - half_dim) < 0 || (x + half_dim) > (width - 1) || (y + half_dim) > (height - 1))
                            {
                                dataAux2 = dataAux;
                                for (i = -half_dim; i <= half_dim; i++)
                                {
                                    for (j = -half_dim; j <= half_dim; j++)
                                    {
                                        y_dif = y + i < 0 ? 0 : ((y + i > height - 1) ? (height - 1) : (y + i));
                                        x_dif = x + j < 0 ? 0 : ((x + j > width - 1) ? (width - 1) : (x + j));

                                        dataAux = dataPtrAux + (x_dif * nChan) + (y_dif * widthStep);

                                        blue_avrg += dataAux[0];
                                        green_avrg += dataAux[1];
                                        red_avrg += dataAux[2];
                                    }                                   
                                }
                                dataAux = dataAux2;
                            }
                            else
                            {
                                //Kernel
                                dataAux2 = dataAux;
                                dataAux -= (half_dim)*widthStep;
                                dataAux -= (half_dim)*nChan;
                                for (i = 0; i < dim; i++)
                                {
                                    for (j = 0; j < dim; j++)
                                    {
                                        blue_avrg += dataAux[0];
                                        green_avrg += dataAux[1];
                                        red_avrg += dataAux[2];
                                        dataAux += nChan;
                                    }
                                    dataAux += widthStep - dim * nChan;
                                }
                                dataAux = dataAux2;
                            }
                            // convert to gray
                            //gray = (byte)(((int)blue + green + red) / 3);

                            // store in the image
                            dataPtr[0] = (byte)(blue_avrg / (dim * dim));
                            dataPtr[1] = (byte)(green_avrg / (dim * dim));
                            dataPtr[2] = (byte)(red_avrg / (dim * dim));

                            // advance the pointer to the next pixel
                            dataPtr += nChan; //nChan: numero de canais
                            dataAux += nChan;
                        }
                        //at the end of the line advance the pointer by the aligment bytes (padding)
                        dataPtr += padding; // +2 * nChan;
                        dataAux += padding;
                    }
                }
            }
        }
        //Filtros não uniformes: Factor é um float
        public static void nonLinearFilter(Image<Bgr, byte> img, Image<Bgr, byte> imgUndo, int dim, int weight, String coef)
        {
            unsafe
            {
                // direct access to the image memory(sequencial)
                // direcion top left -> bottom right

                MIplImage m = img.MIplImage;
                MIplImage mUndo = imgUndo.MIplImage;
                byte* dataPtr = (byte*)m.imageData.ToPointer(); // Pointer to the image
                byte* dataPtrAux = (byte*)mUndo.imageData.ToPointer();
                coef = coef.Trim();
                string [] numbers = coef.Split(',');
                int[] myInts = Array.ConvertAll(numbers, int.Parse);
                int blue_avrg = 0, green_avrg = 0, red_avrg = 0;

                int width = img.Width;
                int widthStep = m.widthStep;
                int height = img.Height;
                int nChan = m.nChannels; // number of channels - 3
                int padding = m.widthStep - m.nChannels * m.width; // alinhament bytes (padding)
                int x, y;
                int i, j;
                int cycles = 0, num;
                int half_dim = (int)(dim / 2); //Metade da divisão inteira da dimensão

                int x_dif = 0, y_dif = 0; // Estas variáveis indicam se a área do filtro supera as dimensões da imagem. Se tiverem valores positivos, 
                // quer dizer que são superiores à altura (Y) ou ao comprimento (X), se tiverem valores negativos, 
                // significa que o filtro supera a menor dimensão de x ou y;

                byte* dataAux = dataPtrAux; // Variável auxiliar que serve para repor o valor de dataPtrAux sempre que necessário.
                byte* dataAux2 = dataPtrAux;

                

                if (nChan == 3) // image in RGB
                {
                    //dataPtr += widthStep + nChan;
                    for (y = 0; y < height; y++)
                    {
                        for (x = 0; x < width; x++)
                        {
                            blue_avrg = 0;
                            green_avrg = 0;
                            red_avrg = 0;
                            if ((x - half_dim) < 0 || (y - half_dim) < 0 || (x + half_dim) > (width - 1) || (y + half_dim) > (height - 1))
                            {
                                dataAux2 = dataAux;
                                cycles = 0;
                                for (i = -half_dim; i <= half_dim; i++)
                                {
                                    for (j = -half_dim; j <= half_dim; j++)
                                    {
                                        y_dif = y + i < 0 ? 0 : ((y + i > height - 1) ? (height - 1) : (y + i));
                                        x_dif = x + j < 0 ? 0 : ((x + j > width - 1) ? (width - 1) : (x + j));

                                        num = myInts[cycles];
                                        dataAux = dataPtrAux + (x_dif * nChan) + (y_dif * widthStep);

                                        blue_avrg += num*dataAux[0];
                                        green_avrg += num*dataAux[1];
                                        red_avrg += num*dataAux[2];

                                        cycles++;
                                    }
                                }
                                dataAux = dataAux2;
                            }
                            else
                            {
                                //Kernel
                                cycles = 0;
                                dataAux2 = dataAux;
                                dataAux -= (half_dim) * widthStep;
                                dataAux -= (half_dim) * nChan;
                                for (i = 0; i < dim; i++)
                                {
                                    for (j = 0; j < dim; j++)
                                    {
                                        num = Convert.ToInt32(numbers[cycles]);
                                        blue_avrg += num*dataAux[0];
                                        green_avrg += num*dataAux[1];
                                        red_avrg += num*dataAux[2];
                                        dataAux += nChan;
                                        cycles++;
                                    }
                                    dataAux += widthStep - dim * nChan;
                                }
                                dataAux = dataAux2;
                            }
                            // convert to gray
                            //gray = (byte)(((int)blue + green + red) / 3);
                            blue_avrg = blue_avrg < 0 ? 0 : (blue_avrg > 255 * weight ? 255 * weight : blue_avrg);
                            green_avrg = green_avrg < 0 ? 0 : (green_avrg > 255 * weight ? 255 * weight : green_avrg);
                            red_avrg = red_avrg < 0 ? 0 : (red_avrg > 255 * weight ? 255 * weight : red_avrg);
                            // store in the image
                            dataPtr[0] = (byte)(blue_avrg / weight);
                            dataPtr[1] = (byte)(green_avrg / weight);
                            dataPtr[2] = (byte)(red_avrg / weight);

                            // advance the pointer to the next pixel
                            dataPtr += nChan; //nChan: numero de canais
                            dataAux += nChan;
                        }
                        //at the end of the line advance the pointer by the aligment bytes (padding)
                        dataPtr += padding; // +2 * nChan;
                        dataAux += padding;
                    }
                }
            }
        }

        public static void averageFilterB(Image<Bgr, byte> img, Image<Bgr, byte> imgUndo, int dim)
        {
            unsafe
            {
                // direct access to the image memory(sequencial)
                // direcion top left -> bottom right

                MIplImage m = img.MIplImage;
                MIplImage mUndo = imgUndo.MIplImage;
                byte* dataPtr = (byte*)m.imageData.ToPointer(); // Pointer to the image
                byte* dataPtrAux = (byte*)mUndo.imageData.ToPointer();
                int blue_avrg = 0, green_avrg = 0, red_avrg = 0;
                int bh = 0, gh = 0, rh = 0;
                int bv = 0, gv = 0, rv = 0;

                int width = img.Width;
                int widthStep = m.widthStep;
                int height = img.Height;
                int nChan = m.nChannels; // number of channels - 3
                int padding = m.widthStep - m.nChannels * m.width; // alinhament bytes (padding)
                int x, y;
                int i, j;
                int half_dim = (int)(dim / 2); //Metade da divisão inteira da dimensão

                int x_dif = 0, y_dif = 0; // Estas variáveis indicam se a área do filtro supera as dimensões da imagem. Se tiverem valores positivos, 
                // quer dizer que são superiores à altura (Y) ou ao comprimento (X), se tiverem valores negativos, 
                // significa que o filtro supera a menor dimensão de x ou y;

                byte* dataAux = dataPtrAux; // Variável auxiliar que serve para repor o valor de dataPtrAux sempre que necessário.

                if (nChan == 3) // image in RGB
                {
                    for (i = -half_dim; i <= half_dim; i++)
                    {
                        for (j = -half_dim; j <= half_dim; j++)
                        {
                            y_dif = i < 0 ? 0 : i;
                            x_dif = j < 0 ? 0 : j;

                            dataAux = dataPtrAux + (x_dif * nChan) + (y_dif * widthStep);

                            blue_avrg += dataAux[0];
                            green_avrg += dataAux[1];
                            red_avrg += dataAux[2];
                        }
                    }
                    bv = blue_avrg;
                    gv = green_avrg;
                    rv = red_avrg;
                    bh = blue_avrg;
                    gh = green_avrg;
                    rh = red_avrg;
                    dataPtr[0] = (byte)(blue_avrg / (dim * dim));
                    dataPtr[1] = (byte)(green_avrg / (dim * dim));
                    dataPtr[2] = (byte)(red_avrg / (dim * dim));
                    
                    for (y = 0; y < height; y++)
                    {
                        for (x = 0; x < width; x++)
                        {
                            blue_avrg = 0;
                            green_avrg = 0;
                            red_avrg = 0;
                            if (x == 0)
                            {
                                if (y != 0)
                                {
                                    for (i = 0; i < 2; i++)
                                    {
                                        if (i == 0)
                                        {
                                            y_dif = y - 1 - half_dim < 0 ? 0 : y - 1 - half_dim;
                                        }
                                        else
                                        {
                                            blue_avrg = - blue_avrg;
                                            green_avrg = - green_avrg;
                                            red_avrg = - red_avrg;
                                            y_dif = y + half_dim > height - 1 ? (height - 1) : y + half_dim;
                                        }
                                        for (j = -half_dim; j <= half_dim; j++)
                                        {
                                            x_dif = x + j < 0 ? 0 : ((x + j > width - 1) ? (width - 1) : (x + j));

                                            dataAux = dataPtrAux + (x_dif * nChan) + (y_dif * widthStep);

                                            blue_avrg += dataAux[0];
                                            green_avrg += dataAux[1];
                                            red_avrg += dataAux[2];
                                        }
                                    }
                                    dataPtr[0] = (byte)((blue_avrg + bv) / (dim * dim));
                                    dataPtr[1] = (byte)((green_avrg + gv) / (dim * dim));
                                    dataPtr[2] = (byte)((red_avrg + rv) / (dim * dim));
                                    bv += blue_avrg;
                                    gv += green_avrg;
                                    rv += red_avrg;
                                    bh = bv;
                                    gh = gv;
                                    rh = rv;
                                }
                            }
                            else
                            {
                                for (i = 0; i < 2; i++)
                                {
                                    if (i == 0)
                                    {
                                        x_dif = x - 1 - half_dim < 0 ? 0 : x - 1 - half_dim;
                                    }
                                    else
                                    {
                                        blue_avrg = -blue_avrg;
                                        green_avrg = - green_avrg;
                                        red_avrg = - red_avrg;
                                        x_dif = x + half_dim > width - 1 ? (width - 1) : x + half_dim;
                                    }
                                    for (j = -half_dim; j <= half_dim; j++)
                                    {
                                        y_dif = y + j < 0 ? 0 : ((y + j > height - 1) ? (height - 1) : (y + j));

                                        dataAux = dataPtrAux + (x_dif * nChan) + (y_dif * widthStep);

                                        blue_avrg += dataAux[0];
                                        green_avrg += dataAux[1];
                                        red_avrg += dataAux[2];
                                    }
                                }
                                dataPtr[0] = (byte)((bh + blue_avrg) / (dim * dim));
                                dataPtr[1] = (byte)((gh + green_avrg) / (dim * dim));
                                dataPtr[2] = (byte)((rh + red_avrg) / (dim * dim));
                                bh += blue_avrg;
                                gh += green_avrg;
                                rh += red_avrg;
                            }                            
                            // advance the pointer to the next pixel
                            dataPtr += nChan; //nChan: numero de canais
                        }
                        //at the end of the line advance the pointer by the aligment bytes (padding)
                        dataPtr += padding; // +2 * nChan;
                    }
                }
            }
        }

        public static void sobelFilter(Image<Bgr, byte> img, Image<Bgr, byte> imgUndo, int dim, String coef, String coef_2)
        {
            unsafe
            {
                // direct access to the image memory(sequencial)
                // direcion top left -> bottom right

                MIplImage m = img.MIplImage;
                MIplImage mUndo = imgUndo.MIplImage;
                byte* dataPtr = (byte*)m.imageData.ToPointer(); // Pointer to the image
                byte* dataPtrAux = (byte*)mUndo.imageData.ToPointer();
                coef = coef.Trim();
                string[] numbers = coef.Split(',');
                int[] myInts = Array.ConvertAll(numbers, int.Parse);
                coef_2 = coef_2.Trim();
                string[] numbers_2 = coef_2.Split(',');
                int[] myInts_2 = Array.ConvertAll(numbers_2, int.Parse);

                int blue_avrg = 0, green_avrg = 0, red_avrg = 0;
                int blue_avrg_2 = 0, green_avrg_2 = 0, red_avrg_2 = 0;

                int width = img.Width;
                int widthStep = m.widthStep;
                int height = img.Height;
                int nChan = m.nChannels; // number of channels - 3
                int padding = m.widthStep - m.nChannels * m.width; // alinhament bytes (padding)
                int x, y;
                int i, j;
                int cycles = 0, num, num_2;
                int half_dim = (int)(dim / 2); //Metade da divisão inteira da dimensão

                int x_dif = 0, y_dif = 0; // Estas variáveis indicam se a área do filtro supera as dimensões da imagem. Se tiverem valores positivos, 
                // quer dizer que são superiores à altura (Y) ou ao comprimento (X), se tiverem valores negativos, 
                // significa que o filtro supera a menor dimensão de x ou y;

                byte* dataAux = dataPtrAux; // Variável auxiliar que serve para repor o valor de dataPtrAux sempre que necessário.
                byte* dataAux2 = dataPtrAux;
                


                if (nChan == 3) // image in RGB
                {
                    //dataPtr += widthStep + nChan;
                    for (y = 0; y < height; y++)
                    {
                        for (x = 0; x < width; x++)
                        {
                            blue_avrg = 0;
                            green_avrg = 0;
                            red_avrg = 0;
                            blue_avrg_2 = 0;
                            green_avrg_2 = 0;
                            red_avrg_2 = 0;
                            if ((x - half_dim) < 0 || (y - half_dim) < 0 || (x + half_dim) > (width - 1) || (y + half_dim) > (height - 1))
                            {
                                dataAux2 = dataAux;
                                cycles = 0;
                                for (i = -half_dim; i <= half_dim; i++)
                                {
                                    for (j = -half_dim; j <= half_dim; j++)
                                    {
                                        y_dif = y + i < 0 ? 0 : ((y + i > height - 1) ? (height - 1) : (y + i));
                                        x_dif = x + j < 0 ? 0 : ((x + j > width - 1) ? (width - 1) : (x + j));

                                        num = myInts[cycles];
                                        num_2 = myInts_2[cycles];
                                        dataAux = dataPtrAux + (x_dif * nChan) + (y_dif * widthStep);

                                        blue_avrg += num * dataAux[0];
                                        green_avrg += num * dataAux[1];
                                        red_avrg += num * dataAux[2];
                                        blue_avrg_2 += num_2 * dataAux[0];
                                        green_avrg_2 += num_2 * dataAux[1];
                                        red_avrg_2 += num_2 * dataAux[2];

                                        cycles++;
                                    }
                                }
                                dataAux = dataAux2;
                            }
                            else
                            {
                                //Kernel
                                cycles = 0;
                                dataAux2 = dataAux;
                                dataAux -= (half_dim) * widthStep;
                                dataAux -= (half_dim) * nChan;
                                for (i = 0; i < dim; i++)
                                {
                                    for (j = 0; j < dim; j++)
                                    {
                                        num = myInts[cycles];
                                        num_2 = myInts_2[cycles];
                                        blue_avrg += num * dataAux[0];
                                        green_avrg += num * dataAux[1];
                                        red_avrg += num * dataAux[2];
                                        blue_avrg_2 += num_2 * dataAux[0];
                                        green_avrg_2 += num_2 * dataAux[1];
                                        red_avrg_2 += num_2 * dataAux[2];

                                        dataAux += nChan;
                                        cycles++;
                                    }
                                    dataAux += widthStep - dim * nChan;
                                }
                                dataAux = dataAux2;
                            }
                            // convert to gray
                            //gray = (byte)(((int)blue + green + red) / 3);

                            // store in the image
                            dataPtr[0] = (byte)(Math.Abs(blue_avrg) + Math.Abs(blue_avrg_2) > 255 ? 255 : Math.Abs(blue_avrg) + Math.Abs(blue_avrg_2));
                            dataPtr[1] = (byte)(Math.Abs(green_avrg) + Math.Abs(green_avrg_2) > 255 ? 255 : Math.Abs(green_avrg) + Math.Abs(green_avrg_2));
                            dataPtr[2] = (byte)(Math.Abs(red_avrg) + Math.Abs(red_avrg_2) > 255 ? 255 : Math.Abs(red_avrg) + Math.Abs(red_avrg_2));

                            // advance the pointer to the next pixel
                            dataPtr += nChan; //nChan: numero de canais
                            dataAux += nChan;
                        }
                        //at the end of the line advance the pointer by the aligment bytes (padding)
                        dataPtr += padding; // +2 * nChan;
                        dataAux += padding;
                    }
                }
            }
        }

        public static void diffFilter(Image<Bgr, byte> img)
        {
            unsafe
            {
                // direct access to the image memory(sequencial)
                // direcion top left -> bottom right

                MIplImage m = img.MIplImage;
                byte* dataPtr = (byte*)m.imageData.ToPointer(); // Pointer to the image
                int blue, red, green;

                int width = img.Width;
                int widthStep = m.widthStep;
                int height = img.Height;
                int nChan = m.nChannels; // number of channels - 3
                int padding = m.widthStep - m.nChannels * m.width; // alinhament bytes (padding)
                int x, y;

                int x_dif = 0, y_dif = 0; // Estas variáveis indicam se a área do filtro supera as dimensões da imagem. Se tiverem valores positivos, 
                // quer dizer que são superiores à altura (Y) ou ao comprimento (X), se tiverem valores negativos, 
                // significa que o filtro supera a menor dimensão de x ou y;

                if (nChan == 3) // image in RGB
                {
                    //dataPtr += widthStep + nChan;
                    for (y = 0; y < height; y++)
                    {
                        for (x = 0; x < width; x++)
                        {
                            if (x == width - 1 || y == height-1)
                            {
                                x_dif = x + 1 >= width ? 0 : 1;
                                y_dif = y + 1 >= height ? 0 : 1;

                                blue = Math.Abs(dataPtr[0] - (dataPtr + (x_dif * nChan))[0]) + Math.Abs(dataPtr[0] - (dataPtr + (y_dif * widthStep))[0]);
                                green = Math.Abs(dataPtr[1] - (dataPtr + (x_dif * nChan))[1]) + Math.Abs(dataPtr[1] - (dataPtr + (y_dif * widthStep))[1]);
                                red = Math.Abs(dataPtr[2] - (dataPtr + (x_dif * nChan))[2]) + Math.Abs(dataPtr[2] - (dataPtr + (y_dif * widthStep))[2]);
                            }
                            else
                            {
                                blue = Math.Abs(dataPtr[0] - (dataPtr + nChan)[0]) + Math.Abs(dataPtr[0] - (dataPtr + widthStep)[0]);
                                green = Math.Abs(dataPtr[1] - (dataPtr + nChan)[1]) + Math.Abs(dataPtr[1] - (dataPtr + widthStep)[1]);
                                red = Math.Abs(dataPtr[2] - (dataPtr + nChan)[2]) + Math.Abs(dataPtr[2] - (dataPtr + widthStep)[2]);                                
                            }

                            dataPtr[0] = (byte)(blue > 255 ? 255 : blue);
                            dataPtr[1] = (byte)(green > 255 ? 255 : green);
                            dataPtr[2] = (byte)(red > 255 ? 255 : red);   
                            // advance the pointer to the next pixel
                            dataPtr += nChan; //nChan: numero de canais
                        }
                        //at the end of the line advance the pointer by the aligment bytes (padding)
                        dataPtr += padding; // +2 * nChan;
                    }
                }
            }
        }

        public static void averageFilterC(Image<Bgr, byte> img, Image<Bgr, byte> imgUndo, int dim)
        {
            unsafe
            {
                // direct access to the image memory(sequencial)
                // direcion top left -> bottom right

                MIplImage m = img.MIplImage;
                MIplImage mUndo = imgUndo.MIplImage;
                byte* dataPtr = (byte*)m.imageData.ToPointer(); // Pointer to the image
                byte* dataPtrAux = (byte*)mUndo.imageData.ToPointer();
                int blue_avrg = 0, green_avrg = 0, red_avrg = 0;
                int bh = 0, gh = 0, rh = 0;
                int bt = 0, gt = 0, rt = 0;
                
                int width = img.Width;
                int widthStep = m.widthStep;
                int height = img.Height;
                colors [] sums = new colors[width];
                int position = 0;
                int nChan = m.nChannels; // number of channels - 3
                int padding = m.widthStep - m.nChannels * m.width; // alinhament bytes (padding)
                int x, y;
                int i, j;
                int half_dim = (int)(dim / 2); //Metade da divisão inteira da dimensão

                int x_dif = 0, y_dif = 0; // Estas variáveis indicam se a área do filtro supera as dimensões da imagem. Se tiverem valores positivos, 
                int x_dif_above = 0, y_dif_above = 0;
                byte* p00, p01, p10, p11;
                // quer dizer que são superiores à altura (Y) ou ao comprimento (X), se tiverem valores negativos, 
                // significa que o filtro supera a menor dimensão de x ou y;

                byte* dataAux = dataPtrAux; // Variável auxiliar que serve para repor o valor de dataPtrAux sempre que necessário.

                if (nChan == 3) // image in RGB
                {
                    for (i = -half_dim; i <= half_dim; i++)
                    {
                        for (j = -half_dim; j <= half_dim; j++)
                        {
                            y_dif = i < 0 ? 0 : i;
                            x_dif = j < 0 ? 0 : j;

                            dataAux = dataPtrAux + (x_dif * nChan) + (y_dif * widthStep);

                            blue_avrg += dataAux[0];
                            green_avrg += dataAux[1];
                            red_avrg += dataAux[2];
                        }
                    }
                    sums[position].blue = blue_avrg;
                    sums[position].green = green_avrg;
                    sums[position].red = red_avrg;
                    dataPtr[0] = (byte)(blue_avrg / (dim * dim));
                    dataPtr[1] = (byte)(green_avrg / (dim * dim));
                    dataPtr[2] = (byte)(red_avrg / (dim * dim));
                    position++;

                    for (y = 0; y < height; y++)
                    {
                        for (x = 0; x < width; x++)
                        {
                            blue_avrg = 0;
                            green_avrg = 0;
                            red_avrg = 0;
                            if (x == 0)
                            {
                                if (y != 0)
                                {
                                    for (i = 0; i < 2; i++)
                                    {
                                        if (i == 0)
                                        {
                                            y_dif = y - 1 - half_dim < 0 ? 0 : y - 1 - half_dim;
                                        }
                                        else
                                        {
                                            blue_avrg = -blue_avrg;
                                            green_avrg = -green_avrg;
                                            red_avrg = -red_avrg;
                                            y_dif = y + half_dim > height - 1 ? (height - 1) : y + half_dim;
                                        }
                                        for (j = -half_dim; j <= half_dim; j++)
                                        {
                                            x_dif = x + j < 0 ? 0 : ((x + j > width - 1) ? (width - 1) : (x + j));

                                            dataAux = dataPtrAux + (x_dif * nChan) + (y_dif * widthStep);

                                            blue_avrg += dataAux[0];
                                            green_avrg += dataAux[1];
                                            red_avrg += dataAux[2];
                                        }
                                    }
                                    position = 0;
                                    dataPtr[0] = (byte)((blue_avrg + sums[position].blue) / (dim * dim));
                                    dataPtr[1] = (byte)((green_avrg + sums[position].green) / (dim * dim));
                                    dataPtr[2] = (byte)((red_avrg + sums[position].red) / (dim * dim));                              
                                    bh = sums[position].blue;
                                    gh = sums[position].green;
                                    rh = sums[position].red;
                                    sums[position].blue += blue_avrg;
                                    sums[position].green += green_avrg;
                                    sums[position].red += red_avrg;
                                    position++;
                                }
                            }
                            else if(y==0)
                            {
                                for (i = 0; i < 2; i++)
                                {
                                    if (i == 0)
                                    {
                                        x_dif = x - 1 - half_dim < 0 ? 0 : x - 1 - half_dim;
                                    }
                                    else
                                    {
                                        blue_avrg = -blue_avrg;
                                        green_avrg = -green_avrg;
                                        red_avrg = -red_avrg;
                                        x_dif = x + half_dim > width - 1 ? (width - 1) : x + half_dim;
                                    }
                                    for (j = -half_dim; j <= half_dim; j++)
                                    {
                                        y_dif = y + j < 0 ? 0 : ((y + j > height - 1) ? (height - 1) : (y + j));

                                        dataAux = dataPtrAux + (x_dif * nChan) + (y_dif * widthStep);

                                        blue_avrg += dataAux[0];
                                        green_avrg += dataAux[1];
                                        red_avrg += dataAux[2];
                                    }
                                }
                                dataPtr[0] = (byte)((sums[position-1].blue + blue_avrg) / (dim * dim));
                                dataPtr[1] = (byte)((sums[position-1].green + green_avrg) / (dim * dim));
                                dataPtr[2] = (byte)((sums[position-1].red + red_avrg) / (dim * dim));
                                sums[position].blue = sums[position - 1].blue + blue_avrg;
                                sums[position].green = sums[position - 1].green + green_avrg;
                                sums[position].red = sums[position - 1].red + red_avrg;
                                position++;
                            }
                            else
                            {
                                x_dif = x - half_dim - 1 < 0 ? 0 : x - half_dim - 1;
                                y_dif = y - half_dim - 1 < 0 ? 0 : y - half_dim - 1;
                                x_dif_above = x + half_dim > width - 1 ? width - 1 : x + half_dim;
                                y_dif_above = y + half_dim > height - 1 ? height - 1 : y + half_dim;

                                p00 = dataPtrAux + (x_dif * nChan) + (y_dif * widthStep);
                                p10 = dataPtrAux + (x_dif_above * nChan) + (y_dif * widthStep);
                                p01 = dataPtrAux + (x_dif * nChan) + (y_dif_above * widthStep);
                                p11 = dataPtrAux + (x_dif_above * nChan) + (y_dif_above * widthStep);

                                dataPtr[0] = (byte)((sums[position].blue - bh + sums[position - 1].blue + p00[0] - p10[0] - p01[0] + p11[0]) / (dim * dim));
                                dataPtr[1] = (byte)((sums[position].green - gh + sums[position - 1].green + p00[1] - p10[1] - p01[1] + p11[1]) / (dim * dim));
                                dataPtr[2] = (byte)((sums[position].red - rh + sums[position - 1].red + p00[2] - p10[2] - p01[2] + p11[2]) / (dim * dim));

                                bt = sums[position].blue;
                                gt = sums[position].green;
                                rt = sums[position].red;
                                sums[position].blue = sums[position].blue - bh + sums[position - 1].blue + p00[0] - p10[0] - p01[0] + p11[0];
                                sums[position].green = sums[position].green - gh + sums[position - 1].green + p00[1] - p10[1] - p01[1] + p11[1];
                                sums[position].red = sums[position].red - rh + sums[position - 1].red + p00[2] - p10[2] - p01[2] + p11[2];
                                bh = bt;
                                gh = gt;
                                rh = rt;
                                position++;
                            }
                            // advance the pointer to the next pixel
                            dataPtr += nChan; //nChan: numero de canais
                        }
                        //at the end of the line advance the pointer by the aligment bytes (padding)
                        dataPtr += padding; // +2 * nChan;
                    }
                }
            }
        }

        public static void robertsFilter(Image<Bgr, byte> img)
        {
            unsafe
            {
                // direct access to the image memory(sequencial)
                // direcion top left -> bottom right

                MIplImage m = img.MIplImage;
                byte* dataPtr = (byte*)m.imageData.ToPointer(); // Pointer to the image
                int blue, red, green;

                int width = img.Width;
                int widthStep = m.widthStep;
                int height = img.Height;
                int nChan = m.nChannels; // number of channels - 3
                int padding = m.widthStep - m.nChannels * m.width; // alinhament bytes (padding)
                int x, y;

                int x_dif = 0, y_dif = 0; // Estas variáveis indicam se a área do filtro supera as dimensões da imagem. Se tiverem valores positivos, 
                // quer dizer que são superiores à altura (Y) ou ao comprimento (X), se tiverem valores negativos, 
                // significa que o filtro supera a menor dimensão de x ou y;

                if (nChan == 3) // image in RGB
                {
                    //dataPtr += widthStep + nChan;
                    for (y = 0; y < height; y++)
                    {
                        for (x = 0; x < width; x++)
                        {
                            if (x == width - 1 || y == height - 1)
                            {
                                x_dif = x + 1 >= width ? 0 : 1;
                                y_dif = y + 1 >= height ? 0 : 1;

                                blue = Math.Abs(dataPtr[0] - (dataPtr + (x_dif * nChan) + (y_dif * widthStep))[0]) + Math.Abs((dataPtr + (x_dif * nChan))[0] - (dataPtr + (y_dif * widthStep))[0]);
                                green = Math.Abs(dataPtr[1] - (dataPtr + (x_dif * nChan) + (y_dif * widthStep))[1]) + Math.Abs((dataPtr + (x_dif * nChan))[1] - (dataPtr + (y_dif * widthStep))[1]);
                                red = Math.Abs(dataPtr[2] - (dataPtr + (x_dif * nChan) + (y_dif * widthStep))[2]) + Math.Abs((dataPtr + (x_dif * nChan))[2] - (dataPtr + (y_dif * widthStep))[2]);
                            }
                            else
                            {
                                blue = Math.Abs(dataPtr[0] - (dataPtr + nChan + widthStep)[0]) + Math.Abs((dataPtr + nChan)[0] - (dataPtr + widthStep)[0]);
                                green = Math.Abs(dataPtr[1] - (dataPtr + nChan + widthStep)[1]) + Math.Abs((dataPtr + nChan)[1] - (dataPtr + widthStep)[1]);
                                red = Math.Abs(dataPtr[2] - (dataPtr + nChan + widthStep)[2]) + Math.Abs((dataPtr + nChan)[2] - (dataPtr + widthStep)[2]);
                            }

                            dataPtr[0] = (byte)(blue > 255 ? 255 : blue);
                            dataPtr[1] = (byte)(green > 255 ? 255 : green);
                            dataPtr[2] = (byte)(red > 255 ? 255 : red);                            
                            // advance the pointer to the next pixel                            
                            dataPtr += nChan; //nChan: numero de canais
                        }
                        //at the end of the line advance the pointer by the aligment bytes (padding)
                        dataPtr += padding; // +2 * nChan;
                    }
                }
            }
        }

        public static void medianFilter(Image<Bgr, byte> img, Image<Bgr, byte> imgUndo, int dim)
        {
            unsafe
            {
                // direct access to the image memory(sequencial)
                // direcion top left -> bottom right

                MIplImage m = img.MIplImage;
                MIplImage mUndo = imgUndo.MIplImage;
                byte* dataPtr = (byte*)m.imageData.ToPointer(); // Pointer to the image
                byte* dataPtrAux = (byte*)mUndo.imageData.ToPointer();
                int blue_avrg = 0, green_avrg = 0, red_avrg = 0;

                int width = img.Width;
                int widthStep = m.widthStep;
                int height = img.Height;
                int nChan = m.nChannels; // number of channels - 3
                int padding = m.widthStep - m.nChannels * m.width; // alinhament bytes (padding)
                int x, y;
                int i, j;
                int half_dim = (int)(dim / 2); //Metade da divisão inteira da dimensão

                int x_dif = 0, y_dif = 0; // Estas variáveis indicam se a área do filtro supera as dimensões da imagem. Se tiverem valores positivos, 
                // quer dizer que são superiores à altura (Y) ou ao comprimento (X), se tiverem valores negativos, 
                // significa que o filtro supera a menor dimensão de x ou y;

                byte* dataAux = dataPtrAux; // Variável auxiliar que serve para repor o valor de dataPtrAux sempre que necessário.
                byte* dataAux2 = dataPtrAux;

                int dim2 = dim * dim;//Quadrado da dimensão (usado para evitar fazer muitas operações)

                int[] vectBlue = new int[dim2];
                int[] vectGreen = new int[dim2];
                int[] vectRed = new int[dim2];
                Double[] euclidean = new Double[dim2];
                Double[] euclidean2 = new Double[dim2];
                int index = 0;
                int half_dim2 = dim2/2;
                int iter = dim2 - 1;
                int cnt = 0; //variavel para percorrer um dos vectores (0 até dim*dim-1)


                if (nChan == 3) // image in RGB
                {
                    //dataPtr += widthStep + nChan;
                    for (y = 0; y < height; y++)
                    {
                        for (x = 0; x < width; x++)
                        {
                            cnt = 0;
                            if ((x - half_dim) < 0 || (y - half_dim) < 0 || (x + half_dim) > (width - 1) || (y + half_dim) > (height - 1))
                            {
                                dataAux2 = dataAux;
                                for (i = -half_dim; i <= half_dim; i++)
                                {
                                    for (j = -half_dim; j <= half_dim; j++)
                                    {
                                        y_dif = y + i < 0 ? 0 : ((y + i > height - 1) ? (height - 1) : (y + i));
                                        x_dif = x + j < 0 ? 0 : ((x + j > width - 1) ? (width - 1) : (x + j));

                                        dataAux = dataPtrAux + (x_dif * nChan) + (y_dif * widthStep);

                                        vectBlue[cnt] = dataAux[0];
                                        vectGreen[cnt] = dataAux[1];
                                        vectRed[cnt] = dataAux[2];

                                        cnt++;
                                    }
                                }

                                cnt = 0;
                                index = 0;
                                for (i = 0; i < dim2; i++)
                                {
                                    euclidean[cnt]=0.0;
                                    for (j = 0; j < dim2; j++)
                                    {
                                        euclidean[cnt] += Math.Abs(vectBlue[i] - vectBlue[j]) + Math.Abs(vectGreen[i] - vectGreen[j]) + Math.Abs(vectRed[i] - vectRed[j]);                                              
                                    }
                                    if (euclidean[cnt] < euclidean[index])
                                    {
                                        index = cnt;
                                    }
                                    cnt++;
                                }
                                blue_avrg = vectBlue[index];
                                green_avrg = vectGreen[index];
                                red_avrg = vectRed[index];

                                dataAux = dataAux2;
                            }
                            else
                            {
                                //Kernel
                                dataAux2 = dataAux;
                                dataAux -= (half_dim) * widthStep;
                                dataAux -= (half_dim) * nChan;
                                for (i = 0; i < dim; i++)
                                {
                                    for (j = 0; j < dim; j++)
                                    {
                                        vectBlue[cnt] = dataAux[0];
                                        vectGreen[cnt] = dataAux[1];
                                        vectRed[cnt] = dataAux[2];
                                        dataAux += nChan;
                                        cnt++;
                                    }
                                    dataAux += widthStep - dim * nChan;
                                }

                                cnt = 0;
                                index = 0;
                                for (i = 0; i < dim2; i++)
                                {
                                    euclidean[cnt] = 0.0;
                                    for (j = 0; j < dim2; j++)
                                    {
                                        euclidean[cnt] += Math.Abs(vectBlue[i] - vectBlue[j]) + Math.Abs(vectGreen[i] - vectGreen[j]) + Math.Abs(vectRed[i] - vectRed[j]);                                        
                                    }
                                    if (euclidean[cnt] < euclidean[index])
                                    {
                                        index = cnt;
                                    }
                                    cnt++;
                                }                            
                                blue_avrg = vectBlue[index];
                                green_avrg = vectGreen[index];
                                red_avrg = vectRed[index];
                                
                                dataAux = dataAux2;
                            }

                            // store in the image
                            dataPtr[0] = (byte)(blue_avrg);
                            dataPtr[1] = (byte)(green_avrg);
                            dataPtr[2] = (byte)(red_avrg);

                            // advance the pointer to the next pixel
                            dataPtr += nChan; //nChan: numero de canais
                            dataAux += nChan;
                        }
                        //at the end of the line advance the pointer by the aligment bytes (padding)
                        dataPtr += padding; // +2 * nChan;
                        dataAux += padding;
                    }
                }
            }
        }

        public static int [,] createHistogram(Image<Bgr, byte> img)
        {
            unsafe
            {
                int[,] histogram = new int[4, 256];
                MIplImage m = img.MIplImage;
                byte* dataPtr = (byte*)m.imageData.ToPointer();
                int nChan = m.nChannels; // number of channels - 3
                int padding = m.widthStep - m.nChannels * m.width; // alinhament bytes (padding)
                int x, y;
                int width = img.Width;
                int height = img.Height;
                int blue, red, green; 

                // convert to gray
                int gray; 

                if (nChan == 3) // image in RGB
                {
                    for (y = 0; y < height; y++)
                    {
                        for (x = 0; x < width; x++)
                        {
                            histogram[0, (int)dataPtr[2]]++; //RED
                            histogram[1, (int)dataPtr[1]]++; //GREEN
                            histogram[2, (int)dataPtr[0]]++; //BLUE
                            blue = dataPtr[0];
                            green = dataPtr[1];
                            red = dataPtr[2];
                            gray = (blue + green + red) / 3;
                            histogram[3, gray]++; //GRAY
                            dataPtr += nChan;
                        }
                        dataPtr += padding;
                    }
                }

                return histogram;
            }
        }

        public static void calcManual(Image<Bgr, byte> img, int threshold)
        {
            unsafe{
                MIplImage m = img.MIplImage;
                byte* dataPtr = (byte*)m.imageData.ToPointer();
                int nChan = m.nChannels; // number of channels - 3
                int padding = m.widthStep - m.nChannels * m.width; // alinhament bytes (padding)
                int x, y;
                int width = img.Width;
                int height = img.Height;
                int blue, red, green;

                // convert to gray
                int gray;

                if (nChan == 3) // image in RGB
                    {
                        for (y = 0; y < height; y++)
                        {
                            for (x = 0; x < width; x++)
                            {
                                blue = dataPtr[0];
                                green = dataPtr[1];
                                red = dataPtr[2];
                                gray = (blue + green + red) / 3;

                                if (gray >= threshold)
                                {
                                    dataPtr[0] = 255;
                                    dataPtr[1] = 255;
                                    dataPtr[2] = 255;
                                }
                                else
                                {
                                    dataPtr[0] = 0;
                                    dataPtr[1] = 0;
                                    dataPtr[2] = 0;
                                }

                                dataPtr += nChan;
                            }
                            dataPtr += padding;
                    }
                }
             }
        }


        public static void calcOtsu(Image<Bgr, byte> img, int [,] histogram)
        {
            unsafe
            {
                MIplImage m = img.MIplImage;
                byte* dataPtr = (byte*)m.imageData.ToPointer();
                int nChan = m.nChannels; // number of channels - 3
                int padding = m.widthStep - m.nChannels * m.width; // alinhament bytes (padding)
                int x, y;
                int width = img.Width;
                int height = img.Height;
                int blue, red, green;

                // convert to gray
                int gray;

                double[] histProb = new double[256];
                double[] variance = new double[256];
                double val = 0e-15;
                int t = 127;
                int dim = img.Width * img.Height;
                for (int j = 0; j < 256; j++)
                {
                    val = ((double)histogram[3, j] / dim);
                    histProb[j] = val;
                }

                for (int i = 0; i < 256; i++)
                {
                    variance[i] = (detQ(1, histProb, i) * detVar(1, histProb, i)) + (detQ(2, histProb, i) * detVar(2, histProb, i));
                }

                int index = min(variance);

                if (nChan == 3) // image in RGB
                {
                    for (y = 0; y < height; y++)
                    {
                        for (x = 0; x < width; x++)
                        {
                            blue = dataPtr[0];
                            green = dataPtr[1];
                            red = dataPtr[2];
                            gray = (blue + green + red) / 3;

                            if (gray >= index)
                            {
                                dataPtr[0] = 255;
                                dataPtr[1] = 255;
                                dataPtr[2] = 255;
                            }
                            else
                            {
                                dataPtr[0] = 0;
                                dataPtr[1] = 0;
                                dataPtr[2] = 0;
                            }

                            dataPtr += nChan;
                        }
                        dataPtr += padding;
                    }
                }
             }
        }

        private static double detVar(int ind, double[] histProb, int threshold)
        {
            int end_ind = 256, start_ind = 0;
            double sum = 0;
            switch (ind)
            {
                case 1: end_ind = threshold + 1; break;
                case 2: start_ind = threshold + 1; break;
            }

            for (int i = start_ind; i < end_ind; i++)
            {
                sum += Math.Pow((detMiu(ind,histProb,threshold) - i),2)*histProb[i];
            }

            switch (ind)
            {
                case 1: sum = sum / (threshold + 1); break;
                case 2: if (256 - (threshold + 1) > 0) { sum = sum / (256 - (threshold + 1)); }  break;
            }

            return sum;
        }

        private static double detMiu(int ind, double[] histProb, int threshold)
        {
            int end_ind = 256, start_ind = 0;
            double sum = 0, q = 0;
            switch (ind)
            {
                case 1: end_ind = threshold + 1; break;
                case 2: start_ind = threshold + 1; break;
            }

            for (int i = start_ind; i < end_ind; i++)
            {
                sum += i*histProb[i];
            }

            q = detQ(ind, histProb, threshold);
            if (q != 0)
            {
                sum = sum / q;
            }

            return sum;
        }

        private static double detQ(int ind, double[] histProb, int threshold)
        {
            int end_ind = 256, start_ind = 0;
            double sum = 0;
            switch (ind)
            {
                case 1: end_ind = threshold + 1; break;
                case 2: start_ind = threshold + 1; break;
            }

            for (int i = start_ind; i < end_ind; i++)
            {
                sum += histProb[i];
            }

            return sum;
        }

        private static int min(double[] vector)
        {
            int index = 0;
            double last = vector[0];
            for (int i = 0; i < vector.Length; i++)
            {
                if (vector[i] < last)
                {
                    index = i;
                    last = vector[i];
                }
            }
            return index;
        }

        private static int max(int[] vector)
        {
            int index = 0;
            double last = vector[0];
            for (int i = 0; i < vector.Length; i++)
            {
                if (vector[i] > last)
                {
                    index = i;
                    last = vector[i];
                }
            }
            return index;
        }

        public static Image<Bgr, byte> createRowLevels(Image<Bgr, byte> img, Image<Bgr, byte> imgAux)
        {
            unsafe
            {
                MIplImage m = img.MIplImage;
                byte* dataPtr = (byte*)m.imageData.ToPointer();
                int nChan = m.nChannels; // number of channels - 3
                int padding = m.widthStep - m.nChannels * m.width; // alinhament bytes (padding)
                int x, y;
                int width = img.Width;
                int height = img.Height;
                int[] rows = new int[height];
                var myHashMap = new Dictionary<int, int[]>();
                ArrayList ItemList = new ArrayList();
                int [] cell = new int[2];
                int max_ind = 0;
                int bottom = 0, up = 0, dif = 0;
                System.Drawing.Rectangle rect = new System.Drawing.Rectangle();
                

                // convert to gray

                if (nChan == 3) // image in RGB
                {
                    for (y = 0; y < height; y++)
                    {
                        for (x = 0; x < width; x++)
                        {
                            if ((x < width - 1) && (dataPtr[0] != (dataPtr + nChan)[0]))
                            {
                                rows[y]++;
                            }
                            dataPtr += nChan;
                        }
                        dataPtr += padding;
                    }

                    max_ind = max(rows);
                    ItemList.Add(max_ind);

                    for (y = max_ind; y > -1; y--)
                    {
                        if (((double)rows[y] / rows[max_ind]) <= 0.5)
                        {
                            up = y;
                            break;
                        }
                    }

                    for (y = max_ind; y < height; y++)
                    {
                        if (((double)rows[y] / rows[max_ind]) <= 0.5)
                        {
                            bottom = y;                            
                            break;
                        }
                    }

                    dif = bottom - up;
                    up = (int)(up - (0.1 * dif));
                    bottom = (int)(bottom + (0.1 * dif));

                    ItemList.Add(up);
                    ItemList.Add(bottom);
                    rect = new System.Drawing.Rectangle(0,up,width,(bottom+2-up));

                    /*for (int i = 0; i <= id; i++)
                    {
                        value = myHashMap[i];
                        if (value[1] - value[0] <= 15)
                        {
                            myHashMap.Remove(i);
                        }
                        else if (init != value[0])
                        {
                            value[0] = init;
                            init = value[1];
                            ItemList.Add(value[1]);
                        }
                        else
                        {
                            init = value[1];
                            ItemList.Add(value[1]);
                        }
                    }*/                    
                }
                return imgAux.Copy(rect);
            }
        }

        public static Image<Bgr, byte> [] findText(Image<Bgr, byte> img, int[,] labels, Image<Bgr, byte> imgAux)
        {
            unsafe
            {
                MIplImage m = img.MIplImage;
                byte* dataPtr = (byte*)m.imageData.ToPointer();
                byte* dataPtrAux;
                int nChan = m.nChannels; // number of channels - 3
                int padding = m.widthStep - m.nChannels * m.width; // alinhament bytes (padding)
                int widthStep = m.widthStep;
                int width = img.Width;
                int x, y;
                int height = img.Height;
                int x_init = width, y_init = height;
                int x_final = 0, y_final = 0;
                int value;
                int[] dim = new int[5];
                ArrayList list = new ArrayList();
                ArrayList listDim = new ArrayList();
                ArrayList listMax = new ArrayList();
                ArrayList listSort = new ArrayList();
                System.Drawing.Rectangle rect = new System.Drawing.Rectangle();
                Image<Bgr, byte>[] values = new Image<Bgr, byte>[6];

                if (nChan == 3) // image in RGB
                {
                    for (y = 0; y < height; y++)
                    {
                        for (x = 0; x < width; x++)
                        {
                            value = labels[y,x];
                            if (!list.Contains(value))
                            {
                                list.Add(value);
                            }
                        }
                    }
                    list.Remove(0);
                    list.Sort();
                    dataPtrAux = dataPtr;
                    for (int i = 0; i < list.Count; i++)
                    {
                        dataPtr = dataPtrAux;
                        for (y = 0; y < height; y++)
                        {
                            for (x = 0; x < width; x++)
                            {
                                /*if (labels[y, x] == 391) //395-398
                                {
                                    dataPtr[0] = 0;
                                    dataPtr[1] = 0;
                                    dataPtr[2] = 0;
                                }
                                else
                                {
                                    dataPtr[0] = 255;
                                    dataPtr[1] = 255;
                                    dataPtr[2] = 255;
                                }*/
                                if (labels[y, x] == (int)list[i])
                                {
                                    if (x < x_init)
                                    {
                                        x_init = x;
                                    }

                                    if (y < y_init)
                                    {
                                        y_init = y;
                                    }

                                    if (x > x_final)
                                    {
                                        x_final = x;
                                    }

                                    if (y > y_final)
                                    {
                                        y_final = y;
                                    }
                                }
                                dataPtr += nChan;
                            }
                            dataPtr += padding;
                        }
                        dim[0] = x_final - x_init;
                        dim[1] = y_final - y_init;
                        dim[2] = x_init;
                        dim[3] = y_init;
                        dim[4] = (int)list[i];
                        listDim.Add(dim.Clone());
                        x_init = width;
                        y_init = height;
                        x_final = 0;
                        y_final = 0;
                    }

                    int max = 0;
                    int index = 0;
                    for (int j = 0; j < 6; j++)
                    {
                        for (int i = 0; i < listDim.Count; i++)
                        {
                            if (max < ((int[])listDim[i])[1] && ((int[])listDim[i])[0] != 0 &&
                                ((int[])listDim[i])[0] < ((int[])listDim[i])[1] && ((int[])listDim[i])[1] < height-1)
                            {
                                max = ((int[])listDim[i])[1];
                                index = i;
                            }                            
                        }
                        listMax.Add(((int[])listDim[index]).Clone());
                        listDim.RemoveAt(index);
                        index = 0;
                        max = 0;
                    }

                    listSort.Add(((int[])listMax[0])[2]);
                    listSort.Add(((int[])listMax[1])[2]);
                    listSort.Add(((int[])listMax[2])[2]);
                    listSort.Add(((int[])listMax[3])[2]);
                    listSort.Add(((int[])listMax[4])[2]);
                    listSort.Add(((int[])listMax[5])[2]);

                    listSort.Sort();

                    for (int i = 0; i < 6; i++)
                    {
                        for (int j = 0; j < 6; j++)
                        {
                            if ((int)listSort[i] == ((int[])listMax[j])[2])
                            {
                                rect = new System.Drawing.Rectangle(((int[])listMax[j])[2], ((int[])listMax[j])[3], ((int[])listMax[j])[0] + 1, ((int[])listMax[j])[1] + 1);
                                values[i] = imgAux.Copy(rect);
                            }
                        }
                    }                        
                }
                return values;
            }
        }

        public static int[,] linkedLabels(Image<Bgr, byte> img)
        {
            unsafe
            {
                MIplImage m = img.MIplImage;
                Dictionary<int, int> relations = new Dictionary<int, int>();
                byte* dataPtr = (byte*)m.imageData.ToPointer();
                int nChan = m.nChannels; // number of channels - 3
                int padding = m.widthStep - m.nChannels * m.width; // alinhament bytes (padding)
                int widthStep = m.widthStep;
                int width = img.Width;
                int x, y;
                int x_aux, y_aux;
                int val_aux;
                int labelNumber = 1;
                int height = img.Height;
                int[,] labels = new int[height, width];

                if (nChan == 3) // image in RGB
                {
                    for (y = 0; y < height; y++)
                    {
                        for (x = 0; x < width; x++)
                        {
                            if (dataPtr[0] == 0)
                            {
                                labels[y, x] = labelNumber;
                                labelNumber++;
                            }
                            dataPtr += nChan;
                        }
                        dataPtr += padding;
                    }

                    for (y = 0; y < height; y++)
                    {
                        for (x = 0; x < width; x++)
                        {
                            if (x == 0 || y == 0)
                            {
                                x_aux = x == 0 ? 0 : x - 1;
                                y_aux = y == 0 ? 0 : y - 1;

                                if (labels[y_aux, x_aux] < labels[y, x] && labels[y_aux, x_aux] != 0)
                                {
                                    labels[y, x] = labels[y_aux, x_aux];
                                }

                                if (y != 0 && x < width-1 && labels[y_aux, x + 1] < labels[y, x] && labels[y_aux, x + 1] != 0)
                                {
                                    labels[y, x] = labels[y_aux, x + 1];
                                }

                                if (labels[y_aux, x_aux] > labels[y, x] && x != 0 && labels[y, x] != 0 && !relations.ContainsKey(labels[y, x - 1]))
                                {
                                    relations.Add(labels[y_aux, x_aux],labels[y, x]);
                                }
                                
                                if (labels[y_aux, x_aux] > labels[y, x] && y != 0 && labels[y, x] != 0 && !relations.ContainsKey(labels[y - 1, x]))
                                {
                                    relations.Add(labels[y_aux, x_aux], labels[y, x]);
                                }

                                if (x < width - 1 && labels[y_aux, x + 1] > labels[y, x] && y != 0 && labels[y, x] != 0 && !relations.ContainsKey(labels[y - 1, x + 1]))
                                {
                                    relations.Add(labels[y_aux, x + 1], labels[y, x]);
                                }
                            }
                            else
                            {
                                if (labels[y - 1, x] < labels[y, x] && labels[y - 1, x] != 0)
                                {
                                    labels[y, x] = labels[y - 1, x];
                                }

                                if (labels[y, x - 1] < labels[y, x] && labels[y, x - 1] != 0)
                                {
                                    labels[y, x] = labels[y, x - 1];
                                }

                                if (labels[y - 1, x - 1] < labels[y, x] && labels[y - 1, x - 1] != 0)
                                {
                                    labels[y, x] = labels[y - 1, x - 1];
                                }

                                if (x < width -1 && labels[y - 1, x + 1] < labels[y, x] && labels[y - 1, x + 1] != 0)
                                {
                                    labels[y, x] = labels[y - 1, x + 1];
                                }

                                if (labels[y, x - 1] > labels[y, x] && labels[y, x] != 0 && !relations.ContainsKey(labels[y, x - 1]))
                                {
                                    relations.Add(labels[y, x - 1], labels[y, x]);
                                }

                                if (labels[y - 1, x] > labels[y, x] && labels[y, x] != 0 && !relations.ContainsKey(labels[y - 1, x]))
                                {
                                    relations.Add(labels[y - 1, x], labels[y, x]);
                                }

                                if (x < width-1 && labels[y - 1, x + 1] > labels[y, x] && labels[y, x] != 0 && !relations.ContainsKey(labels[y - 1, x + 1]))
                                {
                                    relations.Add(labels[y - 1, x + 1], labels[y, x]);
                                }

                                if (labels[y - 1, x - 1] > labels[y, x] && labels[y, x] != 0 && !relations.ContainsKey(labels[y - 1, x - 1]))
                                {
                                    relations.Add(labels[y - 1, x - 1], labels[y, x]);
                                }
                            }
                        }
                    }

                    for (y = 0; y < height; y++)
                    {
                        for (x = 0; x < width; x++)
                        {
                            if (relations.ContainsKey(labels[y, x]))
                            {
                                val_aux = labels[y, x];
                                do
                                {
                                    val_aux = relations[val_aux];
                                }
                                while (relations.ContainsKey(val_aux));
                                labels[y, x] = val_aux;
                            }
                        }
                    }
                }
                return labels;
            }
        }

        public static int[] calcGradient(Image<Bgr, byte> img)
        {
            unsafe
            {
                MIplImage m = img.MIplImage;
                byte* dataPtr = (byte*)m.imageData.ToPointer();
                byte* dataPtrInitX, dataPtrEndX, dataPtrInitY, dataPtrEndY;
                int nChan = m.nChannels; // number of channels - 3
                int padding = m.widthStep - m.nChannels * m.width; // alinhament bytes (padding)
                int widthStep = m.widthStep;
                int x, y;
                int x_init=0, x_end=0, y_init = 0, y_end = 0;
                int width = img.Width;
                int height = img.Height;
                int [] step = new int[width];
                int[] values = new int[2];
                int init, end, angle, difX, difY;
                int maximo = 0, maximo2 = 0, maximo3=0;
                init = (int)Math.Round(Math.Atan2(1, -255) * (180 / Math.PI));
                end = (int)Math.Round(Math.Atan2(1, 255) * (180 / Math.PI));

                if (nChan == 3) // image in RGB
                {
                    for (y = 0; y < height; y++)
                    {
                        for (x = 0; x < width; x++)
                        {
                            x_init = x - 1 < 0 ? x : x - 1;
                            x_end = x + 1 > width - 1 ? x : x + 1;
                            y_init = y - 1 < 0 ? y : y - 1;
                            x_end = y + 1 > height - 1 ? y : y + 1;
                            dataPtrInitX = (nChan * x_init) + (y * widthStep) + dataPtr;
                            dataPtrEndX = (nChan * x_end) + (y * widthStep) + dataPtr;
                            dataPtrInitY = (nChan * x) + (y_init * widthStep) + dataPtr;
                            dataPtrEndY = (nChan * x) + (y_end * widthStep) + dataPtr;
                            difX = dataPtrEndX[0]-dataPtrInitX[0] == 0 ? 1 : dataPtrEndX[0]-dataPtrInitX[0];
                            difY = dataPtrInitY[0]-dataPtrEndY[0] == 0 ? 1 : dataPtrInitY[0]-dataPtrEndY[0];
                            angle = (int)Math.Round(Math.Atan2(difY, difX) * (180 / Math.PI));
                            if(angle == init || angle == end){
                                step[x] += 1;
                            }
                        }
                    }
                }

                maximo = max(step);
                maximo3 = maximo;
                step[maximo] = 0;
                maximo2 = max(step);   
    
                values[0] = maximo;
                values[1] = maximo2;              
                return values;
            }            
        }

        public static Image<Bgr, byte> createColumnLevels(Image<Bgr, byte> img, double threshold, Image<Bgr, byte> imgAux, int weight, double factor)
        {
            unsafe
            {
                MIplImage m = img.MIplImage;
                byte* dataPtr = (byte*)m.imageData.ToPointer();
                byte* dataPtrAux;
                int nChan = m.nChannels; // number of channels - 3
                int padding = m.widthStep - m.nChannels * m.width; // alinhament bytes (padding)
                int widthStep = m.widthStep;
                int x, y;
                int width = img.Width;
                int height = img.Height;
                int[] columns = new int[width];
                var myHashMap = new Dictionary<int, int[]>();
                ArrayList ItemList = new ArrayList();
                System.Drawing.Rectangle rect = new System.Drawing.Rectangle();
                int[] cell = new int[2];
                int[] value;
                int max_val = 0;
                int left=0, right=0;
                int coord = 0, id = 0, init = 0;
                int average = 171;
                double val = 0.0;
                

                if (nChan == 3) // image in RGB
                {
                    for (x = 0; x < width; x++)
                    {
                        dataPtrAux = dataPtr;
                        for (y = 0; y < height; y++)
                        {
                            if (dataPtr[0] == 255)
                            {
                                columns[x]++;
                            }
                            dataPtr += widthStep;
                        }
                        dataPtr = dataPtrAux;
                        dataPtr += nChan;
                    }

                    max_val = max(columns);

                    for (x = 0; x < width - 1; x++)
                    {
                        if (((double)columns[x + 1] / columns[x]) <= threshold || ((double)columns[x] / columns[x + 1]) <= threshold)
                        {
                            cell[0] = coord;
                            cell[1] = x;
                            myHashMap.Add(id, (int[])cell.Clone());
                            coord = x;
                            id++;
                        }
                    }
                    cell[0] = coord;
                    cell[1] = x;
                    myHashMap.Add(id, (int[])cell.Clone());

                    for (int i = 0; i <= id; i++)
                    {
                        value = myHashMap[i];
                        if (value[1] - value[0] <= 2)
                        {
                            myHashMap.Remove(i);
                        }
                        else if (init != value[0])
                        {
                            value[0] = init;
                            init = value[1];
                            ItemList.Add(value[1]);
                        }
                        else
                        {
                            init = value[1];
                            ItemList.Add(value[1]);
                        }
                    }
                    ItemList.RemoveAt(ItemList.Count - 1);

                    myHashMap = new Dictionary<int, int[]>();
                    id = 0;
                    init = (int)ItemList[0];
                    for (int i = 0; i < ItemList.Count-1; i++)
                    {
                        if ((int)ItemList[i + 1] - (int)ItemList[i] > weight)
                        {
                            cell[0] = init;
                            cell[1] = (int)ItemList[i];
                            myHashMap.Add(id, (int[])cell.Clone());
                            id++;
                            if (i != ItemList.Count - 1)
                            {
                                init = (int)ItemList[i + 1];
                            }
                        }
                    }
                    cell[0] = init;
                    cell[1] = (int)ItemList[ItemList.Count - 1];
                    myHashMap.Add(id, (int[])cell.Clone());

                    max_val = 0;
                    for (int i = 0; i < myHashMap.Count; i++)
                    {
                        if (myHashMap[i][1] - myHashMap[i][0] > myHashMap[max_val][1] - myHashMap[max_val][0])
                        {
                            max_val = i;
                        }
                    }

                    /*ItemList = new ArrayList();
                    value = calcGradient(img);
                    ItemList.Add(value[0]);
                    ItemList.Add(value[1]);*/
                    /*init = -1;
                    final = 0;
                    do
                    {
                        init++;
                        final = init + 1;
                        while ((int)ItemList[final] - (int)ItemList[init] < 182)
                        {
                            final++;
                        }
                    }
                    while ((int)ItemList[final] - (int)ItemList[init] > 185);

                    init = (int)ItemList[init];
                    final = (int)ItemList[final];*/
                    ItemList = new ArrayList();
                    ItemList.Add(myHashMap[max_val][0]);
                    ItemList.Add(myHashMap[max_val][1]);
                    if ((int)ItemList[1] - (int)ItemList[0] > average)
                    {
                        val = ((double)(-average * factor) / 2);
                    }
                    else
                    {
                        val = ((double)(average * factor) / 2);
                    }
                    left = (int)((int)ItemList[0] - val);
                    right = (int)((int)ItemList[1] + val);
                    rect = new System.Drawing.Rectangle(left, 0, right - left, imgAux.Height);
                }
                return imgAux.Copy(rect);                   
            }            
        }

        public static Image<Bgr, byte> findColumns(Image<Bgr, byte> img, Image<Bgr, byte> imgAux)
        {
            unsafe
            {
                MIplImage m = img.MIplImage;
                byte* dataPtr = (byte*)m.imageData.ToPointer();
                byte* dataPtrAux;
                int nChan = m.nChannels; // number of channels - 3
                int widthStep = m.widthStep;
                int padding = m.widthStep - m.nChannels * m.width; // alinhament bytes (padding)
                int x, y;
                int width = img.Width;
                int height = img.Height;
                int[] vertical = new int[img.Width];
                int[] blankColumns = new int[img.Width];
                ArrayList arr = new ArrayList();
                int interval = 14;
                int[] neighbours = new int[interval];
                System.Drawing.Rectangle rect = new System.Drawing.Rectangle();
                int index = 0, best = 0;
                int left = 0, right = 0;
                int left_cond = 0, right_cond = 0;

                // convert to gray

                if (nChan == 3) // image in RGB
                {
                    for (x = 0; x < width; x++)
                    {
                        dataPtrAux = dataPtr;
                        for (y = 0; y < height; y++)
                        {
                            if ((y < height - 1) && (dataPtr[0] != (dataPtr + widthStep)[0]))
                            {
                                vertical[x]++;
                            }
                            if(dataPtr[0]==255){
                                blankColumns[x]++;
                            }
                            dataPtr += widthStep;
                        }
                        dataPtr = dataPtrAux;
                        dataPtr += nChan;
                    }

                    for (int i = 0; i < interval; i++)
                    {
                        index = max(vertical);
                        arr.Add(index);
                        vertical[index] = 0;
                    }

                    for (int i = 0; i < interval; i++)
                    {
                        for (int j = 0; j < 7; j++)
                        {
                            if (arr.Contains((int)arr[i] - j))
                            {
                                neighbours[i]++;
                            }
                            if (arr.Contains((int)arr[i] + j))
                            {
                                neighbours[i]++;
                            }
                        }
                    }

                    index = max(neighbours);
                    best = (int)arr[index];
                    left = best;
                    right = best;
                    for (int i = best; i < width; i++)
                    {
                        right_cond = 0;
                        for (int j = 1; j < 15; j++)
                        {
                            right_cond += blankColumns[i + j];
                        }

                        if (right_cond == 14 * height)
                        {
                            right = i;
                            break;
                        }
                    }

                    for (int i = best; i > -1; i--)
                    {
                        left_cond = 0;
                        for (int j = 1; j < 15; j++)
                        {
                            left_cond += blankColumns[i - j];
                        }

                        if (left_cond == 14 * height)
                        {
                            left = i;
                            break;
                        }
                    }
                    rect = new System.Drawing.Rectangle(left, 0, right - left, imgAux.Height);
                }
                return imgAux.Copy(rect);
            }
        }

        public static void drawColumns(Image<Bgr, byte> img, ArrayList columnLevels)
        {
            unsafe
            {
                MIplImage m = img.MIplImage;
                byte* dataPtr = (byte*)m.imageData.ToPointer();
                byte* dataPtrAux;
                int nChan = m.nChannels; // number of channels - 3
                int widthStep = m.widthStep;
                int padding = m.widthStep - m.nChannels * m.width; // alinhament bytes (padding)
                int x, y;
                int width = img.Width;
                int height = img.Height;

                // convert to gray

                if (nChan == 3) // image in RGB
                {
                    for (x = 0; x < width; x++)
                    {
                        dataPtrAux = dataPtr;
                        for (y = 0; y < height; y++)
                        {
                            if (columnLevels.Contains(x))
                            {
                                dataPtr[0] = 0;
                                dataPtr[1] = 255;
                                dataPtr[2] = 0;
                            }
                            dataPtr += widthStep;
                        }
                        dataPtr = dataPtrAux;
                        dataPtr += nChan;
                    }
                }
            }
        } 

        public static void ConvertToLuminance(Image<Bgr, byte> img)
        {
            unsafe
            {
                MIplImage m = img.MIplImage;
                byte* dataPtr = (byte*)m.imageData.ToPointer();
                int nChan = m.nChannels; // number of channels - 3
                int widthStep = m.widthStep;
                int padding = m.widthStep - m.nChannels * m.width; // alinhament bytes (padding)
                int x, y;
                int width = img.Width;
                int height = img.Height;
                int blue,red,green;

                // convert to gray

                if (nChan == 3) // image in RGB
                {
                    for (y = 0; y < height; y++)
                    {
                        for (x = 0; x < width; x++)
                        {
                            blue = (int)(0.114*dataPtr[0]);
                            green = (int)(0.587 * dataPtr[1]);
                            red = (int)(0.299 * dataPtr[2]);
                            dataPtr[0] = (byte)blue;
                            dataPtr[1] = (byte)green;
                            dataPtr[2] = (byte)red;
                            dataPtr += nChan;
                        }
                        dataPtr += padding;
                    }
                }
            }
        }
    }
}
