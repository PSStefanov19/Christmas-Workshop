using DataAccessLayer.Models;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Services
{
    public class OverlapHandler
    {
        public static decimal Distance(ChristmasBall b1, ChristmasBall b2)
        {
            return (decimal)Math.Sqrt(Math.Pow((double)(b1.X - b2.X), 2.0) + Math.Pow((double)(b1.Y - b2.Y), 2.0));
        }

        public static void IsOverlapping(ChristmasBall ball)
        {
            var balls = DataAccessLayer.Repositories.ChristmasBallsRepository.GetAllBalls();

            decimal maxRadius = 6m;

            decimal padding = 2m;

            var boundBalls = balls.Where(x => Distance(ball, x) < maxRadius + padding + ball.Radius).ToList();

            var overlappingBalls = boundBalls.Where(x => Distance(ball,x) < ball.Radius + x.Radius + padding).ToList();

            if (!overlappingBalls.IsNullOrEmpty())
                throw new Exception();

            ColourRepeatHandler.IsRepeatingColour(ball);
        }
    }
}
