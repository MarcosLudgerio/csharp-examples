namespace ClassAndObjects;

public class Birds : Animal
{
    private string habbitat;
    private string region;
    private string country;
    public Birds(string habbitat, string region, string country) : base("", "", "", "")
    {
        this.habbitat = habbitat;
        this.region = region;
        this.country = country;
    }

    public override void toMove()
    {
        Console.WriteLine("The Bird is moving with your wings");
    }

    public override void toEat()
    {
        Console.WriteLine("The Bird is eating with your beak");
    }

    public override void toSleep()
    {
        Console.WriteLine("The Bird is sleeping at the tree.");
    }
}