using System;
using System.Collections.Generic;
using System.Linq;

/*  1.  FizzBuzz
namespace CSharpAssesment
{
    public class Program
    {
        public static void Main()
        {
            string result = FizzBuzz(4);
            Console.WriteLine(result);
        }

        public static string FizzBuzz(int n)
        {
            // TODO - Return "Fizz" if divisible by 3, "Buzz" if divisible by 5, "FizzBizz" if divisible by both, else return number as string.
            string result = "";
            for (int i = 0; i <= n; i++)
            {
                if (i % 3 == 0 && i % 5 == 0) result = "FizzBuzz";
                else if (i % 3 == 0) result = "Fizz";
                else if (i % 5 == 0) result = "Buzz";
                else result = i.ToString();
            }
            return result;
        }
    }
}*/

/*  2.  Reverse a string
namespace CSharpAssesment
{
    public class Program
    {
        public static void Main()
        {
            string result = ReverseString("Sharanabasava");
            Console.WriteLine(result);      // Expected output - avasabanarahS
        }

        public static string ReverseString(string input)
        {
            // TODO - Reverse input string string and return it
            char[] chars = input.ToCharArray();
            Array.Reverse(chars);
            return new string(chars);
        }
    }
}*/

/*  3.  Palindrome Number
namespace CSharpAssesment
{
    public class Program
    {
        public static void Main()
        {
            bool result = IsPalindrome(121);
            Console.WriteLine(result);      // Expected output - True
        }

        public static bool IsPalindrome(int number)
        {
            // TODO - Return true if a number is palindrome else false.
            int Original = number;
			int Reverse = 0;
			while(number > 0)
			{
				int digit = number % 10 ;
				Reverse = Reverse * 10 + digit;
				number = number/10;
			}
            return Original == Reverse;
        }
    }
}*/

/*  4.  Remove the duplicate numbers from list
namespace CSharpAssesment
{
    public class Program
    {
        public static void Main()
        {
            List<int> result = RemoveDuplicates(new List<int> { 1, 2, 2, 3, 4, 4 });
            Console.WriteLine(string.Join(", ", result));      // Expected output - 1, 2, 3, 4
        }

        public static List<int> RemoveDuplicates(List<int> numbers)
        {
            // TODO - Return new list with duplicate removed.
            return numbers.Distinct().ToList();
        }
    }
}*/

/*  5.  Count character in string
namespace CSharpAssesment
{
    public class Program
    {
        public static void Main()
        {
            var frequencies = GetCharFrequencies("SHARANABASAVA");
            foreach(var kv in frequencies)
            {
                Console.WriteLine($"{kv.Key} --> {kv.Value}");
            }
        }

        public static Dictionary<char, int> GetCharFrequencies(string input)
        {
            // TODO - Return dictionary with the frequency of each character in the input string.
            return input.GroupBy(c => c).ToDictionary(g => g.Key, g => g.Count());
        }
    }
}*/

/*  6.  Factorial of number
namespace CSharpAssesment
{
    public class Program
    {
        public static void Main()
        {
            long result = Factorial(5);
            Console.WriteLine(result);  // Expected output = 120;
        }

        public static long Factorial(long number)
        {
            // TODO - Calculate the factorial of a given number.
            int fact = 1;
			if(number <= 1) return 1;
			return number * Factorial(number-1);
        }
    }
}*/

/*  7.  Check if two strings are Anagrams (Check each letters are present in the both string)
namespace CSharpAssesment
{
    public class Program
    {
        public static void Main()
        {
            bool result = AreAnagrams("listen", "silent");
            Console.WriteLine(result);  // Expected output = True;
        }

        public static bool AreAnagrams(string s1, string s2)
        {
            // TODO - Check if s1 and s2 are anagram or not.
			return new string(s1.OrderBy(c => c).ToArray()) == new string(s2.OrderBy(c => c).ToArray());
        }
    }
}*/

/*  8.  Find the second highest number in an array.
namespace CSharpAssesment
{
    public class Program
    {
        public static void Main()
        {
			int[] arr = {1, 3, 5, 4, 2};
			int result = SecondHighest(arr);
            Console.WriteLine(result);  // Expected output = 4;
        }

        public static int SecondHighest(int[] arr)
        {
            // TODO - Find and return second highest element in the array.
			return arr.Distinct().OrderByDescending(n => n).Skip(1).First();
        }
    }
}*/

/*  9.  Count numbers of Owels in a string
namespace CSharpAssesment
{
    public class Program
    {
        public static void Main()
        {
			int result = CountVowels("Hello World");
            Console.WriteLine(result);  // Expected output = 3;
        }

        public static int CountVowels(string input)
        {
            // TODO - Count Owels number in a string.
			return input.Count(c => "aAeEiIoOuU".Contains(c));
        }
    }
}*/

/*  10. Generate fibonacci series
namespace CSharpAssesment
{
    public class Program
    {
        public static void Main()
        {
			var result = Fibonacci(6);
            Console.WriteLine(string.Join(", ", result));  // Expected output = 0, 1, 1, 2, 3, 5;
        }

        public static List<int> Fibonacci(int n)
        {
            // TODO - Generate and return a list of first n Fibinacci numbers.
			var resultList = new List<int> {0, 1};
			
			for(int i=2; i<n; i++)
			{
				resultList.Add(resultList[i - 1] + resultList[i - 2]);
			}
			return resultList;
        }
    }
}*/

/*  11. Find the missing number in an array
namespace CSharpAssesment
{
    public class Program
    {
        public static void Main()
        {
			int[] arr = {1, 2, 3, 4, 6};
			int result = FindMissingNumber(arr, 6);
            Console.WriteLine(result);  // Expected output = 5;
        }

        public static int FindMissingNumber(int[] arr, int n)
        {
            // TODO - Find the missing number in an array containing number from 1 to n.
			int total = n * (n + 1) / 2 ;
			return total - arr.Sum();
        }
    }
}*/

/*  12. First non repeating character in string
namespace CSharpAssesment
{
    public class Program
    {
        public static void Main()
        {
			char result = FirstNonRepetingChar("swiss");
            Console.WriteLine(result);  // Expected output = w;
        }

        public static char FirstNonRepetingChar(string str)
        {
            // TODO - Return first non repeting character in the string
			return str.GroupBy(c => c).First(g => g.Count() == 1).Key;
            // return str.GroupBy(c => c).Where(g => g.Count() == 1).Last().Key     // This is for secong non repeting element
        }
    }
}*/

/*  13. Sum of the digits in a Number
namespace CSharpAssesment
{
    public class Program
    {
        public static void Main()
        {
			int result = SumOfDigits(1234);
            Console.WriteLine(result);  // Expected output = 10;
        }

        public static int SumOfDigits(int num)
        {
            // TODO - Return sum of the digits in a given number.
			int sum = 0;
			while(num > 0)
			{
				sum = sum + (num % 10);
				num = num / 10;
			}
			return sum;
        }
    }
}*/

/*  14. Comman elements in two array
namespace CSharpAssesment
{
    public class Program
    {
        public static void Main()
        {
			var comman = CommanElements(new int[] {1, 2, 3}, new int[] {2, 3, 4});
            Console.WriteLine(string.Join(", ", comman));  // Expected output = 2, 3;
        }

        public static List<int> CommanElements(int[] arr1, int[] arr2)
        {
            // TODO - Return list of the comman elements between two array.
			return arr1.Intersect(arr2).ToList();
        }
    }
}*/

/*  15. Convert string to TitleCase
namespace CSharpAssesment
{
    public class Program
    {
        public static void Main()
        {
			string result = ToTitleCase("hello world");
            Console.WriteLine(result);  // Expected output = Hello World;
        }

        public static string ToTitleCase(string str)
        {
            // TODO - Convert the input string to title case and return it.
			// THIS IS UPPERCASE
			// this is lowercase
			// This Is Title Case
			// camelCase
			// ThisIsPascalCase
			// this-is-kabab-case
			
			return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(str);
        }
    }
}*/

/*  16. Count the words in a string
namespace CSharpAssesment
{
    public class Program
    {
        public static void Main()
        {
			int result = CountWords("This is training session");
            Console.WriteLine(result);  // Expected output = 4;
        }

        public static int CountWords(string input)
        {
            // TODO - Count return the number of words in the sentence.
			// return input.Count(w => w == ' ') + 1;
			return input.Split(new char[] {' ', '\t', '\n', '.'}, StringSplitOptions.RemoveEmptyEntries).Length;
        }
    }
}*/

/*  17. Find the duplicate characters in string
namespace CSharpAssesment
{
    public class Program
    {
        public static void Main()
        {
			var result = FindDuplicate("Programming");
            Console.WriteLine(string.Join(", ", result));  // Expected output = r, g, m;
        }

        public static List<char> FindDuplicate(string input)
        {
            // TODO - Return list of duplicate character in a string.
			return input.GroupBy(c => c).Where(g => g.Count() > 1).Select(g => g.Key).ToList();
        }
    }
}*/

/*  18. Check is Array is sorted or not
namespace CSharpAssesment
{
    public class Program
    {
        public static void Main()
        {
			bool result = IsSorted(new int[] {1, 2, 3, 4, 5, 6});
            Console.WriteLine(result);  // Expected output = True;
        }

        public static bool IsSorted(int[] arr)
        {
            // TODO - Return true is array is sorted in ascending order.
			for(int i=1; i<arr.Length; i++)
			{
				if(arr[i] < arr[i -1])
				{
					return false;
				}
			}
			return true;
        }
    }
}*/

/*  19. Remove the whitespace from the string
namespace CSharpAssesment
{
    public class Program
    {
        public static void Main()
        {
			string result = RemoveWhiteSpaces("H E L L O W O R L D");
            Console.WriteLine(result);  // Expected output = HELLOWORLD;
        }

        public static string RemoveWhiteSpaces(string input)
        {
            // TODO - Return the input string with all white spaces removed.
			return string.Concat(input.Where(c => !char.IsWhiteSpace(c)));
        }
    }
}*/

/*  20. Convert Binary to Decimal
namespace CSharpAssesment
{
    public class Program
    {
        public static void Main()
        {
            int result = BinaryTODeciaml("1010");
            Console.WriteLine(result);  // Expected output = 10;
        }

        public static int BinaryTODeciaml(string binary)
        {
            // TODO - Covert binary string to its decimal integer representation.
            return Convert.ToInt32(binary, 2);
        }
    }
}

namespace CSharpAssesment
{
    public class Program
    {
        public static void Main()
        {
			string result = DecimalToBinary(10);
            Console.WriteLine(result);  // Expected output = 1010;
        }

        public static string DecimalToBinary(int decimalnumber)
        {
            // TODO - Covert decimal integer to its binary string representation.
            return Convert.ToString(decimalnumber, 2);
        }
    }
}*/

/*  21. Handle divide by zero exception
namespace CSharpAssesment
{
    public class Program
    {
        public static void Main()
        {
			string result = SafeDevide(10, 0);
            Console.WriteLine(result);  // Expected output = Can not devide by zero;
        }

        public static string SafeDevide(int a, int b)
        {
            // TODO - Return a reuslt of a/b, and handle DivideByZeroException gracefully
            try
			{
				return ($"result = { a / b}");
			}
			catch(DivideByZeroException)
			{
				return "Can not devide by zero.";	
			}
        }
    }
}*/

//  22. Reverse each word in sentence
/*namespace CSharpAssesment
{
    public class Program
    {
        public static void Main()
        {
			string result = ReverseWord("Hello world this is technical session");
            Console.WriteLine(result);  // Expected output = olleH dlrow siht si lacinhcet noisses;
        }

        public static string ReverseWord(string input)
        {
            // TODO - Reverse each word indidually in the string.
			return string.Join(" ", input.Split(' ').Select(w => new string(w.Reverse().ToArray())));
        }
    }
}*/

/*  23. Find the longest word in sentence
namespace CSharpAssesment
{
    public class Program
    {
        public static void Main()
        {
			string result = LongestWord("Hello world this is technical session");
            Console.WriteLine(result);  // Expected output = technical;
        }

        public static string LongestWord(string input)
        {
            // TODO - Return the longest element from the sentence.
			return input.Split(new char[] {' ', '.', ',', '!'}, StringSplitOptions.RemoveEmptyEntries).OrderByDescending(w => w.Length).First();
        }
    }
}*/

/*  24. Get all even numbers from the list
namespace CSharpAssesment
{
    public class Program
    {
        public static void Main()
        {
			var result = EvenNumbers(new List<int> {1, 2, 3, 4, 5, 6});
            Console.WriteLine(string.Join(", ",result));  // Expected output = 2, 4, 6;
        }

        public static List<int> EvenNumbers(List<int> input)
        {
            // TODO - Return a list of even number from the given list.
			return input.Where(n => n % 2 == 0).ToList();
        }
    }
}*/

/*  25. Find the intersection of two list
namespace CSharpAssesment
{
    public class Program
    {
        public static void Main()
        {
			var result = ListIntersection(new List<int> {1, 2, 3}, new List<int> {2, 3, 4});
            Console.WriteLine(string.Join(", ",result));  // Expected output = 2, 3;
        }

        public static List<int> ListIntersection(List<int> a, List<int> b)
        {
            // TODO - Return common element between two list.
			return a.Intersect(b).ToList();
        }
    }
}*/

/*  26. Find maximum value in list
namespace CSharpAssesment
{
    public class Program
    {
        public static void Main()
        {
			int max = MaxValue(new List<int> {4, 7, 1, 9, 2});
            Console.WriteLine(max);  // Expected output = 9;
        }

        public static int MaxValue(List<int> input)
        {
            // TODO - Return the maximum value from the list.
            // return input.OrderByDescending(n => n).Skip(1).First(); // Second max value.
			return input.Max();
        }
    }
}*/

/*  27. Group string by their length
namespace CSharpAssesment
{
    public class Program
    {
        public static void Main()
        {
			var grouped = GroupByLength(new List<string> {"a", "bb", "ccc", "dd", "ee", "a"});
			foreach(var kv in grouped)
            Console.WriteLine($"{kv.Key} : {string.Join(" ", kv.Value)}");  
        }

        public static Dictionary<int, List<string>> GroupByLength(List<string> input)
        {
            // TODO - Group the string by their length.
			return input.GroupBy(s => s.Length).ToDictionary(g => g.Key, g => g.ToList());
        }
    }
}*/

/*  28. Check if a string is Numeric or Not
namespace CSharpAssesment
{
    public class Program
    {
        public static void Main()
        {
			bool result = IsNumeric("1234");
            Console.WriteLine(result);  //	Expected output = True
        }

        public static bool IsNumeric(string input)
        {
            // TODO - Group the string by their length.
			return double.TryParse(input, out _);
        }
    }
}*/

/*  29. Concatinate list of string with delimiter
namespace CSharpAssesment
{
    public class Program
    {
        public static void Main()
        {
			var input = new List<string> {"apple", "babana", "cherry"};
			string result = JoinWithComma(input);
            Console.WriteLine(result);  //	Expected output = apple, banana, cherry
        }

        public static string JoinWithComma(List<string> items)
        {
            // TODO - Group the string by their length.
			return string.Join(", ", items);
        }
    }
}*/

/*  30. Use delegate to perform arthimatic operation
namespace CSharpAssesment
{
    public class Program
    {
		public delegate int Operation(int x, int y);
        public static void Main(string[] args)
        {
			Operation add = (x, y) => x + y;
			int result = ExecuteOperation(add, 5, 3);
			Console.WriteLine(result);		//	Expected output : 8
        }

        public static int ExecuteOperation(Operation op, int a, int b)
        {
            // TODO - Use delegate to execute arithmatic operation.
			return op.Invoke(a, b);
        }
    }
}*/

/*  31. Declare and Invoke an Event
namespace CSharpAssesment
{
    public class Program
    {
        public static void Main(string[] args)
        {
			Notifier notifier = new Notifier();
			notifier.OnNotify += () => Console.WriteLine("Event triggered");
			notifier.Notify();		// Expected output = Event triggered.
        }

        public class Notifier
		{
			public event Action OnNotify;
			public void Notify()
			{
				// ToDo : Invoke the event if subscribers exists
				OnNotify?.Invoke();
			}
		}
    }
}*/

/*  32. Capitalize first letter of each word.
namespace CSharpAssesment
{
    public class Program
    {
        public static void Main(string[] args)
        {
			string result = CapitalizeWords("Hello world from sharan");
			Console.WriteLine(result);		//	Expected output : Hello World From Sharan
        }

        public static string CapitalizeWords(string input)
		{
			// ToDo : Capitalize the first letter of the each word in the input string
			return string.Join(" ", input.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries).Select(w => char.ToUpper(w[0]) + w.Substring(1)));
		}
    }
}*/

/*  33. Find all Indices of character in a string
namespace CSharpAssesment
{
    public class Program
    {
        public static void Main(string[] args)
        {
			var indices = FindCharIndices("Hello world", 'l');
			Console.WriteLine(string.Join(", ", indices));		//	Expected output : 2, 3, 9
        }

        public static List<int> FindCharIndices(string input, char target)
		{
			// ToDo : Retuen all the indices where the character appears in the string.
			return input.Select((c, i) => new {c, i}).Where(x => x.c == target).Select(x => x.i).ToList();
		}
    }
}*/

/*  34. Sort a list of string alphabatically
namespace CSharpAssesment
{
    public class Program
    {
        public static void Main(string[] args)
        {
			var sorted = SortString(new List<string> {"Banana", "Apple", "Cherry"});
			Console.WriteLine(string.Join(", ", sorted));		//	Expected output : Apple, Banana, Cherry
        }

        public static List<string> SortString(List<string> words)
		{
			// ToDo : Retuen the list of strings sorted in alphabatical order.
			return words.OrderBy(w => w).ToList();
		}
    }
}*/

/*  35. Convert list of Integers to comma saparated string
namespace CSharpAssesment
{
    public class Program
    {
        public static void Main(string[] args)
        {
			string result = ListToCsv(new List<int> {1, 2, 3, 4});
			Console.WriteLine(result);		//	Expected output : 1,2,3,4
        }

        public static string ListToCsv(List<int> numbers)
		{
			// ToDo : Convert the list of integer into a comma-saparated string.
			return string.Join(", ", numbers);
		}
    }
}*/

/*  36. Remove all Null or Empty list from a string
namespace CSharpAssesment
{
    public class Program
    {
        public static void Main(string[] args)
        {
			var cleaned = CleanList(new List<string> {"apple", "", null, "banana", " "});
			Console.WriteLine(string.Join(", ", cleaned));		//	Expected output : apple, banana
        }

        public static List<string> CleanList(List<string> input)
		{
			// ToDo : Remove null, empty and whitespaces only string from the list
			return input.Where(s => !string.IsNullOrWhiteSpace(s)).ToList();
		}
    }
}*/

/*  37. Merge two sorted array
namespace CSharpAssesment
{
    public class Program
    {
        public static void Main(string[] args)
        {
			int[] merged = MergeSortedArray(new int[] {1, 3, 5}, new int[] {2, 4, 6});
			Console.WriteLine(string.Join(", ", merged));		//	Expected output : 1, 2, 3, 4, 5, 6
        }

        public static int[] MergeSortedArray(int[] a, int[] b)
		{
			// ToDo : RMerge two sorted array into a single sorted array
			return a.Union(b).OrderBy(n => n).ToArray();
		}
    }
}*/

