public class Solution {

 public int Searchbin(int[] arr, int high, int low, int target){
        if(low > high) return -1;

        int middle = (low + high) / 2;

        if(arr[middle] == target) return middle;
        else if(arr[middle] > target){
            return Searchbin(arr, middle - 1 , low , target);
        }else{
            return Searchbin(arr, high  , middle + 1 , target);
        }
 }

    public int Search(int[] nums, int target) {
        int low = 0 , high = nums.Length - 1 ;
        // while(low <= high){
        //     int middle = (low + high)/2 ;
        //     if(nums[middle] == target)return middle;
        //     else if(nums[middle] > target){
        //         high = middle - 1;
        //     }else{
        //         low = middle + 1;
        //     }
        // }
        // return -1;
        int result = Searchbin(nums,high, low, target);
        return result;
     
    }

 }

    
