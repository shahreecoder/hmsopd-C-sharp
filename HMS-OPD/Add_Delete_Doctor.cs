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
    public partial class Add_Delete_Doctor : Form

    {
        ListViewItem item3; 
        public Add_Delete_Doctor()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ClsDoc doc = new ClsDoc();
            if (txtid.Text == "")
            {
                doc.Firstname = txtfname.Text;
                doc.Lastname = txtlname.Text;
                doc.Address = txtaddress.Text;
                doc.Phone = txtphone.Text;
                doc.Specialization = txtspeci.Text;
                doc.Fee = int.Parse(txtfees.Text);
                doc.AddDoc();
                MessageBox.Show("Record has Added Successfully", "Hospital Management (OPD)", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtfname.Text = "";
                txtlname.Text = "";
                txtaddress.Text = "";
                txtphone.Text = "";
                txtspeci.Text = "";
                txtfees.Text = "";
                ViewsAddress();
            }
            else
            {
                ClsDoc docupdate = new ClsDoc();
                docupdate.Docid = Convert.ToInt32(txtid.Text);
                docupdate.Firstname = txtfname.Text;
                docupdate.Lastname = txtlname.Text;
                docupdate.Address = txtaddress.Text;
                docupdate.Phone = txtphone.Text;
                docupdate.Specialization = txtspeci.Text;
                docupdate.Fee = int.Parse(txtfees.Text);
                docupdate.UpdateDoctor();
                MessageBox.Show("Record has Updated Successfully", "Hospital Management (OPD)", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtid.Text = "";
                txtfname.Text = "";
                txtlname.Text = "";
                txtaddress.Text = "";
                txtphone.Text = "";
                txtspeci.Text = "";
                txtfees.Text = "";
                ViewsAddress();
            }
        }
        private void ViewsAddress()
        {
            string query = "Select * from Doctor ";

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


                    item3 = new ListViewItem(row["Docid"].ToString());
                    item3.SubItems.Add(row["Firstname"].ToString());
                    item3.SubItems.Add(row["Lastname"].ToString());
                    item3.SubItems.Add(row["Address"].ToString());
                    item3.SubItems.Add(row["Phone"].ToString());
                    item3.SubItems.Add(row["Specialization"].ToString());
                    item3.SubItems.Add(row["Fee"].ToString());

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

            ColumnHeader header0 = this.listView8.Columns.Add("DocID", 6 * Convert.ToInt32(listView8.Font.SizeInPoints), HorizontalAlignment.Left);
            ColumnHeader header1 = this.listView8.Columns.Add("First Name", 15 * Convert.ToInt32(listView8.Font.SizeInPoints), HorizontalAlignment.Left);
            ColumnHeader header2 = this.listView8.Columns.Add("Last Name", 15 * Convert.ToInt32(listView8.Font.SizeInPoints), HorizontalAlignment.Left);
            ColumnHeader header3 = this.listView8.Columns.Add("Address", 15 * Convert.ToInt32(listView8.Font.SizeInPoints), HorizontalAlignment.Left);
            ColumnHeader header4 = this.listView8.Columns.Add("Phone", 15 * Convert.ToInt32(listView8.Font.SizeInPoints), HorizontalAlignment.Left);
            ColumnHeader header5 = this.listView8.Columns.Add("Specialization", 15 * Convert.ToInt32(listView8.Font.SizeInPoints), HorizontalAlignment.Left);
            ColumnHeader header6 = this.listView8.Columns.Add("Fees", 8 * Convert.ToInt32(listView8.Font.SizeInPoints), HorizontalAlignment.Left);
            

        }

        private void txtspeci_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Add_Delete_Doctor_Load(object sender, EventArgs e)
        {
            txtfname.Focus();
            ViewAddress();
            ViewsAddress();
        }

        private void txtlname_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtfees_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtphone_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtaddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtfname_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtid_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (txtid.Text != "")
            {
                
            }
        }

        private void txtfname_Enter(object sender, EventArgs e)
        {
            //ViewsAddress();
        }

        private void txtid_Enter(object sender, EventArgs e)
        {
           
        }

        private void txtid_Leave(object sender, EventArgs e)
        {

            if (txtid.Text != "")
            {
                ClsDoc search = new ClsDoc();
                search.SearchDoctorid(Convert.ToInt32(txtid.Text));
                txtfname.Text = search.Firstname;
                txtlname.Text = search.Lastname;
                txtaddress.Text = search.Address;
                txtphone.Text = search.Phone;
                txtspeci.Text = search.Specialization;
                txtfees.Text = search.Fee.ToString();
            }
            if (txtid.Text == "")
            {
                
                txtfname.Text = "";
                txtlname.Text = "";
                txtaddress.Text = "";
                txtphone.Text = "";
                txtspeci.Text = "";
                txtfees.Text = "";
            }
        }

        private void txtid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if(txtid.Text!="")
                {
                ClsDoc search = new ClsDoc();
                search.SearchDoctorid(Convert.ToInt32(txtid.Text));
                txtfname.Text = search.Firstname;
                txtlname.Text = search.Lastname;
                txtaddress.Text = search.Address;
                txtphone.Text = search.Phone;
                txtspeci.Text = search.Specialization;
                txtfees.Text = search.Fee.ToString();
                 }
            }
        }

        private void txtfname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (txtfname.Text != "")
                {
                    ClsDoc search = new ClsDoc();
                    search.SearchDoctor(txtfname.Text);
                    txtid.Text = search.Docid.ToString();
                    //txtfname.Text = search.Firstname;
                    txtlname.Text = search.Lastname;
                    txtaddress.Text = search.Address;
                    txtphone.Text = search.Phone;
                    txtspeci.Text = search.Specialization;
                    txtfees.Text = search.Fee.ToString();
                }
            }
        }

        private void listView8_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            ClsDoc delete = new ClsDoc();
            delete.DeleteDoctor(Convert.ToInt32(txtid.Text));
            MessageBox.Show("Record has Deleted Successfully", "Hospital Management (OPD)", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ViewsAddress();
            txtid.Text = "";
            txtfname.Text = "";
            txtlname.Text = "";
            txtaddress.Text = "";
            txtphone.Text = "";
            txtspeci.Text = "";
            txtfees.Text = "";
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
                    txtphone.Text = "";
                    txtspeci.Text = "";
                    txtfees.Text = "";
                    

                    txtid.Text = item.SubItems[0].Text.ToString();
                    txtfname.Text = item.SubItems[1].Text.ToString();
                    txtlname.Text = item.SubItems[2].Text.ToString();
                    txtaddress.Text = item.SubItems[3].Text.ToString();
                    txtphone.Text = item.SubItems[4].Text.ToString();
                    txtspeci.Text = item.SubItems[5].Text.ToString();
                    txtfees.Text = item.SubItems[6].Text.ToString();
                    txtfname.Focus();
                    item.Checked = false;

                    break;

                }
            }
        }
    }
}
