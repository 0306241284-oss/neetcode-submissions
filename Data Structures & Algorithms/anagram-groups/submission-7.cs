public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string,List<string>> dc = new Dictionary<string,List<string>>();
        foreach(string str in strs){
            char[] count = new char[26];
            foreach(char character in str){
                count[character - 'a']++;
            }
            string dcKey = new string(count);
            if(!dc.TryGetValue(dcKey,out var list)){
                list = new List<string>();
                dc[dcKey] = list;
            }
            dc[dcKey].Add(str);
        }
        return new List<List<string>>(dc.Values); 
    }
}
