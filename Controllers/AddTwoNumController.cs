using MCTwoToFourEndpoints.Services;
using Microsoft.AspNetCore.Mvc;

namespace MCTwoToFourEndpoints.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AddTwoNumController : ControllerBase
    {
        private readonly AddTwoNumServices _addTwoNumServices;

        public AddTwoNumController(AddTwoNumServices addTwoNumServices)
        {
            _addTwoNumServices = addTwoNumServices;
        }


        [HttpGet]
        [Route("Add/{num1}/{num2}")]
        public string addTwoNumbers(int num1, int num2)
        {
            return _addTwoNumServices.addTwoNumers(num1, num2);
        }  
    }
}