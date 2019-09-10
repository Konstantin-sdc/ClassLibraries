namespace SportsEquipments.FreeWeights {

    /// <summary>Гантель</summary>
    // Гантель это разновидность гири.

    public class Hantel : FreeWeight {

        /// <summary>Создаёт новый экземпляр <see cref="Hantel"/></summary>
        /// <param name="name">Имя</param>
        public Hantel(string name) : base(name) { }
    }

}