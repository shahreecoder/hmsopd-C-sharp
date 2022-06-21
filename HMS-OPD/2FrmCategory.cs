using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace ProPOS
{
    public partial class FrmCategory : Form
    {
        ListViewItem item3; int i;
        public FrmCategory()
        {
            InitializeComponent();
        }

        private void btnhome_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void ViewsCategory()
        {
            string query = "Select * from TblCategory ";

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


                    item3 = new ListViewItem(row["CatID"].ToString());
                    item3.SubItems.Add(row["CatName"].ToString());
                    item3.SubItems.Add(row["Status"].ToString());
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
        public void ViewCategory()
        {

            ColumnHeader header0 = this.listView8.Columns.Add("نمبر", 7 * Convert.ToInt32(listView8.Font.SizeInPoints), HorizontalAlignment.Left);
            ColumnHeader header1 = this.listView8.Columns.Add("نام", 11* Convert.ToInt32(listView8.Font.SizeInPoints), HorizontalAlignment.Left);
            ColumnHeader header2 = this.listView8.Columns.Add("موجودگی", 7 * Convert.ToInt32(listView8.Font.SizeInPoints), HorizontalAlignment.Left);
        }
        private void btnsave_Click(object sender, EventArgs e)
        {
            ClsCategory cc = new ClsCategory();
            if (txtname.Text == "" || cmbstatus.Text == "")
            {
                MessageBox.Show("Enter Category/Status", "کتاب گھر اسٹیشنرزاینڈ فوٹو اسٹیٹ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (txtno.Text == "")
                {

                    cc.CatName = txtname.Text;
                    cc.Status = cmbstatus.Text;
                    cc.AddCategory();
                    ViewsCategory();
                    txtno.Text = "";
                    txtname.Text = "";
                    txtname.Focus();
                }
                else
                {
                    cc.CatID = Convert.ToInt16(txtno.Text);
                    cc.CatName = txtname.Text;
                    cc.Status = cmbstatus.Text;
                    cc.UpdateCategory();
                    ViewsCategory();
                    txtno.Text = "";
                    txtname.Text = "";
                    txtno.Text = "";
                    txtname.Focus();
                }
            }
        }

        private void listView8_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            i = 0;

            foreach (ListViewItem item in listView8.Items)
            {
                if (item.Checked)
                {
                    txtno.Text = "";
                    txtname.Text = "";
                    cmbstatus.Text = "";
                    txtno.Text = item.SubItems[0].Text.ToString();
                    txtname.Text = item.SubItems[1].Text.ToString();
                    cmbstatus.Text = item.SubItems[2].Text.ToString();
                    //txtamount.Text = item.SubItems[3].Text.ToString();
                    txtname.Focus();
                    item.Checked = false;
                    i += 1;

                    break;

                }


            }
        }
        public static InputLanguage GetInputLanguageByName(string inputName)
        {
            foreach (InputLanguage lang in InputLanguage.InstalledInputLanguages)
            {
                if (lang.Culture.EnglishName.ToLower().StartsWith(inputName))
                {
                    return lang;
                }
            }
            return null;
        }
        private void SetKeyboardLayout(InputLanguage layout)
        {
            InputLanguage.CurrentInputLanguage = layout;
        }
        private void txtname_Enter(object sender, EventArgs e)
        {
            ViewsCategory();
            //SetKeyboardLayout(GetInputLanguageByName("eng"));
            SetKeyboardLayout(GetInputLanguageByName("ur"));
        }

        private void FrmCategory_Load(object sender, EventArgs e)
        {
            ViewCategory();
            ViewsCategory();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                cmbstatus.Focus();
            }
        }

        private void cmbstatus_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnsave.Focus();
            }
        }

        private void cmbstatus_Enter(object sender, EventArgs e)
        {
            //SetKeyboardLayout(GetInputLanguageByName("eng"));
            SetKeyboardLayout(GetInputLanguageByName("ur"));
        }

        private void listView8_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        
    }
}
