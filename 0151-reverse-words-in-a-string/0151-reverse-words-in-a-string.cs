using System;
using System.Text.RegularExpressions;
public class Solution {
    public string ReverseWords(string s) {
        string result = Regex.Replace(s, @"\s+", " ").Trim();
        string[] splitted = result.Split(" ");
        Array.Reverse(splitted);
        
        return string.Join(" ",splitted);
    }
}