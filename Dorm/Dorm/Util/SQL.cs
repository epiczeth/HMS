using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;

namespace Dorm.Util
{
 internal   class SQL
    {
     private OleDbConnection GetConnection()
     {
         OleDbConnection conn = new OleDbConnection();
         try
         {
             if (conn.State != ConnectionState.Closed)
             {
                 conn.Close();
             }
             conn.ConnectionString = string.Format("Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0}\\dorm.accdb;Persist Security Info=False;", Environment.CurrentDirectory);
             conn.Open();
         }
         catch (Exception e)
         {
             System.Diagnostics.Debug.WriteLine(e.Message);
         }
             return conn;
       
     }
     internal bool IsExistingUser(string user,string pass)
     {
         bool flag = false;
         try
         {
             OleDbCommand cmd = new OleDbCommand(string.Format("select count(*) from tb_users where [username]='{0}' and [password]='{1}'", user, pass), GetConnection());
             flag = ((int)cmd.ExecuteScalar() > 0) ? true : false;
         }catch(Exception e)
         {
             System.Diagnostics.Debug.WriteLine(e.Message);
         }
         return flag;
     }
    }
}
