using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Services
{
    public class RandomiseBall
    {
        internal string[] colors = { "blue-lt", "blue-dk", "red", "gold-lt", "gold-dk" };
        Random random = new Random();

        DataAccessLayer.Models.Point A = new (0.00, 170.30);
        DataAccessLayer.Models.Point B = new (125.80, 170.30);
        DataAccessLayer.Models.Point C = new (62.80, 14.90);

        public decimal GetRandomX()
        {
            double r1 = (double)random.Next(1, 100) / 100;
            double r2 = (double)random.Next(1, 100) / 100;
            return (decimal)((1 - Math.Sqrt(r1)) * A.X + Math.Sqrt(r1) * (1 - r2) * B.X + Math.Sqrt(r1) * r2 * C.X);
        }

        public decimal GetRandomY()
        {
            double r1 = (double)random.Next(1, 100) / 100;
            double r2 = (double)random.Next(1, 100) / 100;
            return (decimal)((1 - Math.Sqrt(r1)) * A.Y + Math.Sqrt(r1) * (1 - r2) * B.Y + Math.Sqrt(r1) * r2 * C.Y);
        }

        public decimal GetRandomRad()
        {

            return (decimal)random.Next(50, 600) / 100;
        }

        public string GetRandomColor()
        {
            return colors.ElementAt(random.Next(0, 4));
        }

        public string GetRandomEffect()
        {
            return "g" + random.Next(1, 3);
        }

        public ChristmasBall RandomizeBall(ChristmasBall ball)
        {
            ball.X = GetRandomX();
            ball.Y = GetRandomY();
            ball.Radius = GetRandomRad();
            ball.Color = GetRandomColor();
            ball.Effects = GetRandomEffect();

            return ball;
        }


        //ball.x = (1 - sqrt(r1)) * A(x) + (sqrt(r1) * (1 - r2)) * B(x) + (sqrt(r1) * r2) * C(x)
        //ball.y = (1 - sqrt(r1)) * A(y) + (sqrt(r1) * (1 - r2)) * B(y) + (sqrt(r1) * r2) * C(y)
    }
}
