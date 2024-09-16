using MyStudentNamespace;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExampleCsh
{
   
    class Program
    {
        static void Main(string[] args)
        {
            

                        MyClass myClass = new MyClass();
            myClass.ChangeCourse();

            MyClass myClass1 = new MyClass('E', 1, 1);
            myClass1.ChangeCourse();

            MyClass myClass2 = new MyClass(myClass1);
            myClass2.ChangeCourse();

            // myClass.course = 10;
            myClass.studentId = 444;
            myClass.Course();

            MyStudent student = new MyStudent();

            
        }
    }
}
