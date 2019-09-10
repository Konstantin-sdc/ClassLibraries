namespace Foundations.Physics.Matter {

    // UNDONE: Агрегатное состояние.
    // NOTE: Учесть, что свойства состояний это свойства веществ/материалов в этих состояниях а не свойства состояний, как таковых.
    /// <summary>Агрегатное состояние.</summary>
    public interface IAggregateCondition {

        // UNDONE: https://ru.wikipedia.org/wiki/Вязкость
        /// <summary>Вязкость.</summary>
        int Viscosity { get; set; }

    }
}
