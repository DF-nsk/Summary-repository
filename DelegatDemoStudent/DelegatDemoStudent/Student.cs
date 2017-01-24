using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace DelegatDemoStudent
{
    class Student
    {
        public void StudentGo(int distance, Method message)
        {
            for (int i=0;i<distance;i++)
            {
                Thread.Sleep(500);
                message(string.Format("Начало движения .... Пройдено {0}", i));

            }
        }
    }
}
