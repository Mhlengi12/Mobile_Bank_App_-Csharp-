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
    public partial class Pay : Form
    {
        public Pay()
        {
            InitializeComponent();
        }

        private void Pay_Load(object sender, EventArgs e)
        {
            label8.Text = Login.balance.ToString("c2");

            listBox1.Items.Clear();
            listBox1.Items.Add("R 10 for " + Buy.item.ToString());
            listBox1.Items.Add("R 20 for " + Buy.item.ToString());
            listBox1.Items.Add("R 50 for " + Buy.item.ToString());
            listBox1.Items.Add("R 100 for " + Buy.item.ToString());
            listBox1.Items.Add("R 200 for " + Buy.item.ToString());
        }

        int price;

        private void button1_Click(object sender, EventArgs e)
        {
            

            if(listBox1.SelectedIndex < 0)
            {
                MessageBox.Show("Please select purchase value");
            }
            else
            {
                if (listBox1.SelectedIndex == 1)
                    price = 10;
                if (listBox1.SelectedIndex == 2)
                    price = 20;
                if (listBox1.SelectedIndex == 3)
                    price = 50;
                if (listBox1.SelectedIndex == 4)
                    price = 100;
                if (listBox1.SelectedIndex == 5)
                    price = 200;

                if (Login.balance < price)
                    MessageBox.Show("Insufficient funds");
                else
                {
                    Login.balance -= price;
                    MessageBox.Show("Succesfull purchase");
                }
                    
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Transaction trans = new Transaction();
            trans.Show();
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Transaction trans = new Transaction();
            trans.Show();
            this.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Buy buy = new Buy();
            buy.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Buy buy = new Buy();
            buy.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            lg.Show();
            this.Close();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            lg.Show();
            this.Close();
        }
    }
}
