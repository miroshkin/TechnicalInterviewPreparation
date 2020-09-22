using System;

namespace TechnicalInterviewPreparation.Questions
{
    public class Question_001 : IQuestion
    {
        public Question_001()
        {
        }

        class A
        {
            public virtual void Foo()
            {
                Console.Write("Class A\n");
            }
        }
        class B : A
        {
            public override void Foo()
            {
                Console.Write("Class B\n");
            }
        }

        public void GetAnswer()
        {
            //B obj1 = new A();
            //obj1.Foo(); //Error

            B obj2 = new B();
            obj2.Foo(); //Class B

            A obj3 = new B();
            obj3.Foo(); //Class B


        }
    }
}
