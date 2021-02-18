using System;

namespace CokBoyutluDiziler
{
    class Program
    {
        static void Main(string[] args)
        {
            // iki boyutlu dizi
            //matrisler çok boyutlu dizilerdir (matematiksel ifadeler)satılar ve sütünlardan oluşur

            //int[,] dizi = new int [2,2];
            //dizi[0, 0] = 25;
            //dizi[0, 1] = 35;
            //dizi[1, 0] = 17;
            //dizi[1, 1] = 16;

            //for (int i = 0; i < 2; i++)
            //{
            //    for (int j = 0; j < 2; j++)

            //        Console.Write(" {0} ",dizi[i,j]);
            //        Console.WriteLine();              
            //}

            //int[,] dizi =new int [2,3];
            //dizi[0, 0] = 10;
            //dizi[0, 1] = 20;
            //dizi[0, 2] = 30;
            //dizi[1, 0] = 40;
            //dizi[1, 1] = 50;
            //dizi[1, 2] = 60;

            //for (int i = 0; i < 2; i++)
            //{
            //    for (int j = 0; j < 3; j++)

            //        Console.Write(" * ",dizi[i,j]);
            //        Console.WriteLine();


            //}

            // Matrislerde toplama
            Console.Write("Matrislerde Toplama");

            int[,] matris = { { 10, 12, 14, 16 } ,{ 20, 14, 41, 21 },{ 25,14,41,21},{32,36,41,57 } };

            int[,] matris1 = { { 40,30,20,10 }, { 7,9,8,6 }, { 21,22,23,24},{ 34,35,36,37} };
           
            int[,] toplam = new int [4,4];

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    toplam[i, j] = matris[i, j] + matris1[i, j];
                }
            }

            for (int k = 0; k < 4; k++)
            {
                Console.WriteLine();

                for (int m = 0; m < 4; m++)
                {
                    Console.Write(toplam[k,m]+" ");
                }
            }
            Console.WriteLine();
            int[] matriss = { 177, 52, 63 };
            for (int a = 0; a < 3; a++)
            {
                Console.WriteLine(matriss[a]);

            } 

        }
    }
}
