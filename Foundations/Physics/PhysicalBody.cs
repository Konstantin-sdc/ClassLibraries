namespace Foundations.Physics {
    using System.Collections.Generic;
    using Foundations.Geometry;
    using Foundations.Physics.Matter;

    /// <summary>Физическое тело</summary>
    public class PhysicalBody : MaterialPoint, IPhysicalBody {

        #region Constructors
        /// <summary>Создаёт новый экземпляр <see cref="PhysicalBody"/>.</summary>
        public PhysicalBody() {
            _dimensions = new Dictionary<string, double>();
        }

        /// <summary>Создаёт новый экземпляр <see cref="PhysicalBody"/>.</summary>
        /// <param name="title">Название</param>
        public PhysicalBody(string title) : this() {
            Title = title;
        }

        /// <summary>Создаёт новый экземпляр <see cref="PhysicalBody"/>.</summary>
        /// <param name="mass">Масса</param>
        public PhysicalBody(double mass) : this() {
            Mass = mass;
        }

        /// <summary>Создаёт новый экземпляр <see cref="PhysicalBody"/>.</summary>
        /// <param name="bodyMaterial">Материал тела</param>
        public PhysicalBody(Material bodyMaterial) : this() {
            BodyMaterial = bodyMaterial;
        }

        /// <summary>Создаёт новый экземпляр <see cref="PhysicalBody"/>.</summary>
        /// <param name="title">Название.</param>
        /// <param name="mass">Масса.</param>
        public PhysicalBody(string title, int mass) : base(title) {
            Mass = mass;
        }
        #endregion

        /// <summary>Материал тела.</summary>
        public Material BodyMaterial { get; set; }

        /// <summary>Форма</summary>
        public Shape Shape { get; set; }

        /// <summary>Длина</summary>
        public double Length {
            get {
                try {
                    return _dimensions["X"];
                }
                catch(KeyNotFoundException) {
                    throw new System.InvalidOperationException(nameof(Length) + "is not set.");
                }
            }
            set => _dimensions["X"] = value;
        }

        /// <summary>Высота</summary>
        public double Hight {
            get {
                try {
                    return _dimensions["Y"];
                }
                catch(KeyNotFoundException) {
                    throw new System.InvalidOperationException(nameof(Length) + "is not set.");
                }
            }
            set => _dimensions["Y"] = value;
        }

        /// <summary>Ширина</summary>
        public double Width {
            get {
                try {
                    return _dimensions["Z"];
                }
                catch(KeyNotFoundException) {
                    throw new System.InvalidOperationException(nameof(Length) + "is not set.");
                }
            }
            set => _dimensions["Z"] = value;
        }

        private IDictionary<string, double> _dimensions;

        /// <summary>Размеры по осям</summary>
        IDictionary<string, double> IDimensions.Dimensions {
            get => _dimensions;
            set => _dimensions = value;
        }
        IMaterial IPhysicalBody.BodyMaterial { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
    }
}
