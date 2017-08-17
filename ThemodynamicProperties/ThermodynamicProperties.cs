using System;
using System.Linq;

namespace ThemodynamicProperties
{
    public enum medium
        {
            R22,
            test
        };
    public class ThermodynamicProperties
    {


        private R22 R22;

        public ThermodynamicProperties()
        {
            R22 = new R22();
        }
        public double GetPressureFromTemp(medium m, double temperatureC)
        {
            return R22.properties.Where(x => x.medium == m && x.temperatureF == temperatureC).Select(x => x.pressurePSIa).FirstOrDefault();
        }



    }
}
