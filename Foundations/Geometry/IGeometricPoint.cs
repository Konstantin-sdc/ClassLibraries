namespace Foundations.Geometry {
    using System.ComponentModel.DataAnnotations;
    using FndRes = Properties.Resources;

    // NOTE: Для многих классов и интервесов этот класс должен быть классом расширения.
    /// <summary>Геометрическая точка. Определяется только своими координатами.</summary>
    public interface IGeometricPoint : IBasicComplex {

        /// <summary>Координаты точки, указывающие её положение в пространстве.</summary>
        [Display(
            ResourceType = typeof(FndRes),
            Name = "CoordsName",
            Description = "CoordsDesc",
            GroupName = "MeasuredParameters")]
        Coordinates Coordinates { get; set; }

    }
}
