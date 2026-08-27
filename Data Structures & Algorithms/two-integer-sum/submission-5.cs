public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int,int> dc = new Dictionary<int,int>();
        for(int i = 0 ; i < nums.Length; i++){
            if(!dc.ContainsKey(target - nums[i])) dc.Add(nums[i],i);
            else return [dc[target - nums[i]], i];
        }
        return [];
    }
}
