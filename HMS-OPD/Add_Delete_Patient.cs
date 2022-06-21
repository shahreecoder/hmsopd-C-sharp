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
    public partial class Add_Delete_Patient : Form
    {
        ListViewItem item3;
        public Add_Delete_Patient()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ClsPatient patient = new ClsPatient();
            if (txtid.Text == "")
            {
                patient.Firstname = txtfname.Text;
                patient.Lastname = txtlname.Text;
                patient.Address = txtaddress.Text;
                patient.Phone = txtph.Text;
                patient.CNIC = txtcnic.Text;
                patient.Gender = txtgender.Text;
                patient.DOB = dateTimePicker.Value;
                patient.AddPatient();
                MessageBox.Show("Record has Added Successfully", "Hospital Management (OPD)", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtfname.Text = "";
                txtlname.Text = "";
                txtaddress.Text = "";
                txtph.Text = "";
                txtcnic.Text = "";
                txtgender.Text = "";
                ViewsAddress();
            }
            else
            {
                ClsPatient patientupdate = new ClsPatient();

                patientupdate.PID = Convert.ToInt32(txtid.Text);
                patientupdate.Firstname = txtfname.Text;
                patientupdate.Lastname = txtlname.Text;
                patientupdate.Address = txtaddress.Text;
                patientupdate.Phone = txtph.Text;
                patientupdate.CNIC = txtcnic.Text;
                patientupdate.Gender = txtgender.Text;
                patientupdate.DOB = dateTimePicker.Value;
                patientupdate.UpdatePatient();
                MessageBox.Show("Record Updated Successfully", "Hospital Management (OPD)", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtid.Text = "";
                txtfname.Text = "";
                txtlname.Text = "";
                txtaddress.Text = "";
                txtph.Text = "";
                txtcnic.Text = "";
                txtgender.Text = "";
                dateTimePicker.Text = "";
                ViewsAddress();
            }
        }
        private void ViewsAddress()
        {
            string query = "Select * from Patient ";

            DataSet Chenabdata = null;
            OleDbDataAdapter myAdapter;
            Connection c = new Connection();
            if (c.OpenConnection())
            {
                myAdapter = new OleDbDataAdapter(query, c.MyConnection);
                Chenabdata = new DataSet();
                myAdapter.Fill(Chenabdata);
            }
            listView8.Items.Clear();
            // Repeat for each table in the DataSet's table collection.
            foreach (DataTable table in Chenabdata.Tables)
            {
                int ct = 1;
                // Repeat for each row in the table.
                foreach (DataRow row in table.Rows)
                {


                    item3 = new ListViewItem(row["PID"].ToString());
                    item3.SubItems.Add(row["Firstname"].ToString());
                    item3.SubItems.Add(row["Lastname"].ToString());
                    item3.SubItems.Add(row["Address"].ToString());
                    item3.SubItems.Add(row["Phone"].ToString());
                    item3.SubItems.Add(row["CNIC"].ToString());
                    item3.SubItems.Add(row["DOB"].ToString());
                    item3.SubItems.Add(row["Gender"].ToString());



                    listView8.Items.AddRange(new ListViewItem[] { item3 });
                    //lblNoOfRecords.Text=ct.ToString();
                    //if (ct % 2 == 0)
                    //{
                    //    //listView8.BackColor=Color.Beige;
                    //    item3.BackColor = Color.White;
                    //    item3.ForeColor = Color.Black;
                    //}
                    //else
                    //{
                    //    item3.BackColor = Color.Orange;
                    //    item3.ForeColor = Color.White;
                    //}
                    ct += 1;
                }
            }
        }
        ////////////////////////////////////////////////////////////////////////
        public void ViewAddress()
        {

            ColumnHeader header0 = this.listView8.Columns.Add("PID", 6 * Convert.ToInt32(listView8.Font.SizeInPoints), HorizontalAlignment.Left);
            ColumnHeader header1 = this.listView8.Columns.Add("First Name", 15 * Convert.ToInt32(listView8.Font.SizeInPoints), HorizontalAlignment.Left);
            ColumnHeader header2 = this.listView8.Columns.Add("Last Name", 15 * Convert.ToInt32(listView8.Font.SizeInPoints), HorizontalAlignment.Left);
            ColumnHeader header3 = this.listView8.Columns.Add("Address", 15 * Convert.ToInt32(listView8.Font.SizeInPoints), HorizontalAlignment.Left);
            ColumnHeader header4 = this.listView8.Columns.Add("Phone", 15 * Convert.ToInt32(listView8.Font.SizeInPoints), HorizontalAlignment.Left);
            ColumnHeader header5 = this.listView8.Columns.Add("CNIC", 15 * Convert.ToInt32(listView8.Font.SizeInPoints), HorizontalAlignment.Left);
            ColumnHeader header6 = this.listView8.Columns.Add("DOB", 8 * Convert.ToInt32(listView8.Font.SizeInPoints), HorizontalAlignment.Left);
            ColumnHeader header7 = this.listView8.Columns.Add("Gender", 8 * Convert.ToInt32(listView8.Font.SizeInPoints), HorizontalAlignment.Left);

        }
        private void Add_Delete_Patient_Load(object sender, EventArgs e)
        {

            ViewsAddress();
            ViewAddress();
        }

        private void txtfname_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtfname_Enter(object sender, EventArgs e)
        {
            ViewsAddress();
        }

        private void listView8_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            

        }

        private void txtid_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtid_Leave(object sender, EventArgs e)
        {
            if (txtid.Text != "")
            {
                ClsPatient search = new ClsPatient();
                search.SearchPatient(Convert.ToInt32(txtid.Text));
                txtfname.Text = search.Firstname;
                txtlname.Text = search.Lastname;
                txtaddress.Text = search.Address;
                txtph.Text = search.Phone;
                txtcnic.Text = search.CNIC;
                txtgender.Text = search.Gender;
                dateTimePicker.Text = search.DOB.ToString();
            }

        }

        private void Add_Delete_Patient_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (txtid.Text != "")
                {
                    ClsPatient search = new ClsPatient();
                    search.SearchPatient(Convert.ToInt32(txtid.Text));
                    txtfname.Text = search.Firstname;
                    txtlname.Text = search.Lastname;
                    txtaddress.Text = search.Address;
                    txtph.Text = search.Phone;
                    txtcnic.Text = search.CNIC;
                    txtgender.Text = search.Gender;
                    dateTimePicker.Text = search.DOB.ToString();
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ClsPatient delete = new ClsPatient();
            delete.DeletePatient(Convert.ToInt32(txtid.Text));
            MessageBox.Show("Record has Deleted Successfully", "Hospital Management (OPD)", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ViewsAddress();
            txtid.Text = "";
            txtfname.Text = "";
            txtlname.Text = "";
            txtaddress.Text = "";
            txtph.Text = "";
            txtcnic.Text = "";
            txtgender.Text = "";
        }

        private void listView8_ItemChecked(object sender, ItemCheckedEventArgs e)
        {

            foreach (ListViewItem item in listView8.Items)
            {
                if (item.Checked)
                {
                    txtid.Text = "";
                    txtfname.Text = "";
                    txtlname.Text = "";
                    txtaddress.Text = "";
                    txtph.Text = "";
                    txtcnic.Text = "";
                    txtgender.Text = "";
                    dateTimePicker.Text = "";

                    txtid.Text = item.SubItems[0].Text.ToString();
                    txtfname.Text = item.SubItems[1].Text.ToString();
                    txtlname.Text = item.SubItems[2].Text.ToString();
                    txtaddress.Text = item.SubItems[3].Text.ToString();
                    txtph.Text = item.SubItems[4].Text.ToString();
                    txtcnic.Text = item.SubItems[5].Text.ToString();
                    dateTimePicker.Text = item.SubItems[6].Text.ToString();
                    txtgender.Text = item.SubItems[7].Text.ToString();
                    txtfname.Focus();
                    item.Checked = false;

                    break;

                }
            }


        }
    }
}