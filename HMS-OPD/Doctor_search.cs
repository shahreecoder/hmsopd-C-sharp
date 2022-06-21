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
    public partial class Doctor_search : Form
    {
        public Doctor_search()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void searchtxt_Enter(object sender, EventArgs e)
        {
            if (searchtxt.Text == "Enter Doctor Name or Doctor ID")
            {
                searchtxt.Text = "";
                searchtxt.ForeColor = Color.Black;

            }
        }

        private void searchtxt_Leave(object sender, EventArgs e)
        {

            if (searchtxt.Text == "")
            {
                searchtxt.Text = "Enter Doctor Name or Doctor ID";
                searchtxt.ForeColor = Color.Silver;
            }
        }

        private void Doctor_search_Load(object sender, EventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
        {
            if(rbid.Checked==true)
            {
            if (searchtxt.Text != " " && searchtxt.Text != "Enter Doctor Name or Doctor ID")
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


                
                
                    ClsDoc search = new ClsDoc();
                    search.SearchDoctorid(Convert.ToInt32(searchtxt.Text));
                    txtid.Text = searchtxt.Text;
                    txtfname.Text = search.Firstname;
                    txtlname.Text = search.Lastname;
                    txtaddress.Text = search.Address;
                    txtphone.Text = search.Phone;
                    txtspeci.Text = search.Specialization;
                    txtfees.Text = search.Fee.ToString();
                


            }
            else if (searchtxt.Text == " " || searchtxt.Text == "Enter Doctor Name or Doctor ID")
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
                MessageBox.Show("Please Enter Doctor Name or Doctor ID", "Hospital Management (OPD)", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            }
            else if (rbname.Checked == true)
            {
                if (searchtxt.Text != " " && searchtxt.Text != "Enter Doctor Name or Doctor ID")
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




                    ClsDoc searchname = new ClsDoc();
                    searchname.SearchDoctor(searchtxt.Text);
                    txtid.Text = searchname.Docid.ToString();
                    txtfname.Text = searchtxt.Text;
                    txtlname.Text = searchname.Lastname;
                    txtaddress.Text = searchname.Address;
                    txtphone.Text = searchname.Phone;
                    txtspeci.Text = searchname.Specialization;
                    txtfees.Text = searchname.Fee.ToString();


                }
                else if (searchtxt.Text == " " || searchtxt.Text == "Enter Doctor Name or Doctor ID")
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
                    MessageBox.Show("Please Enter Doctor Name or Doctor ID", "Hospital Management (OPD)", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void searchtxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                button2.Focus();
            }

        }

        
    }
}
