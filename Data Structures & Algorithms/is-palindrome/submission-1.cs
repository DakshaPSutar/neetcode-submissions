public class Solution {
    public bool IsPalindrome(string s) {
            char[] insArray = s.ToLower().Where(char.IsLetterOrDigit).ToArray(); 
            
            if (insArray.SequenceEqual(insArray.Reverse()))
                return true;
            return false;
    }
}
