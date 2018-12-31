namespace Builder_SpecificMeasurement
{
    public abstract class MeasurementBuilder
    {
        protected Measurement measurement;

        public Measurement GetMeasurement()
        {
            return measurement;
        }

        public void CreateMeasurement()
        {
            measurement = new Measurement();

        }


        public abstract void ChoosePrecision();
        public abstract void ChooseTempMetric();
        public abstract void ChooseUltraSound();
    }
}
