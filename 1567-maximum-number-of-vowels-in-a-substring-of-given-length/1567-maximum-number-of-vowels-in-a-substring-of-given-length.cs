public class Solution {
    public int MaxVowels(string s, int k) {
        int l = 0 , r = 0 , count = 0 , result = 0;
        while(r < s.Length){
            if(s[r] == 'a' || s[r] == 'e' || s[r] == 'i'|| s[r] == 'o' || s[r] == 'u'){
                count++;
            }
            r++;
            result = Math.Max(count, result);

            if(r-l == k){
                if(s[l] == 'a' || s[l] == 'e' || s[l] == 'i'|| s[l] == 'o' || s[l] == 'u'){
                    count--;
                }
                     l++;
            }
        }
        return result;
    }
}