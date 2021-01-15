using System;
using System.Collections.Generic;
using System.Text;

namespace ClientApp
{
    class TaxiDriver : Driver
    {
        internal void BringPassanger(Passanger passanger)
        {
            if (passanger is null)
            {
                throw new ArgumentNullException(nameof(passanger));
            }
        }

    }
}
