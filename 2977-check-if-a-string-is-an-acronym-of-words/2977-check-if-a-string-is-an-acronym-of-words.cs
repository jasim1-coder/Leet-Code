public class Solution {
    public bool IsAcronym(IList<string> words, string s) {
        string result = "";
        for(int i = 0 ; i < words.Count() ; i++){
            result += (words[i])[0];
        }
        return s == result ;
    }
}