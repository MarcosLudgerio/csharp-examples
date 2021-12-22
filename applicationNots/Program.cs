namespace ApplicationNots
{
    public class Application
    {
        public static void Main(string[] args)
        {
            string[] options = new string[4] { "1", "2", "3", "X" };
            Student[] students = new Student[5];
            int controll = 0;
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
                        if (decimal.TryParse(Console.ReadLine(), out decimal nota))
                        {
                            student.Note = nota;
                            Console.WriteLine("Aluno cadastrado com sucesso!");
                            if (controll > 4) break;
                            students[controll] = student;
                            controll++;
                        }
                        else
                            Console.WriteLine("Nota inválida, tende novamente!");
                        break;

                    case "2":
                        foreach (var s in students)
                        {
                            if (!string.IsNullOrEmpty(s.Name))
                                Console.WriteLine($"ALUNO: {s.Name} - NOTA: {s.Note}");
                        }
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
                Console.WriteLine();
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