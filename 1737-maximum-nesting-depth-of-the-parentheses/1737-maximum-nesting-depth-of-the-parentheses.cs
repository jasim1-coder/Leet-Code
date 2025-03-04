public class Solution {
    public int MaxDepth(string s) {
        int currentdepth = 0 ;
        int maxdepth = 0 ;

        foreach(char ch in s){
            if(ch == '('){
                currentdepth++;
                maxdepth=Math.Max(currentdepth,maxdepth);
            }else if(ch == ')'){
                currentdepth--;
            }
        }
        return maxdepth;
    }
}