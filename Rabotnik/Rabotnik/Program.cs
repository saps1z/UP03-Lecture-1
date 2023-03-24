using System;
using System.Xml.Linq;

namespace TestConsoleApp
{
    // Класс Работник
    class Rabotnik
    {
        // Идентификатор работника ( добавил по своему желанию )
        public int RabotnikID = 0;
        // Атрибут ФИО
        public string FullName = "";
        // Атрибут Стаж работы
        public int WorkAge;
        // Атрибут Должность
        public string Status = "";
        // Атрибут Возраст
        public int Age;
        // Метод Информация о сотруднике
        public void StuffInfo()
        {
            Console.WriteLine("Работник #{0}", RabotnikID);
            Console.WriteLine("ФИО: {0}", FullName);
            Console.WriteLine("Стаж работы: {0}", WorkAge);
            Console.WriteLine("Должность: {0}", Status);
            Console.WriteLine("Возраст: {0}", Age);
        }
    }
    class Program
    {
        static void Main()
        {
            Rabotnik rabotnik_1 = new Rabotnik();
            rabotnik_1.RabotnikID = 1;
            rabotnik_1.FullName = "Валенков Дмитрий Рустамович";
            rabotnik_1.WorkAge = 4;
            rabotnik_1.Status = "Уборщик";
            rabotnik_1.Age = 57;

            rabotnik_1.StuffInfo(); // Информация о сотруднике Дмитрий
            Console.WriteLine();    // Отступ после таблицы ифнормации

            Rabotnik rabotnik_2 = new Rabotnik();
            rabotnik_2.RabotnikID = 2;
            rabotnik_2.FullName = "Романенко Роман Игорьевич";
            rabotnik_2.WorkAge = 7;
            rabotnik_2.Status = "Фасовщик";
            rabotnik_2.Age = 43;

            rabotnik_2.StuffInfo(); // Информация о сотруднике Роман
            Console.WriteLine();    // Ещё один отступ после таблицы ифнормации

            Rabotnik rabotnik_3 = new Rabotnik();
            rabotnik_3.RabotnikID = 3;
            rabotnik_3.FullName = "Политико Артём Иванович";
            rabotnik_3.WorkAge = 13;
            rabotnik_3.Status = "Заместитель";
            rabotnik_3.Age = 31;

            rabotnik_3.StuffInfo(); // Информация о сотруднике Артём
            Console.WriteLine();    // И ещё один отступ после таблицы ифнормации

            Rabotnik rabotnik_4 = new Rabotnik();
            rabotnik_4.RabotnikID = 4;
            rabotnik_4.FullName = "Мамков Юрий Васильевич";
            rabotnik_4.WorkAge = 8;
            rabotnik_4.Status = "Босс";
            rabotnik_4.Age = 44;

            rabotnik_4.StuffInfo(); // Информация о сотруднике Артём
            Console.WriteLine();    // И ещё один отступ после таблицы ифнормации

            Console.ReadKey(true);
        }
    }
}
