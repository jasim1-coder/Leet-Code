/**
 * @param {string} s
 * @return {string}
 */
var reverseWords = function(s) {
    let splitted = s.split(" ")
    let result = splitted.map((item) => item.split("").reverse().join(""))
    return result.join(" ")
};