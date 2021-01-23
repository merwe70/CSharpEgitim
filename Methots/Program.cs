using System;
using System.Linq;

namespace Methots
{
    class Program
    {
        static void Main(string[] args)
        {
            //Add();
            //Add();
            //Add();
            //Add();

            //int number1 ;
            //int number2 = 100;
            //var result2 = Add4(out number1, number2);
            //Console.WriteLine(result2); //Bunun cevabı 130
            //Console.WriteLine(number1); // cvp:20. Nedeni bu değer tip. değer 1 gitmiyor değeri gidiyor.

            //Console.WriteLine(Add3(5));
            //Console.WriteLine(Add2(20,30));
            Console.WriteLine(Multiply(2,4));
            Console.WriteLine(Multiply(2, 4,5));

            Console.WriteLine(Add5(1,2,3,4,5,6));
        }

        static void Add()
        {
            Console.WriteLine("Added!");
        }

        static int Add2(int number1, int number2)
        {
            var result= number1 + number2;
            return result ;
        }

        static int Add3(int number1, int number2=40) //burada default değerini 40 verdik. Yani, eğer number 2 verilmezse otomatikman o sayı 40 olacak demek
            //Default değeri her zaman metodun sonunda olması gerekiyor.
        {
            var result = number1 + number2;
            return result;
        }


        //ref te number1 i mutlaka set etmemiz gerekiyor.Out ta böyle bir zorunluluk yok
        //out kullanırsak metodun içinde set edilmesi gerekiyor. Set edilmezse hata verir
        static int Add4(out int number1, int number2)
        {
            number1 = 30;
            return number1 + number2;
        }

        static int Multiply(int number1, int number2)
        {
            return number1 * number2;
        }

        static int Multiply(int number1, int number2, int number3)
        {
            return number1 * number2* number3;
        }
        //Metotta aynı adı kullansak farklı parametreleri kullansak bir sıkıntı olmaz.Buna Overload deniyor


        //params ile metodumuza aynı tipte istediğimiz kadar parametre gönderebiliriz
        static int Add5 (params int[] numbers)//params notasyonu ile dizi formatında parametreyi yollayabiliriz demek
        {
            return numbers.Sum();

        }
    }
}
