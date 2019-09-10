using Foundations;
namespace Busines {
    /// <summary>Абстрактный класс для взаимодействий с товаром</summary>
    public abstract class MerchandiseAction<T> : BasicComplex where T : IBasicComplex {

        /// <summary>Создаёт новый экземпляр класса <see cref="Merchandise"/></summary>
        /// <param name="merchandise">Товар</param>
        protected MerchandiseAction(Merchandise<T> merchandise) {
            Merchandise = merchandise;
        }

        /// <summary>Товар</summary>
        public Merchandise<T> Merchandise { get; set; }

    }
}