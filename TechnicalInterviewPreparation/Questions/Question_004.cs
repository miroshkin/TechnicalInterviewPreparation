using System;
using System.Collections.Generic;
using System.Text;

namespace TechnicalInterviewPreparation.Questions
{
    class Question_004 : IQuestion
    {
        public void GetAnswer()
        {
            int i = 1;
            object obj = i; //copy of i
            ++i;
            Console.WriteLine(i); //2
            Console.WriteLine(obj);//1
            Console.WriteLine((short)obj);//RTE Int32 > Int16
        }
    }
}
