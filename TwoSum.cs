using System;
namespace HomeWork6
{
    public class Solution3
    {
        public int[] TwoSum(int[] nums, int target)
        {
            int lengthNum = nums.Length;
            for (int i = 0; i < lengthNum; i++)
            {
                for (int j = i + 1; j < lengthNum; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        return new int[] { i, j };
                    }
                }
            }
            return new int[] { }; 
        }
    }

}

