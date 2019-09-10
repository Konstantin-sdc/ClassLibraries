namespace Foundations.MeasurableValues {
    using Foundations;

    class TestPhysItem : BasicComplex, IBaseUnits {

        public TestPhysItem() {
            MeasurableValues.Mass = 2;
        }

        public IBaseUnits MeasurableValues => this;

        double IBaseUnits.Length {
            get => throw new System.NotImplementedException();
            set => throw new System.NotImplementedException();
        }


        double IBaseUnits.Mass {
            get => throw new System.NotImplementedException();
            set => throw new System.NotImplementedException();
        }

        double IBaseUnits.Time {
            get => throw new System.NotImplementedException();
            set => throw new System.NotImplementedException();
        }
    }

}
