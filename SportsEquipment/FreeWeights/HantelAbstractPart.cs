namespace SportsEquipments.FreeWeights {

    /// <summary>Деталь гантели.</summary>
    public class HantelAbstractPart : FreeWeight {

        #region Constructors
        /// <summary>Создаёт новый экземпляр класса <see cref="HantelAbstractPart"/></summary>
        /// <param name="title">Имя</param>
        protected HantelAbstractPart(string title) : base(title) { }

        /// <summary>Создаёт новый экземпляр класса <see cref="HantelDetail"/></summary>
        /// <param name="title">Имя</param>
        /// <param name="model">Модель</param>
        public HantelAbstractPart(string title, string model) : base(title) { }

        /// <summary>Создаёт новый экземпляр класса <see cref="HantelAbstractPart"/></summary>
        /// <param name="title">Имя</param>
        /// <param name="model">Модель</param>
        /// <param name="weight">Вес</param>
        public HantelAbstractPart(string title, int weight, string model) : base(title) {
            Mass = weight;
        }
        #endregion

        /// <summary>Посадочный диаметр</summary>
        public int LandingDiameter { get; set; }

        /// <summary>Габаритный диаметр</summary>
        public int OverallDiameter { get; set; }

    }

}