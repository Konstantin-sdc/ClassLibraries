namespace Foundations {

    /// <summary>Общие и служебные методы</summary>
    public static class Services<T> {

        /// <summary>
        /// Возвращает результат проверки совпадения типа параметра <paramref name="obj"/> 
        /// с <see cref="T"/>
        /// </summary>
        /// <typeparam name="T">Эталонный <see cref="T"/> для сравнения</typeparam>
        /// <param name="obj">Сравниваемый экземпляр <see cref="object"/></param>
        /// <returns>TRUE, если типы сопадают.</returns>
        public static bool IsSameType(object obj) {
            return obj != null && typeof(T) == obj.GetType();
        }

        /// <summary>
        /// Возвращает результат проверки совпадения типа параметра <paramref name="obj"/> 
        /// с экземпляром <see cref="T"/>
        /// </summary>
        /// <typeparam name="T">Эталонный <see cref="T"/> для сравнения</typeparam>
        /// <param name="current">Экземпляр <see cref="T"/></param>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static bool IsSameType(T current, object obj) {
            return IsSameType(obj);
        }

    }
}
