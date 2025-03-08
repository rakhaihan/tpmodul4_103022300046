using System;

namespace tpmodul4_103022300046
{
    class Program
    {
        static void Main(string[] args)
        {

            // Bagian untuk KodePos
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

            // Bagian untuk DoorMachine
            DoorMachine doorMachine = new DoorMachine();
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine($"State saat ini: {doorMachine.currentState}");
                Console.WriteLine("Masukkan perintah (BukaPintu, KunciPintu, Exit):");
                string input = Console.ReadLine();

                switch (input)
                {
                    case "BukaPintu":
                        doorMachine.activate(DoorMachine.Trigger.BukaPintu);
                        break;
                    case "KunciPintu":
                        doorMachine.activate(DoorMachine.Trigger.KunciPintu);
                        break;
                    case "Exit":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("perintah salah.");
                        break;
                }
            }
        }
    }
}
