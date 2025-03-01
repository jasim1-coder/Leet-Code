public class Solution {
    public bool CheckIfPangram(string sentence) {
        string letters = "abcdefghijklmnopqrstvuwxyz";
            return letters.All(c => sentence.Contains(c));
        
    }
}