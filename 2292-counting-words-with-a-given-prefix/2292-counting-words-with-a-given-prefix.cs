public class Solution {
    public int PrefixCount(string[] words, string pref) {
        int result = 0 ;
        foreach(string str in words){
            if(str.StartsWith(pref)){
                result++;
            }
        }
        return result;
    }
}