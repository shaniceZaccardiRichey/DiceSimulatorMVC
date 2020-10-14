using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Weeks5and6Project.Models
{
    public class Dice
    {
        public int NumOne { get; set; }
        public int NumTwo { get; set; }

        public Dice()
        {
            Random random = new Random();
            NumOne = random.Next(1, 7);
            NumTwo = random.Next(1, 7);
        }
        public Dice(int numOne, int numTwo)
        {
            Random random = new Random();
            NumOne = numOne;
            NumTwo = numTwo;
        }

    }
}