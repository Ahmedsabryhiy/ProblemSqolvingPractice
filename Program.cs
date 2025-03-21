﻿using System.ComponentModel;

namespace ProblemSqolvingPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "C# is fun . learing C# is enjoyable . c# is everwhere.";
            string pattern = "C#";

            int[] array1 = { 1, 3, 5, 7, 10 };
            int[] array2 = { 2, 4, 6, 8 };
            int[] arr = { -2, 1, -3, 4, -1, 2, 1, -5, 4 };
            int[] arr2 = { 1, 2, 3, 1, 2, 3, 1, 2, 3 };

            Console.WriteLine("Welcome to Problem Solving Practice");

            string choice = "cont";
            while (choice != "exit")
            {


                Console.Clear();


                Console.WriteLine("1- Count Occurrences");
                Console.WriteLine("2- Reverse Order Of Words");
                Console.WriteLine("3- First Non Repeating");


                Console.WriteLine("4- Merge Two Arrays");
                Console.WriteLine("5- Maximum Subarray Sum ");
                Console.WriteLine("6- Palindrome");
                Console.WriteLine("7- Remove Duplicates from an Array");
                Console.WriteLine("8- Factorial of a number");
                Console.WriteLine("9- FizzBuzz Problem");

                Console.WriteLine("10- Remove Duplicates from an Array");
                Console.WriteLine("11- Sum of Digits");
                Console.WriteLine("12- Find Second Largest Number");
                Console.WriteLine("13- Binary Search");
                Console.WriteLine("14- Reverse a singly linked list");
                Console.WriteLine("15- Find all pairs of an integer array whose sum is equal to a given number");
                Console.WriteLine("16- Rotate an array by K times");
                Console.WriteLine("17-  Evaluate a Polish notation expression as array and return its value ");
                Console.WriteLine("18- Balanced Parentheses Checker Using Stack");
                Console.WriteLine("19- Find missing number in array of integers");
                Console.WriteLine("20- Find Longest common  prfix  ");
                Console.WriteLine("0- Exit");

                Console.WriteLine("Enter the number of the problem you want to solve");
                int number = Convert.ToInt32(Console.ReadLine());


                switch (number)
                {
                    case 1:
                        CountOccurrences(text, pattern);
                        break;
                    case 2:
                        ReverseOrderOfWords(text);
                        break;
                    case 3:
                        FirstNonRepeating("stress");
                        break;

                    case 4:
                        MergeTowArraies(array1, array2);
                        break;
                    case 5:
                        int maxSum = MaximumSubarraySum(arr);
                        Console.WriteLine($"The maximum subarray sum is: {maxSum}");
                        break;
                    case 6:
                        string word = "A man, a plan, a canal: Panama";
                        Palindrome(word);
                        break;
                    case 7:
                        RemoveDuplicates(arr2);
                        break;
                    case 8:
                        int number1 = 5;
                        int result = Factorial(number1);
                        Console.WriteLine($"The factorial of {number1} is: {result}");
                        break;
                    case 9:
                        FizzBuzz();
                        break;
                    case 10:
                        int[] result1 = RemoveDuplicate(arr2);
                        Console.WriteLine($"The unique elements are: {string.Join(", ", result1)}");
                        break;

                    case 11:
                        SumOfDigitsWithoutDivision(14789);
                        break;
                    case 12:
                        int[] ints = { 1, 5, 3, 4, 5, 6, 7 };
                        Console.WriteLine(FindSecondLargestNumber(ints));

                        break;
                    case 13:
                        int[] ints2 = { 1, 3, 5, 7, 9 };
                        int index = BinarySearch(ints2, 0, ints2.Length - 1, 7);
                        Console.WriteLine($"The index of the number is: {index}");
                        break;
                    case 14:
                        ReverseSinglyLinkedList();
                        break;
                    case 15:
                        int[] arr3 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
                        int target = 30;
                        FindAllPairsGivenSumOfTarget(arr3, target);
                        break;
                    case 16:
                        int[] arr4 = { 1, 2, 3, 4, 5, 6, 7 };
                        int k = 3;

                        Console.WriteLine("Original Array: " + string.Join(", ", arr4));

                        RotateArray(arr4, k);

                        Console.WriteLine("Rotated Array: " + string.Join(", ", arr4));

                        break;
                    case 17:
                        // Example: ["2", "1", "+", "3", "*"] should evaluate to 9
                        string[] tokens = new string[] { "2", "1", "+", "3", "*" };
                        int final = EvaluatePolishNotation(tokens);
                        Console.WriteLine("The result is: " + final);
                        // Expected output: The result is: 9
                        break;
                    case 18:

                        // Test cases
                        string test1 = "({[]})";
                        string test2 = "({[})";
                        string test3 = "a(b)c{d[e]f}g";

                        Console.WriteLine($"Is \"{test1}\" balanced? {IsBalanced(test1)}");  // Expected: True
                        Console.WriteLine($"Is \"{test2}\" balanced? {IsBalanced(test2)}");  // Expected: False
                        Console.WriteLine($"Is \"{test3}\" balanced? {IsBalanced(test3)}");  // Expected: True
                        break;
                    case 19:
                        int[] anSortedArray = { 3, 7, 1, 2, 8, 4, 5 };
                        int missingNumber = FindNumberMissing(anSortedArray);
                        Console.WriteLine($"The missing number is: {missingNumber}");
                        break;
                        case 20:
                            string[] str= {"flower", "flow", "flight"};
                            string longestCommonPrefix = LongestCommonPrefix(str);
                            Console.WriteLine($"The longest common prefix is: {longestCommonPrefix}");
                            break;
                    case 0:
                        return;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
                Console.WriteLine("Please write cont to continue or exit to exit");
                choice = Console.ReadLine();
            }


            Console.ReadLine();



        }

        private static void Palindrome(string word)
        {
            string reversedWord = ReverseOrderOfWords(word);
            if (word == reversedWord)
            {
                Console.WriteLine("The word is a palindrome");
            }
            else
            {
                Console.WriteLine("The word is not a palindrome");
            }






        }

        static int CountOccurrences(string text, string pattern)
        {
            int count = 0;

            string[] words = text.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {

                if (words[i] == pattern.ToUpper() || words[i] == pattern.ToLower())
                    count++;
            }
            return count;
        }
        static string ReverseOrderOfWords(string text)
        {

            string[] words = text.Split(' ');
            string reversedText = "";
            for (int i = words.Length - 1; i >= 0; i--)
            {
                reversedText += words[i] + " ";
            }
            return reversedText;
        }
        static char FirstNonRepeating(string word)
        {
            char ch = ' ';
            for (int i = 0; i < word.Length; i++)
            {

                for (int j = 0; j < word.Length; j++)
                {
                    ch = word[0];
                    if (ch == (word[j]))
                    {
                        ch = word[j];
                    }

                }
            }
            return ch;
        }
        static int[] MergeTowArraies(int[] a, int[] b)
        {


            int[] mergedArray = new int[a.Length + b.Length];
            int index = 0;
            for (int i = 0; i < a.Length; i++)
            {
                mergedArray[index] = a[i];
                index++;
            }
            for (int i = 0; i < b.Length; i++)
            {
                mergedArray[index] = b[i];
                index++;
            }
            Console.WriteLine("Merged Array");
            Array.Sort(mergedArray);
            return mergedArray;



        }
        static int MaximumSubarraySum(int[] a)
        {
            int currentMax = a[0];
            int gloalMax = a[1];
            for (int i = 0; i < a.Length; i++)
            {
                currentMax = Math.Max(a[i], currentMax + a[i]);
                gloalMax = Math.Max(gloalMax, currentMax);


            }
            return gloalMax;
        }
        static int[] RemoveDuplicates(int[] a)
        {
            int[] result = new int[a.Length];
            int index = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (!result.Contains(a[i]))
                {
                    result[index] = a[i];
                    index++;
                }
            }
            return result;
        }
        static int Factorial(int number)
        {
            int sum = 1;
            if (number == 0 || number == 1)
                return 1;
            else
            {
                for (int i = 1; i <= number; i++)
                {
                    sum = sum * i;
                }
            }
            return sum;

        }
        static void FizzBuzz()
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0)
                    Console.WriteLine("Fizz");
                else if (i % 5 == 0)
                    Console.WriteLine("Buzz");

                else if (i % 3 == 0 && i % 5 == 0)
                    Console.WriteLine("FizzBuzz");
                else Console.WriteLine(i);
            }
        }
        static int[] RemoveDuplicate(int[] a)
        {
            int[] result = new int[a.Length];
            bool alreadyExists = false;
            int uniqueCount = 0;
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < uniqueCount; j++)
                {
                    if (result[j] == a[i])
                    {
                        alreadyExists = true;
                        break;
                    }

                }
                if (!alreadyExists)
                {
                    result[uniqueCount] = a[i];
                    uniqueCount++;
                }
                alreadyExists = false;


            }
            return result;

        }



        // Method to compute the sum of digits without using '/' or '%' operators.
        public static int SumOfDigitsWithoutDivision(int number)
        {
            // Handle negative numbers manually.
            if (number < 0)
            {
                number = -number;
            }

            int sum = 0;

            // Process until number is reduced to 0.
            while (number > 0)
            {
                int quotient = 0;
                int remainder = number; // Start with the full number.

                // Repeatedly subtract 10 from 'remainder' until it is less than 10.
                // The number of times we subtract 10 gives us the quotient.
                while (remainder >= 10)
                {
                    remainder -= 10;  // Subtract 10.
                    quotient++;       // Count how many times we subtracted.
                }

                // 'remainder' now represents the last digit (like number % 10).
                sum += remainder;

                // 'quotient' simulates number / 10. Update number.
                number = quotient;
            }

            return sum;
        }

        static int FindSecondLargestNumber(int[] a)
        {
            //if (a.Length < 2)
            //    throw new ArgumentException("Array must contain at least two elements.");

            //int largest = int.MinValue;
            //int secondLargest = int.MinValue;

            //foreach (int num in a)
            //{
            //    if (num > largest)
            //    {
            //        secondLargest = largest;
            //        largest = num;
            //    }
            //    else if (num > secondLargest && num < largest)
            //    {
            //        secondLargest = num;
            //    }
            //}

            //if (secondLargest == int.MinValue)
            //    throw new InvalidOperationException("No second largest element found.");

            //return secondLargest;
            if (a.Length < 2)
                throw new ArgumentException("Array must contain at least two elements.");

            int largest = int.MinValue;
            int secondLargest = int.MinValue;
            for (int i = 0; i < a.Length; i++)
            {

                if (a[i] > largest)
                {
                    secondLargest = largest;
                    largest = a[i];
                }
                else if (a[i] > secondLargest && a[i] < largest)
                {
                    secondLargest = a[i];
                }

            }
            return secondLargest;

        }
        static int BinarySearch(int[] a, int start, int end, int number)
        {
            while (start <= end)
            {
                int md = (start + end) / 2;
                if (a[md] == number)
                    return md;
                else if (a[md] < number)
                {
                    start = md + 1;

                }
                else
                    end = md - 1;

            }
            return -1;


        }
        static void ReverseSinglyLinkedList()
        {
            LinkedList myLinkedList = new LinkedList();


            myLinkedList.AddFirst(2);
            myLinkedList.AddFirst(3);
            myLinkedList.AddFirst(4);
            myLinkedList.Reverse();
            myLinkedList.PrintList();


        }
        static void FindAllPairsGivenSumOfTarget(int[] a, int target)
        {


            for (int i = 0; i < a.Length; i++)
            {
                for (int j = i + 1; j < a.Length; j++)
                {
                    if (a[j] + a[i] == target)
                    {
                        Console.WriteLine($"({a[i]},{a[j]})");
                    }
                }
            }


        }
        public static void RotateArray(int[] a, int k)
        {
            int n = a.Length;
            k = k % n;
            Reverse(a, 0, k - 1);
            Reverse(a, k, n - 1);
            Reverse(a, 0, n - 1);



        }
        public static void Reverse(int[] arr, int start, int end)
        {
            while (start < end)
            {
                int temp = arr[start];
                arr[start] = arr[end];
                arr[end] = temp;
                start++;
                end--;
            }
        }
        public static int EvaluatePolishNotation(string[] tokens)
        {
            // Create a stack to hold integer operands.
            Stack<int> stack = new Stack<int>();

            // Iterate over each token in the input.
            foreach (string token in tokens)
            {
                // If the token is one of the operators, perform the operation.
                if (token == "+" || token == "-" || token == "*" || token == "/")
                {
                    // Pop the top two numbers. Note: The second popped is the first operand.
                    int operand2 = stack.Pop();
                    int operand1 = stack.Pop();
                    int result = 0;

                    // Determine the operator and compute the result.
                    switch (token)
                    {
                        case "+":
                            result = operand1 + operand2;
                            break;
                        case "-":
                            result = operand1 - operand2;
                            break;
                        case "*":
                            result = operand1 * operand2;
                            break;
                        case "/":
                            result = operand1 / operand2;  // Assume valid integer division.
                            break;
                    }
                    // Push the computed result back onto the stack.
                    stack.Push(result);
                }
                else
                {
                    // Otherwise, the token is a number. Convert it to an integer and push it onto the stack.
                    int number = int.Parse(token);
                    stack.Push(number);
                }
            }
            // After processing all tokens, the stack should have one element: the final result.
            return stack.Pop();
        }
        public static bool IsBalanced(string input)
        {
            Stack<char> stack = new Stack<char>();

            if (string.IsNullOrEmpty(input))
            {
                return false;
            }

            foreach (char c in input)
            {
                if (c == '(' || c == '{' || c == '[')
                {
                    stack.Push(c);
                }
                if (c == ')' || c == '}' || c == ']')
                {
                    if (stack.Count == 0)
                    {
                        return false;
                    }
                    stack.Pop();
                }
            }
            return stack.Count == 0;

            //foreach (char c in s)
            //{
            //    if (c == '(' || c == '{' || c == '[')
            //    {
            //        stack.Push(c);
            //    }
            //    if (c == ')' || c=='}'  ||c == ']')
            //    {
            //        if(stack.Count == 0)
            //            { return false; }
            //        stack.Pop ();
            //    }
            //    return stack.Count== 0;
            //}

        }
        // Helper method to check if an opening and closing bracket match.
        public static bool IsMatchingPair(char open, char close)
        {
            return (open == '(' && close == ')') ||
                   (open == '{' && close == '}') ||
                   (open == '[' && close == ']');
        }

        public static int FindNumberMissing(int[] input)
        {
            int n = input.Length;
            int expectedSum = (n + 1) * (n + 2) / 2;
            int actualSum = 0;
            for (int i = 0; i < n; i++)
            {
                actualSum += input[i];
            }

            int missingNumber = expectedSum - actualSum;
            return missingNumber;


        }
        public static string LongestCommonPrefix(string[] str)
        {
            // implementation without using built-in methods
            string prefix = str[0];
            if (str.Length == 0 || str == null)
            {
                return "";
            }
            while (str.Length > 0)
            {
               
                for (int i = 1; i < str.Length; i++)
                {
                    while (str[i].IndexOf(prefix) != 0)
                    {
                        prefix = prefix.Substring(0, prefix.Length - 1);
                    }
                }
                if (prefix.Length == 0)
                {
                    return "";
                }
               

            }

            return prefix;

        }
        public static void PrintArray<T>(T[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }

        public static void PrintArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }


    }
}



