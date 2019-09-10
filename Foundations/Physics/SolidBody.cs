namespace Foundations.Physics {
    using Foundations.Geometry;
    using Foundations.Physics.Matter;

    /// <summary>Твёрдое тело.</summary>
    public class SolidBody : PhysicalBody {

        #region Constructors
        /// <summary>Создаёт новый экземпляр <see cref="SolidBody"/>.</summary>
        public SolidBody() : base() { }

        /// <summary>Создаёт новый экземпляр класса <see cref="SolidBody"/>.</summary>
        /// <param name="title">Название.</param>
        public SolidBody(string title) : base(title) { }

        /// <summary>Создаёт новый экземпляр класса <see cref="SolidBody"/>.</summary>
        /// <param name="weight">Масса.</param>
        public SolidBody(int weight) : base(weight) { }

        /// <summary>Создаёт новый экземпляр класса <see cref="SolidBody"/>.</summary>
        /// <param name="title">Название.</param>
        /// <param name="weght">Масса.</param>
        public SolidBody(string title, int weght) : base(title, weght) { }
        #endregion

        /// <summary>Материал наполнителя</summary>
        public Material FillerMaterial { get; set; }

        /// <summary>Материал покрытия.</summary>
        public Material CoatingMaterial { get; set; }

        /// <summary>Место покрытия</summary>
        public CoatingPlace CoatingPlace { get; set; }

        // TODO: Рельеф поверхности SurfaceRelief
        // TODO: Гравировка выпуклая или вогнутая.
    }
}
