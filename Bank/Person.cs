using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banks
{
    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Passport { get; set; }
        public Person(string firstname, string lastname, DateTime dateofbirth, string passport)
        {
            FirstName = firstname;
            LastName = lastname;
            DateOfBirth = dateofbirth;
            Passport = passport;
        }
        public override string ToString()
        {
            return (FirstName + " " + LastName + " " + DateOfBirth + " " + GetEmploymentStatus());
        }
        public virtual string GetEmploymentStatus()
        {
            return "Unemployed";
        }
    }
}
