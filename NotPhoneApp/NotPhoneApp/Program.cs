using System;
namespace NotPhoneConsoleApp
{
    // Класс Телефон
    class NotPhone
    {
        // Атрибут Фирма
        public string Company = "";
        // Атрибут Модель
        public string Model = "";
        // Атрибут Активность сим-карты
        public bool Activated;
        // Метод Позвонить
        public void Call()
        {
            if (Activated)
            {
                Console.WriteLine("Звонок совершён");
            }
            else
            {
                Console.WriteLine("Ваша сим-карта не активирована!");
                Console.WriteLine("Пожалуйта, обратитесь к вашему оператору");
            }
        }
    }
    class Program
    {
        static void Main()
        {
            NotPhone phone_1 = new NotPhone();
            phone_1.Company = "NotPhone";
            phone_1.Model = "TerriblePicture";
            phone_1.Activated = true;
            Console.WriteLine(phone_1.Company + " " + phone_1.Model + " звонит...");
            phone_1.Call();
            Console.WriteLine();

            NotPhone phone_2 = new NotPhone();
            phone_2.Company = "Oleg";
            phone_2.Model = "4S";
            phone_2.Activated = false;
            Console.WriteLine(phone_2.Company + " " + phone_2.Model + " звонит...");
            phone_2.Call();
            Console.WriteLine();

            Console.ReadKey(true);
        }
    }
}
