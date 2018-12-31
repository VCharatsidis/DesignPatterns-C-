namespace Builder_SpecificMeasurement
{
    class MeasurementMaker
    {
        public MeasurementBuilder mb;

        public MeasurementMaker(MeasurementBuilder mb)
        {
            this.mb = mb;

        }

        public void buildMeasurement()
        {
            mb.CreateMeasurement();
            mb.ChoosePrecision();
            mb.ChooseTempMetric();
            mb.ChooseUltraSound();
        }

        public Measurement getMeasurement()
        {
            return mb.GetMeasurement();
        }
    }
}
