using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Program
{
	class Program
	{
		static void Main(string[] args)
		{
			//Compare and Contast the if single-selection statement and the while repetition statement
			//A single selection statement is one of the three types of selection structures. A single selection statement is composed of one single if statement. A while repetition statment is one of the four types of repition statements 
			//A single selection statement looks like this 
			//"if (x == 0) Console.WriteLine("x is 0");
			//For an if single selection statement it evaluates whether the statement is true. If it is, then it executes the statment below, if the condition is false then the statement is ignored.
			//A while repetition statement is evalued by whether the consitional statment in its parenthesis returns true.
			//In regards to sequence structure, in single selection statements the flow travels from the inital state to the decision symbol - a diamond shape. 
			//in if single selection statements, the work flow will flow down one of two transition depending on the determination of the two guard decisions and then eventually reach the the final state
			//The while repitation statement introduces something different in that it uses the UML merge symbol. Like the if single selection statement, the merge symbol is a triangle shape. It is different than a decision symbol in that it joins two flows of activity into one.  

			int speedLimit = 35;
			int speed = 42;

			if (speed > speedLimit)
			{
				Console.WriteLine("Slow Down");
			}

			bool isTrue = false;
			if (isTrue)
			{
				Console.WriteLine("It is True!");
			}
			else
			{
				Console.WriteLine("It is False!");
			}
			Console.WriteLine("Enter Farenheight: ");
			double fahrenheit = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("Farenheight is: " + fahrenheit);
			double celcius = (fahrenheit - 32d) * 5d / 9d;
			Console.WriteLine(Math.Round(celcius,2));
			Console.WriteLine("Celcius is: " + Math.Round(celcius,2) );

			if (fahrenheit < 40)
			{
				Console.WriteLine("It is cold");
			}
			if (fahrenheit > 90)
			{
				Console.WriteLine("It is hot");
			}

			int counter = 1;
			while (counter <= 10)
			{
				Console.WriteLine(counter);
				counter++;
			}

			int counterB = 60;

			while (counterB >= 20)
			{
				Console.WriteLine(counterB);
				counterB -= 5; 
			}

			int counterC = 10;
			while (counterC <= 20)
			{
				Console.WriteLine(counterC);
				counterC += 2;
			}

			Console.ReadLine();
		}
	}
}
