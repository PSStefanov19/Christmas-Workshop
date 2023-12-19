using DataAccessLayer.Models;

namespace BusinessLogicLayer.Services
{
    public class BallsFactory
    {
        public static ChristmasBall CreateBall()
        {
            ChristmasBall ball = new();

            ball = RandomiseBall.RandomizeBall(ball);

            return ball;
        }
    }
}