namespace InheritanceStuff
{
    public abstract class Mob
    {
        protected uint Id { get; set; }

        public string Name { get; set; }
        public int Health { get; set; }

        public abstract void Interact();
    }
}
