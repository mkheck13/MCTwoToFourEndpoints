using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MCTwoToFourEndpoints.Services
{
    public class TwoQuestionServices
    {
        public string twoQuestion(string userName, int wakeUpTime)
        {
            if(wakeUpTime <= 12)
            {
                return $"Nice to met you {userName}, so you woke up at {wakeUpTime}.";
            }else{
                return "That is not the proper format for the time, try again!";
            }
        }
    }
}