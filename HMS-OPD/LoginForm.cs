using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HMS_OPD
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            
        }
        public string user;

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
             
            usersearch userinfo = new usersearch();
            userinfo.SearchAppointmentname(userNametxt.Text);

            if (userNametxt.Text==userinfo.username &&paswordtxt.Text==userinfo.userpasword )
            {
                Form2 home = new Form2(userNametxt.Text);
                home.Show();
                this.Hide();
                userNametxt.Text = user; 
                
            }
            else
            {
                MessageBox.Show("Wrong User Name Or Pasword", "Hospital Management (OPD)", MessageBoxButtons.OK, MessageBoxIcon.Error);
                userNametxt.Text = "USER NAME";
                userNametxt.ForeColor = Color.Silver;
                paswordtxt.Text = "PASSWORD";
                paswordtxt.ForeColor = Color.Silver;
                userNametxt.Focus();

            }
            

           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            LoginPaswordReset passwordreset = new LoginPaswordReset();
            passwordreset.Show();
            this.Hide();
           // MessageBox.Show("Page is Not Created Yet", "Hospital Management (OPD)", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void userNametxt_DragEnter(object sender, DragEventArgs e)
        {
          
        }

        private void userNametxt_Enter(object sender, EventArgs e)
        {
            if (userNametxt.Text == "USER NAME")
            {
                userNametxt.Text = "";
                userNametxt.ForeColor = Color.Black;

            }
        }

        private void userNametxt_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void userNametxt_Leave(object sender, EventArgs e)
        {
            if (userNametxt.Text == "")
            {
                userNametxt.Text = "USER NAME";
                userNametxt.ForeColor = Color.Silver;
            }
        }

        private void paswordtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void paswordtxt_Enter(object sender, EventArgs e)
        {
            if (paswordtxt.Text == "PASSWORD")
            {
                paswordtxt.Text = "";
                paswordtxt.ForeColor = Color.Black;
            }

        }

        private void paswordtxt_Leave(object sender, EventArgs e)
        {
            if (paswordtxt.Text == "")
            {
                paswordtxt.Text = "PASSWORD";
                paswordtxt.ForeColor = Color.Silver;
            }
        }

        private void btnlogin_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void btnlogin_Enter(object sender, EventArgs e)
        {
           
        }

        private void LoginForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void userNametxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                paswordtxt.Focus();
            }
        }

        private void paswordtxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnlogin.Focus();
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
