/**
 * @param {string} s
 * @return {string}
 */
var reverseVowels = function(s) {
let vowels = "aeiouAEIOU"
let reversed = s.split("")
    .filter((char) => vowels.includes(char))
    reversed.reverse()
    let index = 0;
    let result = s.split("").map((char) => {
        if(vowels.includes(char)){
            return reversed[index++]
        }else{
            return char
        }
    } )
    return result.join("")
};
console.log(reverseVowels("IceCreAm"));
