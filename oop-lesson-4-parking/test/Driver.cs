using oop_lesson_4_parking.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_lesson_4_parking.test
{
    public class Driver
    {
        public Driver()
        {
            //Console.WriteLine("1");
        }
        public void CreateObjects()
        {
            CarPark carpark = new CarPark();

            carpark.listOfCustomers.Add(new Customer(2, " "));
            carpark.listOfCustomers.Add(new Customer(3, " "));
            carpark.listOfCustomers.Add(new Customer(4, " "));
            carpark.listOfCustomers.Add(new Customer(5," "));
            carpark.listOfCustomers.Add(new Customer(6, " "));
            carpark.listOfCustomers.Add(new Customer(7, " "));

            carpark.CalculateCharges();

            Customer customer = new Customer(8, " ");
            CarParkCharge carparkcharge = new CarParkCharge();

            Console.WriteLine(carpark.ToString());
            Console.WriteLine(customer.ToString());
            Console.WriteLine(carparkcharge.ToString());
        }
    }
}
