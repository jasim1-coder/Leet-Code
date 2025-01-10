public class Solution {
    public int HeightChecker(int[] heights) {
        List<int> sorted = heights.OrderBy(x=>x).ToList();
        int mismatch = 0 ;
    for(int i = 0 ; i< heights.Length ; i++){
        if(heights[i] != sorted[i]){
            mismatch++;
        }
    }  
    return mismatch;      

    }
}