namespace Foundations.Physics.Matter {
    using Foundations.Geometry;

    /// <summary>Кристаллическая структура.</summary>
    // UNDONE: https://ru.wikipedia.org/wiki/Кристаллическая_структура
    public interface ICrystalStructure {

        /// <summary>Кристаллическая решётка.</summary>
        ICrystallCell CrystallCell { get; set; }

        /// <summary>Мотивная единица.</summary>
        // UNDONE: В кристаллах это атомы, группы атомов, молекулы.
        object MotiveUnit { get; set; }
    }
}
