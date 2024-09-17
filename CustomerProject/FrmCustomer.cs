﻿using System;
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
    public partial class FrmCustomer : Form
    {
        public FrmCustomer()
        {
            InitializeComponent();
        }
        SqlConnection sqlConnection = new SqlConnection("Server=.\\SQLEXPRESS;initial catalog=DbCustomer;integrated security=true");

        private void FrmCustomer_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select * from TblCity", sqlConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            cmbCity.ValueMember = "CityId";
            cmbCity.DisplayMember = "CityName";
            cmbCity.DataSource= dt;
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            string komut = "Select CustomerId,CustomerName,CustomerSurname,CustomerBalance,CustomerStatus,CityName from TblCustomer Inner Join TblCity On TblCustomer.CustomerCity=TblCity.CityId";
            SqlCommand command = new SqlCommand(komut, sqlConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex>0)
            {
                txtCustomerId.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtCustomerName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtCustomerSurname.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtBalance.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                cmbCity.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                bool durum = (bool)dataGridView1.Rows[e.RowIndex].Cells[4].Value;

                if (durum)
                {
                    rdbActive.Checked = true; 
                }
                else
                {
                    rdbPassive.Checked = true;
                }
            }
        }

        private void btnProcedure_Click(object sender, EventArgs e)
        {
            string komut = "execute CustomerListWithCity";
            SqlCommand command = new SqlCommand(komut, sqlConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            SqlCommand command = new SqlCommand("insert into TblCustomer(CustomerName,CustomerSurname,CustomerBalance,CustomerStatus,CustomerCity) Values(@customerName,@customerSurname,@customerBalance,@customerStatus,@customerCity)", sqlConnection);

            command.Parameters.AddWithValue("@customerName", txtCustomerName.Text);
            command.Parameters.AddWithValue("@customerSurname", txtCustomerSurname.Text);
            command.Parameters.AddWithValue("@customerBalance",txtBalance.Text);
            command.Parameters.AddWithValue("@customerCity", cmbCity.SelectedValue);

            if (rdbActive.Checked)
            {
                command.Parameters.AddWithValue("@customerStatus", true);
            }
            if (rdbPassive.Checked)
            {
                command.Parameters.AddWithValue("@customerStatus", false);
            }
            command.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("Kayıt başarıyla eklendi.");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            SqlCommand command = new SqlCommand("delete from TblCustomer where CustomerId=@customerId", sqlConnection);
            command.Parameters.AddWithValue("@customerId", txtCustomerId.Text);
            command.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("Kayıt silindi", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string komut = "select * from TblCustomer where CustomerName=@customerName";
            SqlCommand command = new SqlCommand(komut, sqlConnection);
            command.Parameters.AddWithValue("@customerName", txtCustomerName.Text);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            SqlCommand command = new SqlCommand("update TblCustomer Set CustomerName=@customerName,CustomerSurname=@customerSurname,CustomerBalance=@customerBalance,CustomerStatus=@customerStatus,CustomerCity=@customerCity Where CustomerId=@customerId", sqlConnection);

            command.Parameters.AddWithValue("@customerName", txtCustomerName.Text);
            command.Parameters.AddWithValue("@customerSurname", txtCustomerSurname.Text);
            command.Parameters.AddWithValue("@customerBalance",decimal.Parse( txtBalance.Text));
            command.Parameters.AddWithValue("@customerCity", cmbCity.SelectedValue);

            if (rdbActive.Checked)
            {
                command.Parameters.AddWithValue("@customerStatus", true);
            }
            if (rdbPassive.Checked)
            {
                command.Parameters.AddWithValue("@customerStatus", false);
            }
            command.Parameters.AddWithValue("@customerId", txtCustomerId.Text);
            command.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("Kayıt başarıyla güncellendi.");
        }
    }
}
