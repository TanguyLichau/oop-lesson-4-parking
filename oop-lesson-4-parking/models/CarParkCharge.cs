using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_lesson_4_parking.models
{
    public class CarParkCharge
    {
        public int minimumFee { get; set; }
        public int minimumHours { get; set; }
        public CarParkCharge(int _minimumFee = 2, int _minimumHours = 3)
        {
            minimumFee = _minimumFee;
            minimumHours = _minimumHours;
            //Console.WriteLine("4");
        }
        public override string ToString()
        {
            return "I am the CarParkCHarge";
        }
        public int CalculateCharge(int hoursParked)
        {

            int calculatedFee = hoursParked < minimumHours ? minimumFee : hoursParked * minimumFee;
            return calculatedFee ;
        }
    }
}
