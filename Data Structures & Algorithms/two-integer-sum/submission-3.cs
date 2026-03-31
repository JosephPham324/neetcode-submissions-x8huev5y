public class Solution {
   		public int[] TwoSum(int[] nums, int target)
		{
			Dictionary<int, int> map = new Dictionary<int, int>(); // (value, index)

			for (int i = 0; i < nums.Length; i++)
			{
				map[nums[i]] = i; // latest index of the value
			}

			for (int i = 0; i < nums.Length; i++)
			{
				int difference = target - nums[i];
				if (map.ContainsKey(difference) && map[difference] != i)
					return new int[] { i, map[difference] };
			}

			return Array.Empty<int>();
		}

}
