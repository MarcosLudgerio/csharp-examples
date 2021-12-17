using System;
namespace BasicTypes
{
    class ConditionalInstrutions
    {
        void Assignments()
        {
            // Variables
            int aNumber = 1;
            int numberA = 2, numberB = 3;
            const int numberConst = 2;

            Console.WriteLine(aNumber + numberA + numberB + numberConst); // output: 8 
        }

        static void ConditionalIfElse(string[] args)
        {
            if (args.Length == 0)
                Console.WriteLine("this array is empty");
            else if (args.Length == 1)
                Console.WriteLine("this array has one element");
            else
                Console.WriteLine("this array has many elements");
        }

        static void ConditionalSwitchCase(string[] args)
        {
            int countElements = args.Length;
            switch (countElements)
            {
                case 0:
                    Console.WriteLine("this array is empty");
                    break;
                case 1:
                    Console.WriteLine("this array has one element");
                    break;
                default:
                    Console.WriteLine("this array has many elements");
                    break;
            }
        }
    }
    class RepeatitonsInstructinos
    {
        void LoopWilhe()
        {
            int i = 0;
            while (i < 10) // Repeat 10
            {
                Console.WriteLine($"position {i}");
            }
        }

        static void LoopDoWhile()
        {
            string? input;
            do
            {
                input = Console.ReadLine();
                Console.WriteLine(input);
            } while (!(input != null || input == ""));
        }

        void LoopFor(string[] args)
        {
            for (int i = 0; i < args.Length; i++)
            {
                Console.WriteLine(args[i]);
            }
        }

        void LoopForEach(string[] args)
        {
            foreach (var s in args)
            {
                Console.WriteLine(s);
            }
        }

        void UsingBreak(string[] args)
        {
            int i = 0;
            while (i < args.Length)
            {
                if (args[i] == "a")
                    break; // Stop the loop
                Console.WriteLine(i);
            }
        }

        void UsingContinue(string[] args)
        {
            for (int i = 0; i < args.Length; i++)
            {
                if (args[i] == "a") continue;
                Console.WriteLine(i);
            }
        }

        void UsingReturn(string[] args)
        {
            int SumTwoNumber(int a, int b)
            {
                return a + b;
            }

            Console.WriteLine(SumTwoNumber(1, 2));
            return;
        }
    }

    class ThrowTryCatchFinally
    {
        void tryCatch(string[] args)
        {
            double divideTwoNumber(double a, double b)
            {
                if (b == 0) throw new DivideByZeroException("Not is possible divide by zero");
                return a / b;
            }
            try
            {
                if (args.Length != 2)
                {
                    throw new InvalidOperationException("Enter two numbers");
                }
                double firstNumber = Double.Parse(args[0]);
                double secondNumber = Double.Parse(args[1]);

                Console.WriteLine(divideTwoNumber(firstNumber, secondNumber));
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e.Message}");
            }
            finally
            {
                Console.WriteLine("Output");
            }
        }
    }
}