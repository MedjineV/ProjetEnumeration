using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetEnumeration
{
    class Program
    {
        static void Main(string[] args)
        {
            Test1();
            //Test3();
        }
        static void Test1()
        {
            Console.WriteLine(CoursePrice.java.ToString());
            Console.WriteLine((int)CoursePrice.java);
        }
        static void Test2()
        {
            Console.WriteLine(CoursePrice.cpp);
            string str = CoursePrice.cpp.ToString();
            int prix = (int)CoursePrice.cpp;
            Console.WriteLine(str + "      " + prix);


        }
        static void Test3()
        {
            CoursePrice x = CoursePrice.java;
            Console.WriteLine(x);



        }




    }
    enum CoursePrice
    {
        java = 100,
        cpp,
        csharp = 200
    }
    enum civilite
    {
        mr,
        mlle,
        mme
    }
}
