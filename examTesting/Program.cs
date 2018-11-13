using System;
using System.Threading;


namespace examTesting
{
    class Program
    {

        // 7421 A.1
        enum color:int
        {
            red=-3,
            green,
            blue
        }

        static void Main(string[] args)
        {
            //color.red = 1;
            Console.WriteLine(""+(int)color.red);
            Console.WriteLine("" + (int)color.green);
            Console.WriteLine("" + (int)color.blue);


            // inheritance example a.5
            MyP theP = new MyP(1, 12);
            Console.WriteLine(theP.calculateValue());

            // multi threading a.11
            BeginThread();

            // a.12 exception
            int n = 19;

            NoSmallNumbers(n);

        }

        // a.11
        public static void BeginThread(){
            Thread thread = new Thread(BMethod);

            thread.IsBackground = true; 

            thread.Start();
        }

        public static void BMethod(){
            // no output in console if it is backgorund
            Console.WriteLine("bmethod");
        }


        // a.12
        public static string NoSmallNumbers(int n){
            if (n<100){
                throw new NumberTooSmallException("too small number");
            }else{
                return n.ToString();
            }
        }

        //a.5
        interface IProduct
        {
            int Quantity { get; }
            double Cost { get; }
            double calculateValue();
        }

        public class MyP:IProduct{

            public int Quantity { get; }
            public double Cost { get; }
            public MyP(int q, double c){
                this.Quantity = q;
                Cost = c;
            }
            public double calculateValue(){
                return Quantity * Cost;
            }
        }


    }


}
