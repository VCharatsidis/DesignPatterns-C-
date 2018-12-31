namespace Builder_SpecificMeasurement
{
    class CheapMeasurementBuilder : MeasurementBuilder
    {

        public override void ChoosePrecision()
        {
            measurement.timeToMeasure = 300.0M;
            measurement.repetition = 1;
            measurement.presure = Measurement.Presure.LowPrecision;
        }

        public override void ChooseTempMetric()
        {
            measurement.temp = Measurement.Temperature.Farenheit;
        }

        public override void ChooseUltraSound()
        {
            measurement.ultraSound = true;
        }

    }

}
