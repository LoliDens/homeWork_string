using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWork_string
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            int age;
            string bloodType ;

            Console.Write("Введите свое имя: ");
            name = Console.ReadLine();
            Console.Write("Введите свой возраст: ");
            age = int.Parse(Console.ReadLine());
            Console.Write("Введите стою группу крови: ");
            bloodType = Console.ReadLine();

            Console.Write($"Вас завут {name} ,вам {age} лет и у вас {bloodType} группа крови");
            Console.ReadKey();
            

        }
    }
}
