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
    public partial class Form4 : Form
    {
        string selcValue;
        int selcValueInt;
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'movieDBDataSetGenre.Genre' table. You can move, or remove it, as needed.
            this.genreTableAdapter.Fill(this.movieDBDataSetGenre.Genre);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            BindingSource dv = (BindingSource)dataGridView1.DataSource;
            dv.RemoveFilter();
            String searchText = textBox1.Text;
            if (searchText == "")
            {
                this.genreTableAdapter.Fill(this.movieDBDataSetGenre.Genre);
            }
            else
            {
                dv.Filter = "genreName LIKE '%" + searchText + "%'";
                dataGridView1.DataSource = dv;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1(selcValue, selcValueInt,2);
            f1.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //BindingSource dv = (BindingSource)dataGridView1.DataSource;
            //dv.RemoveFilter();
            if (dataGridView1.Rows[e.RowIndex].Cells[0].Value != null)
            {
                selcValue = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                selcValueInt = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString());
            }

        }
    }
}
