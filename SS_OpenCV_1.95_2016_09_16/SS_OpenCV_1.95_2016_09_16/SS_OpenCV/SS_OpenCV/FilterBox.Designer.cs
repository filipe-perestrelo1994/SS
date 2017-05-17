namespace SS_OpenCV
{
    partial class FilterBox
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.text215x5 = new System.Windows.Forms.TextBox();
            this.text15x5 = new System.Windows.Forms.TextBox();
            this.text165x5 = new System.Windows.Forms.TextBox();
            this.text65x5 = new System.Windows.Forms.TextBox();
            this.text115x5 = new System.Windows.Forms.TextBox();
            this.text255x5 = new System.Windows.Forms.TextBox();
            this.text55x5 = new System.Windows.Forms.TextBox();
            this.text205x5 = new System.Windows.Forms.TextBox();
            this.text105x5 = new System.Windows.Forms.TextBox();
            this.text155x5 = new System.Windows.Forms.TextBox();
            this.text225x5 = new System.Windows.Forms.TextBox();
            this.text235x5 = new System.Windows.Forms.TextBox();
            this.text245x5 = new System.Windows.Forms.TextBox();
            this.text25x5 = new System.Windows.Forms.TextBox();
            this.text35x5 = new System.Windows.Forms.TextBox();
            this.text45x5 = new System.Windows.Forms.TextBox();
            this.text75x5 = new System.Windows.Forms.TextBox();
            this.text85x5 = new System.Windows.Forms.TextBox();
            this.text195x5 = new System.Windows.Forms.TextBox();
            this.text95x5 = new System.Windows.Forms.TextBox();
            this.text185x5 = new System.Windows.Forms.TextBox();
            this.text125x5 = new System.Windows.Forms.TextBox();
            this.text175x5 = new System.Windows.Forms.TextBox();
            this.text135x5 = new System.Windows.Forms.TextBox();
            this.text145x5 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.text13x3 = new System.Windows.Forms.TextBox();
            this.text23x3 = new System.Windows.Forms.TextBox();
            this.text93x3 = new System.Windows.Forms.TextBox();
            this.text33x3 = new System.Windows.Forms.TextBox();
            this.text83x3 = new System.Windows.Forms.TextBox();
            this.text43x3 = new System.Windows.Forms.TextBox();
            this.text73x3 = new System.Windows.Forms.TextBox();
            this.text53x3 = new System.Windows.Forms.TextBox();
            this.text63x3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textWeight = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Mean 3x3",
            "Mean 5x5",
            "Gaussian",
            "Laplacian Hard",
            "Mean Remove"});
            this.comboBox1.Location = new System.Drawing.Point(15, 25);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Filter";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textWeight);
            this.groupBox1.Location = new System.Drawing.Point(15, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(275, 244);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Coeficients";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.text215x5);
            this.panel2.Controls.Add(this.text15x5);
            this.panel2.Controls.Add(this.text165x5);
            this.panel2.Controls.Add(this.text65x5);
            this.panel2.Controls.Add(this.text115x5);
            this.panel2.Controls.Add(this.text255x5);
            this.panel2.Controls.Add(this.text55x5);
            this.panel2.Controls.Add(this.text205x5);
            this.panel2.Controls.Add(this.text105x5);
            this.panel2.Controls.Add(this.text155x5);
            this.panel2.Controls.Add(this.text225x5);
            this.panel2.Controls.Add(this.text235x5);
            this.panel2.Controls.Add(this.text245x5);
            this.panel2.Controls.Add(this.text25x5);
            this.panel2.Controls.Add(this.text35x5);
            this.panel2.Controls.Add(this.text45x5);
            this.panel2.Controls.Add(this.text75x5);
            this.panel2.Controls.Add(this.text85x5);
            this.panel2.Controls.Add(this.text195x5);
            this.panel2.Controls.Add(this.text95x5);
            this.panel2.Controls.Add(this.text185x5);
            this.panel2.Controls.Add(this.text125x5);
            this.panel2.Controls.Add(this.text175x5);
            this.panel2.Controls.Add(this.text135x5);
            this.panel2.Controls.Add(this.text145x5);
            this.panel2.Location = new System.Drawing.Point(26, 19);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(221, 174);
            this.panel2.TabIndex = 12;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // text215x5
            // 
            this.text215x5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text215x5.Location = new System.Drawing.Point(37, 142);
            this.text215x5.Name = "text215x5";
            this.text215x5.Size = new System.Drawing.Size(26, 26);
            this.text215x5.TabIndex = 24;
            // 
            // text15x5
            // 
            this.text15x5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text15x5.Location = new System.Drawing.Point(37, 14);
            this.text15x5.Name = "text15x5";
            this.text15x5.Size = new System.Drawing.Size(26, 26);
            this.text15x5.TabIndex = 23;
            // 
            // text165x5
            // 
            this.text165x5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text165x5.Location = new System.Drawing.Point(37, 110);
            this.text165x5.Name = "text165x5";
            this.text165x5.Size = new System.Drawing.Size(26, 26);
            this.text165x5.TabIndex = 22;
            // 
            // text65x5
            // 
            this.text65x5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text65x5.Location = new System.Drawing.Point(37, 46);
            this.text65x5.Name = "text65x5";
            this.text65x5.Size = new System.Drawing.Size(26, 26);
            this.text65x5.TabIndex = 20;
            // 
            // text115x5
            // 
            this.text115x5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text115x5.Location = new System.Drawing.Point(37, 78);
            this.text115x5.Name = "text115x5";
            this.text115x5.Size = new System.Drawing.Size(26, 26);
            this.text115x5.TabIndex = 21;
            // 
            // text255x5
            // 
            this.text255x5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text255x5.Location = new System.Drawing.Point(165, 142);
            this.text255x5.Name = "text255x5";
            this.text255x5.Size = new System.Drawing.Size(26, 26);
            this.text255x5.TabIndex = 19;
            // 
            // text55x5
            // 
            this.text55x5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text55x5.Location = new System.Drawing.Point(165, 14);
            this.text55x5.Name = "text55x5";
            this.text55x5.Size = new System.Drawing.Size(26, 26);
            this.text55x5.TabIndex = 18;
            // 
            // text205x5
            // 
            this.text205x5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text205x5.Location = new System.Drawing.Point(165, 110);
            this.text205x5.Name = "text205x5";
            this.text205x5.Size = new System.Drawing.Size(26, 26);
            this.text205x5.TabIndex = 17;
            // 
            // text105x5
            // 
            this.text105x5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text105x5.Location = new System.Drawing.Point(165, 46);
            this.text105x5.Name = "text105x5";
            this.text105x5.Size = new System.Drawing.Size(26, 26);
            this.text105x5.TabIndex = 15;
            // 
            // text155x5
            // 
            this.text155x5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text155x5.Location = new System.Drawing.Point(165, 78);
            this.text155x5.Name = "text155x5";
            this.text155x5.Size = new System.Drawing.Size(26, 26);
            this.text155x5.TabIndex = 16;
            // 
            // text225x5
            // 
            this.text225x5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text225x5.Location = new System.Drawing.Point(69, 142);
            this.text225x5.Name = "text225x5";
            this.text225x5.Size = new System.Drawing.Size(26, 26);
            this.text225x5.TabIndex = 12;
            // 
            // text235x5
            // 
            this.text235x5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text235x5.Location = new System.Drawing.Point(101, 142);
            this.text235x5.Name = "text235x5";
            this.text235x5.Size = new System.Drawing.Size(26, 26);
            this.text235x5.TabIndex = 13;
            // 
            // text245x5
            // 
            this.text245x5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text245x5.Location = new System.Drawing.Point(133, 142);
            this.text245x5.Name = "text245x5";
            this.text245x5.Size = new System.Drawing.Size(26, 26);
            this.text245x5.TabIndex = 14;
            // 
            // text25x5
            // 
            this.text25x5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text25x5.Location = new System.Drawing.Point(69, 14);
            this.text25x5.Name = "text25x5";
            this.text25x5.Size = new System.Drawing.Size(26, 26);
            this.text25x5.TabIndex = 9;
            // 
            // text35x5
            // 
            this.text35x5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text35x5.Location = new System.Drawing.Point(101, 14);
            this.text35x5.Name = "text35x5";
            this.text35x5.Size = new System.Drawing.Size(26, 26);
            this.text35x5.TabIndex = 10;
            this.text35x5.TextChanged += new System.EventHandler(this.textBox21_TextChanged);
            // 
            // text45x5
            // 
            this.text45x5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text45x5.Location = new System.Drawing.Point(133, 14);
            this.text45x5.Name = "text45x5";
            this.text45x5.Size = new System.Drawing.Size(26, 26);
            this.text45x5.TabIndex = 11;
            // 
            // text75x5
            // 
            this.text75x5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text75x5.Location = new System.Drawing.Point(69, 46);
            this.text75x5.Name = "text75x5";
            this.text75x5.Size = new System.Drawing.Size(26, 26);
            this.text75x5.TabIndex = 0;
            // 
            // text85x5
            // 
            this.text85x5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text85x5.Location = new System.Drawing.Point(101, 46);
            this.text85x5.Name = "text85x5";
            this.text85x5.Size = new System.Drawing.Size(26, 26);
            this.text85x5.TabIndex = 1;
            // 
            // text195x5
            // 
            this.text195x5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text195x5.Location = new System.Drawing.Point(133, 110);
            this.text195x5.Name = "text195x5";
            this.text195x5.Size = new System.Drawing.Size(26, 26);
            this.text195x5.TabIndex = 8;
            // 
            // text95x5
            // 
            this.text95x5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text95x5.Location = new System.Drawing.Point(133, 46);
            this.text95x5.Name = "text95x5";
            this.text95x5.Size = new System.Drawing.Size(26, 26);
            this.text95x5.TabIndex = 2;
            // 
            // text185x5
            // 
            this.text185x5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text185x5.Location = new System.Drawing.Point(101, 110);
            this.text185x5.Name = "text185x5";
            this.text185x5.Size = new System.Drawing.Size(26, 26);
            this.text185x5.TabIndex = 7;
            // 
            // text125x5
            // 
            this.text125x5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text125x5.Location = new System.Drawing.Point(69, 78);
            this.text125x5.Name = "text125x5";
            this.text125x5.Size = new System.Drawing.Size(26, 26);
            this.text125x5.TabIndex = 3;
            // 
            // text175x5
            // 
            this.text175x5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text175x5.Location = new System.Drawing.Point(69, 110);
            this.text175x5.Name = "text175x5";
            this.text175x5.Size = new System.Drawing.Size(26, 26);
            this.text175x5.TabIndex = 6;
            // 
            // text135x5
            // 
            this.text135x5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text135x5.Location = new System.Drawing.Point(101, 78);
            this.text135x5.Name = "text135x5";
            this.text135x5.Size = new System.Drawing.Size(26, 26);
            this.text135x5.TabIndex = 4;
            // 
            // text145x5
            // 
            this.text145x5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text145x5.Location = new System.Drawing.Point(133, 78);
            this.text145x5.Name = "text145x5";
            this.text145x5.Size = new System.Drawing.Size(26, 26);
            this.text145x5.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.text13x3);
            this.panel1.Controls.Add(this.text23x3);
            this.panel1.Controls.Add(this.text93x3);
            this.panel1.Controls.Add(this.text33x3);
            this.panel1.Controls.Add(this.text83x3);
            this.panel1.Controls.Add(this.text43x3);
            this.panel1.Controls.Add(this.text73x3);
            this.panel1.Controls.Add(this.text53x3);
            this.panel1.Controls.Add(this.text63x3);
            this.panel1.Location = new System.Drawing.Point(46, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(184, 100);
            this.panel1.TabIndex = 11;
            // 
            // text13x3
            // 
            this.text13x3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text13x3.Location = new System.Drawing.Point(49, 5);
            this.text13x3.Name = "text13x3";
            this.text13x3.Size = new System.Drawing.Size(26, 26);
            this.text13x3.TabIndex = 0;
            // 
            // text23x3
            // 
            this.text23x3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text23x3.Location = new System.Drawing.Point(81, 5);
            this.text23x3.Name = "text23x3";
            this.text23x3.Size = new System.Drawing.Size(26, 26);
            this.text23x3.TabIndex = 1;
            // 
            // text93x3
            // 
            this.text93x3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text93x3.Location = new System.Drawing.Point(113, 69);
            this.text93x3.Name = "text93x3";
            this.text93x3.Size = new System.Drawing.Size(26, 26);
            this.text93x3.TabIndex = 8;
            // 
            // text33x3
            // 
            this.text33x3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text33x3.Location = new System.Drawing.Point(113, 5);
            this.text33x3.Name = "text33x3";
            this.text33x3.Size = new System.Drawing.Size(26, 26);
            this.text33x3.TabIndex = 2;
            // 
            // text83x3
            // 
            this.text83x3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text83x3.Location = new System.Drawing.Point(81, 69);
            this.text83x3.Name = "text83x3";
            this.text83x3.Size = new System.Drawing.Size(26, 26);
            this.text83x3.TabIndex = 7;
            // 
            // text43x3
            // 
            this.text43x3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text43x3.Location = new System.Drawing.Point(49, 37);
            this.text43x3.Name = "text43x3";
            this.text43x3.Size = new System.Drawing.Size(26, 26);
            this.text43x3.TabIndex = 3;
            // 
            // text73x3
            // 
            this.text73x3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text73x3.Location = new System.Drawing.Point(49, 69);
            this.text73x3.Name = "text73x3";
            this.text73x3.Size = new System.Drawing.Size(26, 26);
            this.text73x3.TabIndex = 6;
            // 
            // text53x3
            // 
            this.text53x3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text53x3.Location = new System.Drawing.Point(81, 37);
            this.text53x3.Name = "text53x3";
            this.text53x3.Size = new System.Drawing.Size(26, 26);
            this.text53x3.TabIndex = 4;
            // 
            // text63x3
            // 
            this.text63x3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text63x3.Location = new System.Drawing.Point(113, 37);
            this.text63x3.Name = "text63x3";
            this.text63x3.Size = new System.Drawing.Size(26, 26);
            this.text63x3.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Weight:";
            this.label2.Click += new System.EventHandler(this.Weight_Click);
            // 
            // textWeight
            // 
            this.textWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textWeight.Location = new System.Drawing.Point(110, 199);
            this.textWeight.Name = "textWeight";
            this.textWeight.Size = new System.Drawing.Size(58, 26);
            this.textWeight.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(61, 342);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(147, 342);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // FilterBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 376);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Name = "FilterBox";
            this.Text = "FilterBox";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.TextBox textWeight;
        public System.Windows.Forms.TextBox text93x3;
        public System.Windows.Forms.TextBox text83x3;
        public System.Windows.Forms.TextBox text73x3;
        public System.Windows.Forms.TextBox text63x3;
        public System.Windows.Forms.TextBox text53x3;
        public System.Windows.Forms.TextBox text43x3;
        public System.Windows.Forms.TextBox text33x3;
        public System.Windows.Forms.TextBox text23x3;
        public System.Windows.Forms.TextBox text13x3;
        public System.Windows.Forms.TextBox text215x5;
        public System.Windows.Forms.TextBox text15x5;
        public System.Windows.Forms.TextBox text165x5;
        public System.Windows.Forms.TextBox text65x5;
        public System.Windows.Forms.TextBox text115x5;
        public System.Windows.Forms.TextBox text255x5;
        public System.Windows.Forms.TextBox text55x5;
        public System.Windows.Forms.TextBox text205x5;
        public System.Windows.Forms.TextBox text105x5;
        public System.Windows.Forms.TextBox text155x5;
        public System.Windows.Forms.TextBox text225x5;
        public System.Windows.Forms.TextBox text235x5;
        public System.Windows.Forms.TextBox text245x5;
        public System.Windows.Forms.TextBox text25x5;
        public System.Windows.Forms.TextBox text35x5;
        public System.Windows.Forms.TextBox text45x5;
        public System.Windows.Forms.TextBox text75x5;
        public System.Windows.Forms.TextBox text85x5;
        public System.Windows.Forms.TextBox text195x5;
        public System.Windows.Forms.TextBox text95x5;
        public System.Windows.Forms.TextBox text185x5;
        public System.Windows.Forms.TextBox text125x5;
        public System.Windows.Forms.TextBox text175x5;
        public System.Windows.Forms.TextBox text135x5;
        public System.Windows.Forms.TextBox text145x5;
    }
}