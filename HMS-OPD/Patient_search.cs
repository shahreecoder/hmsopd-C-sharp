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
    public partial class Patient_search : Form
    {
        public Patient_search()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void searchtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void Patient_search_Load(object sender, EventArgs e)
        {

            label2.Hide();
            label3.Hide();
            label4.Hide();
            label5.Hide();
            label6.Hide();
            label7.Hide();
            label8.Hide();
            panel4.Hide();
            panel5.Hide();
            panel6.Hide();
            panel7.Hide();
            panel8.Hide();
            panel9.Hide();
            panel10.Hide();
            txtid.Hide();
            txtfname.Hide();
            txtlname.Hide();
            txtphone.Hide();
            txtspeci.Hide();
            txtaddress.Hide();
            txtfees.Hide();

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (rbid.Checked == true)
            {
                if (searchtxt.Text != " " && searchtxt.Text != "Enter Patient Name or Patient ID")
                {

                    label2.Show();
                    label3.Show();
                    label4.Show();
                    label5.Show();
                    label6.Show();
                    label7.Show();
                    label8.Show();
                    panel4.Show();
                    panel5.Show();
                    panel6.Show();
                    panel7.Show();
                    panel8.Show();
                    panel9.Show();
                    panel10.Show();
                    txtid.Show();
                    txtfname.Show();
                    txtlname.Show();
                    txtphone.Show();
                    txtspeci.Show();
                    txtaddress.Show();
                    txtfees.Show();

                    ClsPatient search = new ClsPatient();
                    search.SearchPatient(Convert.ToInt32(searchtxt.Text));
                    txtid.Text = searchtxt.Text;
                    txtfname.Text = search.Firstname;
                    txtlname.Text = search.Lastname;
                    txtaddress.Text = search.Address;
                    txtphone.Text = search.Phone;
                    txtspeci.Text = search.Gender;
                    txtfees.Text = search.DOB.ToString("dd-MM-yyyy");

                }
            }

            else if (searchtxt.Text == " " || searchtxt.Text == "Enter Patient Name or Patient ID")
            {

                label2.Hide();
                label3.Hide();
                label4.Hide();
                label5.Hide();
                label6.Hide();
                label7.Hide();
                label8.Hide();
                panel4.Hide();
                panel5.Hide();
                panel6.Hide();
                panel7.Hide();
                panel8.Hide();
                panel9.Hide();
                panel10.Hide();
                txtid.Hide();
                txtfname.Hide();
                txtlname.Hide();
                txtphone.Hide();
                txtspeci.Hide();
                txtaddress.Hide();
                txtfees.Hide();
                MessageBox.Show("Please Enter Patient Name or Patient ID", "Hospital Management (OPD)", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            else if (rbname.Checked == true)
            {
                if (searchtxt.Text != " " && searchtxt.Text != "Enter Patient Name or Patient ID")
                {

                    label2.Show();
                    label3.Show();
                    label4.Show();
                    label5.Show();
                    label6.Show();
                    label7.Show();
                    label8.Show();
                    panel4.Show();
                    panel5.Show();
                    panel6.Show();
                    panel7.Show();
                    panel8.Show();
                    panel9.Show();
                    panel10.Show();
                    txtid.Show();
                    txtfname.Show();
                    txtlname.Show();
                    txtphone.Show();
                    txtspeci.Show();
                    txtaddress.Show();
                    txtfees.Show();

                    ClsPatient search = new ClsPatient();
                    search.SearchPatient(searchtxt.Text);
                    txtid.Text = search.PID.ToString();

                    txtfname.Text = searchtxt.Text;
                    txtlname.Text = search.Lastname;
                    txtaddress.Text = search.Address;
                    txtphone.Text = search.Phone;
                    txtspeci.Text = search.Gender;
                    txtfees.Text = search.DOB.ToString("dd-MM-yyyy");
                }
                else if (searchtxt.Text == " " || searchtxt.Text == "Enter Patient Name or Patient ID")
                {

                    label2.Hide();
                    label3.Hide();
                    label4.Hide();
                    label5.Hide();
                    label6.Hide();
                    label7.Hide();
                    label8.Hide();
                    panel4.Hide();
                    panel5.Hide();
                    panel6.Hide();
                    panel7.Hide();
                    panel8.Hide();
                    panel9.Hide();
                    panel10.Hide();
                    txtid.Hide();
                    txtfname.Hide();
                    txtlname.Hide();
                    txtphone.Hide();
                    txtspeci.Hide();
                    txtaddress.Hide();
                    txtfees.Hide();
                    MessageBox.Show("Please Enter Patient Name or Patient ID", "Hospital Management (OPD)", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void searchtxt_Enter(object sender, EventArgs e)
        {
            if (searchtxt.Text == "Enter Patient Name or Patient ID")
            {
                searchtxt.Text = "";
                searchtxt.ForeColor = Color.Black;

            }
        }

        private void searchtxt_Leave(object sender, EventArgs e)
        {
            if (searchtxt.Text == "")
            {
                searchtxt.Text = "Enter Patient Name or Patient ID";
                searchtxt.ForeColor = Color.Silver;
            }
        }
      }

   }
