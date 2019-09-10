using Foundations;
using Foundations.Metrology;

namespace Busines {

    /// <summary>Продукт.</summary>
    public interface IProduct<T> : IBasicComplex where T : IBasicComplex {

        /// <summary>Сущность (материальная или нематериальгая) продукта.</summary>
        T Entity { get; }

        // TODO: Возможно, нужно различать изготовителя, производителя, создателя и пр.
        /// <summary>Изготовитель</summary>
        Contractor Manufacturer { get; set; }

        // Кто-то придумал. Кто-то имеет авторские права. Всё это — пока в продукте не рассматривается.
        // Кто-то зарегистрировал изделие, кто-то производит по лицензии.
        // Нужно: фирма-производитель.
        // Страна, где произведено, ибо м.б. не в той стране, где зарегистрирован прооизводитель.
        // Бренд для страны производства или страны поставки.

        /// <summary>Модель</summary>
        // Возможно не у всякого есть модель, например, у кустарных в одном экземляре.
        string Model { get; set; }

        /// <summary>Единица измерения количества продукта, — в штуках он меряется, в килограммах или ещё как-то.</summary>
        MetricUnit Unit { get; set; }

        /// <summary>Линейка продуктов.</summary>
        string Line { get; set; }

        /// <summary>Серийный номер производителя.</summary>
        string SerialNumber { get; set; }

        IBrand<T> Brand { get; set; }

        /// <summary>Страна производства данного продукта</summary>
        // TODO: Вынести страну в отдельный класс.
        string ManufactureCountry { get; set; }
    }
}