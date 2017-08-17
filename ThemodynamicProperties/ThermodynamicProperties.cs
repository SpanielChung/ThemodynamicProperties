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
        PropTable propTable;

        public ThermodynamicProperties()
        {
            propTable = new PropTable();
        }
        public double GetPressureFromTemp(medium m, double temperatureC)
        {
            return  propTable.properties.Where(x => x.medium == m && x.temperatureF == temperatureC).Select(x => x.pressurePSIa).FirstOrDefault();
        }



    }
}
