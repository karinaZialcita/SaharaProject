using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace sahara.entities
{
    public class Account
    {

        public string name { get; set; }
        public string emailAddress { get; set; }
        public string phoneNum { get; set; }
        public string password { get; set; }

        public Account() { }
        public Account(string newName, string newEmail, string newPhoneNum, string newPassword)
        {
            name = newName;
            emailAddress = newEmail;
            phoneNum = newPhoneNum;
            password = newPassword;
        }
        public List<Account>getAccounts()
        {
            List<Account> accList = new List<Account>()
            {
                new Account("karina", "corn@gmail.com", "123456789", "karina1"),
                new Account("acc", "acc@gmail.com", "23423424", "acc1"),
                new Account("admin", "admin@gmail.com", "2342342423", "admin1"),
                new Account("sahara", "sahara@gmail.com", "213123123123", "sahara1")
            };

            return accList;
        }
    }
}