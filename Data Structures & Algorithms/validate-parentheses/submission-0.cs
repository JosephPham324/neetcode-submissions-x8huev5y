public class Solution {
    public bool IsValid(string s) {
        string left = "{[(";
        Dictionary<char,char> match = new Dictionary<char,char>();
        match.Add('}', '{');
        match.Add(')', '(');
        match.Add(']', '[');
        Stack<char> stack = new Stack<char>();
        foreach(char c in s){
            if (left.Contains(c)) {
                stack.Push(c);
            } else {
                if (stack.Count == 0){

                    // Console.WriteLine($"{c}: here");
                    return false; //Nothing to match -> invalid
                } 
                // Console.WrkkiteLine("here!");

                if (stack.Pop() != match[c]) return false;
            }
        }
        // Console.WritekLine("here!!");

        return stack.Count == 0;
    }
}
