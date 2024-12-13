/**
 * @param {string} s
 * @return {number}
 */
var countSegments = function(s) {
    if(s)
    {
        let splitted = s.split(" ").filter((item) => {
            return item.length >= 1
        })
        return splitted.length
    }
    else{
        return 0
    }
};