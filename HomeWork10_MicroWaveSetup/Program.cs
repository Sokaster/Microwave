using System;

namespace HomeWork10_MicroWaveSetup
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Microwave microwave = new Microwave();
            microwave.WarmUp("Burger");
            microwave.WarmUpCompleted += WarmUpCompletedHandler1;
            microwave.WarmUp("Burger");
            microwave.WarmUpCompleted += WarmUpCompletedHandler2;
            microwave.WarmUp("Sandwich");
            microwave.WarmUpCompleted += WarmUpCompletedHandler3;
            microwave.WarmUp("Brokkoli");
            microwave.WarmUpCompleted -= WarmUpCompletedHandler3;
            microwave.WarmUp("potato");


        }
        private static void WarmUpCompletedHandler1(string nameOfFood)
        {
            Console.WriteLine($"Guest 1 Ваша еда готова: {nameOfFood}");
        }

        private static void WarmUpCompletedHandler2(string nameOfFood)
        {
            Console.WriteLine($"Guest 2 Ваша еда готова: {nameOfFood}");
        }

        private static void WarmUpCompletedHandler3(string nameOfFood)
        {
            Console.WriteLine($"Guest 3 Ваша еда готова: {nameOfFood}");
        }
    }
}
