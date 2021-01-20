using System;
using System.Collections.Generic;
using System.Text;

namespace ClientApp
{
    class FreightDriver : Driver
    {

        protected int fee;
        protected int minTax = 100;
        protected int maxTax = 1000;

        public FreightDriver(DateTime dateOfBirth, Truck truck, string licenseId)
        {
            SetDateOfBirth(dateOfBirth);
            SetVehicle(truck);
            if (DriverIsLegal(20)) SetLicense($"Heavy-{licenseId}");

        }

        public override void SetLicense(string licenseId)
        {
            SetLicense(licenseId);
            
        }

    }
}
