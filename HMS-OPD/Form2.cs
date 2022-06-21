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
    public partial class Form2 : Form
    {
        public Form2(string uname)
        {
            InitializeComponent();
            label11.Text = uname;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if (label11.Text == "root" || label11.Text == "admin")
            {
                btnadduser.Show();

            }
            else
            {
                btnadduser.Hide(); 

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            this.Close();
            LoginForm login = new LoginForm();
            login.Show();
            


        }

        private void button1_Click(object sender, EventArgs e)
        {
           // this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Add_Delete_Patient adpatient = new Add_Delete_Patient();
            adpatient.ShowDialog();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Add_Delete_Doctor addoc = new Add_Delete_Doctor();
            addoc.ShowDialog();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Add_Delete_Appointment adapp = new Add_Delete_Appointment();
            adapp.ShowDialog();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Doctor_search dsearch = new Doctor_search();
            dsearch.ShowDialog();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Patient_search psearch = new Patient_search();
            psearch.ShowDialog();
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {

            //Application.Exit();


        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Appointment_search appsearch = new Appointment_search();
            appsearch.ShowDialog(); 
        }

        private void label11_Click(object sender, EventArgs e)
        {
            
        }

        private void btnadduser_Click(object sender, EventArgs e)
        {
            adduser frmadd = new adduser();
            frmadd.ShowDialog(); 
        }
    }
}
