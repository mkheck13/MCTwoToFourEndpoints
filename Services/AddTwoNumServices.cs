using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MCTwoToFourEndpoints.Services
{
    public class AddTwoNumServices
    {
        public string addTwoNumers(int num1,int num2)
        {
            return $"The total of {num1} and {num2} is {num1 + num2}";
        }
    }
}