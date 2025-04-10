public class Solution {
    public string GenerateTheString(int n) {
       string s = new string('x',n-1); 
       s += n%2 == 0 ? 'y' : 'x';
       return s;
    }
}