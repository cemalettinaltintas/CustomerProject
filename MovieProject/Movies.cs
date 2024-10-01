using MovieProject.DAL.Context;
using MovieProject.DAL.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieProject
{
    public partial class Movies : Form
    {
        public Movies()
        {
            InitializeComponent();
        }
        MovieContext context=new MovieContext();

        private void Movies_Load(object sender, EventArgs e)
        {
            var categories=context.Categories.ToList();
            cmbCategory.DataSource = categories;
            cmbCategory.DisplayMember = "CategoryName";
            cmbCategory.ValueMember = "CategoryId";
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            //var movies=context.Movies.ToList();
            //dataGridView1.DataSource = movies;
            MovieListWithCategoryName();
        }
        void MovieListWithCategoryName()
        {
            var movies = context.Movies
                .Join(context.Categories,
                movie => movie.CategoryId,
                category => category.CategoryId,
                (movie, category) => new
                {
                    MovieId=movie.MovieId,
                    MovieTitle=movie.MovieTitle,
                    Duration = movie.Duration,
                    Description =movie.Description,
                    CreatedTime=movie.CreatedTime,
                    Kategori=category.CategoryName,
                }).ToList();
            dataGridView1.DataSource = movies;
        }
        private void btnCreate_Click(object sender, EventArgs e)
        {
            Movie movie=new Movie();
            movie.MovieTitle=txtMovieTitle.Text;   
            movie.Description=txtDescription.Text;
            movie.Duration=int.Parse(txtDuration.Text);
            movie.CreatedTime=DateTime.Parse( mskCreatedTime.Text);
            movie.CategoryId = (int)cmbCategory.SelectedValue;
            context.Movies.Add(movie);
            context.SaveChanges();
            MessageBox.Show("İşlem başarılı");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var movies=context.Movies.Where(x=>x.MovieTitle==txtMovieTitle.Text).ToList();
            dataGridView1.DataSource = movies;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id =int.Parse( txtMovieId.Text);
            var value = context.Movies.Find(id);
            context.Movies.Remove(value);
            context.SaveChanges();
            MessageBox.Show("İşlem başarılı");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtMovieId.Text);
            var value = context.Movies.Find(id);

            value.MovieTitle = txtMovieTitle.Text;
            value.Duration = int.Parse(txtDuration.Text);
            value.Description = txtDescription.Text;
            value.CategoryId = (int) cmbCategory.SelectedValue;
            value.CreatedTime=DateTime.Parse(mskCreatedTime.Text);
      
            context.SaveChanges();
            MessageBox.Show("İşlem başarılı");;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMovieId.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtMovieTitle.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtDuration.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtDescription.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            mskCreatedTime.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            cmbCategory.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
        }
    }
}
