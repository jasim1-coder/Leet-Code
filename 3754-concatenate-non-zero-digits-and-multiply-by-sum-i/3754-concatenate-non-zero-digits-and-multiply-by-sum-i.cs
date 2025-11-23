public class Solution {
    public long SumAndMultiply(int n) {
        long ans = 0 ;
        int sum = 0;
        StringBuilder str = new StringBuilder();
        foreach(char ch in n.ToString()){
            if(ch - '0' != 0){
                sum += ch - '0';
                str.Append(ch);
            }
        }
        if(str.Length == 0) return 0;
        ans = long.Parse(str.ToString()) * sum ;
        return ans;
    }
}