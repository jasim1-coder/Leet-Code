public class Solution {
    public string WinningPlayer(int x, int y) {
        int maxMoves = Math.Min(x, y / 4);
        return maxMoves % 2 == 1 ? "Alice" : "Bob";

    }
}