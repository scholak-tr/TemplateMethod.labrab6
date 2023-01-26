using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod.labrab6
{
   class Tea:Beverage
    {
      protected override void Brew() => Console.WriteLine("Сделать чай");

      protected override void CustomerWantsCondiments()
        {
            Console.WriteLine("Добавить что-то в чай?- да/нет");
            string s = Console.ReadLine();
            if (s == "да")
                Console.WriteLine("Лимон добавлен");
        }
    }
}
