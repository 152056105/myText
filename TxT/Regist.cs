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
    public partial class Regist : Form
    {
        public Regist()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usernamer = username.Text;
            string password = pass.Text;
            string gender;
            if (gendernan.Checked)
            {
                gender = gendernan.Text;
            }
            else
            {
                gender = gendernv.Text;
            }
            string birth = birthday.Text;
            string phone = telephone.Text;

            if ((usernamer == "") || (password == "") || (gender == "") || (phone == ""))
            {
                MessageBox.Show("所需填写内容不能为空！");                                                                        

            }
            else {
                TxT.mysql.ConnFactory conn = new mysql.ConnFactory();
                string sql1 = "select * from `user` where `username`='" + usernamer + "'";
                MySqlDataReader reader = conn.getmysqlread(sql1);
                if (!reader.HasRows)
                {
                    string sql = "INSERT INTO `user` (`username`, `password`, `gender`, `birthday`, `phone`) VALUES ('" + usernamer + "', '" + password + "', '" + gender + "', '" + birth + "', '" + phone + "')";
                    conn.getmysqlcom(sql);
                    login log = new login();
                    log.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("此用户名已经被注册！");
                }
            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
             new login().Show();
             this.Hide();
             
        }
    }
}
