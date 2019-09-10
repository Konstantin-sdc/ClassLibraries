using System.Collections.Generic;

namespace SportsEquipments.FreeWeights {

    /// <summary>Свободный вес</summary>
    public abstract class FreeWeight : SportEquipment {

        protected FreeWeight(string title) : base(title) { }

        protected FreeWeight(string title, int weight) : base(title, weight) { }

        /// <summary>Гриф</summary>
        public Handle Grief { get; set; }

        /// <summary>Груз</summary>
        public IDictionary<Cargo, int> Cargos { get; set; }

        /// <summary>Разборная или неразборная конструкция.</summary>
        public bool IsSeparable => Fixator != null;

        /// <summary>Фиксатор</summary>
        public Fixator Fixator { get; set; }

    }
}
