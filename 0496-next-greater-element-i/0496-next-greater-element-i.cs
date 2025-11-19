public class Solution {
    public int[] NextGreaterElement(int[] nums1, int[] nums2) {
        Dictionary<int,int> store = new Dictionary<int,int>();
        Stack<int> storest = new Stack<int>();
        for(int i = nums2.Length -1 ; i >= 0 ; i--){
            while(storest.Count > 0 && storest.Peek() <= nums2[i]){
                storest.Pop();
            }
            store[nums2[i]] = storest.Count == 0 ? -1 : storest.Peek();
            storest.Push(nums2[i]);
        }
        int[] ans = new int[nums1.Length];
        for(int i = 0 ; i < nums1.Length ; i++){
            ans[i] = store[nums1[i]];
        }

        return ans;
    }
}