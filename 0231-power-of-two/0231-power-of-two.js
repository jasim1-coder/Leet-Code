/**
 * @param {number} n
 * @return {boolean}
 */
var isPowerOfTwo = function(n) {
    // if( n == 1 || n%2 == 0 ){
    //     return true
    // }else{
    //     return false
    // }


    // if(Math.sqrt(n)%2 == 0 || n == 1 ){
    //     return true
    // }else{
    //   return  false
    // }

        return n > 0 && (n & (n - 1)) === 0;


};