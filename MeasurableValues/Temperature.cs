namespace Foundations.MeasurableValues {

    /// <summary>Температура.</summary>
    /// <remarks>Предопредёленный тип физической величины.</remarks>
    public class Temperature : MeasurableValue {

        public const double Min = -273.15;
        /// <summary>Стандартное название.</summary>
        public new static string Title = "Температура";

        /// <summary>Абсолютный ноль.</summary>
        public const double AbsoluteZero = 0;

        public static Temperature Zero = new Temperature() { Value = 0 };

        /// <summary>Планковская температура, кельвин.</summary>
        /// <remarks><see href="https://ru.wikipedia.org/wiki/Планковская_температура"/></remarks>
        public const double PlankTemperature = 1.416808E+32;

        /// <summary>Создаёт новый экземпляр <see cref="Temperature"/></summary>
        public Temperature() {
            new Temperature(Title, "кельвин", "K");

        }

        private Temperature(string title, string unit, string shortRecord) : base(title, unit, shortRecord) { }
    }

}
