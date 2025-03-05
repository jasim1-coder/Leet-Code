public class Solution {
    public int CountSeniors(string[] details) {
        int result = 0 ;
        
        for(int i = 0 ; i < details.Length;i++){
                    string result1 = "";

            for(int j = 11 ;j<13;j++ ){
                result1+=(details[i][j]);
            }
            if(int.TryParse(result1,out int num) && num > 60){
                result++;
            }
        }
        return result;
    }
}