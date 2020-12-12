using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BDTR
{
    public partial class Contractfrom : Form
    {
        private string clientName;
        private DataSet currDataSet = new DataSet();
        public Contractfrom()
        {
            InitializeComponent();
        }
        public Contractfrom(string cn)
        {
            InitializeComponent();
            clientName = cn;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=JOJOfit;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string ask = String.Format("select Title, duration, cost_month*{0} as total from Program_list where Title='{1}'", textBox1.Text, Program_list.Text);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(ask, connection);
            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet, "Prg");
            sqlDataAdapter.Fill(currDataSet, "Prg");
            dataGridView1.DataSource = dataSet.Tables[0];
            connection.Close();
            ContractAccept.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<string> st = new List<string>();

            foreach (DataRow row in currDataSet.Tables[0].Rows)
            {
                foreach (DataColumn column in currDataSet.Tables[0].Columns)
                {
                    st.Add(row[column].ToString());
                }
            }
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=JOJOfit;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string ask = String.Format("exec [dbo].[AddContract] '{0}','{1}',{2}", clientName,st[0],st[1]);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(ask, connection);
            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet, "Prg");

            connection.Close();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Offer_Button_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=JOJOfit;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string ask = "select * from [dbo].[offerprog]('" + clientName + "')";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(ask, connection);
            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet, "ClPg");
            dataGridView1.DataSource = dataSet.Tables[0];
            connection.Close();
        }

        private void Contractfrom_Load(object sender, EventArgs e)
        {
            
            // TODO: данная строка кода позволяет загрузить данные в таблицу "fitClub_primaryDataSet.Program_list". При необходимости она может быть перемещена или удалена.
            this.program_listTableAdapter.Fill(this.fitClub_primaryDataSet.Program_list);
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
            ContractAccept.Enabled = false;
        }
    }
}
