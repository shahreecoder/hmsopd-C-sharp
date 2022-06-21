using System;
using System.Data.OleDb;
using System.Data;

namespace HMS_OPD
{
    public class ClsAppointment
    {
        int _AID;
        int _Docid;
        int _PID;
        string _Adate;

        // empty constructor
        public ClsAppointment()
        {
        }


        // full constructor
        public ClsAppointment(int AID, int Docid, int PID, string Adate)
        {
            this._AID = AID;
            this._Docid = Docid;
            this._PID = PID;
            this._Adate = Adate;
        }

        // public accessors
        public int AID
        {
            get { return _AID; }
            set { _AID = value; }
        }
        public int PID
        {
            get { return _PID; }
            set { _PID = value; }
        }
        public int Docid
        {
            get { return _Docid; }
            set { _Docid = value; }
        }
        public string Adate
        {
            get { return _Adate; }
            set { _Adate = value; }
        }

        public void AddAppointment()
        {
            Connection c = new Connection();
            if (c.OpenConnection())
            {
                OleDbCommand MyOledbCommand = new OleDbCommand();

                MyOledbCommand.CommandText = "Insert Into Appointment (Docid,PID, Adate) Values ('" + Docid + "','" + PID + "','" + Adate+ "')";
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
        //public voAID DeleteAppointment()
        //{
        //    Connection c = new Connection();
        //    if (c.OpenConnection())
        //    {
        //        OleDbCommand MyOledbCommand = new OleDbCommand();

        //        MyOledbCommand.CommandText = "Delete from TblAddNewStudent";
        //        string s = MyOledbCommand.CommandText;
        //        try
        //        {
        //            MyOledbCommand.Connection = c.MyConnection;
        //            MyOledbCommand.ExecuteNonQuery();
        //            c.MyConnection.Close();
        //        }
        //        catch (Exception ex)
        //        {
        //            Console.WriteLine(ex.Message);

        //        }

        //    }

        //}
        ////////////////////////////////////////////////////
        public bool UpdateAppointment()
        {
            Connection c = new Connection();
            if (c.OpenConnection())
            {
                OleDbCommand MyOledbCommand = new OleDbCommand();
                //[date]='" + this._Date + "'
                MyOledbCommand.CommandText = "UPDATE Appointment SET Docid='" + this._Docid + "',PID='" + this._PID + "' ,Adate='" + this._Adate + "'where AID=" + AID + "";
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

        public bool SearchAppointment(string CtName)
        {

            string query = "Select  * from Appointment where Docid='" + CtName + "'";
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

                    if (dr["AID"] != DBNull.Value)
                        this.AID = (int)dr["AID"];


                }


            }
            return true;
        }
        ////////////////////////////////////////////////////////////
        public bool SearchAppointment(int CtID)
        {

            string query = "Select  * from Appointment where AID=" + CtID + "";
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


                }


            }
            return true;
        }
        ////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////
    }

}
