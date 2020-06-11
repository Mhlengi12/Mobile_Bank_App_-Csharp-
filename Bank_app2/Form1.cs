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

        public static bool safe = false;

        //public bool safe_str;

        public bool safe_str
        {
            get { return safe_str; }
            set { safe = value; }
        }

        public static int balance = 0;
        public int balance_str
        {
            get { return balance; }
            set { balance_str = value; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Home home = new Home();

            if (textBox2.Text == "123456")
            {
                safe = true;
                balance = 1000;
                home.Show();
                this.Close();
            }
            else if (textBox2.Text == "654321")
            {
                safe = false;
                balance = 0;
                home.Show();
                this.Close();
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
    }
}
