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
    public partial class adduser : Form
    {
        ListViewItem item3;
        public adduser()
        {
            InitializeComponent();
        }


        private void ViewsAddress()
        {
            string query = "Select * from userinfo ";

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


                    item3 = new ListViewItem(row["userid"].ToString());
                    item3.SubItems.Add(row["username"].ToString());
                    item3.SubItems.Add(row["userpasword"].ToString());
                    

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

            ColumnHeader header0 = this.listView8.Columns.Add("UserID", 6 * Convert.ToInt32(listView8.Font.SizeInPoints), HorizontalAlignment.Left);
            ColumnHeader header1 = this.listView8.Columns.Add("User Name", 15 * Convert.ToInt32(listView8.Font.SizeInPoints), HorizontalAlignment.Left);
            ColumnHeader header2 = this.listView8.Columns.Add("Password", 15 * Convert.ToInt32(listView8.Font.SizeInPoints), HorizontalAlignment.Left);
            

        }







        private void button2_Click(object sender, EventArgs e)
        {
            if (txtid.Text == "")
            {
                usersearch add = new usersearch();
                add.username = textBox1.Text;
                add.userpasword = textBox2.Text;
                add.AddAppointment();
                MessageBox.Show("Record has Added Successfully", "Hospital Management (OPD)", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox1.Text = "";
                textBox2.Text = "";
                ViewsAddress();

            }
            else
            {
                usersearch update = new usersearch();
                update.userid=Convert.ToInt32( txtid.Text) ;
                update.username=textBox1.Text  ;
                update.userpasword=textBox2.Text;
                update.Updateuserinfoid(); 
                MessageBox.Show("Record has Updated Successfully", "Hospital Management (OPD)", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtid.Text = "";
                textBox1.Text = "";
                textBox2.Text = "";
                ViewsAddress();
            }

        }

        private void adduser_Load(object sender, EventArgs e)
        {
            ViewAddress();
            ViewsAddress();
        }

        private void listView8_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            foreach (ListViewItem item in listView8.Items)
            {
                if (item.Checked)
                {
                    txtid.Text = "";
                    textBox1.Text = "";
                    textBox2.Text = "";

                    txtid.Text = item.SubItems[0].Text.ToString();
                    textBox1.Text = item.SubItems[1].Text.ToString();
                    textBox2.Text = item.SubItems[2].Text.ToString();
                    
                    //txtfname.Focus();
                    item.Checked = false;

                    break;

                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            usersearch delete = new usersearch();
            delete.userid = Convert.ToInt32(txtid.Text);
            delete.Deleteuser();
            MessageBox.Show("Record has Deleted Successfully", "Hospital Management (OPD)", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtid.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
            ViewsAddress();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }
    }
}
