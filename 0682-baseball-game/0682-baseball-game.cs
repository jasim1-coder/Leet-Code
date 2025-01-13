public class Solution {
    public int CalPoints(string[] operations) {
        List<int> items = new List<int>();
        for(int i = 0 ; i < operations.Length ; i++){
            if(operations[i] == "C" ){
                items.RemoveAt(items.Count -1);
            }else if(operations[i] == "D")
            {
                items.Add(2*items[items.Count -1]);
            }
            else if(operations[i] == "+"){
                items.Add(items[items.Count - 1] + items[items.Count - 2]);
            }
        else{
            items.Add(int.Parse(operations[i]));
        }

    }
    int result = items.Sum();
    return result;
}
}