public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length) return false;
        Dictionary<char,int> chuVaSoLuong = new Dictionary<char,int>();
        foreach(char i in s.ToCharArray()){
            if(!chuVaSoLuong.ContainsKey(i)) chuVaSoLuong.Add(i,1);
            else chuVaSoLuong[i] += 1;
        }
        foreach(char i in t.ToCharArray()){
        if(chuVaSoLuong.ContainsKey(i)) chuVaSoLuong[i] -= 1;
        }
        foreach(char key in chuVaSoLuong.Keys){
            if(chuVaSoLuong[key] > 0) return false;
        }
        return true ;
    }
}
