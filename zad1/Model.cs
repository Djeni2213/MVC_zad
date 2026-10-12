using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad1
{
    public class Model
    {
        private int distance;
        public int Distance
        {
            get { return distance; }
            set { distance = value; }
        }

        private string dayTime;
        public string DayTime
        {
            get { return dayTime; }
            set { dayTime = value; }
        }

        public double Price { get; set; }

        public void Calculate()
        {
            double price = 0.0;
            if (distance < 20)
            {
                if (dayTime == "day")
                {
                    price = 0.7 + (Distance * 0.75);
                }
                else if (dayTime == "night")
                {
                    price = 0.7 + (Distance * 0.90);
                }
            }
            else if (distance >= 20 || distance < 100)
            {
                price = price + distance * 0.09;
            }
            else
            {
                price = price + distance * 0.06;
            }

            Price = price;
        }

        public Model()
        {
            
        }

        public Model(int dist, string dt)
        {
            this.Distance = dist;
            this.DayTime = dt;
        }

    }
}
