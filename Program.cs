using System.ComponentModel;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;

namespace TASK__2
//{
#region task1
//    internal class Program
//    {
//        static void Main(string[] args)
//        { 

//            int [] numbers= { 5, -9, -8, 4 };
//            Console.WriteLine(minimum(numbers));
//        }

//        static int minimum(int[] numbers)
//        {
//            int mini = numbers[0];
//            int i = 1;
//            for (i = 1; i<numbers.Length; i++)
//            {
//                if (mini > numbers[i])
//                {
//                    mini = numbers[i];
//                }

//            }
//            return mini;
//        }
//    }
//}
#endregion
#region
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("emeliyyati daxil edin\n1)cevrenin sahesi\n2)duzbucaqlinin sahesi \n 3)duzbucaqli paralelipedin sahesi\nucbucagin daviline cekilmis cevrenin radisusu");
//            string emeliyyat = Console.ReadLine();
//            while (emeliyyat != "1" && emeliyyat != "2" && emeliyyat != "3" && emeliyyat != "4")
//            {
//                Console.WriteLine("1-4 araliginda secim edin!");
//                emeliyyat = Console.ReadLine();
//            }
//            switch (emeliyyat)
//            {
//                case "1":
//                    Console.WriteLine("Perimetr ve radiusu daxil edin");
//                    int perimetr = Convert.ToInt32(Console.ReadLine());
//                    int Radius = Convert.ToInt32(Console.ReadLine());
//                    Console.WriteLine(sahe(perimetr, Radius));
//                    break;
//                case "2":
//                    Console.WriteLine("duzbucaqlinin en  ve uzunlugunu qeyd edin!");
//                    int teref_1 = Convert.ToInt32(Console.ReadLine());
//                    int teref_2 = Convert.ToInt32(Console.ReadLine());
//                    Console.WriteLine(sahe_duzbucaqli(teref_1, teref_2));
//                    break;
//                case "3":
//                    Console.WriteLine("paralelipedin tereflerini qeyd edin");
//                    int par_teref_1 = Convert.ToInt32(Console.ReadLine());
//                    int par_teref_2 = Convert.ToInt32(Console.ReadLine());
//                    int par_teref_3 = Convert.ToInt32(Console.ReadLine());
//                    Console.WriteLine(sahe_paraleliped(par_teref_1, par_teref_2, par_teref_3));
//                    break;
//                case "4":
//                    Console.WriteLine("ucbucagin tereflerin qeyd edin!");
//                    int ucbucaq_teref_1 = Convert.ToInt32(Console.ReadLine());
//                    int ucbucaq_teref_2 = Convert.ToInt32(Console.ReadLine());
//                    int ucbucaq_teref_3 = Convert.ToInt32(Console.ReadLine());
//                    int Radius_ucbucaq = Convert.ToInt32(Console.ReadLine());
//                    Console.WriteLine(sahe_ucbucaqli(ucbucaq_teref_1, ucbucaq_teref_2, ucbucaq_teref_3, Radius_ucbucaq));
//                    break;
//            }


//        }

//        static int sahe(int Perimetr, int Radisus)
//        {
//            if (Perimetr <= 0 || Radisus <= 0)
//            {
//                Console.WriteLine("radius ve perimetr menfi ola bilmez!");
//                return 0;
//            }
//            else
//            {
//                int m = 3;
//                int S = 0;
//                S = Perimetr * (Radisus * Radisus) * (m);
//                return S;
//            }
//        }
//        static int sahe_duzbucaqli(int teref_1, int teref_2)
//        {
//            if (teref_1 <= 0 || teref_2 <= 0)
//            {
//                Console.WriteLine("Terefler menfi ola bilmez!");
//                return 0;
//            }
//            else
//            {
//                int S = 0;
//                S = teref_1 * teref_2;
//                return S;
//            }
//        }
//        static int sahe_ucbucaqli(int ucbucaq_teref_1, int ucbucaq_teref_2, int ucbucaq_teref_3, int Radius_ucbucaq)
//        {
//            if (ucbucaq_teref_1 <= 0 || ucbucaq_teref_2 <= 0 || ucbucaq_teref_3 <= 0)
//            {
//                Console.WriteLine("Terefler menfi ola bilmez!");
//                return 0;
//            }
//            else
//            {
//                int S = 0;
//                int P = 0;
//                P = (ucbucaq_teref_1 + ucbucaq_teref_2 + ucbucaq_teref_3);
//                S = P * Radius_ucbucaq;
//                return S;
//            }

