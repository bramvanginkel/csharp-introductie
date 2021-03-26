using System;

namespace opdracht_2
{
    using System.Collections.Generic;
    using System;


    class StackOpdracht
    {
        Stack<string> stack = new Stack<string>();

        public void VulStack()
        {
            Console.Write("Voer iets in: ");
            stack.Push(Console.ReadLine());
        }

        public void PrintStack()
        {
            foreach (string line in stack)
            {
                Console.WriteLine(line);
            }
        }

        public void TestStack()
        {
            Console.Write("Voer te testen string in: ");
            if (stack.Peek() == Console.ReadLine())
            {
                Console.WriteLine($"Verwijderen: '{stack.Pop()}'");
            }
            else
            {
                Console.WriteLine("Niks verwijderen.");
            }
        }
    }

    class Program
    {
        public static void Main()
        {
            StackOpdracht stack = new StackOpdracht();

            for (int i = 0; i < 5; i++)
            {
                stack.VulStack();
                stack.PrintStack();
                stack.TestStack();
                Console.WriteLine("\r\n");
            }
        }
    }

}
