using Foundations.Physics;

namespace SportsEquipments {

    /// <summary>Спортивный инвентарь или снаряд.</summary>
    public abstract class SportEquipment : SolidBody {
        protected SportEquipment(string title) : base(title) { }

        protected SportEquipment(string title, int weight) : base(title, weight) { }

    }
}
