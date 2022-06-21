using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace HMS_OPD
{
    public partial class Appointment_search : Form
    {
        public Appointment_search()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close(); 

        }

        private void searchtxt_Enter(object sender, EventArgs e)
        {
            if (searchtxt.Text == "Enter Appointment ID")
            {
                searchtxt.Text = "";
                searchtxt.ForeColor = Color.Black;

            }
        }

        private void searchtxt_Leave(object sender, EventArgs e)
        {
            if (searchtxt.Text == "")
            {
                searchtxt.Text = "Enter Appointment ID";
                searchtxt.ForeColor = Color.Silver;
            }
        }


        public bool SearchAppointment()
        {

            string query = "Select  * from AppointmentSearch where AID=" + searchtxt.Text + "";
            DataSet accountsData = null;
            OleDbDataAdapter myAdapter;
            Connection c = new Connection();
            if (c.OpenConnection())
            {
                myAdapter = new OleDbDataAdapter(query, c.MyConnection);
                accountsData = new DataSet();
                myAdapter.Fill(accountsData);

                if (accountsData.Tables[0].Rows.Count == 0)
                    return false;
                else
                {
                    DataRow dr = accountsData.Tables[0].Rows[0];

                    if (dr["Doctor.Firstname"] != DBNull.Value)
                        this.txtdname.Text = (string)dr["Doctor.Firstname"];

                    if (dr["Specialization"] != DBNull.Value)
                        this.txtsep.Text = (string)dr["Specialization"];

                    if (dr["Fee"] != DBNull.Value)
                    {
                        
                        fees = (int)dr["Fee"];
                        txtfees.Text = fees.ToString();
                    }
                    if (dr["Patient.Firstname"] != DBNull.Value)
                        this.txtpname.Text = (string)dr["Patient.Firstname"];

                    if (dr["Gender"] != DBNull.Value)
                        this.txtgender.Text = (string)dr["Gender"];

                    if (dr["DOB"] != DBNull.Value)
                    {
                        dob = (DateTime)dr["DOB"];
                        txtdob.Text = dob.ToString("dd-MM-yyyy");

                    }
                    if (dr["Adate"] != DBNull.Value)
                    {
                        Adate = (DateTime)dr["Adate"];
                        txtadate.Text = Adate.ToString("dd-MM-yyyy");

                    }

                }


            }
            return true;
        }



        private void Appointment_search_Load(object sender, EventArgs e)
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
            txtdname.Hide();
            txtpname.Hide();
            txtsep.Hide();
            txtfees.Hide();
            txtgender.Hide();
            txtdob.Hide();
            txtadate.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (searchtxt.Text != " " && searchtxt.Text != "Enter Appointment ID")
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
                txtdname.Show();
                txtpname.Show();
                txtsep.Show();
                txtfees.Show();
                txtgender.Show();
                txtdob.Show();
                txtadate.Show();
                SearchAppointment();
            }
            else if (searchtxt.Text == " " || searchtxt.Text == "Enter Appointment ID")
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
                txtdname.Hide();
                txtpname.Hide();
                txtsep.Hide();
                txtfees.Hide();
                txtgender.Hide();
                txtdob.Hide();
                txtadate.Hide();
                MessageBox.Show("Please Enter Appointment ID ", "Hospital Management (OPD)", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        public int fees 
        {
            get; 
             set;
        }

        public DateTime dob
        {
            get;
            set;
        }
        public DateTime Adate
        {
            get;
            set;
        }
        public void DeleteAppointment()
        {
            Connection c = new Connection();
            if (c.OpenConnection())
            {
                OleDbCommand MyOledbCommand = new OleDbCommand();

                MyOledbCommand.CommandText = "Delete from Appointment where AID=" + searchtxt.Text + "";
                string s = MyOledbCommand.CommandText;
                try
                {
                    MyOledbCommand.Connection = c.MyConnection;
                    MyOledbCommand.ExecuteNonQuery();
                    c.MyConnection.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);

                }

            }

        }
        
        private void button4_Click(object sender, EventArgs e)
        {
            DeleteAppointment();
            MessageBox.Show("Record has Deleted Successfully", "Hospital Management (OPD)", MessageBoxButtons.OK, MessageBoxIcon.Information);
            searchtxt.Text = "Enter Appointment ID";
            searchtxt.ForeColor = Color.Silver;
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
            txtdname.Hide();
            txtpname.Hide();
            txtsep.Hide();
            txtfees.Hide();
            txtgender.Hide();
            txtdob.Hide();
            txtadate.Hide();
        }

        private void printappointment_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Image image = HMS_OPD.Properties.Resources.doctor_icon;
            e.Graphics.DrawImage(image, 80, 40, image.Width, image.Height);
            e.Graphics.DrawString("PUNJAB HOSPITAL (OPD)",new Font ("Arial", 30, FontStyle.Bold),Brushes.Black, new Point(200,30));

            e.Graphics.DrawString("MODEL TOWN, LAHORE", new Font("Arial",12 , FontStyle.Bold), Brushes.Black, new Point(350, 80));
            e.Graphics.DrawString("TELEPHONE: 03058382300", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(320, 110));
            e.Graphics.DrawString("EMALE: SVGABOY@GMAIL.COM", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(325, 140));
            e.Graphics.DrawString("Appointment No: " + searchtxt.Text+ "", new Font("Arial", 25, FontStyle.Bold), Brushes.Black, new Point(320, 180));
            e.Graphics.DrawString("-------------------------------------------------------------------------------", new Font("Arial", 25, FontStyle.Regular), Brushes.Black, new Point(0, 210));
            e.Graphics.DrawString("-------------------------------------------------------------------------------", new Font("Arial", 25, FontStyle.Regular), Brushes.Black, new Point(0, 220));
            e.Graphics.DrawString("DOCTOR NAME:   "+txtdname.Text+" ", new Font("Arial", 13, FontStyle.Bold), Brushes.Black, new Point(10, 260));
            e.Graphics.DrawString("CHECK UP FEES:  " + txtfees.Text + " ", new Font("Arial", 13, FontStyle.Bold), Brushes.Black, new Point(580, 260));
            e.Graphics.DrawString("PATIENT NAME:   " + txtpname.Text + " ", new Font("Arial", 13, FontStyle.Bold), Brushes.Black, new Point(10, 290));
            e.Graphics.DrawString("PATIENT DOB:    " + txtdob.Text + " ", new Font("Arial", 13, FontStyle.Bold), Brushes.Black, new Point(580, 290));
            e.Graphics.DrawString("PATIENT GENDER:  " + txtgender.Text + " ", new Font("Arial", 13, FontStyle.Bold), Brushes.Black, new Point(10, 320));
            e.Graphics.DrawString("APPOINTMENT DATE:  " + txtadate.Text + " ", new Font("Arial", 13, FontStyle.Bold), Brushes.Black, new Point(330, 360));
            e.Graphics.DrawString("-------------------------------------------------------------------------------", new Font("Arial", 25, FontStyle.Regular), Brushes.Black, new Point(0, 380));
            e.Graphics.DrawString("-------------------------------------------------------------------------------", new Font("Arial", 25, FontStyle.Regular), Brushes.Black, new Point(0, 390));
        }

        private void button5_Click(object sender, EventArgs e)
        {

            printPreviewDialog.Document = printappointment;
            printPreviewDialog.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            printappointment.Print();
            
        }
    }
}
