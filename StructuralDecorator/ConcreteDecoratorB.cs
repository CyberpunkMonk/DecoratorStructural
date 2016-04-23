using System;

namespace StructuralDecorator {
    /// <summary>
    /// The 'ConcreteDecoratorB' class
    /// </summary>
    class ConcreteDecoratorB:Decorator {
        public override void Operation() {
            base.Operation();
            Console.WriteLine("ConcreteDecoratorB.Operation()");
        }
    }
}