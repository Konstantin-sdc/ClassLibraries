using Foundations;
using Foundations.Metrology;

namespace Busines {

    public class Product<T> : BasicComplex, IProduct<T> where T : IBasicComplex {

        public Product(T entity, MetricUnit unit) {
            Entity = entity;
            _unit = unit;
        }

        private readonly MetricUnit _unit;

        public T Entity { get; }

        public Contractor Manufacturer { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        public string Model { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

        public MetricUnit Unit {
            get => _unit;
            set => throw new System.NotImplementedException();
        }
        public string Line { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        public string SerialNumber { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        public IBrand<T> Brand { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        public string ManufactureCountry { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

        public override object Clone() {
            throw new System.NotImplementedException();
        }
    }
}