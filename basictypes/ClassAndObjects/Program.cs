namespace ClassAndObjects;

class Program
{
    static void Main(string[] args)
    {
        // , "Indonesia"
        Animal owl = new Birds("Tyto alba", "Polar and Desert", "North of the Himalayas");
        Animal dog = new Mamal("Dalmatian", "World", "Croatia");
        Animal paracanthurus = new Fish("Paracanthurus hepatus", "Atlantic ", "Indo-Pacific");

        owl.toEat();
        dog.toEat();
        paracanthurus.toEat();


    }
}