using System;
namespace HomeWork6
{
    public class Solution2
    {
        public int[] SortArrayByParity(int[] nums)
        {
            int lenNums = nums.Length;
            List<int> output = new List<int>();

            for (int i = 0; i < lenNums; i++)
            {
                if (nums[i] % 2 == 0)
                {
                    output.Add(nums[i]);
                }
            }

            for (int i = 0; i < lenNums; i++)
            {
                if (nums[i] % 2 != 0)
                {
                    output.Add(nums[i]);
                }
            }

            return output.ToArray();
        }
    }

}

