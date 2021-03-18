using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEN381_Project_Call_Center_Group_8
{
    class BusinessClient
    {
        string businessID, buinessName, businessLocation, businessEmail, ServiceTypeID;

        public BusinessClient(string businessID, string buinessName, string businessLocation, string businessEmail, string serviceTypeID)
        {
            this.BusinessID = businessID;
            this.BuinessName = buinessName;
            this.BusinessLocation = businessLocation;
            this.BusinessEmail = businessEmail;
            ServiceTypeID1 = serviceTypeID;
        }

        public string BusinessID { get => businessID; set => businessID = value; }
        public string BuinessName { get => buinessName; set => buinessName = value; }
        public string BusinessLocation { get => businessLocation; set => businessLocation = value; }
        public string BusinessEmail { get => businessEmail; set => businessEmail = value; }
        public string ServiceTypeID1 { get => ServiceTypeID; set => ServiceTypeID = value; }

        public override string ToString()
        {
            return string.Format("ID: {0} - Name: {1} - Email: {2} - Location: {3} - Service Type ID: {4}", businessID, BuinessName, businessEmail, businessLocation, ServiceTypeID);
        }
        public override bool Equals(object obj)
        {
            //Check for null and compare run-time types.
            if ((obj == null) || ! this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            else {
                Point p = (Point) obj;
                return (x == p.x) && (y == p.y);
            }
        }
        public override int GetHashCode()
        {
            return buinessName ^ businessEmail ^ businessID * BusinessLocation ^ ServiceTypeID;
        }

    }
}


