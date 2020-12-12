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
    public partial class OtherForm : Form
    {
        public OtherForm()
        {
            InitializeComponent();
        }

        public OtherForm(string st)
        {
            InitializeComponent();
            Coachshow.Hide();
            Invbutton.Hide();
        }
        private void ClientCheck_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=JOJOfit;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            DataSet dataSet = new DataSet();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select Client.FIO,title,[Длина в месяцах], Оплачено from Client left join Enable_program on Client.FIO = Enable_program.FIO", connection);
            sqlDataAdapter.Fill(dataSet, "Prg");
            Showdata.DataSource = dataSet.Tables[0];
            connection.Close();
            
        }

        private void showProgram_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=JOJOfit;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            DataSet dataSet = new DataSet();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select Title, [Тренер], [Длина в месяцах], [Полная стоимость программы], [dbo].[ProgSum](Title) as Себестоимость from Avaliable_Program", connection);
            sqlDataAdapter.Fill(dataSet, "Prg");
            Showdata.DataSource = dataSet.Tables[0];
            connection.Close();
        }

        private void OtherForm_Load(object sender, EventArgs e)
        {
            
        }

        private void Coachshow_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=JOJOfit;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            DataSet dataSet = new DataSet();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select * from Staff", connection);
            sqlDataAdapter.Fill(dataSet, "Prg");
            Showdata.DataSource = dataSet.Tables[0];
            connection.Close();
        }

        private void Invbutton_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=JOJOfit;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            DataSet dataSet = new DataSet();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select * from InvLook", connection);
            sqlDataAdapter.Fill(dataSet, "Prg");
            Showdata.DataSource = dataSet.Tables[0];
            connection.Close();
        }
    }
}
