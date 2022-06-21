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
    public partial class Add_Delete_Appointment : Form
    {
        ListViewItem item3;
        private DataViewManager DOC;
        private DataViewManager PI;
        public Add_Delete_Appointment()
        {
            InitializeComponent();
        }

        private void txtfees_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ClsAppointment ap = new ClsAppointment();
            ap.Docid = int.Parse (txtdocid.Text);
            ap.PID = int.Parse(txtpid.Text);
            ap.Adate = AdatePicker.Text;
            ap.AddAppointment();
            MessageBox.Show("Record has Added Successfully", "Hospital Management (OPD)", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtdocid.Text = "";
            txtpid.Text = "";
            ViewsAddress();


        }
        private void ViewsAddress()
        {
            string query = "Select * from ViewDocAppointment ";

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


                    item3 = new ListViewItem(row["Doctor.Firstname"].ToString());
                    item3.SubItems.Add(row["Specialization"].ToString());
                    item3.SubItems.Add(row["Patient.Firstname"].ToString());
                    item3.SubItems.Add(row["Gender"].ToString());
                    item3.SubItems.Add(row["Fee"].ToString());
                    item3.SubItems.Add(row["Adate"].ToString());

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

            ColumnHeader header0 = this.listView8.Columns.Add("Doctor Name", 15 * Convert.ToInt32(listView8.Font.SizeInPoints), HorizontalAlignment.Left);
            ColumnHeader header1 = this.listView8.Columns.Add("Specialization", 15 * Convert.ToInt32(listView8.Font.SizeInPoints), HorizontalAlignment.Left);
            ColumnHeader header2 = this.listView8.Columns.Add("Patient Name", 13 * Convert.ToInt32(listView8.Font.SizeInPoints), HorizontalAlignment.Left);
            ColumnHeader header3 = this.listView8.Columns.Add("Gender", 10 * Convert.ToInt32(listView8.Font.SizeInPoints), HorizontalAlignment.Left);
            ColumnHeader header4 = this.listView8.Columns.Add("Fee", 6 * Convert.ToInt32(listView8.Font.SizeInPoints), HorizontalAlignment.Left);
            ColumnHeader header5 = this.listView8.Columns.Add("Check-Up date", 15 * Convert.ToInt32(listView8.Font.SizeInPoints), HorizontalAlignment.Left);

        }
        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void Add_Delete_Appointment_Load(object sender, EventArgs e)
        {
            ViewAddress();
            ViewsAddress();
            Doctor();
            Patient();
            cmbdoctor.Focus();
        }

        private void txtdocid_Enter(object sender, EventArgs e)
        {
            ViewsAddress();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void Doctor()
        {
            string query = " SELECT * from Doctor";

            //string query = "select * from tblBankTransaction";
            DataSet Chenabdata = null;
            OleDbDataAdapter myAdapter;
            Connection c = new Connection();
            if (c.OpenConnection())
            {
                myAdapter = new OleDbDataAdapter(query, c.MyConnection);
                Chenabdata = new DataSet();
                myAdapter.TableMappings.Add("Table", "Doctor");
                myAdapter.Fill(Chenabdata);
                this.DOC = Chenabdata.DefaultViewManager;
                this.cmbdoctor.DataSource = this.DOC;
                this.cmbdoctor.ValueMember = "Doctor.Docid";
                this.cmbdoctor.DisplayMember = "Doctor.Firstname";
                

            }

        }

        private void Patient()
        {
            string query = " SELECT * from Patient";

            //string query = "select * from tblBankTransaction";
            DataSet Chenabdata = null;
            OleDbDataAdapter myAdapter;
            Connection c = new Connection();
            if (c.OpenConnection())
            {
                myAdapter = new OleDbDataAdapter(query, c.MyConnection);
                Chenabdata = new DataSet();
                myAdapter.TableMappings.Add("Table", "Patient");
                myAdapter.Fill(Chenabdata);
                this.PI = Chenabdata.DefaultViewManager;
                this.cmbpatient.DataSource = this.PI;
                this.cmbpatient.ValueMember = "Patient.PID";
                this.cmbpatient.DisplayMember = "Patient.Firstname";


            }

        }


        private void cmbdoctor_Leave(object sender, EventArgs e)
        {
            
        }

        private void cmbpatient_Leave(object sender, EventArgs e)
        {
            txtpid.Text = cmbpatient.SelectedValue.ToString();
        }

        private void cmbdoctor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbpatient_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbdoctor_Enter(object sender, EventArgs e)
        {

        }

        private void cmbdoctor_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        //private void cmbdoctor_DropDownClosed(object sender, EventArgs e)
        //{
        //    txtdocid.Text = cmbdoctor.SelectedValue.ToString();
        //    ClsDoc search = new ClsDoc();
        //    search.SearchDoctor(cmbdoctor.Text);
        //    txtdocspeci.Text = search.Specialization;
        //    txtfees.Text = search.Fee.ToString();
        //}

        private void cmbdoctor_DropDownClosed_1(object sender, EventArgs e)
        {
            txtdocid.Text = cmbdoctor.SelectedValue.ToString();
            ClsDoc search = new ClsDoc();
            search.SearchDoctor(cmbdoctor.Text);
            txtdocspeci.Text = search.Specialization;
            txtfees.Text = search.Fee.ToString();
        }

        private void cmbpatient_DropDownClosed(object sender, EventArgs e)
        {
            txtpid.Text = cmbpatient.SelectedValue.ToString();
            ClsPatient searchp = new ClsPatient();
            searchp.SearchPatient(cmbpatient.Text);
            txtpgender.Text = searchp.Gender;
            txtpdob.Text = searchp.DOB.ToString("dd-MM-yyyy");
        }

        private void listView8_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}

