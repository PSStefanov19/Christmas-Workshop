using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    internal class RandomizeBall
    {
        internal string[] colors = { "blue-lt", "blue-dk", "red", "gold-lt", "gold-dk" };
        Random random = new Random();
        public decimal GetRandomX()
        {
            double r1 = (double)random.Next(1, 100) / 100;
            double r2 = (double)random.Next(1, 100) / 100;
            return (decimal)((1 - Math.Sqrt(r1)) * 0.00 + (Math.Sqrt(r1) * (1 - r2)) * 125.80 + (Math.Sqrt(r1) * r2) * 62.80);
        }

        public decimal GetRandomY()
        {
            double r1 = (double)random.Next(1, 100) / 100;
            double r2 = (double)random.Next(1, 100) / 100;
            return (decimal)((1 - Math.Sqrt(r1)) * 170.30 + (Math.Sqrt(r1) * (1 - r2)) * 170.30 + (Math.Sqrt(r1) * r2) * 14.90);
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

        public ChristmasBall RandomiseBall(ChristmasBall ball)
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
