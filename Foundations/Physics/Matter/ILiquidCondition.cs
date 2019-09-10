namespace Foundations.Physics.Matter {

    // UNDONE: Жидкое состояние.
    /// <summary>Агрегатное состояние — жидкость.</summary>
    /// <remarks><see href="https://ru.wikipedia.org/wiki/Жидкость"/></remarks>
    public interface ILiquidCondition : IAggregateCondition {

        /// <summary>Тип структуры расположения элементов.</summary>
        StructureType StructureType { get; set; }

    }
}
