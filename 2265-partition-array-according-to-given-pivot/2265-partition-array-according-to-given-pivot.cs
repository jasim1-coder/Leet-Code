public class Solution {
    public int[] PivotArray(int[] nums, int pivot) {
        List<int> result = new List<int>();
                List<int> result1 = new List<int>();

        List<int> result2 = new List<int>();

                List<int> final = new List<int>();



        for(int i = 0 ; i < nums.Length ; i++){
            if(nums[i] < pivot){
                result.Add(nums[i]);
            }else if(nums[i] == pivot){
                result1.Add(nums[i]);
            }else{
                result2.Add(nums[i]);
            }
        }
        final.AddRange(result);
                final.AddRange(result1);

        final.AddRange(result2);
return final.ToArray();

    }
}