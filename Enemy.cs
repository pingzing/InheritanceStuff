namespace InheritanceStuff
{
    public class Enemy : Mob
    {
        public int Attack { get; set; }
        public int Defense { get; set; }

        public Enemy()
        {
            Id = 5;// some random ID
        }

        public override void Interact()
        {
            throw new System.NotImplementedException();
        }
    }
}
