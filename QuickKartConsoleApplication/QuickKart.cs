using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickKartConsoleApplication
{
    public class QuickKart
    {
        private string firstName;
        private string lastName;
        private long phoneNumber;
        private int customerId;

        public QuickKart(string firstName, string lastName, long phoneNumber, int customerId)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.phoneNumber = phoneNumber;
            this.customerId = customerId;
        }

        public string displayDetails()
        {
            string details = string.Empty;
            details += this.firstName + "\n";
            details += this.lastName + "\n";
            details += this.phoneNumber + "\n";
            details += this.customerId;

            return details;
        }

        public string FirstName
        {
            get { return this.firstName; }
            set
            {
                this.firstName = value;
            }
        }

        public string LastName
        {
            get { return this.lastName; }
            set
            {
                this.lastName = value;
            }
        }

        public long PhoneNumber
        {
            get { return this.phoneNumber; }
            set
            {
                this.phoneNumber = value;
            }
        }


    }
}
