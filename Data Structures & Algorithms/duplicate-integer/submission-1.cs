public class Solution {
    public bool hasDuplicate(int[] nums) {
        HashSet<int> val = new HashSet<int>();
			foreach (int i in nums)
			{
				if (val.Contains(i))
				{
					return true;
				}
				val.Add(i);
			}
			return false;
    }
}