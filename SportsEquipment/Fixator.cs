using Foundations;

namespace SportsEquipments {

    /// <summary>Фиксатор</summary>
    public class Fixator : SportEquipment {

        /// <summary>Создаёт новый экземпляр <see cref="Fixator"/></summary>
        /// <param name="title">Имя</param>
        public Fixator(string title) : base(title) { }

        /// <summary>Создаёт новый экземпляр <see cref="Fixator"/></summary>
        /// <param name="title">Имя</param>
        /// <param name="weight">Вес</param>
        public Fixator(string title, int weight) : base(title, weight) { }

        /// <summary>Тип фиксатора</summary>
        // Пружинный 
        // Навинчивающаяся гайка на резьбе
        // Олимпийский 
        // Это класс, а не структура, поскольку конструкции разные бывают даже у одинаковых типов.
        public class FixatorType : BasicComplex {

            /// <summary>Создаёт новый экземпляр <see cref="FixatorType"/></summary>
            /// <param name="title">Имя</param>
            public FixatorType(string title) : base(title) { }

        }

    }

}