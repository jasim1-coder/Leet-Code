public class Solution {
    public bool IsValid(string s) {
        Stack<Char> stackstore = new Stack<Char>();

        foreach(Char ch in s){
            if(ch == '(' || ch == '{' || ch == '['){
                stackstore.Push(ch);
            }else{
                if(stackstore.Count() == 0)return false;
                Char currentchar = stackstore.Peek();
                if(currentchar == '(' && ch == ')' || currentchar == '[' && ch == ']' || currentchar == '{' && ch == '}'){
                    stackstore.Pop();
                }else{
                    return false;
                }
                
            }
        }
        int result = stackstore.Count();
        return result == 0;
    }
}