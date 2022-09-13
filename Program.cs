using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odev1_algoritmaSoruları
{
    class Program
    {
        static void Main(string[] args)
        {
            //  1. Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n).Sonrasında kullanıcıdan  n adet pozitif
            //   sayı girmesini isteyin.Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın.

              Console.WriteLine("lutfen cift bir sayi giriniz..");
              int n = Convert.ToInt32(Console.ReadLine());
              Console.WriteLine("lutfen {0} adet sayi giriniz..",n);
              int[] sayiDizisi = new int[n];
              for (int i = 0; i < n; i++)
              {
                  sayiDizisi[i] = int.Parse(Console.ReadLine());
              }
              Console.WriteLine("cift olan sayilar..");

              foreach (var item in sayiDizisi)
              {
                  if (item%2==0)
                  {
                      Console.WriteLine(item);
                  }
              } 

            //  2.  Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin(n, m).
            //  Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin.Kullanıcının girmiş olduğu
            //  sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.

             Console.WriteLine("lutfen iki sayi giriniz..");
             Console.Write("birinci sayi:");
             int n = Convert.ToInt32(Console.ReadLine());
             Console.Write("ikinci sayi:");
             int m = Convert.ToInt32(Console.ReadLine());

             Console.WriteLine("lutfen {0} adet sayi giriniz..", n);
             int[] sayiDizisi2 = new int[n];
             for (int i = 0; i < n; i++)
             {
                 sayiDizisi2[i] = int.Parse(Console.ReadLine());
             }

             foreach (var item2 in sayiDizisi2)
             {
                 if (item2 == m || m%item2==0 )
                 {
                     Console.WriteLine(item2);
                 }
             } 

            //  3.  Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n). 
            //      Sonrasında kullanıcıdan n adet kelime girmesi isteyin.
            //      Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın.

             Console.WriteLine("lutfen  bir sayi giriniz..");
             int n = Convert.ToInt32(Console.ReadLine());
             Console.WriteLine("lutfen {0} adet kelime giriniz",n);

             string[] kelimeDizisi = new string[n];
             for (int i = 0; i < n; i++)
             {
                 Console.WriteLine("lutfen {0}. kelimeyi giriniz..",i+1);
                 kelimeDizisi[i] = Console.ReadLine();
             }

             Console.WriteLine("girmiş oldugunuz kelımelerın tersten siralanisi su sekildedir..");

             Array.Reverse(kelimeDizisi);
             foreach (var item in kelimeDizisi)
             {
                 Console.WriteLine(item);
             }

             

            // 4.Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin.
            //   Cümledeki toplam kelime ve harf sayısını console'a yazdırın.

            Console.WriteLine("lutfen bır cumle yazınız.. ");
            string cumle = Console.ReadLine();
            string[] kelimeler = cumle.Split(' ');
           
            Console.Write("kelime sayisi:");
            Console.WriteLine(kelimeler.Length);
            Console.Write("harf sayisi sayisi:");
            Console.Write(cumle.Length - (kelimeler.Length-1));
            Console.ReadLine();
        }
    }
}
