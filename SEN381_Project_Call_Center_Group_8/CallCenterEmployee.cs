using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEN381_Project_Call_Center_Group_8
{
    //Added Classes 
    //Added More Classes
    class CallCenterEmployee
    {
        string callEmployeeID, callEmployeeName, callEmployeeSurname;

        public CallCenterEmployee(string callEmployeeID, string callEmployeeName, string callEmployeeSurname)
        {
            this.CallEmployeeID = callEmployeeID;
            this.CallEmployeeName = callEmployeeName;
            this.CallEmployeeSurname = callEmployeeSurname;
        }

        public string CallEmployeeID { get => callEmployeeID; set => callEmployeeID = value; }
        public string CallEmployeeName { get => callEmployeeName; set => callEmployeeName = value; }
        public string CallEmployeeSurname { get => callEmployeeSurname; set => callEmployeeSurname = value; }
    
        
        public override string ToString()
        {
            return string.Format("ID: {0} - Name: {1} - Surname: {2}", callEmployeeID, callEmployeeName, callEmployeeSurname);
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
            return callEmployeeID * callEmployeeName * callEmployeeSurname;
        }
    }
}
