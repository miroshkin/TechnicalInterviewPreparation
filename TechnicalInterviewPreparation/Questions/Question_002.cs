using System;
using System.Collections.Generic;
using System.Text;

namespace TechnicalInterviewPreparation.Questions
{
    class Question_002 : IQuestion
    {
        public void GetAnswer()
        {
            var s = new S();
            using (s)
            {
                Console.WriteLine(s.GetDispose());

            }
            Console.WriteLine(s.GetDispose()); //false false see packing/unpacking feature for structures
        }
    }

    public struct S : IDisposable
    {
        private bool dispose;
        public void Dispose()
        {
            dispose = true;
        }
        public bool GetDispose()
        {
            return dispose;
        }
    }
}
