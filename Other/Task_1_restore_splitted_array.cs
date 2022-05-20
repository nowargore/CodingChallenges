using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Other
{
    /// <summary>
    /// There is a sorted array of integers nums that was randomly splitted into 2 chuncks which were swaped and then concat to new array.
    /// The resulting array is given.
    /// You should restore the original array amd return it as answer.
    /// 
    /// Example 1:
    /// Input: nums = [15,56,1,7,9]
    /// Output: [1,7,9,15,56]
    /// 
    /// Example 2:
    /// Input: nums = [2,3,4]
    /// Output: [2,3,4]
    /// 
    /// Example 3:
    /// Input: nums = [5,3]
    /// Output: [3,5]
    /// </summary>
    public class Task_1_restore_splitted_array
    {
        public static int[] RestoreSplittedArray(int[] nums)
        {
            var split = FindSplitIndex(nums, 0, nums.Length - 1);

            var restored = new int[nums.Length];

            nums[0..(split + 1)].CopyTo(restored, nums.Length - split - 1);
            nums[(split + 1)..].CopyTo(restored, 0);

            return restored;
        }

        private static int FindSplitIndex(int[] nums, int start, int end)
        {
            int median = (start + end)/2;

            if (start == median)
            {
                // Split not found, one of the splitted chuncks has 0 length.
                // The END value is the last index of array.
                // Restored array will be [0..end] + [empty array]
                if (nums[start] < nums[end])
                {
                    return end;
                }

                // The START value is the last index of splitted chunk,
                // the END value is first index of another splitted chunk.
                // Restored array will be [end..] + [0..start]
                return start;
            }

            if (nums[start] >= nums[median])
            {
                // Go to left halh
                return FindSplitIndex(nums, start, median);
            }
            else
            {
                // Go to right half
                return FindSplitIndex(nums, median, end);
            }
        }
    }
}
