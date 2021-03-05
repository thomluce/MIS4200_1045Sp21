using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MIS4200_1045.Models
{
    public class Profile
    {
        public Guid  profileID { get; set; }
        public string lastName { get; set; }
        public string firstName { get; set; }
        public string fullName
        {
            get
            {
                return lastName + ", " + firstName;
            }
        }
        public string office { get; set; }
        public string position { get; set; }
        public DateTime hireDate { get; set; }

    }
}