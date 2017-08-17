using System;
using System.Collections.Generic;

namespace ThemodynamicProperties
{
    internal class PropTable
    {
        internal List<Properties> properties = new List<Properties>();
        internal PropTable()
        {
            /// R22 Refridgerant
            properties.Add(new Properties() { medium = medium.R22, temperatureF = -100, pressurePSIa = 2.4,     pressurePSIg = 25.1 });
            properties.Add(new Properties() { medium = medium.R22, temperatureF = -95,  pressurePSIa = 2.87,    pressurePSIg = 24.1 });
            properties.Add(new Properties() { medium = medium.R22, temperatureF = -90,  pressurePSIa = 3.42,    pressurePSIg = 23.0 });
            properties.Add(new Properties() { medium = medium.R22, temperatureF = -100, pressurePSIa = 2.4,     pressurePSIg = 25.1 });
            properties.Add(new Properties() { medium = medium.R22, temperatureF = -95,  pressurePSIa = 2.87,    pressurePSIg = 24.1 });
            properties.Add(new Properties() { medium = medium.R22, temperatureF = -90,  pressurePSIa = 3.42,    pressurePSIg = 23.0 });
        }


    }
}
