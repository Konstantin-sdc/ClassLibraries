namespace Foundations.Physics.ElementaryParticles {

    /// <summary>Фермион.</summary>
    public interface IFermion : IElementaryParticle {

        /// <summary>Квантовое состояние.</summary>
        // https://ru.wikipedia.org/wiki/Принцип_Паули
        object QuantumState { get; set; }

    }
}
