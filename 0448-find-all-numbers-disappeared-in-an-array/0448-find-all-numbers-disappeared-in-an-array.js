/**
 * @param {number[]} nums
 * @return {number[]}
 */
// var findDisappearedNumbers = function(nums) {
//     let newarray = []
//     for(i=1;i<=nums.length;i++){
//         if(nums.includes(i) == false)
//             {newarray.push(i)}
//         }
//             return newarray
//     }

var findDisappearedNumbers = function(nums) {
    const n = nums.length;
    const numSet = new Set(nums); 
    return Array.from({ length: n }, (_, i) => i + 1).filter(num => !numSet.has(num));
};

