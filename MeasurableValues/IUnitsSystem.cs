namespace Foundations.MeasurableValues {
    using System.Collections.Generic;

    /// <summary>Система единиц.</summary>
    public interface IUnitsSystem : IBasicComplex {

        // UNDONE: Каждый экземпляр этого класса содержит систему единиц (например древнегреческую).
        // NOTE: В инфо по культуре единиц нет.
        // Название и описание локализуемые.
        // Величина — Единица измерения — Сокрашённая запись. Все локализуемы.

        /// <summary>Измеряемые величины.</summary>
        IDictionary<IMeasurableValue, double> MeasurableValues { get; set; }

        /// <summary>Является ли данная СИ стандартной?</summary>
        bool IsStandartSystem { get; set; }

        /// <summary>Содержит ли данная СИ указанный вариант <see cref="IMeasurableValue"/>?</summary>
        /// <param name="measurableValue">Экземпляр <see cref="IMeasurableValue"/> для проверки.</param>
        /// <returns>true, если да.</returns>
        bool Contains(IMeasurableValue measurableValue);
    }

}
