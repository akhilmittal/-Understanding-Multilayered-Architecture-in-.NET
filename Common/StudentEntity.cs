using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common
{
    public class StudentEntity
    {
        int studentID;

        public int StudentID
        {
            get { return studentID; }
            set { studentID = value; }
        }
        string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        string email;

        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        string address;

        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        int age;

        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        string country;

        public string Country
        {
            get { return country; }
            set { country = value; }
        }
    }
}
