/**
 * @param {number[]} nums
 * @param {number} k
 * @return {number}
 */
var findKthLargest = function(nums, k) {
    let sorted = nums.sort((a,b) => a-b)
    let unique = [...new Set(sorted)]
    // // let result = unique[k-1]
    // console.log(sorted)
    // console.log(unique)
    return sorted[(sorted.length) - k]
};