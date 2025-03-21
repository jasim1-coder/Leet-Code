public class Solution {
    public bool IsStrictlyPalindromic(int n) {
         if (n >= 2)
        {
            for (int b = 2; b <= n - 2; b++)
            {
                string binary = "";
                int num = n;
                while (num > 0)
                {
                    int rem = num % b;
                    binary = rem + binary;
                    num /= b;
                }

                int i = 0, j = binary.Length - 1;
                while (i < j)
                {
                    if (!binary[i].Equals(binary[j]))
                    {
                        return false;
                    }
                    i++;
                    j--;
                }
            }
        }
        return true;
    }
}