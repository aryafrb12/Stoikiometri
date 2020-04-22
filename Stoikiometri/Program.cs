using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace Stoikiometri
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\tProgram Stoikiometri (Molaritas dan Molalitas)");
            Console.WriteLine();
            Console.WriteLine("Menu : ");
            Console.WriteLine("1. Molaritas");
            Console.WriteLine("2. Molalitas");
            Console.WriteLine();
            Console.Write("Masukkan Pilihan Anda : ");
            int menu = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            switch (menu)
            {
                case 1:
                    Console.WriteLine("Anda Memilih Molaritas");
                    Molaritas molaritas = new Molaritas();
                    Console.WriteLine();
                    Console.Write("Apakah Sudah diketahui Molnya? (Y/T) : ");
                    string mol = Console.ReadLine();

                    if (mol == "Y" || mol == "y")
                    {
                        Console.WriteLine();
                        Console.Write("Mol (mol) : ");
                        molaritas.mol = float.Parse(Console.ReadLine());
                        Console.Write("Volume (ml) : ");
                        molaritas.volume = float.Parse(Console.ReadLine());
                        Console.WriteLine("Molaritas : " + molaritas.YMolaritas());
                    }
                    else if (mol == "T" || mol == "t")
                    {
                        Console.WriteLine();
                        Console.Write("Massa (gram) : ");
                        molaritas.massa = float.Parse(Console.ReadLine());
                        Console.Write("Mr : ");
                        molaritas.mr = float.Parse(Console.ReadLine());
                        Console.Write("Volume (ml) : ");
                        molaritas.tvolume = float.Parse(Console.ReadLine());
                        Console.WriteLine("Molaritas : " + molaritas.TMolaritas());
                    }
                    else
                    {
                        Console.WriteLine("Error");
                    }
                    break;
                case 2:
                    Console.WriteLine("Anda Memilih Molalitas");
                    Console.WriteLine();
                    Molalitas molalitas = new Molalitas();
                    Console.Write("Massa Pelarut (gram) : ");
                    molalitas.massap = float.Parse(Console.ReadLine());
                    Console.Write("Mol (mol) : ");
                    molalitas.mols = float.Parse(Console.ReadLine());
                    Console.WriteLine("Molalitas : " + molalitas.YMolalitas());
                    break;
                default:
                    Console.WriteLine("Error");
                    break;
            }

        }
    }
}
