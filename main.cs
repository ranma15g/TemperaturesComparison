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

// We create an array to store the temperatures
int[] tempArray = new int[5];
    
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

        // Record their new input here
        tempInput = Console.ReadLine();

    }

      
    // We now have an integer so we create a scenario
    // to use it as an integer for the sakes of comparison
    if (int.TryParse(tempInput, out int tempTrue) == true)

    { // temperature pass sub-stack begins
      
        // if the integer does not fall within the range
        if (tempTrue < -30 || tempTrue > 130)
  
              {
                  // reprimand them for not following instructions
                  Console.WriteLine("EXCEPTION Temperature " + tempTrue + " is invalid, Please enter a valid temperature between -30 and 130");
      
              }

        else

              {

                  // add the temperature to the array
                  tempArray[i] = tempTrue;

                  // inform the parent while loop we are moving on to the
                  // next temperature in our array of 5
                  i++;

              }

    } // temperature pass sub-stack closed

} // end the temperature collection stack



    

// We initialize a variable to test whether the temperature keeps climbing
bool isAscending = false;

// We initialize a variable to test whether the temperature keeps lowering
bool isDescending = false;




    

/* ******************************************
  Here we compare temperatures highs
********************************************* */

    
// Declare a variable to store the highest temperature in the array
int highestHeat = -31;

// Declare a variable to keep track of how many times the highest 
// temperature has been recorded
int heatCounter = 0;

// Now we loop through the array
foreach(int temp1 in tempArray)

    {

      // if the current temperature is higher than the highest one recorded so far
      if ( temp1 > highestHeat)
        {

        // the current temperature gets recorded as the new highest
        highestHeat = temp1;

        // we tell the program to mark down that it was hotter than last cycle
        heatCounter++;

        }

      // If the heatCounter is equal to the number of temperatures in the array
      if (heatCounter == tempArray.Length)
        {

        // We tell the user that it's getting warmer because each value of the array
        // ascended the element prior to it
        Console.WriteLine("\nIt's getting warmer");

        // We set the isAscending boolean to true
        isAscending = true;
        }


    }



    
/* ******************************************
  Here we compare temperatures lows
********************************************* */

// Declare a variable to store the coldest temperature in the array
int highestCold = 131;

// Declare a variable to keep track of how many times the lowest 
// temperature has been recorded
int coldCounter = 0;

// Now we loop through the array
foreach(int temp2 in tempArray)

    {
  
      // if the current temperature is lower than the lowest one recorded so far
      if ( temp2 < highestCold )
        {
  
        // the current temperature gets recorded as the new highest
        highestCold = temp2;
  
        // we tell the program to mark down that it was hotter than last cycle
        coldCounter++;
          
        }
  
      // If the coldCounter is equal to the number of temperatures in the array
      if (coldCounter == tempArray.Length)
        {
  
        // We tell the user that it's getting warmer because each value of the array
        // ascended the element prior to it
        Console.WriteLine("\nIt's getting colder.");
  
        // We set the isDescending boolean to true
        isDescending = true;
        }
      
      }
  





// If the temperatures in the array do not ascend or descend in sequential order
if (!isAscending && !isDescending)
    {  // Tell the user what type of weather they are dealing with
      Console.WriteLine("\nIt's a mixed bag");
    }
 
// Finally, display the temperatures in the order they were entered, and then display the average of the temperatures.
Console.WriteLine("\n\nOutput 5-Day Temperature[" + tempArray[0] + ", " + tempArray[1] + ", " + tempArray[2] + ", " + tempArray[3] + ", " + tempArray[4] + "]");

// Get the average for all of the temperatures in the array
double tempListAverage = tempArray.Average();

// Print out for the audience what the average for the temperatures is
Console.WriteLine("\n\nAverage Temperature is " + tempListAverage + " degrees");
      
}

}