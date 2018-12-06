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
        string passValue;
        int intValue;
        int actionTriger;
        public Form1(string valuePass, int intVal, int actionT)
        {
            InitializeComponent();
            passValue = valuePass;
            intValue = intVal;
            actionTriger = actionT;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           this.movieTableAdapter.Fill(this.movieDBDataSet1.Movie);
           if(this.passValue != null)
            {
                label2.Text = passValue;
            }
            if (intValue != 0)
            {
                BindingSource dv = (BindingSource)dataGridView1.DataSource;
                dv.RemoveFilter();
                switch (actionTriger)
                {
                    case 1:
                        dv.Filter = "dirId LIKE '" + intValue + "'";
                        break;
                    case 2:
                        dv.Filter = "genreId =" + intValue;
                        break;
                    case 3:
                        dv.Filter = "actorId =" + intValue;
                        break;

                }
                
                dataGridView1.DataSource = dv;
            }
        }

        private void textbox1_Change(object sender, EventArgs e)
        {

        }



        private void button1_Click(object sender, EventArgs e)
        {
            //no button one any more

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            BindingSource dv = (BindingSource)dataGridView1.DataSource;
            dv.RemoveFilter();
            String searchText = textBox1.Text;
            if (searchText == "")
            {
                if (intValue != 0)
                {
                    switch (actionTriger)
                    {
                        case 1:
                            dv.Filter = "dirId LIKE '" + intValue + "'";
                            break;
                        case 2:
                            dv.Filter = "genreId =" + intValue;
                            break;
                        case 3:
                            dv.Filter = "actorId =" + intValue;
                            break;
                    }
                }
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
            Form3 f3 = new Form3();
            f3.Show();
            this.Hide();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            f5.Show();
            this.Hide();
        }
    }
}
