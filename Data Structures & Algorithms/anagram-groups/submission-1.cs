public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs)
{
	Dictionary<Dictionary<char, int>, List<string>> groupAnagrams = new Dictionary<Dictionary<char, int>, List<string>>();

	foreach (string str in strs)
	{
		Dictionary<char, int> anagramCheck = new Dictionary<char, int>();
		foreach (char c in str)
		{
			anagramCheck[c] = anagramCheck.GetValueOrDefault(c, 0) + 1;
		}
		bool found = false;
		foreach (var kvp in groupAnagrams)
		{
			if (AreDictionariesEqual(kvp.Key, anagramCheck))
			{
				found = true;
				kvp.Value.Add(str);
			}
			
		}
		if (found == false)
		{
			groupAnagrams[anagramCheck] = new List<string>();
			groupAnagrams[anagramCheck].Add(str);
		}
		else
		{

		}
	}
	return groupAnagrams.Values.ToList();
}

static bool AreDictionariesEqual(Dictionary<char, int> dict1, Dictionary<char, int> dict2)
{
	// Check if they have the same number of entries
	if (dict1.Count != dict2.Count)
		return false;

	// Check if all key-value pairs match
	foreach (var kvp in dict1)
	{
		if (!dict2.TryGetValue(kvp.Key, out int value) || value != kvp.Value)
			return false;
	}

	return true;
}
}
