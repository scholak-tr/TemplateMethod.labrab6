using System;

namespace TemplateMethod.labrab6
{
    class Program
    {
        static void Main(string[] args)
        {
          
            Beverage coffee = new Coffee();
            coffee.Prepare();
            Beverage tea = new Tea();
            tea.Prepare();
            Console.ReadKey();
        }
    }
}
