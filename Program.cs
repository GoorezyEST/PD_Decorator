namespace Decorator_PD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create ConcreteComponent object
            Component component = new ConcreteComponent();

            // Create ConcreteDecoratorA object
            Decorator decoratorA = new ConcreteDecoratorA();

            // Set the ConcreteComponent object to be decorated by ConcreteDecoratorA
            decoratorA.SetComponent(component);

            // Create ConcreteDecoratorB object
            Decorator decoratorB = new ConcreteDecoratorB();

            // Set the ConcreteDecoratorA object to be decorated by ConcreteDecoratorB
            decoratorB.SetComponent(decoratorA);

            // Call the Operation method on the ConcreteDecoratorB object
            string result = decoratorB.Operation();
            Console.WriteLine(result);
        }
    }
}