using System;

namespace Builder_SpecificMeasurement
{
    public class Measurement
    {
        public bool ultraSound;
        public int repetition;
        public decimal timeToMeasure;
        public Presure presure;
        public Temperature temp;

        public bool concrete;

        public enum Temperature
        {
            Farenheit,
            Celsius,
            Kelvin,
            PreciseCelsius
        }

        public enum Presure
        {
            LowPrecision,
            MidPrecision,
            HighPrecision
        }

        public void Display()
        {
            Console.WriteLine("Ultrasound on");
            Console.WriteLine("repetition " + repetition);
            Console.WriteLine(temp);
            Console.WriteLine(presure);
        }
    }
}
