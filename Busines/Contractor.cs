using Foundations;

namespace Busines {

    /// <summary>Контрагент</summary>
    public class Contractor : BasicComplex {

        /// <summary>Создаёт новый экземпляр класса <see cref="Contractor"/></summary>
        /// <param name="title">Имя</param>
        public Contractor(string title) : base(title) { }

        /// <summary>Адрес сайта</summary>
        public string Site { get; set; }

        public override object Clone() {
            throw new System.NotImplementedException();
        }
    }
}