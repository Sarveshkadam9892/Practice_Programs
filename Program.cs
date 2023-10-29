
namespace Practice_Programs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");

            //String s = Console.ReadLine();
            //String rev = "";
            //for(int i = s.Length - 1; i>=0; i--)
            //{
            //    rev = rev + s[i];
            //}
            //Console.WriteLine(rev);

            //int num = Convert.ToInt32(Console.ReadLine());
            //int rev = 0;
            //int rem;
            //int temp = num;
            //while (num > 0)
            //{
            //    rem = num % 10;
            //    rev = rev * 10 + rem;
            //    num /= 10;
            //}
            //if (rev == temp)
            //{
            //    Console.WriteLine("Palindrome");
            //}
            //else
            //{
            //    Console.WriteLine("Not Palindrome");
            //}

            //            String s = Console.ReadLine();
            //            String rev = "";
            //            String temp = s;
            //            for (int i = s.Length - 1; i >= 0; i--)
            //            {
            //                rev = rev + s[i];
            //            }
            //            if (rev == temp)
            //            {
            //                Console.WriteLine("Palindrome");
            //            }
            //            else
            //            {
            //                Console.WriteLine("Not Palindrome");
            //            }
            //        }
            //    }
            //}


            //        int num = Convert.ToInt32(Console.ReadLine());
            //        bool IsAPrime = isaprime(num);
            //        if (IsAPrime)
            //        {
            //            Console.WriteLine(num + " is a prime number");
            //        }
            //        else
            //        {
            //            Console.WriteLine(num + " is not a prime number");
            //        }
            //    }
            //    public static bool isaprime(int n)
            //    {
            //        if (n <= 1)
            //        {
            //            return false;
            //        }
            //        for (int i = 2; i * i <= n; i++)
            //        {
            //            if (n % i == 0)
            //            {
            //                return false;
            //            }
            //        }
            //        return true;
            //    }
            //}

            //            List<int> numbers = new List<int> { 1, 2, 3, 4, 2, 5, 2, 6 };

            //            Console.WriteLine("Original List:");
            //            PrintList(numbers);

            //            Console.WriteLine("Enter ElementToRemove:");
            //            int elementToRemove = Convert.ToInt32(Console.ReadLine()); ;

            //            numbers.RemoveAll(item => item == elementToRemove);
            //            //numbers.Remove(elementToRemove);


            //            Console.WriteLine("\nList after removing " + elementToRemove + ":");
            //            PrintList(numbers);

            //            Console.ReadLine();
            //}

            //         static void PrintList(List<int> list)
            //        {
            //           foreach(var num in list)
            //            {
            //                Console.WriteLine(num + " ");
            //            }

            //           Console.WriteLine();
            //        }
            //    }

            //        Console.WriteLine("Enter a string:");
            //        string input = Console.ReadLine();

            //        string result = Changeletters(input);

            //        Console.WriteLine("Result after changing letters: " + result);

            //        Console.ReadLine();
            //    }

            //    static string Changeletters(string input)
            //    {
            //        char[] charArray = input.ToCharArray();

            //        for (int i = 0; i < charArray.Length; i++)
            //        {
            //            if (char.IsLetter(charArray[i]))
            //            {
            //                if (char.IsUpper(charArray[i]))
            //                {
            //                    charArray[i] = (char)(((charArray[i] - 'A' + 1) % 26) + 'A');
            //                }
            //                else
            //                {
            //                    charArray[i] = (char)(((charArray[i] - 'a' + 1) % 26) + 'a');
            //                }
            //            }
            //        }
            //        return new string(charArray);
            //    }
            //}

            //        Console.WriteLine("Enter a number");
            //        int number = Convert.ToInt32(Console.ReadLine());

            //        long factorial = FirstFactorial(number);

            //        Console.WriteLine("Factorial of " + number + "is : " + factorial);

            //        Console.ReadLine();

            //    }

            //    private static long FirstFactorial(int num)
            //    {

            //        if (num == 0)
            //        {
            //            return 1;
            //        }
            //        else
            //        {
            //            return num * FirstFactorial(num - 1);
            //        }
            //    }
            //}

            //    Console.WriteLine("Enter the number:");
            //    int n = Convert.ToInt32(Console.ReadLine());

            //        Console.WriteLine(NextPalindromeNumber(n));

            //}
            static int NextPalindromeNumber(int n)
            {
                n++;
                while (!IsPalindrome(n))
                {
                    n++;
                }
                return n;
            }
            static bool IsPalindrome(int n)
            {
                string nstr = n.ToString();
                int left = 0;
                int right = nstr.Length - 1;
                while (left < right)
                {
                    if (nstr[left] != nstr[right])
                    {
                        return false;

                    }
                    left++;
                    right--;
                }
                return true;

            }

        }
    }
}
