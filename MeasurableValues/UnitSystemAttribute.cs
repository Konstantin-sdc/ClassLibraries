namespace Foundations.MeasurableValues {
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>Система единиц измерения. Атрибут.</summary>
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
    public class UnitSystemAttribute : Attribute, IUnitsSystem {
        public bool IsStandartSystem { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IDictionary<IMeasurableValue, double> MeasurableValues { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Title { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Description { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public StringComparison StringComparison { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        /// <summary>
        /// Содержит ли данная СИ единицу измерения, у которой значение любого из определяющих эту единицу параметров, совпадает со значением 
        /// того же параметра в <paramref name="measurableValue"/>?
        /// </summary>
        /// <param name="measurableValue">Экземпляр <see cref="IMeasurableValue"/> для проверки.</param>
        /// <returns>true, если да.</returns>
        public bool Contains(IMeasurableValue measurableValue) {
            if(measurableValue == null) {
                throw new ArgumentNullException(nameof(measurableValue));
            }
            return (
                MeasurableValues.Any(v => v.Key.DimensionSymbol == measurableValue.DimensionSymbol ||
                v.Key.Sign == measurableValue.Sign ||
                v.Key.StandartEquivalent == measurableValue.StandartEquivalent ||
                v.Key.Unit == measurableValue.Unit)
                );
        }

    }

}
