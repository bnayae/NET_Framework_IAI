using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2_Classes
{
    public class Person
    {
        //Fields
        private string name;
        private string addr;
        private DateTime date;

        private const double PI = 3.14;

        //Properties
        public string phone { get; set; } // public string phone;

        public string SSN { get; private set; }

        public string Password
        {
            set
            {
                Console.WriteLine("I have set a password in the db " +value);
            }
        }

        public string IDNumber
        {
            get { return "[---" + idNumber + "---]"; }
            set {
                if (value.Length > 8)
                    idNumber = value;
                }
        }
        private string idNumber;
        
        public string getIdNumber()
        {
            return idNumber;
        }
        public void setIdNumber(string id,string v3)
        {
            if (id.Length > 8)
                idNumber = id;
        }
        public Person(string name,string addr,int year,int month,int day):this(name,addr,new DateTime(year,month,day))
        {
            SSN = "87834534";
            //Console.WriteLine("my password is " + Password);
        }
        public Person(string name, string addr):this(name,addr,DateTime.Now)
        {

        }

        public Person(string name, string addr,DateTime dt)
        {
            this.name = name;
            this.addr = addr;
            date = dt;

            //this.idNumber = "3";
        }

        private int getLength()
        {
            SSN = "sdfsdf";
            return name.Length;
        }

        public Person LongerName(Person p)
        {
            if (ReferenceEquals(p, null))
                return this;
            if (getLength() > p.getLength())
                return this;
            return p;
        }

        public static Person LongerName(Person p1,Person p2)
        {
            /*if (p1.getLength() > p2.getLength())
                return p1;
            return p2;
            */
            ///return p1.LongerName(p2);
            return p1.getLength() > p2.getLength() ? p1 : p2;
        }

    }
}
