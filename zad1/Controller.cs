using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad1
{
    public class Controller
    {
        Model currModel = new Model();
        Display currDisplay = new Display();

        public void Start()
        {
            currDisplay.InputInfo();

            currModel.Distance = currDisplay.Distance;
            currModel.DayTime = currDisplay.DayTime;

            currModel.Calculate();

            currDisplay.Price = currModel.Price;

            currDisplay.OutputPrice();
        }
    }
}
