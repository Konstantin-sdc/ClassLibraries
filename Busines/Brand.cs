using System.Collections.Generic;
using Foundations;

namespace Busines {

    /// <summary>Бренд</summary>
    /// <typeparam name="T">Тип продукта</typeparam>
    public class Brand<T> : BasicComplex, IBrand<T> where T : IBasicComplex {

        /// <summary>Создаёт новый экземпляр <see cref="Brand{T}"/></summary>
        /// <param name="title">Наименование бренда</param>
        /// <param name="owner">Владелец бренда</param>
        public Brand(string title, Contractor owner) : base(title) {
            Owner = owner;
        }

        // NOTE: Для разных стран один продукт может выпускаться под разными брендами.

        /// <summary>Владелец бренда</summary>
        public Contractor Owner { get; set; }

        /// <summary>Продукты бренда</summary>
        public HashSet<IProduct<T>> Products { get; set; }

        public override object Clone() {
            throw new System.NotImplementedException();
        }
    }
}
