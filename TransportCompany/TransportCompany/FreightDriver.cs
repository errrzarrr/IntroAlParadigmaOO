using System;
using System.Collections.Generic;
using System.Text;

namespace ClientApp
{
    class FreightDriver : Driver
    {
        public FreightDriver() { }

        public FreightDriver(Driver driver) : base(driver)
        {
            //
        }

        public override void ObtainDriverLicense()
        {
            int age = DateTime.Today.Year - this.GetDateOfBirth().Year;

            if (age < 20)
            {
                Console.WriteLine("You are not old enough to get a truck driver's license");
            }
            else this._licenseId = $"Heavy-{this.GetName()}{this.GetDateOfBirth().Year}{this.GetDateOfBirth().Month}{this.GetDateOfBirth().Day}";
        }
    }
}
