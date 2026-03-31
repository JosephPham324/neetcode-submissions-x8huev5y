public class Solution {
    public bool IsAnagram(string s, string t) 
{
    // Optimization: If lengths differ, they cannot be anagrams
    if (s.Length != t.Length) return false;

    // Normalize case
    s = s.ToLower();
    t = t.ToLower();

    // Init array size 26 (C# int arrays default to 0)
    int[] count = new int[26];

    // Iterate first string
    foreach (var c in s)
    {
        // Safety check: ensure char is within 'a'-'z' range to prevent IndexOutOfRangeException
        if (c < 'a' || c > 'z') continue;

        int index = c - 'a';
        count[index]++; 
    } 

    // Iterate second string
    foreach (var c in t)
    {
        if (c < 'a' || c > 'z') continue;

        int index = c - 'a';
        count[index]--;
    }

    // Verify all counts are zero
    for (int i = 0; i < 26; i++)
    {
        if (count[i] != 0) 
        {
            return false;
        }
    }
    
    return true;
}
}
