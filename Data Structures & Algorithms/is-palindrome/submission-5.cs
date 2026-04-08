public class Solution {
    public bool IsPalindrome(string s) {
        s = s.ToLower();
        int l = 0, r = s.Length - 1;
        while (l < r){
            while (l < s.Length - 1 && Char.IsLetterOrDigit(s[l]) == false) l++;
            
            while (r >= 0 && Char.IsLetterOrDigit(s[r]) == false) r--;
            
            if (l > s.Length - 1 || r < 0) return true;

            if (s[l] != s[r]) return false;
            l++;
            r--;
        }
        return true;
    }
}