/*  38. Find all prime numbers upto N
namespace CSharpAssesment
{
    public class Program
    {
        public static void Main(string[] args)
        {
			var primes = GetPrime(10);
			Console.WriteLine(string.Join(", ", primes));		//	Expected output : 2, 3, 5, 7
        }

        public static List<int> GetPrime(int n)
		{
			// ToDo : Return list of all prime numbers less then or equal to n
			return Enumerable.Range(2, n-1).Where(x => Enumerable.Range(2, (int)Math.Sqrt(x) - 1).All(i => x % i != 0)).ToList();
		}
    }
}*/

/*

Console.Write("Enter N: ");
int n = int.Parse(Console.ReadLine());

for (int number = 2; number <= n; number++)
{
    bool isPrime = true;

    for (int i = 2; i <= number / 2; i++)
    {
        if (number % i == 0)
        {
            isPrime = false;
            break;
        }
    }

    if (isPrime)
        Console.WriteLine(number);
}

*/

/*  39. Convert a string to an Integer safely
namespace CSharpAssesment
{
    public class Program
    {
        public static void Main(string[] args)
        {
			int result = SafeParseInt("123abc");
			Console.WriteLine(result);		//	Expected output : 0
        }

        public static int SafeParseInt(string input)
		{
			// ToDo : Safely convert string to integer. return 0 if conversion fails.
			return int.TryParse(input, out int result) ? result : 0 ;
		}
    }
}*/

/*  40. Get distinct characters in a string
namespace CSharpAssesment
{
    public class Program
    {
        public static void Main(string[] args)
        {
			var chars = DistinctCharacter("Hello");
			Console.WriteLine(string.Join(", ", chars));		//	Expected output : H, e, l, o
        }

        public static List<char> DistinctCharacter(string input)
		{
			// ToDo : Return a list of distinct characters from the string.
			return input.Distinct().ToList();
		}
    }
}*/

/*  41. Convert a list of string into Uppercase.
namespace CSharpAssesment
{
    public class Program
    {
        public static void Main(string[] args)
        {
			var result = ConverToUpper(new List<string> {"apple", "banana"});
			Console.WriteLine(string.Join(", ", result));		//	Expected output : APPLE, BANANA
        }

        public static List<string> ConverToUpper(List<string> input)
		{
			// ToDo : Convert list of string to Upper case list string.
			return input.Select(w => w.ToUpper()).ToList();
		}
    }
}*/

/*  42. Check if two list are equal.
namespace CSharpAssesment
{
    public class Program
    {
        public static void Main(string[] args)
        {
			bool result = AreListEqual(new List<int> {1, 2, 3}, new List<int> {1, 2, 3});
			Console.WriteLine(result);		//	Expected output : True
        }

        public static bool AreListEqual<T>(List<T> list1, List<T> list2)
		{
			// ToDo : Convert list of string to Upper case list string.
			return list1.SequenceEqual(list2);
		}
    }
}*/

/*  43. Swap two numbers without a Temp variable.
namespace CSharpAssesment
{
    public class Program
    {
        public static void Main(string[] args)
        {
			int a = 5, b = 10;
			Swap(ref a, ref b);
			Console.WriteLine($"a = {a}, b = {b}");		//	Expected output : a = 10, b = 5
        }

        public static void Swap(ref int a, ref int b)
		{
			// ToDo : Swap the values of a and b without using third variable.
			a = a + b;
			b = a - b;
			a = a - b;
		}
    }
}*/

/*  44. Flaten a list of list
namespace CSharpAssesment
{
    public class Program
    {
        public static void Main(string[] args)
        {
			var result = Flatten(new List<List<int>> {new List<int> {1, 2}, new List<int> {3, 4, 5}});
			Console.WriteLine(string.Join(", ", result));	// Expected output : 1, 2, 3, 4, 5
        }

        public static List<int> Flatten(List<List<int>> nestedlist)
		{
			// ToDo : Flatten the list of list into single list.
			return nestedlist.SelectMany(x => x).ToList();
		}
    }
}*/

/*  45. Find the duplicate in a array
namespace CSharpAssesment
{
    public class Program
    {
        public static void Main(string[] args)
        {
			var duplicates = FindDuplicateNumbers(new int[] {1, 2, 3, 3, 2, 4});
			Console.WriteLine(string.Join(", ", duplicates));	// Expected output : 12, 3
        }

        public static List<int> FindDuplicateNumbers(int[] numbers)
		{
			// ToDo : Return a list of numbers that appears more than once.
			return numbers.GroupBy(n => n).Where(g => g.Count() > 1).Select(g => g.Key).ToList();
		}
    }
}*/

/*  46. Calculate average of list
namespace CSharpAssesment
{
    public class Program
    {
        public static void Main(string[] args)
        {
			double result = GetAverage(new List<int> {4, 6, 8});
			Console.WriteLine(result);	// Expected output : 6
        }

        public static double GetAverage(List<int> numbers)
		{
			// ToDo : Return the average of the list of integer.
			return numbers.Average();
		}
    }
}*/

/*  47. Check if a string contains only Digits
namespace CSharpAssesment
{
    public class Program
    {
        public static void Main(string[] args)
        {
			bool result = IsOnlyDigits("12345");
			Console.WriteLine(result);	// Expected output : True
        }

        public static bool IsOnlyDigits(string input)
		{
			// ToDo : Return true if input contains onl digits.
			return input.All(char.IsDigit);
		}
    }
}*/

/*  48. Count words starting with vowels.
namespace CSharpAssesment
{
    public class Program
    {
        public static void Main(string[] args)
        {
			int result = CountWordsStartingWithVowel("Apple is awesome and orange");
			Console.WriteLine(result);	// Expected output : 5
        }

        public static int CountWordsStartingWithVowel(string input)
		{
			// ToDo : Count how many words int he sentence start with a vowel.
			return input.Split(' ').Count(w => "aAeEiIoOuU".Contains(w[0]));
		}
    }
}*/

/*  49. Create dictionary from two list
namespace CSharpAssesment
{
    public class Program
    {
        public static void Main(string[] args)
        {
			var dict = CreateDictionary(new List<string> {"a", "b"}, new List<int> {1, 2});
			foreach(var kv in dict)
			Console.WriteLine($"{kv.Key} : {kv.Value}");	// Expected output : a : 1, b : 2
        }

        public static Dictionary<string, int> CreateDictionary(List<string> keys, List<int> values)
		{
			// ToDo : Combine keys and values into dictionary
			return keys.Zip(values, (k, v) => new {k, v}).ToDictionary(x => x.k, x => x.v);
		}
    }
}*/

/*  50. Trigger a delegate chain

namespace CSharpAssesment
{
    public class Program
    {
		public delegate void NotifyHandler ();
        public static void Main(string[] args)
        {
			NotifyHandler handler = () => Console.WriteLine("First");
			handler += () => Console.WriteLine("Second");
			
			ExecuteDelegates(handler);	//	Expected Output : First\nSecond
        }

        public static void ExecuteDelegates(NotifyHandler handler)
		{
			// ToDo : Tigger all methods in the delegate chain
			handler();
		}
    }
}*/


-------------------------------------------------------------------------------------------------
Interview Topics
-------------------------------------------------------------------------------------------------

using System;
using System.Data.SqlTypes;
using System.Diagnostics.CodeAnalysis;
using System.Security.Cryptography.X509Certificates;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Net.Http.Headers;
using System.Net.Cache;

// namespace StructureOfCode
// {
//     public class Employee
//     {
//         public Employee()       // Constructor.
//         {

//         }

//         private int experience;     // Feild

//         public int Experience       // Property
//         {
//             get{return experience;}      // Read
//             set{experience = value;}     // 
//         }

//         // public int Experience { get; set; }      // another way to define property.

//         public void CalculateSalary()       // Method
//         {
//             int salary = Experience * 30000;
//             Console.WriteLine("Employee salary is : {0}", salary);
//         }

//         public static void Main(string[] args)      //  Main method
//         {
//             Employee obj = new Employee();      // Object
//             obj.Experience = 3;
//             obj.CalculateSalary();
//             Console.ReadLine();
//         }
//     }
// }

/*namespace AbstractClass
{
    public class Program
    {
        public static void Main(String[] args)
        {
            Circle obj = new Circle(5);
            obj.Display();

            Console.WriteLine("Area of the circle is: " +obj.GetArea());
        }
    }

    public abstract class Shape
    {
        public abstract double GetArea();
        public void Display()
        {
            Console.WriteLine("This is shape");
        }
    }

    public class Circle : Shape
    {
        private double radius;
        public Circle(double radius)
        {
            // _radius = radius;
            this.radius = radius;
        }

        public override double GetArea()
        {
            return 3.14 * radius * radius;
        }
    }
}*/

// namespace Inheritance
// {
//     public class Employee       // Base/Parent/Super class
//     {
//         public int Experience { get; set; }

//         public void pEmpSalary()
//         {
//             int salary = Experience * 30000;
//             Console.WriteLine("Employee salary is : {0}", salary);
//         }

//         public void cEmpSalary()
//         {
//             int salary = Experience * 10000;
//             Console.WriteLine("Employee salary is : {0}", salary);
//         }

//     }

//     public class PermanentEmployee:Employee     // Derived/Child/Sub Class 
//     {

//     }

//     public class ContractEmployee:Employee     // Derived/Child/Sub Class 
//     {

//     }

//     public class Enterance
//     {
//         public static void Main(String[] args)
//         {
//             PermanentEmployee pEMP = new PermanentEmployee();
//             pEMP.Experience = 3;
//             pEMP.pEmpSalary();

//             ContractEmployee cEMP = new ContractEmployee();
//             cEMP.Experience = 3;
//             cEMP.cEmpSalary();

//             Console.ReadKey();
//         }
//     }

// }

/*namespace Polymorphism
{
    public class Polymorphism
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
        public string Add(string str1, string str2)
        {
            return str1 + str2;
        }

        public static void Main(String[] args)
        {
            Polymorphism poly = new Polymorphism();
            int i = poly.Add(50, 50);
            string str3 = poly.Add("Sharan", "basava");

            System.Console.WriteLine(i + " " + str3);
        }
    }
}*/

/*namespace Overriding
{
    public class BaseClass
    {
        public virtual void greeting()
        {
            System.Console.WriteLine("BaseClass greeting");
        }
    }

    public class SubClass : BaseClass
    {
        public override void greeting()
        {
            System.Console.WriteLine("SubClass greeting");
        }
    }

    public class Mainmethod
    {
        public static void Main(String[] args)
        {
            BaseClass obj1 = new BaseClass();   // BaseClass will call
            obj1.greeting();

            SubClass obj2 = new SubClass();     // SubClass will call
            obj2.greeting();

            BaseClass obj3 = new SubClass();        // SubClass will call
            obj3.greeting();

            Console.ReadKey();
        }
    }
}*/

/*namespace Overriding
{
    public class Technology
    {
        public virtual void TechnicalSkill()
        {
            System.Console.WriteLine("Coding");
        }
        public virtual void CommunicationSkills()
        {
            Console.WriteLine("English");
        }
    }

    public class Java : Technology
    {

    }

    public class DotNet : Technology
    {
        
    }
    public class Testing : Technology
    {
        public override void TechnicalSkill()
        {
            Console.WriteLine("Testing");
        }
    }

    public class Mainmethod
    {
        public static void Main(String[] args)
        {
            Testing test = new Testing();
            test.TechnicalSkill();      // Testing
            test.CommunicationSkills();     // English
            Console.ReadKey();
        }
    }
}*/


/*namespace GenericsMethod  // Generics allows us to make class, methods, interfaces Type Indipendent/Tpe safe.
{
    public class Program
    {
        public static void Main(String[] args)
        {
            bool equal = Calculator.AreEqual<int>(4, 4);
            bool strequal = Calculator.AreEqual<string>("sharan", "Guru");
            Console.WriteLine(equal + " " + strequal);
        }
    }

    public class Calculator
    {
        public static bool AreEqual<T>(T value1, T value2)
        {
            return value1.Equals(value2);
        }
    }
}*/


/*namespace GenericsClass  // Generics allows us to make class, methods, interfaces Type Indipendent/Tpe safe.
{
    public class Program
    {
        public static void Main(String[] args)
        {
            bool equal = Calculator<int>.AreEqual(4, 4);
            bool strequal = Calculator<string>.AreEqual("sharan", "Guru");
            Console.WriteLine(equal + " " + strequal);
        }
    }

    public class Calculator<T>
    {
        public static bool AreEqual(T value1, T value2)
        {
            return value1.Equals(value2);
        }
    }
}*/

/*namespace ReverseString
{
    public class Program
    {
        public static void Main (String[] args)
        {
            // Console.WriteLine("Enter a String : ");
            // string OS = Console.ReadLine();
            // string RS = " ";
            // for(int i=OS.Length-1; i>=0; i--)
            // {
            //     RS = RS + OS[i];
            // }
            // Console.WriteLine($"Reversed string is {RS}");

            // Reverse string by using Foreach loop
            // foreach(char c in OS)
            // {
            //     RS = RS + c;
            // }


            string mainString = "Hello, welcome to the world of C#";
            string searchString = "welcome";
            int index = mainString.IndexOf(searchString);
            if (index != -1)
            {
                string subString = mainString.Substring(index, searchString.Length);
                Console.WriteLine(subString); // Output: "welcome"
            }
            else
            {
                Console.WriteLine("Substring not found");
            }
        } 
    }
}*/

/*namespace ReverseSentence
{
    public class Program
{
	public static void Main()
	{
		// string sentence = "I am in interview panel";
		// string[] words = sentence.Split(' ');
		// Array.Reverse(words);
		// string Revsentence = string.Join(" ", words);
		// Console.WriteLine(Revsentence);
		
		string OriginalSentence = "I am in interview panel";
		string ReveseSentence = string.Empty;
		string word = string.Empty;
		
		for(int i=OriginalSentence.Length -1 ; i >= 0 ; i--)
		{
			if(OriginalSentence[i] == ' ')
			{
				ReveseSentence =  ReveseSentence + word + " ";
				word = "";				
			}
			else
			{
				word = OriginalSentence[i] + word;
			}
		}
		ReveseSentence = ReveseSentence + word;
		Console.WriteLine(ReveseSentence);
	}
}


public class Program
{
    public static void Main()
    {
        string original = "I am in interview panel";
        string reversed = string.Join(" ",
            original.Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Reverse());

        Console.WriteLine(reversed); // panel interview in am I
    }
}

}*/

/*namespace interfaces
{
    interface IAnimal
    {
        void MakeSound();
    }
    public class Dog : IAnimal
    {
        public void MakeSound()
        {
            Console.WriteLine("Bark");
        }
    }
    public class Cat : IAnimal
    {
        public void MakeSound()
        {
            Console.WriteLine("Meow");
        }
    }

    public class Program
    {
        public static void Main()
        {
            IAnimal cat = new Cat();
            IAnimal dog = new Dog();
        
            dog.MakeSound();
            cat.MakeSound();
        }
    }
}*/

/*namespace Sorting
{
    public class Arrays
    {
        public static void Main()
	    {
            int[] array = {5, 1, 8, 44, 86, 123, 55};
            for(int i = 0; i <= array.Length - 1; i++)
            {
                for(int j=0; j<=i; j++)
                {
                    if(array[i] < array[j])
                    {
                        int temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
            foreach(var item in array)
            {
                Console.Write(item + " ");
            }
	    }
    }
}*/

/*namespace ReverseArrayElements
{
    public class Program
    {
        public static void Main(String[] args)
        {
            int[] Array = {5, 1, 0, 3, 8, 2, 4, 6};
            Console.Write("Given array elements are: ");
            for(int i=0; i<Array.Length; i++)
            {
                Console.Write(Array[i]+" ");
            }
            
            ReverseArray(Array, 0, (Array.Length-1));

            Console.Write("\nGiven array elements after reverse are: ");
            for(int i=0; i<Array.Length; i++)
            {
                Console.Write(Array[i] + " ");
            }
        }

        public static void ReverseArray(int[] Array, int SI, int EI)
        {
            while(SI<EI)
            {
                int temp = Array[SI];
                Array[SI] = Array[EI];
                Array[EI] = temp;

                SI++;
                EI--;
            } 
        }
    }
}*/

/*namespace PrimeNumber
{
    public class Program
    {
        public static void Main()
        {
            Console.Write("Enter a number : ");
            int number = int.Parse(Console.ReadLine());
            bool isPrime = true;
            if(number<=1)
            {
                isPrime = false;
            }
            else
            {
                for(int i=2; i<=number/2; i++)
                {
                    if(number%i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
            }
            
            if(isPrime)
            {
                Console.WriteLine("Given number is Prime number");
            }
            else{
                Console.WriteLine("Not a prime number");
            }
        }
    }    
}*/

/*namespace FactorialNumber
{
    class Program
    {
        public static void Main(String[] args)
        {
            Console.Write("Enter number : ");
            int number;
            bool isValid = int.TryParse((Console.ReadLine()), out number);
            if(isValid)
            {
                int factorial = 1;
                for(int i=1; i<=number; i++)
                {
                    factorial = factorial * i;
                }
                Console.WriteLine($"Factirial of given number is : {factorial}");
            }
            else{
                Console.WriteLine("Enter a valid number");
            }
        }
    }
}*/

/*namespace PalindromeNumber
{
    class Program
    {
    public static void Main(String[] args)
    {
        Console.Write("Enter a number : ");
        int number = Convert.ToInt32(Console.ReadLine());
        IsPalindrome(number);
        if(IsPalindrome(number)){
            Console.WriteLine("Given number is Palindrome");
        }else{
            Console.WriteLine("Given number is not a Palindrome");
        }
    }
    public static bool IsPalindrome(int number)
    {
        int ON = number;
        int RN = 0;
        while(number>0)
        {
            int digit = number%10;
            RN = RN * 10 + digit;
            number = number/10;
        }
        return ON == RN;
    }
    }
}*/

/*namespace Fibonacci
{
    public class Program
    {
        public static void Main()
        {
            Fibbinacci(10);
        }
        public static void Fibbinacci(int n)
        {
            int FirstNum = 0, SecondNum = 1, NextNum;
            for(int i = 2; i <= n ; i++)
            {
                Console.Write(FirstNum + " ");
                NextNum = FirstNum + SecondNum;
                FirstNum = SecondNum;
                SecondNum = NextNum;
            }		
        }
    }
}*/

/*namespace AmstrongNumber
{
    class Program
    {
        public static void Main(String[] args)
        {
            int i=0;
            int DigitCount=0;
            int sum=0;
            int[] DigitArray = new int[10];

            Console.Write("Enter a number to be check : ");
            int number = int.Parse(Console.ReadLine());

            int tempNum = number;

            while(number>0)
            {
                DigitArray[i++] = number%10;
                number = number/10;
                DigitCount++;
            }

            for(i=0; i<DigitCount; i++)
            {
                sum = sum + Convert.ToInt32(Math.Pow(DigitArray[i], DigitCount));
            }

            if(sum == tempNum)
            {
                Console.WriteLine("Given number is Amstrong number");
            }
            else
            {
                Console.WriteLine("Given number is not amstrong number");
            }
            
        }
    }
}*/


