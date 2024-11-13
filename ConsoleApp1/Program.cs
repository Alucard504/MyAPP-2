using System;

class Program
{
    static void Main()
    {
        Console.Clear();
        Console.WriteLine("==========================");
        Console.WriteLine(" Menghitung Luas Segitiga ");
        Console.WriteLine("==========================");
        //Minta pengguna memasukan nilai alas
        Console.Write("Nilai Alas Segitiga: ");
        double Alas = Convert.ToDouble(Console.ReadLine());

        //Minta pengguna memasukan nilai tinggi
        Console.WriteLine("Nilai Tinggi Segitiga");
        double Tinggi = Convert.ToDouble(Console.ReadLine());
        
        double Luas = 0.5 * Alas * Tinggi;

        Console.WriteLine("luas Segitiga adalah: " + Luas);
    }
}