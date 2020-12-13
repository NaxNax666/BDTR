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

    public partial class AddClientForm : Form
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["BDTR.Properties.Settings.FitClub_primaryConnectionString"].ConnectionString;
        private string Cname;
        public AddClientForm()
        {
            InitializeComponent();
        }
        public AddClientForm(string log)
        {
            InitializeComponent();
            Cname = log;
            CLNTDEL.Hide();

        }

        private void ELikelabel_Click(object sender, EventArgs e)
        {

        }

        private void ContractAccept_Click(object sender, EventArgs e)
        {
            if (FIOTBx.Text != ""|| PhNTBx.Text != ""|| MainLike.Text != "")
            {
                //string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=JOJOfit;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            DataSet dataSet = new DataSet();
            string ask = String.Format("exec [dbo].[AddClient] '{0}','{1}', '{2}'", FIOTBx.Text, PhNTBx.Text, MainLike.Text);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(ask, connection);
            sqlDataAdapter.Fill(dataSet, "Prg"); 
            char[] separators = new char[] { ' ', ',' };
            string[] subs = ExtraLike.Text.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            foreach (string buff in subs)
            {
                if(MainLike.Items.Contains(buff))
                { ask = String.Format("exec [dbo].[AddUserlike] '{0}','{1}'",buff, FIOTBx.Text);
                    sqlDataAdapter = new SqlDataAdapter(ask, connection);
                    sqlDataAdapter.Fill(dataSet, "Lik");
                    
                }
            }
            connection.Close();
            this.Close();
            }
            else
            {
                MessageBox.Show("Заполните все поля", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddClientForm_Load(object sender, EventArgs e)
        {
            //string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=JOJOfit;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            DataSet dataSet = new DataSet();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select Like_name from Likes_list", connection);
            sqlDataAdapter.Fill(dataSet, "Lik");
            foreach (DataRow row in dataSet.Tables["Lik"].Rows)
            {
                foreach (DataColumn column in dataSet.Tables[0].Columns)
                {
                  
                    MainLike.Items.Add(row[column].ToString());
                }
            }
        }

        private void CLNTDEL_Click(object sender, EventArgs e)
        {
            if (FIOTBx.Text != "") { 

            //string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=JOJOfit;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            DataSet dataSet = new DataSet();
            string ask = String.Format("exec [dbo].[DelClnt] '{0}'", FIOTBx.Text);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(ask, connection);
            sqlDataAdapter.Fill(dataSet, "Prg");
            connection.Close();
            this.Close();
            }
            else
            {
                MessageBox.Show("Введите имя Клиента", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
}

        private void AddLike_Button_Click(object sender, EventArgs e)
        {
            if (FIOTBx.Text != "" || ExtraLike.Text!="") {
                //string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=JOJOfit;Integrated Security=True";
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                DataSet dataSet = new DataSet();

                SqlDataAdapter sqlDataAdapter;
                string ask;
                char[] separators = new char[] { ' ', ',' };
                string[] subs = ExtraLike.Text.Split(separators, StringSplitOptions.RemoveEmptyEntries);
                foreach (string buff in subs)
                {
                    if (MainLike.Items.Contains(buff))
                    {
                        ask = String.Format("exec [dbo].[AddUserlike] '{0}','{1}'", buff, FIOTBx.Text);
                        sqlDataAdapter = new SqlDataAdapter(ask, connection);
                        sqlDataAdapter.Fill(dataSet, "Lik");

                    }
                }
                connection.Close();
                this.Close(); 
            }
            else
            {
                MessageBox.Show("Введите клиента и предпочтение", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
