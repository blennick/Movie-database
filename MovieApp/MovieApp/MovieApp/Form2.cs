using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MovieApp.Models;

namespace MovieApp
{
    public partial class Form2 : Form
    {
        MovieDBEntities2 context = new MovieDBEntities2();

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        { /*
            SqlConnection conn = new SqlConnection(@"Data Source=TOM-PC\sqlexpress;Initial Catalog=Northwind;User ID=sa;Password=xyz");
            conn.Open();
            SqlCommand sc = new SqlCommand("select genre", conn);
            SqlDataReader reader;

            reader = sc.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("genreId", typeof(int));
            dt.Columns.Add("genreName", typeof(string));
            dt.Load(reader);

            genreCB.DisplayMember = "genre";
            genreCB.ValueMember = "genreId";
            genreCB.DataSource = dt;

            conn.Close();
            */

            genreCB.Items.Add("Adventure");
            genreCB.Items.Add("Romance");
            directorCB.Items.Add("Tim Burton");
            mainActorCB.Items.Add("Bryant Lennick");
        }

        private void submitBT_Click(object sender, EventArgs e)
        {
            Movie m = new Movie();
            m.title = movieTitleTB.Text;
            m.releaseYear = int.Parse(releaseDataTB.Text);
            m.genreId = 7;
            m.dirID = 4;
            m.actorId = 3;
            m.userId = 1;

            context.Movies.Add(m);
            context.SaveChanges();

            /*
            MovieDBDataSet1TableAdapters.MovieTableAdapter tableAdapt =
                new MovieDBDataSet1TableAdapters.MovieTableAdapter();
            tableAdapt.Insert(m.title, m.releaseYear, m.dirID, m.userId, m.genreId, m.actorId);
            */
        }
    }
}
