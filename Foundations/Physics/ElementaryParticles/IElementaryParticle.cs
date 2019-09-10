namespace Foundations.Physics.ElementaryParticles {

    /// <summary>Элементарная частица.</summary>
    public interface IElementaryParticle : IBasicComplex {

        // NOTE: Все ЭЧ  одного вида во Вселенной полностью одинаковы по всем своим свойствам, 
        // NOTE: и принципу корпускулярно-волнового дуализма (каждой элементарной частице соответствует волна де-Бройля).
        // NOTE: Все ЭЧ обладают свойством взаимопревращаемости, являющегося следствием их взаимодействий: сильного, электромагнитного, слабого, гравитационного. Взаимодействия частиц вызывают превращения частиц и их совокупностей в другие частицы и их совокупности, если такие превращения не запрещены законами сохранения энергии, импульса, момента количества движения, электрического заряда, барионного заряда и др.

        /// <summary>
        /// Время жизни, секунд.
        /// </summary>
        float LiveTime { get; set; }

        /// <summary>Масса покоя.</summary>
        float RestMass { get; set; }

        /// <summary>Спин.</summary>
        /// <remarks>Положительное целое или получелое число.</remarks>
        float Spin { get; set; }

        /// <summary>Электрический заряд, кулон (Кл).</summary>
        float ElectricCharge { get; set; }

        /// <summary>Магнитный момент.</summary>
        float MagneticMoment { get; set; }

        /// <summary>Барионный заряд.</summary>
        /// <remarks>Вычисляеемое квантовое число.</remarks>
        // https://ru.wikipedia.org/wiki/Барионное_число
        byte BaryonCharge { get; set; }

        /// <summary>Лептонное число.</summary>
        // https://ru.wikipedia.org/wiki/Лептонное_число
        sbyte LeptonNumeric { get; set; }

        /// <summary>Странность.</summary>
        // https://ru.wikipedia.org/wiki/Странность
        sbyte Oddity { get; set; }

        // изотопический спин, 
        // чётность, 
        // зарядовая чётность, 
        // G-чётность, 
        // CP-чётность.

    }
}
