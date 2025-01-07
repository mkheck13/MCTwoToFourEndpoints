using MCTwoToFourEndpoints.Services;
using Microsoft.AspNetCore.Mvc;

namespace MCTwoToFourEndpoints.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TwoQuestionController : ControllerBase
    {
        private readonly TwoQuestionServices _twoQuestionServices;

        public TwoQuestionController(TwoQuestionServices twoQuestionServices)
        {
            _twoQuestionServices = twoQuestionServices;
        }

        [HttpGet]
        [Route("TwoQuestions/{userName}/{wakeUpTime}")]

        public string twoQuestion(string userName, int wakeUpTime)
        {
            return _twoQuestionServices.twoQuestion(userName,wakeUpTime);
        }
        
    }
}