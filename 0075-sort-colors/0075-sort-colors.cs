public class Solution {
    public void SortColors(int[] nums) {
        Dictionary<int,int> store = new Dictionary<int, int>(){{0,0},{1,0},{2,0}};

        foreach(int num in nums){
            store[num]++;
        }

         int index = 0;


        for(int i = 0 ; i <= 2 ; i++){
            int count = store[i];
            while(count > 0){
                nums[index] = i;
                index++;
                count--;
            }
        }


    }
}