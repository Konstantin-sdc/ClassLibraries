namespace Foundations.Physics.Matter {
    using System.Collections.Generic;
    using System.Drawing;

    // NOTE: Углерод — вещество, графит, алмаз — материалы. Разделять по такому принципу.

    /// <summary>Материал.</summary>
    public interface IMaterial : ISubstance {

        /// <summary>Цвет материала.</summary>
        Color Color { get; set; }

        // NOTE: Разнообразное свойство, возможно нужно выделить его в подкласс или отделный класс или структуру.
        /// <summary>Плотность материала при стандартных условиях.</summary>
        double Density { get; set; }

        /// <summary>Свойства, в зависимости от условий.</summary>
        SortedDictionary<double, object> PhysicalProperties { get; set; }
    }
}