/*namespace RemoveDuplicateCharString
{
    class Program
    {
        public static void Main(String[] args)
        {
            Console.Write("Enter a String : ");
            string GS = Console.ReadLine();

            string FS = RemoveDuplicate(GS);
            Console.WriteLine("The string after removing duplicate character is : " +FS);
        }
        public static string RemoveDuplicate(string GS)
        {
            string FS= string.Empty;
            for(int i=0; i<GS.Length; i++)
            {   
                bool isDuplicate = false;
                for(int j=0; j<FS.Length; j++)
                {
                    if(GS[i] == FS[j])
                    {
                        isDuplicate = true;
                        break;
                    }
                }
                if(!isDuplicate)
                {
                    FS = FS + GS[i];
                }
            }
            return FS;
        }
    }
}*/

/*namespace DuplicateCharString
{
    class Program
    {
        public static void Main(String[ ] args)
        {
            Console.Write("Enter a String to remove duplicates character: ");
            string str = Console.ReadLine();

            string final = string.Empty;

            for(int i=0; i<str.Length; i++)
            {
                if(!final.Contains(str[i]))
                {
                    final += str[i];
                }
            }
            Console.WriteLine(final);
        }
    }
}*/

/*namespace ExtensionMethod
{
    public class Program
    {
        public static void Main(String[] args)
        {
            string test = "GOOGLE IS A COMPANY";
            string left = test.Substring(3,5);
            string right = test.RightSubString(3);
            Console.WriteLine(left + " " + right);
            Console.ReadLine();
        }
    }
    public static class StringExtension
    {
        public static string RightSubString(this String s, int count)
        {
            return s.Substring(s.Length-count, count);
        }
    }
}*/

/*namespace RemoveDuplicateFromArray;
class Program
{
    public static void Main(string[] args)
    {
        int[] array = { 1, 2, 3, 4, 2, 5, 1, 6, 3 };
        int[] result = RemoveDuplicates(array);

        Console.WriteLine("Array after removing duplicates:");
        foreach (int num in result)
        {
            Console.Write(num + " ");
        }
    }

    public static int[] RemoveDuplicates(int[] array)
    {
        int[] temp = new int[array.Length];
        int count = 0;

        for (int i = 0; i < array.Length; i++)
        {
            bool isDuplicate = false;
            for (int j = 0; j < count; j++)
            {
                if (array[i] == temp[j])
                {
                    isDuplicate = true;
                    break;
                }
            }
            if (!isDuplicate)
            {
                temp[count] = array[i];
                count++;
            }
        }

        int[] result = new int[count];
        for (int i = 0; i < count; i++)
        {
            result[i] = temp[i];
        }
        return result;
    }
}*/

/*public class RemoveDuplicate
{
    public static void Main(String[] args)
    {
        
        int[] arr = { 35, 56, 68, 35, 47, 56, 21 };
        for (int i = 0; i <= arr.Length-1; i++)
        {
            for (int k = 0; k <= arr.Length-1; k++)
            {
                if(arr[i] < arr[k])
                {
                    int temp = arr[i];
                    arr[i] = arr[k];
                    arr[k] = temp;
             
                }
            }
        }
        
        int j = 0;
        for (int i = 0; i <= arr.Length-1; i++)
        {            
            if (arr[i] != arr[j])
            {
                j++;
                int temp = arr[j];
                arr[j] = arr[i];
                arr[i] = temp;
            }
        }
        for(int i=0;i<=j;i++)
        {
            Console.Write(arr[i] + " ");
        }
    }
}*/

/*namespace IEnumerable
{
    class Program
    {
        public static void Main(String[] args)
        {
            List<int> numbers = new List<int>{1,2,3,4,5,6};
            IEnumerable<int> evenNumbers = numbers.Where(n=>n%2 == 0);
            foreach(int num in evenNumbers)
            {
                Console.WriteLine(num);
            }
        }
    }
}*/

/*namespace CountCharacter
{
    public class Program
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Enter a word to count : ");
            string str = Console.ReadLine();

            str = str.Replace(" ", string.Empty);

            while(str.Length > 0)
            {
                Console.Write(str[0] + ":");
                int count = 0;
                for(int i=0; i<str.Length; i++)
                {
                    if(str[0] == str[i])
                    {
                        count++;
                    }
                }
                Console.WriteLine(count);
                str = str.Replace(str[0].ToString(), string.Empty);
            }
        }
    }
}*/

/*namespace CountCharacter
{
    class Program
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Enter a name to check character : ");
            string name = Console.ReadLine();
            Dictionary<char, int> count = countChar(name);
            foreach(var i in count)
            {
                Console.WriteLine($"{i.Key} = {i.Value}");
            } 
        }

        public static Dictionary<char, int> countChar(string name)
        {
            Dictionary<char, int> count = new Dictionary<char, int>();
            foreach(char c in name)
            {
                if(count.ContainsKey(c))
                {
                    count[c]++;
                }
                else
                {
                    count[c] = 1;
                }
            }
            return count;
        }
    }
}*/

/*namespace CountChar
{
    public class Program
    {
        public static void Main(String[] args)
        {
            int[] array = { 3, 3, 3, 5, 5, 2, 2, 2, 0, 0, 0, 4 };
            Dictionary<int, int> count = new Dictionary<int, int>();
            foreach(int num in array)
            {
                if(count.ContainsKey(num))
                    count[num]++;
                else
                    count[num] = 1;
            }
            Console.WriteLine("Digit Counts");
            foreach(var i in count)
            {
                Console.WriteLine($"Digit {i.Key} apears {i.Value} times");
            }
            HashSet<int> UniqNum = new HashSet<int>(array);
            foreach(var i in UniqNum)
            {
                Console.Write($"{i+ " "}");
            }
        }
    }
}*/

/*namespace Inhertance
{
    class ClassC
    {
        public static void Main(String[] args)
        {
            ClassB b = new ClassB();
            b.ABC();
        }

        class ClassA
        {
            public virtual void ABC()
            {
                Console.WriteLine("Class A");
            }

            public void Test()
            {
                Console.WriteLine("Test class A");
            }
        }

        class ClassB:ClassA
        {
            public override void ABC()
            {
                //  base.ABC();
                ClassA a = new ClassA();
                a.ABC();
                Console.WriteLine("Class B");
            }
        }
    }
}*/

/*namespace ExtensionMethod
{
    class Program
    {
        public static void Main(String[] args)
        {
            ClassA A = new ClassA();
            A.Add();
            A.Sub();
        }
    }

    public class ClassA
    {
        public void Add()
        {
            Console.WriteLine("Addition");
        }
    }

    public static class ClassB
    {
        public static void Sub(this ClassA a)
        {
            Console.WriteLine("Substarction");
        }
    }
}*/

/*namespace LeapYear
{
    public class Program
    {
        public static void Main(String[] args)
        {
            Console.Write("Enter a year: ");
            int year = int.Parse(Console.ReadLine());

            if(year%4 == 0 && year%100 != 0 || year%400 == 0)
            {
                Console.WriteLine("Leap Year");
            }
            else{
                Console.WriteLine("Not a leap year");
            }
        }
    }
}*/

/*namespace DepencyInjection
{
    interface IStudent
    {
        public int GetStudentCount();
    }

    public class MathsStudents : IStudent
    {
        public int GetStudentCount()
        {
            return 50;
        }
    }

    public class ScienceStudents : IStudent
    {
        public int GetStudentCount()
        {
            return 100;
        }
    }

    public class FirstController : ControllerBase
    {
        private Readonly IStudent _student;
        public FirstController(IStudent student)
        {
            _student = student;
        }

        public int Index()
        {
            return _student.GetStudentCount();
        }
    }
    
    builder.services.AddSingleton<IStudent, MathsStudents>();   // For Maths students count
    builder.services.AddSingleton<IStudent, ScienceStudents>();   // For Science students count

}*/

/*namespace SingleTonExample
{
    public sealed class SingleTonClass      // it should be sealed becouse class should not be inherited.
    {
        private SingleTonClass()    // it should have private constructor because class should not be instantiated.
        {

        }

        private static SingleTonClass instance;     // it should be private static property.
        private readonly static Object obj = new Object;

        public static SingleTonClass GetInstance()      // it should be public static.
        {
            lock(obj)       // lock used to prevent from thread safe.
            {
                if(instance == null)        // Lazy loading
                {
                    instance = new SingleTonClass();
                }
            }
            return instance;
        }

    }
}*/

/*namespace FactoryDesignPattern
{
    public interface ICreditCard
    {
        string GetCardType();
        int GetCreditLimit();
        int GetAnnualCharge();
    }

    public class MoneyBack : ICreditCard
    {
        public string GetCardType()
        {
            return "MoneyBack";
        }
        public int GetCreditLimit()
        {
            return 15000;
        }
        public int GetAnnualCharge()
        {
            return 500;
        }
    }

    public class Platinium : ICreditCard
    {
        public string GetCardType()
        {
            return "Platinium";
        }
        public int GetCreditLimit()
        {
            return 35000;
        }
        public int GetAnnualCharge()
        {
            return 2000;
        }
    }

    public class Titanium : ICreditCard
    {
        public string GetCardType()
        {
            return "Titanium Edge";
        }
        public int GetCreditLimit()
        {
            return 25000;
        }
        public int GetAnnualCharge()
        {
            return 1500;
        }
    }

    public class CreditCardFactory
    {
        public static ICreditCard GetCreditCard(string cardType)
        {
            ICreditCard cardDetail = null;

            if(cardType == "MoneyBack")
            {
                cardDetail = new MoneyBack();
            }
            else if(cardType == "Titanium")
            {
                cardDetail = new Titanium();
            }
            else if(cardType == "Platinium")
            {
                cardDetail = new Platinium();
            }
            return cardDetail;
        }
    }

    public class Program
    {
        public static void Main(String[] args)
        {
            ICreditCard cardDetail = CreditCardFactory.GetCreditCard("Platinium");

            if(cardDetail != null)
            {
                Console.WriteLine("CardType : " +cardDetail.GetCardType());
                Console.WriteLine("CreditLimt : " +cardDetail.GetCreditLimit());
                Console.WriteLine("AnnualCharge : " +cardDetail.GetAnnualCharge());
            }
            else
            {
                Console.WriteLine("Invalid Card Type");
            }
        }
    }
}*/

/*namespace FactoryDesign
{
    public class Program
    {
        public static void Main()
        {
            Factory F = new Factory();
            IFactory IF = F.GetInstance("Gold");
            IF.GetType();
            IF.GetLimit();            
        }
    }

    public interface IFactory
    {
        void GetType();
        void GetLimit();
    }

    public class Silver : IFactory
    {
        public void GetType()
        {
            Console.WriteLine("Silvercard");
        }
        public void GetLimit()
        {
            Console.WriteLine(10000);
        }
    }

    public class Platinium : IFactory
    {
        public void GetType()
        {
            Console.WriteLine("Platinium");
        }
        public void GetLimit()
        {
            Console.WriteLine(20000);
        }
    }

    public class Gold : IFactory
    {
        public void GetType()
        {
            Console.WriteLine("Gold");
        }
        public void GetLimit()
        {
            Console.WriteLine(30000);
        }
    }

    public class Factory
    {
        public IFactory GetInstance(string input)
        {
            IFactory obj = null ;
            if(input == "Silver")
            {
                obj = new Silver();
            }
            else if(input == "Gold")
            {
                obj = new Gold();
            }
            else if(input == "Platinium")
            {
                obj = new Platinium();
            } 

            return obj;
        }
    }
}*/

/*namespace RemoveDuplicatesSort
{
class Program
{
    static void Main()
    {
        int[] array = { 3, 3, 3, 5, 5, 2, 2, 2, 0, 0, 0, 4 };
        int[] result = RemoveDuplicatesAndSort(array);

        Console.WriteLine("Result: " + string.Join(", ", result));
    }

    public static int[] RemoveDuplicatesAndSort(int[] array)
    {
        Dictionary<int, int> elementCount = new Dictionary<int, int>();

        foreach (int num in array)
        {
            if (elementCount.ContainsKey(num))
            {
                if (elementCount[num] < 2)
                {
                    elementCount[num]++;
                }
            }
            else
            {
                elementCount[num] = 1;
            }
        }

        List<int> resultList = new List<int>();

        foreach (var kvp in elementCount)
        {
            for (int i = 0; i < kvp.Value; i++)
            {
                resultList.Add(kvp.Key);
            }
        }

        resultList.Sort();

        return resultList.ToArray();
    }
}   
}*/

/*namespace CutomMidleware
{
    public class LoggingMiddleware
    {
        private readonly RequestDelegate next;
        public LoggingMiddleware(Request _next)
        {
            next = _next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            Console.WriteLine($"Request path : {context.Request.Path}");
            await _next(context);
        }
    }

    // Register in Program.cs
    app.UseMiddleware<LoggingMiddleware>();

    // Create Extension method for clean code.
    public static class LoggingMiddlewareExtension
    {
        public static IApplicationBuilder UseRequestLogging(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<LoggingMiddlewareExtension>();
        }
    }
}*/

/*namespace ReverseSentenceWithoutChangingPosition
{
    public class Program
    {
        static void Main(String[] args)
        {
            string Sentence = "I am in Intervew panel";
            string result = ReveseWordInString(Sentence);
            Console.WriteLine(result);
        }

        static string ReveseWordInString()
        {
            string result = "";
            int i = 0;
            while(i < Sentence.Length)
            {
                if (Sentence[i] == ' ')
                {
                    result = result + ' ';
                    i++;
                    continue;
                }

                int start = i;
                while (i < Sentence.Length && Sentence[i] != ' ')
                {
                    i++;
                }
                int end = i - 1;

                for(int j=end; j>=start; j--)
                {
                    result = result + Sentence[j];
                }
            }
            return result;            
        }
    }
}*/

/*public class RateLimiting
{
    private readonly Requestdeligate _next;
    public RateLimiting(RequestDelegate next)
    {
        _next = next;
    }
    private static Dictionary<string int> _requestCount = new Dictionary<string, int>();
    public async Task Invoke(HttpContext context)
    {
        var clientIp = context.connection.RemoteIpAddress.ToString();
        if (_requestCount.ContainsKey(clientIp))
        {
            _requestCount[clientIp]++;
        }
        else
        {
            _requestCount[clientIp] = 1;
        }

        if(_requestCount > 100)
        {
            limit context.Response.StatusCode = 429;
            await context.Response.WriteAsync("Rate Limit exceded");
            return;
        }
        await _next.context
    }
}*/

// Basic CRUD Operation
/*

using Microsoft.AspNetCore.Mvc;

public static class ProductStore
{
    public static List<Product> Products = new()
    {
        new Product { Id = 1, Name = "Pen" },
        new Product { Id = 2, Name = "Book" }
    };
}

[ApiController]
[Route("api/products")]
public class ProductsController : ControllerBase
{
    // GET: api/products
    [HttpGet]
    public ActionResult<IEnumerable<Product>> GetAll()
    {
        return Ok(ProductStore.Products);
    }

    // GET: api/products/1
    [HttpGet("{id}")]
    public ActionResult<Product> GetById(int id)
    {
        var product = ProductStore.Products.FirstOrDefault(p => p.Id == id);

        if (product == null)
            return NotFound();

        return Ok(product);
    }

    // POST: api/products
    [HttpPost]
    public ActionResult<Product> Create(Product product)
    {
        product.Id = ProductStore.Products.Max(p => p.Id) + 1;
        ProductStore.Products.Add(product);

        return CreatedAtAction(nameof(GetById), new { id = product.Id }, product);
    }

    // PUT: api/products/1
    [HttpPut("{id}")]
    public ActionResult Update(int id, Product updatedProduct)
    {
        var product = ProductStore.Products.FirstOrDefault(p => p.Id == id);

        if (product == null)
            return NotFound();

        product.Name = updatedProduct.Name;
        return Ok(product);
    }

    // DELETE: api/products/1
    [HttpDelete("{id}")]
    public ActionResult Delete(int id)
    {
        var product = ProductStore.Products.FirstOrDefault(p => p.Id == id);

        if (product == null)
            return NotFound();

        ProductStore.Products.Remove(product);
        return Ok("Product deleted");
    }
}

*/


/*
//  Interview Questions

1.FizzBuzz
2.Reverse a string
3.Palindrome Number
4.Remove the duplicate numbers from list
5.Count character in string
6.Factorial of number
7.Check if two strings are Anagrams (Check each letters are present in the both string)
8.Find the second highest number in an array.
9.Count numbers of Owels in a string
10.Generate fibonacci series
11.Find the missing number in an array
12.First non repeating character in string

13.Sum of the digits in a Number
14.Comman elements in two array
15.Convert sentence to TitleCase
16.Count the words in a string
17.Find the duplicate characters in string
18.Check is Array is sorted or not
19.Remove the whitespace from the string
20.Convert Binary to Decimal
21.Handle divide by zero exception
22.Reverse each word in sentence
23.Find the longest word in sentence
24.Get all even numbers from the list
25.Find the intersection of two list
26.Find maximum value in list

27.Group string by their length
28.Check if a string is Numeric or Not
29.Concatinate list of string with delimiter
30.Use delegate to perform arthimatic operation
31.Declare and Invoke an Event
32.Capitalize first letter of each word in a sentence.
33.Find all Indices of character in a string
34.Sort a list of string alphabatically
35.Convert list of Integers to comma saparated string
36.Remove all Null or Empty list from a string
37.Merge two sorted array
38.Find all prime numbers upto N
39.Convert a string to an Integer safely
40.Get distinct characters in a string
41.Convert a list of string into Uppercase.
42.Check if two list are equal.
43.Swap two numbers without a Temp variable.
44.Flaten a list of list
45.Find the duplicate in a array
46.Calculate average of list
47.Check if a string contains only Digits
48.Count words starting with vowels.
49.Create dictionary from two list
50.Trigger a delegate chain

*/


---------------------------------------------------------------------------
WebAPI codes
---------------------------------------------------------------------------

using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading;


//  Routing In API
/*[Route"(api/Products/{id : int})"]
public class ProductController : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> GetAllProducts(int id)
    {
        var prouct = await products.GetAllProductsAsync(int id)
        {
            if (Product == null)
                return Not Found();
            return Ok(Product);
        }
    }
}*/

// Model validation
/*[HttpPost]
public IActionResult CreateProduct([FromBody] Product product)
{
    if (!ModelState.IsValid)
        return BadRequest(ModelState);
    return CreatedAtAction("DefaultApi", new { id = product.Id }, product); 
}*/

// Custom error handling
/*if (!ModelState.isValid)
  { 
    return BadRequest(new 
    { 
        message = "Invalid data", errors = Modelstate.Values.SelectMany(e => e.Errors) 
    }); 
  }
*/

// API Versioning
/*
[ApiVersion("1.0")]
[Route("api/v{version:apiVersion}/products")]
public class ProductsV1Controller : ControllerBase
{
    [HttpGet]
    public IActionResult GetV1()
    {
        return Ok("Version 1");
    }
}

[ApiVersion("2.0")]
[Route("api/v{version:apiVersion}/products")] 
public class ProductsV2Controller : ControllerBase
{
    [HttpGet] 
    public IActionResult GetV2()
    {
        return Ok("Version 2"); 
    }
 }

builder.services.AddApiVersioning(options =>
{
    options.DefaultApiVersion = new ApiVersion(1, 0);
    options.AssumeDefaultVersionWhenUnspecified = true;
    options.ReportApiVersions = true;
}); 

*/

