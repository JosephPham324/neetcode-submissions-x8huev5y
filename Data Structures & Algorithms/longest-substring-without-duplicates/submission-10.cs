public class Solution {
    public int LengthOfLongestSubstring(string s) {
        Dictionary<char, int> seen = new Dictionary<char,int>();
        int res = 0;
        int curLength = 0;
        int[] window = {0, 0};
        for (int i = 0; i < s.Length; i++){
            char ch = s[i];
            if (seen.ContainsKey(ch) && seen[ch] >= window[0]) { // if exists, update window                
                window[0] = seen[ch] + 1;
            } 
            seen[ch] = i;

            window[1] = i;
            curLength = window[1] - window[0] + 1;
            res = Math.Max(res,curLength); //check max against previous length
            Console.WriteLine(curLength + " " + ch);
        }
        return res;
    }
}
