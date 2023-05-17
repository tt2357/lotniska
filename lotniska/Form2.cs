using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lotniska
{
    public partial class Form2 : Form
    {
        private ListViewItem selectedRow;
        public Form2(ListViewItem selectedRow)
        {
            InitializeComponent();
            this.selectedRow = selectedRow;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            listView1.Items.Add(selectedRow);
        }
    }
}