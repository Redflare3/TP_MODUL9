using System;

namespace TP_MODUL9_103022400141 {
    class Program
    {
        static void Main()
        {
            CovidConfig config = CovidConfig.LoadConfig();

            for (int i = 0; i <= 2; i++){
                Console.WriteLine("Satuan suhu saat ini: " + config.satuan_suhu);
                Console.Write("ubah satuan? (y/n): ");
                string ubah = Console.ReadLine();
                Console.WriteLine();

                if (ubah == "y")
                {
                    config.UbahSatuan();
                    Console.WriteLine("Satuan sekarang: " + config.satuan_suhu);
                    Console.WriteLine();
                }
                Console.Write("Berapa suhu badan anda saat ini? Dalam nilai " + config.satuan_suhu + ": ");
                double suhu = Convert.ToDouble(Console.ReadLine());

                Console.Write("Berapa hari yang lalu anda terakhir memiliki gejala demam?: ");
                int hari = Convert.ToInt32(Console.ReadLine());

                bool suhuValid = false;

                if (config.satuan_suhu == "celcius")
                {
                    if (suhu >= 36.5 && suhu <= 37.5)
                    {
                        suhuValid = true;
                    }
                }
                else if (config.satuan_suhu == "fahrenheit")
                {
                    if (suhu >= 97.7 && suhu <= 99.5)
                    {
                        suhuValid = true;
                    }
                       
                }

                bool hariValid = (hari < config.batas_hari_demam);

                if (suhuValid && hariValid)
                {
                    Console.WriteLine(config.pesan_diterima);
                    Console.WriteLine();
                }
                else if (!(suhuValid && hariValid))
                {
                    Console.WriteLine(config.pesan_ditolak);
                    Console.WriteLine();
                }
                else { Console.WriteLine("Test"); }
            }
        }
    }
}
