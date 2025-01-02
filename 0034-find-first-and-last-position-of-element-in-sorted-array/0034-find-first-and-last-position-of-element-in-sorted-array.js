/**
 * @param {number[]} nums
 * @param {number} target
 * @return {number[]}
 */
var searchRange = function(nums, target) {
    let num1 = nums.indexOf(target)
    let num2 = nums.lastIndexOf(target)
    let resutl = [-1,-1]
    if(num1 === -1){
        return resutl
    }else {
        return [num1,num2]
    }

};