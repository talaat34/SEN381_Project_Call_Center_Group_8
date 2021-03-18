using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEN381_Project_Call_Center_Group_8
{
    class Technician
    {
        string TechnicianID, TechnicianName, TechnicianSurname, ServiceTypeID;

        public Technician(string technicianID, string technicianName, string technicianSurname, string serviceTypeID)
        {
            TechnicianID1 = technicianID;
            TechnicianName1 = technicianName;
            TechnicianSurname1 = technicianSurname;
            ServiceTypeID1 = serviceTypeID;
        }

        public string TechnicianID1 { get => TechnicianID; set => TechnicianID = value; }
        public string TechnicianName1 { get => TechnicianName; set => TechnicianName = value; }
        public string TechnicianSurname1 { get => TechnicianSurname; set => TechnicianSurname = value; }
        public string ServiceTypeID1 { get => ServiceTypeID; set => ServiceTypeID = value; }
    

        public override string ToString()
        {
            return string.Format("ID: {0} - Name: {1} - Promotion: {2} - Service Type ID: {3}", TechnicianID, TechnicianName, TechnicianSurname, ServiceTypeID);
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
            return TechnicianID ^ TechnicianName * TechnicianSurname * ServiceTypeID;
        }

    }
}
