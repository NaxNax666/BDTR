using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BDTR
{
    public partial class ClientChoose : Form
    {
        private string clientName;
        public ClientChoose()
        {
            InitializeComponent();
        }
        public ClientChoose(string cn)
        {
            InitializeComponent();
            clientName = cn;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=JOJOfit;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string ask = "select * from [dbo].[MyContract]('" + clientName + "')";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(ask, connection);
            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet, "ClPg");
            dataGridView1.DataSource = dataSet.Tables[0];
            connection.Close();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ClientChoose_Load(object sender, EventArgs e)
        {

        }

        private void NewProgramButton_Click(object sender, EventArgs e)
        {
            Contractfrom contractfrom = new Contractfrom(clientName);
            contractfrom.Show();
        }
    }
}
