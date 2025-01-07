using MCTwoToFourEndpoints.Services;
using Microsoft.AspNetCore.Mvc;

namespace MCTwoToFourEndpoints.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GreaterThanController : ControllerBase
    {
        private readonly GreaterThanServices _greaterThanService;

        public GreaterThanController(GreaterThanServices greaterThanServices)
        {
            _greaterThanService = greaterThanServices;
        }

        [HttpGet]
        [Route("Greater/{numOne}/{numTwo}")]
        public string greaterThan(int numOne, int numTwo)
        {
            return _greaterThanService.greaterThan(numOne, numTwo);   
        }
    }
}