using Foundations;
using Social;

namespace Busines {

    /// <summary>Покупка</summary>
    public class Purchase<T> : Storage<T> where T : IBasicComplex {

        /// <summary>Создаёт новый экземпляр класса <see cref="Purchase"/></summary>
        /// <param name="merchandise">Товар</param> 
        /// <param name="user">Пользователь</param>
        /// <param name="count">Количество</param>
        public Purchase(TestUser user, Merchandise<T> merchandise, int count = 1) : base(merchandise, count) { }

        /// <summary>Покупатель</summary>
        public TestUser User { get; set; }

        /// <summary>Стоимость</summary>
        public decimal Cost { get; set; }
    }
}