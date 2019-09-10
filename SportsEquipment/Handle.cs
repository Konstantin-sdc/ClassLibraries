namespace SportsEquipments {

    /// <summary>Рукоять (гриф)</summary>
    /// <remarks>Бывает не только у гантелей и гирь, но и к примеру у тренажёров.</remarks>
    public class Handle : SportEquipment {

        /// <summary>Создаёт новый экземпляр класса <see cref="Handle"/></summary>
        /// <param name="name">Имя</param>
        public Handle(string name) : base(name) {
            // масса 
            // единица измерения массы

            // размеры габаритные 
            // размеры на хват
            // одно или двуручный
            // размеры места для груза 
            // единица измерения размеров

            // форма
            // подходяшие фиксаторы 
            // материал основной 
            // материал покрытия 
            // рельеф поверхности 
            // цвет

            Mass = 12;
        }

        /// <summary>Длина части, на которую навешивается груз.</summary>
        /// <remarks>Считается с одной стороны, от рукояти до края.</remarks>
        public int CargoLength { get; set; }

        /// <summary>Диаметр части, на которую навешивается груз.</summary>
        public int CargoDiameter { get; set; }

        /// <summary>Длина рукояти</summary>
        public int HandleLength { get; set; }

        /// <summary>Диаметр рукояти</summary>
        public int HandleDiameter { get; set; }
    }
}