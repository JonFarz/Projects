using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Data.Sql;
using System.Windows.Forms;

namespace WindowsFormsApplication1.Functions
{
    class DataConnect 
    {
        private SqlConnection SC =  new SqlConnection();
        public int pOrF = 0;
        
        /*public void SetLogin(Login T)
        {
            this.L = T;
        }*/

        public List<string> GetDatabases()
        {
            List<string> DBs = new List<string>();
            int i = 0;

            using (SqlCommand SQ = new SqlCommand("select Database_Name from sys.master.databases", ConnectionMan))
            using (SqlDataReader DR = SQ.ExecuteReader())
            {
                while (DR.Read())
                {
                    DBs[i] = DR.GetString(0);
                    i++;
                }
            }

            return DBs;
        }
       
        public SqlConnection ConnectionMan
        {
            get { return this.SC; }
        }

        public void SetServer(string Server)
        {
            string ConnectString = "Data Source=" + Server + ";Initial Catalog=master;User ID=" + Login.UserName + ";Password=" + Login.ConvertToUnsecureString() + "";

            try
            {
                ConnectionMan.ConnectionString = ConnectString;
                ConnectionMan.Open();
            }
            catch (SqlException exd)
            {

                MessageBox.Show(exd.Message, "SQL Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Argument Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ChangeDB(string database)
        {
            try
            {
                ConnectionMan.ChangeDatabase(database);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Failure to Change Databases",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        public void ChangeServer(string Server)
        {
            string ConnectString = "Data Source=" + Server + ";Initial Catalog=master;User ID=" + Login.UserName + ";Password=" + Login.ConvertToUnsecureString() + "";

            try
            {
                ConnectionMan.ConnectionString=ConnectString;
                //ConnectionMan.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Failed To Change Servers",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        public void SendSql(string sql)
        {
            using (SqlCommand SQ = new SqlCommand(sql, ConnectionMan))
            using (SqlDataReader SDR = SQ.ExecuteReader())
            {
                while (SDR.Read())
                {
                    Console.WriteLine("{0}", SDR.GetString(0));
                }
            }
        }

    }
}
