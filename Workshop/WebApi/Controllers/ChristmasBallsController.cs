using DataAccessLayer.Models;
using DataAccessLayer.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("/")]
    public class ChristmasBallsController : Controller
    {
        [HttpGet("get")]
        public List<ChristmasBall> Get() 
        {
            return ChristmasBallsRepository.GetAllBalls();
        }
    }
}
