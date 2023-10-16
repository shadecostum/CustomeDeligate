namespace CustomeDeligate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<int, int, int> deligatePointer = AddictionFunc;
            Console.WriteLine(deligatePointer(45,67));

            Console.WriteLine("=======================================");
            Predicate<string> deligatePredicate = CheckLength;
            Console.WriteLine(deligatePredicate("akash"));
            Console.WriteLine("=======================================");
            Predicate<int> deligatePredictInt= CheckLengthInt;
            Console.WriteLine(deligatePredictInt(5));
            Console.WriteLine("=======================================");
            Action<int,int,int> deligateAction = NonReturenFunction;
            deligateAction(2,3,4);
            Console.WriteLine("=======================================");
        }

        private static bool CheckLengthInt(int obj)
        {
            return obj > 2;
        }

        private static void NonReturenFunction(int arg1, int arg2, int arg3)
        {
            Console.WriteLine("sum is :"+arg1*arg2*arg3);
        }

        static  int AddictionFunc(int n1,int n2)
        {
            return n1 + n2;
        }
        static bool CheckLength(string sname)
        {
            return sname.Length > 10;
        }

    }
}