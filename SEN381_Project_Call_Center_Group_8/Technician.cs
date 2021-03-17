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
    }
}
