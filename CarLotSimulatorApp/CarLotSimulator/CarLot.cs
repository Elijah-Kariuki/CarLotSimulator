﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLotSimulator
{
    public class CarLot
    {
        public CarLot()
        {
            
        }
        public List<Car> InventoryList { get; set; } = new List<Car>();
        public static int numbersOfCars =1;
    }
}
