/**
 * @param {number} x
 * @return {number}
 */
var sumOfTheDigitsOfHarshadNumber = function(x) {
   let splitted = x.toString().split("")
let sum = splitted.reduce((acc,element) => (acc + Number(element)),0)
if(x % sum == 0){
    return sum
}else{
    return -1
}
};