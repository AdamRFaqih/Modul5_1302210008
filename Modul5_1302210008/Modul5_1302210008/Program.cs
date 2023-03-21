using System.Security.Cryptography;

class Penjumlahan
{
    public void jumlahTigaAngka<T>(T angka1, T angka2, T angka3)
    {
        dynamic ang1, ang2, ang3;
        ang1 = angka1;
        ang2 = angka2;
        ang3 = angka3;
        Console.WriteLine(ang1+ ang2 + ang3);
    }
}

class Utama
{
    public static void Main(string[] args)
    {
        Penjumlahan penjumlahan = new Penjumlahan();
        penjumlahan.jumlahTigaAngka<int>(13, 02, 21);
    }
}