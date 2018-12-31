using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeasurementController
{
    class Program
    {
        static void Main(string[] args)
        {

            /* 2 or more abstractions make a Bridge to scallable solution where there are many combinations of possible objects. */

            Console.WriteLine("Research");
            CheapMeasurement sm = new CheapMeasurement();
            Sensor sensor = new TemperatureSensor(sm);
            sensor.takeMeasurement();
            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }

}
