using System;


namespace Tugas{
    class Program{
        static void Main(string[] args){
            Console.WriteLine("Aplikasi Kalkulator");

            pilihan:
            Console.WriteLine("1. Penjumlahan");
            Console.WriteLine("2. Pengurangan");
            Console.WriteLine("3. Pembagian");
            Console.WriteLine("4. Perkalian");

            Console.Write("Masukan Pilihan : ");
            int pilih = Convert.ToInt32(Console.ReadLine());

            if(pilih == 1){
                Console.Write("Masukan Nilai a : ");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.Write("Masukan Nilai b : ");
                int b = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine();
                Console.WriteLine("Hasil Penjumlahan " + a + " + " + b + " = " + penambahan(a,b));
                Console.ReadKey();
            }else if(pilih == 2){
                Console.Write("Masukan Nilai a : ");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.Write("Masukan Nilai b : ");
                int b = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine();
                Console.WriteLine("Hasil Pengurangan " + a + " - " + b + " = " + pengurangan(a,b));
                Console.ReadKey();
            }else if(pilih == 3){
                Console.Write("Masukan Nilai a : ");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.Write("Masukan Nilai b : ");
                int b = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine();
                Console.WriteLine("Hasil Penmbagian " + a + " : " + b + " = " + pembagian(a,b));
                Console.ReadKey();
            }else if(pilih == 4){
                Console.Write("Masukan Nilai a : ");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.Write("Masukan Nilai b : ");
                int b = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine();
                Console.WriteLine("Hasil Perkalian " + a + " x " + b + " = " + perkalian(a,b));
                Console.ReadKey();
            }else {
                Console.WriteLine("Input nomor salah, silahkan coba lagi");
                goto pilihan;
            }
        }

        static int penambahan(int a,int b){
            return a + b;
        }
        static int pengurangan(int a,int b){
            return a - b;
        }
        static int pembagian(int a,int b){
            return a / b;
        }
        static int perkalian(int a, int b){
            return a * b;
        }
    }
}

