public class Solution {
    public int NumberOfSubstrings(string s) {
        int[] Lastseen = {-1,-1,-1};
        int count = 0 ;
        for(int i = 0 ; i < s.Length ; i++){
            Lastseen[s[i] - 'a'] = i;
            count = count + (1 + Math.Min(Math.Min(Lastseen[0], Lastseen[1]), Lastseen[2]));
        }
        return count;
    }
}