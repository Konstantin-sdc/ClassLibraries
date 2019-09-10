using System;
using Foundations;
using Foundations.Metrology;

namespace Busines {

    // TODO: Поставщик относится к товару, а не к продукту. Ибо поставка подразумевает двусторонние бизнес-отношения.
    /// <summary>Товар.</summary>
    /// <typeparam name="T">Сущность товара.</typeparam>
    public class Merchandise<T> where T : IBasicComplex {

        /// <summary>Создаёт новый экземпляр <see cref="Merchandise{T}"/></summary>
        /// <param name="product">Продукт.</param>
        /// <param name="price">Цена за единицу.</param>
        public Merchandise(Product<T> product, decimal price) {
            Product = product ?? throw new ArgumentNullException(nameof(product));
            Price = price;
        }

        /// <summary>Создаёт новый экземпляр <see cref="Merchandise{T}"/></summary>
        /// <param name="entity">Сущность товара.</param>
        /// <param name="price">Цена за единицу.</param>
        public Merchandise(T entity, MetricUnit unit, decimal price) {
            Product = new Product<T>(entity, unit);
            Price = price;
        }

        /// <summary>Продукт.</summary>
        public Product<T> Product { get; set; }

        /// <summary>Цена за единицу.</summary>
        public decimal Price { get; set; }

        /// <summary>Поставщик.</summary>
        public Contractor Provider { get; set; }

    }
}