//        }
//        static int sahe_paraleliped(int par_teref_1, int par_teref_2, int par_teref_3)
//        {
//            if (par_teref_1 <= 0 || par_teref_2 <= 0 || par_teref_3 <= 0)
//            {
//                Console.WriteLine("Terefler menfi ola bilmez!");
//                return 0;
//            }
//            else
//            {
//                int S = 0;
//                S = 2 * (par_teref_1 * par_teref_2 * par_teref_3);
//                return S;
//            }
//        }

//    }
//}
#endregion
#region
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("emeliyyati daxil edin!");
//            string emeliyyat = Console.ReadLine();
//            while (emeliyyat != "1" && emeliyyat != "2" && emeliyyat != "3" && emeliyyat != "4")
//            {
//                Console.WriteLine("1-4 araliginda secim edin!");
//                emeliyyat = Console.ReadLine();
//            }
//            switch (emeliyyat)
//            {
//                case "1":
//                    int x = Convert.ToInt32(Console.ReadLine());
//                    int y = Convert.ToInt32(Console.ReadLine());
//                    Console.WriteLine(cem(x, y));
//                    break;
//                case "2":
//                    int c = Convert.ToInt32(Console.ReadLine());
//                    int d = Convert.ToInt32(Console.ReadLine());
//                    Console.WriteLine(ferq(c, d));
//                    break;
//                case "3":
//                    int e = Convert.ToInt32(Console.ReadLine());
//                    int f = Convert.ToInt32(Console.ReadLine());
//                    Console.WriteLine(vurma(e, f));
//                    break;
//                case "4":
//                    int g = Convert.ToInt32(Console.ReadLine());
//                    int h = Convert.ToInt32(Console.ReadLine());
//                    Console.WriteLine(bolme(g, h));
//                    break;

//            }

//        }
//        static int cem(int a, int b)
//        {
//            return a + b;
//        }
//        static int ferq(int a, int b)
//        {
//            return a - b;
//        }
//        static int vurma(int a, int b)
//        {
//            return a * b;
//        }
//        static int bolme(int a, int b)
//        {   
//            if (a==0 && b==0)
//            {
//                return 0;
//            }
//            else
//            {
//                return a % b;
//            }
//        }
//    }
//}
#endregion
# region
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {



//            Console.WriteLine(power(2, 5));
//            Console.WriteLine(power(3));



//        }
//        static int power(int a, int b)
//        {
//            int c = a;

//            for(int i = 1; i <b;)
//            {
//                a = a * c;
//                i++;
//            }
//            return a;

//        }
//        static int power(int c)
//        {
//            int quvvet =c*c;
//            return quvvet;

//        }
//    }
//}
//
#endregion
#region
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine(user("SENAN"));
//            Console.WriteLine(user("SENAN", "BEHEHBUDOV"));
//            Console.WriteLine(user("Senan", "BEHBUDOV", "SEDAI"));
//        }
//        static string user(string name)
//        {

//            return name;
//        }
//        static string user(string name, string surname)
//        {
//            return surname;
//        }
//        static string user(string name, string surname, string f_n)
//        {

//            string c = f_n[0]+"."+name +" "+surname;
//            return c;
//        }
//    }
            
        
        
    
    
    

//}



#endregion