namespace ApplicationNots
{
    public class Application
    {
        public static void Main(string[] args)
        {
            string[] options = new string[4] { "1", "2", "3", "X" };
            Student[] students = new Student[5];
            string option = ShowOptions();
            while (option.ToUpper() != "X")
            {
                switch (option)
                {
                    case "1":
                        Student student = new Student();
                        Console.WriteLine("Adicionar novo aluno");
                        Console.Write("Informe o nome do aluno: ");
                        student.Name = Console.ReadLine();
                        Console.Write("Informe a note do aluno: ");
                        student.Note = Decimal.Parse(Console.ReadLine());
                        Console.WriteLine();
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
                option = ShowOptions();
            }
            string ShowOptions()
            {
                Console.WriteLine("Informe a opção desejada:");
                Console.WriteLine("1 - Cadastrar novo aluno");
                Console.WriteLine("2 - Listar alunos");
                Console.WriteLine("3 - Calcular média geral");
                Console.WriteLine("X - Parar a aplicação");
                string option = Console.ReadLine();
                Console.WriteLine();
                return option;
            }
        }
    }
}