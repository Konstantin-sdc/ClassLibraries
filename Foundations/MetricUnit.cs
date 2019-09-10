namespace Foundations.Metrology {

    /// <summary>Единица измерения.</summary>
    public class MetricUnit : BasicComplex {

        /// <summary>Создаёт новый экземпляр <see cref="MetricUnit"/></summary>
        /// <param name="title">Имя.</param>
        public MetricUnit(string title) : base(title) { }

        /// <summary>Сокращённое название.</summary>
        public string ShortTitle { get; set; }

    }

}