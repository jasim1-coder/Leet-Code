public class Solution {
    public int NumOfStrings(string[] patterns, string word) {
        int count = 0 ;
        for(int i = 0 ; i < patterns.Length ; i++){
            if(word.Contains(patterns[i])){
                count++;
            }
        }
        return count;
    }
}