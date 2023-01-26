using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod.labrab6
{
     class Coffee:Beverage
    {
     protected override void Brew() => Console.WriteLine("Варить кофе");
     protected override void AddCondiments() => Console.WriteLine("Добавить в кофе сироп");
    }
    
}
