using System;
using System.Collections.Generic;
using System.Linq;

class Program {
  public static void Main (string[] args) {


/* ******************************************
  This is where we collect the temperatures
********************************************* */

    
  // This is where we explain the program to the audience
  Console.WriteLine("Greetings. I need five temperatures to check and see how they commpare average wise. \n\n Please note that these temperatures must be between -30 and 130 degrees Fahrenheit range.\n");

// We declare an input for the user to enter the temperatures
string tempInput;

// We create a list to store temperatures
List<int> tempList= new List<int>();

// int i is going to be used as a way of counting the number of times the user has inputted a temperature.
int i = 0;

    // while we are waiting for five temperatures to be recorded
    while (i < 5) // We start a collection stack to gather data
    {

    // user control
    Console.Write("Please input a temperature: ");

    // We grab a temperature.
    tempInput = Console.ReadLine();

    // While the string input can not be converted into a number
    while (int.TryParse(tempInput, out int tempFail) == false)

    {

        // Reprimand the individual for not following instructions
        Console.WriteLine ("I need an actual temperature: ");

        // Record their input here
        tempInput = Console.ReadLine();

    }


     
    
    
    
    
    
    
    
    // We now have an integer so we create a scenario
    // to use it as an integer for the sakes of comparison
    if (int.TryParse(tempInput, out int tempTrue) == true)

    { // temperature pass stack begins
      
        // if the integer does not fall within the range
        if (tempTrue < -30 || tempTrue > 130)
  
              {
                  // reprimand them for not following instructions
                  Console.WriteLine("EXCEPTION Temperature " + tempTrue + " is invalid, Please enter a valid temperature between -30 and 130");
      
              }

        else

              {
                  // collect the next temperature
                  i++;

                  // We add the sales persons 
                  // initial to the namesList
                  tempList.Add(tempTrue);

                }













                
  
              
      } // temperature pass stack closed






   
      
    }



    // If no temperature is lower than any previous one, display a message Getting warmer



    int highestHeat = -31;

    int heatCounter = 0;

    foreach(int temp1 in tempList)

      {


        if ( temp1 > highestHeat)
          {

          highestHeat = temp1;

          heatCounter++;

          }

        if (heatCounter == tempList.Count)
          {

          Console.WriteLine("\nIt's getting warmer");

          }

      }



    // If every temperature is lower than the previous one, display a message Getting cooler


    
    int highestCold = 131;

    int coldCounter = 0;

    foreach(int temp2 in tempList)

      {


        if ( temp2 < highestCold )
          {

          highestCold = temp2;

          coldCounter++;
            
          }

        if (coldCounter == tempList.Count)
          {

          Console.WriteLine("\nIt's getting colder.");
            
          }

        }





    bool isAscending = true;
    bool isDescending = true;


    for (int o = 1; o < tempList.Count; o++)
    {
      if (tempList[o - 1] > tempList[o])
      {
        isAscending = false; // Not ascending if a larger element comes after a smaller one
      }
      if (tempList[o - 1] < tempList[o])
      {
        isDescending = false; // Not descending if a smaller element comes after a larger one
      }
    }

    if (!isAscending && !isDescending)
    {
      Console.WriteLine("\nIt's a mixed bag");
    }
 
       
        

        
        
    












                    


 



 
      
  
  
  // Finally, display the temperatures in the order they were entered, and then display the average of the temperatures.
    
    Console.WriteLine("\n\nOutput 5-Day Temperature[" + tempList[0] + ", " + tempList[1] + ", " + tempList[2] + ", " + tempList[3] + ", " + tempList[4] + "]");

    double tempListAverage = tempList.Average();

    Console.WriteLine("\n\nAverage Temperature is " + tempListAverage + " degrees");
      
  }
}