using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace lotniska
{
    public partial class Form1 : Form
    {
        bool[] chs; 
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 Form2 = new Form2(chs);
            Form2.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var LotniskaDataList = new List<DaneLotniska>();
            listView1.View = View.Details;
            listView1.Columns.Add("Nazwa lotniska");

            using (var reader = new StreamReader("Dane-Testowe.csv"))
            {
                var linia = 0;

                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');

                    if (linia > 0 && values.Length >= 7)
                    {
                        var daneLotniska = new DaneLotniska
                        {
                            Miasto_cl = values[0],
                            Wojewodztwo_cl = values[1],
                            ICAO_cl = values[2],
                            IATA_cl = values[3],
                            Nazwa_cl = values[4],
                            Pasazerowie_cl = values[5],
                            Zmiana_cl = values[6]
                        };

                        LotniskaDataList.Add(daneLotniska);
                    }
                    linia++;
                }
            }

            foreach (var daneLotniska in LotniskaDataList)
            {
                var item = new ListViewItem(new[] {daneLotniska.Nazwa_cl});
                listView1.Items.Add(item);
            }

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void woj_CheckedChanged(object sender, EventArgs e)
        {
            if (woj.Checked)
            {
                chs[0] = true;
            }
            else
            {
                chs[0] = false;
            }
        }

        private void ICAO_CheckedChanged(object sender, EventArgs e)
        {
            if (ICAO.Checked)
            {
                chs[1] = true;
            }
            else
            {
                chs[1] = false;
            }
        }

        private void IATA_CheckedChanged(object sender, EventArgs e)
        {
            if (IATA.Checked)
            {
                chs[2] = true;
            }
            else
            {
                chs[2] = false;
            }
        }

        private void nazwa_CheckedChanged(object sender, EventArgs e)
        {
            if (nazwa.Checked)
            {
                chs[3] = true;
            }
            else
            {
                chs[3] = false;
            }
        }

        private void lpas_CheckedChanged(object sender, EventArgs e)
        {
            if (lpas.Checked)
            {
                chs[4] = true;
            }
            else
            {
                chs[4] = false;
            }
        }

        private void zmiana_CheckedChanged(object sender, EventArgs e)
        {
            if (zmiana.Checked)
            {
                chs[5] = true;
            }
            else
            {
                chs[5] = false;
            }
        }
    }
}
