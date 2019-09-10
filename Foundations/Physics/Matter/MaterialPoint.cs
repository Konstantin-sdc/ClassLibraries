namespace Foundations.Physics {
    using Foundations.Geometry;

    /// <summary>Материальная точка.</summary>
    public class MaterialPoint : BasicComplex, IMaterialPoint {

        /// <summary>Масса</summary>
        public double Mass { get; set; }
        double IMaterialPoint.Mass { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        Coordinates IGeometricPoint.Coordinates { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

        #region Constructors
        /// <summary>Создаёт новый экземпляр <see cref="MaterialPoint"/>.</summary>
        protected MaterialPoint() { }

        /// <summary>Создаёт новый экземпляр <see cref="MaterialPoint"/>.</summary>
        /// <param name="title">Название</param>
        protected MaterialPoint(string title) : base(title) { }

        /// <summary>Создаёт новый экземпляр <see cref="MaterialPoint"/>.</summary>
        /// <param name="mass">Масса</param>
        public MaterialPoint(double mass) {
            Mass = mass;
        }

        /// <summary>Создаёт новый экземпляр <see cref="MaterialPoint"/>.</summary>
        /// <param name="title">Название</param>
        /// <param name="mass">Масса</param>
        public MaterialPoint(string title, int mass) : base(title) {
            Mass = mass;
        }
        #endregion

    }
}
