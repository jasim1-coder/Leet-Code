/**
 * @param {number[]} nums
 * @return {boolean}
 */
var containsDuplicate = function(nums) {
    // let unique = nums.filter((num,index,arr) => 
    //     (arr.indexOf(num) === index )
    // )
    // if(unique.size !== nums.length){
    //     return true
    // }
    // else{
    //     return false
    // }


    let unique =new Set(nums)
    return unique.size !== nums.length
};
console.log(containsDuplicate([1,2,3]))