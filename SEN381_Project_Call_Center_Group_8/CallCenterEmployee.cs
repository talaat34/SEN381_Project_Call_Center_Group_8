using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEN381_Project_Call_Center_Group_8
{
    //Added Classes
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
    }
}
