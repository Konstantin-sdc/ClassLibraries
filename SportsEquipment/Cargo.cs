namespace SportsEquipments {

    /// <summary>Груз</summary>
    public class Cargo : SportEquipment {

        /// <summary>Создаёт новый экземпляр <see cref="Cargo"/>.</summary>
        /// <param name="title">Имя</param>
        public Cargo(string title) : base(title) { }

        /// <summary>Создаёт новый экземпляр <see cref="Cargo"/>.</summary>
        /// <param name="title">Имя</param>
        /// <param name="weight">Вес</param>
        public Cargo(string title, int weight) : base(title, weight) { }

        /// <summary>Тип снаряда для этого фиксатора</summary>
        public SportEquipment EquipmentType { get; set; }

        /// <summary>Тип фиксации</summary>
        public string FixationType { get; set; }
    }

}