// CROS - Cross Orign Resource Sharing
/*
builder.services.AddCors(options =>
{
    options.AddPolicy("AllowAll", builder => 
    builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());
});

app.UseCors("AllowAll");
*/

// Asynchronous Programing.
/*
[HttpGet("{id}")] 
public async Task<IActionResult> GetProduct(int id)
{
    var product = await _productService.GetProductAsync(id);
    if (product == null)
        return NotFound();
    return Ok(product); 
}
*/

// Logging and Monitoring
/*
public class ProductsController : ControllerBase
{
    private readonly ILogger<ProductsController> _logger; 
    public ProductsController(ILogger<ProductsController> logger)
    {
        _logger = logger;
    } 
    public IActionResult GetProduct(int id)
    {
        _logger.LogInformation("Fetching product with ID {id}", id);
        // Other logic 
    }
}
*/

// Rate Limiting
/*
public class RateLimiting
{
    private readonly Requestdelegate _next;
    Dictionary<string, int> requestCount = new Dictionary<string, int>();
    public RateLimiting(Requestdelegate next)
    {
        _next = next;
    }

    public Async Task InvokeAsync(HttpContent context)
    {
        var clientIp = context.Connection.RemoteIpAddress.ToString();
        {
            if (requestCount.ContainsKey(clientIp))
            {
                requestCount[clientIp]++;
            }
            else
            {
                requestCount[clientIp] = 1;
            }

            if(requestCount > 100)
            {
                limit context.Response.StatusCode = 429;
                await context.Response.WriteAsync("Too many requests");
                return;
            }
            await _next(context);

        }
    }
}
*/

// Error Handing in WebAPI
/*
public IActionResult GetProduct(int id)
{
    try
    {
        var product = _productService.GetById(id);
        if (product == null)
        {
            return NotFound();
        }
        return Ok(product);
    }
    catch (Exception ex)
    {
        return InternalServerError(ex);
    }
}
*/

// InMenory Caching
/*
public class ProductsController : ControllerBase
{
    private readonly IMemoryCache _cache;
    public ProductsController(IMemoryCache cache)
    {
        _cache = cache;
    }
    public IActionResult GetProducts()
    {
        if (!_cache.TryGetValue("products", out List<Product> products))
        {
            products = _productService.GetAll();
            _cache.Set("products", products, TimeSpan.FromMinutes(5));
        }
        return Ok(products);
    }
}
*/

/*
// Error handling Middleware.

public class ErrorHandlingMiddleware
{
    private readonly RequestDelegate _next;
    private readonly ILogger<ErrorHandlingMiddleware> _logger;

    public ErrorHandlingMiddleware(RequestDelegate next, ILogger<ErrorHandlingMiddleware> logger)
    {
        _next = next;
        _logger = logger;
    }

    public async Task Invoke(HttpContext context)
    {
        try
        {
            await _next(context); // Proceed to next middleware
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Unhandled exception occurred.");
            context.Response.StatusCode = 500;
            context.Response.ContentType = "application/json";

            var errorResponse = new
            {
                Message = "An unexpected error occurred.",
                Details = ex.Message // Optional:(errorResponse);
            }
        }
    }
}
*/

/*
// Global Exceptions handling

public void Configure(IApplicationBuilder app)
{
    app.UseExceptionHandler(errorApp =>
    {
        errorApp.Run(async context =>
        {
            context.Response.StatusCode = 500;
            await context.Response.WriteAsync("An unexpected error occurred.");
        });
    });
}
*/

// Nunit Testing and Mocking
/*
public interface IProductRepository
{
    IEnumerable<string> GetAllProducts();
}

public class ProductService
{
    private readonly IProductRepository _Repository;
    public ProductService(IProductRepository Repository)
    {
        _Repository = Repository;
    }

    public int GetAllProducts()
    {
        var products = _Repository.GetAllProducts();
        return products == null ? 0 : new List<string>(products).Count;
    }
}

public class ProductServiceTests
{
    [Text Fixtures]
    public void GetProductsCount_ReturnsCorrectCount
    {
        // Arrange
        var mockRepo = new Mock<IProductRepository>();
        mockRepo.Setup( r => r.GetAllProducts()).Returns(new List<string>{"Laptop","Mouse","Keyboard"});
         var service = new ProductService(mockRepo.Objects);

        // Act
        int count = service.GetAllProducts();

        // Assert
        Assert.Equal(3, count);
    }
    
    [Text Fixtures]
    public void GetProductsCount_ReturnsZero_WhenNoProducts
    {
        // Arrange
        var mockRepo = new Mock<IProductRepository>();
        mockRepo.Setup( r => r.GetAllProducts()).Returns(new List<string>());
         var service = new ProductService(mockRepo.Objects);

        // Act
        int count = service.GetAllProducts();

        // Assert
        Assert.Equal(0, count);
    }

    {
        var mockService = new Mock<IProductService>();
        mockService.Setup(x => x.GetAll()).Returns(new List<Product> { new Product { Id = 1, Name = "Sample" } });

        var controller = new ProductsController(mockService.Object);
        var result = controller.GetAll();
        
        Assert.IsType<OkObjectResult>(result);
    }
}
*/

/*
// Singleton design patterns
public sealed class Logger
{
    private static Logger _instance;
    private static readonly object obj = new object();

    // Private constructor to prevent external instantiation
    private Logger() { }

    public static Logger GetInstance()
    {
            lock (obj)
            {
                if (_instance == null)
                    _instance = new Logger();
                return _instance;
            }
    }

    public void Log(string message)
    {
        Console.WriteLine($"[LOG] {DateTime.Now}: {message}");
    }
}

class Program
{
    static void Main()
    {
        Logger.Instance.Log("Application started.");
        Logger.Instance.Log("Performing some operation...");
        Logger.Instance.Log("Application ended.");
    }
}

//  Basic Authentication

public class BasicAuthentication : AuthorizationFilterAttribute 
{ 
    public override void OnAuthorization(HttpActionContext context) 
    { 
        var authHeader = context.Request.Headers.Authorization; 
        if (authHeader == null || authHeader.Scheme != "Basic") 
        { 
            context.Response = context.Request.CreateResponse(HttpStatusCode.Unauthorized); 
            return; 
        }
        // Check credentials 
    } 
}

//      JWT Token Authentication

Microsoft.AspNetCore.Authentication.JwtBearer

 builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
       .AddJwtBearer(options =>
       {
           options.TokenValidationParameters = new TokenValidationParameters
           {
               ValidateIssuer = true,
               ValidateAudience = true,
               ValidateLifetime = true,
               IssuerSigningKey = new 
SymmetricSecurityKey(Encoding.UTF8.GetBytes("YourSecretKey"))

[Authorize]
[HttpGet]
public IActionResult GetSecretData()
{
    return Ok("This is protected");
}


*/


----------------------------------------------------------------
LINQ -Topics
-----------------------------------------------------------------

using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;


//  LINQ 
//  --> Using Linq we can write queries on a wide variety of data sources like Arrays, Collections, Database tables, Data sets, XMLData

//  Syntax for Database. 
//  select <collection list> from <table> as <alias>] [<clauses>]
// clauses :- Where, Group by, Having, Order by

//  Syntax for LINQ.
//  from <alias> in <collction or Array> [<clauses>] select <alias>

// Example :- How many elements above 40 in array
// int[] arr = {12, 45, 67, 39, 8, 61, 74, 82, 97, 27, 56, 49, 58, 79, 86, 14, 3, 23, 37, 92};
// var arr1 = from i in arr select i;
// var arr2 = from i in arr where i>40 select i;
// var arr3 = from i in arr where i>40 orderby i select i;
// var arr4 = from i in arr where i>40 orderby i descending select i;


// using System;
// namespace LinqProject
// {
//     class Linq
//     {
//         static void Main()
//         {
//             int[] arr = {12, 45, 67, 39, 8, 61, 74, 82, 97, 27, 56, 49, 58, 79, 86, 14, 3, 23, 37, 92};
//             var arr1 = from i in arr where i>40 orderby i descending select i;
//             foreach(int x in arr1)
//             System.Console.Write(x+" ");
//         }         
//     }

// }


// Linq to Objects :- Arrays, Collections, etc
// Linq to Database :- DataTables, Relational Database Tables
// -->     Linq to ADO.Net
// -->     Linq to SQL
// -->     Linq to Entities
// Linq to XML :- XML files 

// Linq to SQL
// --> It is a query language introduces in Dotnet 3.0 framework, for working with relational database ie; Sql server
// --> It is allow us to perform Insert, Read, Update and Delete operations ie; CRUD operation. 
// Advantages are below,
// 1.  Compile time syntax checking
// 2.  Type safe.
// 3.  Intellisense suppoert is available.
// 4.  Debugging to Linq to SQL is availble.
// 5.  Pure Object Oriented code.

//  Table       --->        Class
//  Colums      --->        Property
//  Rows and Records    --> Instances
//  Stored procedures   --> Methods


// ORM (Object Relational Mapping) - ORDesigner tool
// To work with link to Sql, forst we need to convert all the relational objects of databse into object oriented types and this process is known as ORM.
//  By using OR(Object Realtional) Designer we can convert all relational objects into Object oriented types. and this is called ORM performance.


// using System.Collections.Generic;
// using System.Security.Cryptography;
// namespace DemoApp
// {
//     internal class Employee
//     {
//         public int ID { get; set; }
//         public string ?FirstName { get; set; }
//         public string ?LastName { get; set; }
//         public string ?Department { get; set; }
//         public int Age { get; set; }
//         public int Salary { get; set; }
//     }

//     internal static class DataManager
//     {
//         internal static List<Employee> GetData()
//         {
//             return new List<Employee>
//             {
//                 new Employee{ID = 1, FirstName = "Sharan", LastName = "Mannalli", Department = "DEV", Age = 24, Salary = 10000},
//                 new Employee{ID = 2, FirstName = "Suraj", LastName = "Savekar", Department = "Sales", Age = 25, Salary = 15000},
//                 new Employee{ID = 3, FirstName = "John", LastName = "Smith", Department = "Finance", Age = 21, Salary = 20000},
//                 new Employee{ID = 4, FirstName = "Ava", LastName = "Maroon", Department = "HR", Age = 32, Salary = 5000},
//                 new Employee{ID = 5, FirstName = "Jaimy", LastName = "Lanister", Department = "QA", Age = 20, Salary = 25000},
//                 new Employee{ID = 6, FirstName = "Sachin", LastName = "Bhaire", Department = "Sales", Age = 27, Salary = 13000},
//                 new Employee{ID = 7, FirstName = "Kashi", LastName = "Nath", Department = "Scrum", Age = 31, Salary = 19000},
//                 new Employee{ID = 8, FirstName = "Vishnu", LastName = "Sakepalli", Department = "Support", Age = 33, Salary = 24000},
//                 new Employee{ID = 9, FirstName = "David", LastName = "Willson", Department = "Dev", Age = 45, Salary = 17000},
//                 new Employee{ID = 10, FirstName = "Sersi", LastName = "Lan", Department = "Manager", Age = 51, Salary = 11000},
//                 new Employee{ID = 11, FirstName = "Hisenberg", LastName = "Quantum", Department = "Technician", Age = 29, Salary = 26000},
//                 new Employee{ID = 12, FirstName = "Newton", LastName = "Laws", Department = "Cleark", Age = 39, Salary = 39000},
//             };
//         }
//     }

//     class Program
//     {
//         public static void Main(String[] args)
//         {
//             List<Employee> employees = DataManager.GetData();

// foreach (Employee employee in employees)
// {
//     Console.WriteLine("ID = {0}, FirstName = {1}, LastName = {2}, Department = {3}, Age = {4}, Salary = {5}",
//     employee.ID, employee.FirstName, employee.LastName, employee.Department, employee.Age, employee.Salary);
// }

//  Using LINQ
// employees.ForEach(employee => Console.WriteLine("ID = {0}, FirstName = {1}, LastName = {2}, Department = {3}, Age = {4}, Salary = {5}",
//                     employee.ID, employee.FirstName, employee.LastName, employee.Department, employee.Age, employee.Salary));

//  Returning perticular columns
// IEnumerable<string> names = employees.Select(e => e.FirstName).Distinct();
// foreach (string name in names)
// {
//     Console.WriteLine(name);
// }

//  Sorting Collections
// employees = employees.OrderBy(e => e.FirstName).ToList();
// employees = employees.OrderByDescending(e => e.FirstName).ThenBy(e => e.LastName).ToList();
// employees.ForEach(employee => Console.WriteLine("ID = {0}, FirstName = {1}, LastName = {2}, Department = {3}, Age = {4}, Salary = {5}",
//                      employee.ID, employee.FirstName, employee.LastName, employee.Department, employee.Age, employee.Salary));

//  Filtering from Collections
// employees = employees.Where(e => e.Age > 25 && e.Salary > 20000).ToList();
// employees.ForEach(employee => Console.WriteLine("ID = {0}, FirstName = {1}, LastName = {2}, Department = {3}, Age = {4}, Salary = {5}",
//                      employee.ID, employee.FirstName, employee.LastName, employee.Department, employee.Age, employee.Salary));


//  Some other functions in LINQ like First(), FirstOrDefault() etc
// Employee employee = employees.First(e => e.FirstName == "Sharan");   // Returns First element from collections
// Employee employee = employees.Last(e => e.FirstName == "Sharan");    //  Returns last elements from collections
// Employee employee = employees.FirstOrDefault(e => e.FirstName == "Sharanabasava");   //  Retunr first matching value or throw exceptions.
// Employee employee = employees.LastOrDefault(e => e.FirstName == "Sharanabasava");    //  Return last matching value
// Employee employee = employees.Single(e => e.FirstName == "Sharan");      // Use only when you have no duplicate elements.
// if (employee != null)
// {
//     Console.WriteLine("ID = {0}, FirstName = {1}, LastName = {2}, Department = {3}, Age = {4}, Salary = {5}",
//                          employee.ID, employee.FirstName, employee.LastName, employee.Department, employee.Age, employee.Salary);
// }
// else
// {
//     Console.WriteLine("Not Found");
// }

// employees = employees.Take(2).ToList();     //  Returns first 2 elements from list.
// employees = employees.Skip(2).Take(5).ToList();     //  Skips first 2 elements and returns next 5 elemtents
// employees.ForEach(employee => Console.WriteLine("ID = {0}, FirstName = {1}, LastName = {2}, Department = {3}, Age = {4}, Salary = {5}",
//                      employee.ID, employee.FirstName, employee.LastName, employee.Department, employee.Age, employee.Salary));


//  Some Boolean and Other methods examples.

// Console.WriteLine(employees.Any(e => e.Age > 30));
// Console.WriteLine(employees.All(e => e.Age > 30));
// Console.WriteLine(employees.Count(e => e.Age > 30));
// Console.WriteLine(employees.Sum(e => e.Salary));
// Console.WriteLine(employees.Average(e => e.Salary));
// Console.WriteLine(employees.Min(e => e.Salary));
// Console.WriteLine(employees.Max(e => e.Salary));

// Employee employee = employees.MinBy(e => e.Salary);     // Returns whole data whose salary is minimun.
//             Employee employee = employees.MaxBy(e => e.Salary);     // Returns whole data whose salary is maximum.
//             Console.WriteLine("ID = {0}, FirstName = {1}, LastName = {2}, Department = {3}, Age = {4}, Salary = {5}",
//                                  employee.ID, employee.FirstName, employee.LastName, employee.Department, employee.Age, employee.Salary);


//         }
//     }
// }


// class Student
// {
//     public int ID { get; set; }
//     public string Name { get; set; }
//     public char Gender { get; set; }
// }


/*class Program
{
    public static void Main(String[] args)
    {
        //  Query Syntax
        // List<int> numbers = new List<int> { 1, 3, 6, 8, 10, 2, 4, 6, 8, 09, 5, 22, 41, 69, 34, 97 };
        // IEnumerable<int> result = from n in numbers where n > 10 select n;
        // foreach (int num in result)
        // {
        //     Console.WriteLine(num);
        // } 

        //  Method Syntax
        // List<int> numbers = new List<int> { 1, 3, 6, 8, 10, 2, 4, 6, 8, 09, 5, 22, 41, 69, 34, 97 };
        // var result = numbers.Where(n => n > 10).ToList();
        // foreach (int num in result)
        // {
        //     Console.WriteLine(num);
        // }

        //  Mixed Syntax
        // List<int> numbers = new List<int> { 1, 3, 6, 8, 10, 2, 4, 6, 8, 09, 5, 22, 41, 69, 34, 97 };
        // var result = (from num in numbers where num > 10 select num).Sum();
        // Console.WriteLine(result);

        //  --------------------------------------------------------------------------------------------------------------

        //  Creating Objects example
        // List<Student> studentList = new List<Student>()
        // {
        //     new Student(){ID = 1, Name = "Sharan", Gender = 'M'},
        //     new Student(){ID = 2, Name = "Basav", Gender ='M'}
        // };

        // // IEnumerable<Student> result = from i in studentList where i.ID == 2 select i;    // IEnumerable
        // IQueryable<Student> result = studentList.AsQueryable().Where(std => std.ID == 2);    // IQuerable
        // foreach (var n in result)
        // {
        //     Console.WriteLine($" Name : {n.Name}, Gender: {n.Gender}");
        // }

        //  --------------------------------------------------------------------------------------------------------------

        // Operators OR Methods

        //  1. Projection Operator(Select, SelectMany)
        //  Select :-
        //  Purpose: Projects each element of a sequence into a new form.
        //  Use case: When you want to transform each item in a collection individually.
        // var numbers = new List<int> { 1, 2, 3 };
        // var squares = numbers.Select(n => n * n);
        // Result: [1, 4, 9]

        //  SelectMany :- When each item in the collection contains a sub-collection, and you want to flatten all sub-collections into a single sequence.  
        //  var students = new[]
        //  {
        //      new { Name = "Alice", Subjects = new[] { "Math", "Science" } },
        //      new { Name = "Bob", Subjects = new[] { "English", "History" } }
        //  };
        //  var allSubjects = students.SelectMany(s => s.Subjects);
        // Result: ["Math", "Science", "English", "History"]

        //  ------------------------------------------------

        //  2.  Filtering Operator(Where and OfType)
        //  Where: Filters a sequence of values based on a predicate.
        //  var numbers = new List<int> { 1, 2, 3, 4, 5 };
        //  var evenNumbers = numbers.Where(n => n % 2 == 0);
        // Result: [2, 4]


        //  OfType: Filters the elements of an array based on a specified type.
        //  var mixedList = new ArrayList { 1, "hello", 2.5, 3, "world" };
        //  var integers = mixedList.OfType<int>();
        // Result: [1, 3]

        //  ------------------------------------------------

        //  3.  Partitioning Operator
        //  Take : Returns a specified number of elements from the start of a sequence.
        //  var numbers = new List<int> { 1, 2, 3, 4, 5 };
        //  var firstThree = numbers.Take(3);
        // Result: [1, 2, 3]

        //  Skip : Skips a specified number of elements and returns the remaining.
        //  var numbers = new List<int> { 1, 2, 3, 4, 5 };
        //  var afterTwo = numbers.Skip(2);
        // Result: [3, 4, 5]

        //  TakeWhile : Takes elements from the sequence as long as the condition is true.
        //  var numbers = new List<int> { 1, 2, 3, 4, 5 };
        //  var lessThanFour = numbers.TakeWhile(n => n < 4);
        // Result: [1, 2, 3]

        //  SkipWhile : Skips elements as long as the condition is true, then returns the rest.
        //  var numbers = new List<int> { 1, 2, 3, 4, 5 };
        //  var skipLessThanThree = numbers.SkipWhile(n => n < 3);
        // Result: [3, 4, 5]

        //  ------------------------------------------------

        //  4.  Ordering Operator
        //  OrderBy : Sorts the elements in ascending order based on a key.
        //  var names = new List<string> { "Charlie", "Alice", "Bob" };
        //  var sortedNames = names.OrderBy(n => n);
        // Result: ["Alice", "Bob", "Charlie"]

        //  OrderByDescending : Sorts the elements in descending order based on a key.
        //  var scores = new List<int> { 90, 70, 80 };
        //  var sortedScores = scores.OrderByDescending(s => s);
        // Result: [90, 80, 70]

        //  ThenBy : Performs a secondary sort in ascending order after OrderBy.
        //  var people = new[]
        //  {
        //  new { Name = "Alice", Age = 30 },
        //  new { Name = "Bob", Age = 25 },
        //  new { Name = "Alice", Age = 25 }
        //  };
        //  var sortedPeople = people.OrderBy(p => p.Name).ThenBy(p => p.Age);
        // Result: [Alice-25, Alice-30, Bob-25]

        //  ThenByDescending : Performs a secondary sort in descending order after OrderBy.
        //  var sortedPeople = people.OrderBy(p => p.Name).ThenByDescending(p => p.Age);
        // Result: [Alice-30, Alice-25, Bob-25]

        //  ------------------------------------------------

        //  5.  GroupBy Operator : Groups elements that have the same key. Returns A collection of groups, where each group is an IGrouping<TKey, TElement>.
        /*var students = new[]
        {
            new { Name = "Alice", Grade = "A" },
            new { Name = "Bob", Grade = "B" },
            new { Name = "Charlie", Grade = "A" },
            new { Name = "David", Grade = "C" }
        };

        var groupedByGrade = students.GroupBy(s => s.Grade);

        foreach (var group in groupedByGrade)
        {
            Console.WriteLine($"Grade: {group.Key}");
            foreach (var student in group)
            {
                Console.WriteLine($"  {student.Name}");
            }
        }

          Result : Grade: A
                    Alice
                    Charlie
                   Grade: B
                    Bob
                   Grade: C
                    David    
        */

