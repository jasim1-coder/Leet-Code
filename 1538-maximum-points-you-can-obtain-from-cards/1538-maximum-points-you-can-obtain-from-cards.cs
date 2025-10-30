public class Solution {
    public int MaxScore(int[] cardPoints, int k) {

        int maxpoint = 0 ; 
        int right = cardPoints.Length - 1 ;
        int left = cardPoints.Length - k ;
        int result = 0;
        int currentpoint = 0;

        for(int i = 0 ; i <= k-1 ; i++){
            maxpoint += cardPoints[i];
        }
        result = maxpoint;

        while(right >= left){
            maxpoint -= cardPoints[right-left];
            currentpoint += cardPoints[right] ;
            result = Math.Max(result, currentpoint + maxpoint);
            right--;
        }

        return result;

    }
}