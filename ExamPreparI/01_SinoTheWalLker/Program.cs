/*

Problem 1. Sino The Walker
Sino is one of those people that lives in SoftUni. He leaves every now and then, but when he leaves he always takes a different route, so he needs to know how much time it will take for him to go home. Your job is to help him with the calculations.
You will receive the time that Sino leaves SoftUni, the steps taken and time for each step in seconds. 
You need to print the exact time that he will arrive at home in the format specified.
Input / Constrains
•	The first line will be the time Sino leaves SoftUni in the following format: HH:mm:ss
•	The second line will contain the number of steps that he needs to walk to his home. This number will be an integer in range [0…2,147,483,647]
•	On the final line you will receive the time in seconds for each step. This number will be an integer in range [0…2,147,483,647]
Output
•	Print the time of arrival at home in the following format:
o	Time Arrival: {hours}:{minutes}:{seconds}
•	If hours, minutes or seconds are a single digit number, add a zero in front.
•	If, for example, hours are equal to zero, print a 00 in their place. The same is true for minutes or seconds.
•	Time of day starts at 00:00:00 and ends at 23:59:59

Input	                Output
12:30:30
90
1	                    Time Arrival: 12:32:00
Input	                Output
23:49:13
5424
2	                    Time Arrival: 02:50:01

*/

using System;

namespace TimeDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            DateTime startTime = DateTime.Parse(input);

            var steps = int.Parse(Console.ReadLine()) % 86400;
            var secondsPerStep = int.Parse(Console.ReadLine()) % 86400;
            var allTimeInSeconds = (steps * secondsPerStep);

            TimeSpan spanTime = TimeSpan.FromSeconds(allTimeInSeconds);

            var result = startTime + spanTime;

            Console.WriteLine("Time Arrival: {0:HH:mm:ss}", result);
        }
    }
}
