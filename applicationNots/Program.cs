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
                        decimal sumNotes = 0;
                        int contStudents = 0;
                        for (int i = 0; i < students.Length; i++)
                        {
                            if (!string.IsNullOrEmpty(students[i].Name))
                            {
                                sumNotes = sumNotes + students[i].Note;
                                contStudents++;
                            }
                        }
                        var avgStudents = sumNotes / contStudents;

                        Classification classGeneral;

                        if (avgStudents < 3)
                            classGeneral = Classification.E;
                        else if (avgStudents <= 5)
                            classGeneral = Classification.D;
                        else if (avgStudents <= 7)
                            classGeneral = Classification.C;
                        else if (avgStudents <= 9)
                            classGeneral = Classification.B;
                        else
                            classGeneral = Classification.A;

                        Console.WriteLine($"MÉDIA GERAL: {avgStudents} a turma está classificada como CLASSE {classGeneral}");
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