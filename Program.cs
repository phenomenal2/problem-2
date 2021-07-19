using System;
using System.Collections.Generic;

public class GFG
{
    static public void Main()
    {

        int[] price = { 2, 30, 15, 10, 8, 25, 80, 105 };


        int profit = 0;


        for (int i = 1; i < price.Length; i++)
        {


            int sub = price[i] - price[i - 1];
            if (sub > 0)
                profit += sub;
        }
        Console.WriteLine("Maximum Profit=" + profit);
    }
}