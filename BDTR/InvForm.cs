using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Configuration;

namespace BDTR
{
    public partial class InvForm : Form
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["BDTR.Properties.Settings.FitClub_primaryConnectionString"].ConnectionString;
        public InvForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AddInvButt_Click(object sender, EventArgs e)
        {
            if (Program_list.Text != "" && NewInvName.Text != "")
            {
                //string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=JOJOfit;Integrated Security=True";
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                DataSet dataSet = new DataSet();
                string ask = String.Format("exec [dbo].[AddInv] '{0}','{1}-{2}-{3}', {4}, '{5}'", NewInvName.Text, Bdate.Value.Year, Bdate.Value.Month, Bdate.Value.Day, CostBox.Text, Program_list.Text);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(ask, connection);
                sqlDataAdapter.Fill(dataSet, "Prg");
                Inv.Items.Add(NewInvName.Text);
                NewInvName.Text = "";
                CostBox.Value = 0;
                Program_list.Text = "";
                ask = String.Format("select * from Inventory");
                sqlDataAdapter = new SqlDataAdapter(ask, connection);
                sqlDataAdapter.Fill(dataSet, "inv");
                DataView.DataSource = dataSet.Tables["Inv"];
                connection.Close();
            }
            else
            {
                MessageBox.Show("Введите название инвентаря и выберите программу", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InvForm_Load(object sender, EventArgs e)
        {
            //string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=JOJOfit;Integrated Security=True";
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
            ask = "select invName from Inventory";
            sqlDataAdapter = new SqlDataAdapter(ask, connection);
            dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet, "invdel");
            foreach (DataRow row in dataSet.Tables["invdel"].Rows)
            {
                foreach (DataColumn column in dataSet.Tables[0].Columns)
                {
                    Inv.Items.Add(row[column].ToString());
                }
            }
            connection.Close();
            
        }

        private void AddinvProg_Click(object sender, EventArgs e)
        {
            if (Program_list.Text != "" && Inv.Text != "")
            {
                //string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=JOJOfit;Integrated Security=True";
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                DataSet dataSet = new DataSet();
                string ask = String.Format("exec [dbo].[AddInvtoPrgrm] '{0}','{1}'", Inv.Text, Program_list.Text);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(ask, connection);
                sqlDataAdapter.Fill(dataSet, "Prg");
            }
            else
            {
                MessageBox.Show("Выберите название инвентаря и выберите программу", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void WrtFFInv_Click(object sender, EventArgs e)
        {
            if (Inv.Text != "")
            {
                //string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=JOJOfit;Integrated Security=True";
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                DataSet dataSet = new DataSet();
                string ask = String.Format("exec [dbo].[WriteOffInv] '{0}'", Inv.Text);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(ask, connection);
                sqlDataAdapter.Fill(dataSet, "Prg");
                Inv.Items.Remove(Inv.Text);
                ask = String.Format("select * from Inventory");
                sqlDataAdapter = new SqlDataAdapter(ask, connection);
                sqlDataAdapter.Fill(dataSet, "inv");
                DataView.DataSource = dataSet.Tables["Inv"];
                connection.Close();
            }
            else
            {
                MessageBox.Show("Введите название инвентаря", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
