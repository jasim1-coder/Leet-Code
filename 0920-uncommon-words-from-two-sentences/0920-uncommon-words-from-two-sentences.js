/**
 * @param {string} s1
 * @param {string} s2
 * @return {string[]}
 */
var uncommonFromSentences = function(s1, s2) {
    let combined = s1.split(" ").concat(s2.split(" "))
    let newarray = combined.filter((item,index,arr) => 
        combined.indexOf(item) === combined.lastIndexOf(item)
    )
    return newarray
};