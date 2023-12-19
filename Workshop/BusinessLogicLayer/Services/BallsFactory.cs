using DataAccessLayer.Models;

namespace BusinessLogicLayer.Services
{
    public class BallsFactory
    {
        public static ChristmasBall CreateBall()
        {
            ChristmasBall ball = new();

            ball = RandomiseBall.RandomizeBall(ball);

            Console.WriteLine($"{ball.X}, {ball.Y}, {ball.Color}, {ball.Effects}, {ball.Radius}");

            return ball;
        }
    }
}