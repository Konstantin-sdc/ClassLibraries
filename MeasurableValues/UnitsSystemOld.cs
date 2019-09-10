using System;
using System.Collections.Generic;

namespace Foundations.MeasurableValues {

    /// <summary>Система единиц.</summary>
    // UNDONE: Доделать соотвествующий интерфейс.
    public class UnitsSystemOld : BasicComplex, IUnitsSystem {
        public string DimensionSymbol { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Unit { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Sign { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        IDictionary<IMeasurableValue, double> IUnitsSystem.MeasurableValues { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        bool IUnitsSystem.IsStandartSystem { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        bool IUnitsSystem.Contains(IMeasurableValue measurableValue) {
            throw new NotImplementedException();
        }
    }
}
