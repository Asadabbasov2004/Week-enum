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
        public Weekdays BirthDay { get; set; }

        public User(string Name ,string Surname , Weekdays BirthDay)
        {
            this.Name = Name;
            this.Surname = Surname;
            this.BirthDay = BirthDay;
        }
    }
}
