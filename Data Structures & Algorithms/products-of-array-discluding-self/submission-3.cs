public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int prod = 1;
        int count = 0;
        int[] res = new int[nums.Length];
        foreach(int num in nums){
            if(num == 0) count++;
            else prod *= num;
        }
        for(int i = 0 ; i < res.Length; i++){
            if(count == 1){
                if(nums[i] != 0 ) res[i] = 0;
                else res[i] = prod;
            }else if(count > 1){
                res[i] = 0;
            }
            else res[i] = prod / nums[i];
        }
            return res;
        }
    }