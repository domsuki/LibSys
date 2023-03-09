using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginRegister
{
    public partial class Registration : Form

    {
        SqlCommand cmd;
        public Registration()
        {
            InitializeComponent();
        }

        public SqlConnection cn { get; private set; }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txtUsername.Text) && !string.IsNullOrEmpty(txtPassword.Text)) 
            {
                using (cn)
                {
                    SqlConnection cn = new SqlConnection(@"Data Source=LENOVO-PC;Initial Catalog=master;Integrated Security=True");
                    cn.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO LoginandRegistration (username, password) VALUES (@username, @password)", cn);
                    cmd.Parameters.AddWithValue("@username", txtUsername.Text);
                    cmd.Parameters.AddWithValue("@password", txtPassword.Text);

                    cmd.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Registration Successful!");
                    
                }
               
            } 
            else
                {
                    MessageBox.Show("Please enter a value in both fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }



        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 login = new Form1();
            login.ShowDialog();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
