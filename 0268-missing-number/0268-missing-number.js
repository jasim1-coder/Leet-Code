/**
 * @param {number[]} nums
 * @return {number}
 */
var missingNumber = function(nums) {
    let num = 0
    for(i=0;i<=nums.length;i++){
        if(!nums.includes(i)){
            num += i
        }
    }
    return num
};