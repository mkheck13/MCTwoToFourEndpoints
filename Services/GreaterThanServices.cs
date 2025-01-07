namespace MCTwoToFourEndpoints.Services
{
    public class GreaterThanServices
    {
        public string greaterThan(int numOne, int numTwo)
        {
            if (numOne > numTwo)
            {
                return $"{numOne} is greater than {numTwo},\n{numTwo} is less than {numOne}";

            }else if(numOne < numTwo)
            {
                return $"{numTwo} is greater than {numOne},\n{numOne} is less than {numTwo}";
            }else{
                return $"{numTwo} is equal to {numOne}";
            }
        } 
    }
}