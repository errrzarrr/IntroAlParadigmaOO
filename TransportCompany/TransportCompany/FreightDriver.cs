using System;
using System.Collections.Generic;
using System.Text;

namespace ClientAppClassLIbrary
{
    public class FreightDriver : Driver
    {
        protected double fee;

        public void SetFee(double fee)
        {
            if (fee < 0)
            {
                Console.WriteLine("You must provide a positive amount");
            }
            else this.fee = fee;
        }
        public double GetFee()
        {
            return this.fee;
        }

        public override void SetLicense(string licenseId)
        {
            if (this.age < 20)
            {
                Console.WriteLine("You are not old enough to get a Freight/Truck's driver license");
            }            
            else if ((licenseId == "") || (licenseId.Substring(0, 6) != "Heavy-"))
            {
                Console.WriteLine("This is not a valid Freight/Truck's license ID");
            }
            else this.licenseId = licenseId;
        }

        protected override bool CanDriveThisVehicle()
        {
            return ((vehicle is Truck) || (vehicle is Freight));
        }

        public override string ObtainDriverLicense()
        {
            this.SetLicense($"Heavy-{this.GetName()}{this.GetDateOfBirth().Year}{this.GetDateOfBirth().Month}{this.GetDateOfBirth().Day}");
            return this.licenseId;
        }            
    }
}
