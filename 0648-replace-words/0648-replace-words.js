/**
 * @param {string[]} dictionary
 * @param {string} sentence
 * @return {string}
 */
var replaceWords = function(dictionary, sentence) {
    let splittedString = sentence.split(" ")
    dictionary.sort((a,b) => a.length - b.length)
    for(i=0;i<splittedString.length;i++){
        for(let prefix of dictionary){
        if(splittedString[i].startsWith(prefix)){
            splittedString[i] = prefix
        }
        }
    }
    return splittedString.join(" ")
};