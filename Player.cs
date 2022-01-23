using System;

namespace InheritanceStuff
{
    public class Player : Mob, ICoordinatable, ITakeDamage
    {
        public int Strength { get; set; }
        public int Wisdom { get; set; }
        public int Intellect { get; set; }
        public int Charisma { get; set; }
        public int Dexterity { get; set; }
        public int Armor { get; set; }

        // Part of ICoordinatable
        public float XCoord { get; set; }
        public float YCoord { get; set; }

        public Player()
        {
            Id = 0;
        }

        public virtual int TakeDamage(int damage)
        {
            int? reducedDamage = ApplyDamageReduction(damage);
            int finalDamage = reducedDamage ?? damage;
            Health = Health - finalDamage;
            return damage;
        }

        public int? ApplyDamageReduction(int initialDamage)
        {
            return Math.Max(0, initialDamage - Armor);
        }

        public override void Interact()
        {
            throw new NotImplementedException();
        }
    }
}
