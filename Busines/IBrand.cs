using System.Collections.Generic;
using Foundations;

namespace Busines {

    /// <summary>Бренд</summary>
    /// <typeparam name="T">Тип продукта</typeparam>
    public interface IBrand<T> where T : IBasicComplex {

        /// <summary>Владелец бренда</summary>
        Contractor Owner { get; set; }

        /// <summary>Продукты бренда</summary>
        HashSet<IProduct<T>> Products { get; set; }

    }
}