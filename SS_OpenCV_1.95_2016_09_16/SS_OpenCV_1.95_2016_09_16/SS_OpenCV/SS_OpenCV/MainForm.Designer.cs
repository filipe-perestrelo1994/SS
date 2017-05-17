namespace SS_OpenCV
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.convertToToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.negativeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.onlyRedGrayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.greenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.brightnessAndContrastToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transformsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.translationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rotationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filtersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.averageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.methodAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.methodBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.methodCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nonLinearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contourEnhancementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.differentialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.robertsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prewittToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.robinson4DirectionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.krisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.laplacianToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.medianToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.normalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autoZoomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.binarizationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otsuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rowDetectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.luminnanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ImageViewer = new System.Windows.Forms.PictureBox();
            this.evalFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImageViewer)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Images (*.png, *.bmp, *.jpg)|*.png;*.bmp;*.jpg";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.imageToolStripMenuItem,
            this.autoresToolStripMenuItem,
            this.detectionToolStripMenuItem,
            this.evalFormToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(685, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.openToolStripMenuItem.Text = "Open...";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.saveToolStripMenuItem.Text = "Save As...";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(120, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.undoToolStripMenuItem.Text = "Undo";
            this.undoToolStripMenuItem.Click += new System.EventHandler(this.undoToolStripMenuItem_Click);
            // 
            // imageToolStripMenuItem
            // 
            this.imageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.colorToolStripMenuItem,
            this.transformsToolStripMenuItem,
            this.filtersToolStripMenuItem,
            this.autoZoomToolStripMenuItem,
            this.binarizationToolStripMenuItem});
            this.imageToolStripMenuItem.Name = "imageToolStripMenuItem";
            this.imageToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.imageToolStripMenuItem.Text = "Image";
            // 
            // colorToolStripMenuItem
            // 
            this.colorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.convertToToolStripMenuItem,
            this.negativeToolStripMenuItem,
            this.onlyRedGrayToolStripMenuItem,
            this.brightnessAndContrastToolStripMenuItem});
            this.colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            this.colorToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.colorToolStripMenuItem.Text = "Color";
            // 
            // convertToToolStripMenuItem
            // 
            this.convertToToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.grayToolStripMenuItem});
            this.convertToToolStripMenuItem.Name = "convertToToolStripMenuItem";
            this.convertToToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.convertToToolStripMenuItem.Text = "Convert To";
            // 
            // grayToolStripMenuItem
            // 
            this.grayToolStripMenuItem.Name = "grayToolStripMenuItem";
            this.grayToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.grayToolStripMenuItem.Text = "Gray";
            this.grayToolStripMenuItem.Click += new System.EventHandler(this.grayToolStripMenuItem_Click);
            // 
            // negativeToolStripMenuItem
            // 
            this.negativeToolStripMenuItem.Name = "negativeToolStripMenuItem";
            this.negativeToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.negativeToolStripMenuItem.Text = "Negative";
            this.negativeToolStripMenuItem.Click += new System.EventHandler(this.negativeToolStripMenuItem_Click);
            // 
            // onlyRedGrayToolStripMenuItem
            // 
            this.onlyRedGrayToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.redToolStripMenuItem,
            this.greenToolStripMenuItem,
            this.blueToolStripMenuItem});
            this.onlyRedGrayToolStripMenuItem.Name = "onlyRedGrayToolStripMenuItem";
            this.onlyRedGrayToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.onlyRedGrayToolStripMenuItem.Text = "OnlyGray";
            this.onlyRedGrayToolStripMenuItem.Click += new System.EventHandler(this.onlyRedGrayToolStripMenuItem_Click);
            // 
            // redToolStripMenuItem
            // 
            this.redToolStripMenuItem.Name = "redToolStripMenuItem";
            this.redToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.redToolStripMenuItem.Text = "Red";
            this.redToolStripMenuItem.Click += new System.EventHandler(this.redToolStripMenuItem_Click);
            // 
            // greenToolStripMenuItem
            // 
            this.greenToolStripMenuItem.Name = "greenToolStripMenuItem";
            this.greenToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.greenToolStripMenuItem.Text = "Green";
            this.greenToolStripMenuItem.Click += new System.EventHandler(this.greenToolStripMenuItem_Click);
            // 
            // blueToolStripMenuItem
            // 
            this.blueToolStripMenuItem.Name = "blueToolStripMenuItem";
            this.blueToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.blueToolStripMenuItem.Text = "Blue";
            this.blueToolStripMenuItem.Click += new System.EventHandler(this.blueToolStripMenuItem_Click);
            // 
            // brightnessAndContrastToolStripMenuItem
            // 
            this.brightnessAndContrastToolStripMenuItem.Name = "brightnessAndContrastToolStripMenuItem";
            this.brightnessAndContrastToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.brightnessAndContrastToolStripMenuItem.Text = "Brightness and Contrast";
            this.brightnessAndContrastToolStripMenuItem.Click += new System.EventHandler(this.brightnessAndContrastToolStripMenuItem_Click);
            // 
            // transformsToolStripMenuItem
            // 
            this.transformsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.translationToolStripMenuItem,
            this.rotationToolStripMenuItem,
            this.zoomToolStripMenuItem});
            this.transformsToolStripMenuItem.Name = "transformsToolStripMenuItem";
            this.transformsToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.transformsToolStripMenuItem.Text = "Transforms";
            // 
            // translationToolStripMenuItem
            // 
            this.translationToolStripMenuItem.Name = "translationToolStripMenuItem";
            this.translationToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.translationToolStripMenuItem.Text = "Translation";
            this.translationToolStripMenuItem.Click += new System.EventHandler(this.translationToolStripMenuItem_Click);
            // 
            // rotationToolStripMenuItem
            // 
            this.rotationToolStripMenuItem.Name = "rotationToolStripMenuItem";
            this.rotationToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.rotationToolStripMenuItem.Text = "Rotation";
            this.rotationToolStripMenuItem.Click += new System.EventHandler(this.rotationToolStripMenuItem_Click);
            // 
            // zoomToolStripMenuItem
            // 
            this.zoomToolStripMenuItem.Name = "zoomToolStripMenuItem";
            this.zoomToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.zoomToolStripMenuItem.Text = "Zoom";
            this.zoomToolStripMenuItem.Click += new System.EventHandler(this.zoomToolStripMenuItem_Click);
            // 
            // filtersToolStripMenuItem
            // 
            this.filtersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.averageToolStripMenuItem,
            this.nonLinearToolStripMenuItem,
            this.contourEnhancementToolStripMenuItem,
            this.medianToolStripMenuItem});
            this.filtersToolStripMenuItem.Name = "filtersToolStripMenuItem";
            this.filtersToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.filtersToolStripMenuItem.Text = "Filters";
            // 
            // averageToolStripMenuItem
            // 
            this.averageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.methodAToolStripMenuItem,
            this.methodBToolStripMenuItem,
            this.methodCToolStripMenuItem});
            this.averageToolStripMenuItem.Name = "averageToolStripMenuItem";
            this.averageToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.averageToolStripMenuItem.Text = "Average";
            // 
            // methodAToolStripMenuItem
            // 
            this.methodAToolStripMenuItem.Name = "methodAToolStripMenuItem";
            this.methodAToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.methodAToolStripMenuItem.Text = "Method A";
            this.methodAToolStripMenuItem.Click += new System.EventHandler(this.methodAToolStripMenuItem_Click);
            // 
            // methodBToolStripMenuItem
            // 
            this.methodBToolStripMenuItem.Name = "methodBToolStripMenuItem";
            this.methodBToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.methodBToolStripMenuItem.Text = "Method B";
            this.methodBToolStripMenuItem.Click += new System.EventHandler(this.methodBToolStripMenuItem_Click);
            // 
            // methodCToolStripMenuItem
            // 
            this.methodCToolStripMenuItem.Name = "methodCToolStripMenuItem";
            this.methodCToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.methodCToolStripMenuItem.Text = "Method C";
            this.methodCToolStripMenuItem.Click += new System.EventHandler(this.methodCToolStripMenuItem_Click);
            // 
            // nonLinearToolStripMenuItem
            // 
            this.nonLinearToolStripMenuItem.Name = "nonLinearToolStripMenuItem";
            this.nonLinearToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.nonLinearToolStripMenuItem.Text = "Non linear";
            this.nonLinearToolStripMenuItem.Click += new System.EventHandler(this.nonLinearToolStripMenuItem_Click);
            // 
            // contourEnhancementToolStripMenuItem
            // 
            this.contourEnhancementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sobelToolStripMenuItem,
            this.differentialToolStripMenuItem,
            this.robertsToolStripMenuItem,
            this.prewittToolStripMenuItem,
            this.robinson4DirectionsToolStripMenuItem,
            this.krisToolStripMenuItem,
            this.laplacianToolStripMenuItem});
            this.contourEnhancementToolStripMenuItem.Name = "contourEnhancementToolStripMenuItem";
            this.contourEnhancementToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.contourEnhancementToolStripMenuItem.Text = "Contour Enhancement";
            // 
            // sobelToolStripMenuItem
            // 
            this.sobelToolStripMenuItem.Name = "sobelToolStripMenuItem";
            this.sobelToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.sobelToolStripMenuItem.Text = "Sobel";
            this.sobelToolStripMenuItem.Click += new System.EventHandler(this.sobelToolStripMenuItem_Click);
            // 
            // differentialToolStripMenuItem
            // 
            this.differentialToolStripMenuItem.Name = "differentialToolStripMenuItem";
            this.differentialToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.differentialToolStripMenuItem.Text = "Differentiation";
            this.differentialToolStripMenuItem.Click += new System.EventHandler(this.differentialToolStripMenuItem_Click);
            // 
            // robertsToolStripMenuItem
            // 
            this.robertsToolStripMenuItem.Name = "robertsToolStripMenuItem";
            this.robertsToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.robertsToolStripMenuItem.Text = "Roberts";
            this.robertsToolStripMenuItem.Click += new System.EventHandler(this.robertsToolStripMenuItem_Click);
            // 
            // prewittToolStripMenuItem
            // 
            this.prewittToolStripMenuItem.Name = "prewittToolStripMenuItem";
            this.prewittToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.prewittToolStripMenuItem.Text = "Prewitt";
            this.prewittToolStripMenuItem.Click += new System.EventHandler(this.prewittToolStripMenuItem_Click_1);
            // 
            // robinson4DirectionsToolStripMenuItem
            // 
            this.robinson4DirectionsToolStripMenuItem.Name = "robinson4DirectionsToolStripMenuItem";
            this.robinson4DirectionsToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.robinson4DirectionsToolStripMenuItem.Text = "Robinson(4 directions)";
            this.robinson4DirectionsToolStripMenuItem.Click += new System.EventHandler(this.robinson4DirectionsToolStripMenuItem_Click);
            // 
            // krisToolStripMenuItem
            // 
            this.krisToolStripMenuItem.Name = "krisToolStripMenuItem";
            this.krisToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.krisToolStripMenuItem.Text = "Krisch";
            this.krisToolStripMenuItem.Click += new System.EventHandler(this.krisToolStripMenuItem_Click);
            // 
            // laplacianToolStripMenuItem
            // 
            this.laplacianToolStripMenuItem.Name = "laplacianToolStripMenuItem";
            this.laplacianToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.laplacianToolStripMenuItem.Text = "Laplacian";
            this.laplacianToolStripMenuItem.Click += new System.EventHandler(this.laplacianToolStripMenuItem_Click);
            // 
            // medianToolStripMenuItem
            // 
            this.medianToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.normalToolStripMenuItem});
            this.medianToolStripMenuItem.Name = "medianToolStripMenuItem";
            this.medianToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.medianToolStripMenuItem.Text = "Median";
            // 
            // normalToolStripMenuItem
            // 
            this.normalToolStripMenuItem.Name = "normalToolStripMenuItem";
            this.normalToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.normalToolStripMenuItem.Text = "Normal";
            this.normalToolStripMenuItem.Click += new System.EventHandler(this.normalToolStripMenuItem_Click);
            // 
            // autoZoomToolStripMenuItem
            // 
            this.autoZoomToolStripMenuItem.CheckOnClick = true;
            this.autoZoomToolStripMenuItem.Name = "autoZoomToolStripMenuItem";
            this.autoZoomToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.autoZoomToolStripMenuItem.Text = "Auto Zoom";
            this.autoZoomToolStripMenuItem.Click += new System.EventHandler(this.autoZoomToolStripMenuItem_Click);
            // 
            // binarizationToolStripMenuItem
            // 
            this.binarizationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.otsuToolStripMenuItem,
            this.manualToolStripMenuItem});
            this.binarizationToolStripMenuItem.Name = "binarizationToolStripMenuItem";
            this.binarizationToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.binarizationToolStripMenuItem.Text = "Binarization";
            // 
            // otsuToolStripMenuItem
            // 
            this.otsuToolStripMenuItem.Name = "otsuToolStripMenuItem";
            this.otsuToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.otsuToolStripMenuItem.Text = "Otsu";
            this.otsuToolStripMenuItem.Click += new System.EventHandler(this.otsuToolStripMenuItem_Click);
            // 
            // manualToolStripMenuItem
            // 
            this.manualToolStripMenuItem.Name = "manualToolStripMenuItem";
            this.manualToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.manualToolStripMenuItem.Text = "Manual";
            this.manualToolStripMenuItem.Click += new System.EventHandler(this.manualToolStripMenuItem_Click);
            // 
            // autoresToolStripMenuItem
            // 
            this.autoresToolStripMenuItem.Name = "autoresToolStripMenuItem";
            this.autoresToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.autoresToolStripMenuItem.Text = "Autores...";
            this.autoresToolStripMenuItem.Click += new System.EventHandler(this.autoresToolStripMenuItem_Click);
            // 
            // detectionToolStripMenuItem
            // 
            this.detectionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rowDetectionToolStripMenuItem,
            this.changeImageToolStripMenuItem,
            this.luminnanceToolStripMenuItem});
            this.detectionToolStripMenuItem.Name = "detectionToolStripMenuItem";
            this.detectionToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.detectionToolStripMenuItem.Text = "Detection";
            this.detectionToolStripMenuItem.Click += new System.EventHandler(this.detectionToolStripMenuItem_Click);
            // 
            // rowDetectionToolStripMenuItem
            // 
            this.rowDetectionToolStripMenuItem.Name = "rowDetectionToolStripMenuItem";
            this.rowDetectionToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.rowDetectionToolStripMenuItem.Text = "Row Detection";
            this.rowDetectionToolStripMenuItem.Click += new System.EventHandler(this.rowDetectionToolStripMenuItem_Click);
            // 
            // changeImageToolStripMenuItem
            // 
            this.changeImageToolStripMenuItem.Name = "changeImageToolStripMenuItem";
            this.changeImageToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.changeImageToolStripMenuItem.Text = "Change Image";
            this.changeImageToolStripMenuItem.Click += new System.EventHandler(this.changeImageToolStripMenuItem_Click);
            // 
            // luminnanceToolStripMenuItem
            // 
            this.luminnanceToolStripMenuItem.Name = "luminnanceToolStripMenuItem";
            this.luminnanceToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.luminnanceToolStripMenuItem.Text = "Luminnance";
            this.luminnanceToolStripMenuItem.Click += new System.EventHandler(this.luminnanceToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.ImageViewer);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(685, 366);
            this.panel1.TabIndex = 6;
            // 
            // ImageViewer
            // 
            this.ImageViewer.Location = new System.Drawing.Point(0, 0);
            this.ImageViewer.Name = "ImageViewer";
            this.ImageViewer.Size = new System.Drawing.Size(576, 427);
            this.ImageViewer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ImageViewer.TabIndex = 6;
            this.ImageViewer.TabStop = false;
            this.ImageViewer.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ImageViewer_MouseClick);
            // 
            // evalFormToolStripMenuItem
            // 
            this.evalFormToolStripMenuItem.Name = "evalFormToolStripMenuItem";
            this.evalFormToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.evalFormToolStripMenuItem.Text = "EvalForm";
            this.evalFormToolStripMenuItem.Click += new System.EventHandler(this.evalFormToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 390);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Sistemas Sensoriais 2016/2017 - Image processing";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImageViewer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem convertToToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem negativeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transformsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem translationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rotationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filtersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autoZoomToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem onlyRedGrayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem greenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem brightnessAndContrastToolStripMenuItem;
        private System.Windows.Forms.PictureBox ImageViewer;
        private System.Windows.Forms.ToolStripMenuItem averageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem methodAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nonLinearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem methodBToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contourEnhancementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem differentialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem methodCToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem robertsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem medianToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem normalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem binarizationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem otsuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manualToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rowDetectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem luminnanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prewittToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem robinson4DirectionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem krisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem laplacianToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem evalFormToolStripMenuItem;
    }
}

