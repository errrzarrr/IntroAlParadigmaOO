using System;
using System.Collections.Generic;
using System.Text;

namespace ClientApp
{

    class Pilot : Driver
    {

        public Pilot(DateTime dateOfBirth, Car car, string licenseId)
        {
            SetDateOfBirth(dateOfBirth);
            if(DriverIsLegal(22)) SetLicense($"Pro-{licenseId}");
            else Console.WriteLine("Pilot can't have a license.");
        }


        public override void SetLicense(string licenseId)
        {
            SetLicense(licenseId);
        }

    }
}
