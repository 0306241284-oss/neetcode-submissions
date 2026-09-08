public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int prod = 1;
        int[] allZero = new int[nums.Length];
        int count = 0;
        int[] res = new int[nums.Length];
        foreach(int num in nums){
            if(num == 0) count++;
            else prod *= num;
        }
        if(count > 1){
            for(int i = 0; i < nums.Length;i++){
                allZero[i] = 0;
            }
            return allZero;
        }
        if(count == 1){
            for(int i = 0; i < res.Length ; i++){
                if(nums[i] != 0 ) res[i] = 0;
                else res[i] = prod;
            }
            return res;
        }
        for(int i = 0 ; i < res.Length; i++){
            res[i] = prod / nums[i];
        }
        return res;   
    }
}