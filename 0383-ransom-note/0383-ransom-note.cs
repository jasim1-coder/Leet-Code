public class Solution {
    public bool CanConstruct(string ransomNote, string magazine) {
        int[] charCount = new int[26];

        foreach (char c in magazine) {
            charCount[c - 'a']++;
        }

        foreach (char c in ransomNote) {
            if (--charCount[c - 'a'] < 0) {
                return false;
            }
        }

        return true; 
    }
}
