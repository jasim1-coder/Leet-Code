/**
 * @param {number[]} nums
 * @return {number}
 */
var thirdMax = function(nums) {
    // let newsset =  new set(...nums)
    // console.log(newsset)
    let newset = []
    for(i=0;i<nums.length;i++){
        if(newset.indexOf(nums[i]) == -1){
            newset.push(nums[i])
        }
    }
    console.log(newset.sort((a,b) => a-b))
    // let sorted = nums.sort((a,b) => a-b)
    if(newset.length < 3){
        return newset[(newset.length)-1]
    }
    return newset[(newset.length)-3]
};