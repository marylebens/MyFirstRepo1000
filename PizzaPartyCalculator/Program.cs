//Declare variables
int numberOfGuests;
int slicesPerGuest = 3; //Assume each guest eats three slices
int slicesPerPizza = 8; // Standard pizza has 8 slices

//Prompt user to enter the number of guests
Console.WriteLine("Enter the number of guests: ");

//Call the Parse function to turn the value the user entered into an int
numberOfGuests = int.Parse(Console.ReadLine());

//Calculate the total number of slices needed
int totalSlicesNeeded = numberOfGuests * slicesPerGuest;

//Round up to the nearest integer greater than or equal to the pizza count
//since we can't order a half a pizza from the restaurant
int pizzasNeeded = (int)Math.Ceiling((double)totalSlicesNeeded / slicesPerPizza);

//Display results
Console.WriteLine($"For {numberOfGuests} guests, you'll need {pizzasNeeded} pizzas.");