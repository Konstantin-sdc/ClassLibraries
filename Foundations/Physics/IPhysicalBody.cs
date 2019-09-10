namespace Foundations.Physics {
    using Foundations.Geometry;
    using Foundations.Physics.Matter;

    /// <summary>Физическое тело</summary>
    public interface IPhysicalBody : IMaterialPoint, IDimensions {

        /// <summary>Материал</summary>
        IMaterial BodyMaterial { get; set; }

        /// <summary>Форма</summary>
        Shape Shape { get; set; }

    }
}