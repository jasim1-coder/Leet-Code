/**
 * @param {number[]} nums1
 * @param {number[]} nums2
 * @return {number[]}
 */
var intersection = function(nums1, nums2) {
    let result = [...nums1, ...nums2]
    let newresult = []
    let ans = result.filter((items) => {
        if(newresult.includes(items) == false){
    if(nums1.includes(items) && nums2.includes(items)){
        newresult.push(items)
    }

        }
    }
    )
return newresult
};