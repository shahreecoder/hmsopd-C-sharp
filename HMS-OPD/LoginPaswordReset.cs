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
    public partial class LoginPaswordReset : Form
    {
        public LoginPaswordReset()
        {
            InitializeComponent();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            LoginForm loginfrm = new LoginForm();
            loginfrm.Show(); 
            this.Hide(); 
            
        }

        private void userNametxt_Enter(object sender, EventArgs e)
        {
            if (userNametxt.Text == "USER NAME")
            {
                userNametxt.Text = "";
                userNametxt.ForeColor = Color.Black;

            }
        }

        private void userNametxt_Leave(object sender, EventArgs e)
        {
            if (userNametxt.Text == "")
            {
                userNametxt.Text = "USER NAME";
                userNametxt.ForeColor = Color.Silver;
            }
            if (userNametxt.Text != "")
            {
                usersearch usearch = new usersearch();
                usearch.SearchAppointmentname(userNametxt.Text);
                if (userNametxt.Text == usearch.username)
                {
                    pictureBox5.Show();
                    pictureBox6.Show();
                    paswordtxt.Show();
                    retypepassword.Show();
                    
                   
                }
                else
                {
                   // MessageBox.Show("Please Enter Correct User Name ", "Hospital Management (OPD)", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }

            
        }

        private void paswordtxt_Enter(object sender, EventArgs e)
        {
            if (paswordtxt.Text == "NEW PASSWORD")
            {
                paswordtxt.Text = "";
                paswordtxt.ForeColor = Color.Black;
            }
        }

        private void paswordtxt_Leave(object sender, EventArgs e)
        {
            if (paswordtxt.Text == "")
            {
                paswordtxt.Text = "NEW PASSWORD";
                paswordtxt.ForeColor = Color.Silver;
            }
        }

        private void retypepassword_Enter(object sender, EventArgs e)
        {
            if (retypepassword.Text == "RETYPE PASSWORD")
            {
                retypepassword.Text = "";
                retypepassword.ForeColor = Color.Black;
            }
        
        }

        private void retypepassword_Leave(object sender, EventArgs e)
        {
            if (retypepassword.Text == "")
            {
                retypepassword.Text = "RETYPE PASSWORD";
                retypepassword.ForeColor = Color.Silver;
            }
        }

        private void LoginPaswordReset_Load(object sender, EventArgs e)
        {
            pictureBox5.Hide();
            pictureBox6.Hide();
            paswordtxt.Hide();
            retypepassword.Hide();
        }

        private void userNametxt_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == (char)Keys.Enter)
            {


                if (userNametxt.Text != "")
                {
                    usersearch usearch = new usersearch();
                    usearch.SearchAppointmentname(userNametxt.Text);
                    if (userNametxt.Text == usearch.username)
                    {
                        pictureBox5.Show();
                        pictureBox6.Show();
                        paswordtxt.Show();
                        retypepassword.Show();

                    }
                    else
                    {
                        MessageBox.Show("Please Enter Correct User Name ", "Hospital Management (OPD)", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
                
            }
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            usersearch paswordupdate = new usersearch();
            if (paswordtxt.Text != "")
            {
                if (paswordtxt.Text == retypepassword.Text)
                {
                    paswordupdate.username = userNametxt.Text;
                    paswordupdate.userpasword = paswordtxt.Text;
                    paswordupdate.Updateuserinfo();
                    MessageBox.Show("Pasword Has Been Changed ", "Hospital Management (OPD)", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    userNametxt.Text = "";
                    paswordtxt.Text = "";
                    retypepassword.Text = "";
                }
                else
                {
                    MessageBox.Show("Pasword Does not Match ", "Hospital Management (OPD)", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    paswordtxt.Text = "";
                    retypepassword.Text = "";
                    paswordtxt.Focus();
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginForm loginfrm = new LoginForm();
            loginfrm.Show();
            this.Hide(); 
        }

        private void userNametxt_TextChanged(object sender, EventArgs e)
        {

        }
        }
    }

