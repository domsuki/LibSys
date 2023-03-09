using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LoginRegister
{
    public partial class Form1 : Form
    {
        private SqlCommand cmd;
        private SqlConnection cn;

        public Form1()
        {
            InitializeComponent();
            cn = new SqlConnection(@"Data Source=LENOVO-PC;Initial Catalog=master;Integrated Security=True");
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                cn.Open();
                cmd = new SqlCommand("SELECT * FROM LoginandRegistration WHERE username = @username AND password = @password", cn);
                cmd.Parameters.AddWithValue("@password", txtPass.Text);
                cmd.Parameters.AddWithValue("@username", txtUser.Text);

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    MessageBox.Show("Welcome!");
                    mainDashboard dashboard = new mainDashboard();
                    dashboard.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid username or password!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                cn.Close();
            }

            Console.WriteLine("Query: " + cmd.CommandText);
            Console.WriteLine("Username: " + txtUser.Text);
            Console.WriteLine("Password: " + txtPass.Text);
        }
        private void btnRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registration registration = new Registration();
            registration.ShowDialog();
            this.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
