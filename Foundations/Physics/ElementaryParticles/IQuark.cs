namespace Foundations.Physics.ElementaryParticles {

    /// <summary>Кварк.</summary>
    interface IQuark : IFermion {

        /// <summary>Поколение.</summary>
        // https://ru.wikipedia.org/wiki/Поколение_(физика)
        sbyte Generation { get; set; }

        /// <summary>Аромат.</summary>
        Flavour Flavour { get; set; }

        /// <summary>Цветовой заряд.</summary>
        ColorCharge ColorCharge { get; set; }

        /// <summary>Дробный электрический заряд (в электронах).</summary>
        /// <remarks>Для кварка кратен 1/3 заряда электрона.</remarks>
        float ElectricChargeFractional { get; set; }


    }
}
