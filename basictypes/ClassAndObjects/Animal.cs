// ClasseA : ClasseB == ClasseA extends ClasseB
namespace ClassAndObjects
{
    public class Animal
    {
        public string name;
        protected string classification;
        protected string filo;
        protected string cientificName;

        public Animal(string name, string classification, string filo, string cientificName)
        {
            this.name = name;
            this.classification = classification;
            this.filo = filo;
            this.cientificName = cientificName;
        }

        public virtual void toMove()
        {
            Console.WriteLine(this.name + " is moving");
        }

        public virtual void toEat()
        {
            Console.WriteLine(this.name + " is eating");
        }

        public virtual void toSleep()
        {
            Console.WriteLine(this.name + " is sleeping");
        }

    }
}

