﻿using Microsoft.VisualBasic;
using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car
            CarLot showRoom = new CarLot();
            Car collectorItem = new Car();
           showRoom.InventoryList.Add(collectorItem);
            collectorItem.Year = 1928;
            collectorItem.Make = "Ford";
            collectorItem.Model = "Model T";
            collectorItem.EngineNoise = "BrrrBrrr";
            collectorItem.HonkNoise = "Aroogah";
            collectorItem.IsDriveable = true;
            collectorItem.MakeEngineNoise();
            collectorItem.MakeHonkNoise();




            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car
            Car conceptCar = new Car(2026, "VolksWagen", "Electric Bus", "Silent", "Honk", false);
            showRoom.InventoryList.Add(conceptCar);
            conceptCar.MakeEngineNoise();
            conceptCar.MakeHonkNoise();

            var jeep = new Car() {Year = 2022, Make = "Jeep", Model = "Gladiator", EngineNoise = "Vroom", HonkNoise = "Loud Beep", IsDriveable = true};
            showRoom.InventoryList.Add(jeep);
            jeep.MakeEngineNoise();
            jeep.MakeHonkNoise();
            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console

            
            foreach(var vehicle in showRoom.InventoryList)
            {
                Console.WriteLine("--------------------");
                Console.WriteLine($"Year: {vehicle.Year}, Make: {vehicle.Make}, Model: {vehicle.Model}. Car engine sounds like/is {vehicle.EngineNoise}. The horn sounds like/is {vehicle.HonkNoise}.\n Is the vehicle driverable?  {vehicle.IsDriveable}");
            }
            Console.WriteLine("__________________");
            Console.WriteLine($"The number of cars in the Car Lot is {CarLot.numbersOfCars}");
        }
    }
}
