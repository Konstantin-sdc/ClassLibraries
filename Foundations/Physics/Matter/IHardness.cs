
namespace Foundations.Physics.Matter {
    using System.Collections.Generic;

    /// <summary>Твёрдость.</summary>
    /// <remarks><see href="https://ru.wikipedia.org/wiki/Твёрдость"/></remarks>
    public interface IHardness {

        /// <summary>Методы измерения и величины.</summary>
        IDictionary<string, double> Methods { get; set; }

        /// <summary>Максимальная твёрдость по шкале Мооса.</summary>
        MohsScale MohsScaleMax { get; set; }

        /// <summary>Минимальная твёрдость по шкале Мооса.</summary>
        MohsScale MohsScaleMin { get; set; }

    }

}