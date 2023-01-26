using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod.labrab6
{
    abstract class Beverage
    {
        public void Prepare()
        {
            BoilWater();
            Brew();
            PourInCup();
            AddCondiments();
            CustomerWantsCondiments();
        }
      
      protected void BoilWater() => Console.WriteLine("Вскипятить воду");
         protected virtual void Brew() { }
        private protected void PourInCup() => Console.WriteLine("Налить в чашку");
        protected virtual void AddCondiments() { }
         protected virtual void CustomerWantsCondiments() { }
    //    { return true; }
        
 
        

    }
}
