using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeoMapDashBoard
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LiveCharts.WinForms.GeoMap geoMap = new LiveCharts.WinForms.GeoMap();
            Dictionary<string, double> keyValues = new Dictionary<string, double>();
            keyValues["CL"] = 81285;
            keyValues["CH"] = 81285;
            keyValues["CR"] = 81285;
            keyValues["EC"] = 81285;
            keyValues["TW"] = 81285;
            keyValues["AT"] = 81285;
            keyValues["AU"] = 81285;
            keyValues["MT"] = 81285;
            keyValues["DE"] = 81285;
            keyValues["CO"] = 81285;
            keyValues["US"] = 81285;
            keyValues["GL"] = 81285;
            keyValues["IE"] = 81285;
            keyValues["FI"] = 81285;
            keyValues["LU"] = 81285;
            keyValues["BR"] = 81285;
            keyValues["FR"] = 81285;
            keyValues["NZ"] = 81285;
            keyValues["UY"] = 81285;
            keyValues["DK"] = 81285;
            keyValues["AR"] = 81285;
            keyValues["PT"] = 81285;
            keyValues["SE"] = 81285;
            keyValues["MX"] = 81285;
            keyValues["NO"] = 81285;
            keyValues["ZA"] = 81285;
            keyValues["ES"] = 81285;
            keyValues["CA"] = 81285;
            keyValues["BE"] = 81285;
            keyValues["NL"] = 81285;


            geoMap.HeatMap = keyValues;
            geoMap.Source = $"{Application.StartupPath}\\World.xml";
            this.Controls.Add(geoMap);
            geoMap.Dock = DockStyle.Fill;
        }
    }
}
