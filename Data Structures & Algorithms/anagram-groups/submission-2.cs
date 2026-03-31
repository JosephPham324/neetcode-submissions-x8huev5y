public class Solution {

    class IntArrayComparer : IEqualityComparer<int[]>
{
    public bool Equals(int[] a, int[] b)
    {
        if (ReferenceEquals(a, b)) return true;
        if (a == null || b == null || a.Length != b.Length) return false;

        for (int i = 0; i < a.Length; i++)
            if (a[i] != b[i]) return false;

        return true;
    }

    public int GetHashCode(int[] arr)
    {
        unchecked
        {
            int hash = 17;
            for (int i = 0; i < arr.Length; i++)
                hash = hash * 31 + arr[i];
            return hash;
        }
    }
}
   public List<List<string>> GroupAnagrams(string[] strs)
{
    var groups = new Dictionary<int[], List<string>>(new IntArrayComparer());
    // key: frequency of letters, value: grouped strings

    foreach (string s in strs)
    {
        string str = s.ToLower();

        int[] key = new int[26];

        foreach (char c in str)
        {
            int index = c - 'a';
            key[index]++;
        }

        if (groups.ContainsKey(key))
        {
            groups[key].Add(str);
        }
        else
        {
            groups[key] = new List<string> { str };
        }
    }

    List<List<string>> res = new List<List<string>>();
    foreach (var group in groups.Values)
        res.Add(group);

    return res;
}
}
