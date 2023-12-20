using DataAccessLayer.Models;
using DataAccessLayer.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Net;

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

        [HttpPost("post")]
        public string Post()
        {
            BusinessLogicLayer.Services.BallCreation.CreateNewBall();

            return "{ \"succeeded\": true }";
        }
    }
}
