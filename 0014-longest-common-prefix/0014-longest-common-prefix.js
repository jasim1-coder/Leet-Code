/**
 * @param {string[]} strs
 * @return {string}
 */
var longestCommonPrefix = function(strs) {
    if(strs.length === 0 ){
        return ""
    }
    return strs.reduce((prefix,current) => {
        while(!current.startsWith(prefix)){
            prefix = prefix.slice(0,-1)
        }
            return prefix

    },strs[0])
};