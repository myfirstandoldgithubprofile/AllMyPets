using System;
 
public class AllMyPets
{
    static public void Main ()
    {
        Console.Clear();
        Console.WriteLine ("=========================================================================");
        Console.WriteLine ("This little piece of code will show you some information about my pets :)");
        Console.WriteLine ("=========================================================================");
        Console.WriteLine (" ");
        Menu:
        Console.WriteLine ("Choose the option that best fits your curiosity!");
        Console.WriteLine ("[1] Find out how many pets live in my house!");
        Console.WriteLine ("[2] Find out their cool names!");
        Console.WriteLine ("[3] Find out how much food they eat in a month!");
        Console.WriteLine ("[Any other number] Quit.");

        int key = Convert.ToInt32(Console.ReadLine());
        int numOfDogs = 2;
        int numOfCats = 8;
        double amountOfFoodPerCat = 0.110; // kg of food per day
        double amountOfFoodPerDog = 0.235; // kg of food per day

        string[] dogsNames;
        dogsNames = new string[numOfDogs];

        dogsNames[0] = "Little White";
        dogsNames[1] = "Ugly Dog";

        string[] catsNames;
        catsNames = new string[numOfCats];

        catsNames[0] = "Safo";
        catsNames[1] = "Black Hole";
        catsNames[2] = "Quark";
        catsNames[3] = "Higg's Boson";
        catsNames[4] = "Java"; // ok, I do have a cat named Java but I have no cat named C-Sharp yet 
        catsNames[5] = "Derivative";
        catsNames[6] = "Integral";
        catsNames[7] = "Monster";

        	switch (key) { 
        		case 1: 
        		Console.WriteLine("I have "+numOfCats+" cats and "+numOfDogs+" dogs.");
        		Console.WriteLine("========================================");
        		goto Menu;
        	
        		case 2: 
        		for (int i = 0; i < 8; i++) {
        			Console.WriteLine("Cat "+i+"'s name is: "+catsNames[i]+".");
        		} 
        		Console.WriteLine("========================================");
        		for (int j = 0; j < 2; j++) {
        			Console.WriteLine("Dog "+j+"'s name is: "+dogsNames[j]+".");

        		} 
        		Console.WriteLine("========================================");
        		goto Menu;
        		
        		case 3: 
        		double totalCatFood = numOfCats * amountOfFoodPerCat * 30;
        		double totalDogFood = numOfDogs * amountOfFoodPerDog * 30;
        		Console.WriteLine("I have to buy "+totalCatFood+" kg of cat food and "+totalDogFood+" kg of dog food monthly!");
        		Console.WriteLine("========================================");
        		goto Menu;
        		
        		default: 
        		System.Environment.Exit(1);
        		break;
       	 	}
      

    }
}