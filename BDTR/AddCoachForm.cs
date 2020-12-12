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
    public partial class AddCoachForm : Form
    {
        public AddCoachForm()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void WorkCoach_Click(object sender, EventArgs e)
        {
            if (FIOTBx.Text =="" || PstnBx.Text == "" || SLTBx.Text == "") { 
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=JOJOfit;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            DataSet dataSet = new DataSet();
            string ask = String.Format("exec [dbo].[AddStaff] '{0}','{1}', {2}, '{3}'", FIOTBx.Text, PstnBx.Text, SLTBx.Text, DateTime.Today.ToString("d"));
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(ask, connection);
            sqlDataAdapter.Fill(dataSet, "Prg");
            ask = String.Format("exec [dbo].[AddPrgrmtoStff] '{0}','{1}'", FIOTBx.Text, Program_list.Text);
            sqlDataAdapter = new SqlDataAdapter(ask, connection);
            sqlDataAdapter.Fill(dataSet, "scl");
            connection.Close();
            this.Close();
            }
            else
            {
                MessageBox.Show("Заполните все поля", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
}

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddCoachForm_Load(object sender, EventArgs e)
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

        private void FireCoach_Click(object sender, EventArgs e)
        {
            if (FIOTBx.Text == "" )
            {
                string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=JOJOfit;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            DataSet dataSet = new DataSet();
            string ask = String.Format("exec [dbo].[FireStaff] '{0}'", FIOTBx.Text);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(ask, connection);
            sqlDataAdapter.Fill(dataSet, "Prg");
            connection.Close();
            this.Close();
        }
            else
            {
                MessageBox.Show("Введите имя Тренера", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
}
    }
}
