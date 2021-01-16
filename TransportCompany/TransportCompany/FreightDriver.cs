using System;
using System.Collections.Generic;
using System.Text;

namespace ClientApp
{
    class FreightDriver : Driver
    {
        public FreightDriver(DateTime dateOfBirth, Truck truck, string licenseId)
        {
            SetDateOfBirth(dateOfBirth);
            if (DriverIsLegal(20)) SetLicense($"Heavy-{licenseId}");
            else Console.WriteLine("FreightDriver can't have a license.");
        }

        public override void SetLicense(string licenseId)
        {
            SetLicense(licenseId);
            
        }
    }
}
