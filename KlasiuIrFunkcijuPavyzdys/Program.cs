using System;


namespace KlasiuIrFunkcijuPavyzdys
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Zmogus zmogus1 = new Zmogus();

            Zmogus zmogus2 = new Zmogus("Sarunas", "Genys", 1998);
            

            Console.WriteLine();

            zmogus1.GimimoMetai = 1995;
            zmogus1.Vardas = "Jonas";
            zmogus1.Pavarde = "Jonaitis";

            Console.WriteLine();

            Console.WriteLine($"{zmogus1.Vardas} {zmogus1.Pavarde} {zmogus1.GimimoMetai} , Gimimo Metai yra lyginiai {zmogus1.ArMetaiLyginiai()}");

            Console.WriteLine($"{zmogus2.Vardas} {zmogus2.Pavarde} {zmogus2.GimimoMetai} , Gimimo Metai yra lyginiai {zmogus2.ArMetaiLyginiai()}");

        }
    }
    
}