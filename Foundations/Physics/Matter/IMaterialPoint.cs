namespace Foundations.Physics {
    using Geometry;

    /// <summary>Материальная точка.</summary>
    public interface IMaterialPoint : IGeometricPoint {

        /// <summary>Масса.</summary>
        double Mass { get; set; }
    }

}