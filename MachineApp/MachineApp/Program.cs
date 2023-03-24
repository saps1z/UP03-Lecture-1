using System;
namespace MachineCarConsoleApp
{
    // Класс Машина
    class Car
    {
        // Атрибут Название машины
        public string BrandModel = "";
        // Атрибут Кол-во топлива в баке
        public double Fuel;
        // Атрибут Потребление топлива на километр
        public double FPKM;
        // Метод Ехать
        public double Drive(double Distance, double Speed)
        {
            double fuelNeeded = Distance * FPKM;       // Узнаём, сколько топлива потребуется

            // Если требуемое топливо превышает запас, тогда выдаём ошибку
            if (fuelNeeded > Fuel)
            {
                Console.WriteLine("У " + BrandModel + " не получилось преодолеть расстояние");
                return 0;
            }
            else  // Иначе возращаем время, которое потребуется для преодоления расстояния
            {
                return Distance / Speed;
            }
        }
    }
    class Program
    {
        static void Main()
        {
            // Создаём первую машину как объект
            Car car_1 = new Car();
            car_1.BrandModel = "БМВ М3";
            car_1.Fuel = 70;
            car_1.FPKM = 0.2;

            // Создаём вторую машину
            Car car_2 = new Car();
            car_2.BrandModel = "Мерседес СЛК";
            car_2.Fuel = 50;
            car_2.FPKM = 0.1;

            // Выводим данные о машинах
            Console.WriteLine("Первая машина: " + car_1.BrandModel + "; остаток топлива: " + car_1.Fuel + "; Затрата на 1км: " + car_1.FPKM);
            Console.WriteLine("Вторая машина: " + car_2.BrandModel + "; остаток топлива: " + car_2.Fuel + "; Затрата на 1км: " + car_2.FPKM);
            Console.WriteLine();  // Отступаем строчку для удобства чтения

            // Просим Пользователя указать дистанцию, которую необходимо проехать
            Console.Write("Введите расстояние, которое нужно проехать: ");
            double Distance = double.Parse(Console.ReadLine());

            // Просим так же указать и скорость, с которой двигались автомобили
            Console.Write("Введите скорость движения обоих автомобилей: ");
            double Speed = double.Parse(Console.ReadLine());

            // Отступаем строчку для удобства чтения
            Console.WriteLine();

            // Если исходя из функции Ехать мы не получили на выходе ошибку, тогда выводим кол-во затраченного времени на путь первой машины
            if (car_1.Drive(Distance, Speed) != 0)
            {
                Console.WriteLine(car_1.BrandModel + " проедет " + Distance + " км за " + car_1.Drive(Distance, Speed) + " часов");
            }

            // Если исходя из функции Ехать мы не получили на выходе ошибку, тогда выводим кол-во затраченного времени на путь второй машины
            if (car_2.Drive(Distance, Speed) != 0)
            {
                Console.WriteLine(car_2.BrandModel + " проедет " + Distance + " км за " + car_2.Drive(Distance, Speed) + " часов");
            }

            // Просим Пользователя нажать любую клавишу для закрытия консоли ( Для старых версий VS )
            Console.ReadKey(true);
        }
    }
}
