using System;

namespace MeasurementController
{
    abstract class Sensor
    {
        private IMeasurement measurement;

        public Sensor(IMeasurement measurement)
        {
            this.measurement = measurement;
            
        }

        public void takeMeasurement()
        {
            measurement.Measure();
            Console.WriteLine("meusurement taken");
        }
    }
 
}
