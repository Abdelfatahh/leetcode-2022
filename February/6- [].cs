public class Solution {
    public int RemoveDuplicates(int[] nums) {
        var n = nums.Length;

        if (n <= 2) return nums.Length;

        var left = 1;
        var count = 1;
        for (int i = 1; i < n; i++) {
            if (nums[i - 1] == nums[i]) {
                count++;

                if (count <= 2) {
                    nums[left] = nums[i];
                    left++;
                }
            } else {
                count = 1;
                nums[left] = nums[i];
                left++;
            }
        }

        return left;
    }
}