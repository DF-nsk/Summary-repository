using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatDemoStudent
{
    delegate void Method(string message);
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            Method method = Show_Message;
            student.StudentGo(7, method);
        }
        static void Show_Message(string message)
        {
            Console.WriteLine(message);
        }
    }
}
