public class Solution {
    public int LongestConsecutive(int[] nums) {
       int longest = 0;
       HashSet<int> hs = new HashSet<int>(nums);
       foreach(var num in hs){
        if(!hs.Contains(num - 1)){
            int length = 1;
            while(hs.Contains(num + length)) length++;
            longest = Math.Max(longest, length);
        }
       }
       return longest;
    }
}
