using System;
using Foundations;

namespace Social {

    /// <summary>Отзыв пользователя</summary>
    public class Rating<T> : Favorite<T> where T : IBasicComplex {

        /// <summary>Создаёт новый экземпляр <see cref="Rating{T}"/></summary>
        /// <param name="subject">Объект оценки</param>
        /// <param name="user">Пользователь</param>
        /// <param name="integralImpression">Обшее впечатление.</param>
        public Rating(T subject, TestUser user, string integralImpression) : base(subject, user) {
            Title = integralImpression;
        }

        /// <summary>Баллы</summary>
        public RatingEnum Points { get; set; }

        /// <summary>Достоинства</summary>
        public string Goodies { get; set; }

        /// <summary>Недостатки</summary>
        public string Minuses { get; set; }

        /// <summary>Общее впечатление.</summary>
        public string Title { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        /// <summary>Комментарий.</summary>
        public string Description { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        /// <summary>Недоступно.</summary>
        /// <returns><see cref="NotImplementedException"/></returns>
        public object Clone() {
            throw new NotImplementedException();
        }

        /// <summary>Оценка в баллах</summary>
        public enum RatingEnum {
            /// <summary>Неприемлемо</summary>
            Unacceptable = -1,
            /// <summary>Отвратительно</summary>
            Disgusting,
            /// <summary>Плохо</summary>
            Poorly,
            /// <summary>Посредственно</summary>
            Mediocre,
            /// <summary>Хорошо</summary>
            Good,
            /// <summary>Отлично</summary>
            Fine,
            /// <summary>Идеально</summary>
            Perfect
        }

    }

}