//  ------------------------------------------------

//  6.  Join Operators: It is used to combine elements from two sequences based on matching keys, similar to SQL joins.  It’s particularly useful when working with related data from different collections.

//  ------------------------------------------------

//  7. Set Operators: These operators perform mathematical set operations on sequences, such as Distinct, Union, Intersect, and Except. These operators help you compare, combine, and eliminate duplicates from collections.
//  Distinct: Removes duplicate elements from a sequence.
//  var numbers = new List<int> { 1, 2, 2, 3, 3, 3 };
//  var uniqueNumbers = numbers.Distinct();
// Result: [1, 2, 3]


//  Union: Produces the set union of two sequences.
//  var list1 = new List<int> { 1, 2, 3 };
//  var list2 = new List<int> { 3, 4, 5 };
//  var union = list1.Union(list2);
// Result: [1, 2, 3, 4, 

//  Intersect: Produces the set intersection of two sequences.
//  var list1 = new List<int> { 1, 2, 3 };
//  var list2 = new List<int> { 2, 3, 4 };
//  var intersection = list1.Intersect(list2);
// Result: [2, 3]

//  Except: Produces the set difference of two sequences.
//  var list1 = new List<int> { 1, 2, 3 };
//  var list2 = new List<int> { 2, 3, 4 };
//  var difference = list1.Except(list2);
// Result: [1]

//  ------------------------------------------------

//  8.  Conversion Operators: These are used to convert one type of sequence or collection to another. Examples include ToArray, ToList, ToDictionary, and AsEnumerable. These are especially useful when you need to transform the result of a query into a specific collection type or format.
//  AsEnumerable: Casts an IEnumerable to an IEnumerable<T>.
//  ToArray: Converts a sequence to an array.
//  ToList: Converts a sequence to a List<T>.
//  ToDictionary: Converts a sequence to a Dictionary<TKey, TValue> based on a key selector function.

//  ------------------------------------------------

// 9.   Element Operators: are used to retrieve single elements from a sequence. These operators are helpful when you want to access specific items directly, such as the first, last, or only item that matches a condition.
/*  First() : Returns the first element of a sequence. Throws exception if the sequence is empty.
var numbers = new List<int> { 10, 20, 30 };
var first = numbers.First(); // Result: 10

//  FirstOrDefault() : Returns the first element, or a default value if the sequence is empty.
var emptyList = new List<int>();
var first = emptyList.FirstOrDefault(); // Result: 0 (default for int)

//  Last() : Returns the last element of a sequence. Throws exception if the sequence is empty.
var last = numbers.Last(); // Result: 30

//  LastOrDefault() : Returns the last element, or a default value if the sequence is empty.
var last = emptyList.LastOrDefault(); // Result: 0

//  Single() : Returns the only element in a sequence. Throws exception if there is more than one or none.
var oneItem = new List<int> { 42 };
var single = oneItem.Single(); // Result: 42


//  SingleOrDefault() : Returns the only element, or default if none. Throws exception if more than one.
var empty = new List<int>();
var single = empty.SingleOrDefault(); // Result: 0


//  ElementAt(index) : Returns the element at a specific index. Throws exception if index is out of range.
var item = numbers.ElementAt(1); // Result: 20


//  ElementAtOrDefault(index) : Returns the element at a specific index, or default if out of range.
var item = numbers.ElementAtOrDefault(5); // Result: 0

*/

//  ------------------------------------------------

/* 

10. Quantifier Operators: are used to determine whether some or all elements in a sequence satisfy a condition. These operators return a Boolean value (true or false).

---> Any() : Checks if any elements exist in the sequence or if any element satisfies a condition. Returns true if at least one element matches; otherwise, false.
var numbers = new List<int> { 1, 2, 3 };
bool hasEven = numbers.Any(n => n % 2 == 0); // true
bool isNotEmpty = numbers.Any();             // true

---> All() : Checks if all elements in the sequence satisfy a condition. Retuns true only if every element matches the condition.
var numbers = new List<int> { 2, 4, 6 };
bool allEven = numbers.All(n => n % 2 == 0); // true

---> Contains() : Checks if the sequence contains a specific element. Returns true if the element is found.
var numbers = new List<int> { 1, 2, 3 };
bool hasTwo = numbers.Contains(2); // true

*/

/*

11. Aggregate Operators: These operators perform a calculation on a sequence and return a single value. Examples include Count, Sum, Min, Max, Average, and Aggregate.
--->  Count: Counts the elements in a sequence.
var numbers = new List<int> { 1, 2, 3 };
int count = numbers.Count(); // Result: 3

--->  LongCount: Counts the elements in a sequence, returning the count as a long.
List<int> numbers = Enumerable.Range(1, 1000000000).ToList();
long evenCount = numbers.LongCount(n => n % 2 == 0);
Console.WriteLine(evenCount); // Output: 500000000


--->  Sum: Computes the sum of a sequence of numeric values.
int total = numbers.Sum(); // Result: 

--->  Min: Returns the minimum value in a sequence.
int min = numbers.Min(); // Result: 1

--->  Max: Returns the maximum value in a sequence.
int max = numbers.Max(); // Result: 3

--->  Average: Computes the average of a sequence of numeric values.
double avg = numbers.Average(); // Result: 2.0

--->  Aggregate: Applies an accumulator function over a sequence.
string[] words = { "Hello", "World", "LINQ" };
string sentence = words.Aggregate((a, b) => a + " " + b);
// Result: "Hello World LINQ"

*/

// 12. Equality Operators: Determines whether two sequences are equal by comparing the elements by using the default equality comparer for their type.

/*

13. Generation Operators: are used to create sequences of values. These are especially useful when you need to generate data on the fly without relying on an existing collection.
--->  Empty<T>() : Returns an empty IEnumerable<T> with the specified type argument.
var emptyList = Enumerable.Empty<string>();
// Output: (no elements


--->  Repeat() : Generates a sequence that contains one repeated value.
var repeated = Enumerable.Repeat("Hello", 3);
// Output: "Hello", "Hello", "Hello"


--->  Range() : Generates a sequence of integral numbers within a specified range.
var numbers = Enumerable.Range(1, 5);
// Output: 1, 2, 3, 4, 5



}
}*/


// Extension Methods in LINQ
/*namespace Linq
{
    class Program
    {
        public static void Main(string[] args)
        {
            string str = "we need to make the ExtensionHelper class a static class";
            int wordCount = str.GetWordCount();
            Console.WriteLine($"There are total {wordCount} words are there in sentence");
        }
    }

    public static class ExtensionMethod
    {
        public static int GetWordCount(this string str)
        {
            if (!String.IsNullOrEmpty(str))
                return str.Split(' ').Length;
            return 0;
        }
    }
}*/

// -----------------------------------------------------------------------------------------------------------------------------------------------

// Projections Methods

/*namespace Projections
{

    //  Select Method

    /*public class Employee
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Salary { get; set; }

        public static List<Employee> GetEmployees()
        {
            List<Employee> employees = new List<Employee>
            {
                new Employee {ID = 101, FirstName = "Preety", LastName = "Tiwary", Salary = 60000 },
                new Employee {ID = 102, FirstName = "Priyanka", LastName = "Dewangan", Salary = 70000 },
                new Employee {ID = 103, FirstName = "Hina", LastName = "Sharma", Salary = 80000 },
                new Employee {ID = 104, FirstName = "Anurag", LastName = "Mohanty", Salary = 90000 },
                new Employee {ID = 105, FirstName = "Sambit", LastName = "Satapathy", Salary = 100000 },
                new Employee {ID = 106, FirstName = "Sushanta", LastName = "Jena", Salary = 160000 }
            };

            return employees;

        }

        public static void Main(String[] args)
        {
            // Using Query Syntax
            // List<Employee> basicQuery = (from emp in Employee.GetEmployees() select emp).ToList();
            // foreach (Employee emp in basicQuery)
            // {
            //     Console.WriteLine($"ID : {emp.ID} FirstName : {emp.FirstName} LastName : {emp.LastName}");
            // }

            // Using Method Syntax
            IEnumerable<Employee> basicMethod = Employee.GetEmployees().ToList();
            foreach (Employee emp in basicMethod)
            {
                Console.WriteLine($"ID : {emp.ID} FirstName : {emp.FirstName} LastName : {emp.LastName}");
            }

            /*Select Single property from data source
            //query Syntax
            List<int> data =(from emp in Employee.GetEmployees()
                            select emp.Id).ToList();
            //Method Syntax
            IEnumerable<int> data = Employee.GetEmployees()
                             .Select(emp => emp.Id);   
        }
    }*/


    //  SelectMany Method.

    /*class SelectManyName
    {
        public static void Main(string[] args)
        {
            List<string> str = new List<string>() { "Sharana", "Basava" };
            IEnumerable<char> result = str.SelectMany(x => x);
            foreach (char c in result)
            {
                Console.Write(c + " "); //  Output : S h a r a n a B a s a v a
            }
        }
    }*/

    /*public class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public List<string> Programming { get; set; }
        public static List<Student> GetStudents()
        {
            return new List<Student>()
            {
                new Student(){ID = 1, Name = "James", Email = "James@j.com", Programming = new List<string>() { "C#", "Jave", "C++"} },
                new Student(){ID = 2, Name = "Sam", Email = "Sara@j.com", Programming = new List<string>() { "WCF", "SQL Server", "C#" }},
                new Student(){ID = 3, Name = "Patrik", Email = "Patrik@j.com", Programming = new List<string>() { "MVC", "Jave", "LINQ"} },
                new Student(){ID = 4, Name = "Sara", Email = "Sara@j.com", Programming = new List<string>() { "ADO.NET", "C#", "LINQ" } }
            };
        }

        // public static void Main(string[] args)
        // {
        //     //var SelectSyntax = Student.GetStudents().SelectMany(std => std.Programming).Distinct().ToList(); //  result with unique value
        //     var QuerySntax = (from std in Student.GetStudents()
        //                       from program in std.Programming
        //                       select program);   //  result without unique value
        //     foreach (var item in QuerySntax)
        //     {
        //         Console.WriteLine(item);
        //     }
        // }

        public static void Main(string[] args)  // joining name with programming.
        {
            var SelectSyntax = Student.GetStudents()
                            .SelectMany(std => std.Programming,
                            (student, program) => new
                            {
                                StudentName = student.Name,
                                ProgramName = program
                            }
                            ).ToList();


            var QuerySntax = (from std in Student.GetStudents()
                            from program in std.Programming
                            select new
                            {
                                StudentName = std.Name,
                                ProgramName = program
                            }).ToList();


            foreach (var item in QuerySntax)
            {
                Console.WriteLine(item.StudentName + " => " + item.ProgramName);
            }
        }

    }
}*/

// --------------------------------------------------------------------------------------------------------------------------------------------------------------

// Filtering Methods : Where, TypeOf()

/*namespace Filtering
{
    //  Where()
    /*public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Salary { get; set; }
        public List<string> Technology { get; set; }
        public static List<Employee> GetEmployees()
        {
            List<Employee> employees = new List<Employee>()
            {
                new Employee {ID = 101, Name = "Preety", Gender = "Female", Salary = 60000,
                              Technology = new List<string>() {"C#", "Jave", "C++"} },
                new Employee {ID = 102, Name = "Priyanka", Gender = "Female", Salary = 50000,
                              Technology =new List<string>() { "WCF", "SQL Server", "C#" } },
                new Employee {ID = 103, Name = "Hina", Gender = "Female", Salary = 40000,
                              Technology =new List<string>() { "MVC", "Jave", "LINQ"}},
                new Employee {ID = 104, Name = "Anurag", Gender = "Male", Salary = 450000},
                new Employee {ID = 105, Name = "Sambit", Gender = "Male", Salary = 550000},
                new Employee {ID = 106, Name = "Sushanta", Gender = "Male", Salary = 700000,
                             Technology =new List<string>() { "ADO.NET", "C#", "LINQ" }}
            };
            return employees;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //Query Syntax
            var QuerySyntax = (from employee in Employee.GetEmployees()
                               where employee.Salary >= 50000 && employee.Technology != null
                               select new
                               {
                                   EmployeeName = employee.Name,
                                   Gender = employee.Gender,
                                   MonthlySalary = employee.Salary / 12
                               }).ToList();

            //Method Syntax
            var MethodSyntax = Employee.GetEmployees()
                               .Where(emp => emp.Salary >= 50000 && emp.Technology != null)
                               .Select(emp => new
                               {
                                   EmployeeName = emp.Name,
                                   Gender = emp.Gender,
                                   MonthlySalary = emp.Salary / 12
                               })
                               .ToList();

            foreach (var emp in QuerySyntax)
            {
                Console.WriteLine($"Name : {emp.EmployeeName}, Gender : {emp.Gender}, Monthly Salary : {emp.MonthlySalary}");
            }
            Console.ReadKey();
        }
    }*/

    //  TypeOf()

    /*class Program
    {
        static void Main(string[] args)
        {
            //Data Source Contains both Integer and String Data
            List<object> dataSource = new List<object>()
            {
                "Tom", "Mary", 50, "Prince", "Jack", 10, 20, 30, 40, "James"
            };
            //Fetching only the Integer Data from the Data Source
            //using Linq Query Syntax and OfType Method
            var intData = (from num in dataSource.OfType<int>()
                              select num).ToList();
            //Print the Integer Data
            Console.WriteLine("Using OfType Method");
            foreach (int number in intData)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine("\nUsing IS Operator");
            //Fetching only the String Data from the Data Source
            //using Linq Query Syntax and is Method
            var stringData = (from name in dataSource
                              where name is string
                              select name).ToList();
            //Print the Integer Data
            foreach (string name in stringData)
            {
                Console.Write(name + " ");
            }

            //Fetching the String Names whose length is greater than 3 characters
            //Using Query Syntax with is Operator
            var stringData1 = (from name in dataSource
                              where name is string && name.ToString().Length > 3
                              select name).ToList();
            //Fetching the String Names whose length is greater than 3 characters
            //Using Query Syntax with OfType Operator
            var stringData2 = (from name in dataSource.OfType<string>()
                              where name.Length > 3
                              select name).ToList();


            Console.ReadKey();
        }
    }*/

//}


// -----------------------------------------------------------------------------------------------------------------------------------------------

// Set Operators:

/*namespace SetOperator
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[] Sequence1 = { 1, 2, 3, 4, 5, 1, 5, 3 };
            int[] Sequence2 = { 6, 7, 8, 9, 10 };

            var Distinct = Sequence1.Distinct();
            Console.Write($"Distinct : " + string.Join(", ", Distinct));

            var Union = Sequence1.Union(Sequence2);
            Console.WriteLine($"Unions: " + string.Join(", ", Union));

            var Intersect = Sequence1.Intersect(Sequence2);
            Console.WriteLine($"Intersects: " + string.Join(", ", Intersect));

            var Except = Sequence1.Except(Sequence2);
            Console.WriteLine($"Except: " + string.Join(", ", Except));

            var Concatenate = Sequence1.Concat(Sequence2);
            Console.WriteLine($"Concatenate: " + string.Join(", ", Concatenate));

            var areEqual = Sequence1.SequenceEqual(Sequence2);
            Console.WriteLine($"AreEquals : {areEqual}");
        }
    }

}*/

--------------------------------------------------------------------------
  Patterns problems
--------------------------------------------------------------------------

