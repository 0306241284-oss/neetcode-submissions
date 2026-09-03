public class Solution {
    public bool IsPalindrome(string s) {
        string a = Regex.Replace(s, @"[^a-zA-Z0-9]", "").ToLower();
        int id = a.Length - 1;
        int idj = a.Length/2;
        for(int i = 0 ; i < id ; i++){
         if(a[i] != a[id]) return false;
            id--;
        }
        return true;
    }
}