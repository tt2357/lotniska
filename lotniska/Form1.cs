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
            
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem selectedRow = (ListViewItem)listView1.SelectedItems[0].Clone();

                Form2 Form2 = new Form2(selectedRow);
                Form2.Show();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var LotniskaDataList = new List<DaneLotniska>();
            listView1.View = View.Details;
            listView1.Columns.Add("Nazwa lotniska");
            listView1.Columns.Add("");
            listView1.Columns.Add("");
            listView1.Columns.Add("");
            listView1.Columns.Add("");
            listView1.Columns.Add("");
            listView1.Columns.Add("");

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
                var Item = new ListViewItem(new[] {daneLotniska.Nazwa_cl, daneLotniska.Miasto_cl, daneLotniska.Wojewodztwo_cl, daneLotniska.ICAO_cl, daneLotniska.IATA_cl, daneLotniska.Pasazerowie_cl, daneLotniska.Zmiana_cl });
                listView1.Items.Add(Item);
            }

            listView1.Columns[0].Width = 300;
            listView1.Columns[1].Width = 0;
            listView1.Columns[2].Width = 0;
            listView1.Columns[3].Width = 0;
            listView1.Columns[4].Width = 0;
            listView1.Columns[5].Width = 0;
            listView1.Columns[6].Width = 0;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void woj_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void ICAO_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void IATA_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void nazwa_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void lpas_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void zmiana_CheckedChanged(object sender, EventArgs e)
        {
        }
    }
}
