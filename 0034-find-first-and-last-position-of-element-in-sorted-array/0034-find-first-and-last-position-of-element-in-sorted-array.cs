public class Solution {
    public int[] SearchRange(int[] nums, int target) {


        int leftindex =returnindex(nums, target, true);
        int rightindex = returnindex(nums, target,false );
        return new int[]  {leftindex,rightindex};
    }

        public int returnindex(int[] nums, int target, bool istrue){
            int low=0,high=nums.Length-1; int result = -1 ;

            while(low <= high){
                int middle = (low + high)/2;
                if(nums[middle] == target){
                    result = middle;
                    if(istrue){
                        high = middle - 1;
                    }else{
                        low = middle + 1;
                    }
                }
                else if(nums[middle] > target){
                    high = middle -1;
                }else{
                    low = middle + 1;
                }
            }

            return result ;
        }
        
    }
