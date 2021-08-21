using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basics_POO
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string FullName { 
            get {
                string fullName = "";
                if (!string.IsNullOrEmpty(FirstName))
                {
                    fullName += FirstName;
                    if (!string.IsNullOrEmpty(LastName))
                    {
                        fullName += " " + LastName;
                    }
                    return fullName;
                }
                else
                {
                    if (!string.IsNullOrEmpty(LastName))
                    {
                        return LastName;
                    }
                    else
                    {
                        return "N/A";
                    }
                }
            }
        }
        public static int InstanceCount { get; set; }
    }
}
