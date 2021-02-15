﻿using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetAllByDailyPrice(150, 200))
            {
                Console.WriteLine(car.Description + "'s Daily Price : " + car.DailyPrice.ToString());
            }
        }
    }
}
