using System;

namespace CokBoyutluDiziler1
{
    class Program
    {
        static void Main(string[] args)
        {
            int satir, sutun;
            Console.WriteLine("Satır sayısını girin");
            satir = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Sütun sayısını girin");
            sutun = Convert.ToInt16(Console.ReadLine());
            int[,] matris = new int[satir,sutun];

            for (int i = 0; i < satir; i++)
            {
                for (int j = 0; j < sutun; j++)
                {
                    Console.WriteLine("Matrisin {0} x {1} değeri",i+1,j+1);
                    matris[i, j] = Convert.ToInt32(Console.ReadLine());
                }

            }
            Console.WriteLine("Değerler \n");

            for (int k = 0; k < satir; k++)
            {
                for (int m = 0; m < sutun; m++)
                {
                    Console.Write(matris[k,m] + " ");
                }
                Console.WriteLine();
            }
            // matrisin transpose'u
            Console.WriteLine("Transposes \n");
            for (int x = 0; x < sutun; x++)
            {
                for (int y = 0; y < satir; y++)
                {
                    Console.Write(matris[y,x] + " ");
                }
                Console.WriteLine();
            }
            
            Console.WriteLine("Bir sayı giriniz");
            int carpım = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Çarpım \n");
            for (int s = 0; s < satir; s++)
            {
                for (int p = 0; p < sutun; p++)
                {
                    Console.Write(matris[s, p]*carpım + " ");
                }
                Console.WriteLine();
            }


            // Determinant
            //determinant değeri daima pozitif çıkar mutlak değere alınır

            int a, b, c, d,sonuc;
            Console.WriteLine("a değerini giriniz: ");
            a = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("b değerini giriniz: ");
            b = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("c değerini giriniz: ");
            c = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("d değerini giriniz: ");
            d = Convert.ToInt16(Console.ReadLine());
            sonuc = Math.Abs( (a * d) - (b * c)); // mutlak değer fonksiyonu
            Console.WriteLine("Determinant:"+sonuc);


        }
    }
}
