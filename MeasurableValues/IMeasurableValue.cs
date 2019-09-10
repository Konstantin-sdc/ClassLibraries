namespace Foundations.MeasurableValues {
    using System.ComponentModel;

    // UNDONE: Измеряемая величина. Завершить модуль. 
    // NOTE: Если в базе ВСЕГДА величины будут вформате ММСИ. Представление величин в иных СИ — на уровне пользователя.

    /// <summary>Измеряемая величина.</summary>
    public interface IMeasurableValue : IBasicComplex {

        /// <summary>Используемая система измерений.</summary>
        // Одна на все наследники и экземпляры.
        IUnitsSystem UnitsSystem { get; }

        /// <summary>Минимум.</summary>
        double Min { get; set; }

        /// <summary>Максимум.</summary>
        double Max { get; set; }

        /// <summary>Символ размерности.</summary>
        string DimensionSymbol { get; }

        /// <summary>Единица измерения.</summary>
        [Localizable(true)]
        string Unit { get; }

        /// <summary>Обозначение.</summary>
        /// <remarks>
        /// Обозначения единиц, согласно Брошюре СИ, являются не сокращениями, а математическими объектами. Они входят в международную научную символику <see href="https://www.iso.org"/> ISO 80000 и от языка не зависят, например kg.
        /// </remarks>
        [Localizable(false)]
        string Sign { get; }

        /// <summary>Эквивалент в стандартной системе единиц.</summary>
        IMeasurableValue StandartEquivalent { get; }

        /// <summary>
        /// Множитель, на который следует умножить значение этой величины, чтобы получить значение её эквивалента в стандартной СИ.
        /// </summary>
        double ConversionMultipler { get; }
    }

}
