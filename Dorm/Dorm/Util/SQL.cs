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
     internal int GetNewRoomNumber()
     {
         int flag = 1;
         try
         {
             OleDbCommand cmd = new OleDbCommand("select top 1 roomnumber from tb_rooms order by roomnumber desc", GetConnection());
             OleDbDataReader rd = cmd.ExecuteReader();
             while (rd.Read())
             {
                 flag = (Convert.ToInt32(rd[0]) + 1);
             }
         }
         catch (Exception e)
         {
             System.Diagnostics.Debug.WriteLine(e.Message);
         }
         return flag;
     }
     internal int GetNewOccuId()
     {
         int flag = 1;
         try
         {
             OleDbCommand cmd = new OleDbCommand("select top 1 ocid from tb_occupencies order by ocid desc", GetConnection());
             OleDbDataReader rd = cmd.ExecuteReader();
             while (rd.Read())
             {
                 flag = (Convert.ToInt32(rd[0]) + 1);
             }
         }
         catch (Exception e)
         {
             System.Diagnostics.Debug.WriteLine(e.Message);
         }
         return flag;
     }
     internal int GetNewSId()
     {
         int flag = 1;
         try
         {
             OleDbCommand cmd = new OleDbCommand("select top 1 stid from tb_stubs order by stid desc", GetConnection());
             OleDbDataReader rd = cmd.ExecuteReader();
             while (rd.Read())
             {
                 flag = (Convert.ToInt32(rd[0]) + 1);
             }
         }
         catch (Exception e)
         {
             System.Diagnostics.Debug.WriteLine(e.Message);
         }
         return flag;
     }

     internal int GetNewOwnerID()
     {
         int flag = 1;
         try
         {
             OleDbCommand cmd = new OleDbCommand("select top 1 ownerid from tb_owners order by ownerid desc", GetConnection());
             OleDbDataReader rd = cmd.ExecuteReader();
             while (rd.Read())
             {
                 flag = (Convert.ToInt32(rd[0]) + 1);
             }
         }
         catch (Exception e)
         {
             System.Diagnostics.Debug.WriteLine(e.Message);
         }
         return flag;
     }
    }
}
