public class Solution {
    public string TruncateSentence(string s, int k) {
        string[] splitted = s.Split(" ");
        string result = "";
        for(int i= 0 ; i < splitted.Count() ; i++ ){
            if(i < k){
                result += $" {splitted[i]}";
            }
        }
        return result.Substring(1);
    }
}