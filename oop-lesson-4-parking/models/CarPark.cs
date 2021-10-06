using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_lesson_4_parking.models
{
    public class CarPark
    {
        public List<Customer> listOfCustomers = new List<Customer>();

        public CarParkCharge carParkCharge = new CarParkCharge();
        public CarPark()
        {
            //Console.WriteLine("3");
        }
        public override string ToString()
        {
            return "I am the CarPark";
        }
        public void CalculateCharges()
        {
            foreach(Customer customer in listOfCustomers)
            {
                int calculatedCharge = carParkCharge.CalculateCharge(customer.hoursParked);
                Console.WriteLine($"Calculte charge of customer : cost is { calculatedCharge } for customer : { customer.Registration }");
            }
        }
    }
}
