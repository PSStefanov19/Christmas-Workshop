using DataAccessLayer.Models;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Services
{
    public class ColourRepeatControl
    {
        public static bool IsRepeatingColour(ChristmasBall ball)
        {
            var balls = DataAccessLayer.Repositories.ChristmasBallsRepository.GetAllBalls();

            if(balls.IsNullOrEmpty()) return false;

            return (balls.Last().Color == ball.Color);
        }
    }
}
