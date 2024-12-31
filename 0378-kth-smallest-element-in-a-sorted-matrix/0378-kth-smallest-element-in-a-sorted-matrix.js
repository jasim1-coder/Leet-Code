/**
 * @param {number[][]} matrix
 * @param {number} k
 * @return {number}
 */
var kthSmallest = function(matrix, k) {
    let flatted = matrix.flat()
    let sorted = flatted.sort((a,b) => a-b)
    return sorted[k-1]
};