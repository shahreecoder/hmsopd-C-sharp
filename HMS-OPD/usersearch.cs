using System;
using System.Data.OleDb;
using System.Data;

namespace HMS_OPD
{
    public class usersearch
    {
        int _userid;
        string _username;
        string _userpasword;

        // empty constructor
        public usersearch()
        {
        }


        // full constructor
        public usersearch(int userid, string username, string userpasword)
        {
            this._userid = userid;
            this._username = username;
            this._userpasword = userpasword;
        }

        // public accessors
        public int userid
        {
            get { return _userid; }
            set { _userid = value; }
        }
       
        public string username
        {
            get { return _username; }
            set { _username = value; }
        }
        public string userpasword
        {
            get { return _userpasword; }
            set { _userpasword = value; }
        }

        public void AddAppointment()
        {
            Connection c = new Connection();
            if (c.OpenConnection())
            {
                OleDbCommand MyOledbCommand = new OleDbCommand();

                MyOledbCommand.CommandText = "Insert Into userinfo (username, userpasword) Values ('" + username+ "','" + userpasword + "')";
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
        public void Deleteuser()
        {
            Connection c = new Connection();
            if (c.OpenConnection())
            {
                OleDbCommand MyOledbCommand = new OleDbCommand();

                MyOledbCommand.CommandText = "Delete from userinfo where userid=" + userid + "";
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
        //////////////////////////////////////////////////
        public bool Updateuserinfo()
        {
            Connection c = new Connection();
            if (c.OpenConnection())
            {
                OleDbCommand MyOledbCommand = new OleDbCommand();
                //[date]='" + this._Date + "'
                MyOledbCommand.CommandText = "UPDATE userinfo SET userpasword='" + this._userpasword + "' where username='" + username + "'";
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



        public bool Updateuserinfoid()
        {
            Connection c = new Connection();
            if (c.OpenConnection())
            {
                OleDbCommand MyOledbCommand = new OleDbCommand();
                //[date]='" + this._Date + "'
                MyOledbCommand.CommandText = "UPDATE userinfo SET username='" + this._username + "',userpasword='" + this._userpasword + "' where userid=" + userid + "";
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

        public bool SearchAppointmentname(string CtName)
        {

            string query = "Select  * from userinfo where username='" + CtName + "'";
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

                    if (dr["username"] != DBNull.Value)
                        this.username = (string)dr["username"];
                    if (dr["userpasword"] != DBNull.Value)
                        this.userpasword = (string)dr["userpasword"];
                    


                }


            }
            return true;
        }
        ////////////////////////////////////////////////////////////
        public bool SearchAppointment(int CtID)
        {

            string query = "Select  * from userinfo where userid=" + CtID + "";
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

                    if (dr["userid"] != DBNull.Value)
                        this.userid = (int)dr["userid"];


                }


            }
            return true;
        }
        ////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////
    }

}
