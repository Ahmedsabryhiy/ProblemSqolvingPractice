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
          
            string choice="cont";
            while ( choice != "exit") 
            {  
            
               
               
                Console.WriteLine("1- Count Occurrences");
                Console.WriteLine("2- Reverse Order Of Words");
                Console.WriteLine("3- First Non Repeating");
               
         
                Console.WriteLine("4- Merge Two Arrays");
                Console .WriteLine("5- Maximum Subarray Sum ");
                Console.WriteLine("6- Palindrome");
                Console.WriteLine("7- Remove Duplicates from an Array");
                Console.WriteLine("8- Factorial of a number");
                Console.WriteLine("9- FizzBuzz Problem");
                
                Console.WriteLine("0- Exit");

                Console.WriteLine("Enter the number of the problem you want to solve");
                int number = Convert.ToInt32(Console.ReadLine());


                switch (number)
                {
                    case 1:
                        CountOccurrences( text ,pattern);
                        break;
                    case 2:
                        ReverseOrderOfWords( text);
                        break;
                    case 3:
                        FirstNonRepeating("stress");
                        break;
                
                    case 4:
                        MergeTowArraies(array1, array2);
                        break;
                    case 5:
                        int maxSum =MaximumSubarraySum(arr);
                        Console.WriteLine($"The maximum subarray sum is: {maxSum}");
                        break;
                    case 6:
                        string word = "A man, a plan, a canal: Panama";
                        Palindrome(word );
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
                           int[] result1 =  RemoveDuplicate(arr2);
                            Console.WriteLine($"The unique elements are: {string.Join(", ", result1)}");
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
            return reversedText ;
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
        static int MaximumSubarraySum (int[] a)
        {
            int  currentMax=a[0];
            int gloalMax = a[1];
            for(int i = 0; i<a.Length; i++)
            {
                 currentMax=Math.Max(a[i], currentMax + a[i]);
                gloalMax =Math .Max(gloalMax, currentMax);


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
            for(int i = 1; i <=100;i++)
            {
                if (i % 3 == 0)
                    Console.WriteLine("Fizz");
                else if (i % 5 == 0)
                    Console.WriteLine("Buzz");
               
               else if ( i % 3 == 0 && i % 5 == 0)
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
                for (int j=0;j<uniqueCount;j++)
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
           return   result;
                
        }


    }
}
