using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BDTR
{
    public partial class CoachForm : Form
    {
        private string coachLogin;
        public CoachForm()
        {
            InitializeComponent();
        }
        public CoachForm(string inp)
        {
            InitializeComponent();
            coachLogin = inp;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OtherForm otherForm = new OtherForm("ffd");
            otherForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddClientForm addClientForm = new AddClientForm(coachLogin);
            addClientForm.Show();
        }
    }
}
