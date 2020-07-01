using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Inheritance_Classes
{
    public class Person
    {
        private string _firstname;
        private string _lastname;
        public string Name
        {
            get
            {
                string fullName = $"{_firstname} {_lastname}";
                return (!string.IsNullOrEmpty(fullName)) ? fullName : "Unnamed";
            }
        }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }

        public void setFirstName(string name)
        {
            _firstname = name;
        }

        public void setLastName(string name)
        {
            _lastname = name;
        }

    }
}
