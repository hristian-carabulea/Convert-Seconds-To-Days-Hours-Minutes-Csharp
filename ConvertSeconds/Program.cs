/*
Seconds = 288970
The given number of seconds is equivalent to "3 days, 8 hours, 16 minutes, 10 seconds"
Output: 3 days, 8 hours, 16 minutes, 10 seconds
Note: Don't use any predefined math functions.
*/
class AssignmentNearestThousand
{
    static void Main()
    {
        int numberSeconds = 288970;  //input
        int numberOfSecondsInADay = 24 * 60 * 60;
        System.Console.Write("Enter a number of seconds: ");
        string number2 = System.Console.ReadLine();

        if (!System.Int32.TryParse(number2, out numberSeconds))
        {
            System.Console.WriteLine("Wrong input");
        }
        else
        { // process the input data

            // get num of days
            int numDays = numberSeconds / numberOfSecondsInADay; 
            // System.Console.WriteLine("Number of days: " + numDays);

            // get num of hours left after the days are taken out of the total hour sum
            int numHoursLeftSeconds = numberSeconds - (numDays * 24 * 60 * 60);
            int numHoursLeft = numHoursLeftSeconds / (60 * 60);
            // System.Console.WriteLine("Number of hours: " + numHoursLeft);

            // get num of minutes left after days and hours are subtracted from the seconds total
            int numMinutesLeftinSeconds = numberSeconds - ( (numDays * 24 * 60 * 60) + (numHoursLeft * 60 * 60) );
            int numMinutesLeft = numMinutesLeftinSeconds / 60;
            // System.Console.WriteLine("Number of minutes: " + numMinutesLeft);

            int numOfSecondsLeft = numberSeconds - ((numDays * 24 * 60 * 60) + (numHoursLeft * 60 * 60) + (numMinutesLeft * 60) );
            //System.Console.WriteLine("Num of seconds left: " + numOfSecondsLeft);

            System.Console.WriteLine(numDays + " days, " + numHoursLeft + " hours, " + numMinutesLeft + " minutes, " + numOfSecondsLeft + " seconds");
            //System.Console.WriteLine("Enter any key to exit program.");
            System.Console.ReadKey();
        }
    }
}
