using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MovieApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'movieDBDataSet1.Movie' table. You can move, or remove it, as needed.
            this.movieTableAdapter.Fill(this.movieDBDataSet1.Movie);
           
        }

        private void textbox1_Change(object sender, EventArgs e)
        {

        }



        private void button1_Click(object sender, EventArgs e)
        {
            BindingSource dv = (BindingSource)dataGridView1.DataSource;
            dv.RemoveFilter();
            String searchText = textBox1.Text;
            if(searchText == "")
            {
                this.movieTableAdapter.Fill(this.movieDBDataSet1.Movie);
            }
            else
            {
                dv.Filter = "title LIKE '%" + searchText + "%'";
                dataGridView1.DataSource = dv;
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            BindingSource dv = (BindingSource)dataGridView1.DataSource;
            dv.RemoveFilter();
            String searchText = textBox1.Text;
            if (searchText == "")
            {
                this.movieTableAdapter.Fill(this.movieDBDataSet1.Movie);
            }
            else
            {
                dv.Filter = "title LIKE '%" + searchText + "%'";
                dataGridView1.DataSource = dv;
            }

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            this.dataGridView1.Sort(this.dataGridView1.Columns[0], ListSortDirection.Ascending);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            this.dataGridView1.Sort(this.dataGridView1.Columns[0], ListSortDirection.Descending);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }
    }
}
