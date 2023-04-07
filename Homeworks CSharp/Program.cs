namespace Calculator
{
    class Program
    {
        static public void Add()
        {
            int num1;
            int num2;
            Console.Write("Enter the first number: ");
            if (!(_ = (int.TryParse(Console.ReadLine(), out num1))))
            {
                Console.WriteLine("Integer cannot contain any symbols except digits");
                Thread.Sleep(2000);
                return;
            }
            Console.Write("Enter the second number: ");
            if (!(_ = (int.TryParse(Console.ReadLine(), out num2))))
            {
                Console.WriteLine("Integer cannot contain any symbols except digits");
                Thread.Sleep(2000);
                return;
            }
            int result = num1 + num2;
            Console.WriteLine($"Result: {result}");
            Console.WriteLine();
            Console.ReadKey(true);
        }
        static public void Subtract()
        {
            int num1;
            int num2;
            Console.Write("Enter the first number: ");
            if (!(_ = (int.TryParse(Console.ReadLine(), out num1))))
            {
                Console.WriteLine("Integer cannot contain any symbols except digits");
                Thread.Sleep(2000);
                return;
            }
            Console.Write("Enter the second number: ");
            if (!(_ = (int.TryParse(Console.ReadLine(), out num2))))
            {
                Console.WriteLine("Integer cannot contain any symbols except digits");
                Thread.Sleep(2000);
                return;
            }
            int result = num1 - num2;
            Console.WriteLine($"Result: {result}");
            Console.WriteLine();
            Console.ReadKey(true);
        }
        static public void Mutiply()
        {
            int num1;
            int num2;
            Console.Write("Enter the first number: ");
            if (!(_ = (int.TryParse(Console.ReadLine(), out num1))))
            {
                Console.WriteLine("Integer cannot contain any symbols except digits");
                Thread.Sleep(2000);
                return;
            }
            Console.Write("Enter the second number: ");
            if (!(_ = (int.TryParse(Console.ReadLine(), out num2))))
            {
                Console.WriteLine("Integer cannot contain any symbols except digits");
                Thread.Sleep(2000);
                return;
            }
            int result = num1 * num2;
            Console.WriteLine($"Result: {result}");
            Console.WriteLine();
            Console.ReadKey(true);
        }
        static public void Divide()
        {
            int num1;
            int num2;
            Console.Write("Enter the first number: ");
            if (!(_ =(int.TryParse(Console.ReadLine(), out num1))))
            {
                Console.WriteLine("Integer cannot contain any symbols except digits");
                Thread.Sleep(2000);
                return;
            }
            Console.Write("Enter the second number: ");    
            if (!(_ =(int.TryParse(Console.ReadLine(), out num2))))
            {
                Console.WriteLine("Integer cannot contain any symbols except digits");
                Thread.Sleep(2000);
                return;
            }
            if(num2 == 0)
            {
                Console.WriteLine("Cannot divide by zero");
                Thread.Sleep(2000);
                return;
            }
            int result = num1 / num2;
            Console.WriteLine($"Result: {result}");
            Console.WriteLine();
            Console.ReadKey(true);
        }
        static void Main()
        {

            string[] menuOptions = { "Addition", "Subtraction", "Multiplication", "Division", "Exit" };

            int selectedIndex = 0; 

            while (true)
            {
                Console.Clear();
                Console.WriteLine(@"
                 ____           
                |        /\     |
                |       /__\    |     
                |____  /    \   |___ 

                 ____          
                |      |    |  |
                |      |    |  |
                |____  |____|  |___
                
                       _____
                   /\    |
                  /__\   |
                 /    \  |    
                 ____     ____
                |    |    |  |
                |    |    |__|
                |____|    |   \
                ");
                for (int i = 0; i < menuOptions.Length; i++)
                {
                    if (i == selectedIndex)
                    {
                        Console.BackgroundColor = ConsoleColor.DarkBlue; 
                        Console.WriteLine("-->" + menuOptions[i]);
                        Console.ResetColor(); 
                    }
                    else
                    {
                        Console.WriteLine("  " + menuOptions[i]);
                    }
                }

                var opKey = Console.ReadKey(true);

                if (opKey.Key == ConsoleKey.UpArrow)
                {                    
                    selectedIndex = Math.Max(selectedIndex - 1, 0);
                }
                else if (opKey.Key == ConsoleKey.DownArrow)
                { 
                    selectedIndex = Math.Min(selectedIndex + 1, menuOptions.Length - 1);
                }
                else if (opKey.Key == ConsoleKey.Enter)
                {
                    switch (selectedIndex)
                    {
                        case 0:
                            Add();
                            break;
                        case 1:
                            Subtract();
                            break;
                        case 2:
                            Mutiply();
                            break;
                        case 3:
                            Divide();
                            break;
                        default:
                            Environment.Exit(0);
                            break;
                    }
                };
            }
        }
    }
}