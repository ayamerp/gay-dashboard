using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace vachart
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            dgvData.DataSource = LoadCSV(textBox1.Text);
        }

        public List<GenderData> LoadCSV(string csvFile)
        {
            var query = from l in File.ReadAllLines(csvFile)
                        let data = l.Split(',')
                        select new GenderData
                        {
                            DateAndTime = data[0],
                            Gender = data[1],
                            FirstDoseDaily = data[2],
                            FirstDoseCumulative = data[3],
                            SecondDoseDaily = data[4],
                            SecondDoseCumulative = data[5],
                            SingleDoseDailyCumulative = data[6],
                            ThirdDoseDaily = data[7],
                            ThirdDoseDailyCumulative = data[8],
                            AtleastOneDose = data[9],
                            AtleastOneDoseCumulative = data[10],
                            FullyVaccinated = data[11],
                            FullyVaccinatedCumulative = data[12],
                        };
            return query.ToList();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.ShowDialog();
            textBox1.Text = dlg.FileName;
        }
    }

    public class GenderData
    {
        public string DateAndTime { get; set; }
        public string Gender { get; set; }
        public string FirstDoseDaily { get; set; }
        public string FirstDoseCumulative { get; set; }
        public string SecondDoseDaily { get; set; }
        public string SecondDoseCumulative { get; set; }
        public string SingleDoseDaily { get; set; }
        public string SingleDoseDailyCumulative { get; set; }
        public string ThirdDoseDaily { get; set; }
        public string ThirdDoseDailyCumulative { get; set; }
        public string AtleastOneDose { get; set; }
        public string AtleastOneDoseCumulative { get; set; }
        public string FullyVaccinated { get; set; }
        public string FullyVaccinatedCumulative { get; set; }
    }

}
