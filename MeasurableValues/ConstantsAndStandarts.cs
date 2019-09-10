namespace Foundations.MeasurableValues {

    /// <summary>Физические константы и стандартные величины.</summary>
    public static class ConstantsAndStandarts {

        /// <summary>Стандартные условия, согласно IUPAC.</summary>
        public static class IUPAC {

            /// <summary>Стандартное давление для газов жидкостей и твёрдых тел, паскаль (Pa). </summary>
            public const int Pressure = 100000;

            /// <summary>Стандартная температура для газов, кельвин (K).</summary>
            public const double Temperature = 273.15;

            /// <summary>Стандартная молярность для расстворов, моль/л.</summary>
            public const int Molarity = 1;

        }

        /// <summary>Нормальное давление, паскаль (Pa).</summary>
        public const int NormalPressure = 101325;

        /// <summary>Стандартная температура в термодинамике, кельвин (K).</summary>
        public const double StandardThermodynamicTemperature = 298.15;

        public const int Qwe = IUPAC.Pressure;
    }
}
