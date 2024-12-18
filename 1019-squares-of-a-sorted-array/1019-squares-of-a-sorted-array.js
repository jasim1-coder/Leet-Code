/**
 * @param {number[]} nums
 * @return {number[]}
 */
var sortedSquares = function(nums) {
        const squared = nums.map(num => num ** 2);
    squared.sort((a, b) => a - b);
    return squared;
};