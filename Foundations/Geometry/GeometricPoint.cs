namespace Foundations.Geometry {
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using FndRes = Properties.Resources;

    /// <summary>Геометрическая точка. Определяется только своими координатами.</summary>
    [Serializable]
    [Display(
        ResourceType = typeof(FndRes),
        Name = "GeometricPointName",
        Description = "GeometricPointDesc")]
    [Localizable(true)]
    public class GeometricPoint : BasicComplex, IGeometricPoint, IComparable, IComparable<GeometricPoint>,
        IEqualityComparer<GeometricPoint>, IEquatable<GeometricPoint> {

        /// <summary>Создаёт новый экземпляр <see cref="GeometricPoint"/>.</summary>
        public GeometricPoint() { }

        /// <summary>Создаёт новый экземпляр <see cref="GeometricPoint"/> с заданными координатами.</summary>
        /// <param name="coordinates"></param>
        public GeometricPoint(Coordinates coordinates) {
            Coordinates = coordinates ?? throw new ArgumentNullException(nameof(coordinates));
        }

        /// <summary>Координаты точки, указывающие её положение в пространстве.</summary>
        /// <remarks>Необязательно трехмерные.</remarks>
        [Display(
            ResourceType = typeof(FndRes),
            Name = "CoordsName",
            Description = "CoordsDesc",
            GroupName = "MeasuredParameters")]
        public Coordinates Coordinates {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }

        /// <summary>Сравнивает данный экземпляр <see cref="GeometricPoint"/> с другим для определения порядка сортировки.</summary>
        /// <remarks>Доступно для переопределения.</remarks>
        /// <param name="other">Экземпляр для сравнения.</param>
        /// <returns>Меньше 0. Данный экземпляр предшествует параметру <paramref name="other"/> в порядке сортировки.</returns>
        /// <returns>Равно 0. Данный экземпляр занимает ту же позицию в порядке сортировки, что и <paramref name="other"/>.</returns>
        /// <returns>Меньше 0. Данный экземпляр следует за параметром <paramref name="other"/> в порядке сортировки.</returns>
        [Display(
            ResourceType = typeof(FndRes),
            Name = "CompareForSort",
            Description = "CompareToOtherDesc",
            GroupName = "DataComparisonGroup")]
        public int CompareTo(GeometricPoint other) {
            int result = CompareTo(other as BasicComplex);
            return (result == 0) ? Coordinates.CompareTo(other.Coordinates) : result;
        }

        /// <summary>Возвращает результат проверки эквивалентности текущего экземпляра <see cref="GeometricPoint"/> с другим объектом.</summary>
        /// <param name="obj"><see cref="object"/> для сравнения</param>
        /// <returns>True, если результат положителен.</returns>
        /// <returns>False, если результат отрицателен.</returns>
        [Display(
            ResourceType = typeof(FndRes),
            Name = "EqualsObjectName",
            Description = "EqualsObjectDesc",
            GroupName = "DataComparisonGroup")]
        public override bool Equals(object obj) {
            return Equals(obj as GeometricPoint);
        }

        /// <summary>Возвращает результат проверки эквивалентности текущего экземпляра <see cref="GeometricPoint"/> с другим экземпляром</summary>
        /// <param name="other">Экземпляр для сравнения</param>
        /// <returns>True, если результат положителен.</returns>
        /// <returns>False, если результат отрицателен.</returns>
        [Display(
            ResourceType = typeof(FndRes),
            Name = "EqualsOtherName",
            Description = "EqualsOtherDesc",
            GroupName = "DataComparisonGroup")]
        public bool Equals(GeometricPoint other) {
            return base.Equals(other)
                && Coordinates.Equals(other.Coordinates);
        }

        /// <summary>Определяет, эквивалентны ли два указанных экземпляра <see cref="GeometricPoint"/>.</summary>
        /// <param name="x">Первый сравниваемый объект</param>
        /// <param name="y">Второй сравниваемый объект</param>
        /// <returns>True, если указанные объекты равны</returns>
        /// <returns>False, если указанные объекты неравны</returns>
        /// <exception cref="ArgumentNullException">Один или оба параметра == null</exception>
        [Display(
            ResourceType = typeof(FndRes),
            Name = "EqualsTwoName",
            GroupName = "DataComparisonGroup")]
        public bool Equals(GeometricPoint x, GeometricPoint y) {
            return x.Equals(y);
        }

        /// <summary>Возвращает хэш-код текущего экземпляра <see cref="GeometricPoint"/></summary>
        /// <returns>Значение хэш-кода</returns>
        [Display(
            ResourceType = typeof(FndRes),
            Name = "HashCodeCurrent",
            GroupName = "DataComparisonGroup")]
        [DataObjectMethod(DataObjectMethodType.Select)]
        public override int GetHashCode() {
            var hashCode = 318434654;
            hashCode = hashCode * -1521134295 + base.GetHashCode();
            hashCode = hashCode * -1521134295 + Coordinates.GetHashCode();
            return hashCode;
        }

        /// <summary>Возвращает хэш-код указанного экземпляра <see cref="GeometricPoint"/>.</summary>
        /// <remarks>Доступно для переопределения.</remarks>
        /// <param name="obj"> Объект, для которого необходимо вернуть хэш-код</param>
        /// <returns>Хэш-код указанного объекта.</returns>
        /// <exception cref="ArgumentNullException"><paramref name="obj"/> == null</exception>
        [Display(
            ResourceType = typeof(FndRes),
            Name = "HashCodeTarget",
            GroupName = "DataComparisonGroup")]
        [DataObjectMethod(DataObjectMethodType.Select)]
        public int GetHashCode(GeometricPoint obj) {
            if(obj == null) {
                throw new ArgumentNullException(nameof(obj));
            }
            return obj.GetHashCode();
        }

        /// <summary>Возвращает результат проверки двух экземпляров <see cref="GeometricPoint"/> на равенство по значениям.</summary>
        /// <remarks>Проверяет равенство по значениям членов экземпляра.</remarks>
        /// <param name="left">Левый операнд.</param>
        /// <param name="right">Правый операнд.</param>
        /// <returns>True, если операнды равны.</returns>
        [Display(
            ResourceType = typeof(FndRes),
            Name = "ParityName",
            Description = "ParityDesc",
            GroupName = "DataComparisonGroup")]
        public static bool operator ==(GeometricPoint left, GeometricPoint right) {
            return (left as BasicComplex) == (right as BasicComplex)
                && left.Coordinates == right.Coordinates;
        }

        /// <summary>Возвращает результат проверки на неравенство по значениям двух экземпляров <see cref="GeometricPoint"/>.</summary>
        /// <remarks>Проверяет неравенство по значениям членов экземпляра.</remarks>
        /// <param name="left">Левый операнд</param>
        /// <param name="right">Правый операнд</param>
        /// <returns>True, если операнды неравны.</returns>
        [Display(
            ResourceType = typeof(FndRes),
            Name = "UnParityName",
            Description = "UnParityDesc",
            GroupName = "DataComparisonGroup")]
        public static bool operator !=(GeometricPoint left, GeometricPoint right) {
            return !(left == right);
        }

    }
}
