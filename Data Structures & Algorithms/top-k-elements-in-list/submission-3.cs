public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int,int> dc = new Dictionary<int,int>();
        List<int>[] freg = new List<int>[nums.Length + 1];
        for(int i = 0; i < freg.Length; i++){
            freg[i] = new List<int>();
        }
        foreach(var key in nums){
            if(!dc.ContainsKey(key)) dc[key] = 1;
            else dc[key]++;
        }
        foreach(var entry in dc){
            freg[entry.Value].Add(entry.Key);
        }
        int[] res = new int[k];
        int index = 0;
        for(int i = freg.Length - 1; i > 0 && index < k; i-- ){
            foreach(var num in freg[i]){
                res[index++] = num;
                if(index == k) return res;
            }
        }
        return res;
}
}
