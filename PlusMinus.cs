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

class Result
{

    /*
     * Complete the 'plusMinus' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */


    string timeConversion(string s)
    {
        //11：11：11pm
        int pos = s.find(":");
        int t = stoi(s.substr(0, pos));
        string r = s.substr(8, 2);
        if (t == 12 && r == "AM") return "00" + s.substr(pos, 6);
        else if (t < 12 && r == "PM") return to_string((t + 12)) + s.substr(pos, 6);
        else return s.substr(0, 8);
    }



   public static string timeConversion(string s)
    {
        
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Result.plusMinus(arr);
    }
}
