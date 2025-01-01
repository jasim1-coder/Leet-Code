/**
 * @param {number[]} nums
 * @return {number}
 */
var singleNumber = function(nums) {
    let num = nums.filter((item)=>
    nums.indexOf(item) ===  nums.lastIndexOf(item)
    )
    return num[0]
};