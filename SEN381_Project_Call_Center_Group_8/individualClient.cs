using System;

namespace SEN381_Project_Call_Center_Group_8
{
    public class individualClient
    {
        private string indiID;
        private string name;
        private string surname;
        private string role;
        private string serviceTypeID;

        public string IndiID { get => indiID; set => indiID = value; }
        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public string Role { get => role; set => role = value; }
        public string ServiceTypeID { get => serviceTypeID; set => serviceTypeID = value; }

        public individualClient()
        {
        }

        public individualClient(string id, string nm, string surnm, string role, string serviveTyp)
        {
            this.indiID = id;
            this.name = nm;
            this.surname = surnm;
            this.role = role;
            this.serviceTypeID = serviveTyp;
        }

        public override string ToString()
        {
            return string.Format("ID: {0} - Name: {1} - Surname: {2} - Role: {3} - Service Type ID: {4}", indiID, name, surname, role, serviceTypeID);
        }
        public override bool Equals(object obj)
        {
            //Check for null and compare run-time types.
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            else
            {
                Point p = (Point)obj;
                return (x == p.x) && (y == p.y);
            }
        }
        public override int GetHashCode()
        {
            return indiID ^ name ^ surname ^ role * serviceTypeID;
        }

    }

}
