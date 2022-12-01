using System;
using System.Security.Cryptography.X509Certificates;



//Problem 211

//namespace MyApplication
//{
// class Program
// {
//    static int MyMethod(int Count)
//{

//    int x = 0;
//    int sum = 0;
//    int mij = 0;
//    int[] Arr = new int[Count];

//    for (int i = 0; i < Count; i++)
//    {
//        Arr[i] = Convert.ToInt32(Console.ReadLine());

//        if (Arr[i] % 2 == 0)
//        {

//            sum = sum + Arr[i];
//            x++;

//        }

//    }
//    mij = sum / x;
//    return mij;

//}

//static void Main(string[] args)
//{
//    Console.WriteLine("zangvaci tareri qanaky aynuhetev zangvaci tarery");

//    int qanak = Convert.ToInt32(Console.ReadLine());

//     Console.WriteLine(" mijin tvabanakann e----  " + MyMethod(qanak));



//}
//  }
//}







// Problem 221

//namespace MyApplication
//{
//    class Program
//    {
//        static int MyMethodSum(int a, int b)
//        {


//            int[] Arr = new int[Math.Abs(b - a) + 1];
//            int sum = 0;
//            for (int i = 0; i < Arr.Length; i++)

//            {
//                if (b > a)
//                {

//                    Arr[i] = b - a;
//                    sum += Arr[i];
//                    a--;
//                }
//                if (b < a)
//                {
//                    Arr[i] = a - b;
//                    sum += Arr[i];
//                    b--;
//                }

//            }
//            return sum;

//        }
//        static void Main(string[] args)
//        {
//            int a = Convert.ToInt32(Console.ReadLine());
//            int b = Convert.ToInt32(Console.ReadLine());
//            Console.WriteLine(MyMethodSum(a, b));
//        }
//    }
//}





// Problems 223


//namespace MyApplication
//{
//    class Program
//    {
//        static int MyMethod(int a, int b)
//        {

//            int count = 0;
//            int[] Arr = new int[Math.Abs(a - b)];
//            for (int i = 0; i < Arr.Length; i++)
//            {
//                count++;

//            }
//            return count;
//        }



//        static void Main(string[] args)
//        {
//            int a = Convert.ToInt32((Console.ReadLine()));
//            int b = Convert.ToInt32((Console.ReadLine()));

//            Console.WriteLine(MyMethod(a, b));
//        }
//    }
//}


//Problem 231


//namespace MyApplication
//{
//    class Program
//    {
//        static int MyMethod(int n)
//        {
//            int[] Arr = new int[n];
//            int sum = 0;

//            for (int i = 0; i < n; i++)
//            {
//                int a = Convert.ToInt32(Console.ReadLine());
//                Arr[i] = a;
//                if(a % 2 == 0)
//                {
//                    sum = sum + Arr[i] * Arr[i];
//                }
//            }
//            return sum;
//        }
//        static void Main(string[] args)
//        {
//            Console.Write("mutqagreq zangvaci tareri qanaky ");

//            int n = Convert.ToInt32(Console.ReadLine());

//            Console.WriteLine("mutqagreq zangvaci tarery");

//            Console.WriteLine(MyMethod(n));

//        }
//    }
//}


//Problem 232

//namespace MyApplication
//{
//    class Program
//    {
//        static int MyMethod(int n)
//        {
//            int[] Arr = new int[n];
//            int count = 0;
//            for (int i = 0; i < n; i++)
//            {
//                Arr[i] = Convert.ToInt32(Console.ReadLine());
//                if (Arr[i] % 2 == 0)
//                {
//                    count++;
//                }

//            }

//            return count;
//        }
//        static void Main(string[] args)
//        {
//            int n = Convert.ToInt32(Console.ReadLine());

//            Console.WriteLine(MyMethod(n));
//        }
//    }
//}


//Problem 251

//namespace MyApplication
//{
//    class program
//    {
//        static int MyMethod( int n)
//        {
//            int max = 0;
//            int[] Arr=new int[n];
//            for (int i = 0; i < n; i++)
//            {
//                int a = Convert.ToInt32(Console.ReadLine());
//                Arr[i] = a;
//                if (max < a )
//                {
//                    max = a;
//                }

//            }
//            return max;
//        }

//        static void Main(string[] args)
//        {
//            int n = Convert.ToInt32(Console.ReadLine());

//            Console.WriteLine(MyMethod(n));
//        }
//    }

//}


//Problem 254


//namespace MyApplication
//{
//    class program
//    {
//        static int MyMethod(int n)
//        {
//            int[] Arr=new int[n];
//            int max = 1;
//            int min = 1;
//            int sum = 1;
//            for (int i = 0; i < n; i++)
//            {
//                int a = Convert.ToInt32(Console.ReadLine());
//                Arr[i] = a;
//                if (max < a)
//                {
//                    max = a;
//                }
//               else if( min > a)
//                {
//                  min = a;
//                }
//            }

//            sum = max * min;
//            return sum;
//        }

//        static void Main(string[] args)
//        {
//            int n = Convert.ToInt32(Console.ReadLine());

//            Console.WriteLine(MyMethod(n));
//        }
//    }
//}


//Problem 255

//namespace MyApplication
//{
//    class Program
//    {


