/**
 * @param {string} s
 * @return {number}
 */
var firstUniqChar = function(s) {
        let array =[]

   for(let i = 0;i<s.length;i++){
    if(s.indexOf(s[i]) === s.lastIndexOf(s[i])){
        array.push(s[i])
        return i
    }
   }
   if(array.length == 0){
    return -1
   }
};
console.log(firstUniqChar("leetcode"))