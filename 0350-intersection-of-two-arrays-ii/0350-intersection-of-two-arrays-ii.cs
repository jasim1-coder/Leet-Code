public class Solution {
    public int[] Intersect(int[] nums1, int[] nums2) {
         var nums2list = new List<int>(nums2);
        var result = new List<int>();
        for(int i = 0;i<nums1.Length;i++){
            var index = nums2list.IndexOf(nums1[i]);
            if(index != -1){
                result.Add(nums1[i]);
                nums2list.RemoveAt(index);
            }
        }

        return result.ToArray();
    }
}