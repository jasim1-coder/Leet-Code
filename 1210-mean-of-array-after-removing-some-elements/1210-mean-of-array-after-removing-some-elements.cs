public class Solution {
    public double TrimMean(int[] arr) {
        Array.Sort(arr); 

        int n = arr.Length;
        int removeCount = n / 20; 

        double mean = arr.Skip(removeCount).Take(n - 2 * removeCount).Average();

        return Math.Round(mean, 5); 

    }
}