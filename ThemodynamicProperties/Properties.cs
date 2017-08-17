using System;

namespace ThemodynamicProperties
{
    internal class Properties
    {
        internal medium medium { get; set; }
        internal double temperatureF { get; set; }
        internal double temperatureC { get; set; }
        internal double pressureMPa { get; set; }
        internal double pressurePSIg { get; set; }
        internal double pressurePSIa { get; set; }
        internal double liquidDensity { get; set; }
        internal double vaporSpecificVolume { get; set; }
        internal double hf { get; set; } // enthalpy saturated liquid
        internal double hg { get; set; } // enthalpy saturated vapor
        internal double sf { get; set; } // entropy saturated liquid
        internal double sg { get; set; } // entropy saturated vapor
    }
}
