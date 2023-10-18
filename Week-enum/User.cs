using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_enum
{
    internal class User
    {
        public string Name{ get; set; }
        public string Surname{ get; set; }
        Weekdays _birthday;
        public Weekdays BirthDay
        {
            get { return _birthday; }
            set
            {
                if (value > 0 && (int)value < 8)
                {
                   _birthday=value;
                }
                else
                {
                    Console.WriteLine("olmaz");
                }
            }
        }
            

        public User(string Name ,string Surname , Weekdays BirthDay)
        {
            this.Name = Name;
            this.Surname = Surname;
            this.BirthDay = BirthDay;
        }
    }
}
