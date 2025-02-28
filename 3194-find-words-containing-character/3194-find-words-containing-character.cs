public class Solution {
    public IList<int> FindWordsContaining(string[] words, char x) {
        List<int> results = new List<int>();
        for(int i=0;i<words.Count();i++){
            if(words[i].Contains(x)){
                results.Add(i);
            }
        }
        return results;
    }
}