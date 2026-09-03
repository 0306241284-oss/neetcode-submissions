public class Solution {
    public bool IsPalindrome(string s) {
        s = s.ToLower();
        int l = 0, r = s.Length - 1;
        while(l < r){
            while(!Char.IsLetterOrDigit(s[l]) && l < r) l++;
            while(!Char.IsLetterOrDigit(s[r]) && l < r) r--;
            if(s[l] != s[r]) return false;
            l++;
            r--;
        }
        return true;
    }
}