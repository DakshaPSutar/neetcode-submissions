public class Solution {
    public bool IsPalindrome(string s) {
            char[] insArray = s.ToLower().Where(char.IsLetterOrDigit).ToArray(); 
            char[] revArray = new char[s.Length];

            //insArray = s.ToCharArray();

            if (insArray.SequenceEqual(insArray.Reverse()))
                return true;
            return false;
    }
}
