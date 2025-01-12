public class Solution {
    public bool ArrayStringsAreEqual(string[] word1, string[] word2) {
        string new1 = string.Join("",word1);
        string new2 =string.Join("",word2);
        bool result = new1 == new2;

    return result;


    }
}