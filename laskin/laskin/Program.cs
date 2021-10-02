using System;

namespace laskin
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int num1 = 0;
            int num2 = 0;

            Console.WriteLine("Laskin");
            

            
            Console.WriteLine("Anna ensimmäinen luku ja paina Entteriä");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Anna toinen luku ja paina Entteriä");
            num2 = Convert.ToInt32(Console.ReadLine());

            
            Console.WriteLine("Yhteen- vai vähennyslasku (+/-)");
            Console.WriteLine("\t paina + ja Enter jos haluat yhteenlaskun");
            Console.WriteLine("\t paina - ja Enter jos haluat vähennyslaskun");


            // Use a switch statement to do the math.
            switch (Console.ReadLine())
            {
                case "+":
                    Console.WriteLine($"Tuloksesi: {num1} + {num2} = " + (num1 + num2));
                    break;
                case "-":
                    Console.WriteLine($"Tuloksesi: {num1} - {num2} = " + (num1 - num2));
                    break;

            }
        }
    }
}
