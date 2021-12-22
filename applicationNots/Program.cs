// See https://aka.ms/new-console-template for more information
Console.WriteLine("Informe a opção desejada:");
Console.WriteLine("1 - Cadastrar novo aluno");
Console.WriteLine("2 - Listar alunos");
Console.WriteLine("3 - Calcular média geral");
Console.WriteLine("X - Parar a aplicação");
Console.WriteLine("");

string option = Console.ReadLine();
string[] options = new string[4] { "1", "2", "3", "X" };

while (option.ToUpper() != "X")
{
    switch (option)
    {
        case "1":
            //TODO: Add student
            Console.WriteLine("Esclheu a primeira opção");
            break;

        case "2":
            //TODO: list student
            Console.WriteLine("Esclheu a primeira opção");
            break;

        case "3":
            //TODO: avg
            Console.WriteLine("Esclheu a primeira opção");
            break;

        default:
            Console.WriteLine($"Opcão {option} é inválida, tente novamente");
            break;
    }
    option = Console.ReadLine();
}

