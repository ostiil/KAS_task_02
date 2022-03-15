using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KAS_Task_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Программа будет выполняться, пока вы не введете exit");
            string word = "";
            while(word != "exit")
            {
                Console.WriteLine("Программа выполняется. введите любое значение для продолжения");
                word = Console.ReadLine();
            }
        }
    }
}
