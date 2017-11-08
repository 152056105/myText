using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;
using MySql.Data.Common;
namespace TxT.mysql
{
    class ConnFactory
    {
        //建立连接
        public   MySqlConnection getmysqlcon()
        {
            string M_str_sqlcon = "server=localhost;user id=root;password=root;database=txt;Charset=utf8"; //根据自己的设置
           MySqlConnection myCon = new MySqlConnection(M_str_sqlcon);
           return myCon;
        }

        //运行sql语句，运行没有返回值的
        public void getmysqlcom(string M_str_sqlstr)
     {
         MySqlConnection mysqlcon = this.getmysqlcon();
         mysqlcon.Open();
         MySqlCommand mysqlcom = new MySqlCommand(M_str_sqlstr, mysqlcon);
         mysqlcom.ExecuteNonQuery();
         mysqlcom.Dispose();
         mysqlcon.Close();
         mysqlcon.Dispose();
     }

        /// <summary>
        /// 创建一个MySqlDataReader对象
        /// </summary>
       /// <param name="M_str_sqlstr">SQL语句</param>
       /// <returns>返回MySqlDataReader对象</returns>
    public MySqlDataReader getmysqlread(string M_str_sqlstr)
     {
         MySqlConnection mysqlcon = this.getmysqlcon();
         MySqlCommand mysqlcom = new MySqlCommand(M_str_sqlstr, mysqlcon);
         mysqlcon.Open();
         MySqlDataReader mysqlread = mysqlcom.ExecuteReader(CommandBehavior.CloseConnection);
         return mysqlread;
     }


    }
}
