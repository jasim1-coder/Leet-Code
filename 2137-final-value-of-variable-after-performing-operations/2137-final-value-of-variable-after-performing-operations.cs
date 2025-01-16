public class Solution {
    public int FinalValueAfterOperations(string[] operations) {
        int x = 0 ;
        foreach(string ch in operations){
            if(ch == "--X" ||ch == "X--"){
                x = x-1;
            }else if(ch == "X++" ||ch ==  "++X"){
                x = x+1;
            }
        }
        return x ;
    }
}