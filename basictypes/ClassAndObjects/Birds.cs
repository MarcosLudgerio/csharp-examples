namespace ClassAndObjects
{
    public class Birds : Animal
    {
        private string region;
        private string country;
        public Birds(string name, string region, string country) : base(name, "", "", "")
        {
            this.region = region;
            this.country = country;
        }

        public override void toMove()
        {
            Console.WriteLine(base.name + " is moving");
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

