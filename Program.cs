using System;

namespace tpmodul4_103022300046
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Masukkan nama kelurahan: ");
            string inputKelurahan = Console.ReadLine();

            KodePos.Kelurahan kelurahan;
            bool isValidKelurahan = Enum.TryParse(inputKelurahan,true ,out kelurahan);

            if (isValidKelurahan)
            {
                int kodePos = KodePos.getKodePos(kelurahan);
                Console.WriteLine($"Kode Pos untuk {inputKelurahan}: {kodePos}");
            }
            else
            {
                Console.WriteLine("Kelurahan tidak valid.");
            }
        }
    }
}
