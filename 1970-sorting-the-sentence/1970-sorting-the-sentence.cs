public class Solution {
    public string SortSentence(string s) {
    
        string[] splitedString = s.Split(" ");
        string[] result = new string[splitedString.Length];

        for ( int i = 0; i < splitedString.Length; i++)
        {
            string word = splitedString[i];
            int index = int.Parse(word[word.Length - 1].ToString()) - 1;
            result[index] = word.Substring(0, word.Length - 1);
        }

        return String.Join(" ", result);
    }
}