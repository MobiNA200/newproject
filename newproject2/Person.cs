using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newproject2
{
    internal class Person
    {
        protected string karbar;
        protected string name;
        protected string pass;
        protected string fullName;
        protected string Email;
        protected string number;

     
        public Person()
        {

        }

        public void setname(string n)
        {
            name = n;

        }
        public string getname()
        {
            return name;
        }

        public void setpass(string n)
        {
            pass = n;

        }
        public string getpass()
        {
            return pass;
        }

        public void setfullNmae(string n)
        {
            fullName = n;

        }
        public string getfullName()
        {
            return fullName;
        }

        public void setnumber(string n)
        {
            number = n;

        }
        public string getnumber()
        {
            return number;
        }

        public void setkarbar(string n)
        {
            karbar = n;

        }
        public string getkarbar()
        {
            return karbar;
        }
        public void setEmail(string n)
        {
            Email = n;

        }
        public string getEmail()
        {
            return Email;
        }

        string car;
        string plak;
        public Person(string name, string fullname, string number, string pass , string Email )
        {
            this.name = name;
            this.number = number;
            this.fullName = fullname;
            this.pass = pass;
            this.Email = Email;
        }

        

       


    }
}