// using System;
//     class Program
//     {
//         static void Main()
//         {
//             pattern1(5);
            // pattern2(5);
            // pattern3(5);
            // pattern4(5);
            // pattern5(5);
            // pattern6(5);
            // pattern7(5, 1);
            // pattern8(5);


            // int n = 4;
            // int m = 5;
        
        //     for(int i=1; i<=n; i++)
        //     {
        //         for(int j=1; j <= m ; j++)
        //         {
        //             if(i==1 || j==1 || i==n || j==m)
        //             {
        //                 System.Console.Write("*");
        //             }
        //             else
        //             {
        //                 System.Console.Write(" ");
        //             }
                    
        //         }
        //             System.Console.WriteLine();
        //     }
   
        // }

        // static void pattern1(int n)
        // {
        //     for(int row=1; row<=n; row++)
        //     {
        //         for(int col=1; col <= n ; col++)
        //         {
        //             System.Console.Write("* ");
        //         }
        //             System.Console.WriteLine();
        //     }
        // }

        // static void pattern2(int n)
        // {
        //     for(int row=1; row<=n; row++)
        //     {
        //         for(int col=1; col <= row ; col++)
        //         {
        //             System.Console.Write("* ");
        //         }
        //             System.Console.WriteLine();
        //     }
        // }

        // static void pattern3(int n)
        // {
        //     for(int row=n; row>=1; row--)
        //     {
        //         for(int col=1; col <= row ; col++)
        //         {
        //             System.Console.Write("* ");
        //         }
        //             System.Console.WriteLine();
        //     }
        // }

        // static void pattern4(int n)
        // {
        //     for(int row=1; row<=n; row++)
        //     {
        //         for(int col=1; col <= n - row ; col++)
        //         {
        //             System.Console.Write(" ");
        //         }

        //         for(int col=1; col<=row; col++)
        //         {
        //             System.Console.Write("*");
        //         }
        //         System.Console.WriteLine();
        //     }
        // }

        // static void pattern5(int n)
        // {
        //     for(int row=1; row<=n; row++)
        //     {
        //         for(int col=1; col <= row ; col++)
        //         {
        //             System.Console.Write(col+" ");
        //         }
        //         System.Console.WriteLine();
        //     }
        // }

        // static void pattern6(int n)
        // {
        //     for(int row=n; row>=1; row--)
        //     {
        //         for(int col=1; col <= row ; col++)
        //         {
        //             System.Console.Write(col+" ");
        //         }
        //         System.Console.WriteLine();
        //     }
        // }

        // static void pattern7(int n, int number)
        // {
        //     for(int row=1; row<=n; row++)
        //     {
        //         for(int col=1; col <= row ; col++)
        //         {
        //             System.Console.Write(number+" ");
        //             number++;
        //         }
        //         System.Console.WriteLine();
        //     }
        // }


    //     static void pattern8(int n)
    //     {
    //         for(int row=1; row<=n; row++)
    //         {
    //             for(int col=1; col <= row ; col++)
    //             {
    //                 int sum = row + col ;
    //                 if(sum % 2 == 0)
    //                 {
    //                     System.Console.Write("1 ");
    //                 }
    //                 else
    //                 {
    //                     System.Console.Write("0 ");
    //                 }
                    
    //             }
    //             System.Console.WriteLine();
    //         }
    //     }

    //     }
    // }

---------------------------------------------------------------------------
Bangar Raju Notes
---------------------------------------------------------------------------

// // Structure
using System;
using System.Data.SqlTypes;
using System.Diagnostics.CodeAnalysis;
using System.Security.Cryptography.X509Certificates;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Threading;
using System.Threading.Tasks;

// namespace DemoProject
// {
//     struct MyStruct
//     {
//         public void display()
//         {
//             Console.WriteLine("Methods in a class");
//         }
//         public static void Main()
//         {
//             MyStruct m1 = new MyStruct();
//             m1.display();
//         }
//     }
// }

// // Enumerable or Enum Types
// using System;
// namespace DemoProject
// {
//     public enum Days
//     {
//         // Monday, Tuesday, Wednesday, Thursday, Friday     || OR ||
//         Monday,
//         Tuesday,
//         Wednesday,
//         Thursday,
//         Friday
//     }

//     class Testclass
//     {
//         public static Days MeetingDate
//         {
//             get; set;
//         } = Days.Monday;
//         static void Main()
//         {
//             // Days d = 0;
//             // Days d = Days.Monday;
//             // Console.WriteLine(d);

//             // foreach(int i in Enum.GetValues(typeof(Days)))
//             //     Console.WriteLine(i + ": " + (Days)i);
//             // foreach(string s in Enum.GetNames(typeof(Days)))
//             //     Console.WriteLine(s);

//             System.Console.WriteLine(MeetingDate);
//             MeetingDate = Days.Thursday;
//             System.Console.WriteLine(MeetingDate);
//         }
//     }
// }


//  // Properties in C#
// public class Circle
// {
//     double Radius = 12.45;
//     public double _Radius
//     {
//         get{return Radius;}
//         set{Radius = value;}
//     }
// }
// public class TestCircle
// {
//     static void Main()
//     {
//         Circle c = new Circle();
//         double radius = c._Radius; 
//     }
// }

// // Part - 2 
// using System;
// namespace DemoProject
// {

//     public class Customer
//     {
//         int _Custid;
//         bool _Status;
//         string _Cname;
//         double _Balance;

//         public Customer(int Custid, bool Status, string Cname, double Balance)
//         {
//             this._Custid = Custid;
//             this._Status = Status;
//             this._Cname = Cname;
//             this._Balance = Balance;
//         }

//         public int Custid
//         {
//             get{return _Custid;}
//             set{_Custid = value;}
//         }

//         public bool Status
//         {
//             get{return _Status;}
//             set{_Status = value;}
//         }

//         public string Cname
//         {
//             get{return _Cname;}
//             set{_Cname = value;}
//         }

//         public double Balance
//         {
//             get{return _Balance;}
//             set{_Balance = value;}
//         }
//     }

//     class TestCustomer
//     {
//         public static void Main()
//         {
//             Customer obj = new Customer(101, true, "Sharan", 10000);
//             Console.WriteLine("Customer ID: " +obj.Custid);
//             // obj.Custid = 102;        Can't be assigned as the property is read only.

//             Console.WriteLine("Customer current status : " +obj.Status);

//             Console.WriteLine("Customer Cname: " +obj.Cname);
//             obj.Cname += "Basava";
//             Console.WriteLine("Customer modified name: " +obj.Cname);

//             Console.WriteLine("Customer Balance: " +obj.Balance);
//             obj.Balance -= 2000;
//             System.Console.WriteLine("Customer current balance: " +obj.Balance);
//         }
//     }
// }


// Indexers :

// using System;
// namespace DemoProject
// {
//     class TestEmployee
//     {
//         static void Main()
//         {
//             Employee Emp = new Employee(1001, "Sharan", 10000.00, "Analyst", "IT", "Pune");
//             System.Console.WriteLine("Eno: " +Emp[0]);
//             System.Console.WriteLine("Ename: " +Emp[1]);
//             System.Console.WriteLine("Salary: " +Emp[2]);
//             System.Console.WriteLine("Job: " +Emp[3]);
//             System.Console.WriteLine("Dname: " +Emp[4]);
//             System.Console.WriteLine("Location: " +Emp[5]);

//             System.Console.WriteLine("-----------------------------------");

//             Emp[0] = 1005;
//             Emp[1] = "Basava";
//             Emp[2] = 25000.00;
//             Emp[3] = "Sales";
//             Emp[4] = "Production";
//             Emp[5] = "Bengaluru";

//             System.Console.WriteLine("Eno: " +Emp[0]);
//             System.Console.WriteLine("Ename: " +Emp[1]);
//             System.Console.WriteLine("Salary: " +Emp[2]);
//             System.Console.WriteLine("Job: " +Emp[3]);
//             System.Console.WriteLine("Dname: " +Emp[4]);
//             System.Console.WriteLine("Location: " +Emp[5]);

//             Console.ReadLine();
//         }
//     }
//     public class Employee
//     {
//         int Eno;
//         double Salary;
//         string Ename, Job, Dname, Location;

//         public Employee(int Eno, string Ename, double Salary, string Job, string Dname, string Location)
//         {
//             this.Eno = Eno;
//             this.Ename = Ename;
//             this.Salary = Salary;
//             this.Job = Job;
//             this.Dname = Dname;
//             this.Location = Location;
//         }

//         public object this[int index]
//         {
//             get
//             {
//                 if(index == 0)
//                     return Eno;
//                 else if(index == 1)
//                     return Ename;
//                 else if(index == 2)
//                     return Salary;
//                 else if(index == 3)
//                     return Job;
//                 else if(index == 4)
//                     return Dname;
//                 else if(index == 5)
//                     return Location;
//                 return null;   
//             }
//             set
//             {
//                 if(index == 0)
//                     Eno = (int)value;
//                 else if(index == 1)
//                     Ename = (string)value;
//                 else if(index == 2)
//                     Salary = (double)value;
//                 else if(index == 3)
//                     Job = (string)value;
//                 else if(index == 4)
//                     Dname = (string)value;
//                 else if(index == 5)
//                     Location = (string)value;
//             }
//         }
//     }
// }


// // Deligates Part-1

// using System;
// namespace DeligateProject
// {
//     public delegate void AddDelegate(int x, int y);
//     public delegate string SayDelegate(string str);
//     class Program
//     {
//         public void AddNumbers(int a, int b)
//         {
//             System.Console.WriteLine(a + b);
//         }
//         public static string SayHello(string name)
//         {
//             return "Hello: " + name;
//         }
//     }

//     class TestProgram
//     {
//         static void Main(String[] args)
//         {
//             Program p = new Program();
//             AddDelegate ad = new AddDelegate(p.AddNumbers);
//             ad.Invoke(100, 50);

//             SayDelegate sd = new SayDelegate(Program.SayHello);
//             string str = sd.Invoke("Sharan");
//             System.Console.WriteLine(str);
//         }
//     }
// }


// Extension Methods
//  defn :- Its a mechanism of adding new methods into existing class or structure without madifying the sourse code 
//          of a orginal and this process we dont required any permission from original type.


// using System;
// namespace ExtensionMethods
// {
//     public class Program
//     {
//          static void Main(String[] args)
//         {
//             Program p = new Program();
//             p.Test1();
//             p.Test2();
//             p.Test3();
//         }

//         public void Test1()
//         {
//             System.Console.WriteLine("Method 1");
//         }

//         public void Test2()
//         {
//             System.Console.WriteLine("Method 2");
//         }

//     }

// // namespace ExtensionMethods1

//     public static class ProgramExtensions
//     {
//         public static void Test3(this Program p)
//         {
//             System.Console.WriteLine("Method 3");
//         }

//     }

// }

// using System;

// class Program
// {
//     public static int factorial(int n)
//     {
//         if (n <= 1)
//             return 1;
//         else
//             return n * factorial(n-1);
//     }

//     public static void Main()
//     {
//         Console.Write("Enter a number to find its factorial: ");
//         int num = Convert.ToInt32(Console.ReadLine());
//         int result = factorial(num);
//         System.Console.WriteLine(result);
//     }
// }


//  Difference between String and String builder

// Strings are immutable, StringBUilder is mutable
// Syntax = StringBuilder sb = new StringBuilder();
// sb.Append();


// // Exception handling

// // Try : 1) Add those statements which will cause run time error.
// //       2) Add those statements which does not require execution when the run time error occured.

// // Catch : 1) Add those statements which should excecute only when there is a run time error.

// using System;
// class ExceptionHandling
// {
//     static void Main()
//     {
//         try
//         {
//             System.Console.WriteLine("Enter 1st number : ");
//             int x = int.Parse(Console.ReadLine());

//             System.Console.WriteLine("Enter 2nd number : ");
//             int y = int.Parse(Console.ReadLine());

//             int z = x / y;
//             System.Console.WriteLine("The result is : " +z);
//         }

//         catch(DivideByZeroException ex)
//         {
//             Console.WriteLine(ex.Message);
//         }
//         catch(FormatException ex2)
//         {
//             Console.WriteLine(ex2.Message);
//         }
//         catch(Exception ex)  // this is use when the error was not above erros. It will call all the remaining exception.
//         {
//             Console.WriteLine(ex.Message);
//         }

//         finally
//         {
//             System.Console.WriteLine("Finally block is excecuted.");
//         }

//         Console.ReadKey();
//     }
// }

// //  Deligates :- 
// //  A delegate is a variable that holds referance to a methods or a pointer to a method.
// //  A deleagte can refer to amore than one methods of the same return type and paramter.
// //  When we need to pass method as parameter we use delegates.
// //  Multicast delegates : It is a delgate that holds the reference of more than one functions.

// using System;

// delegate void Calculator(int x, int y);
// class Program
// {
//     public static void Add(int a, int b)
//     {
//         System.Console.WriteLine(a + b);
//     }
//     public static void Mul(int a, int b)
//     {
//         System.Console.WriteLine(a * b);
//     }

//     static void Main(String[] args)
//     {
//         Calculator cal = new Calculator(Add);
//         cal(20, 30);
//         Mul(10, 10);

//         //cal += Mul; // Multicast delegates : It is a delgate that holds the reference of more than one functions.
//     }
// }


//  Multiple Threading : All methods will get equal importance to excecute. All methods will excecutes simultaniously. Advantage is max utilisation of CPU.
//  Disadvantage of single Threading : Single theraded application, Action will completed one after another. so if we want to see the result of nth task, we need to wait for excecuting (n-1) task.
//  Thread priority : Lowest --> Below Normal --> Normal(default) --> Above Normal --> Highest
//  t1.Priority = ThreadPriority.Lowest;
//  t2.Priority = ThreadPriority.Highest;
//  Joining Threading :- T1.join();  T2.join();

// using System;
// class Threadtest
// {
//     static void Test1()
//     {
//         lock(this)   // It will keep this method results in same region.
//         {
//              for(int i=0; i<=100; i++)
//              {
//                  System.Console.WriteLine("Test1: " +i);
//              }
//              System.Console.WriteLine("Thread1 is exiting");
//         }
//     }

//     static void Test2()
//     {
//         for(int i=0; i<=100; i++)
//         {
//             System.Console.WriteLine("Test2: " +i);

//         if(i == 50)
//         {
//             System.Console.WriteLine("Thread 2 is going to sleep");
//             Thread.Sleep(15000);
//             System.Console.WriteLine("Thread 2 is wake up");
//         }
//         }
//         System.Console.WriteLine("Thread2 is exiting");
//     }

//     static void Test3()
//     {
//         for(int i=0; i<=100; i++)
//         {
//             System.Console.WriteLine("Test3: " +i);
//         }
//         System.Console.WriteLine("Thread3 is exiting");
//     }

//     static void Main()
//     {
//         Thread T1 = new Thread(Test1);
//         Thread T2 = new Thread(Test2);
//         Thread T3 = new Thread(Test3);
//         System.Console.WriteLine("Thread main is exiting");

//         T1.Start(); T2.Start(); T3.Start();

// ThreadStart obj = new ThreadStart(Test1);    // By using Delegate method
// Thread t = new Thread(obj);
// Test1();
//     }

// }

//  Task Program parallelism (TPL)

// namespace TPL
// {
//     class Program
//     {
//         public static void Main(String[] args)
//         {
//             Task taskOne = new Task(AnotherTask);
//             taskOne.Start();

//             Task taskTwo = new Task(() =>
//             {
//                 for (int counter = 1; counter <= 5; counter++)
//                 {
//                     Thread.Sleep(1000);
//                     Console.WriteLine($"Task 2 counter = {counter} Thread ID = {Thread.CurrentThread.ManagedThreadId}");
//                 }
//             });
//             taskTwo.Start();
//             // Makes the main thread to wait untill all the child thread complete its task.
//             taskOne.Wait();
//             taskTwo.Wait();
//             Console.WriteLine($"Program terminated with the thread id {Thread.CurrentThread.ManagedThreadId}");
//         }

//         static void AnotherTask()
//         {
//             for (int counter = 1; counter <= 5; counter++)
//             {
//                 Thread.Sleep(1000);
//                 Console.WriteLine($"Task 1 counter = {counter} Thread ID = {Thread.CurrentThread.ManagedThreadId}");
//             }
//         }
//     }
// }


// Collections : These are Non-Generics.

// Generic Collection : It is type safe and Auto resizing(Dynamically).
// Non Generic Collections : Stack, Queue, LinkedList, SortedList, ArrayList, Hashtable

// int[] arr = new int[50];
// ArrayList al = new ArrayList();
// al.Add(100);    // Elements will add to list

// using System;
// using System.Collections;
// using System.Collections.Generic;
// class Program
// {
//     ArrayList
//     public static void Main()
//     {
//         ArrayList al = new ArrayList();
//         al.Add(100); al.Add(200); al.Add(300); al.Add(400); al.Add(500);
//         al.Insert(2,250);
//         al.Remove(500);
//         foreach(object obj in al)
//         System.Console.Write(obj + " ");
//         Console.ReadKey();
//     }

//     HashTable : Key and Value Combination.
//     static void Main()
//     {
//         Hashtable ht = new Hashtable();
//         ht.Add("Eid", 1010);
//         ht.Add("Ename", "Deepak");
//         ht.Add("Job", "Manager");
//         ht.Add("Salary", 25000);
//         ht.Add("Mgrid", 1002);
//         ht.Add("Phone", 1234567890);
//         ht.Add("Emailid", "Deepak@gmail.com");
//         ht.Add("Dname", "IT");
//         ht.Add("Location", "Pune");
//         ht.Add("Did", 20);

//         foreach(object key in ht.Keys)
//         // System.Console.WriteLine(key);
//         System.Console.WriteLine(key + ": " +ht[key]);
//     }

    // Generic Collections
    
    // static void Main()
    // {
    //     List<int> li = new List<int>();
    //     li.Add(10); li.Add(20); li.Add(30); li.Add(40); li.Add(50);
    //     li.Insert(3, 35);
    //     li.Remove(1);
    //     for(int i=0; i < li.Count; i++)
    //     System.Console.WriteLine(li[i]);
    // }

    // public bool Compare<T>(T a, T b)    // Generic collection define <T>, Generic implemented only to method.
    // {
    //     if(a.Equals(b))
    //         return true;
    //     return false;
    // }

    // static void Main()
    // {
    //     Program p = new Program();
    //     bool result1 = p.Compare<float>(12.56f, 12.56f);     // Generic collection define <T> = <float>
    //     System.Console.WriteLine(result1);

    //     bool result2 = p.Compare<int>(12, 12);     // Generic collection define <T> = <int>
    //     System.Console.WriteLine(result2);
    // }

//     class Generics2<T>      // Genric collection define to class
//     {
//         public void Add(T a, T b)
//         {
//             dynamic d1 = a;
//             dynamic d2 = b;
//             System.Console.WriteLine(d1 + d2);
//         }
//         public void Sub(T a, T b)
//         {
//             dynamic d1 = a;
//             dynamic d2 = b;
//             System.Console.WriteLine(d1 - d2);
//         }
//         public void Mul(T a, T b)
//         {
//             dynamic d1 = a;
//             dynamic d2 = b;
//             System.Console.WriteLine(d1 * d2);
//         }
//         public void Devide(T a, T b)
//         {
//             dynamic d1 = a;
//             dynamic d2 = b;
//             System.Console.WriteLine(d1 / d2);
//         }
//     }
//     static void Main()
//     {
//         Generics2<int> obj = new Generics2<int>();
//         obj.Add(10, 20); obj.Sub(30, 20); obj.Mul(10, 10); obj.Devide(20, 4);
//     }


//      In Generic Collections HashTable are used as Dictionary
    // class DictionaryCollections
    // {
    //     static void Main()
    //     {
    //         Dictionary<String, object> dt = new Dictionary<string, object>();
    //         dt.Add("Eid", 1010);
    //         dt.Add("Ename", "Deepak");
    //         dt.Add("Job", "Manager");
    //         dt.Add("Salary", 25000);
    //         dt.Add("Mgrid", 1002);
    //         dt.Add("Phone", 1234567890);
    //         dt.Add("Emailid", "Deepak@gmail.com");
    //         dt.Add("Dname", "IT");
    //         dt.Add("Location", "Pune");
    //         dt.Add("Did", 20);

    //         foreach(string key in dt.Keys)
    //         System.Console.WriteLine(key + ": " + dt[key]);

    //     }
    // }

// }


