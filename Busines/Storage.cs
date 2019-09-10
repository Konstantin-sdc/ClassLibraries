using Foundations;
namespace Busines {

    /// <summary>Товар на складе</summary>
    public class Storage<T> : MerchandiseAction<T> where T : IBasicComplex {

        /// <summary>Создаёт новый экземпляр класса <see cref="Storage"/></summary>
        /// <param name="merchandise">Товар</param>
        /// <param name="count">Количество</param>
        public Storage(Merchandise<T> merchandise, int count = 1) : base(merchandise) {
            Merchandise = merchandise;
            Count = count;
        }

        /// <summary>Доступное количество</summary>
        public double Count { get; set; }

        public override object Clone() {
            throw new System.NotImplementedException();
        }
    }
}