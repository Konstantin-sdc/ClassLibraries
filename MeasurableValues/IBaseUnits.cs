namespace Foundations.MeasurableValues {

    /// <summary>Основные единицы измерения.</summary>
    public interface IBaseUnits {
        // Для каждой величины нужны ссылка на применяемую СИ и на имя величины в этой СИ.
        // Ссылка на СИ и имя величины —> Имя величины —> Параметры величины.

        //[UnitSystem(nameof(Mass), "M", "килограмм", "кг")]
        double Length { get; set; }

        double Mass { get; set; }

        double Time { get; set; }


    }
}
