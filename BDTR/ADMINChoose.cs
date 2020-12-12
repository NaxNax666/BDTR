using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BDTR
{
    public partial class ADMINChoose : Form
    {
        public ADMINChoose()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddClientForm addClientForm = new AddClientForm();
            addClientForm.Show();
        }

        private void CoachAddButton_Click(object sender, EventArgs e)
        {
            AddCoachForm addCoachForm = new AddCoachForm();
            addCoachForm.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            OtherForm otherForm = new OtherForm();
            otherForm.Show();
        }

        private void delProg_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=JOJOfit;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string ask = String.Format("exec [dbo].[Delprog]'{0}'", Program_list.Text);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(ask, connection);
            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet, "Prgl");
            foreach (DataRow row in dataSet.Tables[0].Rows)
            {
                foreach (DataColumn column in dataSet.Tables[0].Columns)
                {
                    Program_list.Items.Add(row[column].ToString());
                }
            }
            connection.Close();
        }

        private void ADMINChoose_Load(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=JOJOfit;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string ask = "select Title from Program_list";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(ask, connection);
            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet, "Prgl");
            foreach (DataRow row in dataSet.Tables[0].Rows)
            {
                foreach (DataColumn column in dataSet.Tables[0].Columns)
                {
                    Program_list.Items.Add(row[column].ToString());
                }
            }
            connection.Close();
        }

        private void InvBut_Click(object sender, EventArgs e)
        {
            InvForm invForm = new InvForm();
            invForm.Show();
        }
    }
}
