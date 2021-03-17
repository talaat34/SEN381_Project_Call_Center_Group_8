using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEN381_Project_Call_Center_Group_8
{
    class adminstrator
    {
        //FIELDS
        private int id;
        private string name;
        private string surname;
        private string password;

        //PROPERTIES
        public int ID { get { return id; } set { this.id = value; } }
        public string Name { get { return name; } set { name = value; } }
        public string Surname { get { return surname; } set {surname = value; } }
        public string Password { get { return password; } set { password = value; } }

        //CONSTRUCTORS
        public adminstrator()
        {

        }
        public adminstrator(int iD, string nm, string surnm, string pass)
        {
            this.ID = iD;
            this.Name = nm;
            this.Surname = surnm;
            this.Password = pass;
        }

        //OVERRIDE METHOD(S)
        public override string ToString()
        {
            return string.Format("ID: {0} - Name: {1} - Surname: {2} - Password: {3}", ID.ToString(), Name, Surname, Password);
        }

    }
}
