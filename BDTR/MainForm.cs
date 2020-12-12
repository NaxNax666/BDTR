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
    public partial class MainForm : Form
        
    {
       
        public MainForm()
        {
            InitializeComponent();
        }
        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=JOJOfit;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("Select FIO from Staff", connection);
            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet, "Staff");

            string login = LoginField.Text;
            bool f = false;

            foreach (DataRow row in dataSet.Tables[0].Rows)
            {
                foreach (DataColumn column in dataSet.Tables[0].Columns)
                {
                    if (row[column].ToString() == login && PasswordField.Text =="coach")
                        f = true;
                }
            }

            ;
            connection.Close();
            if (f)
            {
                CoachForm coachForm = new CoachForm(login);
                coachForm.Show();
            }
            else
            {
                MessageBox.Show("Неверный логин или Пароль!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            connection.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            

           
            
            if (LoginField.Text == "admin" && PasswordField.Text == "admin")
            {
                ADMINChoose aDMINChoose = new ADMINChoose();
                aDMINChoose.Show();
            }
            else
            {
                MessageBox.Show("Неверный логин/пароль!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=JOJOfit;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("Select FIO from Client", connection);
            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet, "Client");
            
            string login = LoginField.Text;
            bool f=false;

            foreach (DataRow row in dataSet.Tables[0].Rows)
                {
                    foreach (DataColumn column in dataSet.Tables[0].Columns)
                    {
                    if (row[column].ToString() == login)
                    f = true;
                    }
                }
            
            ;
            connection.Close();
            if (f)
            {
                    ClientChoose clientChoose = new ClientChoose(login);
                    clientChoose.Show();
            }
            else
            {
                MessageBox.Show("Неверный логин!","Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "fitClub_primaryDataSet.Client". При необходимости она может быть перемещена или удалена.
            this.clientTableAdapter.Fill(this.fitClub_primaryDataSet.Client);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
