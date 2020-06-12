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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        public static bool safe_str = false;

        //public bool safe_str;
        /*
        public static bool safe_str
        {
            get { return safe_str; }
            set { safe_str = value; }
        }
        */
        public static int balance = 0;
        /*
        public int balance_str
        {
            get { return balance; }
            set { balance_str = value; }
        }
        */
        private void button1_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            if (textBox1.Text == "")
            {
                MessageBox.Show("Please enter your username");
                textBox1.Focus();
            }
            else if (textBox1.Text != "admin")
            {
                MessageBox.Show("Incorrect username");
                textBox1.Focus();
            }
            else if(textBox2.Text == "")
            {
                MessageBox.Show("Please enter your password");
                textBox2.Focus();
            }
            else if (textBox2.Text == "123456")
            {
                safe_str = true;
                balance = 1000;
                home.Show();
                this.Hide();
            }
            else if (textBox2.Text == "654321")
            {
                safe_str = false;
                balance = 0;
                home.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Incorrect password");
            }
                


            /*
             * try
            {
               username = textBox1.Text;
                string password = textBox2.Text;
                Welcome welcome = new Welcome();

                connection = new SqlConnection(conString);
                SqlDataAdapter adapter = new SqlDataAdapter("Select Count(*) From ClientData Where Username = '" + username + "' and Password ='" + password + "'", connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                if (dataTable.Rows[0][0].ToString() == "1")
                {
                    SqlDataAdapter adapter1 = new SqlDataAdapter("Select Count(*) From ClientData Where Username = '" + username + "' and Password ='" + password + "'", connection);
                    DataTable dataTable1 = new DataTable();
                    adapter1.Fill(dataTable1);
                    Client_ID = dataTable1.Rows[0][0].ToString();
                    client_id_str = Client_ID.ToString();


                    this.Hide();
                    welcome.Show();

                }
                else
                {
                    MessageBox.Show("Incorrect password or username! Please enter values again");
                    textBox1.Text = "";
                    textBox2.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
              
             */
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == false)
                textBox2.UseSystemPasswordChar = true;
            else
                textBox2.UseSystemPasswordChar = false;
        }
    }
}
