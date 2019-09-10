namespace Foundations.Physics.Matter {
    using System.Collections.Generic;
    using Foundations.Physics.ElementaryParticles;

    /// <summary>Материал</summary>
    public class Material : BasicComplex, IMaterial {

        /// <summary>Создаёт новый экземпляр <see cref="Material"/></summary>
        /// <param name="title">Имя</param>
        public Material(string title) : base(title) { }

        /// <summary>Плотность</summary>
        public double Density { get; set; }

        /// <summary>Цвет материала</summary>
        public System.Drawing.Color Color { get; set; }

        /// <summary>Массовые доли составляющих веществ.</summary>
        public IDictionary<ISubstance, float> Substances { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        public SortedDictionary<double, object> PhysicalProperties { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        public IDictionary<IElementaryParticle, double> Elements { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        public IDictionary<ISubstance, double> ChemicalComposition { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        public ConnectionType ConnectionType { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
    }

}