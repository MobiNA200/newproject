using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newproject2
{
    internal class ClassDriver : Person
    {
        string car;
        string Plak;
     
        public void setcar(string c)
        {
            car = c;
        }
        public string getcar()
        {
            return car;
        }

        public void setplak(string c)
        {
            Plak = c;
        }
        public string getplak()
        {
            return Plak;
        }

        

        public string color { get; set; }
        public string codemeli { get; set; }
         
        public ClassDriver()
        { }
        public ClassDriver(string name, string fullname, string number, string pass, string Email,string car , string Plak, string color, string codemeli)
        {
            this.name = name;
            this.number = number;
            this.fullName = fullname;
  
            this.pass = pass;
            this.Email = Email;
            this.car = car;
            this.Plak = Plak;
            this.color = color;
            this.codemeli = codemeli;

        }



    }
}

