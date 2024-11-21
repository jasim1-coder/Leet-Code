/**
 * @param {string} s
 * @return {boolean}
 */
var isPalindrome = function(s) {
    let c = s.replace(/[^a-zA-Z0-9]/g,"").toLowerCase()
    let d = c.split("").reverse().join("")
    return c === d

    };
    // let a = s.split("").join("").replaceAll(",","")
    // let b = a.replaceAll(" ","")
    // let c = b.replaceAll(":","").toLowerCase()
    // let d = c.split("").reverse().join("")
    // if(c === d) {
    //     return true
    // }
    
