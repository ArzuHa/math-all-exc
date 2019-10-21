using System;

namespace Math_all_exc
{
    class Program
    {
        static void Main(string[] args)
        //3cu tapsiriq

        //1ci mesele
        {
            //Console.WriteLine("Reqem daxil edin");
            //int eded = int.Parse(Console.ReadLine());

            //if (eded % 2 == 0 && eded % eded == 0)
            //{
            //    Console.WriteLine("Daxil etdiyiniz reqem cut ededdir");
            //}
            //else
            //{
            //    Console.WriteLine("Daxil etdiyiniz reqem tek ededdir");
            //}

            //Console.WriteLine(eded);
            //Console.ReadKey();

            //2ci mesele

            //Console.WriteLine(" 1ci reqemi daxil edin");
            //int eded1 = int.Parse(Console.ReadLine());

            //Console.WriteLine("2ci reqemi daxil edin");
            //int eded2 = int.Parse(Console.ReadLine());
            //int cavab=eded1/eded2;
            //if (eded1%eded2==0)
            //{
            //    Console.WriteLine($"{eded1} / {eded2} = {cavab}");
            //}
            //else
            //{
            //    Console.WriteLine("Daxil etdiyiniz reqemler bir birine tam bolunmur");
            //}

            //Console.ReadKey();

            //3cu mesele

            //Console.WriteLine("Reqem daxil edin:");
            //int n = int.Parse(Console.ReadLine());
            //int temp,x;
            //while (n!=0)
            //{
            //    temp = n % 10;
            //    n = n / 10;


            //    Console.WriteLine(temp);
            //    if (temp == 7)
            //    {
            //        Console.WriteLine("Daxil etdiyiniz ededin sonu 7 ile bitir");
            //    }
            //    else {
            //        Console.WriteLine("Daxil etdiyiniz reqemin sonu 7 ile bitmir");
            //            }
            //}


            //Console.ReadKey();

            //4cu mesele

            //Console.WriteLine("Reqem daxil edin:");
            //int n = int.Parse(Console.ReadLine());
            //int temp, x;
            //while (n != 0)
            //{
            //    temp = n % 10;
            //    n = n / 10;

            //    if (temp == n)
            //    {
            //        Console.WriteLine("Daxil edilen ededde reqemler eynidir");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Daxil edilen ededde reqemler eyni deyil");
            //    }


            //}
            //Console.ReadKey();

            //5ci mesele

            Console.WriteLine("Reqem daxil edin:");
            int n = int.Parse(Console.ReadLine());
            int temp, x=0,t=1;
            while (n != 0)
            {
                temp = n % 10;
                n = n / 10;
                x =x + temp;
                t =t * temp;

                if (x%2==0 && x%x==0)
                {
                    Console.WriteLine(t);
                }
                else
                {
                    Console.WriteLine("Daxil edilen ededde reqemler cemi cut deyil");
                }


            }
            Console.ReadKey();
        }
    }
}
