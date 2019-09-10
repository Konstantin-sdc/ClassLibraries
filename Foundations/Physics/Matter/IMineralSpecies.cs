namespace Foundations.Physics.Matter {

    /// <summary>Минеральный вид.</summary>
    public interface IMineralSpecies : IMaterial {

        /// <summary>Кристаллическая структура.</summary>
        ICrystalStructure Structure { get; set; }

    }
}
