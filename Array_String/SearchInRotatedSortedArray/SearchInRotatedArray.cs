namespace SearchInRotatedSortedArray
{
    internal static class SearchInRotatedArray
    {
        public static int Search(int[] nums, int target)
        {
            int pos = -1;
            int len = nums.Length;
            int low = 0, high = len - 1;

            while(low <= high)
            {
                int mid = low + (high - low) / 2;

                if(nums[mid] == target)
                {
                    pos = mid;
                    break;
                }
                //left side sorted
                else if(nums[mid] >= nums[low])
                {
                    if(target >= nums[low] && target < nums[mid])
                    {
                        high = mid - 1;
                    }
                    else
                    {
                        low = mid + 1;
                    }
                }

                //right side sorted
                else if (nums[mid] <= nums[high])
                {
                    if(target <= nums[high] && target > nums[mid])
                    {
                        low = mid + 1;
                    }
                    else
                    {
                        high = mid - 1;
                    }
                }


            }
            return pos;
        }
    }
}
