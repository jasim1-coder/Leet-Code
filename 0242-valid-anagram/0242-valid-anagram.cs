public class Solution {
    public bool IsAnagram(string s, string t) {
        int[] store = new int[26];
        if(s.Length != t.Length)return false;
        for(int i = 0 ; i < s.Length ; i++){
            store[s[i] - 'a'] +=1;
            store[t[i] - 'a']-=1;
        }

        foreach(int c in store){
            if(c != 0)
            return false;
        }

        return true;
    }
}