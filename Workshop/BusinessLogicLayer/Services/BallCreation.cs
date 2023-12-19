using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Services
{
    public class BallCreation
    {
        public static void CreateNewBall()
        {
            ChristmasBall ball = BallsFactory.CreateBall();

            //chain of responsibility goes here(?)

            DataAccessLayer.Repositories.ChristmasBallsRepository.InsertBall(ball);
        }

    }
}
