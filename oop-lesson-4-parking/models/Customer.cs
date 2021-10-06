using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_lesson_4_parking.models
{
    public class Customer
    {
        public int hoursParked { get; set; }
        public string Registration { get; set; }
        public Customer(int _hoursParked, string _registration)
        {
            Console.WriteLine("2");
            hoursParked = _hoursParked;
            Registration = _registration;
        }
        public override string ToString()
        {
            return "I am the Customer";
        }
    }
}