//        static int MyMethod( int n)
//        {
//            int[] Arr=new int[n];
//            int sum = 0;
//            int max = 0;
//            int num = 0;
//            for (int i = 0; i < n; i++)
//            {
//                int a = Convert.ToInt32(Console.ReadLine());
//                if (max < a)
//                {
//                    max = a;
//                    num = i;
//                }
//            }
//            sum = max + num;
//            return sum;

//        }
//        static void Main(string[] args)
//        {
//            int n = Convert.ToInt32(Console.ReadLine());
//           Console.WriteLine(MyMethod( n ));
//        }
//    }
//}


//Problem 261


//namespace MyApplication
//{
//    class Program
//    {
//        static int MyMethod(int a)
//        {
//            int[] arr1=new int[a];
//            int[] arr2=new int[a];
//            int sum1 = 0;
//            int sum2 = 0;
//            for (int i = 0; i < a; i++)
//            {
//                arr1[i] = Convert.ToInt32(Console.ReadLine());
//                arr2[i] = Convert.ToInt32(Console.ReadLine());
//                sum1 = sum1 + arr1[i];
//                sum2 = sum2 + arr2[i];
//            }

//            return sum1/a  + sum2/a;
//        }
//        static void Main(string[] args)
//        {
//            Console.WriteLine("mutqagreq zangvaci chapsy aynuhetev 1in zangvaci tarery heto 2iny");
//           int a = Convert.ToInt32(Console.ReadLine());
//            Console.WriteLine(MyMethod(a));
//        }
//    }
//}


//Problem 263

//namespace MyApplication
//{
//    class Program
//    {
//        static int MyMethod(int n)
//        {
//            int[] arr1= new int[n];
//            int[] arr2= new int[n];
//            int sum1 = 0;
//            int sum2 = 0;
//            int sum = 0; 
//            for (int i = 0; i < n; i++)
//            {
//                arr1[i] = Convert.ToInt32(Console.ReadLine());
//                arr2[i] = Convert.ToInt32(Console.ReadLine());
//                if (arr1[i]>0)
//                {
//                    sum1++;
//                }
//                 if (arr2[i]>0)
//                {
//                    sum2++;
//                }

//            }
//            sum = sum1 + sum2;
//            return sum ;
//        }

//        static void Main(string[] args)
//        {
//           int n = Convert.ToInt32(Console.ReadLine());
//            Console.WriteLine(MyMethod(n));
//        }
//    }
//}


//Problem 265


//namespace MyApplication
//{
//    class Program
//    {
//        static double MyMethod(int n)
//        {
//            int sum = 0;
//            int mult = 1;
//            int[] arr1= new int[n];
//            int[] arr2= new int[n];
//            for (int i = 0; i < n; i++)
//            {
//                arr1[i] = Convert.ToInt32(Console.ReadLine());
//                sum = sum + arr1[i];
//            }
//            for (int i = 0; i < n; i++)

//            {
//                arr2[i] = Convert.ToInt32(Console.ReadLine());
//                mult = mult * arr2[i];
//            }

//            int fin = sum / mult;

//            return fin;
//        }
//        static void Main(string[] args)
//        {
//            int n = Convert.ToInt32(Console.ReadLine());
//            Console.WriteLine(MyMethod(n));
//        }
//    }
//}


//Problem 269


//namespace MyApplication
//{
//    class Program
//    {
//        static int MyMethod(int n,int m)
//        {
//            int[] arr1 = new int[n];
//            int[] arr2 = new int[m];
//            int sum1 = 0;
//            int sum2 = 0;


//            for (int i = 0; i < n; i++)
//            {
//                arr1[i] = Convert.ToInt32(Console.ReadLine());
//                if (i % 2==0)
//                {
//                    sum1 = sum1 + arr1[i];
//                }
//            }

//            for (int i = 0; i < m; i++)
//            {
//                arr2[i] = Convert.ToInt32(Console.ReadLine());
//                if (i % 2 != 0)
//                {
//                    sum1 = sum1 + arr2[i];
//                }
//            }
//           int sum = sum1 + sum2;
//            return sum;

//        }
//        static void Main(string[] args)
//        {
//            int n = Convert.ToInt32(Console.ReadLine());
//            int m = Convert.ToInt32(Console.ReadLine());

//            Console.WriteLine(MyMethod(n,m));
//        }
//    }
//}

//Problem 271

//namespace MyApplication
//{
//    class Program
//    {
//        static int MyMethod( int n) {

//            int a = 0;
//            char[] arr = {'a','a','j','h','k' };
//            for (int i = 0; i < n; i++)
//            {
//                if (arr[i]=='a')
//                {
//                    a++;
//                }
//            }
//            return a;
//                }
//       static void Main(string[] args)
//        {
//               Console.WriteLine(MyMethod(5));

//                }
//    }
//}

//problem 272 

//namespace MyApplication
//{
//    class Program
//    {
//        static bool MyMethod() {

//            char[] arr = { 'a', 's', 'b', 'b' };
//            int n = 2;
//            int a = 0;
//            bool t;

//            for (int i = 0; i < arr.Length; i++)
//            {
//                if (arr[i] == 'b')
//                {
//                    a++;
//                }
//            }
//            if (n / 2 <= a)
//            {
//                t = true;
//            }
//            else
//            {
//                t = false;
//            }

//            return t;
//        }

//        static void Main(string[] args)
//        {
//           Console.WriteLine(MyMethod());
//        }
//    }
//}