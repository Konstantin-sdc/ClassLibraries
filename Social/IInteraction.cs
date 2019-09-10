using System;
using Foundations;

namespace Social {

    /// <summary>Взаимодействие пользователя и сущности</summary>
    /// <typeparam name="T">Тип, реализующий <see cref="IBasicComplex"/></typeparam>
    public interface IInteraction<T> where T : IBasicComplex {

        /// <summary>Сущность.</summary>
        T Entity { get; set; }

        /// <summary>Время взаимодействия.</summary>
        DateTime TimeOfAdd { get; }

        /// <summary>Пользователь.</summary>
        TestUser User { get; set; }

    }
}