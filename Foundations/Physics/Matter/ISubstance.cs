namespace Foundations.Physics.Matter {
    using System.Collections.Generic;
    using ElementaryParticles;

    /// <summary>Вещество.</summary>
    public interface ISubstance : IMatter {

        /// <summary>Массовые доли элементарных частиц.</summary>
        IDictionary<IElementaryParticle, double> Elements { get; set; }

        /// <summary>Химический состав. Массовые доли составляющих веществ.</summary>
        IDictionary<ISubstance, double> ChemicalComposition { get; set; }

        /// <summary>Тип связи между элементами вещества.</summary>
        ConnectionType ConnectionType { get; set; }

    }

}
