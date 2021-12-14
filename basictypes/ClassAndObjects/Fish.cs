namespace ClassAndObjects;
public class Fish : Animal
{

    private string habbitat;
    private string region;
    private string country;
    public Fish(string habbitat, string region, string country) : base("", "", "", "")
    {
        this.habbitat = habbitat;
        this.region = region;
        this.country = country;
    }
    public override void toMove()
    {
        Console.WriteLine("The fish is moving in the ocean with its fins.");
    }

    public override void toEat()
    {
        Console.WriteLine("the fish is eating seaweed in the sea ");
    }

    public override void toSleep()
    {
        Console.WriteLine("Fish never sleep!");
    }

}