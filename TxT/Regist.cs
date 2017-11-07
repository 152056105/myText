using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            User user = new User();
            user.Usernmae = usernamer;
            user.Password = password;
            user.Gender = gender;
            user.Birthday = birth;
            user.Phone = phone;
            //注册方法
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
             new login().Show();
             this.Hide();
             
        }
    }
}
