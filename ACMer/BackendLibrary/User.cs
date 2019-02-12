using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACMer.BackendLibrary
{
    [Serializable]
    public class User
    {
        public WString Password, Email, Phone, Name;
        public int Privilege, UserID;

        public User(string password = "", string email = "", string phone = "", string name = "")
        {
            Password = new WString(40, password);
            Email = new WString(20, email);
            Phone = new WString(20, phone);
            Name = new WString(10, name);
            Privilege = UserID = 0;
        }
    }
}
