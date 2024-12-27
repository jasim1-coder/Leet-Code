/**
 * @param {string} s
 * @return {number}
 */
function balancedStringSplit(s) {
    let count = 0; // To track balance between 'L' and 'R'
    let maxBalanced = 0; // To count the number of balanced substrings

    for (let char of s) {
        if (char === 'L') {
            count++;
        } else if (char === 'R') {
            count--;
        }

        if (count === 0) {
            maxBalanced++; // Found a balanced substring
        }
    }

    return maxBalanced;
}
