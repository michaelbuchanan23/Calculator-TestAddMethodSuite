/* 
 * Addition calculator pgoram that we used for testing development
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator {

	 public class Program {

		public static int Add(string nbrs) {
			
			//separate string list numbers with a comma and puts them in the strArray
			var strArray = nbrs.Split(',');
			
			//creating list for our numbers to be put in once they run through the foreach loop below
			List<int> ints = new List<int>();

			//foreach loop to turn string numbers into longs
			foreach (var str in strArray) {
				int i;
				var success = int.TryParse(str,out i); //converts letters and non-numbers to 0 -- also converts decimal #'s such as 1.5 to 0 b/c it can't parse
				if(!success) {
					Console.WriteLine("Some term is not an integer.");
					return -1; //could also throw an exception here
				}
				ints.Add(i); //adds parsed number to the List longs
			}

			//summing up and returning the list array of longs
			var sum = ints.Sum();
			return sum;
		}

		public static int Multiply(string nbrs) {

			//separate string list numbers with a comma and puts them in the strArray
			var strArray = nbrs.Split(',');

			//creating list for our numbers to be put in once they run through the foreach loop below
			List<int> ints = new List<int>();

			//foreach loop to turn string numbers into longs
			foreach (var str in strArray) {
				int i;
				var success = int.TryParse(str, out i); //converts letters and non-numbers to 0 -- also converts decimal #'s such as 1.5 to 0 b/c it can't parse
				if (!success) {
					Console.WriteLine("Some term is not an integer.");
					return -1; //could also throw an exception here
				}
				ints.Add(i); //adds parsed number to the List longs
			}

			//summing up and returning the list array of longs
			var sum = 1;
			foreach(var i in ints) {
				sum *= i;
			}
			return sum;
		}

		static void Main(string[] args) {

			Console.Write("Enter numbers to add: ");
			var response = Console.ReadLine();
			var answer = Add(response);
			Console.WriteLine($"Add({response}) is {answer}");
		}
	}
}
