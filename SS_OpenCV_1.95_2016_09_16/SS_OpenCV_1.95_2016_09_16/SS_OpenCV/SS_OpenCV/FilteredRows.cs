using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Collections;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace SS_OpenCV
{
    public partial class FilteredRows : Form
    {
        public FilteredRows(ArrayList array, String name, String type)
        {
            InitializeComponent();

            DataPointCollection list1 = chart1.Series[0].Points;
            for (int i = 0; i < array.Count; i++)
            {
                list1.AddXY(i, (int)array[i]);
            }

            this.Text = name;
            chart1.Series[0].Color = Color.Red;
            chart1.ChartAreas[0].AxisX.Maximum = array.Count-1;
            chart1.ChartAreas[0].AxisX.Minimum = 0;
            chart1.ChartAreas[0].AxisX.Title = type;
            chart1.ChartAreas[0].AxisY.Title = "Pixeis brancos";
            chart1.ResumeLayout();
        }
    }
}
