// Solution 1: HashMap

// We need to find 2 numbers a, b so that a + b = target.
// We need a HashMap datastructure to store elements in the past, let name it seen.
// The idea is that we iterate b as each element in nums, we check if we found a (where a = target - b) in the past.
// If a exists in seen then we already found 2 numbers a and b, so that a + b = target, just output their indices.
// Else add b to the seen.

public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        // Stores value, index
        Dictionary<int, int> dict = new Dictionary<int, int>();
        int[] result = new int[2];

        for (int i = 0; i < nums.Length; ++i)
        {
            int b = nums[i];
            int a = target - b;
            if (dict.ContainsKey(a))
            {
                result[0] = dict[a];
                result[1] = i;
            }
            else
                dict[b] = i;
        }

        return result;
    }
}