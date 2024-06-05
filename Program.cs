using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите номер авто:");
        string nom = Console.ReadLine();

        Console.WriteLine("Введите объем бензина в баке:");
        float bak = float.Parse(Console.ReadLine());

        Console.WriteLine("Введите расход топлива на 100 км:");
        float ras = float.Parse(Console.ReadLine());

        Avto myCar = new Avto(nom, (int)bak, ras);

        while (true)
        {
            Console.WriteLine("Выберите действие:\n1 - Езда\n2 - Заправка\n3 - Торможение\n4 - Разгон\n5 - Выйти");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Введите расстояние:");
                    int distance = int.Parse(Console.ReadLine());
                    myCar.move(distance);
                    break;
                case 2:
                    Console.WriteLine("Введите количество залитого бензина:");
                    float topUp = float.Parse(Console.ReadLine());
                    myCar.zapravka(topUp);
                    break;
                case 3:
                    myCar.tormozhenie();
                    break;
                case 4:
                    myCar.razgon();
                    break;
                case 5:
                    return;
                default:
                    Console.WriteLine("Некорректный выбор. Попробуйте еще раз.");
                    break;
            }
            Console.WriteLine($"Остаток топлива в баке: {myCar.ostatok()} л.");
        }
    }
}