/**
 * @param {number[]} nums
 * @return {void} Do not return anything, modify nums in-place instead.
 */
var moveZeroes = function(nums) {
    let result = 0
for(let i=0;i<nums.length;i++){
    if(nums[i] !== 0){
    nums[result] = nums[i]
    result++
    }
}
for(i=result;i<nums.length;i++){
    nums[i] = 0
}
};