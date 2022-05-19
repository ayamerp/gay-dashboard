using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CHARTdASHBOARD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            chart1.Series["Male"].Points.AddXY("2011", 144833.0);
            chart1.Series["Male"].Points.AddXY("2011", 136574.0);
            chart1.Series["Male"].Points.AddXY("2012", 125994.0);
            chart1.Series["Male"].Points.AddXY("2012", 129302.0);
            chart1.Series["Male"].Points.AddXY("2012", 147973.0);
            chart1.Series["Male"].Points.AddXY("2012", 138855.0);
            chart1.Series["Male"].Points.AddXY("2013", 127699.0);
            chart1.Series["Male"].Points.AddXY("2013", 131456.0);
            chart1.Series["Male"].Points.AddXY("2013", 149710.0);
            chart1.Series["Male"].Points.AddXY("2013", 141050.0);
            chart1.Series["Male"].Points.AddXY("2014", 128998.0);
            chart1.Series["Male"].Points.AddXY("2014", 133602.0);
            chart1.Series["Male"].Points.AddXY("2014", 152235.0);
            chart1.Series["Male"].Points.AddXY("2014", 142579.0);
            chart1.Series["Male"].Points.AddXY("2015", 131222.0);
            chart1.Series["Male"].Points.AddXY("2015", 134593.0);
            chart1.Series["Male"].Points.AddXY("2015", 152408.0);
            chart1.Series["Male"].Points.AddXY("2015", 141890.0);
            chart1.Series["Male"].Points.AddXY("2016", 128939.0);
            chart1.Series["Male"].Points.AddXY("2016", 131890.0);


            chart1.Series["Female"].Points.AddXY("2011", 117360.0);
            chart1.Series["Female"].Points.AddXY("2011", 111143.0);
            chart1.Series["Female"].Points.AddXY("2012", 107064.0);
            chart1.Series["Female"].Points.AddXY("2012", 108414.0);
            chart1.Series["Female"].Points.AddXY("2012", 119334.0);
            chart1.Series["Female"].Points.AddXY("2012", 112837.0);
            chart1.Series["Female"].Points.AddXY("2013", 108195.0);
            chart1.Series["Female"].Points.AddXY("2013", 109397.0);
            chart1.Series["Female"].Points.AddXY("2013", 120545.0);
            chart1.Series["Female"].Points.AddXY("2013", 114400.0);
            chart1.Series["Female"].Points.AddXY("2014", 108268.0);
            chart1.Series["Female"].Points.AddXY("2014", 109760.0);
            chart1.Series["Female"].Points.AddXY("2014", 121282.0);
            chart1.Series["Female"].Points.AddXY("2014", 114484.0);
            chart1.Series["Female"].Points.AddXY("2015", 110046.0);
            chart1.Series["Female"].Points.AddXY("2015", 111022.0);
            chart1.Series["Female"].Points.AddXY("2015", 123108.0);
            chart1.Series["Female"].Points.AddXY("2015", 115719.0);
            chart1.Series["Female"].Points.AddXY("2016", 110202.0);
            chart1.Series["Female"].Points.AddXY("2016", 111592.0);
        }
    }
}
