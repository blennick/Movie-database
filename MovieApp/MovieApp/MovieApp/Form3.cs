using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieApp
{
    public partial class Form3 : Form
    {
        string selcValue;
        int selcValueInt;
        public Form3()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //BindingSource dv = (BindingSource)dataGridView1.DataSource;
            //dv.RemoveFilter();
            if (dataGridView1.Rows[e.RowIndex].Cells[2].Value != null)
            {
                selcValue = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                selcValue += " "+ dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                selcValueInt = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString());
            }

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'movieDBDataSetDIR.Director' table. You can move, or remove it, as needed.
            this.directorTableAdapter.Fill(this.movieDBDataSetDIR.Director);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            BindingSource dv = (BindingSource)dataGridView1.DataSource;
            dv.RemoveFilter();
            String searchText = textBox1.Text;
            if (searchText == "")
            {
                this.directorTableAdapter.Fill(this.movieDBDataSetDIR.Director);
            }
            else
            {
                dv.Filter = "dirLName LIKE '%" + searchText + "%'";
                dataGridView1.DataSource = dv;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1(selcValue,selcValueInt,1);
            f1.Show();
            this.Hide();
        }
    }
}
