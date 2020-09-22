using System;
using System.Collections.Generic;
using System.Text;

namespace TechnicalInterviewPreparation.Questions
{
    class Question_005 : IQuestion
    {
        public void GetAnswer()
        {
            var s1 = string.Format("{0}{1}", "abc", "cba");
            var s2 = "abc" + "cba";
            var s3 = "abccba";

            Console.WriteLine(s1 == s2); 
            Console.WriteLine((object)s1 == (object)s2); 
            Console.WriteLine(s2 == s3);
            Console.WriteLine((object)s2 == (object)s3); 

            #region Answer
            //true, false, true, true
                #region Explanation
                    //Last result is a compilator optimization feature
                    //On compilation stage s2 and s3 links to the same string instance
                #endregion
            #endregion
        }
    }
}
