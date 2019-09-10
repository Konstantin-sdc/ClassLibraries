namespace Foundations {
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using FndRes = Properties.Resources;

    /// <summary>
    /// Представляет базовый набор данных для всех производных классов.
    /// <para/>
    /// <list type="number">
    /// <listheader>
    /// <term>Состоит из следующих данных:</term>
    /// </listheader>
    /// <para/>
    /// <item>
    /// <term><see cref="Title"/></term>
    /// <description> — Наименование</description>
    /// </item>
    /// <para/>
    /// <item>
    /// <term><see cref="Description"/></term>
    /// <description> — Описание</description>
    /// </item>
    /// </list>
    /// </summary>
    [Serializable]
    [Display(
        ResourceType = typeof(FndRes),
        Name = "BasicComplexName",
        Description = "BasicComplexDesc")]
    [Localizable(true)]
    [DefaultProperty(nameof(Title))]
    public abstract class BasicComplex : IBasicComplex, IComparable, IComparable<BasicComplex>,
        IEqualityComparer<BasicComplex>, IEquatable<BasicComplex> {

        #region Fields, Properies...
        /// <summary>Служебное поле для <see cref="Title"/></summary>
        [NonSerialized]
        private string _title;
        /// <summary>Служебное поле для <see cref="Description"/></summary>
        [NonSerialized]
        private string _description;

        /// <summary>Общая часть сообщений для <see cref="ArgumentException"/></summary>
        /// <param name="callerName">Метод, вызвавший исключение</param>
        /// <returns>Строка сообщения</returns>
        private static string ArgumentExceptionMessage(string callerName) {
            return $"{FndRes.ArgumentExceptionMessage} {callerName}.";
        }

        /// <summary>Описание ошибки неверного состава строки</summary>
        /// <remarks>Доступно для переопределения.</remarks>
        protected virtual string InvalidStringDescripttion => FndRes.InvalidStringDescripttion;

        /// <summary>Проверяет строку на корректность, генерирует исключение, если строка некорректна.</summary>
        /// <remarks>Доступно для переопределения.</remarks>
        /// <param name="checkString">Строка для проверки</param>
        /// <param name="callerName">Имя вызывающего метода</param>
        /// <exception cref="ArgumentException">Генерируется, если строка некорректна</exception>
        protected virtual void StringValidation(string checkString, [CallerMemberName]string callerName = null) {
            bool isNotValid = checkString.All(c => char.IsSeparator(c)) || checkString.Length == 0;
            if(isNotValid) {
                var typeName = GetType().Name;
                var source = $"{typeName}.{callerName}";
                var message = ArgumentExceptionMessage(source);
                message = $"{message} {InvalidStringDescripttion}";
                throw
                    new ArgumentException(message) { Source = source };
            }
        }

        /// <summary>Наименование</summary>
        /// <remarks>Доступно для переопределения.</remarks>
        [Display(
            ResourceType = typeof(FndRes),
            Name = "TitleName",
            Description = "TitleDesc",
            GroupName = "BasicDataGroup")]
        [Localizable(true)]
        [AttributeProvider(nameof(BasicComplex), nameof(Title))]
        public virtual string Title {
            get => _title;
            set {
                StringValidation(value);
                _title = value?.Trim() ?? value;
            }
        }

        /// <summary>Описание.</summary>
        [Display(
            ResourceType = typeof(FndRes),
            Name = "DescriptionName",
            Description = "DescriptionDesc",
            GroupName = "BasicDataGroup")]
        [Localizable(true)]
        public string Description {
            get => _description;
            set {
                StringValidation(value);
                _description = value?.Trim() ?? value;
            }
        }

        /// <summary>Правило проверки строк на <see cref="string.Equals(string, StringComparison)"/> = <see cref="StringComparison.InvariantCultureIgnoreCase"/>.</summary>
        [DefaultValue(StringComparison.InvariantCultureIgnoreCase)]
        [Display(
            ResourceType = typeof(FndRes),
            Name = "StringComparisonName",
            Description = "StringComparisonDesc",
            GroupName = "DataComparisonGroup")]
        [Localizable(true)]
        public StringComparison StringComparison { get; set; } = StringComparison.InvariantCultureIgnoreCase;

        /// <summary>Правило проверки строк на эквивалентность по умолчанию</summary>
        [DefaultValue(StringComparison.InvariantCultureIgnoreCase)]
        [DisplayName("Правило сравнения строк на эквивалентность по умолчанию")]
        [Display(Name = "Правило сравнения строк на эквивалентность по умолчанию",
            GroupName = "DataComparisonGroup")]
        [Localizable(true)]
        public static StringComparison StringComparisonDefault => StringComparison.InvariantCultureIgnoreCase;
        #endregion

        #region Constructors
        /// <summary>Создаёт пустой экземпляр <see cref="BasicComplex"/></summary>
        protected BasicComplex() { }

        /// <summary>Создаёт экземпляр с определённым наименованием</summary>
        /// <param name="title">Имя</param>
        protected BasicComplex(string title) : this() {
            Title = title ?? throw new ArgumentNullException(nameof(title));
        }

        /// <summary>Создаёт экземпляр с определёнными наименованием и описанием</summary>
        /// <param name="title"></param>
        /// <param name="description"></param>
        protected BasicComplex(string title, string description) : this(title) {
            Description = description ?? throw new ArgumentNullException(nameof(description));
        }
        #endregion

        #region Comparsion
        #region Equals
        /// <summary>
        /// Возвращает результат проверки совпадения типа экземпляра <see cref="object"/> 
        /// с типом текущего экземпляра.
        /// </summary>
        /// <param name="obj">Сравниваемый экземпляр <see cref="object"/></param>
        /// <returns>TRUE, если типы совпадают.</returns>
        protected bool IsSameType(object obj) {
            return obj.GetType() == GetType();
        }

        /// <summary>Возвращает результат проверки эквивалентности текущего экземпляра <see cref="BasicComplex"/> с другим объектом.</summary>
        /// <param name="obj"><see cref="object"/> для сравнения</param>
        /// <returns>True, если результат положителен.</returns>
        /// <returns>False, если результат отрицателен.</returns>
        [Display(
            ResourceType = typeof(FndRes),
            Name = "EqualsObjectName",
            Description = "EqualsObjectDesc",
            GroupName = "DataComparisonGroup")]
        public override bool Equals(object obj) {
            if(obj == null) {
                throw new ArgumentNullException(nameof(obj));
            }
            return Equals(obj as BasicComplex);
        }

        /// <summary>Возвращает результат проверки эквивалентности текущего экземпляра <see cref="BasicComplex"/> с другим экземпляром</summary>
        /// <param name="other">Экземпляр для сравнения</param>
        /// <returns>True, если результат положителен.</returns>
        /// <returns>False, если результат отрицателен.</returns>
        [Display(
            ResourceType = typeof(FndRes),
            Name = "EqualsOtherName",
            Description = "EqualsOtherDesc",
            GroupName = "DataComparisonGroup")]
        public bool Equals(BasicComplex other) {
            if(other == null) {
                throw new ArgumentNullException(nameof(other));
            }
            StringComparison stringComparison = StringComparison;
            if(StringComparison != other.StringComparison) {
                stringComparison = StringComparisonDefault;
            }
            return other != null
                && Title.Equals(other.Title, stringComparison)
                && Description.Equals(other.Description, stringComparison);
        }

        /// <summary>Определяет, эквивалентны ли два указанных экземпляра <see cref="BasicComplex"/>.</summary>
        /// <param name="x">Первый сравниваемый объект</param>
        /// <param name="y">Второй сравниваемый объект</param>
        /// <returns>True, если указанные объекты равны</returns>
        /// <returns>False, если указанные объекты неравны</returns>
        /// <exception cref="ArgumentNullException">Один или оба параметра == null</exception>
        [Display(
            ResourceType = typeof(FndRes),
            Name = "EqualsTwoName",
            GroupName = "DataComparisonGroup")]
        public bool Equals(BasicComplex x, BasicComplex y) {
            if(x == null) {
                throw new ArgumentNullException(nameof(x));
            }
            if(y == null) {
                throw new ArgumentNullException(nameof(y));
            }
            return x.Equals(y);
        }
        #endregion

        /// <summary>
        /// Сравнивает текущий экземпляр с другим объектом того же типа и возвращает целое число, 
        /// которое показывает, расположен ли текущий экземпляр перед, после или на той же позиции 
        /// в порядке сортировки, что и другой объект.
        /// </summary>
        /// <remarks>Доступно для переопределения.</remarks>
        /// <param name="obj">Объект для сравнения с данным экземпляром.</param>
        /// <returns>Меньше 0. Данный экземпляр предшествует параметру <paramref name="obj"/> в порядке сортировки.</returns>
        /// <returns>Равно 0. Данный экземпляр занимает ту же позицию в порядке сортировки, что и <paramref name="obj"/>.</returns>
        /// <returns>Меньше 0. Данный экземпляр следует за параметром <paramref name="obj"/> в порядке сортировки.</returns>
        /// <exception cref="ArgumentException">Параметр <paramref name="obj"/> несовместим с данным типом.</exception>
        [Display(
            ResourceType = typeof(FndRes),
            Name = "CompareForSort",
            Description = "CompareToObjectDesc",
            GroupName = "DataComparisonGroup")]
        public int CompareTo(object obj) {
            if(obj == null) {
                throw new ArgumentNullException(nameof(obj));
            }
            if(!(obj is BasicComplex)) {
                throw new ArgumentException("Параметр несовместим с данным типом.", nameof(obj));
            }
            return CompareTo(obj as BasicComplex);
        }

        /// <summary>Сравнивает данный экземпляр <see cref="BasicComplex"/> с другим для определения порядка сортировки.</summary>
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
        public int CompareTo(BasicComplex other) {
            if(other == null) {
                throw new ArgumentNullException(nameof(other));
            }
            int result = Title.CompareTo(other.Title);
            return (result == 0) ? Description.CompareTo(other.Description) : result;
        }

        /// <summary>Возвращает результат проверки двух экземпляров <see cref="BasicComplex"/> на равенство по значениям.</summary>
        /// <remarks>Проверяет равенство по значениям членов экземпляра.</remarks>
        /// <param name="left">Левый операнд.</param>
        /// <param name="right">Правый операнд.</param>
        /// <returns>True, если операнды равны.</returns>
        [Display(
            ResourceType = typeof(FndRes),
            Name = "ParityName",
            Description = "ParityDesc",
            GroupName = "DataComparisonGroup")]
        public static bool operator ==(BasicComplex left, BasicComplex right) {
            if(left == null) {
                throw new ArgumentNullException(nameof(left));
            }
            if(right == null) {
                throw new ArgumentNullException(nameof(right));
            }
            return left.Description == right.Description
                && left.Title == right.Title;
        }

        /// <summary>Возвращает результат проверки на неравенство по значениям двух экземпляров <see cref="BasicComplex"/>.</summary>
        /// <remarks>Проверяет неравенство по значениям членов экземпляра.</remarks>
        /// <param name="left">Левый операнд</param>
        /// <param name="right">Правый операнд</param>
        /// <returns>True, если операнды неравны.</returns>
        [Display(
            ResourceType = typeof(FndRes),
            Name = "UnParityName",
            Description = "UnParityDesc",
            GroupName = "DataComparisonGroup")]
        public static bool operator !=(BasicComplex left, BasicComplex right) {
            if(left == null) {
                throw new ArgumentNullException(nameof(left));
            }
            if(right == null) {
                throw new ArgumentNullException(nameof(right));
            }
            return !(left == right);
        }
        #endregion

        /// <summary>Возвращает хэш-код текущего экземпляра <see cref="BasicComplex"/></summary>
        /// <returns>Значение хэш-кода</returns>
        [Display(
            ResourceType = typeof(FndRes),
            Name = "HashCodeCurrent",
            GroupName = "DataComparisonGroup")]
        [DataObjectMethod(DataObjectMethodType.Select)]
        public override int GetHashCode() {
            var hashCode = 221168129;
            hashCode = (hashCode * -1521134295) + EqualityComparer<string>.Default.GetHashCode(Title);
            hashCode = (hashCode * -1521134295) + EqualityComparer<string>.Default.GetHashCode(Description);
            return hashCode;
        }

        /// <summary>Возвращает хэш-код указанного экземпляра <see cref="BasicComplex"/>.</summary>
        /// <remarks>Доступно для переопределения.</remarks>
        /// <param name="obj"> Объект, для которого необходимо вернуть хэш-код</param>
        /// <returns>Хэш-код указанного объекта.</returns>
        /// <exception cref="ArgumentNullException"><paramref name="obj"/> == null</exception>
        [Display(
            ResourceType = typeof(FndRes),
            Name = "HashCodeTarget",
            GroupName = "DataComparisonGroup")]
        [DataObjectMethod(DataObjectMethodType.Select)]
        public virtual int GetHashCode(BasicComplex obj) {
            if(obj == null) {
                throw new ArgumentNullException(nameof(obj));
            }
            return obj.GetHashCode();
        }

    }

}