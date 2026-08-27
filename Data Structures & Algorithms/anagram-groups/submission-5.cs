public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string,List<string>> dc = new Dictionary<string,List<string>>();
        foreach(string str in strs){
            char[] chars = str.ToCharArray();
            Array.Sort(chars);
            string dcKey = new string(chars);
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