----------------------------------------------------------------------------------------
Bro codes Notes
---------------------------------------------------------------------------------------

// class Program
//     {
//         static void Main(string[] args)
//         {
//             Console.WriteLine("I like pizza!");
//             Console.WriteLine("It's really good!");
//         }
//     }



// class Program
//     {
//         static void Main(string[] args)
//         {
//             Console.Write("Hey!");
//             Console.WriteLine("Hello!");

//             //This is a comment
//             /*
//              * this
//              * is
//              * a
//              * multiline
//              * comment
//              */

//             Console.WriteLine("\tBro\nCode");

//             Console.ReadKey();
//         }
//     }


// class Program
//     {
//         static void Main(string[] args)
//         {
//             int x; // declaration
//             x = 123; // initialization

//             int y = 321; // declaration + initialization

//             int z = x + y;

//             int age = 21; // whole integer
//             double height = 300.5; // decimal number
//             bool alive = false; //true or false
//             char symbol = '@'; // single character
//             String name = "Bro"; // a series of characters

//             Console.WriteLine("Hello " + name);
//             Console.WriteLine("Your age is " + age);
//             Console.WriteLine("Your height is " + height + "cm");
//             Console.WriteLine("Are you alive? " + alive);
//             Console.WriteLine("Your symbol is: " + symbol);

//             String userName = symbol + name;

//             Console.WriteLine("Your username is: " + userName);

//             Console.ReadKey();
//         }
//     }


// class Program
//     {
//         static void Main(string[] args)
//         {
//             // constants  = immutable values which are known at compile time
//             //              and do not change for the life of the program

//             const double pi = 3.14;

//             //pi = 420; //can't change this constant

//             Console.WriteLine(pi);

//             Console.ReadKey();
//         }
//     }


// class Program
//     {
//         static void Main(string[] args)
//         {
//             // type casting = Converting a value to a different data type
//             //                Useful when we accept user input (string)
//             //                Different data types can do different things

//             double a = 3.14;
//             int b = Convert.ToInt32(a);

//             int c = 123;
//             double d = Convert.ToDouble(c);

//             int e = 321;
//             String f = Convert.ToString(e);

//             String g = "$";
//             char h = Convert.ToChar(g);

//             String i = "true";
//             bool j = Convert.ToBoolean(i);

//             Console.WriteLine(b.GetType());
//             Console.WriteLine(d.GetType());
//             Console.WriteLine(f.GetType());
//             Console.WriteLine(h.GetType());
//             Console.WriteLine(j.GetType());

//             Console.ReadKey();
//         }
//     }


//  class Program
//     {
//         static void Main(string[] args)
//         {
//             Console.WriteLine("What's your age?");
//             String name = Console.ReadLine();

//             Console.WriteLine("What's your age?");
//             int age = Convert.ToInt32(Console.ReadLine());  

//             Console.WriteLine("Hello " + name);
//             Console.WriteLine("You are " + age + " years old");

//             Console.ReadKey();
//         }
//     }


// class Program
//     {
//         static void Main(string[] args)
//         {
//             int friends = 5;

//             friends = friends + 1;
//             //friends += 1;
//             //friends++;

//             //friends = friends - 1;
//             //friends -= 1;
//             //friends--;

//             //friends = friends * 2;
//             //friends *= 2;

//             //friends = friends / 2;
//             //friends /= 2;

//             //int remainder = friends % 2;
//             //Console.WriteLine(remainder);

//             Console.WriteLine(friends);

//             Console.ReadKey();
//         }
//     }


// class Program
//     {
//         static void Main(string[] args)
//         {

//             double x = 3;
//             double y = 5;

//             double a = Math.Pow(x, 2);
//             double b = Math.Sqrt(x);
//             double c = Math.Abs(x);
//             double d = Math.Round(x);
//             double e = Math.Ceiling(x);
//             double f = Math.Floor(x);
//             double g = Math.Max(x, y);
//             double h = Math.Min(x, y);

//             Console.WriteLine(a);

//             Console.ReadKey();
//         }
//     }


// class Program
//     {
//         static void Main(string[] args)
//         {
//             Random random = new Random();

//             int num1 = random.Next(1, 7);
//             int num2 = random.Next(1, 7);
//             int num3 = random.Next(1, 7);

//             //double num = random.NextDouble();

//             Console.WriteLine(num1);
//             Console.WriteLine(num2);
//             Console.WriteLine(num3);

//             Console.ReadKey();
//         }
//     }


// class Program
//     {
//         static void Main(string[] args)
//         {

//             Console.WriteLine("Enter side A: ");
//             double a = Convert.ToDouble(Console.ReadLine());

//             Console.WriteLine("Enter side B: ");
//             double b = Convert.ToDouble(Console.ReadLine());

//             double c = Math.Sqrt((a * a) + (b * b));

//             Console.WriteLine("The hypotenuse is: " + c);

//             Console.ReadKey();
//         }
//     }


// class Program{
//     public static void Main(){
        
//         Console.WriteLine("Enter value of side a : ");
//         int side_A = Convert.ToInt32(Console.ReadLine());

//         Console.WriteLine("Enter value of side b : ");
//         int side_B = Convert.ToInt32(Console.ReadLine());

//         double hypo_C = Math.Sqrt(Math.Pow(side_A, 2) + Math.Pow(side_B,2));

//         Console.WriteLine("Hypotenis value is : " +hypo_C);

//         Console.ReadLine();
//     }
// }


// class Program
//     {
//         static void Main(string[] args)
//         {
//             String fullName = "Bro Code";
//             String phoneNumber = "123-456-7890";

//             //fullName = fullName.ToUpper();
//             //fullName = fullName.ToLower();
//             //Console.WriteLine(fullName);

//             //phoneNumber = phoneNumber.Replace("-","");
//             //Console.WriteLine(phoneNumber);

//             //String userName = fullName.Insert(0,"Mr.");
//             //Console.WriteLine(userName);

//             //Console.WriteLine(fullName.Length);

//             String firstName = fullName.Substring(0, 3);
//             String lastName = fullName.Substring(4, 4);

//             Console.WriteLine(firstName);
//             Console.WriteLine(lastName);

//             Console.ReadKey();
//         }
//     }


// class Program
//     {
//         static void Main(string[] args)
//         {
//             //if statement = a basic form of decision making

//             Console.WriteLine("Please enter your name: ");
//             String name = Console.ReadLine();

//             if (name == "")
//             {
//                 Console.WriteLine("You did not enter your name!");
//             }
//             else
//             {
//                 Console.WriteLine("Hello " + name);
//             }

//             Console.ReadKey();
//         }
//     }


// class Program
//     {
//         static void Main(string[] args)
//         {
//             // switch = an efficient alternative to many else if statements

//             Console.WriteLine("What day is it today?");
//             String day = Console.ReadLine();

//             switch (day)
//             {
//                 case "Monday":
//                     Console.WriteLine("It's Monday!");
//                     break;
//                 case "Tuesday":
//                     Console.WriteLine("It's Tuesday!");
//                     break;
//                 case "Wednesday":
//                     Console.WriteLine("It's Wednesday!");
//                     break;
//                 case "Thursday":
//                     Console.WriteLine("It's Thursday!");
//                     break;
//                 case "Friday":
//                     Console.WriteLine("It's Friday!");
//                     break;
//                 case "Saturday":
//                     Console.WriteLine("It's Saturday!");
//                     break;
//                 case "Sunday":
//                     Console.WriteLine("It's Sunday!");
//                     break;
//                 default:
//                     Console.WriteLine(day + " is not a day!");
//                     break;
//             }

//             Console.ReadKey();
//         }
//     }


// class Program
//     {
//         static void Main(string[] args)
//         {

//             // logical operators = Can be used to check if more than 1 condition is true/false

//             // && (AND)
//             // || (OR)

//             Console.WriteLine("What's the temperature outside: (C)");
//             double temp = Convert.ToDouble(Console.ReadLine());

//             if (temp >= 10 && temp <= 25)
//             {
//                 Console.WriteLine("It's warm outside!");
//             }
//             else if (temp <= -50 || temp >= 50)
//             {
//                 Console.WriteLine("DO NOT GO OUTSIDE!");
//             }


//             Console.ReadKey();
//         }
//     }


// class Program
//     {
//         static void Main(string[] args)
//         {

//             // while loop = repeats some code while some condition remains true

//             String name = "";

//             while (name == "")
//             {
//                 Console.Write("Enter your name: ");
//                 name = Console.ReadLine();
//             }

//             Console.WriteLine("Hello " + name);

//             Console.ReadKey();
//         }
//     }


//  class Program
//     {
//         static void Main(string[] args)
//         {

//             // for loop = repeats some code a FINITE amount of times

//             // Count up to 10
//             for (int i = 1; i <= 10; i++)
//             {
//                 Console.WriteLine(i);
//             }
               
//             // Count down from 10
//             for (int i = 10; i > 0; i--)
//             {
//                 Console.WriteLine(i);
//             }
//             Console.WriteLine("HAPPY NEW YEAR!");

//             Console.ReadKey();
//         }
//     }


// class Program
//     {
//         static void Main(string[] args)
//         {
//             // nested loops = loops inside of other loops
//             //                Uses vary. Used a lot in sorting algorithms

//             Console.Write("How many rows?: ");
//             int rows = Convert.ToInt32(Console.ReadLine());

//             Console.Write("How many columns?: ");
//             int columns = Convert.ToInt32(Console.ReadLine());

//             Console.Write("What symbol: ");
//             String symbol = Console.ReadLine();

//             for (int i = 0; i < rows; i++)
//             {
//                 for (int j = 0; j < columns; j++)
//                 {
//                     Console.Write(symbol);
//                 }
//                 Console.WriteLine();
//             }

//             Console.ReadKey();
//         }
//     }


// class Program
//     {
//         static void Main(string[] args)
//         {
//             Random random = new Random();
//             bool playAgain = true;
//             int min = 1;
//             int max = 100;
//             int guess;
//             int number;
//             int guesses;
//             String response;

//             while (playAgain)
//             {
//                 guess = 0;
//                 guesses = 0;
//                 response = "";
//                 number = random.Next(min, max + 1);

//                 while (guess != number)
//                 {
//                     Console.WriteLine("Guess a number between " + min + " - " + max + " : ");
//                     guess = Convert.ToInt32(Console.ReadLine());
//                     Console.WriteLine("Guess: " + guess);

//                     if (guess > number)
//                     {
//                         Console.WriteLine(guess + " is to high!");
//                     }
//                     else if (guess < number)
//                     {
//                         Console.WriteLine(guess + " is to low!");
//                     }
//                     guesses++;
//                 }
//                 Console.WriteLine("Number: " + number);
//                 Console.WriteLine("YOU WIN!");
//                 Console.WriteLine("Guesses: " + guesses);

//                 Console.WriteLine("Would you like to play again (Y/N): ");
//                 response = Console.ReadLine();
//                 response = response.ToUpper();

//                 if (response == "Y")
//                 {
//                     playAgain = true;
//                 }
//                 else
//                 {
//                     playAgain = false;
//                 }
//             }

//             Console.WriteLine("Thanks for playing! ... I guess");

//             Console.ReadKey();
//         }
//    }


// class Program
//     {
//         static void Main(string[] args)
//         {
//             Random random = new Random();
//             bool playAgain = true;
//             String player;
//             String computer;
//             String answer;

//             while (playAgain)
//             {
//                 player = "";
//                 computer = "";
//                 answer = "";

//                 while (player != "ROCK" && player != "PAPER" && player != "SCISSORS") {
//                     Console.Write("Enter ROCK, PAPER, or SCISSORS: ");
//                     player = Console.ReadLine();
//                     player = player.ToUpper();
//                 }

                
//                 switch (random.Next(1, 4))
//                 {
//                     case 1:
//                         computer = "ROCK";
//                         break;
//                     case 2:
//                         computer = "PAPER";
//                         break;
//                     case 3:
//                         computer = "SCISSORS";
//                         break;
//                 }

//                 Console.WriteLine("Player: " + player);
//                 Console.WriteLine("Computer: " + computer);

//                 switch (player)
//                 {
//                     case "ROCK":
//                         if (computer == "ROCK")
//                         {
//                             Console.WriteLine("It's a draw!");
//                         }
//                         else if (computer == "PAPER")
//                         {
//                             Console.WriteLine("You lose!");
//                         }
//                         else
//                         {
//                             Console.WriteLine("You win!");
//                         }
//                         break;
//                     case "PAPER":
//                         if (computer == "ROCK")
//                         {
//                             Console.WriteLine("You win!");
//                         }
//                         else if (computer == "PAPER")
//                         {
//                             Console.WriteLine("It's a draw!");
//                         }
//                         else
//                         {
//                             Console.WriteLine("You lose!");
//                         }
//                         break;
//                     case "SCISSORS":
//                         if (computer == "ROCK")
//                         {
//                             Console.WriteLine("You lose!");
//                         }
//                         else if (computer == "PAPER")
//                         {
//                             Console.WriteLine("You win!");
//                         }
//                         else
//                         {
//                             Console.WriteLine("It's a draw!");
//                         }
//                         break;
//                 }

//                 Console.Write("Would you like to play again (Y/N): ");
//                 answer = Console.ReadLine();
//                 answer = answer.ToUpper();

//                 if (answer == "Y")
//                 {
//                     playAgain = true;
//                 }
//                 else
//                 {
//                     playAgain = false;
//                 }
                
//             }

//             Console.WriteLine("Thanks for playing!");

//             Console.ReadKey();
//         }
//     }


// class Program
//     {
//         static void Main(string[] args)
//         {
//             do
//             {
//                 double num1 = 0;
//                 double num2 = 0;
//                 double result = 0;

//                 Console.WriteLine("------------------");
//                 Console.WriteLine("Calculator Program");
//                 Console.WriteLine("------------------");

//                 Console.Write("Enter number 1: ");
//                 num1 = Convert.ToDouble(Console.ReadLine());

//                 Console.Write("Enter number 2: ");
//                 num2 = Convert.ToDouble(Console.ReadLine());

//                 Console.WriteLine("Enter an option: ");
//                 Console.WriteLine("\t+ : Add");
//                 Console.WriteLine("\t- : Subtract");
//                 Console.WriteLine("\t* : Multiply");
//                 Console.WriteLine("\t/ : Divide");
//                 Console.Write("Enter an option: ");


//                 switch (Console.ReadLine())
//                 {
//                     case "+":
//                         result = num1 + num2;
//                         Console.WriteLine($"Your result: {num1} + {num2} = " + result);
//                         break;
//                     case "-":
//                         result = num1 - num2;
//                         Console.WriteLine($"Your result: {num1} - {num2} = " + result);
//                         break;
//                     case "*":
//                         result = num1 * num2;
//                         Console.WriteLine($"Your result: {num1} * {num2} = " + result);
//                         break;
//                     case "/":
//                         result = num1 / num2;
//                         Console.WriteLine($"Your result: {num1} / {num2} = " + result);
//                         break;
//                     default:
//                         Console.WriteLine("That was not a valid option");
//                         break;
//                 }
//                 Console.Write("Would you like to continue? (Y = yes, N = No): ");
//             } while (Console.ReadLine().ToUpper() == "Y");

//             Console.WriteLine("Bye!");
//             Console.ReadKey();
//         }
//     }


// class Program
//     {
//         static void Main(string[] args)
//         {
//             // array = a variable that can store multiple values. fixed size

//             //String[] cars = {"BMW", "Mustang", "Corvette"};

//             String[] cars = new string[3];

//             cars[0] = "Tesla";
//             cars[1] = "Mustang";
//             cars[2] = "Corvette";

//             for (int i = 0; i < cars.Length; i++)
//             {
//                 Console.WriteLine(cars[i]);
//             }

//             Console.ReadKey();
//         }
//     }


// class Program
//     {
//         static void Main(string[] args)
//         {
//             // foreach loop = a simpler way to iterate over an array, but it's less flexible

//             String[] cars = {"BMW", "Mustang", "Corvette"};

//             foreach (String car in cars)
//             {
//                 Console.WriteLine(car);
//             }

//             Console.ReadKey();
//         }
//     }


// class Program
//     {
//         static void Main(string[] args)
//         {
//             // method  = performs a section of code, whenever it's called "invoked".
//             //           benefit = Let's us reuse code w/o writing it multiple times
//             //           Good practice is to capitalize method names (I forgot in this video)

//             String name = "Bro";
//             int age = 21;

//             SingHappyBirthday(name, age);

//             Console.ReadKey();
//         }
//         static void SingHappyBirthday(String name, int age)
//         {
//             Console.WriteLine("Happy birthday to you!");
//             Console.WriteLine("Happy birthday to you!");
//             Console.WriteLine("Happy birthday dear " + name);
//             Console.WriteLine("You are " + age + " years old!");
//             Console.WriteLine("Happy birthday to you!");
//             Console.WriteLine();
//         }
//     }


//  class Program
//     {
//         static void Main(string[] args)
//         {
//             // return  = returns data back to the place where a method is invoked

//             double x;
//             double y;
//             double result;

//             Console.WriteLine("Enter in number 1: ");
//             x = Convert.ToDouble(Console.ReadLine());

//             Console.WriteLine("Enter in number 2: ");
//             y = Convert.ToDouble(Console.ReadLine());

//             result = Multiply(x, y);

//             Console.WriteLine(result);

//             Console.ReadKey();
//         }
//         static double Multiply(double x, double y)
//         {
//             return x * y;
//         }
//     }


// class Program
//     {
//         static void Main(string[] args)
//         {
//             // method overloading  = methods share same name, but different parameters
//             //                       name + parameters = signature
//             //                       methods must have a unique signature

//             double total;
            
//             total = Multiply(2, 3, 4);

//             Console.WriteLine(total);
//             Console.ReadKey();
//         }

//         static double Multiply(double a, double b)
//         {      
//             return a * b;
//         }
//         static double Multiply(double a, double b, double c)
//         {
//             return a * b * c;
//         }
//     }


// class Program
//     {
//         static void Main(string[] args)
//         {
//             //params keyword = a method parameter that takes a variable number of arguments.
//             //                 The parameter type must be a single - dimensional array

//             double total = CheckOut(3.99, 5.75, 15, 1.00, 10.25);

//             Console.WriteLine(total);
//             Console.ReadKey();
//         }

//         static double CheckOut(params double[] prices)
//         {
//             double total = 0;

//             foreach (double price in prices)
//             {
//                 total += price;
//             }
//             return total;
//         }
//     }


// class Program
//     {
//         static void Main(string[] args)
//         {
//             // exception = errors that occur during execution

//             //        try     = try some code that is considered "dangerous"
//             //        catch   = catches and handles exceptions when they occur
//             //        finally = always executes regardless if exception is caught or not

//             int x;
//             int y;
//             double result;

//             try
//             {
//                 Console.Write("Enter number 1: ");
//                 x = Convert.ToInt32(Console.ReadLine());

//                 Console.Write("Enter number 2: ");
//                 y = Convert.ToInt32(Console.ReadLine());

//                 result = x / y;

