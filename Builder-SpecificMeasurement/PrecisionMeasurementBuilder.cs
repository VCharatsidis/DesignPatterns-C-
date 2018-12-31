namespace Builder_SpecificMeasurement
{
    class PrecisionMeasurementBuilder : MeasurementBuilder
    {

        public override void ChoosePrecision()
        {
            measurement.timeToMeasure = 283733.2M;
            measurement.repetition = 3;
            measurement.presure = Measurement.Presure.HighPrecision;
        }

        public override void ChooseTempMetric()
        {
            measurement.temp = Measurement.Temperature.Celsius;
        }

        public override void ChooseUltraSound()
        {
            measurement.ultraSound = true;
        }
    }

}
