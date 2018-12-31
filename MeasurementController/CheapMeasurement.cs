using System;

namespace MeasurementController
{
    class CheapMeasurement : IMeasurement
    {
        public void Measure()
        {
            Console.WriteLine("Shallow measurement");
        }
    }

}
