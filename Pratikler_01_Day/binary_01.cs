using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;



class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());
        var reminder = 0;
        var count = 0;
        var max = 0;
        
        while(n > 0)
        {
            reminder = n % 2;
            n /= 2;
            
            if(reminder == 1)
            {
                count++;
                max = Math.Max(max, count);
            }
            else
            {
                count = 0;
            }
        }
        Console.WriteLine(max);
		// bir sayının binary karsiligini bulmak
    }
}
