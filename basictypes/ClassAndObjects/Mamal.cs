namespace ClassAndObjects;
public class Mamal : Animal
{

    private string habbitat;
    private string region;
    private string country;
    public Mamal(string habbitat, string region, string country) : base("", "", "", "")
    {
        this.habbitat = habbitat;
        this.region = region;
        this.country = country;
    }

    public override void toMove()
    {
        Console.WriteLine("The Mammal is moving with your legs");
    }

    public override void toEat()
    {
        Console.WriteLine("The Mamal is eating");
    }

    public override void toSleep()
    {
        Console.WriteLine("The Mamal is sleeping!");
    }
}