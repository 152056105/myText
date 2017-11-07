using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TxT
{
   public class User
    {
        private string usernmae;

        public string Usernmae
        {
            get { return usernmae; }
            set { usernmae = value; }
        }
        private string password;

        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        private string gender;

        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }
        private string birthday;

        public string Birthday
        {
            get { return birthday; }
            set { birthday = value; }
        }
        private string phone;

        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }
    }
}
