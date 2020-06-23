using creational_patterns;
using System;

namespace design_patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            TestSingleton();
            TestFactory();
        }

        static void TestSingleton()
        {
            Console.WriteLine("Singleton Test.......");
            Singleton singleton = Singleton.GetInstance();
            singleton.LogMessage("Hello");
        }

        static void TestFactory()
        {
            Console.WriteLine("Factory Test.......");
            ToolFactory toolFactory = new BrushFactory();

            Tool tool = toolFactory.GetTool();
            tool.Draw();

            toolFactory = new PencilFactory();

            tool = toolFactory.GetTool();
            tool.Draw();
        }
    }
}
