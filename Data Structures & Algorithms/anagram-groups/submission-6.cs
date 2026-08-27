public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string,List<string>> dc = new Dictionary<string,List<string>>();
        foreach(string str in strs){
            char[] count = new char[26];
            foreach(char character in str){
                count[character - 'a']++;
            }
            string dcKey = new string(count);
            if(!dc.ContainsKey(dcKey)){
                dc[dcKey] = new List<string>();
            }
            dc[dcKey].Add(str);
        }
        List<List<string>> result = new List<List<string>>();
        foreach(var key in dc.Keys){
            result.Add(dc[key]);
        }

        return result;   
    }
}
