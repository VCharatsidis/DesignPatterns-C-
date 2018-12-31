using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_SpecificMeasurement
{
    class Program
    {
        static void Main(string[] args)
        {
            /* When the objects have too many parameters we might want to encapsulate their creation in a dedicated class just for this. */
            var measurementMaker = new MeasurementMaker(new PrecisionMeasurementBuilder());
            measurementMaker.buildMeasurement();
            var precMeasurement = measurementMaker.getMeasurement();

            precMeasurement.Display();
            Console.ReadKey();
        }
    }

}
