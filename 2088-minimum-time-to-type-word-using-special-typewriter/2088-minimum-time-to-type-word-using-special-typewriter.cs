public class Solution {
    public int MinTimeToType(string word) {
        // string str = "nopqrstuvwxyzabcdefghijklm";
        // int result = 0 ;
        // for(int i = 0 ; i < word.Length ; i++){
        //     if(str.IndexOf(word[i]) == 13 && str.IndexOf(word[i]) == 14 ){
        //         result = result + 1;
        //     }else if(str.IndexOf(word[i]) <= 12){
        //         result = result + (13 - str.IndexOf(word[i]));
        //     }else{
        //         result = result + (str.IndexOf(word[i]) - 14);
        //     }

        // }
        // return result;

  
        int time = 0;
        char currentChar = 'a';  // Start from 'a'

        foreach (char targetChar in word) {
            int forwardSteps = Math.Abs(targetChar - currentChar);  // Clockwise distance
            int backwardSteps = 26 - forwardSteps;  // Counterclockwise distance
            
            time += Math.Min(forwardSteps, backwardSteps) + 1;  // Move and type

            currentChar = targetChar;  // Update the current position
        }

        return time;
    }
}

