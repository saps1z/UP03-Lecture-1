using System;

namespace OlegApp
{
    // Класс Человек
    class Human
    {
        // Атрибут Имя
        public string name = "";
        // Атрибут Рост
        public double height;
        // Атрибут Рост
        public double weight;
        // Атрибут Речь
        public string speech = "";
        // Метод Говорит
        public void Speak()
        {
            Console.WriteLine("{0} говорит: {1}", name, speech);
        }
    }
    class Program
    {
        static void Main()
        {
            Human human_1 = new Human();
            human_1.name = "Олег";
            human_1.height = 1.70;
            human_1.weight = 70;
            human_1.speech = "Я учиться, так-то, не особо люблю !";
            human_1.Speak();
            Console.ReadKey(true);
        }
    }
}