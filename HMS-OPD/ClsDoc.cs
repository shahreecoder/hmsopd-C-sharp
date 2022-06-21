using System;
using System.Data.OleDb;
using System.Data;

namespace HMS_OPD
{
    public class ClsDoc
    {
        int _Docid;
        string _Firstname;
        string _Lastname;
        string _Address;
        string _Phone;
        string _Specialization;
        int _Fee;


        // empty constructor
        public ClsDoc()
        {
        }


        // full constructord
        public ClsDoc(int Docid, string Firstname, string Lastname, string Address, string Phone, string Specialization, int Fee)
        {
            this._Docid = Docid;
            this._Firstname = Firstname;
            this._Lastname = Lastname;
            this._Address = Address;
            this._Phone = Phone;
            this._Specialization = Specialization;
            this._Fee = Fee;
        }

        // public accessors
        public int Docid
        {
            get { return _Docid; }
            set { _Docid = value; }
        }
        public string Address
        {
            get { return _Address; }
            set { _Address = value; }
        }
        public string Firstname
        {
            get { return _Firstname; }
            set { _Firstname = value; }
        }
        public string Lastname
        {
            get { return _Lastname; }
            set { _Lastname = value; }
        }
        public string Phone
        {
            get { return _Phone; }
            set { _Phone = value; }
        }
        public string Specialization
        {
            get { return _Specialization; }
            set { _Specialization = value; }
        }
        public int Fee
        {
            get { return _Fee; }
            set { _Fee = value; }
        }
        
        public void AddDoc()
        {
            Connection c = new Connection();
            if (c.OpenConnection())
            {
                OleDbCommand MyOledbCommand = new OleDbCommand();

                MyOledbCommand.CommandText = "Insert Into Doctor (Firstname,Lastname, Address, Phone, Specialization, Fee) Values ('" + Firstname + "','" + Lastname + "','" + Address + "', '" + Phone + "', '" + Specialization + "','" + Fee + "')";
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
        /// <summary>
        /// /////////////////////////////////
        /// </summary>
        /// <returns></returns>
        /// 
        public void DeleteDoctor(int did)
        {
            Connection c = new Connection();
            if (c.OpenConnection())
            {
                OleDbCommand MyOledbCommand = new OleDbCommand();

                MyOledbCommand.CommandText = "Delete from Doctor  where Docid=" + did + "";
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
        ////////////////////////////////////////////////////
        public bool UpdateDoctor()
        {
            Connection c = new Connection();
            if (c.OpenConnection())
            {
                OleDbCommand MyOledbCommand = new OleDbCommand();
                //[date]='" + this._Date + "'
                MyOledbCommand.CommandText = "UPDATE Doctor SET Firstname='" + this._Firstname + "',Lastname='" + this._Lastname + "',Address='" + this._Address + "', Phone='" + this._Phone + "', Specialization='" + this._Specialization + "', Fee='" + this._Fee + "' where Docid=" + Docid + "";
                string re = MyOledbCommand.CommandText;
                try
                {
                    MyOledbCommand.Connection = c.MyConnection;
                    MyOledbCommand.ExecuteNonQuery();
                    c.MyConnection.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return false;
                }

            }
            return true;
        }
        /// <summary>
        /// //
        /// 
        /////////////////////////////////////
        //public bool UpdateRecordsByFamily()
        //{
        //    Connection c = new Connection();
        //    if (c.OpenConnection())
        //    {
        //        OleDbCommand MyOledbCommand = new OleDbCommand();
        //        //[date]='" + this._Date + "'
        //        MyOledbCommand.CommandText = "UPDATE TblAddNewStudent SET fathername='" + this._fathername + "' WHERE Familyno=" + Familyno + "";
        //        string re = MyOledbCommand.CommandText;
        //        try
        //        {
        //            MyOledbCommand.Connection = c.MyConnection;
        //            MyOledbCommand.ExecuteNonQuery();
        //            c.MyConnection.Close();
        //        }
        //        catch (Exception ex)
        //        {
        //            Console.WriteLine(ex.Message);
        //            return false;
        //        }

        //    }
        //    return true;
        //}
        /// ////////////////////////////////
        //public bool SearchmaxFamilyno()
        //{

        //    string query = "Select  max(Familyno)as Familyno from TblAddNewStudent";
        //    DataSet accountsData = null;
        //    OleDbDataAdapter myAdapter;
        //    Connection c = new Connection();
        //    if (c.OpenConnection())
        //    {
        //        myAdapter = new OleDbDataAdapter(query, c.MyConnection);
        //        accountsData = new DataSet();
        //        myAdapter.Fill(accountsData);

        //        if (accountsData.Tables[0].Rows.Count == 0)
        //            return false;
        //        else
        //        {
        //            DataRow dr = accountsData.Tables[0].Rows[0];

        //            if (dr["Familyno"] != DBNull.Value)
        //                this.Familyno = (int)dr["Familyno"];
        //        }
        //    }
        //    return true;
        //}
        ///////////////////////////////////////////////////////////////////////////

        public bool SearchDoctor(string CtName)
        {

            string query = "Select  * from Doctor where Firstname='" + CtName + "'";
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

                    if (dr["Docid"] != DBNull.Value)
                        this.Docid = (int)dr["Docid"];
                    if (dr["Lastname"] != DBNull.Value)
                        this.Lastname = (string)dr["Lastname"];

                    if (dr["Address"] != DBNull.Value)
                        this.Address = (string)dr["Address"];

                    if (dr["Phone"] != DBNull.Value)
                        this.Phone = (string)dr["Phone"];

                    if (dr["Specialization"] != DBNull.Value)
                    { this.Specialization = (string)dr["Specialization"]; }

                    if (dr["Fee"] != DBNull.Value)
                        this.Fee = (int)dr["Fee"];


                }


            }
            return true;
        }
        ////////////////////////////////////////////////////////////
        public bool SearchDoctorid(int CtID)
        {

            string query = "Select  * from Doctor where Docid=" + CtID + "";
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

                    if (dr["Firstname"] != DBNull.Value)
                        this.Firstname = (string)dr["Firstname"];
                    if (dr["Lastname"] != DBNull.Value)
                        this.Lastname = (string)dr["Lastname"];

                    if (dr["Address"] != DBNull.Value)
                        this.Address    = (string)dr["Address"];

                    if (dr["Phone"] != DBNull.Value)
                        this.Phone = (string)dr["Phone"];

                    if (dr["Specialization"] != DBNull.Value)
                    { this.Specialization = (string)dr["Specialization"]; }

                    if (dr["Fee"] != DBNull.Value)
                        this.Fee = (int)dr["Fee"];

                }


            }
            return true;
        }
        ////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////
    }

}
