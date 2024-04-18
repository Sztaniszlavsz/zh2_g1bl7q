using CsvHelper;
using System.ComponentModel;
using System.Globalization;
using System.Reflection;

namespace zh2_g1bl7q
{
    public partial class Form1 : Form
    {
        BindingList<repulo> repulojarat = new();
        public Form1()
        {
            InitializeComponent();
            repuloBindingSource.DataSource = repulojarat;
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            try
            {
                StreamReader sr = new StreamReader("repulojaratok.csv");
                var csv = new CsvReader(sr, CultureInfo.InvariantCulture);
                var t�mb = csv.GetRecords<repulo>();
                foreach (var item in t�mb)
                {
                    repulojarat.Add(item);
                }
                sr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog SFD = new();
                if (SFD.ShowDialog() == DialogResult.OK)
                {
                    StreamWriter sw = new StreamWriter(SFD.FileName);
                    var csv = new CsvWriter(sw, CultureInfo.InvariantCulture);

                    csv.WriteRecords(repulojarat);
                    sw.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (repuloBindingSource.Current == null) return;

            if (MessageBox.Show("Biztosan t�r�lni akarod ezt a sort?", "T�rl�s", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                repuloBindingSource.RemoveCurrent();
            }
        }

        private void buttonAddNew_Click(object sender, EventArgs e)
        {
            FormAddNew formAddNew = new();
            formAddNew.ShowDialog();
            repulojarat.Add(formAddNew.�jAdat);
        }

        private void buttonFact_Click(object sender, EventArgs e)
        {
            string varos1 = "";
            string varos2 = "";
            int hossz = 0;
            int jaratszam = 0;
            int utas = 0;
            int atlag = 0;
            foreach (var item in repulojarat)
            {
                if (item.IdotartamOra > hossz)
                {
                    hossz = item.IdotartamOra;
                    varos1 = item.IndulasiHely;
                    varos2 = item.CelHely;
                }
                if (item.CelHely == "New York")
                {
                    jaratszam++;
                    utas = utas + item.UtasokSzama;
                }
            }
            atlag = utas / jaratszam;
            MessageBox.Show($"A leghosszabb menetidej� j�rat {varos1}-b�l/b�l indul {varos2}-ba/be.\n" +
                $"�tlagosan {atlag} utas utazik a New York-i v�g�llom�s� j�ratokon.");

        }
    }
}