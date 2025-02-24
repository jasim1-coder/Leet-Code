public class Solution {
    public string ReversePrefix(string word, char ch) {
        var point = word.IndexOf(ch);
        if(point == -1) return word;
        var words = word.ToCharArray();
        Array.Reverse(words, 0 , point+1);
        return new string(words);
    }
}