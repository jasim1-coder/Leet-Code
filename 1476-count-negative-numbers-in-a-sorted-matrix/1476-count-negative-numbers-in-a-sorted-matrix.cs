public class Solution {
    public int CountNegatives(int[][] grid) {
        int result = 0;

        foreach(int[] arrnum in grid){
            foreach(int num in arrnum){
                if(num < 0){
                    result++;
                }
            }
        }
        return result;

        
    }
}