using DataAccessLayer.Models;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Services
{
    public class ColourRepeatHandler
    {
        public static void IsRepeatingColour(ChristmasBall ball)
        {
            var balls = DataAccessLayer.Repositories.ChristmasBallsRepository.GetAllBalls();

            if (balls.IsNullOrEmpty())
            {
                ApiCoordinate.CheckCoordinates(ball.X, ball.Y);
                return;
            }

            if (balls.Last().Color == ball.Color)
                throw new Exception();

            ApiCoordinate.CheckCoordinates(ball.X, ball.Y);
        }
    }
}
