using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miniminimini_men
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] isimler = { "Ali", "Veli", "Ali", "Ahmet", "Mehmet", "Ali", "Zehra", "Fatma", "Ayşe", "Ali" };

            Console.WriteLine(Array.IndexOf(args, isimler));

            Console.WriteLine(isimler.Length);
            Array.IndexOf(args, isimler);

            int İndex = Convert.ToInt32(Console.ReadLine());

            foreach (var item in isimler)
            {
                Console.WriteLine(item);
            }
















            Console.ReadLine();






















        }
    }
}
