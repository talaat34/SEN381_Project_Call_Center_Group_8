﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEN381_Project_Call_Center_Group_8
{
    class ServiceTier
    {
        string ServiceTypeID, ServiceName, ServicePromotion, ServiceDescription, ServcieTierID;
        float ServiceCost;

        public ServiceTier(string serviceTypeID, string serviceName, string servicePromotion, string serviceDescription, string servcieTierID, float serviceCost)
        {
            ServiceTypeID = serviceTypeID;
            ServiceName = serviceName;
            ServicePromotion = servicePromotion;
            ServiceDescription = serviceDescription;
            ServcieTierID = servcieTierID;
            ServiceCost = serviceCost;
        }

        public string ServiceTypeID1 { get => ServiceTypeID; set => ServiceTypeID = value; }
        public string ServiceName1 { get => ServiceName; set => ServiceName = value; }
        public string ServicePromotion1 { get => ServicePromotion; set => ServicePromotion = value; }
        public string ServiceDescription1 { get => ServiceDescription; set => ServiceDescription = value; }
        public string ServcieTierID1 { get => ServcieTierID; set => ServcieTierID = value; }
        public float ServiceCost1 { get => ServiceCost; set => ServiceCost = value; }

        public override string ToString()
        {
            return string.Format("ID: {0} - Name: {1} - Promotion: {2} - Description: {3} - Service Tier Type ID: {4} - Service Cost: {5}", ServiceTypeID, ServiceName, ServicePromotion, ServiceDescription, ServcieTierID, ServiceCost1);
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
            return ServiceTierID.GetHashCode() * ServiceTierCost.GetHashCode();
        }
    }
}
