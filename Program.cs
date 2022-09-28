using System;

namespace operatorlar
{
    class program
    {

        private static void Main(String[] args)
        {
            // Atama ve İşlemli Atama

            int x = 3;
            int y = 3;
            y = y + 2;
            Console.WriteLine(y);
            y += 2;
            Console.WriteLine(y);
            y /= 1;
            Console.WriteLine(y);
            x *= 2;
            Console.WriteLine(x);

            //Mantıksal Operatörler

            bool isSucces = true;
            bool isComplated = true;
             if (isSucces && isComplated)
             {
                Console.WriteLine("mükemmel");
             }

             if (isSucces || isComplated)
             {
                System.Console.WriteLine("çok iyi");
             }

             if (isSucces && !isComplated)
             {
                System.Console.WriteLine("güzel");
             }

             int a = 3;
             int b = 4;
             bool sonuc = a<b;

             Console.WriteLine(sonuc);
             sonuc = a>b;
             Console.WriteLine(sonuc);
             sonuc = a>=b;
             Console.WriteLine(sonuc);
             sonuc = a<=b;
             Console.WriteLine(sonuc);
             sonuc = a==b;
             Console.WriteLine(sonuc);
             sonuc = a!=b;
             Console.WriteLine(sonuc);

             int sayi1 = 10;
             int sayi2 = 5;

             int sonuc1 = sayi1/sayi2;
             System.Console.WriteLine(sonuc1);
             sonuc1= sayi1*sayi2;
             System.Console.WriteLine(sonuc1);
             sonuc1 = sayi1+sayi2;
             System.Console.WriteLine(sonuc1);
             sonuc1 = sayi1++;
             System.Console.WriteLine(sonuc1);

             int sonuc2 = 20%3;
             System.Console.WriteLine(sonuc2);


        }

    }
};
