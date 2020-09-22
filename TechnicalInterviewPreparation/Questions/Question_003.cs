using System;
using System.Collections.Generic;
using System.Text;

namespace TechnicalInterviewPreparation.Questions
{
    class Question_003 : IQuestion
    {
        public void GetAnswer()
        {
            List<Action> actions = new List<Action>();
            for (var count = 0; count < 10; count++)
            {
                //int t = count;
                //actions.Add(() => Console.WriteLine(t)); // 0,1,2,3,4,5,6,7,8,9
                actions.Add(() => Console.WriteLine(count));
            }
            foreach (var action in actions)
            {
                action(); // 10, 10, 10, 10, 10, 10, 10, 10, 10, 10
            }
        }
    }
}
