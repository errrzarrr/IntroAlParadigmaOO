using System;
using System.Collections.Generic;
using System.Text;

namespace ClientApp
{
    class Pilot:Driver
    {
        private string PilotLicense;
        public string GetPilotLicense()
        {
            return PilotLicense;
        }

        public void SetPilotLicense(string license)
        {
            PilotLicense = $" Pro-{license}"; ;
        }

        public Pilot(string license)
        {
            PilotLicense = $" Pro-{license}";
        }
    }
}
