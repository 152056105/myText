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
            strname = name;
            Form1 form1 = new Form1(this);
            form1.Show();
        }
    }
}
