using System;
using System.Collections.Generic;
using System.Text;

namespace ClientApp
{

    class Pilot : Driver
    {
        private Car car;
        public Pilot(DateTime dateOfBirth, Car car, string licenseId)
        {
            this.car = car;
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
