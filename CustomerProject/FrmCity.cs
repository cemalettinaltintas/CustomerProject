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

namespace CustomerProject
{
    public partial class FrmCity : Form
    {
        public FrmCity()
        {
            InitializeComponent();
        }
        SqlConnection sqlConnection=new SqlConnection("Server=.\\SQLEXPRESS;initial catalog=DbCustomer;integrated security=true");
        private void btnListele_Click(object sender, EventArgs e)
        {
            CityList();
        }

        private void CityList()
        {
            string komut = "select * from TblCity";
            SqlCommand command = new SqlCommand(komut, sqlConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        //ADO.NET
        //ORM
        //Entity Framework
        private void btnCreate_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            SqlCommand command = new SqlCommand("INSERT INTO TblCity(CityName,CityCountry) VALUES(@cityName,@cityCountry)", sqlConnection);
            command.Parameters.AddWithValue("@cityName",txtCityName.Text);
            command.Parameters.AddWithValue("@cityCountry", txtCountry.Text);
            command.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("Şehir başarıyla eklendi.");
            CityList();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCityId.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtCityName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtCountry.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            SqlCommand command = new SqlCommand("delete from TblCity where CityId=@cityId", sqlConnection);
            command.Parameters.AddWithValue("@cityId", txtCityId.Text);
            command.ExecuteNonQuery ();
            sqlConnection.Close();
            CityList(); 
            MessageBox.Show("Kayıt silindi","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Warning);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            SqlCommand command = new SqlCommand("update TblCity Set CityName=@cityName,CityCountry=@cityCountry where CityId=@cityId", sqlConnection);
            command.Parameters.AddWithValue("@cityId", txtCityId.Text);
            command.Parameters.AddWithValue("@cityName",txtCityName.Text);
            command.Parameters.AddWithValue("@cityCountry", txtCountry.Text);
            command.ExecuteNonQuery();
            sqlConnection.Close();
            CityList();
            MessageBox.Show("Kayıt güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string komut = "select * from TblCity where CityName=@cityName";
            SqlCommand command = new SqlCommand(komut, sqlConnection);
            command.Parameters.AddWithValue("@cityName", txtCityName.Text);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
