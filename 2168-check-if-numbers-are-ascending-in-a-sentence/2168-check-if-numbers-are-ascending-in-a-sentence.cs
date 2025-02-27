public class Solution {
    public bool AreNumbersAscending(string s) {
        List<int> num = new List<int>();
        string[] words = s.Split(' ');
        foreach(var str in words){
            if(int.TryParse(str, out int n)){
                num.Add(n);
            }
        }
        for(int i = 1; i < num.Count; i++){
            if(num[i] <= num[i-1]){
                return false;
            }
        }
        return true;
    }
}