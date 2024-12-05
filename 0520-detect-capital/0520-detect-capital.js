/**
 * @param {string} word
 * @return {boolean}
 */
var detectCapitalUse = function(word) {
    let capital = word.toUpperCase()
    let small = word.toLowerCase()
    if(capital == word){
        return true
    }else if (small == word){
        return true
    }else if (word[0] == capital[0] && word.slice(1) === small.slice(1)){
        return true
    }else{
        return false
    }
};