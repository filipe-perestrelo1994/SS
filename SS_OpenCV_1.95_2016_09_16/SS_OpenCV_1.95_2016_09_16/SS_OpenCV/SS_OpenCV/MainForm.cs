using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Collections;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.UI;
using Emgu.CV.Structure;

namespace SS_OpenCV
{
    public partial class MainForm : Form
    {
        Image<Bgr, Byte> img = null; // working image
        Image<Bgr, Byte> imgUndo = null; // undo backup image - UNDO
        string title_bak = "";
        int mouseX, mouseY;
        bool mouseFlag = false;

        public MainForm()
        {
            InitializeComponent();
            title_bak = Text;
        }

        /// <summary>
        /// Opens a new image
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                img = new Image<Bgr, byte>(openFileDialog1.FileName);
                Text = title_bak + " [" +
                        openFileDialog1.FileName.Substring(openFileDialog1.FileName.LastIndexOf("\\") + 1) +
                        "]";
                imgUndo = img.Copy();
                ImageViewer.Image = img.Bitmap;
                ImageViewer.Refresh();
            }
        }

        /// <summary>
        /// Saves an image with a new name
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                ImageViewer.Image.Save(saveFileDialog1.FileName);
            }
        }

        /// <summary>
        /// Closes the application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// restore last undo copy of the working image
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (imgUndo == null) // verify if the image is already opened
                return; 
            Cursor = Cursors.WaitCursor;
            img = imgUndo.Copy();

            ImageViewer.Image = img.Bitmap;
            ImageViewer.Refresh(); // refresh image on the screen

            Cursor = Cursors.Default; // normal cursor 
        }

        /// <summary>
        /// Chaneg visualization mode
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void autoZoomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // zoom
            if (autoZoomToolStripMenuItem.Checked)
            {
                ImageViewer.SizeMode = PictureBoxSizeMode.Zoom;
                ImageViewer.Dock = DockStyle.Fill;
            }
            else // with scroll bars
            {
                ImageViewer.Dock = DockStyle.None;
                ImageViewer.SizeMode = PictureBoxSizeMode.AutoSize;
            }
        }

        /// <summary>
        /// Show authors form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void autoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AuthorsForm form = new AuthorsForm();
            form.ShowDialog();
        }


        /// <summary>
        /// Convert the working image to grayscale
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void grayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (img == null) // verify if the image is already opened
                return;
            Cursor = Cursors.WaitCursor; // clock cursor 

            //copy Undo Image
            //imgUndo = img.Copy();

            ImageClass.ConvertToGray(img);

            ImageViewer.Image = img.Bitmap;
            ImageViewer.Refresh(); // refresh image on the screen

            Cursor = Cursors.Default; // normal cursor 
        }

        /// <summary>
        /// Calculate the image negative
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void negativeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (img == null) // verify if the image is already opened
                return;
            Cursor = Cursors.WaitCursor; // clock cursor 

            //copy Undo Image
            //imgUndo = img.Copy();
            DateTime p_incial = DateTime.Now;
            ImageClass.Negative(img);
            TimeSpan time = DateTime.Now - p_incial;
            MessageBox.Show(time.ToString());
            ImageViewer.Image = img.Bitmap;
            ImageViewer.Refresh(); // refresh image on the screen

            Cursor = Cursors.Default; // normal cursor 
        }

        private void onlyRedGrayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (img == null) // verify if the image is already opened
                return;
            Cursor = Cursors.WaitCursor; // clock cursor 

            //copy Undo Image
            //imgUndo = img.Copy();

            ImageClass.OnlyGray(img,2);

            ImageViewer.Image = img.Bitmap;
            ImageViewer.Refresh(); // refresh image on the screen

            Cursor = Cursors.Default; // normal cursor 
        }

        private void greenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (img == null) // verify if the image is already opened
                return;
            Cursor = Cursors.WaitCursor; // clock cursor 

            //copy Undo Image
            //imgUndo = img.Copy();

            ImageClass.OnlyGray(img, 1);

            ImageViewer.Image = img.Bitmap;
            ImageViewer.Refresh(); // refresh image on the screen

            Cursor = Cursors.Default; // normal cursor
        }

        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (img == null) // verify if the image is already opened
                return;
            Cursor = Cursors.WaitCursor; // clock cursor 

            //copy Undo Image
            //imgUndo = img.Copy();

            ImageClass.OnlyGray(img, 0);

            ImageViewer.Image = img.Bitmap;
            ImageViewer.Refresh(); // refresh image on the screen

            Cursor = Cursors.Default; // normal cursor
        }

        private void brightnessAndContrastToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (img == null) // verify if the image is already opened
                return;

            Cursor = Cursors.WaitCursor; // clock cursor 
            InputBox form_bright = new InputBox("Insira o brilho"); 
            form_bright.ShowDialog();
            InputBox form_bright_2 = new InputBox("Insira o contraste");
            form_bright_2.ShowDialog();

            int brilho = Convert.ToInt32(form_bright.ValueTextBox.Text);
            int contraste = Convert.ToInt32(form_bright_2.ValueTextBox.Text);

            Console.Write("Brilho: {0} Contraste: {1}", brilho, contraste);
            if (brilho > 255 || brilho < 0 || contraste > 3 || contraste < 0)
            {
                MessageBox.Show("Valor incorrecto para o brilho ou contraste");
                return;
            }
            ImageClass.brightAndcont(img, brilho, contraste);

            ImageViewer.Image = img.Bitmap;
            ImageViewer.Refresh(); // refresh image on the screen

            Cursor = Cursors.Default; // normal cursor
        }

        private void translationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (img == null) // verify if the image is already opened
                return;

            Cursor = Cursors.WaitCursor; // clock cursor 
            InputBox form_bright = new InputBox("Insira o deslocamento em x");
            form_bright.ShowDialog();
            InputBox form_bright_2 = new InputBox("Insira o deslocamento em y");
            form_bright_2.ShowDialog();

            int dX = Convert.ToInt32(form_bright.ValueTextBox.Text);
            int dY = Convert.ToInt32(form_bright_2.ValueTextBox.Text);

            ImageClass.moveImage(img, img.Copy(), dX, dY);

            ImageViewer.Image = img.Bitmap;
            ImageViewer.Refresh(); // refresh image on the screen

            Cursor = Cursors.Default; // normal cursor
        }

        private double degreeToRadian(double angle)
        {
            return Math.PI * angle / 180.0;
        }

        private void rotationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (img == null) // verify if the image is already opened
                return;

            Cursor = Cursors.WaitCursor; // clock cursor 
            InputBox form_bright = new InputBox("Insira o ângulo");
            form_bright.ShowDialog();

            double angle = Convert.ToDouble(form_bright.ValueTextBox.Text);


            ImageClass.rotateImage(img, img.Copy(), degreeToRadian(angle));

            ImageViewer.Image = img.Bitmap;
            ImageViewer.Refresh(); // refresh image on the screen

            Cursor = Cursors.Default; // normal cursor
        }

        private void zoomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InputBox form_bright = new InputBox("Insira o zoom");
            form_bright.ShowDialog();

            int difX = ImageViewer.Size.Width/2 - img.Width/2;
            int difY = ImageViewer.Size.Height - img.Height;
            int x, y;
            Console.Write("Esta aqui\n");
            float zoom = (float)Convert.ToDouble(form_bright.ValueTextBox.Text);
            Console.Write("Zoom: {0}\n", zoom);

            mouseFlag = true;
            while (mouseFlag)
                Application.DoEvents();

            x = mouseX;
            y = mouseY;
            if (autoZoomToolStripMenuItem.Checked) 
            {
                x = mouseX - difX;
                y = mouseY - difY;
            }            

            if (img == null) // verify if the image is already opened
                return;

            Cursor = Cursors.WaitCursor; // clock cursor 
            
            /*InputBox form_bright_2 = new InputBox("Insira a coordenada x");
            form_bright_2.ShowDialog();
            InputBox form_bright_3 = new InputBox("Insira a coordenada y");
            form_bright_3.ShowDialog();*/
            
            /*int x = Convert.ToInt32(form_bright_2.ValueTextBox.Text);
            int y = Convert.ToInt32(form_bright_3.ValueTextBox.Text);*/

            ImageClass.zoomImage(img, img.Copy(), zoom, x, y);

            ImageViewer.Image = img.Bitmap;
            ImageViewer.Refresh(); // refresh image on the screen

            Cursor = Cursors.Default; // normal cursor
        }

        private void ImageViewer_MouseClick(object sender, MouseEventArgs e)
        {
            if (mouseFlag)
            {
                mouseX = e.X;
                mouseY = e.Y;

                mouseFlag = false;
            }

        }

        private void methodAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (img == null) // verify if the image is already opened
                return;

            Cursor = Cursors.WaitCursor;

            InputBox form_bright = new InputBox("Insira a dimensão do filtro");
            form_bright.ShowDialog();

            int dim = Convert.ToInt32(form_bright.ValueTextBox.Text);

            if (dim % 2 != 0)
            {
                ImageClass.averageFilter(img, img.Copy(), dim);
            }
            else
            {
                MessageBox.Show("Inseriu um valor par para a dimensão do filtro");
            }
            ImageViewer.Image = img.Bitmap;
            ImageViewer.Refresh(); // refresh image on the screen

            Cursor = Cursors.Default; // normal cursor
        }

        private void nonLinearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (img == null) // verify if the image is already opened
                return;

            Cursor = Cursors.WaitCursor;

            FilterBox filter = new FilterBox();
            filter.ShowDialog();
            string coef= "";

            if (filter.filter_3)
            {
                coef = filter.text13x3.Text + "," + filter.text23x3.Text + "," + filter.text33x3.Text + "," + filter.text43x3.Text + "," + filter.text53x3.Text
                    + "," + filter.text63x3.Text + "," + filter.text73x3.Text + "," + filter.text83x3.Text + "," + filter.text93x3.Text;
                ImageClass.nonLinearFilter(img, img.Copy(), 3, Convert.ToInt32(filter.textWeight.Text), coef);
            }
            else
            {
                coef = filter.text15x5.Text + "," + filter.text25x5.Text + "," + filter.text35x5.Text + "," + filter.text45x5.Text + "," + filter.text55x5.Text
                    + "," + filter.text65x5.Text + "," + filter.text75x5.Text + "," + filter.text85x5.Text + "," + filter.text95x5.Text + "," + filter.text105x5.Text
                    + "," + filter.text115x5.Text + "," + filter.text125x5.Text + "," + filter.text135x5.Text + "," + filter.text145x5.Text + "," + filter.text155x5.Text
                    + "," + filter.text165x5.Text + "," + filter.text175x5.Text + "," + filter.text185x5.Text + "," + filter.text195x5.Text + "," + filter.text205x5.Text
                    + "," + filter.text215x5.Text + "," + filter.text225x5.Text + "," + filter.text235x5.Text + "," + filter.text245x5.Text + "," + filter.text255x5.Text;
                ImageClass.nonLinearFilter(img, img.Copy(), 5, Convert.ToInt32(filter.textWeight.Text), coef);
            }

            ImageViewer.Image = img.Bitmap;
            ImageViewer.Refresh(); // refresh image on the screen
            
            Cursor = Cursors.Default; // normal cursor
        }

        private void methodBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (img == null) // verify if the image is already opened
                return;

            Cursor = Cursors.WaitCursor;

            InputBox form_bright = new InputBox("Insira a dimensão do filtro");
            form_bright.ShowDialog();

            int dim = Convert.ToInt32(form_bright.ValueTextBox.Text);

            if (dim % 2 != 0)
            {
                ImageClass.averageFilterB(img, img.Copy(), dim);
            }
            else
            {
                MessageBox.Show("Inseriu um valor par para a dimensão do filtro");
            }
            ImageViewer.Image = img.Bitmap;
            ImageViewer.Refresh(); // refresh image on the screen

            Cursor = Cursors.Default; // normal cursor
        }
        
        private void sobelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (img == null) // verify if the image is already opened
                return;

            Cursor = Cursors.WaitCursor;

            InputBox form_bright = new InputBox("Insira a dimensão do filtro");
            form_bright.ShowDialog();

            int dim = Convert.ToInt32(form_bright.ValueTextBox.Text);

            if (dim == 5 || dim == 3)
            {
                if (dim == 3)
                {
                    ImageClass.sobelFilter(img, img.Copy(), dim, "1,0,-1,2,0,-2,1,0,-1", "-1,-2,-1,0,0,0,1,2,1");
                }
                else
                {
                    ImageClass.sobelFilter(img, img.Copy(), dim, "1,2,0,-2,-1,4,8,0,-8,-4,6,12,0,-12,-6,4,8,0,-8,-4,1,2,0,-2,-1", "-1,-4,-6,-4,-1,-2,-8,-12,-8,-2,0,0,0,0,0,2,8,12,8,2,1,4,6,4,1");
                }
            }
            else
            {
                MessageBox.Show("Inseriu um valor incorrecto para a dimensão do filtro");
            }
            ImageViewer.Image = img.Bitmap;
            ImageViewer.Refresh(); // refresh image on the screen

            Cursor = Cursors.Default; // normal cursor
        }

        private void differentialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (img == null) // verify if the image is already opened
                return;

            Cursor = Cursors.WaitCursor;
            ImageClass.diffFilter(img);

            ImageViewer.Image = img.Bitmap;
            ImageViewer.Refresh(); // refresh image on the screen

            Cursor = Cursors.Default; // normal cursor
        }

        private void methodCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (img == null) // verify if the image is already opened
                return;

            Cursor = Cursors.WaitCursor;

            InputBox form_bright = new InputBox("Insira a dimensão do filtro");
            form_bright.ShowDialog();

            int dim = Convert.ToInt32(form_bright.ValueTextBox.Text);

            if (dim % 2 != 0)
            {
                ImageClass.averageFilterC(img, img.Copy(), dim);
            }
            else
            {
                MessageBox.Show("Inseriu um valor par para a dimensão do filtro");
            }
            ImageViewer.Image = img.Bitmap;
            ImageViewer.Refresh(); // refresh image on the screen

            Cursor = Cursors.Default; // normal cursor
        }

        private void robertsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (img == null) // verify if the image is already opened
                return;

            Cursor = Cursors.WaitCursor;
            ImageClass.robertsFilter(img);

            ImageViewer.Image = img.Bitmap;
            ImageViewer.Refresh(); // refresh image on the screen

            Cursor = Cursors.Default; // normal cursor
        }

        private void normalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (img == null) // verify if the image is already opened
                return;

            Cursor = Cursors.WaitCursor;

            InputBox form_bright = new InputBox("Insira a dimensão do filtro");
            form_bright.ShowDialog();

            int dim = Convert.ToInt32(form_bright.ValueTextBox.Text);
            DateTime p_incial = DateTime.Now;
            if (dim % 2 != 0)
            {
                ImageClass.medianFilter(img, img.Copy(), dim);
            }
            else
            {
                MessageBox.Show("Inseriu um valor par para a dimensão do filtro");
            }
            TimeSpan time = DateTime.Now - p_incial;
            MessageBox.Show(time.ToString());
            ImageViewer.Image = img.Bitmap;
            ImageViewer.Refresh(); // refresh image on the screen

            Cursor = Cursors.Default; // normal cursor
        }

        private void otsuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (img == null) // verify if the image is already opened
                return;

            Cursor = Cursors.WaitCursor;
            int [,] histogram = ImageClass.createHistogram(img);
            HistogramForm his = new HistogramForm(histogram);
            his.Show();
            ImageClass.calcOtsu(img, histogram);

            ImageViewer.Image = img.Bitmap;
            ImageViewer.Refresh(); // refresh image on the screen

            Cursor = Cursors.Default; // normal cursor
        }

        private void manualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (img == null) // verify if the image is already opened
                return;

            Cursor = Cursors.WaitCursor;
            int[,] histogram = ImageClass.createHistogram(img);
            HistogramForm his = new HistogramForm(histogram);
            his.Show();

            InputBox form_bright = new InputBox("Insira o valor de threshold");
            form_bright.ShowDialog();

            int threshold = Convert.ToInt32(form_bright.ValueTextBox.Text);

            if (threshold < 0 || threshold > 255)
            {
                MessageBox.Show("Valor de threshold incorrecto!!");
                return;
            }

            ImageClass.calcManual(img,threshold);

            ImageViewer.Image = img.Bitmap;
            ImageViewer.Refresh(); // refresh image on the screen

            Cursor = Cursors.Default; // normal cursor
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void detectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
         
        }

        private void rowDetectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (img == null) // verify if the image is already opened
                return;

            Cursor = Cursors.WaitCursor;
            ArrayList columnLevels = new ArrayList();

            Image<Bgr, Byte> imgAux = imgUndo.Copy();
            img = ImageClass.createRowLevels(img,imgAux);

            Image<Bgr, Byte>  imgAux1 = img.Copy(), imgCond;

            /*ImageClass.brightAndcont(img, 123, 3);
            ImageClass.nonLinearFilter(img, img.Copy(), 3, 16, "1,2,1,2,4,2,1,2,1");
            ImageClass.medianFilter(img, img.Copy(), 3);
            int[,] histogram = ImageClass.createHistogram(img);
            ImageClass.calcOtsu(img, histogram);*/

            /*int[,] histogram = ImageClass.createHistogram(img);
            ImageClass.calcOtsu(img, histogram);
            ImageClass.medianFilter(img, img.Copy(), 3);
            ImageClass.nonLinearFilter(img, img.Copy(), 3, 16, "1,2,1,2,4,2,1,2,1");
            histogram = ImageClass.createHistogram(img);
            ImageClass.calcOtsu(img, histogram);
            ImageClass.sobelFilter(img, img.Copy(), 3, "1,0,-1,2,0,-2,1,0,-1", "-1,-2,-1,0,0,0,1,2,1");*/
            //ImageClass.OnlyGray(img, 2);
            
            /*Image<Gray, Byte> gray = img.Convert<Gray, Byte>().PyrDown().PyrUp();

            Gray cannyThreshold = new Gray(149);
            Gray cannyThresholdLinking = new Gray(149);
            Gray circleAccumulatorThreshold = new Gray(120);

            Image<Gray, Byte> cannyEdges = gray.Canny(cannyThreshold, cannyThresholdLinking);
            LineSegment2D[] lines = cannyEdges.HoughLinesBinary(
                0.01, //Distance resolution in pixel-related units
                Math.PI / 45.0, //Angle resolution measured in radians.
                20, //threshold
                0, //min Line width
                400//gap between lines
                )[0]; //Get the lines from the first channel

            List<MCvBox2D> boxList = new List<MCvBox2D>();

            using (MemStorage storage = new MemStorage()) //allocate storage for contour approximation
                for (Contour<Point> contours = cannyEdges.FindContours(); contours != null; contours = contours.HNext)
                {
                    Contour<Point> currentContour = contours.ApproxPoly(contours.Perimeter * 0.05, storage);

                    if (contours.Area > 250) //only consider contours with area greater than 250
                    {
                        if (currentContour.Total == 4) //The contour has 4 vertices.
                        {
                            bool isRectangle = true;
                            Point[] pts = currentContour.ToArray();
                            LineSegment2D[] edges = PointCollection.PolyLine(pts, true);

                            for (int i = 0; i < edges.Length; i++)
                            {
                                double angle = Math.Abs(
                                   edges[(i + 1) % edges.Length].GetExteriorAngleDegree(edges[i]));
                                if (angle < 80 || angle > 100)
                                {
                                    isRectangle = false;
                                    break;
                                }
                            }

                            if (isRectangle) boxList.Add(currentContour.GetMinAreaRect());
                        }
                    }
                }

            Image<Bgr, Byte> triangleRectangleImage = img.CopyBlank();

            Image<Bgr, Byte> lineImage = img.CopyBlank();*/
            /*foreach (LineSegment2D line in lines)
                img.Draw(line, new Bgr(Color.Green), 2);*/

            /*foreach (MCvBox2D box in boxList)
                img.Draw(box, new Bgr(Color.Orange), 2);*/

            ImageClass.OnlyGray(img, 1);
            int[,] histogram = ImageClass.createHistogram(img);
            ImageClass.calcOtsu(img, histogram);
            ImageClass.medianFilter(img, img.Copy(), 3);
            ImageClass.nonLinearFilter(img, img.Copy(), 3, 1, "0,0,0,-1,2,-1,0,0,0");
            ImageClass.sobelFilter(img, img.Copy(), 3, "0,1,0,1,-4,1,0,1,0", "0,-1,0,-1,4,-1,0,-1,0");
            ImageClass.Negative(img);
            imgCond = img.Copy();
            bool done = false;
            int ratio = 0;
            while (!done)
            {
                img = ImageClass.findColumns(img, imgAux1);
                ratio = (int)Math.Round(((double)img.Width / img.Height));
                if (ratio > 6)
                {
                    imgAux1 = img.Copy();
                    ImageClass.OnlyGray(img, 1);
                    histogram = ImageClass.createHistogram(img);
                    ImageClass.calcOtsu(img, histogram);
                    ImageClass.medianFilter(img, img.Copy(), 3);
                    ImageClass.nonLinearFilter(img, img.Copy(), 3, 1, "0,0,0,-1,2,-1,0,0,0");
                    ImageClass.sobelFilter(img, img.Copy(), 3, "0,1,0,1,-4,1,0,1,0", "0,-1,0,-1,4,-1,0,-1,0");
                    ImageClass.Negative(img);
                    ImageClass.medianFilter(img, img.Copy(), 5);
                    ImageClass.medianFilter(img, img.Copy(), 5);
                }
                else
                {
                    done = true;
                }
            }

            imgAux = img.Copy();
            histogram = ImageClass.createHistogram(img);
            ImageClass.calcOtsu(img, histogram);
            int[,] labels = ImageClass.linkedLabels(img);
            Image<Bgr, byte>[] values = ImageClass.findText(img,labels,imgAux);
            ShowPlate sh1 = new ShowPlate();
            ShowPlate sh2 = new ShowPlate();
            ShowPlate sh3 = new ShowPlate();
            ShowPlate sh4 = new ShowPlate();
            ShowPlate sh5 = new ShowPlate();
            ShowPlate sh6 = new ShowPlate();
            sh1.ImageViewer.Image = values[0].Bitmap;
            sh1.ImageViewer.Refresh();
            sh1.Show();
            sh2.ImageViewer.Image = values[1].Bitmap;
            sh2.ImageViewer.Refresh();
            sh2.Show();
            sh3.ImageViewer.Image = values[2].Bitmap;
            sh3.ImageViewer.Refresh();
            sh3.Show();
            sh4.ImageViewer.Image = values[3].Bitmap;
            sh4.ImageViewer.Refresh();
            sh4.Show();
            sh5.ImageViewer.Image = values[4].Bitmap;
            sh5.ImageViewer.Refresh();
            sh5.Show();
            sh6.ImageViewer.Image = values[5].Bitmap;
            sh6.ImageViewer.Refresh();
            sh6.Show();
            //img = ImageClass.createColumnLevels(img, 0.9, imgAux1, 39, ((double)1 / 12));
            
            /*FilteredRows rows = new FilteredRows(rowLevels,"FiltredRows","Linha");
            rows.Show();*/

            //ImageClass.drawLines(img, rowLevels);


            ImageViewer.Image = img.Bitmap;
            ImageViewer.Refresh(); // refresh image on the screen

            Cursor = Cursors.Default; // normal cursor
        }

        private void luminanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void uToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void changeImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (img == null) // verify if the image is already opened
                return;

            Cursor = Cursors.WaitCursor;

            ImageClass.OnlyGray(img, 2);
            ImageClass.nonLinearFilter(img, img.Copy(), 3, 16, "1,2,1,2,4,2,1,2,1"); //Gaussiano
            int[,] histogram = ImageClass.createHistogram(img);
            ImageClass.calcOtsu(img, histogram);
            ImageClass.medianFilter(img, img.Copy(), 3);
            ImageClass.sobelFilter(img, img.Copy(), 3, "1,0,-1,2,0,-2,1,0,-1", "-1,-2,-1,0,0,0,1,2,1");
            ImageClass.Negative(img);
            //ImageClass.sobelFilter(img, img.Copy(), 3, "1,0,-1,2,0,-2,1,0,-1", "-1,-2,-1,0,0,0,1,2,1");            
            /*ImageClass.calcOtsu(img, histogram);
            ImageClass.medianFilter(img, img.Copy(), 3);
            ImageClass.nonLinearFilter(img, img.Copy(), 3, Convert.ToInt32(filter.textWeight.Text), coef);*///-1,2,-1
            

            ImageViewer.Image = img.Bitmap;
            ImageViewer.Refresh(); // refresh image on the screen

            Cursor = Cursors.Default; // normal cursor
        }

        private void luminanceToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            
        }

        private void luminnanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (img == null) // verify if the image is already opened
                return;

            Cursor = Cursors.WaitCursor;

            ImageClass.ConvertToLuminance(img);

            ImageViewer.Image = img.Bitmap;
            ImageViewer.Refresh(); // refresh image on the screen

            Cursor = Cursors.Default; // normal cursor
        }

        private void prewittToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void prewittToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (img == null) // verify if the image is already opened
                return;

            Cursor = Cursors.WaitCursor;

            ImageClass.sobelFilter(img, img.Copy(), 3, "1,0,-1,1,0,-1,1,0,-1", "-1,-1,-1,0,0,0,1,1,1");

            ImageViewer.Image = img.Bitmap;
            ImageViewer.Refresh(); // refresh image on the screen

            Cursor = Cursors.Default; // normal cursor
        }

        private void robinson4DirectionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (img == null) // verify if the image is already opened
                return;

            Cursor = Cursors.WaitCursor;

            ImageClass.sobelFilter(img, img.Copy(), 3, "2,1,0,1,0,-1,0,-1,-2", "0,1,2,-1,0,1,-2,-1,0");
            ImageClass.sobelFilter(img, img.Copy(), 3, "0,-1,-2,1,0,-1,2,1,0", "-2,-1,0,-1,0,1,0,1,2");

            ImageViewer.Image = img.Bitmap;
            ImageViewer.Refresh(); // refresh image on the screen

            Cursor = Cursors.Default; // normal cursor
        }

        private void krisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (img == null) // verify if the image is already opened
                return;

            Cursor = Cursors.WaitCursor;

            ImageClass.sobelFilter(img, img.Copy(), 3, "-3,-3,5,-3,0,5,-3,-3,5", "5,-3,-3,5,0,-3,5,-3,-3");
            ImageClass.sobelFilter(img, img.Copy(), 3, "-3,-3,-3,-3,0,-3,5,5,5", "5,5,5,-3,0,-3,-3,-3,-3");

            ImageViewer.Image = img.Bitmap;
            ImageViewer.Refresh(); // refresh image on the screen

            Cursor = Cursors.Default; // normal cursor
        }

        private void laplacianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (img == null) // verify if the image is already opened
                return;

            Cursor = Cursors.WaitCursor;

            ImageClass.sobelFilter(img, img.Copy(), 3, "0,1,0,1,-4,1,0,1,0", "0,-1,0,-1,4,-1,0,-1,0");

            ImageViewer.Image = img.Bitmap;
            ImageViewer.Refresh(); // refresh image on the screen

            Cursor = Cursors.Default; // normal cursor
        }

        private void bWToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void evalFormmrToolStripMenuItem_Click(object sender, EventArgs e)
        {
        
        }

        private void evalFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new SS_OpenCV.EvalForm().ShowDialog();
        }
    }
}