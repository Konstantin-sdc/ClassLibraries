namespace Foundations.Geometry {
    using Physics;

    /// <summary>Класс геометрических расширений.</summary>
    public static class GeometryExtensions {

        /// <summary>Возвращает или устанавливает набор координат.</summary>
        private static Coordinates _coordinates { get; set; }

        /// <summary>Возвращает координаты для <see cref="IMaterialPoint"/></summary>
        /// <param name="point">Экземпляр расширяемого интерфейса.</param>
        /// <returns>Координаты.</returns>
        public static Coordinates GetCoordinates(this IMaterialPoint point) {
            return _coordinates;
        }

        /// <summary>Устанавливает координаты для <see cref="IMaterialPoint"/></summary>
        /// <param name="point">Экземпляр расширяемого интерфейса.</param>
        /// <param name="coordinates">Задаваемые координаты.</param>
        /// <returns>Заданные координаты.</returns>
        public static void SetCoordinates(this IMaterialPoint point, Coordinates coordinates) {
            _coordinates = coordinates;
        }
    }
}
