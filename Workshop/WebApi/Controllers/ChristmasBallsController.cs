using BusinessLogicLayer.Services;
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
            BallCreator bc = new();

            bool ballCreated = false;
            
            for (int i = 0; i < 100; i++)
            {
                if (bc.CreateNewBall())
                {
                    ballCreated = true;
                    break;
                }
            }
            
            return $"{{successful = {ballCreated}}}";
        }
    }
}
