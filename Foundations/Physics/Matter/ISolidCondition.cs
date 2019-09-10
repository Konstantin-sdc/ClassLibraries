namespace Foundations.Physics.Matter {

    // https://ru.wikipedia.org/wiki/Твёрдое_тело
    /// <summary>Агрегатное состояние — твёрдое тело.</summary>
    public interface ISolidCondition : ILiquidCondition {

        /// <summary>Твёрдость.</summary>
        IHardness Hardness { get; set; }

        #region Пластичность "https://ru.wikipedia.org/wiki/Пластичность_(физика)"
        /// <summary>Относительное удлинение.</summary>
        double RelativeElongation { get; set; }

        /// <summary>Относительное сужение.</summary>
        double RelativeNarrowing { get; set; }
        #endregion

        #region https://ru.wikipedia.org/wiki/Упругость
        /// <summary>Модуль упругости, паскаль (Pa).</summary>
        double ElasticModulus { get; set; }

        /// <summary>Предел упругости, паскаль (Pa).</summary>
        double ElasticLimit { get; set; }
        #endregion

        // https://ru.wikipedia.org/wiki/Хрупкость
        // https://ru.wikipedia.org/wiki/Предел_прочности
        /// <summary>Предел прочности, паскаль (Pa).</summary>
        double DurabilityLimit { get; set; }

    }
}
