using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using MySql.Data.Common;
namespace TxT
{
    public partial class login : Form
    {
        public string strname;
        public login()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Regist re = new Regist();
            re.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = loginname.Text;
            string pass = loginpass.Text;

            if ((name == "") || (pass == ""))
            {
                MessageBox.Show("所需填写内容不能为空！");

            }
            else
            {
                TxT.mysql.ConnFactory conn = new mysql.ConnFactory();
                string sql1 = "select * from `user` where `username`='" + name + "'";
                MySqlDataReader reader = conn.getmysqlread(sql1);
                 string username="";
                 string password = "";
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                         username = reader.GetString("username"); 
                         password = reader.GetString("password");

                    }
                    if (password == pass) {

                        strname = name;
                        Form1 form1 = new Form1(this);
                        form1.Show();
                        this.Hide();
                    }
                    else
                    {

                        MessageBox.Show("用户名或密码不正确！");
                    }


                }
                else
                {
                    MessageBox.Show("没有此用户！");
                }




               
            }
        }
    }
}
