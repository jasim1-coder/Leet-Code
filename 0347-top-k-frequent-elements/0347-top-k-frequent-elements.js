/**
 * @param {number[]} nums
 * @param {number} k
 * @return {number[]}
 */
var topKFrequent = function(nums, k) {

    let frequencey = new Map()
    nums.forEach((num) => {
        frequencey.set(num, (frequencey.get(num)|| 0)+1)
    })
    let sorted = [...frequencey.entries()].sort((a, b) => b[1] - a[1]);
    return sorted.slice(0, k).map(([key, value]) => key);
};