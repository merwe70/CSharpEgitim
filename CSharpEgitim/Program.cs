using System;

namespace CSharpEgitim
{
    class Program
    {
        static void Main(string[] args)
        {

            var number7 = 10; // değişken tutmak için kullanılır.
            number7 = 'A'; // 65 değerini verir. Çünkü ilk başta biz bunu integer atadık.
            //value types
            // Console.WriteLine("Hello World!"); //uygulamanın yaşam döngüsü bu metotta parantezin içidir
            double number5 = 10.5; // 64 bit lik veri tutuşu mevcut. Ondalıklı sayıları tutuyoruz.
            //İNT İÇİN LONG NE İSE DOUBLE İÇİN DE DECİMAL ODUR.
            decimal number6 = 10.4m;// para için decimal kullanılıyır virgülden sonra 28 karakter tutuyor

            char character = 'M';
            string city = "İstanbul";
            bool condition = false;
            int number1 = 2147483647; //int in alacağı son değer bu---- 32 bit
            long number2 = 2147483648; //longun sınırı 19 karakterden oluşuyor----64 bit
            short number3 = 32767;  //16 bit
            byte number4 = 255; //0 ile 255 arası ve 8 bit
                                //long int in 2 katı kadar fazla değer tutar. Long aslında int i kapsar.int yazılacak yere long yazarsak belleğimizde fazla yer kaplamış oluruz. 

            
            
            Console.WriteLine("Number1 is : {0}", number1);//süslü parantez içindeki sayı yukarıda tanımladığımız dğeri göstermek için 
            Console.WriteLine("Number2 is : {0}", number2);
            Console.WriteLine("Number3 is : {0}", number3);
            Console.WriteLine("Number4 is : {0}", number4);
            Console.WriteLine("Number4 is : {0}", number4);

            Console.WriteLine("Character is : {0}", character);
            Console.WriteLine("Character is : {0}", (int)character);// char veri türünün karşılığını yazdırırken başına int yazar isek, ASCII karşılığını alırız karakterin
            Console.WriteLine((int)Days.Friday);
        }

        // enum la ilgili tip değişimi önemli. Başlangıç değeri aslında 0 biz başlandıç değerinin 1 olmasını istiyorsak Monday=1 yapmalıyız
        enum Days //enum  string gibi tek tek yazmayı engelliyor. Enum yapısının avantajı bir değişiklik yapıldığında string olarak yazılsa idi her yerde tek tek değiştirmek zorunda kalırdık. Enum yapısı ile bunun olmasını engellemiş olduk
        {
            Monday=1,Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday
        }
    }


}
