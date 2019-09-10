namespace Foundations.Physics.ElementaryParticles {

    /// <summary>Адрон.</summary>
    interface IAdron : IElementaryParticle {

        /// <summary>Изотопический спин.</summary>
        // https://ru.wikipedia.org/wiki/Изотопический_спин
        float IsotopicSpin { get; set; }

    }
}
