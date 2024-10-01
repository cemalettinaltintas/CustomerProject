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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        MovieContext context=new MovieContext();
        private void Form1_Load(object sender, EventArgs e)
        {
            CategoryList();
        }

        private void CategoryList()
        {
            var categories = context.Categories.ToList();
            dataGridView1.DataSource = categories;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            Category category = new Category();
            category.CategoryName=txtCategoryName.Text;

            context.Categories.Add(category);
            context.SaveChanges();
            MessageBox.Show("İşlem başarılı");
            CategoryList();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtCategoryId.Text);
            var category = context.Categories.Find(id);
            context.Categories.Remove(category);
            context.SaveChanges();
            MessageBox.Show("İşlem başarılı");
            CategoryList();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCategoryId.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtCategoryName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            int id = int.Parse(txtCategoryId.Text);

            var category = context.Categories.Find(id);

            category.CategoryName = txtCategoryName.Text;

            context.SaveChanges();
            MessageBox.Show("İşlem başarılı");
            CategoryList();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var categories = context.Categories.Where(x => x.CategoryName.Contains(txtCategoryName.Text)).ToList() ;
            dataGridView1.DataSource = categories;
        }

        // ORM - Entity Framework (DbFirst,CodeFirst,ModelFirst)
        //CodeFirst
    }
}
