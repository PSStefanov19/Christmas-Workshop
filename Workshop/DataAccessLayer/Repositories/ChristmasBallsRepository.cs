using DataAccessLayer.Data;
using DataAccessLayer.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DataAccessLayer.Repositories
{
    public class ChristmasBallsRepository
    {
        public static void InsertBall(ChristmasBall ball)
        {
            using BallzContext context = new();
            context.Add(ball);
            context.SaveChanges();
        }

        public static List<ChristmasBall> GetAllBalls()
        {
            using BallzContext context = new();
            return context.ChristmasBalls.ToList();
        }
    }
}
