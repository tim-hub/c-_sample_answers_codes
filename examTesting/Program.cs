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


            //a.13 convert binary string to int
            Console.WriteLine(IntFromBinaryString("11110000"));

            //a.14 convert in to binary string
            Console.WriteLine(StringIntToBinaryString(2));

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

        //a.13
        private static int IntFromBinaryString(string s1){
            int c = 0;
            int n = 0;


            for (int i = 128; i > 0; i = i >> 1){
            //for (int i = 128; i > 0; i = i /2){ // these two lines are same
                if(s1[c] == '1'){
                    n += i;
                }
                c++;
            }

            return n;

        }

        //a.14
        private static string StringIntToBinaryString(int n1){
            char[] bits = "00000000".ToCharArray();

            int c = 0;

            for (int i = 128; i > 0; i=i>>1){
                if (n1/i >0){
                    bits[c] = '1';
                    n1 -= i;
                }
                c++;
            }

            return new string(bits);
        }
        
    }


}
