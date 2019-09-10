using System.Collections.Generic;

namespace Foundations.Geometry {

    /// <summary>Размеры</summary>
    public interface IDimensions {

        /// <summary>Размеры по осям</summary>
        IDictionary<string, double> Dimensions { get; set; }

        /// <summary>Высота</summary>
        double Hight { get; set; }

        /// <summary>Длина</summary>
        double Length { get; set; }

        /// <summary>Ширина</summary>
        double Width { get; set; }
    }
}