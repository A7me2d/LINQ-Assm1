using System.Text;

namespace LINQ_Assm1
{
    internal class Program
    {
        //static var Print(var X)
        //{
        //    return X;
        //}

        static dynamic Print(dynamic X)
        {
            return X;
        }


        static void Main(string[] args)
        {

            #region Implicity Typed

            #region C# Keyword : var
            //var Data01 = "Ahmed";

            //var X = 12; 

            //var X;

            //var X = null;

            //Data01 = 12;

            //var X = 12;

            //X = "Ahmed";
            //X = new Object();
            #endregion

            #region Implicit dynamic
            //dynamic Data02 = "Ahmed";

            // Console.WriteLine(Data02.GetType().Name);

            // Data02 = 12;

            // Console.WriteLine(Data02.GetType().Name);

            // Data02 = 'a';

            // Console.WriteLine(Data02.GetType().Name);

            // Data02 = 1.9;

            // Console.WriteLine(Data02.GetType().Name);

            //Data02 = new StringBuilder(value: "");

            //dynamic X = null;

            //Console.WriteLine(X);

            #endregion

            #endregion

            #region Extesnion Methods

            //int Number = 12345;

            //var Result =  IntExtension.Reverse(Number);

            // Console.WriteLine(Result);

            //var Result =  Number.Reverse();

            //  Console.WriteLine(Result);

            //var Result = IntExtension.Reverse(Number);

            //Console.WriteLine(Result);

            //Number.Reverse();
            //Console.WriteLine(Number);

            //var X = 1.2 % 10;
            //Console.WriteLine(X);

            #endregion


        }
    }
}
