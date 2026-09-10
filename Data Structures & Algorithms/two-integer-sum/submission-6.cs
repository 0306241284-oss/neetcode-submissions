public class Solution {
    public int[] TwoSum(int[] nums, int target) {
    Dictionary<int,int> dc = new Dictionary<int,int>();
    for(int i = 0 ; i < nums.Length ; i++){
        int result = target - nums[i];
        if(!dc.TryGetValue(result, out int key)){
            dc[nums[i]] = i; 
        }else{
            return [key,i];
        }
    }
    return [];
    }
}
