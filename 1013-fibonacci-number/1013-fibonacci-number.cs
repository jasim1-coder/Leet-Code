public class Solution {
    public int Fib(int n) {
        if(n <= 1) return n;
        int last = Fib( n - 1);
        int slast = Fib( n - 2);
        return last + slast;
    }
}