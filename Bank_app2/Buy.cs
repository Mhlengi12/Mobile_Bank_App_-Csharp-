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
    public partial class Buy : Form
    {
        public Buy()
        {
            InitializeComponent();
        }

        private void paypage()
        {
            Pay pay = new Pay();
            pay.Show();
            this.Hide();

        }

        public static string item = "Airtime";
        /*
        public string item_str
        {
            get { return item; }
            set { item_str = value; }
        }
        */
        private void label10_Click(object sender, EventArgs e)
        {
            paypage();
            item = "Airtime";
        }

        private void label9_Click(object sender, EventArgs e)
        {
            paypage();
            item = "Data";
        }

        private void label8_Click(object sender, EventArgs e)
        {
            paypage();
            item = "Electricity";
        }

        private void label7_Click(object sender, EventArgs e)
        {
            paypage();
            item = "Beneficiary";
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            paypage();
            item = "Airtime";
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            paypage();
            item = "Data";
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            paypage();
            item = "Electricity";
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            paypage();
            item = "Beneficiary";
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            lg.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            lg.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Transaction trans = new Transaction();
            trans.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Transaction trans = new Transaction();
            trans.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Pay pay = new Pay();
            pay.Show();
            this.Hide();
        }

        private void Buy_Load(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {
            paypage();
            item = "Beneficiary ";
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Pay pay = new Pay();
            pay.Show();
            this.Hide();
        }
    }
}
