public class Solution {
    public int MaximumValue(string[] strs) {
        int result = 0;
        foreach(var str in strs){
            if(int.TryParse(str, out int num)){
                result = Math.Max(result,num);
            }else{
                    result = Math.Max(result, str.Length);
            }
        }
        return result;
    }
}