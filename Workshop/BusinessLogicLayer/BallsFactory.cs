using DataAccessLayer.Models;

namespace BusinessLogicLayer
{
    public class BallsFactory
    {
        ChristmasBall CreateBall()
        {
            ChristmasBall ball = new();

            return ball;      
        }
    }
}