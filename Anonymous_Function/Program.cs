namespace Anonymous_Function
{
    // Always used with delegate with same signature
    // Return type is not needed in anonymous function
    // return type of anonymous function infered(Assigned) to delegate 
    // Access modifiers are not required
    // they can be used as Event handler
    
    public delegate void MyDelegate(int num);
    class Program
    {
        //public static void MyMethod(int num)
        //{
        //    num += 10;
        //    Console.WriteLine(num);
        //}

        //Anonymous function as a parameter

        public static void MyMethod(MyDelegate del,int num)
        {
            num += 10;
            del.Invoke(num);
        }
        static void Main(string[] args)
        {
            //MyDelegate myDelegate =new MyDelegate(MyMethod);
            //MyDelegate obj = delegate (int num)
            //{
            //    num += 10;
            //    return num;
            //};
            //Console.WriteLine(obj.Invoke(10));
            ////myDelegate.Invoke(10);
            

            // Anonymouse Function passed as parameter
            MyMethod(delegate(int num) { num+= 10; Console.WriteLine(num); },5);
            Console.WriteLine("Hello, World!");
        }
    }
}