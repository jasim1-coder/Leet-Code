/**
 * @param {number[]} nums
 * @return {number}
 */
var findMaxConsecutiveOnes = function(nums) {
    let current = 0;
    let max = 0;
    for(let i = 0;i<nums.length;i++){
        if (nums[i] === 1){
             current += 1
        }else {
            max = Math.max(current,max)
            current = 0
        }
    }
    max = Math.max(current,max)
    return max
};