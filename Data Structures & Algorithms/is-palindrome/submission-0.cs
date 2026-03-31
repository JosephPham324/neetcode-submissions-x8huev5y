public class Solution {
    public bool IsPalindrome(string s) {
      s = s.ToLower();
s = Regex.Replace(s, @"[^\w]", "");
Console.WriteLine(s);
int left = 0;
int right = s.Length - 1;
while (left < right) { 
	if (s[left] != s[right])
	{
		return false;
	}
	left++;
	right--;
}
return true;
    }
}
