namespace Social {
    using System;
    using Foundations;

    /// <summary>Сущность в избранном</summary>
    /// <typeparam name="T">Тип, реализующий <see cref="IBasicComplex"/></typeparam>
    public class Favorite<T> : IInteraction<T> where T : IBasicComplex {

        /// <summary>Создаёт новый экземпляр <see cref="Favorite{T}"/></summary>
        /// <param name="favorEntity">Избранный элемент</param>
        /// <param name="user">Пользователь</param>
        public Favorite(T favorEntity, TestUser user) {
            Entity = favorEntity;
            User = user;
            TimeOfAdd = DateTime.Now;
        }

        /// <summary>Избранная сущность.</summary>
        public T Entity { get; set; }

        /// <summary>Пользователь</summary>
        public TestUser User { get; set; }

        /// <summary>Дата и время добавления.</summary>
        public DateTime TimeOfAdd { get; }

    }
}