//                 Console.WriteLine("result: " + result);
//             }
//             catch (FormatException e)
//             {
//                 Console.WriteLine("Enter ONLY numbers PLEASE!");
//             }
//             catch (DivideByZeroException e)
//             {
//                 Console.WriteLine("You can't divide by zero! IDIOT!");
//             }
//             catch (Exception e)
//             {
//                 Console.WriteLine("Something went wrong!");
//             }
//             finally
//             {
//                 Console.WriteLine("Thanks for visiting!");
//             }

//             Console.ReadKey();
//         }
//     }


// class Program
//     {
//         static void Main(string[] args)
//         {
//             // conditional operator = used in conditional assignment if a condition is true/false

//             //(condition) ? x : y

//             double temperature = 20;
//             String message;

//             message = (temperature >= 15) ? "It's warm outside!" : "It's cold outside!";

//             Console.WriteLine(message);

//             Console.ReadKey();
//         }
//     }


// class Program
//     {
//         static void Main(string[] args)
//         {
//             // string interpolation = allows us to insert variables into a string literal
//             //                        precede a string literal with $
//             //                        {} are placeholders

//             String firstName = "Bro";
//             String lastName = "Code";
//             int age = 21;

//             Console.WriteLine($"Hello {firstName} {lastName}.");
//             Console.WriteLine($"You are {age,-10} old.");

//             Console.ReadKey();
//         }
//     }


// class Program 
//     {
//         static void Main(string[] args)
//         {

//             String[,] parkingLot = { { "Mustang", "F-150", "Explorer" }, 
//                                                    { "Corvette", "Camaro", "Silverado" }, 
//                                                    { "Corolla", "Camry", "Rav4" } 
//                                                  };

//             parkingLot[0, 2] = "Fusion";
//             parkingLot[2, 0] = "Tacoma";
//             /*
//             foreach(String car in parkingLot)
//             {
//                 Console.WriteLine(car);
//             }
//             */
//             for(int i = 0; i < parkingLot.GetLength(0); i++)
//             {
//                 for (int j = 0; j < parkingLot.GetLength(1); j++)
//                 {
//                     Console.Write(parkingLot[i, j] + " ");
//                 }
//                 Console.WriteLine();
//             }

//             Console.ReadKey();
//         }
//     }


// class Program
//     {
//         static void Main(string[] args)
//         {
//             // class = A bundle of related code.
//             //              Can be used as a blueprint to create objects (OOP)
            
//             Messages.Hello();
//             Messages.Waiting();
//             Messages.Bye();

//             Console.ReadKey();
//         }
//     }
//     static class Messages
//     {
//         public static void Hello()
//         {
//             Console.WriteLine("Hello! Welcome to the program");
//         }
//         public static void Waiting()
//         {
//             Console.WriteLine("I am waiting for something");
//         }
//         public static void Bye()
//         {
//             Console.WriteLine("Bye! Thanks for visiting");
//         }
//     }


// class Program
//     {
//         static void Main(string[] args)
//         {
//             // object = An instance of a class
//             //          A class can be used as a blueprint to create objects (OOP)
//             //          objects can have fields & methods (characteristics & actions)

//             Human human1 = new Human();
//             Human human2 = new Human();

//             human1.name = "Rick";
//             human1.age = 65;

//             human2.name = "Morty";
//             human2.age = 16;

//             human1.Eat();
//             human1.Sleep();

//             human2.Eat();
//             human2.Sleep();

//             Console.ReadKey();
//         }
//     }
//     class Human
//     {
//         public String name;
//         public int age;

//         public void Eat()
//         {
//             Console.WriteLine(name + " is eating");
//         }
//         public void Sleep()
//         {
//             Console.WriteLine(name + " is sleeping");
//         }
//     }


// class Program
//     {
//         static void Main(string[] args)
//         {
//             // constructor = A special method in a class
//             //               Same name as the class name
//             //               Can be used to assign arguments to fields when creating an object

//             Car car1 = new Car("Ford", "Mustang", 2022, "red");
//             Car car2 = new Car("Chevy", "Corvette", 2021, "blue");

//             car1.Drive();
//             car2.Drive();

//             Console.ReadKey();
//         }
//     }
//     class Car
//     {
//         String make;
//         String model;
//         int year;
//         String color;

//         public Car(String make, String model, int year, String color)
//         {
//             this.make = make;
//             this.model = model;
//             this.year = year;
//             this.color = color;
//         }

//         public void Drive()
//         {
//             Console.WriteLine("You drive the " + make + " " + model);
//         }
//     }


// class Program
//     {
//         static void Main(string[] args)
//         {
//             // static = modifier to declare a static member, which belongs to the class itself
//             //          rather than to any specific object

//             Car car1 = new Car("Mustang");
//             Car car2 = new Car("Corvette");
//             Car car3 = new Car("Lambo");

//             Console.WriteLine(Car.numberOfCars);
//             Car.StartRace();

//             Console.ReadKey();
//         }
//     }
//     class Car
//     {
//         String model;
//         public static int numberOfCars;

//         public Car(String model)
//         {
//             this.model = model;
//             numberOfCars++;
//         }

//         public static void StartRace()
//         {
//             Console.WriteLine("The race has begun!");
//         }
//     }


// class Program
//     {
//         static void Main(string[] args)
//         {
//             // overloaded constructors = technique to create multiple constructors,
//             //                           with a different set of parameters.
//             //                           name + parameters = signature

//             Pizza pizza = new Pizza("stuffed crust", "red sauce", "mozzarella");

//             Console.ReadKey();
//         }   
//     }
//     class Pizza
//     {
//         String bread;
//         String sauce;
//         String cheese;
//         String topping;

//         public Pizza(String bread)
//         {
//             this.bread = bread;
//         }
//         public Pizza(String bread, String sauce)
//         {
//             this.bread = bread;
//             this.sauce = sauce;
//         }
//         public Pizza(String bread, String sauce, String cheese)
//         {
//             this.bread = bread;
//             this.sauce = sauce;
//             this.cheese = cheese;
//         }
//         public Pizza(String bread, String sauce, String cheese, String topping)
//         {
//             this.bread = bread;
//             this.sauce = sauce;
//             this.cheese = cheese;
//             this.topping = topping;
//         }
//     }


// class Program
//     {
//         static void Main(string[] args)
//         {
//             // inheritance = 1 or more child classes recieving fields, methods, etc. from a common parent

//             Car car = new Car();
//             Bicycle bicycle = new Bicycle();
//             Boat boat = new Boat();

//             Console.WriteLine(car.speed);
//             Console.WriteLine(car.wheels);
//             car.go();

//             Console.WriteLine(bicycle.speed);
//             Console.WriteLine(bicycle.wheels);
//             bicycle.go();

//             Console.WriteLine(boat.speed);
//             Console.WriteLine(boat.wheels);
//             boat.go();

//             Console.ReadKey();
//         }   
//     }
//     class Vehicle
//     {
//         public int speed = 0;

//         public void go()
//         {
//             Console.WriteLine("This vehicle is moving!");
//         }
//     }
//     class Car : Vehicle
//     {
//         public int wheels = 4;
//     }
//     class Bicycle : Vehicle
//     {
//         public int wheels = 2;
//     }
//     class Boat : Vehicle
//     {
//         public int wheels = 0;
//     }


// class Program
//     {
//         static void Main(string[] args)
//         {
//             // abstract classes =  modifier that indicates missing components or incomplete implementation

//             Car car = new Car();
//             Bicycle bicycle = new Bicycle();
//             Boat boat = new Boat();
//             //Vehicle vehicle = new Vehicle(); //can't create a vehicle object


//             Console.ReadKey();
//         }   
//     }
//     abstract class Vehicle
//     {
//         public int speed = 0;

//         public void go()
//         {
//             Console.WriteLine("This vehicle is moving!");
//         }
//     }
//     class Car : Vehicle
//     {
//         public int wheels = 4;
//         int maxSpeed = 500;
//     }
//     class Bicycle : Vehicle
//     {
//         public int wheels = 2;
//         int maxSpeed = 50;
//     }
//     class Boat : Vehicle
//     {
//         public int wheels = 0;
//         int maxSpeed = 100;
//     }


// class Program
//     {
//         static void Main(string[] args) {

//             Car[] garage = { new Car("Mustang"), new Car("Corvette"), new Car("Lambo") };

//             foreach (Car car in garage)
//             {
//                 Console.WriteLine(car.model);
//             }

//             Console.ReadKey();
//         }   
//     }
//     class Car 
//     {
//         public String model;

//         public Car(String model)
//         {
//             this.model = model;
//         }
//     }


//  class Program
//     {
//         static void Main(string[] args) {

//             Car car1 = new Car("Mustang","red");

//             Car car2 = Copy(car1);

//             Console.WriteLine(car2.color + " " + car2.model);

//             Console.ReadKey();
//         }

//         public static void ChangeColor(Car car, String color)
//         {
//             car.color = color;
//         }

//         public static Car Copy(Car car)
//         {
//             return new Car(car.model, car.color);
//         }
//     }
//     class Car 
//     {
//         public String model;
//         public String color;

//         public Car(String model, String color)
//         {
//             this.model = model;
//             this.color = color;
//         }
//     }


// class Program
//     {
//         static void Main(string[] args) {

//             //method overriding = provides a new version of a method inherited from a parent class
//             //                    inherited method must be: abstract, virtual, or already overriden
//             //                    Used with ToString(), polymorphism 

//             Dog dog = new Dog();
//             Cat cat = new Cat();

//             dog.Speak();
//             cat.Speak();

//             Console.ReadKey();
//         }
//     }
//     class Animal 
//     {
//         public virtual void Speak()
//         {
//             Console.WriteLine("The animal goes *brrr*");
//         }
//     }
//     class Dog : Animal
//     {
//         public override void Speak()
//         {
//             Console.WriteLine("The dog goes *woof*");
//         }
//     }
//     class Cat : Animal
//     {

//     }


// class Program 
//     {
//         static void Main(string[] args)
//         {

//             //ToString() = converts an object to its string representation so that it is suitable for display

//             Car car = new Car("Chevy", "Corvette", 2022, "blue");

//             Console.WriteLine(car.ToString());

//             Console.ReadKey();
//         }
//     }
//     class Car
//     {
//         String make;
//         String model;
//         int year;
//         String color;

//         public Car(String make, String model, int year, String color)
//         {
//             this.make = make;
//             this.model = model;
//             this.year = year;
//             this.color = color;
//         }
//         public override string ToString()
//         {       
//             return "This is a " + make + " " + model;
//         }
//     }


// class Program
//     {
//         static void Main(string[] args) {

//             // polymorphism = Greek word that means to "have many forms"
//             //                Objects can be identified by more than one type
//             //                Ex. A Dog is also: Canine, Animal, Organism

//             Car car = new Car();
//             Bicycle bicycle = new Bicycle();
//             Boat boat = new Boat();

//             Vehicle[] vehicles = {car, bicycle, boat};

//             foreach (Vehicle vehicle in vehicles)
//             {
//                 vehicle.Go();
//             }
           
//             Console.ReadKey();
//         }
//     }
//     class Vehicle
//     {
//         public virtual void Go()
//         {

//         }
//     }
//     class Car: Vehicle
//     {
//         public override void Go()
//         {
//             Console.WriteLine("The car is moving!");
//         }
//     }
//     class Bicycle : Vehicle
//     {
//         public override void Go()
//         {
//             Console.WriteLine("The bicycle is moving!");
//         }
//     }
//     class Boat : Vehicle
//     {
//         public override void Go()
//         {
//             Console.WriteLine("The boat is moving!");
//         }
//     }


// class Program
//     {
//         static void Main(string[] args)
//         {
//             // interface = defines a "contract" that all the classes inheriting from should follow

//             //             An interface declares "what a class should have"
//             //             An inheriting class defines "how it should do it"

//             //             benefits = security + multiple inheritance + "plug-and-play"

//             Rabbit rabbit = new Rabbit();
//             Hawk hawk = new Hawk();
//             Fish fish = new Fish();

//             rabbit.Flee();
//             hawk.Hunt();
//             fish.Flee();
//             fish.Hunt();

//             Console.ReadKey();
//         }
//         interface IPrey
//         {
//             void Flee();
//         }
//         interface IPredator
//         {
//             void Hunt();
//         }
//         class Rabbit : IPrey
//         {
//             public void Flee()
//             {
//                 Console.WriteLine("The rabbit runs away!");
//             }
//         }
//         class Hawk : IPredator
//         {
//             public void Hunt()
//             {
//                 Console.WriteLine("The hawk is searching for food!");
//             }
//         }
//         class Fish : IPrey, IPredator
//         {
//             public void Flee()
//             {
//                 Console.WriteLine("The fish swims away!");
//             }
//             public void Hunt()
//             {
//                 Console.WriteLine("The fish is searching for smaller fish!");
//             }
//         } 
//     }


// class Program 
//     {
//         static void Main(string[] args)
//         {

//             // List = data structure that represents a list of objects that can be accessed by index.
//             //        Similar to array, but can dynamically increase/decrease in size 
//             //        using System.Collections.Generic;

//             List<String> food = new List<String>();

//             food.Add("pizza");
//             food.Add("hamburger");
//             food.Add("hotdog");
//             food.Add("fries");

//             //Console.WriteLine(food[0]);
//             //Console.WriteLine(food[1]);
//             //Console.WriteLine(food[2]);
//             //Console.WriteLine(food[3]);

//             //food.Remove("fries");
//             //food.Insert(0, "sushi");
//             //Console.WriteLine(food.Count);
//             //Console.WriteLine(food.IndexOf("pizza"));
//             //Console.WriteLine(food.LastIndexOf("fries"));
//             //Console.WriteLine(food.Contains("pizza"));
//             //food.Sort();
//             //food.Reverse();
//             //food.Clear();
//             //String[] foodArray = food.ToArray();

//             foreach (String item in food)
//             {
//                 Console.WriteLine(item);
//             }

//             Console.ReadKey();
//         }
//     }


// class Program 
//     {
//         static void Main(string[] args)
//         {
//             List<Player> players = new List<Player>();

//             players.Add(new Player("Chad"));
//             players.Add(new Player("Steve"));
//             players.Add(new Player("Karen"));

//             foreach (Player player in players)
//             {
//                 Console.WriteLine(player);
//             }

//             Console.ReadKey();
//         }
//     }

//     class Player
//     {
//         public String username;

//         public Player(String username)
//         {
//             this.username = username;
//         }
//         public override string ToString()
//         {
//             return username;
//         }
//     }


// class Program
//     {
//         static void Main(string[] args)
//         {
//             //getters & setters = add security to fields by encapsulation
//             //                    They're accessors found within properties

//             // properties = combine aspects of both fields and methods (share name with a field)
//             // get accessor = used to return the property value
//             // set accessor = used to assign a new value
//             // value keyword = defines the value being assigned by the set (parameter)
            
//             Car car = new Car(400);

//             car.Speed = 1000000000;

//             Console.WriteLine(car.Speed);

//             Console.ReadKey();
//         }   
//     }
//     class Car
//     {
//         private int speed;

//         public Car(int speed)
//         {
//             Speed = speed;
//         }

//         public int Speed
//         {
//             get { return speed; }
//             set                   
//             {
//                 if (value > 500)
//                 {
//                     speed = 500;
//                 }
//                 else
//                 {
//                     speed = value;
//                 }
//             }
//         }

//     }


// class Program 
//     {
//         static void Main(string[] args)
//         {
//             // auto-Implemented property =  shortcut when no additional logic is required in the property
//             //                                you do not have to define a field for a property,
//             //                                you only have to write get; and/or set; inside the property                             

//             Car car = new Car("Porsche");

//             Console.WriteLine(car.Model);

//             Console.ReadKey();
//         }
//     }

//     class Car
//     {
//         public String Model {get; set;}

//         public Car(String model)
//         {
//             this.Model = model;
//         }
//     }


// class Program
//     {

//         static void Main(string[] args)
//         {
//             // enums = special "class" that contains a set of named integer constants.
//             //         Use enums when you have values that you know will not change,
//             //         To get the integer value from an item, you must explicitly convert to an int

//             //         name = integer

//             //Console.WriteLine(Planets.Mercury + " is planet #" + (int)Planets.Mercury);
//             //Console.WriteLine(Planets.Pluto + " is planet #" + (int)Planets.Pluto);

//             String name = PlanetRadius.Earth.ToString();
//             int radius = (int)PlanetRadius.Earth;
//             double volume = Volume(PlanetRadius.Earth);

//             Console.WriteLine("planet: " + name);
//             Console.WriteLine("radius: " + radius +"km");
//             Console.WriteLine("volume: " + volume +"km^3");

//             Console.ReadKey();
//         }
//         public static double Volume(PlanetRadius radius)
//         {
//             double volume = (4.0 / 3.0) * Math.PI * Math.Pow((int)radius, 3);
//             return volume;
//         }
//     }
//     enum Planets
//     {
//         Mercury = 1, 
//         Venus = 2, 
//         Earth = 3, 
//         Mars = 4, 
//         Jupiter = 5, 
//         Saturn = 6, 
//         Uranus = 7, 
//         Neptune = 8, 
//         Pluto = 9
//     }

//     enum PlanetRadius
//     {
//         Mercury = 2439,
//         Venus = 6051,
//         Earth = 6371,
//         Mars = 3389,
//         Jupiter = 69911,
//         Saturn = 58232,
//         Uranus = 25362,
//         Neptune = 24622,
//         Pluto = 1188
//     }


// class Program
//     {
//         static void Main(string[] args)
//         {
//             // generic =  "not specific to a particular data type"
//             //            add <T> to: classes, methods, fields, etc.
//             //            allows for code reusability for different data types

//             int[] intArray = { 1, 2, 3 };
//             double[] doubleArray = { 1.0, 2.0, 3.0 };
//             String[] stringArray = { "1", "2", "3" };

//             displayElements(intArray);
//             displayElements(doubleArray);
//             displayElements(stringArray);

//             Console.ReadKey();
//         }     
//         public static void displayElements<Thing>(Thing[] array)
//         {
//             foreach (Thing item in array)
//             {
//                 Console.Write(item + " ");
//             }
//             Console.WriteLine();
//         }
//     }


// class Program
//     {
//         static void Main(string[] args)
//         {
//             // thread = an execution path of a program
//             //          We can use multiple threads to perform,
//             //          different tasks of our program at the same time.
//             //          Current thread running is "main" thread
//             //          using System.Threading;

//             Thread mainThread = Thread.CurrentThread;
//             mainThread.Name = "Main Thread";
//             //Console.WriteLine(mainThread.Name);

//             Thread thread1 = new Thread(() => CountDown("Timer #1"));
//             Thread thread2 = new Thread(() => CountUp("Timer #2"));

//             thread1.Start();
//             thread2.Start();

//             Console.WriteLine(mainThread.Name + " is complete!");

//             Console.ReadKey();
//         }  
//         public static void CountDown(String name)
//         {
//             for (int i = 10; i >= 0; i--)
//             {
//                 Console.WriteLine("Timer #1 : " + i + " seconds");
//                 Thread.Sleep(1000);
//             }
//             Console.WriteLine("Timer #1 is complete!");
//         }
//         public static void CountUp(String name)
//         {
//             for (int i = 0; i <= 10; i++)
//             {
//                 Console.WriteLine("Timer #2 : " + i + " seconds");
//                 Thread.Sleep(1000);
//             }
//             Console.WriteLine("Timer #2 is complete!");
//         }
//     }














































