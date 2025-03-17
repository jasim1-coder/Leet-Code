public class Solution {
    public string RemoveStars(string s) {
        List<char> result = new List<char>();
        foreach(char ch in s){
            if(ch == '*'&& result.Count() > 0){
                result.RemoveAt(result.Count() - 1);
            }else if(ch != '*'){
                result.Add(ch);
            }
        }
        return new string(result.ToArray());
    }
}