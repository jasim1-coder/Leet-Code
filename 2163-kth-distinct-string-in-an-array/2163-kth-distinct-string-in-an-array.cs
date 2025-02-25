public class Solution {
    public string KthDistinct(string[] arr, int k) {
        List<string> store = new List<string>();
        foreach(string str in arr){
            if(arr.Count(x => x == str)==1){
                store.Add(str);
            }
        }
        if(store.Count() < k){
            return "";
        }else{
            return store[k-1];
        }
    }
}