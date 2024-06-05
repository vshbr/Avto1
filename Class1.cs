using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Avto
{
    private string nomAvto;
    private int benzBak;
    private float rashod;

    public Avto()
    {
        nomAvto = " ";
        benzBak = 0;
        rashod = 0.0f;
    }

    public Avto(string nom, int bak, float ras)
    {
        nomAvto = nom;
        benzBak = bak;
        rashod = ras;
    }

    public void info(string nom, float bak, float ras)
    {
        nomAvto = nom;
        benzBak = (int)bak;
        rashod = ras;
    }

    public void outInfo()
    {
        Console.WriteLine($"Номер авто: {nomAvto}, Количество бензина в баке: {benzBak}, Расход топлива на 100 км: {rashod}");
    }

    public void zapravka(float top)
    {
        benzBak += (int)top;
    }

    public void move(int km)
    {
        int fuelNeeded = (int)(km * rashod / 100);
        if (fuelNeeded <= benzBak)
        {
            benzBak -= fuelNeeded;
            Console.WriteLine($"Проехали {km} км.");
        }
        else
        {
            Console.WriteLine("Недостаточно топлива для поездки.");
        }
    }

    public int ostatok()
    {
        return benzBak;
    }

    public void tormozhenie()
    {
        Console.WriteLine("Выполнено торможение.");
    }

    public void razgon()
    {
        Console.WriteLine("Машина разогнана.");
    }
}