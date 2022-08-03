using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using DemakVenturesPOSSoftware.General;

namespace DemakVenturesPOSSoftware
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2ShadowPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
           
        }

        private void LoginGradientButton_Click(object sender, EventArgs e)
        {
            if(IsValid())
            {
                using (SqlConnection con = new SqlConnection(ApplicationSetting.ConnectionString()))
                {
                      using(SqlCommand cmd = new SqlCommand("usp_Login_VerifyLoginDetails", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@UserName", UsernameTextBox.Text.Trim());
                        cmd.Parameters.AddWithValue("Password", PasswordTextBox.Text.Trim());

                        con.Open();

                        SqlDataReader sdr = cmd.ExecuteReader();

                        if(sdr.Read())
                        {
                           
                        }
                        else
                        {
                            MessageBox.Show("User Name or Password is incorrect", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private bool IsValid()
        {
            if(UsernameTextBox.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Username is required", "Form Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
            }

            if (PasswordTextBox.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Password is required", "Form Validation Error" , MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
            }

            return true;
        }

        private void CreateAccountButton_Click(object sender, EventArgs e)
        {
            Register2 f1 = new Register2();
            f1.ShowDialog();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
