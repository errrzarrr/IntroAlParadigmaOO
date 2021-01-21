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

            if(ValidAge(22)) 
                SetLicense($"Pro-{licenseId}");
        }


        public override void SetLicense(string licenseId)
        {
            SetLicense(licenseId);
        }

    }
}
