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
        string[] rowElements; 
        public Form2(string []rowElements)
        {
            InitializeComponent();
            this.rowElements = rowElements;
        }


        private void Form2_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns.Add("","");
            dataGridView1.Columns[0].Width = 400;
            dataGridView1.Rows.Add(rowElements[0]);
            for (int i = 1; i < rowElements.Length; i++)
            {
                if (rowElements[i] != "SKIP")
                {
                    dataGridView1.Rows.Add(rowElements[i]);
                }
            }
        }
    }
}