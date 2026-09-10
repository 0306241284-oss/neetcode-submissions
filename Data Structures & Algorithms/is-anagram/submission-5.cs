public class Solution {
    public bool IsAnagram(string s, string t) {
     int[] check = new int[26];
     if(s.Length != t.Length) return false;
     for(int i = 0; i < s.Length ; i++){
        check[s[i]-'a']++;
        check[t[i]-'a']--;
     }
     foreach(int num in check ){
        if(num != 0) return false;
     }
     return true;
    }
}
