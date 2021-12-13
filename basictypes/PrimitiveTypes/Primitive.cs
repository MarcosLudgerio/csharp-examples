namespace BasicTypes;
class PrimitiveTypes
{
    // Variables primitive types 
    int integerNumber = 0; // Ex: 1, 2, 3...
    double fractionalNumber = 0.0; // Ex: 1.1, 1.2, -2.1...

    string characters = ""; // Ex: "hello", "name", "address"...

    char uniqueCharacter = 'a'; // Ex: 'a', 'b', 'c'...

    // Arrays
    int[] listFiveNumbers = new int[5]; // List of 5 numbers
    int[,] twoDimensionalMatrix = new int[4, 3]; // Matrix 4 rows and 3 columns
    int[] listCompleted = new int[4] { 1, 2, 3, 4 }; // List completed

    int[] listCompleted2 = { 1, 2, 3, 4 };

    // Examples
    void examples()
    {
        string[] arrayNumberPhones = new string[3];
        arrayNumberPhones[0] = "555-0123";
        arrayNumberPhones[1] = "555-3135";
        arrayNumberPhones[2] = "+88 552237998";
        return;
    }

    void usingVariables()
    {
        Console.WriteLine(integerNumber);
        Console.WriteLine(fractionalNumber);
        Console.WriteLine(listFiveNumbers);
        Console.WriteLine(listCompleted2);
        Console.WriteLine(twoDimensionalMatrix);
        Console.WriteLine(uniqueCharacter);
        Console.WriteLine(listCompleted);
        Console.WriteLine(characters);
    }
}
