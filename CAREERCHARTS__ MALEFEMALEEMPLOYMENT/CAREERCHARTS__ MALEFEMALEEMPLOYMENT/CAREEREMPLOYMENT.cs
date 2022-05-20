using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CAREERCHARTS___MALEFEMALEEMPLOYMENT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            chart1.Series["Men"].Points.AddXY("Chief executives", 932743);
            chart1.Series["Women"].Points.AddXY("Chief executives", 335274);

            chart1.Series["Men"].Points.AddXY("General and operations managers", 685078);
            chart1.Series["Women"].Points.AddXY("General and operations managers", 341720);

            chart1.Series["Men"].Points.AddXY("Legislators", 7266);
            chart1.Series["Women"].Points.AddXY("Legislators", 4812);

            chart1.Series["Men"].Points.AddXY("Advertising and promotions managers", 20939);
            chart1.Series["Women"].Points.AddXY("Advertising and promotions managers", 27023);

            chart1.Series["Men"].Points.AddXY("Marketing managers", 185926);
            chart1.Series["Women"].Points.AddXY("Marketing managers", 276885);

            chart1.Series["Men"].Points.AddXY("Sales managers", 334121);
            chart1.Series["Women"].Points.AddXY("Sales managers", 160616);

            chart1.Series["Men"].Points.AddXY("Public relations and fundraising managers", 28038);
            chart1.Series["Women"].Points.AddXY("Public relations and fundraising managers", 56216);

            chart1.Series["Men"].Points.AddXY("Administrative services managers", 17489);
            chart1.Series["Women"].Points.AddXY("Administrative services managers", 39148);

            chart1.Series["Men"].Points.AddXY("Facilities managers", 90355);
            chart1.Series["Women"].Points.AddXY("Facilities managers", 18699);

            chart1.Series["Men"].Points.AddXY("Computer and information systems managers", 437646);
            chart1.Series["Women"].Points.AddXY("Computer and information systems managers", 176524);

            chart1.Series["Men"].Points.AddXY("Financial managers", 533586);
            chart1.Series["Women"].Points.AddXY("Financial managers", 673688);

            chart1.Series["Men"].Points.AddXY("Compensation and benefits managers", 4326);
            chart1.Series["Women"].Points.AddXY("Compensation and benefits managers", 13337);

            chart1.Series["Men"].Points.AddXY("Human resources managers", 59647);
            chart1.Series["Women"].Points.AddXY("Human resources managers", 180262);

            chart1.Series["Men"].Points.AddXY("Training and development managers", 23477);
            chart1.Series["Women"].Points.AddXY("Training and development managers", 27928);

            chart1.Series["Men"].Points.AddXY("Industrial production managers", 197946);
            chart1.Series["Women"].Points.AddXY("Industrial production managers", 57438);

            chart1.Series["Men"].Points.AddXY("Purchasing managers", 100815);
            chart1.Series["Women"].Points.AddXY("Purchasing managers", 98346);

            chart1.Series["Men"].Points.AddXY("Transportation, storage, and distribution managers", 204652);
            chart1.Series["Women"].Points.AddXY("Transportation, storage, and distribution managers", 50084);

            chart1.Series["Men"].Points.AddXY("Farmers, ranchers, and other agricultural managers", 411859);
            chart1.Series["Women"].Points.AddXY("Farmers, ranchers, and other agricultural managers", 56949);

            chart1.Series["Men"].Points.AddXY("Construction managers", 716687);
            chart1.Series["Women"].Points.AddXY("Construction managers", 62880);

            chart1.Series["Men"].Points.AddXY("Education and childcare administrators", 285342);
            chart1.Series["Women"].Points.AddXY("Education and childcare administrators", 516036);

            chart1.Series["Men"].Points.AddXY("Architectural and engineering managers", 149081);
            chart1.Series["Women"].Points.AddXY("Architectural and engineering managers", 18583);

            chart1.Series["Men"].Points.AddXY("Food service managers", 432632);
            chart1.Series["Women"].Points.AddXY("Food service managers", 398667);

            chart1.Series["Men"].Points.AddXY("Funeral home managers", 4520);
            chart1.Series["Women"].Points.AddXY("Funeral home managers", 2629);

            chart1.Series["Men"].Points.AddXY("Entertainment and recreation managers", 19178);
            chart1.Series["Women"].Points.AddXY("Entertainment and recreation managers", 12074);

            chart1.Series["Men"].Points.AddXY("Lodging managers", 60479);
            chart1.Series["Women"].Points.AddXY("Lodging managers", 63351);

            chart1.Series["Men"].Points.AddXY("Medical and health services managers", 172451);
            chart1.Series["Women"].Points.AddXY("Medical and health services managers", 439510);

            chart1.Series["Men"].Points.AddXY("Natural sciences managers", 6544);
            chart1.Series["Women"].Points.AddXY("Natural sciences managers", 9038);

            chart1.Series["Men"].Points.AddXY("Postmasters and mail superintendents", 12918);
            chart1.Series["Women"].Points.AddXY("Postmasters and mail superintendents", 12989);

            chart1.Series["Men"].Points.AddXY("Property, real estate, and community association", 223510);
            chart1.Series["Women"].Points.AddXY("Property, real estate, and community association", 246039);

            chart1.Series["Men"].Points.AddXY("Social and community service managers", 104765);
            chart1.Series["Women"].Points.AddXY("Social and community service managers", 242724);

            chart1.Series["Men"].Points.AddXY("Emergency management directors", 7815);
            chart1.Series["Women"].Points.AddXY("Emergency management directors", 4617);

            chart1.Series["Men"].Points.AddXY("Personal service managers, all other", 458);
            chart1.Series["Women"].Points.AddXY("Personal service managers, all other", 1319);

            chart1.Series["Men"].Points.AddXY("Managers, all other", 2428328);
            chart1.Series["Women"].Points.AddXY("Managers, all other", 1341712);

        }
    }
}
