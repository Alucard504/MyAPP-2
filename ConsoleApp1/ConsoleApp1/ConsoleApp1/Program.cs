using System;
using System.ComponentModel.DataAnnotations;
using System.Security.AccessControl;
class Program
{
    static void Main()
    {
        Console.WriteLine("Rumus Matematika");
        Console.WriteLine("1.Rumus Segitiga");
        Console.WriteLine("2.Rumus Jajargenjang");
        Console.Write("Pilih mode: ");
        int mode = Convert.ToInt32(Console.ReadLine());

        if (mode == 1) {
            op_luas_segitiga();
        } else if (mode == 2) {
            op_Luas_jajargenjang();
        } else {

        }
    }

    static void op_luas_segitiga() {

        //minta pengguna memasukan nilai alas
        Console.Write("Masukan alas segitiga: ");
        double alas = Convert.ToDouble(Console.ReadLine());
        //minta pengguna memasukan nilai tinggi
        Console.Write("Masukan tinggi segitiga: ");
        double tinggi = Convert.ToDouble(Console.ReadLine());
        //Hitung luas segitiga
        double luas = 0.5 * alas * tinggi;

        Console.WriteLine("Luas segitiga adalah: "+ luas);
    }

    static void op_Luas_jajargenjang() {

        //minta pengguna memasukan nilai alas 
        Console.WriteLine("Masukan alas jajargenjang");
        double alas = Convert.ToDouble(Console.ReadLine());
        //minta pengguna memasukan nilai tinggi
        Console.WriteLine("Masukan tinggi jajargenjang");
        double tinggi = Convert.ToDouble(Console.ReadLine());
        //menghitung luas jajargenjang
        double luas = alas * tinggi;

        Console.WriteLine("Luas jajargenjang adalah: " + luas);
    }
}