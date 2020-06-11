using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank_app2
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            label8.Text = Login.balance.ToString("c2");
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            lg.Show();
            this.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            lg.Show();
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Transaction trans = new Transaction();
            trans.Show();
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Transaction trans = new Transaction();
            trans.Show();
            this.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Pay pay = new Pay();
            pay.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Pay pay = new Pay();
            pay.Show();
            this.Hide();
        }
    }
}
