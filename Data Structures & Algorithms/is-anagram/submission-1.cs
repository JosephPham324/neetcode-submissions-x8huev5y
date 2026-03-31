public class Solution {
    public bool IsAnagram(string s, string t) {
Dictionary<char, int> anagramCheck = new Dictionary<char, int>();
foreach(char c in s)
{
	anagramCheck[c] = anagramCheck.GetValueOrDefault(c, 0) + 1;
}
foreach (char c in t)
{
	if (!anagramCheck.ContainsKey(c))
	{
		return false;
	}
	anagramCheck[c]--;
	if (anagramCheck[c] == 0)
	{
		anagramCheck.Remove(c);
	}
}
return anagramCheck.Count == 0;
    }
}
