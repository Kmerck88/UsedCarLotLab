


﻿//USED CAR LOT
//Objectives: Collections, Objects, Inheritance

//Task: Hold information about Car inventory using a collection of Car objects, including a UsedCar subclass.

//What will the application do?
//Display a set of at least 6 cars (at least 3 new and 3 used) along with Add and Quit options
//Let the user select one of the cars.
//Ask if they want to buy the car. If they enter yes, remove it from the list.
//If they want to add another car to the list, get the details, instantiate a new car of the appropriate class (Car class for new cars, or UsedCar), and add it to your data collection.
//Keep looping until they choose to quit.
 
//Build Specifications
//If your instructors tells you to work in pairs, stay with your assigned pair for this lab.
//Create a class named Car(5 points) to store the data about a car. This class should contain:
//Data members for car details
//A string for the make
//A string for the model
//An int for the year
//A decimal for the price
//A no - arguments constructor that sets data members to default values(blanks or your choice)
//A constructor with four arguments matching the order above
//Properties for all data members
//An override to the ToString() method returning a formatted string with the car details.
//Create a subclass of Car named UsedCar(3 points).UsedCar has additional members:
//Data member: A double for mileage.
//Constructor: Takes five arguments(same order as constructor from last lab with the mileage last).
//ToString: overrides Car’s ToString() to include(Used) and the mileage.
//Discuss with your partner how a CarLot class (5 points) could contain a member that stores the information. In what cases would each of these make more sense?
//A member that’s a two-dimensional array of cars
//A member that’s a List<Car>
//A Dictionary <?, Car>
//Any other option?
//However you store information inside the class, this class should include methods to
//Add a car
//List all cars to the console
//Remove a car

//Hints:
//Use the right access modifiers (public/private/protected)!
//Make sure to match the signature of ToString() from Object.
//You can just use \t tab escape characters to line things up, or if you want to get fancier, look up text formatters. 
//Let polymorphism work for you.
//Remember casting.

//Extra Challenges:
//Write a CarLotApp class which instantiates and puts cars in your CarLot class.  It should invoke CarLot methods to let a user:
//List all cars.
//Buy a car, which removes it from the inventory.
//Add a car.
//The main method would then create an instance of CarLotApp and call its methods as needed.
//Think about other methods which might be useful for your CarLot. Implement them and modify your app to take advantage of them. 
//Modify or create a class named Validator with static methods to validate the data in this application. 
//Create an Admin mode which lets the user edit, delete, or replace cars. Move the Add a car feature here.
//Provide search features:
//View all cars of an entered make.
//View all cars of an entered year.
//View all cars of an entered price or less.
//View only used cars or view only new cars.

