public class Solution {
    public int MaximumNumberOfStringPairs(string[] words) {
        int result = 0 ;
        foreach(string str in words){
            string reversed = new string(str.Reverse().ToArray());
            if(words.Contains(reversed) && str != reversed){
                result++;
            }
        }
        return result/2;
    }
}