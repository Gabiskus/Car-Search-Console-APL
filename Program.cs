using System;
using System.Collections.Generic;
using System.Linq;

public class Automobil
{
    public string brend;
    public string model;
    public int godiste;
    public double predjenakm;
    public double cena;

    public Automobil(string brend1, string model1, int godiste1, double predjenakm1, double cena1)
    {
        brend = brend1;
        model = model1;
        godiste = godiste1;
        predjenakm = predjenakm1;
        cena = cena1;
    }
}

namespace Automobili
{
    class Program
    {
        static void Main(string[] args)
        {
            Automobil auto1 = new Automobil("Audi", "A6", 2005, 246749.5, 5200);
            Automobil auto2 = new Automobil("Dacia", "Sandero", 2013, 109505.3, 3990);
            Automobil auto3 = new Automobil("Audi", "A4", 2005, 304000.2, 4190);
            Automobil auto4 = new Automobil("Audi", "A7", 2014, 186000.6, 28900);
            Automobil auto5 = new Automobil("Skoda", "Yeti", 2010, 251000.2, 6690);
            Automobil auto6 = new Automobil("Skoda", "Octavia", 2006, 186000.6, 3995);
            Automobil auto7 = new Automobil("Volkswagen", "Golf 4", 2001, 220000.6, 1000);
            Automobil auto8 = new Automobil("Volkswagen", "Golf 4", 2001, 264615.4, 1800);
            Automobil auto9 = new Automobil("Skoda", "Fabia", 2004, 260000.6, 2150);
            Automobil auto10 = new Automobil("Skoda", "Fabia", 2014, 177735.4, 9699);
            Automobil auto11 = new Automobil("Volkswagen", "Golf 7", 2015, 192753.4, 11290);
            Automobil auto12 = new Automobil("Volkswagen", "Touran", 2005, 197000, 3750);
            Automobil auto13 = new Automobil("BMW", "M5", 2006, 255500.7, 15000);
            Automobil auto14 = new Automobil("BMW", "X3", 2020, 19600.6, 55000);
            Automobil auto15 = new Automobil("BMW", "X6", 2014, 241326.7, 24999);
            Automobil auto16 = new Automobil("Dacia", "Duster", 2012, 185354.8, 6950);
            Automobil auto17 = new Automobil("Dacia", "Pickup", 1998, 123628.7, 300);
            Automobil auto18 = new Automobil("Toyota", "Supra", 1992, 56500.9, 14000);
            Automobil auto19 = new Automobil("Toyota", "Carina", 1997, 250000.8, 400);
            Automobil auto20 = new Automobil("Toyota", "Corona", 1968, 168000.6, 1500);
            Automobil auto21 = new Automobil("Tesla", "Model S", 2017, 121000.6, 25000);
            Automobil auto22 = new Automobil("Tesla", "Model 3", 2021, 9800.8, 56000);
            Automobil auto23 = new Automobil("Opel", "Astra", 2008, 177600.6, 3300);
            Automobil auto24 = new Automobil("Opel", "Zafira", 2007, 183575.6, 3000);
            Automobil auto25 = new Automobil("Opel", "Corsa", 2004, 162367.9, 2600);
            Automobil auto26 = new Automobil("Nissan", "X-Trail", 2008, 185000.6, 6490);
            Automobil auto27 = new Automobil("Nissan", "Pixo", 2009, 66100.6, 3290);
            Automobil auto28 = new Automobil("Nissan", "Zafira", 1998, 178560.6, 1700);

            List<Automobil> garaza = new List<Automobil>();

            garaza.Add(auto1);
            garaza.Add(auto2);
            garaza.Add(auto3);
            garaza.Add(auto4);
            garaza.Add(auto5);
            garaza.Add(auto6);
            garaza.Add(auto7);
            garaza.Add(auto8);
            garaza.Add(auto9);
            garaza.Add(auto10);
            garaza.Add(auto11);
            garaza.Add(auto12);
            garaza.Add(auto13);
            garaza.Add(auto14);
            garaza.Add(auto15);
            garaza.Add(auto16);
            garaza.Add(auto17);
            garaza.Add(auto18);
            garaza.Add(auto19);
            garaza.Add(auto20);
            garaza.Add(auto21);
            garaza.Add(auto22);
            garaza.Add(auto23);
            garaza.Add(auto24);
            garaza.Add(auto25);
            garaza.Add(auto26);
            garaza.Add(auto27);
            garaza.Add(auto28);

            int i = 1;
            int mincena = 0;
            int maxcena = 1000000;
            int ebrend = 0;
            string pbrend = "neselektovan";
            int emodel = 0;
            string pmodel = "neselektovan";
            string ulaz4;
            int mingodiste = 1950, maxgodiste = 2022;
            int minkilometraza = 0, maxkilometraza = 1000000;
            while (i == 1)
            {
                Console.WriteLine("=============================================");
                Console.WriteLine("[1] Unesite ili Zamenite Raspon cena (" + mincena + "e-" + maxcena + "e)");
                Console.WriteLine("[2] Unesite ili Zamenite Brend Automobila (" + pbrend + ")");
                Console.WriteLine("[3] Unesite ili Zamenite Model Automobila (" + pmodel + ")");
                Console.WriteLine("[4] Unesite ili Zamenite Godiste Automobila (" + mingodiste + ".g-" + maxgodiste + ".g)");
                Console.WriteLine("[5] Unesite ili Zamenite Predjenu Kilometrazu (" + minkilometraza + "km-" + maxkilometraza + "km)");
                Console.WriteLine("[6] Trazi Automobile");
                Console.WriteLine("[7] Resetuj uslove");
                Console.WriteLine("[8] Zaustavi program");
                Console.WriteLine("");

                string ulaz = Console.ReadLine();

                switch (ulaz)
                {
                    case "1":
                        Console.WriteLine("Unesite minimalnu cenu Automobila [Min: 0]: ");
                        mincena = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Unesite maximalnu cenu Automobila [Max: 1000000]: ");
                        maxcena = Convert.ToInt32(Console.ReadLine());
                        if (mincena > maxcena)
                        {
                            mincena = 0;
                            maxcena = 1000000;
                            Console.WriteLine("!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
                            Console.WriteLine("Minimalna cena ne moze biti veca od maximalne");
                            Console.WriteLine("!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");

                        }
                        break;
                    case "2":
                        ebrend = 1;
                        Console.WriteLine("Izaberi Brend Automobila");
                        Console.WriteLine("[1] BMW");
                        Console.WriteLine("[2] Audi");
                        Console.WriteLine("[3] Skoda");
                        Console.WriteLine("[4] Opel");
                        Console.WriteLine("[5] Dacia");
                        Console.WriteLine("[6] Volkswagen");
                        Console.WriteLine("[7] Toyota");
                        Console.WriteLine("[8] Nissan");
                        Console.WriteLine("[9] Tesla");
                        string ulaz3 = Console.ReadLine();
                        switch (ulaz3)
                        {
                            case "1":
                                pbrend = "BMW";
                                break;
                            case "2":
                                pbrend = "Audi";
                                break;
                            case "3":
                                pbrend = "Skoda";
                                break;
                            case "4":
                                pbrend = "Opel";
                                break;
                            case "5":
                                pbrend = "Dacia";
                                break;
                            case "6":
                                pbrend = "Volkswagen";
                                break;
                            case "7":
                                pbrend = "Toyota";
                                break;
                            case "8":
                                pbrend = "Nissan";
                                break;
                            case "9":
                                pbrend = "Tesla";
                                break;
                            default:
                                Console.WriteLine("Pogrsan broj je izabran");
                                ebrend = 0;
                                continue;
                        }
                        break;
                    case "3":
                        if (ebrend == 1)
                        {
                            switch (pbrend)
                            {
                                case "BMW":
                                    emodel = 1;
                                    Console.WriteLine("Izaberi Model");
                                    Console.WriteLine("[1] X6");
                                    Console.WriteLine("[2] M5");
                                    Console.WriteLine("[3] X3");
                                    ulaz4 = Console.ReadLine();
                                    switch (ulaz4)
                                    {
                                        case "1":
                                            pmodel = "X6";
                                            break;
                                        case "2":
                                            pmodel = "M5";
                                            break;
                                        case "3":
                                            pmodel = "X3";
                                            break;
                                    }
                                    break;
                                case "Audi":
                                    emodel = 1;
                                    Console.WriteLine("Izaberi Model");
                                    Console.WriteLine("[1] A6");
                                    Console.WriteLine("[2] A4");
                                    Console.WriteLine("[3] A7");
                                    ulaz4 = Console.ReadLine();
                                    switch (ulaz4)
                                    {
                                        case "1":
                                            pmodel = "A6";
                                            break;
                                        case "2":
                                            pmodel = "A4";
                                            break;
                                        case "3":
                                            pmodel = "A7";
                                            break;
                                    }
                                    break;
                                case "Skoda":
                                    emodel = 1;
                                    Console.WriteLine("Izaberi Model");
                                    Console.WriteLine("[1] Octavia");
                                    Console.WriteLine("[2] Fabia");
                                    Console.WriteLine("[3] Yeti");
                                    ulaz4 = Console.ReadLine();
                                    switch (ulaz4)
                                    {
                                        case "1":
                                            pmodel = "Octavia";
                                            break;
                                        case "2":
                                            pmodel = "Fabia";
                                            break;
                                        case "3":
                                            pmodel = "Yeti";
                                            break;
                                    }
                                    break;
                                case "Opel":
                                    emodel = 1;
                                    Console.WriteLine("Izaberi Model");
                                    Console.WriteLine("[1] Zafira");
                                    Console.WriteLine("[2] Corsa");
                                    Console.WriteLine("[3] Astra");
                                    ulaz4 = Console.ReadLine();
                                    switch (ulaz4)
                                    {
                                        case "1":
                                            pmodel = "Zafira";
                                            break;
                                        case "2":
                                            pmodel = "Corsa";
                                            break;
                                        case "3":
                                            pmodel = "Astra";
                                            break;
                                    }
                                    break;
                                case "Dacia":
                                    emodel = 1;
                                    Console.WriteLine("Izaberi Model");
                                    Console.WriteLine("[1] Duster");
                                    Console.WriteLine("[2] Pickup");
                                    Console.WriteLine("[3] Sandero");
                                    ulaz4 = Console.ReadLine();
                                    switch (ulaz4)
                                    {
                                        case "1":
                                            pmodel = "Duster";
                                            break;
                                        case "2":
                                            pmodel = "Pickup";
                                            break;
                                        case "3":
                                            pmodel = "Sandero";
                                            break;
                                    }
                                    break;
                                case "Volkswagen":
                                    emodel = 1;
                                    Console.WriteLine("Izaberi Model");
                                    Console.WriteLine("[1] Golf 4");
                                    Console.WriteLine("[2] Golf 7");
                                    Console.WriteLine("[3] Touran");
                                    ulaz4 = Console.ReadLine();
                                    switch (ulaz4)
                                    {
                                        case "1":
                                            pmodel = "Golf 4";
                                            break;
                                        case "2":
                                            pmodel = "Golf 7";
                                            break;
                                        case "3":
                                            pmodel = "Touran";
                                            break;
                                    }
                                    break;
                                case "Toyota":
                                    emodel = 1;
                                    Console.WriteLine("Izaberi Model");
                                    Console.WriteLine("[1] Corona");
                                    Console.WriteLine("[2] Carina");
                                    Console.WriteLine("[3] Supra");
                                    ulaz4 = Console.ReadLine();
                                    switch (ulaz4)
                                    {
                                        case "1":
                                            pmodel = "Corona";
                                            break;
                                        case "2":
                                            pmodel = "Carina";
                                            break;
                                        case "3":
                                            pmodel = "Supra";
                                            break;
                                    }
                                    break;
                                case "Nissan":
                                    emodel = 1;
                                    Console.WriteLine("Izaberi Model");
                                    Console.WriteLine("[1] Pixo");
                                    Console.WriteLine("[2] X-Trail");
                                    Console.WriteLine("[3] Serena");
                                    ulaz4 = Console.ReadLine();
                                    switch (ulaz4)
                                    {
                                        case "1":
                                            pmodel = "Pixo";
                                            break;
                                        case "2":
                                            pmodel = "X-Trail";
                                            break;
                                        case "3":
                                            pmodel = "Serena";
                                            break;
                                    }
                                    break;
                                case "Tesla":
                                    emodel = 1;
                                    Console.WriteLine("Izaberi Model");
                                    Console.WriteLine("[1] Model S");
                                    Console.WriteLine("[2] Model 3");
                                    ulaz4 = Console.ReadLine();
                                    switch (ulaz4)
                                    {
                                        case "1":
                                            pmodel = "Model S";
                                            break;
                                        case "2":
                                            pmodel = "Model 3";
                                            break;
                                    }
                                    break;
                                default:
                                    Console.WriteLine("Nepostojeci Brend je izabran");
                                    continue;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Unesi prvo parku Automobila");
                        }
                        break;
                    case "4":
                        Console.WriteLine("Unesite pocetnu godinu: ");
                        mingodiste = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Unesite krajnju godinu: ");
                        maxgodiste = Convert.ToInt32(Console.ReadLine());
                        if (mingodiste > maxgodiste)
                        {
                            mingodiste = 1950;
                            maxgodiste = 2022;
                            Console.WriteLine("!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
                            Console.WriteLine("Minimalna godina ne moze biti veca od maximalne godine");
                            Console.WriteLine("!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
                        }
                        if (mingodiste < 1950 || maxgodiste > 2022)
                        {
                            mingodiste = 1950;
                            maxgodiste = 2022;
                            Console.WriteLine("!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
                            Console.WriteLine("Godina mora biti izmedu 1950 i 2022");
                            Console.WriteLine("!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
                        }
                        break;
                    case "5":
                        Console.WriteLine("Unesite pocetnu kilometrazu: ");
                        minkilometraza = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Unesite krajnju kilometrazu: ");
                        maxkilometraza = Convert.ToInt32(Console.ReadLine());
                        if (minkilometraza > maxkilometraza)
                        {
                            minkilometraza = 0;
                            maxkilometraza = 1000000;
                            Console.WriteLine("!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
                            Console.WriteLine("Minimalna kilometraza ne moze biti veca od maximalne kilometraze");
                            Console.WriteLine("!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
                        }
                        break;
                    case "6":
                        for (int n = 0; n < garaza.Count(); n++)
                        {
                            if (ebrend == 1 && pbrend == garaza[n].brend)
                            {
                                if (emodel == 1 && pmodel == garaza[n].model)
                                {
                                    if (minkilometraza <= garaza[n].predjenakm && maxkilometraza >= garaza[n].godiste)
                                    {
                                        if (mingodiste <= garaza[n].godiste && maxgodiste >= garaza[n].godiste)
                                        {

                                            if (garaza[n].cena >= mincena && garaza[n].cena <= maxcena)
                                            {
                                                Console.WriteLine(garaza[n].brend + " " + garaza[n].model + " " + garaza[n].godiste + " " + garaza[n].predjenakm + " km " + garaza[n].cena + " e");
                                            }
                                        }
                                    }
                                }
                                else if (emodel == 0)
                                {
                                    if (minkilometraza <= garaza[n].predjenakm && maxkilometraza >= garaza[n].godiste)
                                    {
                                        if (mingodiste <= garaza[n].godiste && maxgodiste >= garaza[n].godiste)
                                        {
                                            if (garaza[n].cena >= mincena && garaza[n].cena <= maxcena)
                                            {
                                                Console.WriteLine(garaza[n].brend + " " + garaza[n].model + " " + garaza[n].godiste + " " + garaza[n].predjenakm + " km " + garaza[n].cena + " e");
                                            }
                                        }
                                    }
                                }
                            }
                            else if (ebrend == 0)
                            {
                                if (minkilometraza <= garaza[n].predjenakm && maxkilometraza >= garaza[n].godiste)
                                {
                                    if (mingodiste <= garaza[n].godiste && maxgodiste >= garaza[n].godiste)
                                    {
                                        if (garaza[n].cena >= mincena && garaza[n].cena <= maxcena)
                                        {
                                            Console.WriteLine(garaza[n].brend + " " + garaza[n].model + " " + garaza[n].godiste + " " + garaza[n].predjenakm + " km " + garaza[n].cena + " e");
                                        }
                                    }
                                }
                            }
                        }
                        Console.WriteLine("[1] Nastavi sa programom");
                        Console.WriteLine("[2] Zaustavi program");
                        string ulaz2 = Console.ReadLine();
                        switch (ulaz2)
                        {
                            case "1":
                                break;
                            case "2":
                                i = 0;
                                break;
                            default:
                                Console.WriteLine("Pogrsan broj je izabran");
                                continue;
                        }
                        break;
                    case "7":
                        mincena = 0;
                        maxcena = 1000000;
                        ebrend = 0;
                        emodel = 0;
                        mingodiste = 1900;
                        maxgodiste = 2022;
                        minkilometraza = 0;
                        maxkilometraza = 1000000;
                        pmodel = "neselektovan";
                        pbrend = "neselektovan";
                        break;
                    case "8":
                        i = 0;
                        break;
                    default:
                        Console.WriteLine("Pogrsan broj je izabran");
                        continue;
                }
            }
        }
    }
}
