public class Solution {
    public bool UniqueOccurrences(int[] arr) {
        Dictionary<int,int> result = new Dictionary<int,int>();
        foreach(var num in arr){
            if(result.ContainsKey(num)){
                result[num]++;
            }else{
                result[num] = 1;
            }
        }

        var result1 = new HashSet<int>();
        foreach(var num in result.Values){
            result1.Add(num);
        }
        return result.Count == result1.Count ;
    }
}