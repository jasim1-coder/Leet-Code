/**
 * @param {number[]} nums
 * @return {number}
 */
var singleNumber = function(nums) {
    let result = 0;
    for (let num of nums) {
        result ^= num; // XOR each number with the result
    }
    return result;
};