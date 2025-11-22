public class Solution {
    public int MinBitFlips(int start, int goal) {
        int changeneededbits = start ^ goal;
        int count = 0 ;
        while(changeneededbits > 0){
            if(changeneededbits % 2 != 0){
                count = count + 1 ;
            }
            changeneededbits = changeneededbits / 2 ;
        }
        return count;
    }
}