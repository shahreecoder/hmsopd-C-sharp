using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace HMS_OPD
{
	/// <summary>
	/// Summary description for Connection.
	/// </summary>
	public class Connection
	{
        private OleDbConnection myConnection; 

        public string a;
		public Connection()
		{
			//
			// TODO: Add constructor logic here
			//
		}
		public OleDbConnection MyConnection
		{
			get{return myConnection;}
			set{myConnection=value;}
		}
		public bool OpenConnection()
		{
           // string connectionString;
			bool val=false;
			try
			{
                //if (a == 1)
                //{
                //string connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;User ID=Admin;Data Source=//server1/Chenab/Chenab.mdb";
                //string connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=\\serverName\shareName\folder\myDatabase.mdb;User Id=admin;Password=";
                //}
                //else if (a == 2)
                //{
                string connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;User ID=Admin;Data Source=" + Application.StartupPath + "\\OPD.mdb;";
                //}
				myConnection = new OleDbConnection( connectionString );
				myConnection.Open();
				MyConnection=myConnection;
				val=true;
			}
			catch(Exception ex)
			{
                MessageBox.Show(ex.Message,"HMS OPD",MessageBoxButtons.OK,MessageBoxIcon.Error);
				val=false;
			}
			return val;
		}

        
	}
}
