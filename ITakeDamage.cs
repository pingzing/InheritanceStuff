namespace InheritanceStuff
{
    public interface ITakeDamage
    {
        int TakeDamage(int damage);
        int? ApplyDamageReduction(int initialDamage);
    }
}
