using System;
using System.Data.OleDb;
using System.Data;

namespace HMS_OPD
{
    public class ClsPatient
    {
        int _PID;
        string _Firstname;
        string _Lastname;
        string _Address;
        string _Phone;
        string _CNIC;
        string _Gender;
        DateTime _DOB;


        // empty constructor
        public ClsPatient()
        {
        }


        // full constructord
        public ClsPatient(int PID, string Firstname, string Lastname, string Address, string Phone, string CNIC, string Gender, DateTime DOB)
        {
            this._PID = PID;
            this._Firstname = Firstname;
            this._Lastname = Lastname;
            this._Address = Address;
            this._Phone = Phone;
            this._CNIC = CNIC;
            this._Gender = Gender;
            this._DOB = DOB;

        }

        // public accessors
        public int PID
        {
            get { return _PID; }
            set { _PID = value; }
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
        public string CNIC
        {
            get { return _CNIC; }
            set { _CNIC = value; }
        }
        public string Gender
        {
            get { return _Gender; }
            set { _Gender = value; }
        }
        public DateTime DOB
        {
            get { return _DOB; }
            set { _DOB = value; }
        }
        public void AddPatient()
        {
            Connection c = new Connection();
            if (c.OpenConnection())
            {
                OleDbCommand MyOledbCommand = new OleDbCommand();

                MyOledbCommand.CommandText = "Insert Into Patient (Firstname,Lastname, Address, Phone, CNIC, Gender, DOB) Values ('" + Firstname + "','" + Lastname + "','" + Address + "', '" + Phone + "', '" + CNIC + "', '" + Gender + "', '" + DOB + "')"; 
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
        public void DeletePatient(int pid)
        {
            Connection c = new Connection();
            if (c.OpenConnection())
            {
                OleDbCommand MyOledbCommand = new OleDbCommand();

                MyOledbCommand.CommandText = "Delete from Patient where PID=" + pid + "";
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
        public bool UpdatePatient()
        {
            Connection c = new Connection();
            if (c.OpenConnection())
            {
                OleDbCommand MyOledbCommand = new OleDbCommand();
                //[date]='" + this._Date + "'
                MyOledbCommand.CommandText = "UPDATE Patient SET Firstname='" + this._Firstname + "',Lastname='" + this._Lastname + "',Address='" + this._Address + "', Phone='" + this._Phone + "', CNIC='" + this._CNIC + "', Gender='" + this._Gender + "', DOB='" + this._DOB + "' where PID=" + PID + "";
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

        public bool SearchPatient(string Firstname)
        {

            string query = "Select  * from Patient where Firstname='" + Firstname + "'";
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

                    if (dr["PID"] != DBNull.Value)
                        this.PID = (int)dr["PID"];

                    if (dr["Lastname"] != DBNull.Value)
                        this.Lastname = (string)dr["Lastname"];

                    if (dr["Address"] != DBNull.Value)
                        this.Address = (string)dr["Address"];

                    if (dr["Phone"] != DBNull.Value)
                        this.Phone = (string)dr["Phone"];

                    if (dr["CNIC"] != DBNull.Value)
                        this.CNIC = (string)dr["CNIC"];

                    if (dr["Gender"] != DBNull.Value)
                        this.Gender = (string)dr["Gender"];

                     if (dr["DOB"] != DBNull.Value)
                         this.DOB = (DateTime)dr["DOB"];


                }


            }
            return true;
        }
        ////////////////////////////////////////////////////////////
        public bool SearchPatient(int PID)
        {

            string query = "Select  * from Patient where PID=" + PID + "";
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
                        this.Address = (string)dr["Address"];

                    if (dr["Phone"] != DBNull.Value)
                        this.Phone = (string)dr["Phone"];

                    if (dr["CNIC"] != DBNull.Value)
                        this.CNIC = (string)dr["CNIC"];

                    if (dr["Gender"] != DBNull.Value)
                        this.Gender = (string)dr["Gender"];

                    if (dr["DOB"] != DBNull.Value)
                        this.DOB = (DateTime)dr["DOB"];

                    
                }


            }
            return true;
        }
        ////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////

        
    }

}
