namespace ClassAndObjects
{
    class TestingEverything
    {
        static void Main(string[] args)
        {
            Animal komodo = new Animal("Komodo dragon", "Varanidae", "monitor lizard", "Varanus komodoensis"); //string name, string classification, string filo, string cientificName
            Animal owl = new Birds("Tyto alba", "Polar and Desert", "North of the Himalayas");
            Animal dog = new Mamal("Dalmatian", "Everyplace", "Croatia");
            Animal paracanthurus = new Fish("Paracanthurus hepatus", "Atlantic ", "Indo-Pacific");
            owl.toEat();
            owl.toMove();
            owl.toSleep();
            Console.WriteLine("");
            dog.toEat();
            dog.toMove();
            dog.toSleep();
            Console.WriteLine("");
            paracanthurus.toEat();
            paracanthurus.toMove();
            paracanthurus.toSleep();
            Console.WriteLine("");
            komodo.toEat();
            komodo.toMove();
            komodo.toSleep();
        }
    }
}
