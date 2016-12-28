using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        //new list that will hold Car objects
        List<Car> myCarList = new List<Car>();
        //new array with the vehicle names i want
        string[] carNames = { "honda", "toyota", "opel", "volvo" };

        //loop trough the vehicle names list 
        foreach (string carName in carNames)
        {
            //create a new car object for every vehicle names and give the name with the carName param in the (carname)
            Car newCar = new Car(carName);
            //add the newly created car to my list of car objects
            myCarList.Add(newCar);
        }

        //loop trough the list of car objects
        foreach (Car car in myCarList)
        {
            //call the PrintMyName() function for every car 
            car.PrintMyName();
        }

    }
}

public class Car
{
    // the variable that will hold the carname
    public string carName { get; set; }

    public Car(string carName)
    {
        //when creating the new car => put the carname in the local carName {get; set;} variable
        this.carName = carName;
    }

    public void PrintMyName()
    {
        // print the saved carName from carname{ get; set;}
        Console.WriteLine(this.carName);
        Console.ReadKey();
    }
}