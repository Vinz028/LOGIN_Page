using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        
        private string correctUsername = "admin";
        private string correctPassword = "admin";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();
            ErrorMessage.Text = "";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string enteredUsername = txtUsername.Text;
            string enteredPassword = txtPassword.Text;

            // Validate login credentials
            if (enteredUsername == correctUsername && enteredPassword == correctPassword)
            {
                // Login successful
                MessageBox.Show("Login successful! Welcome " + enteredUsername, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Login failed, display error message
                ErrorMessage.Text = "Invalid username or password.";
                ErrorMessage.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void ErrorMessage_Click(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
