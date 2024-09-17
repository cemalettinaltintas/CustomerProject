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
    public partial class FrmStatistics : Form
    {
        public FrmStatistics()
        {
            InitializeComponent();
        }
        SqlConnection sqlConnection = new SqlConnection("Server=.\\SQLEXPRESS;initial catalog=DbCustomer;integrated security=true");
        private void FrmStatistics_Load(object sender, EventArgs e)
        {
            sqlConnection.Open();
            SqlCommand command = new SqlCommand("select count(*) from TblCity", sqlConnection);
            SqlDataReader reader = command.ExecuteReader();
            //if (reader!=null&& reader.Read())
            //{
            //    lblCityCount.Text = reader[0].ToString();
            //}
            while (reader.Read())
            {
                lblCityCount.Text = reader[0].ToString();
            }
            sqlConnection.Close();

            CustomerCount();
            GetCustomerBalance();
        }
        private void CustomerCount()
        {
            sqlConnection.Open();
            SqlCommand command = new SqlCommand("select count(*) from TblCustomer", sqlConnection);
            SqlDataReader reader = command.ExecuteReader();
            if (reader != null && reader.Read())
            {
                lblCustomerCount.Text = reader[0].ToString();
            }
            sqlConnection.Close();
        }
        private void GetCustomerBalance()
        {
            sqlConnection.Open();
            SqlCommand command = new SqlCommand("select sum(CustomerBalance) from TblCustomer", sqlConnection);
            SqlDataReader reader = command.ExecuteReader();
            if (reader != null && reader.Read())
            {
                lblCutomerBalance.Text = reader[0].ToString();
            }
            sqlConnection.Close();
        }
    }
}
