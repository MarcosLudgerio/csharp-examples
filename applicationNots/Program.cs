namespace ApplicationNots
{
    public class Application
    {
        static Student[] students = new Student[5];
        public static void Main(string[] args)
        {
            string[] options = new string[4] { "1", "2", "3", "X" };
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
                        Console.Write("Informe a nota do aluno: ");
                        if (decimal.TryParse(Console.ReadLine(), out decimal noteInput))
                        {
                            if (!(noteInput >= 0 && noteInput <= 10)) break;
                            student.Note = noteInput;
                            Console.WriteLine("Aluno cadastrado com sucesso!");
                            if (controll >= 4) break;
                            students[controll] = student;
                            controll++;
                        }
                        else
                            Console.WriteLine("Nota inválida, tente novamente!");
                        break;

                    case "2":
                        foreach (var s in students)
                        {
                            if (!string.IsNullOrEmpty(s.Name))
                                Console.WriteLine($"ALUNO: {s.Name} - NOTA: {s.Note}");
                        }
                        break;

                    case "3":
                        Console.WriteLine("Apagar Aluno");
                        if (controll == 0) break;
                        Console.Write("Informe o nome do aluno: ");
                        String name = Console.ReadLine();
                        int studentFinded = getIndexStudentByName(name);
                        students[studentFinded] = new Student();
                        controll--;
                        break;

                    case "4":
                        if (controll == 0) break;
                        Console.WriteLine($"MÉDIA GERAL: {CalcAvg()} a turma está classificada como CLASSE {GetClassification(CalcAvg())}");
                        break;

                    default:
                        Console.WriteLine($"Opcão {option} é inválida, tente novamente!");
                        break;
                }
                option = ShowOptions();
            }

        }
        static string ShowOptions()
        {
            Console.WriteLine();
            Console.WriteLine("Informe a opção desejada:");
            Console.WriteLine("1 - Cadastrar novo aluno");
            Console.WriteLine("2 - Listar alunos");
            Console.WriteLine("3 - Excluir aluno");
            Console.WriteLine("4 - Calcular média geral");
            Console.WriteLine("X - Parar a aplicação");
            string option = Console.ReadLine();
            Console.WriteLine();
            return option;
        }
        static int getIndexStudentByName(String name)
        {
            int studentIndex = -1;
            foreach (var s in students)
                if (!string.IsNullOrEmpty(s.Name))
                    if (s.Name.ToLower().Equals(name.ToLower()))
                        studentIndex = Array.IndexOf(students, s);
            return studentIndex;
        }

        static Classification GetClassification(decimal avgStudents)
        {
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
            return classGeneral;
        }

        static decimal CalcAvg()
        {
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
            return sumNotes / contStudents;
        }


    }
}