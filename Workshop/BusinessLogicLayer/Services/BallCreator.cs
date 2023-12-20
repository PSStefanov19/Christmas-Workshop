using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Services
{
    public class BallCreator
    {
        private List<IBallHandler> _handlers;

        public BallCreator() 
        {
            _handlers = new List<IBallHandler>{
                new OverlapHandler(),
                new ColourRepeatHandler(),
                new ApiCoordinateHandler()
            };
        }

        public bool CreateNewBall()
        {
            ChristmasBall ball = BallsFactory.CreateBall();

            try
            {
                foreach (IBallHandler handler in _handlers) 
                {
                    handler.Execute(ball);
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }

            DataAccessLayer.Repositories.ChristmasBallsRepository.InsertBall(ball);
            return true;
        }

    }
}
