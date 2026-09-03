public class Solution {
    public bool IsPalindrome(string s) {
        string a = Regex.Replace(s, @"[^a-zA-Z0-9]", "");
        a = a.ToLower().Replace(" ",string.Empty);
        int id = a.Length - 1;
        int idj = a.Length/2;
        for(int i = 0 ; i < a.Length ; i++){
            if(i == idj  ) return true;
            else if(a[i] != a[id]) return false;
            id -= 1;
        }
        return true;
    }
}