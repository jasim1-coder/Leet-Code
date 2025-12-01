public class Solution {
    public bool IsIsomorphic(string s, string t) {
        if(s.Length != t.Length)return false;

        Dictionary<Char, Char> strings = new Dictionary<Char, Char>();
        Dictionary<Char, Char> stringt = new Dictionary<Char, Char>();

        for(int i = 0 ; i < s.Length ; i++){
            Char ss = s[i];
            Char tt = t[i];

            if(strings.ContainsKey(ss)){
                if(strings[ss] != tt)return false;
            }else{
                strings[ss] = tt;
            }

            if(stringt.ContainsKey(tt)){
                if(stringt[tt] != ss)return false;
            }else{
                stringt[tt] = ss;
            }

        }
    return true;
    }
}