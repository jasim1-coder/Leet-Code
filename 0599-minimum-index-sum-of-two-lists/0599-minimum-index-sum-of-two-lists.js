/**
 * @param {string[]} list1
 * @param {string[]} list2
 * @return {string[]}
 */
var findRestaurant = function(list1, list2) {
    let newarray = [...list1,...list2];
    console.log(newarray);
    let unique = newarray.filter((item) => (newarray.indexOf(item) != newarray.lastIndexOf(item)));
    let result = [unique[0]];
    let newresult = []
   for(i=1;i<unique.length;i++){
    if(newarray.indexOf(unique[i]) + newarray.lastIndexOf(unique[i]) <= newarray.indexOf(result[0]) + newarray.lastIndexOf(result[0])){
        result[0] = unique[i]
        newresult.push(unique[i])
    }
   }
   let final = [...new Set(newresult)]
   return final;

};