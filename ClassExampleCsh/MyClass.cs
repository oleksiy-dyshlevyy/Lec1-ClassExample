using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExampleCsh
{
    class MyClass
    {
        public char FirstLetterOfName;
        private int course;
        public int studentId;

        public int b;

        public MyClass()
        {
            FirstLetterOfName = 'S';
            course = 4;
            studentId = 111;
        }
        public MyClass(char FirstLetterOfName, int course, int studentId)
        {
            this.FirstLetterOfName = FirstLetterOfName;
            this.course = course;
            this.studentId = studentId;
        }
        public MyClass(MyClass myClass)
        {
            FirstLetterOfName = myClass.FirstLetterOfName;
            course = myClass.course;
            studentId = myClass.studentId;
        }
        public void ChangeCourse()
        {
            
           // if (a <=6 )
            //   this.b = 5;
            b = 7;
            course++;
        }

        ~MyClass()
        {
            course = 0;
        }

        public int Course()
        {
            return course;
        }
    }
}
