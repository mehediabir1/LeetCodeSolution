using System;
using System.Collections.Generic;

namespace LeetCodeProblems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //------Run Here------//

            //Build_Array_From_Permutation_1920();
            //Concatenation_of_Array_1929();
            //Partitioning_Into_Minimum_Number_1689();
            //Maximum_Number_of_Words_2114();
            //Palindrome_Number_9();
            //Final_Value_of_Variable_2011();
            //Running_Sum_of_1d_Array_1480();
            //Richest_Customer_Wealth_1672();
            Kids_With_the_Greatest_1431(); // Not Working
            //Shuffle_the_Array_1470();


        }
        public static void Shuffle_the_Array_1470()
        {
            int[] nums = { 1, 2, 3, 4, 4, 3, 2, 1 };
            int[] newNum = new int[nums.Length];

            for (int i = 0, j = nums.Length / 2, k = 0 ; i < nums.Length/2; i++,j++)
            {
                newNum[k++] = nums[i];
                newNum[k++] = nums[j];
            }
            for (int i = 0; i < newNum.Length; i++)
            {
                Console.WriteLine(newNum[i]);
            }
        }
        public static void Kids_With_the_Greatest_1431()
        {
            int[] candies = { 2, 3, 5, 1, 3 };
            int extraCandies = 3;
            //int sum = candies[0] + extraCandies;
            bool[] GreatCandies = new bool[candies.Length];
            int j;

            for (int i = 0; i < candies.Length; i++)
            {
                int sum = candies[i] + extraCandies;

                for (j = 0; j < candies.Length; j++)
                {
                    if (sum < candies[j] && i != j)
                    {
                        break;
                    }
                }
                if (j != candies.Length)
                {
                    GreatCandies[i] = false;
                }
                else
                {
                    GreatCandies[i] = true;
                }

            }
            for (int i = 0; i < GreatCandies.Length; i++)
            {
                Console.WriteLine(GreatCandies[i]);
            }
        }

        public static void Kids_With_the_Greatest_1431__2()
        {
                int MaxNumber = candies.Max();
                IList<bool> res = new List<bool>();
                candies.ToList().ForEach(num =>
                {
                    if (num >= MaxNumber || (num + extraCandies) >= MaxNumber)
                    {
                        res.Add(true);
                    }
                    else
                    {
                        res.Add(false);
                    }
                });
                return res;
            
        }


        //public static void Richest_Customer_Wealth_1672()
        //  {
        //      int[,] accounts = { { 2, 8, 7 },{ 7, 1, 3 },{ 1, 9, 5 } };
        //      int sum1 = 0;
        //       int max = 0;
        //       for (int i = 0; i < accounts.Length; i++)
        //       {
        //           sum1 = 0;

        //           for (int j = 0; j < accounts[i].Length; j++)
        //           {
        //               sum1 = sum1 + accounts[i][j];
        //           }

        //           if (sum1 > max)
        //           {
        //               max = sum1;
        //           }
        //       }

        //       //return max;
        //   }

        public static void Running_Sum_of_1d_Array_1480()
        {
            int[] nums = new int[] { 3, 1, 2, 10, 1 };
            int[] sums = new int[nums.Length];
            int sums2 = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                sums2 = sums2 + nums[i];
            }
            for (int i = sums.Length - 1; i >= 0; i--)
            {
                sums[i] = sums2;
                sums2 = sums2 - nums[i];   
            }
            
            Array.Reverse(sums);
            Array.Reverse(sums);

           // return sums;
        }

        public static void Final_Value_of_Variable_2011()
        {
            int X = 0;
            string[] operations = { "X++", "++X", "--X", "X--" };

            for (int i = 0; i < operations.Length; i++)
            {   
               
                if (operations[i] == "--X" || operations[i] == "X--")
                {
                    X = X - 1;
                }

                else if (operations[i] == "X++" || operations[i] == "++X")
                {
                    X = X + 1;
                }
            }
            //return X;

        }

        public static void Palindrome_Number_9()
        {
            int x = 101;
            int y = x;
            double rev = 0;
            int rem = 0;
            

            while (x >= 1)
            {
              rem = x% 10;
              rev = rev * 10 + rem;
              x /= 10;
            }
            if(rev == y)
            {
                //return true; 
               
            }
            else
            {
               // return false;  
                
            }


        }

        public static void Maximum_Number_of_Words_2114()
        {
            string[] sentences = new string[] { "alice and bob love leetcode", "i think so too", "this is great thanks very much" };

            int counter;
            int max = 0;

            for (int i = 0; i < sentences.Length; i++)
            {
                counter = 0;
                for (int j = 0; j < sentences[i].Length; j++)
                {
                    if (sentences[i][j] == ' ')
                    {
                        counter++;
                    }
                }

                if (counter > max)
                {
                    max = counter;
                }
            }

            //return max + 1;

        }
        
        public static int[] Build_Array_From_Permutation_1920()
        {
            int[] nums = new int[] { 0, 2, 1, 5, 3, 4 };
            int[] ans = new int[nums.Length];

            for (int i = 0; i < nums.Length; i++)
            {
                ans[i] = nums[nums[i]];
                Console.WriteLine(ans[i]);
            }

            return ans;

        }

        public static void Concatenation_of_Array_1929()
        {
            int[] nums = new int[] { 1, 2, 1 };
            int[] ans = new int[nums.Length * 2];

            for (int i = 0, j = 0; i < nums.Length * 2; i++)
            {
                ans[i] = nums[j];

                if (j == nums.Length - 1)
                {
                    j = 0;
                }
                else
                {
                    j++;
                }
            }

        }
        
        public static int[] TwoSum_()
        {
            int[] nums = new int[] { 2, 11, 7, 15 };
            int target = 9;
            int i, j;
            int[] res = new int[2];

            for (i = 0; i < nums.Length; i++)
            {
                for (j = 0; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target && i != j)
                    {
                        res[0] = i;
                        res[1] = j;
                        break;
                    }
                }
                if (j != nums.Length)
                {
                    break;
                }
            }
            return res;
        }

        public static void Partitioning_Into_Minimum_Number_1689()
        {
            string n = "27346209830709182346";

            //long n3 = Convert.ToInt64(nums);
            int n2 = 0;
            
            for (int i = 0; i < n.Length; i++)
            {
                if (n[i]-'0' > n2)
                {
                    n2 = n[i] - '0';
                }
            }

            
        }


    }
}
