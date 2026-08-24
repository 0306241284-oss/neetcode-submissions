class Solution {
public:
    vector<int> topKFrequent(vector<int>& nums, int k) {
        unordered_map<int,int>check;
        for(auto x :nums) check[x]++;
        int nsize=nums.size();
        vector<vector<int>> bucket(nsize+1);
        for(auto &a: check) bucket[a.second].push_back(a.first);
        vector<int> result;
        for(int i = nsize;i>=0 && result.size() < k;i--){
            for(int x : bucket[i]){
                result.push_back(x);
                if(result.size()==k) break;
            }
        }
        return result;
        
    }
};
