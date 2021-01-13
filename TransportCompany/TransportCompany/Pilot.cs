using System;
using System.Collections.Generic;
using System.Text;

namespace ClientApp
{

    class Pilot : Driver
    {

        public Pilot()
        {
            SetLicense("Pro-");
        }

        public override void SetLicense(string licenseId)
        {
            string license = GetLicense() + licenseId;
            base.SetLicense(license);
        }

    }
}
