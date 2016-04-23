using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralDecorator {
    /// <summary>
    /// MainApp startup class.
    /// </summary>
    class MainApp {
        static void Main() {
            //Create ConcreteComponent and two Decorators.
            ConcreteComponent c = new ConcreteComponent();
            ConcreteDecoratorA d1 = new ConcreteDecoratorA();
            ConcreteDecoratorB d2 = new ConcreteDecoratorB();

            //Link the decorators.
            d1.SetComponent(c);
            d2.SetComponent(d1);
            d2.Operation();
            Console.ReadKey();
        }
    }
}
