public class Solution {
    public int NumJewelsInStones(string jewels, string stones) {
        int result = 0;
        for(int i = 0; i< stones.Length;i++){
            if(jewels.Contains(stones[i])){
                result++ ;
            }
        }
        return result;
    }
}