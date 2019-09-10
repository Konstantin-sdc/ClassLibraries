namespace Foundations.MeasurableValues {
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Linq;

    /// <summary>Измеряемая величина.</summary>
    public class MeasurableValue : BasicComplex, IMeasurableValue, IEquatable<MeasurableValue> {

        delegate bool Sovpad(string a, string b);

        /// <summary>Создаёт экземпляр <see cref="MeasurableValue"/> с необходимыми параметрами.</summary>
        /// <param name="title">Наименование.</param>
        /// <param name="unitsSystem">Используемая системя единиц.</param>
        /// <param name="dimensionSymbol">Символ размерности.</param>
        /// <param name="unit">Единица измерения.</param>
        /// <param name="sign">Обозначение.</param>
        /// <param name="standartEquivalent">Эквивалент в стандартной системе единиц.</param>
        /// <param name="conversionMultipler">
        /// Множитель, на который следует умножить значение этой величины, чтобы получить значение её эквивалента в стандартной СИ.
        /// </param>
        public MeasurableValue(string title, IUnitsSystem unitsSystem, string dimensionSymbol, string unit, string sign, IMeasurableValue standartEquivalent, double conversionMultipler) {
            IDictionary<IMeasurableValue, double> msv = unitsSystem.MeasurableValues;
            // UNDONE: Доделать и локализовать сообщение об исключении.
            if(unitsSystem.Contains(this)) throw new ArgumentException("QQQ");
            Title = title ?? throw new ArgumentNullException(nameof(title));
            if(unitsSystem.MeasurableValues.Any(u => u.Key.t)) ;
            UnitsSystem = unitsSystem ?? throw new ArgumentNullException(nameof(unitsSystem));
            DimensionSymbol = dimensionSymbol ?? throw new ArgumentNullException(nameof(dimensionSymbol));
            Unit = unit ?? throw new ArgumentNullException(nameof(unit));
            Sign = sign ?? throw new ArgumentNullException(nameof(sign));
            StandartEquivalent = standartEquivalent ?? throw new ArgumentNullException(nameof(standartEquivalent));
            ConversionMultipler = conversionMultipler;
        }

        bool Svp(string a, string b) {

        }

        /// <summary>Используемая система измерений.</summary>
        // Одна на все наследники и экземпляры.
        public IUnitsSystem UnitsSystem { get; private set; }

        /// <summary>Минимум.</summary>
        public double Min {
            get => throw new System.NotImplementedException();
            set => throw new System.NotImplementedException();
        }

        /// <summary>Максимум.</summary>
        public double Max {
            get => throw new System.NotImplementedException();
            set => throw new System.NotImplementedException();
        }

        /// <summary>Символ размерности.</summary>
        public string DimensionSymbol { get; private set; }

        /// <summary>Единица измерения.</summary>
        [Localizable(true)]
        public string Unit { get; private set; }

        /// <summary>Обозначение.</summary>
        /// <remarks>
        /// Обозначения единиц, согласно Брошюре СИ, являются не сокращениями, а математическими объектами. Они входят в международную научную символику <see href="https://www.iso.org"/> ISO 80000 и от языка не зависят, например kg.
        /// </remarks>
        [Localizable(false)]
        public string Sign { get; private set; }

        /// <summary>Эквивалент в стандартной системе единиц.</summary>
        public IMeasurableValue StandartEquivalent { get; private set; }

        /// <summary>
        /// Множитель, на который следует умножить значение этой величины, чтобы получить значение её эквивалента в стандартной СИ.
        /// </summary>
        public double ConversionMultipler { get; private set; }

        /// <summary>Возвращает результат проверки эквивалентности с другим объектом.</summary>
        /// <param name="obj">Объект для сравнения.</param>
        /// <returns>true, если объекты эквивалентны.</returns>
        public override bool Equals(object obj) {
            return Equals(obj as MeasurableValue);
        }

        /// <summary>
        /// <para>
        /// Возвращает результат проверки эквивалентности с другим экземпляром <see cref="MeasurableValue"/>.
        /// </para>
        /// <para>
        /// jjhghjg
        /// </para>
        /// </summary>
        /// <param name="other">Экземпляр для сравнения.</param>
        /// <returns></returns>
        public bool Equals(MeasurableValue other) {
            //return other != null &&
            //       base.Equals(other) &&
            //       EqualityComparer<IUnitsSystem>.Default.Equals(UnitsSystem, other.UnitsSystem) &&
            //       DimensionSymbol == other.DimensionSymbol &&
            //       Unit == other.Unit &&
            //       Sign == other.Sign;
            // NOTE: Возможно, следует изменить BasicComplex, чтобы StringComparisonDefault было достаточно.
            // NOTE: Настроить проверку в рамках одной СИ и между величинами разных СИ. 

            // В разных СИ должны совпадать: (величина или символ размерности) + (единица измерения или обозначение). 

            // Мегаграмм и метрическая тонна эквивалентны, но программно не равны, равны только по значению массы.
            // Масса M килограмм kg | Масса M килограмм kg | 1
            // Масса M грамм g | Масса M килограмм kg | 1000
            // Масса M тонна метрическая t | Масса M килограмм kg | 0.001
            // Масса M мегаграмм Mg | Масса M килограмм kg | 0.001
            // NOTE: В саму СИ внести только, что там есть. Тонны, центнеры и прочее — отдельная производная СИ. Кратные и дольные приставки тоже отдельно.
            // NOTE: В любой СИ только один вариант измеряемой величины является главным, остальные варианты этой величины — производные. 
            // В БД запись значений величин всегда в главном варианте.
            StringComparison comp = StringComparisonDefault;
            bool titleEq = Title.Equals(other.Title, comp) && UnitsSystem.Equals(other.UnitsSystem);
            bool dimEq = DimensionSymbol.Equals(other.DimensionSymbol, comp);
            bool unitEq = Unit.Equals(other.Unit, comp);
            bool signEq = Sign.Equals(other.Sign, comp);
            return other != null &&
                (titleEq || dimEq || unitEq || signEq);
        }

        /// <summary>
        /// Возвращает результат проверки эквивалентности с другим экземпляром <see cref="MeasurableValue"/> в той же <see cref="IUnitsSystem"/>
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        bool EqualsSameSystem(MeasurableValue other) {
            // В рамках одной СИ достаточно совпадения по одному из параметров.
            return UnitsSystem == other.UnitsSystem && (
                Title == other.Title ||
                DimensionSymbol == other.DimensionSymbol ||
                Unit == other.Unit ||
                Sign == other.Sign
                );
        }

        public override int GetHashCode() {
            var hashCode = -784065415;
            hashCode = hashCode * -1521134295 + base.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<IUnitsSystem>.Default.GetHashCode(UnitsSystem);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(DimensionSymbol);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Unit);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Sign);
            return hashCode;
        }

        public static bool operator ==(MeasurableValue left, MeasurableValue right) {
            return EqualityComparer<MeasurableValue>.Default.Equals(left, right);
        }

        public static bool operator !=(MeasurableValue left, MeasurableValue right) {
            return !(left == right);
        }
    }

}
