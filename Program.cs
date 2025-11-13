namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float result = 0;

            Console.WriteLine("Sisesta esimene number");
           float firstNumber = float.Parse(Console.ReadLine());
            Console.WriteLine("Sisesta teine number");
            float secondnumber = float.Parse(Console.ReadLine());
            Console.WriteLine("Vali tehe +,-,*,/");
            string input = Console.ReadLine();
            switch (input)
            {
                case "+":
                    Console.WriteLine($"tulemus: {firstNumber + secondnumber}");
                    break;
                case "-":
                    Console.WriteLine($"tulemus: {firstNumber - secondnumber}");
                    break;
                case "*":
                    Console.WriteLine($"tulemus: {firstNumber * secondnumber}");
                    break;
                case "/":
                    Console.WriteLine($"tulemus: {firstNumber / secondnumber}");
                    break;
                    if (secondnumber == 0)
                    {
                        Console.WriteLine("ne");
                    }
                    else
                    {
                        Console.WriteLine($"Tulemus: {firstNumber / secondnumber}");
                    }
                    break;
                    default:
                    break;

                        
                    
            }



        }
    }
}
