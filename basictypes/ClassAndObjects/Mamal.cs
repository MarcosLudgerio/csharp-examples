namespace ClassAndObjects
{

    public class Mamal : Animal
    {
        private string region;
        private string country;
        public Mamal(string name, string region, string country) : base(name, "", "", "")
        {
            this.region = region;
            this.country = country;
        }

        public override void toMove()
        {
            Console.WriteLine(this.name + " is moving");
        }

        public override void toEat()
        {
            Console.WriteLine(this.name + " is eating");
        }

        public override void toSleep()
        {
            Console.WriteLine(this.name + " is sleeping");
        }
    }
}